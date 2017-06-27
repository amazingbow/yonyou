namespace UFIDA.U9.Cust.XMJL.ItemSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.Business;

    /// <summary>
    /// QueryAllEffectiveItem partial 
    /// </summary>	
    public partial class QueryAllEffectiveItem
    {
        internal BaseStrategy Select()
        {
            return new QueryAllEffectiveItemImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryAllEffectiveItemImpementStrategy : BaseStrategy
    {
        public QueryAllEffectiveItemImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryAllEffectiveItem bpObj = (QueryAllEffectiveItem)obj;

            string oql = @"select Code,Name,InventoryUOM.Code UomCode,InventoryUOM.Name UomName,InventoryUOM.ShortName UomShortName,
Effective.EffectiveDate EffectiveDate,Effective.DisableDate DisableDate,RefrenceCost 
from UFIDA::U9::CBO::SCM::Item::ItemMaster
where Effective.IsEffective=1 and Org=@org and state=@state and modifiedon > @modifiedon 
and Effective.EffectiveDate<=@today and Effective.DisableDate>=@today";

            EntityDataQuery q = new EntityDataQuery("UFIDA.U9.CBO.SCM.Item.ItemMaster");

            q.Parameters.Add(new OqlParam("state", ItemStateEnum.Verified.Value));//状态
            q.Parameters.Add(new OqlParam("modifiedon", bpObj.SynDateTime));//更新时间
            q.Parameters.Add(new OqlParam("today", DateTime.Now));//当天
            q.Parameters.Add(new OqlParam("org", UFIDA.U9.Base.Context.LoginOrg.ID));//组织

            DataSet ds = q.FindDataSet(oql);

            List<ItemDTO> listResult = new List<ItemDTO>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ItemDTO item = new ItemDTO()
                {
                    ItemCode = dr["Code"].ToString(),
                    ItemName = dr["Name"].ToString(),
                    UomCode = dr["UomCode"].ToString(),
                    UomName = dr["UomName"].ToString(),
                    UomShortName = dr["UomShortName"].ToString()
                };

                DateTime effectiveDate;
                DateTime.TryParse(dr["EffectiveDate"].ToString(), out effectiveDate);

                DateTime disableDate;
                DateTime.TryParse(dr["DisableDate"].ToString(), out disableDate);

                double cost;
                double.TryParse(dr["RefrenceCost"].ToString(),out cost);

                item.EffectiveDate = effectiveDate;
                item.DisableDate = disableDate;
                item.RefrenceCost = cost;

                listResult.Add(item);
            }

            return listResult;
        }
    }

    #endregion


}