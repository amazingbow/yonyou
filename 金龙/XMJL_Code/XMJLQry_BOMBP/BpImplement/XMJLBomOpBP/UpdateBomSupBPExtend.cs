namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.InvTrans.WhQoh;

    /// <summary>
    /// UpdateBomSupBP partial 
    /// </summary>	
    public partial class UpdateBomSupBP
    {
        internal BaseStrategy Select()
        {
            return new UpdateBomSupBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpdateBomSupBPImpementStrategy : BaseStrategy
    {
        public UpdateBomSupBPImpementStrategy() { }

        public override object Do(object obj)
        {
            UpdateBomSupBP bpObj = (UpdateBomSupBP)obj;
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
                    var whQoh = WhQoh.Finder.FindAll("ItemInfo.ItemID="
                    + item.Item.ID + " and Wh=" + item.WareHouse.ID, null);
                    //如果缺件表发料数量大于0的，取供应商的逻辑就是要判断现存量大于0的才取；
                    //如果缺件表发料数量小于0的，还是按现有的逻辑取
                    if (whQoh.Count == 1)//有多个供应商，或者没有供应商 都不更新
                    {
                        if (item.Supplier == null && whQoh[0].SupplierInfo.Supplier != null)
                        {
                            if (item.Qty > 0)
                            {
                                if (whQoh[0].StoreQty > 0)
                                {
                                    item.Supplier = whQoh[0].SupplierInfo.Supplier;
                                }
                            }
                            else
                            {
                                item.Supplier = whQoh[0].SupplierInfo.Supplier;
                            }
                        }
                    }
                    else if (whQoh.Count > 1)//有可能多个供应商是一样的
                    {
                        List<string> supList = new List<string>();
                        foreach (var wh in whQoh)
                        {
                            if (wh.SupplierInfo.Supplier != null)
                            {
                                supList.Add(wh.SupplierInfo.Supplier.ID.ToString());
                            }
                        }
                        if (supList.Count > 0)
                        {
                            var sup = Supplier.Finder.FindAll("ID in (" + string.Join(",", supList.ToArray()) + ")", null);
                            if (sup.Count == 1)//有多个供应商，或者没有供应商 都不更新
                            {
                                if (item.Qty > 0)
                                {
                                    if (whQoh[0].StoreQty > 0)
                                    {
                                        item.Supplier = whQoh[0].SupplierInfo.Supplier;
                                    }
                                }
                                else
                                {
                                    item.Supplier = sup[0];
                                }
                            }
                        }
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