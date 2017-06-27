using UFIDA.U9.Base;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.FJGX.SOLineInfoQryBP
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.View.Query;

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
    ///     Impement Implement
    /// </summary>
    internal partial class QueryBPImpementStrategy : BaseStrategy
    {
        public QueryBPImpementStrategy()
        {
        }

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
            return "UFIDA.U9.SM.SO.SOLine";
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
            return true;
        } //end isNeedMultiLang

        /// <summary>
        ///     执行业务逻辑，返回OQL串，由BP开发人员添加代码。
        ///     参数bpParameter中带有已选栏目、过滤及排序信息
        /// </summary>
        /// <returns></returns>
        private string DoLogic(QryCommonParaObj bpParameter)
        {
            DoMap();
            EntityViewQuery entityViewQuery = new EntityViewQuery();
            //必须引用UFIDA.UBF.Report.App.Data.dll
            #region 销售订单
            SimpleOqlTool simpleTool = new SimpleOqlTool();
            simpleTool.AddSelect("SOLine.SO", "ID");
            simpleTool.AddSelect("SOLine.ID", "SOLine_ID");
            foreach (string strKey in map.Keys)
            {
                switch (strKey)
                {
                    case "ID":
                        break;
                    case "TotalShipQty":
                        simpleTool.AddSelect("SOLine.SOLineSumInfo.SumShipQtyTU", strKey);
                        break;
                    case "TotalShipMoney":
                        simpleTool.AddSelect(@"SOLine.SOLineSumInfo.SumShipQtyTU*SOLine.FinallyPriceTC-(select ReprtLine.AROCMoney.TotalMoney  from UFIDA::U9::AR::ARBill::ARBillLine ReprtLine 
                                                        left join UFIDA::U9::AR::ARBill::MemosRelateInvoiceDetail detail on detail.RelARBillLine=ReprtLine.ID
                                                        left join UFIDA::U9::AR::ARBill::ARBillLine ArLine  on detail.ARBillLine=ArLine.ID
                                                        left join UFIDA::U9::SM::Ship::ShipLine as ShipLine  on ArLine.SrcBillSMLineID = ShipLine.ID
                                                        where ShipLine.SrcDocLineKey = SOLine.ID)", strKey);
                        break;
                    case "AfterAdjustedMoney":
                        simpleTool.AddSelect(@"(select ReprtLine.AROCMoney.TotalMoney  from UFIDA::U9::AR::ARBill::ARBillLine ReprtLine 
                                                        left join UFIDA::U9::AR::ARBill::MemosRelateInvoiceDetail detail on detail.RelARBillLine=ReprtLine.ID
                                                        left join UFIDA::U9::AR::ARBill::ARBillLine ArLine  on detail.ARBillLine=ArLine.ID
                                                        left join UFIDA::U9::SM::Ship::ShipLine as ShipLine  on ArLine.SrcBillSMLineID = ShipLine.ID
                                                        where ShipLine.SrcDocLineKey = SOLine.ID)", strKey);
                        break;
                    case "AfterAdjustedPrice":
                        simpleTool.AddSelect(@"(SOLine.SOLineSumInfo.SumShipQtyTU*SOLine.FinallyPriceTC-(select ReprtLine.AROCMoney.TotalMoney  from UFIDA::U9::AR::ARBill::ARBillLine ReprtLine 
                                                        left join UFIDA::U9::AR::ARBill::MemosRelateInvoiceDetail detail on detail.RelARBillLine=ReprtLine.ID
                                                        left join UFIDA::U9::AR::ARBill::ARBillLine ArLine  on detail.ARBillLine=ArLine.ID
                                                        left join UFIDA::U9::SM::Ship::ShipLine as ShipLine  on ArLine.SrcBillSMLineID = ShipLine.ID
                                                        where ShipLine.SrcDocLineKey = SOLine.ID))/SOLine.SOLineSumInfo.SumShipQtyTU", strKey);
                        break;
                    //UFIDA::U9::SM::Ship::ShipLine SrcDocLineKey 
                    default:
                        simpleTool.AddSelect(this.map[strKey], strKey);
                        break;
                }
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            //simpleTool.AddCondition(bpParameter.FilterOpath);
            simpleTool.AddCondition(string.Format("SOLine.Org = {0}", Context.LoginOrg.ID));
            //处理From部份，形成From子句
            simpleTool.SetFromClause("UFIDA::U9::SM::SO::SOLine as SOLine"); //在这里替换From子句中的实体名称
            #endregion
            #region 退回处理单
            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("SOLine.RMA", "ID");
            simpleTool1.AddSelect("SOLine.ID", "SOLine_ID");
            foreach (string strKey in map.Keys)
            {
                switch (strKey)
                {
                    case "ID":
                        break;
                    case "SOLine_PU_Name":
                        simpleTool1.AddSelect("SOLine.TU.Name", strKey);
                        break;
                    case "SOLine_CU_Name":
                        simpleTool1.AddSelect("SOLine.ItemInfo.ItemID.CostUOM.Name", strKey);
                        break;
                    case "SOLine_OrderByQtyTU":
                    case "TotalShipQty":
                        simpleTool1.AddSelect("SOLine.RtnQtyTU1 ", strKey);
                        break;
                    case "SOLine_FinallyPriceTC":
                        simpleTool1.AddSelect("SOLine.RtnPice ", strKey);
                        break;
                    case "SOLine_TotalMoneyTC":
                    case "TotalShipMoney":
                        simpleTool1.AddSelect("SOLine.RtnMoneyTC ", strKey);
                        break;
                    case "SOLine_Memo":
                        simpleTool1.AddSelect("SOLine.Remark ", strKey);
                        break;
                    case "AfterAdjustedMoney":
                    case "AfterAdjustedPrice":
                        simpleTool1.AddSelect("0.0", strKey);
                        break;
                    default:
                        simpleTool1.AddSelect(this.map[strKey], strKey);
                        break;
                }
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr = string.Empty;
                switch (filterItem.Name)
                {
                    case "TotalShipQty":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SOLine.RtnQtyTU1");
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "TotalShipMoney":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SOLine.RtnMoneyTC");
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                }
            }
            //simpleTool1.AddCondition(bpParameter.FilterOpath);
            simpleTool1.AddCondition(string.Format("SOLine.Org = {0}", Context.LoginOrg.ID));
            //处理From部份，形成From子句
            simpleTool1.SetFromClause("UFIDA::U9::SM::RMA::RMALine as SOLine"); //在这里替换From子句中的实体名称
            #endregion
            SimpleOqlTool totalSimpleTool = new SimpleOqlTool();
            foreach (string strKey in map.Keys)
            {
                totalSimpleTool.AddSelect(strKey, strKey);
            }
            totalSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool.GetOqlString(),
                " union all ",
                simpleTool1.GetOqlString(),
                ") as SO"
            }));
            totalSimpleTool.AddCondition(bpParameter.FilterOpath);
            TempTableUtil.CreateTempTableByOql("SOLineTempTable", totalSimpleTool.GetOqlString(), entityViewQuery);
            ObjectQuery query = entityViewQuery.CreateQuery("select * from SOLineTempTable");
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.SOLine_ID", "ID");//如果列表中ID重复的话，多条只会显示一条
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#SOLineTempTable as A ");
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
            QryPaginateService<SOLineInfoQryDTO> ps = new QryPaginateService<SOLineInfoQryDTO>(bpParameter,
                isNeedTempTable());
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
        private IDictionary<String, String> map = new Dictionary<String, String>();

        #region 实体属性对应的别名定义
        public readonly static string ID = "ID";
        public readonly static string SOLine_ID = "SOLine_ID";
        public readonly static string SOLine_DocLineNo = "SOLine_DocLineNo";
        public readonly static string SOLine_ItemInfo_ItemCode = "SOLine_ItemInfo_ItemCode";
        public readonly static string SOLine_ItemInfo_ItemName = "SOLine_ItemInfo_ItemName";
        public readonly static string SOLine_ItemInfo_ItemID_SPECS = "SOLine_ItemInfo_ItemID_SPECS";
        public readonly static string SOLine_PU_Name = "SOLine_PU_Name";
        public readonly static string SOLine_CU_Name = "SOLine_CU_Name";
        public readonly static string SOLine_OrderByQtyTU = "SOLine_OrderByQtyTU";
        public readonly static string SOLine_FinallyPriceTC = "SOLine_FinallyPriceTC";
        public readonly static string SOLine_TotalMoneyTC = "SOLine_TotalMoneyTC";
        public readonly static string SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = "SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5";
        public readonly static string SOLine_Memo = "SOLine_Memo";
        public readonly static string SOLine_TU_Round_Precision = "SOLine_TU_Round_Precision";
        public readonly static string SOLine_TU_Round_RoundType = "SOLine_TU_Round_RoundType";
        public readonly static string SOLine_TU_Round_RoundValue = "SOLine_TU_Round_RoundValue";
        public readonly static string TotalShipQty = "TotalShipQty";
        public readonly static string TotalShipMoney = "TotalShipMoney";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //ID
            map.Add(SOLine_ID, "SOLine.ID");
            //行号
            map.Add(SOLine_DocLineNo, "SOLine.DocLineNo");
            //料号
            map.Add(SOLine_ItemInfo_ItemCode, "SOLine.ItemInfo.ItemCode");
            //品名
            map.Add(SOLine_ItemInfo_ItemName, "SOLine.ItemInfo.ItemName");
            //型号
            map.Add(SOLine_ItemInfo_ItemID_SPECS, "SOLine.ItemInfo.ItemID.SPECS");
            //名称
            map.Add(SOLine_PU_Name, "SOLine.PU.Name");
            //名称
            map.Add(SOLine_CU_Name, "SOLine.CU.Name");
            //数量
            map.Add(SOLine_OrderByQtyTU, "SOLine.OrderByQtyTU");
            //单价
            map.Add(SOLine_FinallyPriceTC, "SOLine.FinallyPriceTC");
            //金额
            map.Add(SOLine_TotalMoneyTC, "SOLine.TotalMoneyTC");
            //包装数
            map.Add(SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5, "SOLine.ItemInfo.ItemID.DescFlexField.PrivateDescSeg5");
            //备注
            map.Add(SOLine_Memo, "SOLine.Memo");
            //销售单位_精度_精度
            map.Add(SOLine_TU_Round_Precision, "SOLine.TU.Round.Precision");
            //销售单位_精度_舍入类型
            map.Add(SOLine_TU_Round_RoundType, "SOLine.TU.Round.RoundType");
            //销售单位_精度_舍入值
            map.Add(SOLine_TU_Round_RoundValue, "SOLine.TU.Round.RoundValue");
            //累计出货数量
            map.Add(TotalShipQty, "TotalShipQty");
            //累计出货金额
            map.Add(TotalShipMoney, "TotalShipMoney");
        }
    }

    #endregion

    #endregion


}