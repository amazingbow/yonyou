namespace UFIDA.U9.Cust.XMJL.ItemSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SPR.SalePriceList;
    using System.Data;
    using UFSoft.UBF.Business;

    /// <summary>
    /// GetItemPrice partial 
    /// </summary>	
    public partial class GetItemPrice
    {
        internal BaseStrategy Select()
        {
            return new GetItemPriceImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetItemPriceImpementStrategy : BaseStrategy
    {
        public GetItemPriceImpementStrategy() { }

        public override object Do(object obj)
        {
            GetItemPrice bpObj = (GetItemPrice)obj;

            string itemCode = bpObj.ItemCode;

            UFSoft.UBF.PL.OqlParam[] oqlParameters = new UFSoft.UBF.PL.OqlParam[]
            {
                new UFSoft.UBF.PL.OqlParam(itemCode)
                {
                    ParamName = "ItemCode",
                    Value = itemCode,
                    Type = DbType.String,
                },
                new UFSoft.UBF.PL.OqlParam(UFIDA.U9.SPR.Enums.Status.Approved.Value)
                {
                    ParamName = "Status",
                    Value = UFIDA.U9.SPR.Enums.Status.Approved.Value,
                    Type = DbType.Int32,
                },
                new UFSoft.UBF.PL.OqlParam(DateTime.Now)
                {
                    ParamName = "Date",
                    Value = DateTime.Now,
                    Type = DbType.DateTime,
                },
                new UFSoft.UBF.PL.OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID)
            };

            string oql = @"ItemInfo.ItemCode=@ItemCode and SalePriceList.Org=@Org and SalePriceList.Status=@Status and FromDate<=@Date and ToDate>=@Date order by ModifiedOn desc";
            SalePriceLine line = SalePriceLine.Finder.Find(oql, oqlParameters);
            if (line == null) return null;
            ItemPriceDTO dto = new ItemPriceDTO();
            dto.ItemCode = line.ItemInfo.ItemCode;
            dto.ItemName = line.ItemInfo.ItemName;
            dto.UomCode = line.Uom.Code;
            dto.UomName = line.Uom.Name;
            dto.UomShortName = line.Uom.ShortName;
            dto.Price = line.Price;

            return dto;

            //return Query(itemCode);
        }
        private ItemPriceDTO Query(string itemCode)
        {
            string oql = @"select top 1 
ItemInfo.ItemCode ItemCode,ItemInfo.ItemName ItemName,Uom.Code UomCode,Uom.Name UomName,Uom.ShortName UomShortName,Price 
from UFIDA::U9::SPR::SalePriceList::SalePriceLine 
where ItemInfo.ItemCode=@ItemCode and SalePriceList.Status=@Status and FromDate<=@Date and ToDate>=@Date
order by ModifiedOn desc;";

            EntityDataQuery q = new EntityDataQuery("UFIDA::U9::SPR::SalePriceList::SalePriceLine");
            DataSet ds = q.FindDataSet(oql);
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam("ItemCode", itemCode));
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam("Status", UFIDA.U9.SPR.Enums.Status.Approved.Value));
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam("Date", DateTime.Now));

            if (ds != null && ds.Tables[0].Rows.Count != 0)
            {
                ItemPriceDTO dto = new ItemPriceDTO();
                DataRow dr = ds.Tables[0].Rows[0];
                dto.ItemCode = dr["ItemCode"].ToString();
                dto.ItemName = dr["ItemName"].ToString();
                dto.UomCode = dr["UomCode"].ToString();
                dto.UomName = dr["UomName"].ToString();
                dto.UomShortName = dr["UomShortName"].ToString();
                dto.Price = decimal.Parse(dr["Price"].ToString());

                return dto;
            }
            else
            {
                return null;
            }
        }
    }

    #endregion


}