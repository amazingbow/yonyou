namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// GetItemMainSupBP partial 
    /// </summary>	
    public partial class GetItemMainSupBP
    {
        internal BaseStrategy Select()
        {
            return new GetItemMainSupBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetItemMainSupBPImpementStrategy : BaseStrategy
    {
        public GetItemMainSupBPImpementStrategy() { }

        public override object Do(object obj)
        {
            GetItemMainSupBP bpObj = (GetItemMainSupBP)obj;
            if (bpObj.ItemIds.Count == 0) return null;
            List<string> ids = new List<string>();
            foreach (var item in bpObj.ItemIds)
            {
                ids.Add(item.ToString());
            }
            List<ItemSupplyDTO> ItemSupplyList = new List<ItemSupplyDTO>();
            var itemMaster = ItemMaster.Finder.FindAll("ID in (" + string.Join(",", ids.ToArray()) + ")");
            foreach (var item in itemMaster)
            {
                if (item.PurchaseInfo == null || item.PurchaseInfo.Supplier == null) continue;
                ItemSupplyDTO data = new ItemSupplyDTO
                {
                    ItemId = item.ID,
                    Supply = item.PurchaseInfo.Supplier.ID,
                    SupplyCode = item.PurchaseInfo.Supplier.Code,
                    SupplyName = item.PurchaseInfo.Supplier.Name
                };
                ItemSupplyList.Add(data);
            }
            return ItemSupplyList;
        }
    }

    #endregion


}