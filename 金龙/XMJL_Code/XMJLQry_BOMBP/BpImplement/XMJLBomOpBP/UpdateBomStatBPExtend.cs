namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFSoft.UBF.Business;

    /// <summary>
    /// UpdateBomStatBP partial 
    /// </summary>	
    public partial class UpdateBomStatBP
    {
        internal BaseStrategy Select()
        {
            return new UpdateBomStatBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpdateBomStatBPImpementStrategy : BaseStrategy
    {
        public UpdateBomStatBPImpementStrategy() { }

        public override object Do(object obj)
        {
            UpdateBomStatBP bpObj = (UpdateBomStatBP)obj;
            ReturnUpDTO result = new ReturnUpDTO();
            result.Msg = "";
            //var bomMainList = Cust_Xmjl_MO_BomMain.Finder.FindAll(bpObj.OPath, null);
            //List<string> ids = new List<string>();
            //foreach (var item in bomMainList)
            //{
            //    ids.Add(item.ID.ToString());
            //}
            //var bomHeadList = OQlAnalysis.GetBomHeadData(bpObj.OPath, string.Join(",", ids.ToArray()));
            var bomHeadList = Cust_Xmjl_MO_BomHead.Finder.FindAll("ID in ("+bpObj.OPath+")", null);
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
                    if (item.DisbursedQty != 0 || !string.IsNullOrEmpty(item.Memo))
                    {
                        if (result.Msg.Length < 100)
                        {
                            result.Msg += "单号：" + item.Cust_Xmjl_MO_BomMain.DocNo
                         + ",行号：" + item.RowNo + "已发料数量不等于0或备注不为空";
                            result.Status = "0";
                        }
                    }
                    else
                    {
                        item.Status = BomHeadStatus.Closed;
                    }
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