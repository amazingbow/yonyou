namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.Warehouse;

    /// <summary>
    /// ResetBomWhBP partial 
    /// </summary>	
    public partial class ResetBomWhBP
    {
        internal BaseStrategy Select()
        {
            return new ResetBomWhBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ResetBomWhBPImpementStrategy : BaseStrategy
    {
        public ResetBomWhBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ResetBomWhBP bpObj = (ResetBomWhBP)obj;

            ReturnUpDTO result = new ReturnUpDTO();
            result.Msg = "";
            var bomMainList = Cust_Xmjl_MO_BomMain.Finder.FindAll(bpObj.OPath, null);
            List<string> ids = new List<string>();
            foreach (var item in bomMainList)
            {
                ids.Add(item.ID.ToString());
            }
            var bomHeadList = OQlAnalysis.GetBomHeadData(bpObj.OPath, string.Join(",", ids.ToArray()));
            if (bomHeadList == null)
            {
                result.Msg = "没有要更改的数据";
                result.Status = "0";
                return result;
            }
            using (ISession session = Session.Open())
            {
                foreach (var item in bomHeadList)
                {
                    if (result.Msg.Length < 100)
                    {
                        if (item.DisbursedQty == item.Qty)
                        {
                            result.Msg += item.Item.Name + ":已经发完料，不更新仓库！";
                            continue;
                        }
                        if (item.Status == BomHeadStatus.Closed)
                        {
                            result.Msg += item.Item.Name + ":已经关闭，不更新仓库！";
                            continue;
                        }
                    }
                    else
                    {
                        if (item.DisbursedQty == item.Qty) continue;
                        if (item.Status == BomHeadStatus.Closed) continue;
                    }

                    string whCode = "";
                    #region 取仓库
                    switch (item.Cust_Xmjl_MO_BomMain.ManufactureNo.Code.Substring(0, 1))
                    {
                        case "1":
                        case "Y":
                            {
                                if (item.WorkPlace.Trim().ToUpper() != "DP") { whCode = item.Item.DescFlexField.PrivateDescSeg2; }
                                else { whCode = item.Item.DescFlexField.PrivateDescSeg3; }; break;
                            }
                        case "3":
                        case "8":
                        case "S":
                            {
                                if (item.WorkPlace.Trim().ToUpper() != "DP") { whCode = item.Item.DescFlexField.PrivateDescSeg4; }
                                else { whCode = item.Item.DescFlexField.PrivateDescSeg5; }; break;
                            }
                        case "7":
                        case "Q":
                            {
                                if (item.WorkPlace.Trim().ToUpper() != "DP") { whCode = item.Item.DescFlexField.PrivateDescSeg6; }
                                else { whCode = item.Item.DescFlexField.PrivateDescSeg7; }; break;
                            }
                        case "2": whCode = item.Item.DescFlexField.PrivateDescSeg8; break;
                        case "4":
                        case "5":
                        case "C": whCode = item.Item.DescFlexField.PrivateDescSeg1; break;

                        default:
                            {
                                continue;
                            }
                    }
                    #endregion

                    item.WareHouse = Warehouse.Finder.Find(" code='" + whCode + "'");
                }
                session.Commit();
            }
            if (string.IsNullOrEmpty(result.Msg))
            {
                result.Msg = "更新成功！";
                result.Status = "1";
            }
            return result;
        }
    }

    #endregion


}