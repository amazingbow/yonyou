namespace UFIDA.U9.Cust.XMJL.ItemSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.Business;
    using UFIDA.U9.InvTrans.WhQoh;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetItemStore partial 
    /// </summary>	
    public partial class GetItemStore
    {
        internal BaseStrategy Select()
        {
            return new GetItemStoreImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetItemStoreImpementStrategy : BaseStrategy
    {
        public GetItemStoreImpementStrategy() { }

        public override object Do(object obj)
        {
            GetItemStore bpObj = (GetItemStore)obj;
            string itemCode = bpObj.ItemCode;
            bool isSum = bpObj.IsSum;
            string excludeWHCode = "";
            foreach (string whCode in bpObj.ExcludeWHCode)
            {
                excludeWHCode += "'" + whCode + "',";
            }
            if (!string.IsNullOrEmpty(excludeWHCode))
            {
                excludeWHCode = "(" + excludeWHCode.TrimEnd(',') + ")";
            }

            OqlParam[] oqlParameters = new OqlParam[]
            {
                new OqlParam(itemCode)
                {
                    ParamName = "ItemCode",
                    Value = itemCode,
                    Type = DbType.String,
                },
                new UFSoft.UBF.PL.OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID)
            };

            //            string oql = @"select ItemInfo.ItemCode 件号,ItemInfo.ItemName 件名,
            //StoreUOM.Code 单位编码,StoreUOM.Name 单位名称,StoreUOM.ShortName 单位简称,Wh.Code 存储地点代码,Wh.Name 存储地点名称,StoreQty 库存数量 
            //from UFIDA::U9::InvTrans::WhQoh::WhQoh where ItemInfo.ItemCode=@ItemCode and Wh.Code not in " + excludeWHCode;

            string oql = @" ItemInfo.ItemCode=@ItemCode and Org=@Org and Wh.Code not in " + excludeWHCode;

            WhQoh.EntityList list = WhQoh.Finder.FindAll(oql, oqlParameters);

            List<ItemStoreDTO> result = new List<ItemStoreDTO>();
            if (isSum)
            {
                ItemStoreDTO dto = new ItemStoreDTO();
                foreach (WhQoh whqoh in list)
                {
                    dto.ItemCode = whqoh.ItemInfo.ItemCode;
                    dto.ItemName = whqoh.ItemInfo.ItemName;
                    dto.UomCode = whqoh.StoreUOM.Code;
                    dto.UomName = whqoh.StoreUOM.Name;
                    dto.UomShortName = whqoh.StoreUOM.ShortName;
                    dto.WHCode = "";
                    dto.WHName = "";

                    dto.StoreQty += whqoh.StoreQty;
                }

                result.Add(dto);
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

        /* 注释内语句若要启用需要加上组织过滤
        //用SQL查询
        private DataSet SqlQuery(string itemCode, bool isSum, string excludeWHCode)
        {
            string sql = "select  t4.code as 件号,t4.Name As 件名,";
            if (isSum)//合并存储地点统计数量
            {
                sql += @" '' As 存储地点代码,'' 存储地点名称,
t5.Code AS 单位编码,t3.name As 单位名称,t5.ShortName AS 单位简称, SUM(ISNULL(t1.StoreQty, 0)) AS 库存数量 ";
            }
            else
            {
                sql += @" t2.code As 存储地点代码,t6.Name 存储地点名称,
t5.Code AS 单位编码,t3.name As 单位名称,t5.ShortName AS 单位简称, t1.StoreQty AS 库存数量 ";
            }

            sql += @"from InvTrans_WhQoh  t1 
left join CBO_ItemMaster t4 on t4.id =  t1.ItemInfo_ItemID
left join CBO_Wh t2 on t2.ID =t1.Wh
left join CBO_Wh_Trl t6 on t6.ID =t1.Wh
left join  Base_UOM_trl t3 on t3.id = t1.storeuom
left join  Base_UOM t5 on t5.id = t1.storeuom
where storeqty<>0 and t4.code='" + itemCode + "' and t2.Code not in " + excludeWHCode;

            if (isSum)
            {
                sql += " GROUP BY t4.code,t4.name,t3.name,t5.Code,t5.ShortName";
            }

            //UFSoft.UBF.Util.DataAccess.DataParamList dataParams = new UFSoft.UBF.Util.DataAccess.DataParamList();
            //UFSoft.UBF.Util.DataAccess.DataParam param = new UFSoft.UBF.Util.DataAccess.DataParam();
            //param.Name = "ItemCode";
            //param.Value = itemCode;
            //dataParams.Add(param);

            DataSet ds = new DataSet();
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);

            return ds;
        }
        //用OQL查询
        private DataSet OqlQuery(string itemCode, bool isSum, string excludeWHCode)
        {
            //未合并数量
            string oql = @"select t4.Code 件号,t4.Name 件名,t2.code 存储地点代码,t2.Name 存储地点名称,
            t5.Code 单位编码,t5.Name 单位名称,t5.ShortName 单位简称, t1.StoreQty 库存数量
            from UFIDA::U9::CBO::SCM::Item::ItemMaster t4
            left join UFIDA::U9::InvTrans::WhQoh::WhQoh t1 on t4.id =  t1.ItemInfo.ItemID
            left join UFIDA::U9::CBO::SCM::Warehouse::Warehouse t2 on t2.ID =t1.Wh
            left join UFIDA::U9::Base::UOM::UOM t5 on t5.id = t1.storeuom
            where t1.StoreQty!=0 and t4.code='" + itemCode + "' and t2.Code not in " + excludeWHCode;

            EntityDataQuery q = new EntityDataQuery("UFIDA.U9.CBO.SCM.Item.ItemMaster");
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam(itemCode));
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam(excludeWHCode));
            DataSet ds = q.FindDataSet(oql);



            return ds;
        }*/
    }

    #endregion


}