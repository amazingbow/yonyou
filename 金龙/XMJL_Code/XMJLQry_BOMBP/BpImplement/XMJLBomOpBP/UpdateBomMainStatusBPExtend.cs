namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.Base.FlexField.ValueSet;

    /// <summary>
    /// UpdateBomMainStatusBP partial 
    /// </summary>	
    public partial class UpdateBomMainStatusBP
    {
        internal BaseStrategy Select()
        {
            return new UpdateBomMainStatusBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpdateBomMainStatusBPImpementStrategy : BaseStrategy
    {
        public UpdateBomMainStatusBPImpementStrategy() { }

        public override object Do(object obj)
        {
            UpdateBomMainStatusBP bpObj = (UpdateBomMainStatusBP)obj;
            var returnstr = string.Empty;
            var data = bpObj.ManufactureNoList;
            if (data.Count == 0) return null;
            string manufactureNos = string.Join(",", bpObj.ManufactureNoList.ToArray());
            var bomMainlist = Cust_Xmjl_MO_BomMain.Finder.FindAll("ManufactureNo in (" + manufactureNos + ") and DisburseType=" + bpObj.DisburseType +
                " and Status=1 and DescFlexField.PrivateDescSeg2='True' and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID, null);

            if (bomMainlist == null) return null;
            var operators = UFIDA.U9.CBO.HR.Operator.Operators.Finder.Find("Name='" + UFIDA.U9.Base.Context.LoginUser + "' and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID, null);
            string maxSerialNumber = "0";

            System.Data.DataSet ds = new System.Data.DataSet();
            DataAccessor.RunSQL(DataAccessor.GetConn(), "select max(right(DescFlexField_PrivateDescSeg1,12)) as maxSerialNumber from Cust_Xmjl_MO_BomMain", null, out ds);

            if (ds != null && ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["maxSerialNumber"].ToString() != "")
                {
                    maxSerialNumber = ds.Tables[0].Rows[0]["maxSerialNumber"].ToString();
                }
            }

            using (ISession session = Session.Open())
            {
                foreach (var bomMain in bomMainlist)
                {
                    bomMain.Status = BomMainStatusEnum.Disbursed;
                    if (bomMain.DisburseType == BomMainType.Batch)
                    {
                        bomMain.DescFlexField.PrivateDescSeg1 = "PDL" + GetSerialNumber(maxSerialNumber);
                    }
                    else if (bomMain.DisburseType == BomMainType.Rtn)
                    {
                        bomMain.DescFlexField.PrivateDescSeg1 = "TL" + GetSerialNumber(maxSerialNumber);
                    }
                    returnstr = bomMain.DescFlexField.PrivateDescSeg1;
                    bomMain.DescFlexField.PrivateDescSeg3 = bomMain.DescFlexField.PrivateDescSeg1;
                    bomMain.DisburseBY = operators;
                    bomMain.DisburseOn = DateTime.Now;
                    //Modify by 李杨 2016年7月21日17:12:35
                    //在值集档案中维护仓库对应的不发料料品，值集编码为仓库，值集值为料品；
                    //执行缺件调度时将需要执行缺件的数据与值集值进行比较，相同的则将该缺件行关闭，不同的则执行缺件调度
                    foreach (var bomHead in bomMain.Cust_Xmjl_MO_BomHead)
                    {
                        if (bomHead.Status == BomHeadStatus.InitStat)
                        {
                            bomHead.Status = BomHeadStatus.PartDisburse;
                        }
                        var itemCode = bomHead.Item.Code;
                        ValueSetDef value = ValueSetDef.FindByCode(bomHead.WareHouse.Code);
                        if (value == null) continue;
                        if (value.CheckValue(itemCode))
                        {
                            bomHead.Status = BomHeadStatus.Closed;
                        }

                    }
                }
                session.Commit();
            }
            return returnstr;
        }

        public string GetSerialNumber(string serialNumber)
        {

            if (serialNumber != "0")
            {

                string headDate = serialNumber.Substring(0, 8);

                int lastNumber = int.Parse(serialNumber.Substring(8));

                //如果数据库最大值流水号中日期和生成日期在同一天，则顺序号加1

                if (headDate == DateTime.Now.ToString("yyyyMMdd"))
                {

                    lastNumber++;

                    return headDate + lastNumber.ToString("0000");

                }

            }

            return DateTime.Now.ToString("yyyyMMdd") + "0001";

        }
    }

    #endregion


}