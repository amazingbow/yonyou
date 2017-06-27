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
    /// UpdateBomWhBP partial 
    /// </summary>	
    public partial class UpdateBomWhBP
    {
        internal BaseStrategy Select()
        {
            return new UpdateBomWhBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpdateBomWhBPImpementStrategy : BaseStrategy
    {
        public UpdateBomWhBPImpementStrategy() { }

        public override object Do(object obj)
        {
            UpdateBomWhBP bpObj = (UpdateBomWhBP)obj;
            ReturnUpDTO result = new ReturnUpDTO();
            result.Msg = "";
            // (Cust_Xmjl_MO_BomHead.DisbursedQty > 0)  and  (Cust_Xmjl_MO_BomHead.Item.Code = N'0.75')  
            //and  (Cust_Xmjl_MO_BomHead.WareHouse.Code = N'13')  and  (Cust_Xmjl_MO_BomHead.Status = 1) 
            //and  (Cust_Xmjl_MO_BomHead.Qty = 0)  and  ( (CreatedOn>=@CreatedOn0_begin and CreatedOn<@CreatedOn0_end) )  
            //and  (CreatedBy = N'1')  and  ( (ModifiedOn>=@ModifiedOn2_begin and ModifiedOn<@ModifiedOn2_end) )  
            //and  (ManufactureNo.Code = N'1721031')  所有的查询条件
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

                    item.WareHouse = Warehouse.Finder.FindByID(bpObj.WareHouse);
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