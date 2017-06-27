using System;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP
{
    /// <summary>
    ///     QueryBP partial
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
    ///     Impement Implement
    /// </summary>
    internal partial class QueryBPImpementStrategy : BaseStrategy
    {
        public QueryBPImpementStrategy()
        {
        }

        public override object Do(object obj)
        {
            QueryBP bpObj = (QueryBP) obj;
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
            return "UFIDA.U9.SM.Ship.ShipLine";
        }

        /// <summary>
        ///     分页内部是否需要使用临时表机制，对于数据量比较小的查询，没有必要采用临时表
        ///     缓存第一次查询的结果，每次重查就行了，否则第一次查询时页面加载会慢些。由BP
        ///     开发人员自己判断。
        /// </summary>
        /// <returns></returns>
        private bool isNeedTempTable()
        {
            return true;
        } //end isTempTable 

        /// <summary>
        ///     是否基于临时表构造的OQL,对于基于临时表的查询，分页服务内部不需要多语的处理；
        ///     基于业务表的查询，则需要。此处由BP开发人员根据实际情况返回正确的值。
        /// </summary>
        /// <returns></returns>
        private bool oqlBuildByTempTable()
        {
            return false;
        } //end isNeedMultiLang

        /// <summary>
        ///     执行业务逻辑，返回OQL串，由BP开发人员添加代码。
        ///     参数bpParameter中带有已选栏目、过滤及排序信息
        /// </summary>
        /// <returns></returns>
        private string DoLogic(QryCommonParaObj bpParameter)
        {
            this.DoMap();

            #region 出货行

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("ShipLine.ID", "ID");
            simpleTool1.AddSelect("Ship.DocNo", "DocNo");
            simpleTool1.AddSelect("Ship.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("ShipLine.DocLineNo", "DocLineNo");
            simpleTool1.AddSelect("ShipLine.ItemInfo.ItemCode", "ItemCode");
            simpleTool1.AddSelect("ShipLine.ItemInfo.ItemName", "ItemName");
            simpleTool1.AddSelect("ShipLine.ItemInfo.ItemID.SPECS", "SPECS");
            simpleTool1.AddSelect("ShipLine.ShipQtyTUAmount", "MainSOQty");
            simpleTool1.AddSelect("ShipLine.ShipQtyInvAmount", "InvSOQty");
            simpleTool1.AddSelect("ShipLine.FinallyPrice", "FinallyPrice");
            simpleTool1.AddSelect("ShipLine.TotalMoneyTC", "TotalMoney");
            simpleTool1.AddSelect("Customer.Name", "Customer_Name");
            simpleTool1.AddSelect("Ship.Seller.Name", "Operators_Name");
            simpleTool1.AddSelect(@"(case when ShipLine.ItemInfo.ItemID.DescFlexField.PrivateDescSeg5 = '' 
                then 0 else convert(decimal(23,9),ShipLine.ItemInfo.ItemID.DescFlexField.PrivateDescSeg5) end)",
                "ConversionRates");
            simpleTool1.AddSelect("ShipLine.Seller.Name", "Operators_Name");
            simpleTool1.AddSelect("ShipLine.TradeUom.Name", "MainUOM_Name");
            simpleTool1.AddSelect("ShipLine.TradeUom.Round.Precision", "MainUOM_Round_Precision");
            simpleTool1.AddSelect("ShipLine.TradeUom.Round.RoundType", "MainUOM_Round_RoundType");
            simpleTool1.AddSelect("ShipLine.TradeUom.Round.RoundValue", "MainUOM_Round_RoundValue");
            simpleTool1.AddSelect("ShipLine.InvUom.Name", "InvUOM_Name");
            simpleTool1.AddSelect("ShipLine.InvUom.Round.Precision", "InvUOM_Round_Precision");
            simpleTool1.AddSelect("ShipLine.InvUom.Round.RoundType", "InvUOM_Round_RoundType");
            simpleTool1.AddSelect("ShipLine.InvUom.Round.RoundValue", "InvUOM_Round_RoundValue");
            simpleTool1.AddSelect("ShipLine.DescFlexField.PrivateDescSeg4", "Memo");
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::SM::Ship::ShipLine as ShipLine");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::SM::Ship::Ship as Ship");
            fromSb.Append(" on ");
            fromSb.Append("ShipLine.Ship = Ship.ID");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb.Append(" on ");
            fromSb.Append("Customer.ID = Ship.OrderBy.Customer");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::SM::SO::SOLine as SOLine");
            fromSb.Append(" on ");
            fromSb.Append("SOLine.ID = ShipLine.SOLineKey");

            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "DocNo":
                    case "BusinessDate":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship." + filterItem.Name);
                        break;
                    case "ItemCode":
                    case "ItemName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ShipLine.ItemInfo." + filterItem.Name);
                        break;
                    case "SPECS":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ShipLine.ItemInfo.ItemID.SPECS");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            string filterOpath = bpParameter.FilterOpath.Replace("#Doc#", "Ship");
            simpleTool1.AddCondition(filterOpath);
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称

            #endregion

            #region 退货处理单行

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("RMALine.ID", "ID");
            simpleTool2.AddSelect("RMA.DocNo", "DocNo");
            simpleTool2.AddSelect("RMA.BusinessDate", "BusinessDate");
            simpleTool2.AddSelect("RMALine.DocLineNo", "DocLineNo");
            simpleTool2.AddSelect("RMALine.ItemInfo.ItemCode", "ItemCode");
            simpleTool2.AddSelect("RMALine.ItemInfo.ItemName", "ItemName");
            simpleTool2.AddSelect("RMALine.ItemInfo.ItemID.SPECS", "SPECS");
            simpleTool2.AddSelect("RMALine.RtnQtyTU1", "MainSOQty");
            simpleTool2.AddSelect("RMALine.RtnQtyIU", "InvSOQty");
            simpleTool2.AddSelect("RMALine.RtnPice", "FinallyPrice");
            simpleTool2.AddSelect("RMALine.RtnMoneyTC", "TotalMoney");
            simpleTool2.AddSelect("Customer.Name", "Customer_Name");
            simpleTool2.AddSelect("RMA.Seller.Name", "Operators_Name");
            simpleTool2.AddSelect(@"(case when RMALine.ItemInfo.ItemID.DescFlexField.PrivateDescSeg5 = '' 
                then 0 else convert(decimal(23,9),RMALine.ItemInfo.ItemID.DescFlexField.PrivateDescSeg5) end)",
                "ConversionRates");
            simpleTool2.AddSelect("RMA.Seller.Name", "Operators_Name");
            simpleTool2.AddSelect("RMALine.TU.Name", "MainUOM_Name");
            simpleTool2.AddSelect("RMALine.TU.Round.Precision", "MainUOM_Round_Precision");
            simpleTool2.AddSelect("RMALine.TU.Round.RoundType", "MainUOM_Round_RoundType");
            simpleTool2.AddSelect("RMALine.TU.Round.RoundValue", "MainUOM_Round_RoundValue");
            simpleTool2.AddSelect("RMALine.IU.Name", "InvUOM_Name");
            simpleTool2.AddSelect("RMALine.IU.Round.Precision", "InvUOM_Round_Precision");
            simpleTool2.AddSelect("RMALine.IU.Round.RoundType", "InvUOM_Round_RoundType");
            simpleTool2.AddSelect("RMALine.IU.Round.RoundValue", "InvUOM_Round_RoundValue");
            simpleTool2.AddSelect("''", "Memo");
            StringBuilder fromSb2 = new StringBuilder();
            fromSb2.Append("UFIDA::U9::SM::RMA::RMALine as RMALine");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::SM::RMA::RMA as RMA");
            fromSb2.Append(" on ");
            fromSb2.Append("RMALine.RMA = RMA.ID");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb2.Append(" on ");
            fromSb2.Append("Customer.ID = RMA.Customer.Customer");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb2.Append(" on ");
            fromSb2.Append("Customer.ID = RMA.Customer.Customer");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "DocNo":
                    case "BusinessDate":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA." + filterItem.Name);
                        break;
                    case "ItemCode":
                    case "ItemName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMALine.ItemInfo." + filterItem.Name);
                        break;
                    case "SPECS":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMALine.ItemInfo.ItemID.SPECS");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool2.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            filterOpath = bpParameter.FilterOpath.Replace("#Doc#", "RMA");
            simpleTool2.AddCondition(filterOpath);
            //处理From部份，形成From子句
            simpleTool2.SetFromClause(fromSb2.ToString()); //在这里替换From子句中的实体名称

            #endregion

            #region 返回结果

            SimpleOqlTool resultOqlTool = new SimpleOqlTool();
            resultOqlTool.AddSelect("finallOql.ID", "ID");
            resultOqlTool.AddSelect("row_number() over(order by finallOql.ID desc)", "sn");
            foreach (QryColumnItem current in bpParameter.QryColumnItems)
            {
                resultOqlTool.AddSelect("finallOql." + current.ColumnAlias, current.ColumnAlias);
            }
            EntityViewQuery entityViewQuery = new EntityViewQuery();
            resultOqlTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool1.GetOqlString(),
                " union all ",
                simpleTool2.GetOqlString(),
                ") as finallOql "
            }));
            string oqlString = resultOqlTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                resultOqlTool.AddOrder("finallOql." + sortItem.ColumnName,
                    sortItem.OrderType == OrderType.Ascend);
            }
            if (resultOqlTool.Orders != null && resultOqlTool.Orders.Count > 0)
            {
                return oqlString + " order by " + resultOqlTool.Orders;
            }
            return oqlString;

            #endregion
        } //end DoLogic 

        /// <summary>
        ///     这部份代码查询开发人员不要作修改
        ///     删除Do方法中的
        ///     throw new NotImplementedException();
        ///     在Do方法中直接加上一句:
        ///     return DoProcess(bpObj.QryInParameter);
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <returns></returns>
        private object DoProcess(QryCommonParaObj bpParameter)
        {
            QryPaginateService<CustomerDocLineListQryDTO> ps =
                new QryPaginateService<CustomerDocLineListQryDTO>(bpParameter, isNeedTempTable());
            if (ps.isProcessBusiness)
            {
                string oql = DoLogic(bpParameter);
                return ps.FindDataByPage(GetEntityFullName(), oqlBuildByTempTable(), oql);
            }
            return ps.FindDataByPage();
        }
    }

    internal partial class QueryBPImpementStrategy
    {
        private readonly IDictionary<String, String> map = new Dictionary<String, String>();

        #region 实体属性对应的别名定义

        public static readonly string ID = "ID";
        public static readonly string BusinessDate = "BusinessDate";
        public static readonly string DocNo = "DocNo";
        public static readonly string ItemCode = "ItemCode";
        public static readonly string ItemName = "ItemName";
        public static readonly string SPECS = "SPECS";
        public static readonly string MainSOQty = "MainSOQty";
        public static readonly string MainUOM_Name = "MainUOM_Name";
        public static readonly string FinallyPrice = "FinallyPrice";
        public static readonly string InvSOQty = "InvSOQty";
        public static readonly string InvUOM_Name = "InvUOM_Name";
        public static readonly string TotalMoney = "TotalMoney";
        public static readonly string ConversionRates = "ConversionRates";
        public static readonly string Customer_Name = "Customer_Name";
        public static readonly string DocLineNo = "DocLineNo";
        public static readonly string Operators_Name = "Operators_Name";
        public static readonly string MainUOM_Round_Precision = "MainUOM_Round_Precision";
        public static readonly string MainUOM_Round_RoundType = "MainUOM_Round_RoundType";
        public static readonly string MainUOM_Round_RoundValue = "MainUOM_Round_RoundValue";
        public static readonly string InvUOM_Round_Precision = "InvUOM_Round_Precision";
        public static readonly string InvUOM_Round_RoundType = "InvUOM_Round_RoundType";
        public static readonly string InvUOM_Round_RoundValue = "InvUOM_Round_RoundValue";
        public static readonly string Memo = "Memo";

        #endregion

        private void DoMap()
        {
            map.Clear();
            //ID
            map.Add(ID, "ID");
            //单据日期
            map.Add(BusinessDate, "BusinessDate");
            //单据号
            map.Add(DocNo, "DocNo");
            //存货编码
            map.Add(ItemCode, "ItemCode");
            //存货名称
            map.Add(ItemName, "ItemName");
            //规格型号
            map.Add(SPECS, "SPEC");
            //主销售数量
            map.Add(MainSOQty, "MainSOQty");
            //主单位
            map.Add(MainUOM_Name, "MainUOM.Name");
            //主报价
            map.Add(FinallyPrice, "FinallyPrice");
            //辅销售数量
            map.Add(InvSOQty, "InvSOQty");
            //辅单位
            map.Add(InvUOM_Name, "InvUOM.Name");
            //金额
            map.Add(TotalMoney, "TotalMoney");
            //换算率
            map.Add(ConversionRates, "ConversionRates");
            //公司名称
            map.Add(Customer_Name, "Customer.Name");
            //行号
            map.Add(DocLineNo, "DocLineNo");
            //业务员
            map.Add(Operators_Name, "Operators.Name");
            //主单位_精度_精度
            map.Add(MainUOM_Round_Precision, "MainUOM.Round.Precision");
            //主单位_精度_舍入类型
            map.Add(MainUOM_Round_RoundType, "MainUOM.Round.RoundType");
            //主单位_精度_舍入值
            map.Add(MainUOM_Round_RoundValue, "MainUOM.Round.RoundValue");
            //辅单位_精度_精度
            map.Add(InvUOM_Round_Precision, "InvUOM.Round.Precision");
            //辅单位_精度_舍入类型
            map.Add(InvUOM_Round_RoundType, "InvUOM.Round.RoundType");
            //辅单位_精度_舍入值
            map.Add(InvUOM_Round_RoundValue, "InvUOM.Round.RoundValue");
            //备注
            map.Add(Memo, "Memo");
        }
    }

    #endregion

    #endregion
}