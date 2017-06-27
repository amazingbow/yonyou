using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// QueryBP partial 
	/// </summary>	
	public partial class QueryBP 
	{	
		internal BaseStrategy Select()
		{
			return new QueryBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class QueryBPImpementStrategy : BaseStrategy
	{
		public QueryBPImpementStrategy() { }

		public override object Do(object obj)
		{
            QueryBP bpObj = (QueryBP)obj;
            object result = DoProcess(bpObj.QryInParameter);
            return result;
		}		
	}
    
    #region QueryBP Stereotype
    internal partial class QueryBPImpementStrategy
    {
       //实体FullName
        private string GetEntityFullName()
        {
             //TODO:
            return "UFIDA.U9.InvTrans.WhQoh.WhQoh";
        }
        /// <summary>
        /// 分页内部是否需要使用临时表机制，对于数据量比较小的查询，没有必要采用临时表
        /// 缓存第一次查询的结果，每次重查就行了，否则第一次查询时页面加载会慢些。由BP
        /// 开发人员自己判断。
        /// </summary>
        /// <returns></returns>
        private bool isNeedTempTable()
        {
            return true;
        }//end isTempTable 

        /// <summary>
        /// 是否基于临时表构造的OQL,对于基于临时表的查询，分页服务内部不需要多语的处理；
        /// 基于业务表的查询，则需要。此处由BP开发人员根据实际情况返回正确的值。
        /// </summary>
        /// <returns></returns>
        private bool oqlBuildByTempTable()
        {
            return true;
        }//end isNeedMultiLang

        /// <summary>
        /// 执行业务逻辑，返回OQL串，由BP开发人员添加代码。
        /// 参数bpParameter中带有已选栏目、过滤及排序信息
        /// </summary>
        /// <returns></returns>
        private string DoLogic(UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            DoMap();
            EntityViewQuery entityViewQuery = new EntityViewQuery();
            //获取库存汇总量
            GetInvSumTempTable(entityViewQuery, bpParameter);
            //获取库存预留量汇总
            GetInvResvSumTempTable(entityViewQuery, bpParameter);
            //创建结果表
            CreateResultTempTable(entityViewQuery, bpParameter);

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("row_number() over(order by A.ItemID desc)", "ID");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#InvTempTable as A ");
            string oqlString = resultTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                resultTool.AddOrder("A." + sortItem.ColumnName, sortItem.OrderType == OrderType.Ascend);
            }
            string result;
            if (resultTool.Orders != null && resultTool.Orders.Count > 0)
            {
                result = oqlString + " order by " + resultTool.Orders;
            }
            else
            {
                result = oqlString;
            }
            return result;
        } //end DoLogic 

        /// <summary>
        /// 获取库存汇总量
        /// </summary>
        /// <param name="entityViewQuery"></param>
        /// <param name="bpParameter"></param>
        private void GetInvSumTempTable(EntityViewQuery entityViewQuery, UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            SimpleOqlTool simpleTool = new SimpleOqlTool();
            //料品ID
            simpleTool.AddSelect("ItemMaster.ID", "ItemID");
            //存储地点
            simpleTool.AddSelect("WhQoh.Wh", WhQoh_Wh);
            //名称
            simpleTool.AddSelect("WhQoh.Wh.Name", WhQoh_Wh_Name);
            //料号
            simpleTool.AddSelect("ItemMaster.Code", ItemMaster_Code);
            //品名
            simpleTool.AddSelect("ItemMaster.Name", ItemMaster_Name);
            //料品分类
            simpleTool.AddSelect("ItemMaster.MainItemCategory", ItemMaster_MainItemCategory);
            //料品分类
            simpleTool.AddSelect("ItemMaster.MainItemCategory.Name", ItemMaster_MainItemCategory_Name);
            //规格
            simpleTool.AddSelect("ItemMaster.SPECS", ItemMaster_SPECS);
            //批号
            simpleTool.AddSelect("WhQoh.LotInfo.LotMaster_EntityID", WhQoh_LotInfo_LotMaster_EntityID);
            //批号
            simpleTool.AddSelect("WhQoh.LotInfo.LotCode", WhQoh_LotInfo_LotCode);
            //结存数(库存单位)
            simpleTool.AddSelect("sum(WhQoh.StoreQty)", WhQoh_StoreQty);
            //结存数(成本单位)
            simpleTool.AddSelect("sum(WhQoh.StoreQtyCU)", WhQoh_StoreQtyCU);
            //库存在手量_库存单位_精度_精度
            simpleTool.AddSelect("WhQoh.StoreUOM.Round.Precision", WhQoh_StoreUOM_Round_Precision);
            //库存在手量_库存单位_精度_舍入类型
            simpleTool.AddSelect("WhQoh.StoreUOM.Round.RoundType", WhQoh_StoreUOM_Round_RoundType);
            //库存在手量_库存单位_精度_舍入值
            simpleTool.AddSelect("WhQoh.StoreUOM.Round.RoundValue", WhQoh_StoreUOM_Round_RoundValue);
            //名称
            simpleTool.AddSelect("WhQoh.StoreUOM.Name", WhQoh_StoreUOM_Name);
            //库存在手量_成本单位_精度_精度
            simpleTool.AddSelect("WhQoh.CU.Round.Precision", WhQoh_CU_Round_Precision);
            //库存在手量_成本单位_精度_舍入类型
            simpleTool.AddSelect("WhQoh.CU.Round.RoundType", WhQoh_CU_Round_RoundType);
            //库存在手量_成本单位_精度_舍入值
            simpleTool.AddSelect("WhQoh.CU.Round.RoundValue", WhQoh_CU_Round_RoundValue);
            //名称
            simpleTool.AddSelect("WhQoh.CU.Name", WhQoh_CU_Name);
            //包装数
            simpleTool.AddSelect(@"(case when ItemMaster.DescFlexField.PrivateDescSeg5 != '' then 
                            convert(decimal(23,9),ItemMaster.DescFlexField.PrivateDescSeg5) else 0 end)", PackageNum);
            //批发价
            simpleTool.AddSelect(@"(case when ItemMaster.DescFlexField.PrivateDescSeg1 != '' then 
                            convert(decimal(23,9),ItemMaster.DescFlexField.PrivateDescSeg1) else 0 end)", WholesalePrice);
            //米价
            simpleTool.AddSelect(@"(case when ItemMaster.DescFlexField.PrivateDescSeg2 != '' then 
                            convert(decimal(23,9),ItemMaster.DescFlexField.PrivateDescSeg2) else 0 end)", MeterPrice);
            //最高库存
            simpleTool.AddSelect("ItemMaster.InventoryInfo.InventoryMaxLimitQty", ItemMaster_InventoryInfo_InventoryMaxLimitQty);
            //最低库存
            simpleTool.AddSelect("ItemMaster.InventoryInfo.InventoryMinLimitQty", ItemMaster_InventoryInfo_InventoryMinLimitQty);
            //安全库存
            simpleTool.AddSelect("ItemMaster.InventoryInfo.SafetyStockQty", ItemMaster_InventoryInfo_SafetyStockQty);
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Organization":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ItemMaster.Org");
                        break;
                    case "WhQoh_StoreQty":
                    case "WhQoh_StoreQtyCU":
                    case "ResvStQty":
                    case "ResvStQtyCU":
                    case "AvailableQty":
                    case "AvailableQtyCU":
                        continue;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool.AddCondition(bpParameter.FilterOpath);
            StringBuilder fromSb1 = new StringBuilder();
            fromSb1.Append("UFIDA::U9::InvTrans::WhQoh::WhQoh as WhQoh");
            fromSb1.Append(" left join ");
            fromSb1.Append("UFIDA::U9::CBO::SCM::Item::ItemMaster as ItemMaster");//客户联系人
            fromSb1.Append(" on ");
            fromSb1.Append("WhQoh.ItemInfo.ItemID = ItemMaster.ID"); //客户联系人 = 默认
            //处理From部份，形成From子句
            simpleTool.SetFromClause(fromSb1.ToString()); //在这里替换From子句中的实体名称
            simpleTool.AddGroup(new string[]
            {
                "ItemMaster.ID","WhQoh.Wh","WhQoh.Wh.Name","ItemMaster.Code","ItemMaster.Name",
                "ItemMaster.MainItemCategory","ItemMaster.MainItemCategory.Name","ItemMaster.SPECS",
                "WhQoh.LotInfo.LotMaster_EntityID","WhQoh.LotInfo.LotCode",
                "WhQoh.StoreUOM.Round.Precision","WhQoh.StoreUOM.Round.RoundType","WhQoh.StoreUOM.Round.RoundValue","WhQoh.StoreUOM.Name",
                "WhQoh.CU.Round.Precision","WhQoh.CU.Round.RoundType","WhQoh.CU.Round.RoundValue",
                "WhQoh.CU.Name","ItemMaster.DescFlexField.PrivateDescSeg5","ItemMaster.DescFlexField.PrivateDescSeg1","ItemMaster.DescFlexField.PrivateDescSeg2",
                "ItemMaster.InventoryInfo.InventoryMaxLimitQty","ItemMaster.InventoryInfo.InventoryMinLimitQty","ItemMaster.InventoryInfo.SafetyStockQty"
            });
            TempTableUtil.CreateTempTableByOql("InvSumTempTable", simpleTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 获取库存预留量汇总
        /// </summary>
        /// <param name="entityViewQuery"></param>
        /// <param name="bpParameter"></param>
        private void GetInvResvSumTempTable(EntityViewQuery entityViewQuery,
            UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            SimpleOqlTool simpleTool = new SimpleOqlTool();
            //料品ID
            simpleTool.AddSelect("ItemMaster.ID", "ItemID");
            //存储地点
            simpleTool.AddSelect("WhQoh.Wh", WhQoh_Wh);
            //批号
            simpleTool.AddSelect("WhQoh.LotInfo.LotMaster_EntityID", WhQoh_LotInfo_LotMaster_EntityID);
            //预留量(库存单位)
            simpleTool.AddSelect("sum(WhQoh.StoreQty)", ResvStQty);
            //预留量(成本单位)
            simpleTool.AddSelect("sum(WhQoh.StoreQtyCU)", ResvStQtyCU);
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Organization":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ItemMaster.Org");
                        break;
                    case "WhQoh_StoreQty":
                    case "WhQoh_StoreQtyCU":
                    case "ResvStQty":
                    case "ResvStQtyCU":
                    case "AvailableQty":
                    case "AvailableQtyCU":
                        continue;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool.AddCondition(bpParameter.FilterOpath);
            StringBuilder fromSb1 = new StringBuilder();
            fromSb1.Append("UFIDA::U9::InvTrans::WhQoh::WhQoh as WhQoh");
            fromSb1.Append(" left join ");
            fromSb1.Append("UFIDA::U9::CBO::SCM::Item::ItemMaster as ItemMaster");//客户联系人
            fromSb1.Append(" on ");
            fromSb1.Append("WhQoh.ItemInfo.ItemID = ItemMaster.ID"); //客户联系人 = 默认
            //处理From部份，形成From子句
            simpleTool.SetFromClause(fromSb1.ToString()); //在这里替换From子句中的实体名称
            simpleTool.AddCondition("WhQoh.Project is not null");//项目不能为空
            simpleTool.AddGroup(new string[]
            {
                "ItemMaster.ID","WhQoh.Wh","WhQoh.LotInfo.LotMaster_EntityID"
            });
            TempTableUtil.CreateTempTableByOql("InvResvSumTempTable", simpleTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 创建结果表
        /// </summary>
        /// <param name="entityViewQuery"></param>
        /// <param name="bpParameter"></param>
        private void CreateResultTempTable(EntityViewQuery entityViewQuery,
            UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ItemID", "ItemID");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                switch (columnitem.ColumnAlias)
                {
                    case "ResvStQty":
                        resultTool.AddSelect("B.ResvStQty", columnitem.ColumnAlias);
                        break;
                    case "ResvStQtyCU":
                        resultTool.AddSelect("B.ResvStQtyCU", columnitem.ColumnAlias);
                        break;
                    case "AvailableQty":
                        resultTool.AddSelect("(A.WhQoh_StoreQty - (case when B.ResvStQty is null then 0 else B.ResvStQty end))", AvailableQty);
                        break;
                    case "AvailableQtyCU":
                        resultTool.AddSelect("(A.WhQoh_StoreQtyCU - (case when B.ResvStQtyCU is null then 0 else B.ResvStQtyCU end))", AvailableQtyCU);
                        break;
                    default:
                        resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                        break;
                }
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "ResvStQty":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "B.ResvStQty");
                        break;
                    case "ResvStQtyCU":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "B.ResvStQtyCU");
                        break;
                    case "AvailableQty":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "(A.WhQoh_StoreQty - (case when B.ResvStQty is null then 0 else B.ResvStQty end))");
                        break;
                    case "AvailableQtyCU":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "(A.WhQoh_StoreQtyCU - (case when B.ResvStQtyCU is null then 0 else B.ResvStQtyCU end))");
                        break;
                    default:
                        continue;
                }
                resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            resultTool.SetFromClause(@"#InvSumTempTable A left join #InvResvSumTempTable B on A.ItemID = B.ItemID 
                and A.WhQoh_Wh = B.WhQoh_Wh and A.WhQoh_LotInfo_LotMaster_EntityID = B.WhQoh_LotInfo_LotMaster_EntityID"); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("InvTempTable", resultTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 这部份代码查询开发人员不要作修改
        /// 删除Do方法中的
        /// throw new NotImplementedException();
        /// 在Do方法中直接加上一句:
        /// return DoProcess(bpObj.QryInParameter);
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <returns></returns>
        private object DoProcess(UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            UFIDA.UBF.Query.CommonService.QryPaginateService<UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.InvInfoQueryQryDTO> ps = new UFIDA.UBF.Query.CommonService.QryPaginateService<UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.InvInfoQueryQryDTO>(bpParameter, isNeedTempTable());
            if (ps.isProcessBusiness)
            {
                string oql = DoLogic(bpParameter);
                return ps.FindDataByPage(GetEntityFullName(), oqlBuildByTempTable(), oql);
            }
            else
            {
                return ps.FindDataByPage();
            }
        }
    }
    
    internal partial class QueryBPImpementStrategy
    {
        private IDictionary<String, String> map = new Dictionary<String, String>();

        #region 实体属性对应的别名定义
        public readonly static string ID = "ID";
        public readonly static string WhQoh_Wh = "WhQoh_Wh";
        public readonly static string WhQoh_Wh_Name = "WhQoh_Wh_Name";
        public readonly static string ItemMaster_Code = "ItemMaster_Code";
        public readonly static string ItemMaster_Name = "ItemMaster_Name";
        public readonly static string ItemMaster_MainItemCategory = "ItemMaster_MainItemCategory";
        public readonly static string ItemMaster_MainItemCategory_Name = "ItemMaster_MainItemCategory_Name";
        public readonly static string ItemMaster_SPECS = "ItemMaster_SPECS";
        public readonly static string WhQoh_LotInfo_LotMaster_EntityID = "WhQoh_LotInfo_LotMaster_EntityID";
        public readonly static string WhQoh_LotInfo_LotCode = "WhQoh_LotInfo_LotCode";
        public readonly static string WhQoh_StoreQty = "WhQoh_StoreQty";
        public readonly static string WhQoh_StoreQtyCU = "WhQoh_StoreQtyCU";
        public readonly static string ResvStQty = "ResvStQty";
        public readonly static string ResvStQtyCU = "ResvStQtyCU";
        public readonly static string AvailableQty = "AvailableQty";
        public readonly static string AvailableQtyCU = "AvailableQtyCU";
        public readonly static string WhQoh_StoreUOM_Round_Precision = "WhQoh_StoreUOM_Round_Precision";
        public readonly static string WhQoh_StoreUOM_Round_RoundType = "WhQoh_StoreUOM_Round_RoundType";
        public readonly static string WhQoh_StoreUOM_Round_RoundValue = "WhQoh_StoreUOM_Round_RoundValue";
        public readonly static string WhQoh_StoreUOM_Name = "WhQoh_StoreUOM_Name";
        public readonly static string WhQoh_CU_Round_Precision = "WhQoh_CU_Round_Precision";
        public readonly static string WhQoh_CU_Round_RoundType = "WhQoh_CU_Round_RoundType";
        public readonly static string WhQoh_CU_Round_RoundValue = "WhQoh_CU_Round_RoundValue";
        public readonly static string WhQoh_CU_Name = "WhQoh_CU_Name";
        public readonly static string PackageNum = "PackageNum";
        public readonly static string WholesalePrice = "WholesalePrice";
        public readonly static string MeterPrice = "MeterPrice";
        public readonly static string ItemMaster_InventoryInfo_InventoryMaxLimitQty = "ItemMaster_InventoryInfo_InventoryMaxLimitQty";
        public readonly static string ItemMaster_InventoryInfo_InventoryMinLimitQty = "ItemMaster_InventoryInfo_InventoryMinLimitQty";
        public readonly static string ItemMaster_InventoryInfo_SafetyStockQty = "ItemMaster_InventoryInfo_SafetyStockQty";
        public readonly static string WhQoh_Project = "WhQoh_Project";
        public readonly static string WhQoh_Project_Code = "WhQoh_Project_Code";
        public readonly static string Organization = "Organization";
        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //存储地点
            map.Add(WhQoh_Wh, "WhQoh.Wh");
            //名称
            map.Add(WhQoh_Wh_Name, "WhQoh.Wh.Name");
            //料号
            map.Add(ItemMaster_Code, "ItemMaster.Code");
            //品名
            map.Add(ItemMaster_Name, "ItemMaster.Name");
            //料品分类
            map.Add(ItemMaster_MainItemCategory, "ItemMaster.MainItemCategory");
            //料品分类
            map.Add(ItemMaster_MainItemCategory_Name, "ItemMaster.MainItemCategory.Name");
            //规格
            map.Add(ItemMaster_SPECS, "ItemMaster.SPECS");
            //批号
            map.Add(WhQoh_LotInfo_LotMaster_EntityID, "WhQoh.LotInfo.LotMaster.EntityID");
            //批号
            map.Add(WhQoh_LotInfo_LotCode, "WhQoh.LotInfo.LotCode");
            //结存数(库存单位)
            map.Add(WhQoh_StoreQty, "WhQoh.StoreQty");
            //结存数(成本单位)
            map.Add(WhQoh_StoreQtyCU, "WhQoh.StoreQtyCU");
            //预留量(库存单位)
            map.Add(ResvStQty, "ResvStQty");
            //预留量(成本单位)
            map.Add(ResvStQtyCU, "ResvStQtyCU");
            //可用量(库存单位)
            map.Add(AvailableQty, "AvailableQty");
            //可用量(成本单位)
            map.Add(AvailableQtyCU, "AvailableQtyCU");
            //库存在手量_库存单位_精度_精度
            map.Add(WhQoh_StoreUOM_Round_Precision, "WhQoh.StoreUOM.Round.Precision");
            //库存在手量_库存单位_精度_舍入类型
            map.Add(WhQoh_StoreUOM_Round_RoundType, "WhQoh.StoreUOM.Round.RoundType");
            //库存在手量_库存单位_精度_舍入值
            map.Add(WhQoh_StoreUOM_Round_RoundValue, "WhQoh.StoreUOM.Round.RoundValue");
            //名称
            map.Add(WhQoh_StoreUOM_Name, "WhQoh.StoreUOM.Name");
            //库存在手量_成本单位_精度_精度
            map.Add(WhQoh_CU_Round_Precision, "WhQoh.CU.Round.Precision");
            //库存在手量_成本单位_精度_舍入类型
            map.Add(WhQoh_CU_Round_RoundType, "WhQoh.CU.Round.RoundType");
            //库存在手量_成本单位_精度_舍入值
            map.Add(WhQoh_CU_Round_RoundValue, "WhQoh.CU.Round.RoundValue");
            //名称
            map.Add(WhQoh_CU_Name, "WhQoh.CU.Name");
            //包装数
            map.Add(PackageNum, "PackageNum");
            //批发价
            map.Add(WholesalePrice, "WholesalePrice");
            //米价
            map.Add(MeterPrice, "MeterPrice");
            //最高库存
            map.Add(ItemMaster_InventoryInfo_InventoryMaxLimitQty, "ItemMaster.InventoryInfo.InventoryMaxLimitQty");
            //最低库存
            map.Add(ItemMaster_InventoryInfo_InventoryMinLimitQty, "ItemMaster.InventoryInfo.InventoryMinLimitQty");
            //安全库存
            map.Add(ItemMaster_InventoryInfo_SafetyStockQty, "ItemMaster.InventoryInfo.SafetyStockQty");
            //项目
            map.Add(WhQoh_Project, "WhQoh.Project");
            //编码
            map.Add(WhQoh_Project_Code, "WhQoh.Project.Code");
            //组织
            map.Add(Organization, "Organization");
        }
    }
    #endregion
    
	#endregion
	
	
}