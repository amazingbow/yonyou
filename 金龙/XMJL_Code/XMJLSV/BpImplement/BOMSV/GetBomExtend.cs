namespace UFIDA.U9.Cust.XMJL.BOMSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.InvTrans.Trans;
    using UFIDA.U9.CBO.SCM.Item;

    /// <summary>
    /// GetBom partial 
    /// </summary>	
    public partial class GetBom
    {
        internal BaseStrategy Select()
        {
            return new GetBomImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetBomImpementStrategy : BaseStrategy
    {
        public GetBomImpementStrategy() { }

        public override object Do(object obj)
        {
            GetBom bpObj = (GetBom)obj;
            string oql = @" DescFlexField.PrivateDescSeg1!='' and ModifiedOn>'" + bpObj.LastSynTimeStamp
                + "' and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID;

            TransLine.EntityList list = TransLine.Finder.FindAll(oql);
            if (list.Count == 0)
            {
                return null;
            }

            List<ProductBomDTO> listProductBom = new List<ProductBomDTO>();

            foreach (TransLine line in list)
            {
                ProductBomDTO productBom = listProductBom.Find(delegate(ProductBomDTO p) { return p.ManufactureNo == line.DescFlexField.PrivateDescSeg1; });
                if (productBom == null)
                {
                    productBom = new ProductBomDTO();
                    productBom.ManufactureNo = line.DescFlexField.PrivateDescSeg1;
                    productBom.Bom = new List<BomDTO>();

                    listProductBom.Add(productBom);
                }
                else
                {

                }
                if (line.ItemInfo == null)
                {
                    continue;
                }
                string supplierCode = "";
                string supplierName = "";
                if (line.SupplierInfo == null || string.IsNullOrEmpty(line.SupplierInfo.Code))
                {
                    ItemMaster item = ItemMaster.Finder.Find(" Code='" + line.ItemInfo.ItemCode + "'");
                    if (item != null && item.PurchaseInfo != null && item.PurchaseInfo.Supplier != null && !string.IsNullOrEmpty(item.PurchaseInfo.Supplier.Code))
                    {
                        supplierCode = item.PurchaseInfo.Supplier.Code;
                        supplierName = item.PurchaseInfo.Supplier.Name;
                    }
                    else
                    {
                        supplierCode = "dd";
                    }
                }
                else
                {
                    supplierCode = line.SupplierInfo.Code;
                    supplierName = line.SupplierInfo.Name;
                }
                BomDTO bom = productBom.Bom.Find(delegate(BomDTO b) { return b.ItemCode == line.ItemInfo.ItemCode && b.VendorCode == supplierCode; });
                if (bom == null)
                {
                    bom = new BomDTO();

                    bom.ItemCode = line.ItemInfo.ItemCode;
                    bom.ItemName = line.ItemInfo.ItemName;
                    bom.VendorCode = supplierCode;
                    bom.VendorName = supplierName;
                    bom.Qty = line.StoreUOMQty;
                    bom.UomCode = line.StoreUOM == null || string.IsNullOrEmpty(line.StoreUOM.Code) ? "EA" : line.StoreUOM.Code;
                    bom.UomName = line.StoreUOM == null || string.IsNullOrEmpty(line.StoreUOM.Name) ? "EA" : line.StoreUOM.Name;
                    bom.BomType = "已发";

                    productBom.Bom.Add(bom);
                }
                else
                {
                    bom.Qty += line.StoreUOMQty;
                }

            }

            return listProductBom;
        }
    }

    #endregion


}