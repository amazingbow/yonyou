namespace UFIDA.U9.Cust.XMJL.ItemSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.InvTrans.WhQoh;

    /// <summary>
    /// QueryAllItemStore partial 
    /// </summary>	
    public partial class QueryAllItemStore
    {
        internal BaseStrategy Select()
        {
            return new QueryAllItemStoreImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryAllItemStoreImpementStrategy : BaseStrategy
    {
        public QueryAllItemStoreImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryAllItemStore bpObj = (QueryAllItemStore)obj;

            bool isSum = bpObj.IsSum;

            string oql = string.Empty;

            if (bpObj.ExcludeWHCode != null && bpObj.ExcludeWHCode.Count > 0)
                oql = @" Wh.Code not in (" + string.Join(",", bpObj.ExcludeWHCode) + ") and Wh.Org =" + Base.Context.LoginOrg.ID;

            WhQoh.EntityList list = WhQoh.Finder.FindAll(oql);

            List<ItemStoreDTO> result = new List<ItemStoreDTO>();
            if (isSum)
            {
                foreach (WhQoh whQoh in list)
                {
                    ItemStoreDTO dto;

                    dto = result.Find(delegate(ItemStoreDTO i) { return i.ItemCode == whQoh.ItemInfo.ItemCode && i.WHCode == whQoh.Wh.Code; });
                    if (dto == null)
                    {
                        dto = new ItemStoreDTO();
                        dto.ItemCode = whQoh.ItemInfo.ItemCode;
                        dto.ItemName = whQoh.ItemInfo.ItemName;
                        dto.UomCode = whQoh.StoreUOM.Code;
                        dto.UomName = whQoh.StoreUOM.Name;
                        dto.UomShortName = whQoh.StoreUOM.ShortName;
                        dto.WHCode = whQoh.Wh.Code;
                        dto.WHName = whQoh.Wh.Name;

                        result.Add(dto);
                    }
                    dto.StoreQty += whQoh.StoreQty;
                }
            }
            else
            {
                foreach (WhQoh whqoh in list)
                {
                    ItemStoreDTO dto = new ItemStoreDTO();
                    dto.ItemCode = whqoh.ItemInfo.ItemCode;
                    dto.ItemName = whqoh.ItemInfo.ItemName;
                    dto.UomCode = whqoh.StoreUOM.Code;
                    dto.UomName = whqoh.StoreUOM.Name;
                    dto.UomShortName = whqoh.StoreUOM.ShortName;
                    dto.WHCode = whqoh.Wh.Code;
                    dto.WHName = whqoh.Wh.Name;
                    dto.StoreQty = whqoh.StoreQty;

                    result.Add(dto);
                }
            }

            return result;
        }
    }

    #endregion


}