namespace UFIDA.U9.Cust.XMJL.ItemSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFIDA.U9.SPR.SalePriceList;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.SPR.Enums;

    /// <summary>
    /// QueryAllItemPrice partial 
    /// </summary>	
    public partial class QueryAllItemPrice
    {
        internal BaseStrategy Select()
        {
            return new QueryAllItemPriceImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryAllItemPriceImpementStrategy : BaseStrategy
    {
        public QueryAllItemPriceImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryAllItemPrice bpObj = (QueryAllItemPrice)obj;

            OqlParam[] oqlParameters = new OqlParam[]
            {
                new OqlParam(Status.Approved.Value)
                {
                    ParamName = "Status",
                    Value = Status.Approved.Value,
                    Type = DbType.Int32,
                },
                new OqlParam(DateTime.Now)
                {
                    ParamName = "Date",
                    Value = DateTime.Now,
                    Type = DbType.DateTime,
                },
                new UFSoft.UBF.PL.OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID)
            };

            string oql = @"SalePriceList.Status=@Status and SalePriceList.Org=@Org and FromDate<=@Date and ToDate>=@Date order by ModifiedOn desc";
            SalePriceLine.EntityList list = SalePriceLine.Finder.FindAll(oql, oqlParameters);
            List<ItemPriceDTO> result = new List<ItemPriceDTO>();
            //用于记录各料品的最新更新时间
            Dictionary<string, DateTime> itemMaxModifiedOn = new Dictionary<string, DateTime>();
            foreach (SalePriceLine line in list)
            {
                ItemPriceDTO dto = result.Find(delegate(ItemPriceDTO i) { return i.ItemCode == line.ItemInfo.ItemCode; });
                if (dto == null)
                {
                    dto = new ItemPriceDTO();
                    dto.ItemCode = line.ItemInfo.ItemCode;
                    dto.ItemName = line.ItemInfo.ItemName;
                    dto.UomCode = line.Uom.Code;
                    dto.UomName = line.Uom.Name;
                    dto.UomShortName = line.Uom.ShortName;
                    dto.Price = line.Price;

                    itemMaxModifiedOn.Add(line.ItemInfo.ItemCode, line.ModifiedOn);

                    result.Add(dto);
                }
                else
                {
                    if (line.ModifiedOn > itemMaxModifiedOn[line.ItemInfo.ItemCode])
                    {
                        dto.Price = line.Price;
                        itemMaxModifiedOn[line.ItemInfo.ItemCode] = line.ModifiedOn;
                    }
                }
            }
            return result;
        }
    }

    #endregion


}