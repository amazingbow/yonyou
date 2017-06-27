using System;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;

namespace UIFIA.U9.Cust.FJGX.RcvLineQryBP
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
            //TODO:
            return "UFIDA.U9.PM.Rcv.RcvLine";
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
            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("RcvLine.ID", "ID");
            simpleTool1.AddSelect("RcvLine.DocLineNo", "DocLineNo");
            simpleTool1.AddSelect("Rcv.DocNo", "DocNo");
            //制单人
            simpleTool1.AddSelect("Rcv.CreatedBy", "CreatedBy");
            simpleTool1.AddSelect("Rcv.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("RcvLine.ItemInfo.ItemCode", "ItemCode");
            simpleTool1.AddSelect("RcvLine.ItemInfo.ItemName", "ItemName");
            simpleTool1.AddSelect("RcvLine.ItemInfo.ItemID.SPECS", "SPEC");
            simpleTool1.AddSelect("RcvLine.FinallyPriceTC", "FinallyPriceTC");
            simpleTool1.AddSelect(
               "case when Rcv.ReceivementType = 0 then RcvLine.ArriveTotalMnyTC else RcvLine.RtnDeductMnyTC end",
               "ArriveTotalMnyTC");
            //采购单位
            simpleTool1.AddSelect(
                "case when Rcv.ReceivementType = 0 then RcvLine.ArriveQtyTU else RcvLine.RtnDeductQtyTU end",
                "QtyTU");
            simpleTool1.AddSelect("RcvLine.TradeUOM.Name", "TradeUOMName");
            //库存单位
            simpleTool1.AddSelect(
               "case when Rcv.ReceivementType = 0 then RcvLine.ArriveQtySU else RcvLine.RtnDeductQtySU end",
               "QtySU");
            simpleTool1.AddSelect("RcvLine.StoreUOM.Name", "StoreUOMName");
            //成本单位
            simpleTool1.AddSelect(
               "case when Rcv.ReceivementType = 0 then RcvLine.ArriveQtyCU else RcvLine.RtnDeductQtyCU end",
               "QtyCU");
            simpleTool1.AddSelect("RcvLine.CostUOM.Name", "CostUOMName");
            //批号
            simpleTool1.AddSelect("RcvLine.InvLotCode", "LotCode");
            //换算率
            simpleTool1.AddSelect("ItemConvertRatioInClass.Ratio", "Ratio");
            //件数
            simpleTool1.AddSelect(@"(case when RcvLine.StoreUOM = RcvLine.CostUOM and ItemConvertRatioInClass.Ratio != 0 then 
                (case when Rcv.ReceivementType = 0 then RcvLine.ArriveQtySU else RcvLine.RtnDeductQtySU end)/ItemConvertRatioInClass.Ratio else null end)", "PieceQty");
            //备注
            simpleTool1.AddSelect("RcvLine.Memo", "Memo");
            //采购单位_精度_精度
            simpleTool1.AddSelect("RcvLine.TradeUOM.Round.Precision", TradeUOM_Round_Precision);
            //采购单位_精度_舍入类型
            simpleTool1.AddSelect("RcvLine.TradeUOM.Round.RoundType", TradeUOM_Round_RoundType);
            //采购单位_精度_舍入值
            simpleTool1.AddSelect("RcvLine.TradeUOM.Round.RoundValue", TradeUOM_Round_RoundValue);
            //库存单位_精度_精度
            simpleTool1.AddSelect("RcvLine.StoreUOM.Round.Precision", StoreUOM_Round_Precision);
            //库存单位_精度_舍入类型
            simpleTool1.AddSelect("RcvLine.StoreUOM.Round.RoundType", StoreUOM_Round_RoundType);
            //库存单位_精度_舍入值
            simpleTool1.AddSelect("RcvLine.StoreUOM.Round.RoundValue", StoreUOM_Round_RoundValue);
            //成本单位_精度_精度
            simpleTool1.AddSelect("RcvLine.CostUOM.Round.Precision", CostUOM_Round_Precision);
            //成本单位_精度_舍入类型
            simpleTool1.AddSelect("RcvLine.CostUOM.Round.RoundType", CostUOM_Round_RoundType);
            //成本单位_精度_舍入值
            simpleTool1.AddSelect("RcvLine.CostUOM.Round.RoundValue", CostUOM_Round_RoundValue);

            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "ItemCode":
                    case "ItemName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RcvLine.ItemInfo." + filterItem.Name);
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "SPECS":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name,
                            "RcvLine.ItemInfo.ItemID" + filterItem.Name);
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Rcv." + filterItem.Name);
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    default:
                        break;
                }
            }
            simpleTool1.AddCondition("Rcv.ReceivementType in (0,1)");
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::PM::Rcv::RcvLine as RcvLine");
            fromSb.Append(" inner join ");
            fromSb.Append("UFIDA::U9::PM::Rcv::Receivement as Rcv");
            fromSb.Append(" on ");
            fromSb.Append("RcvLine.Receivement = Rcv.ID");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb.Append(" on ");
            fromSb.Append("Supplier.ID = Rcv.Supplier.Supplier"); //客户联系人 = 默认
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Item::ItemConvertRatioInClass as ItemConvertRatioInClass");
            fromSb.Append(" on ");
            fromSb.Append("RcvLine.ItemInfo.ItemID = ItemConvertRatioInClass.ItemMaster");
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("RcvLineTempTable", simpleTool1.GetOqlString(), entityViewQuery);

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#RcvLineTempTable as A ");
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
            QryPaginateService<RcvLineQryDTO> ps = new QryPaginateService<RcvLineQryDTO>(bpParameter, isNeedTempTable());
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
        public static readonly string DocLineNo = "DocLineNo";
        public static readonly string ItemCode = "ItemCode";
        public static readonly string ItemName = "ItemName";
        public static readonly string BusinessDate = "BusinessDate";
        public static readonly string DocNo = "DocNo";
        public static readonly string SPEC = "SPEC";
        public static readonly string QtyTU = "QtyTU";
        public static readonly string TradeUOMName = "TradeUOMName";
        public static readonly string QtySU = "QtySU";
        public static readonly string StoreUOMName = "StoreUOMName";
        public static readonly string QtyCU = "QtyCU";
        public static readonly string CostUOMName = "CostUOMName";
        public static readonly string LotCode = "LotCode";
        public static readonly string FinallyPriceTC = "FinallyPriceTC";
        public static readonly string ArriveTotalMnyTC = "ArriveTotalMnyTC";
        public static readonly string Ratio = "Ratio";
        public static readonly string PieceQty = "PieceQty";
        public static readonly string CreatedBy = "CreatedBy";
        public static readonly string Memo = "Memo";
        public static readonly string TradeUOM_Round_Precision = "TradeUOM_Round_Precision";
        public static readonly string TradeUOM_Round_RoundType = "TradeUOM_Round_RoundType";
        public static readonly string TradeUOM_Round_RoundValue = "TradeUOM_Round_RoundValue";
        public static readonly string StoreUOM_Round_Precision = "StoreUOM_Round_Precision";
        public static readonly string StoreUOM_Round_RoundType = "StoreUOM_Round_RoundType";
        public static readonly string StoreUOM_Round_RoundValue = "StoreUOM_Round_RoundValue";
        public static readonly string CostUOM_Round_Precision = "CostUOM_Round_Precision";
        public static readonly string CostUOM_Round_RoundType = "CostUOM_Round_RoundType";
        public static readonly string CostUOM_Round_RoundValue = "CostUOM_Round_RoundValue";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //行号
            map.Add(DocLineNo, "DocLineNo");
            //存货编码
            map.Add(ItemCode, "ItemCode");
            //存货名称
            map.Add(ItemName, "ItemName");
            //单据日期
            map.Add(BusinessDate, "BusinessDate");
            //单据号
            map.Add(DocNo, "DocNo");
            //规格
            map.Add(SPEC, "SPEC");
            //采购数量
            map.Add(QtyTU, "QtyTU");
            //采购单位
            map.Add(TradeUOMName, "TradeUOMName");
            //库存数量
            map.Add(QtySU, "QtySU");
            //库存单位
            map.Add(StoreUOMName, "StoreUOMName");
            //成本数量
            map.Add(QtyCU, "QtyCU");
            //成本单位
            map.Add(CostUOMName, "CostUOMName");
            //批号
            map.Add(LotCode, "LotCode");
            //单价
            map.Add(FinallyPriceTC, "FinallyPriceTC");
            //金额
            map.Add(ArriveTotalMnyTC, "ArriveTotalMnyTC");
            //换算率
            map.Add(Ratio, "Ratio");
            //件数
            map.Add(PieceQty, "PieceQty");
            //制单人
            map.Add(CreatedBy, "CreatedBy");
            //备注
            map.Add(Memo, "Memo");
            //采购单位_精度_精度
            map.Add(TradeUOM_Round_Precision, "TradeUOM.Round.Precision");
            //采购单位_精度_舍入类型
            map.Add(TradeUOM_Round_RoundType, "TradeUOM.Round.RoundType");
            //采购单位_精度_舍入值
            map.Add(TradeUOM_Round_RoundValue, "TradeUOM.Round.RoundValue");
            //库存单位_精度_精度
            map.Add(StoreUOM_Round_Precision, "StoreUOM.Round.Precision");
            //库存单位_精度_舍入类型
            map.Add(StoreUOM_Round_RoundType, "StoreUOM.Round.RoundType");
            //库存单位_精度_舍入值
            map.Add(StoreUOM_Round_RoundValue, "StoreUOM.Round.RoundValue");
            //成本单位_精度_精度
            map.Add(CostUOM_Round_Precision, "CostUOM.Round.Precision");
            //成本单位_精度_舍入类型
            map.Add(CostUOM_Round_RoundType, "CostUOM.Round.RoundType");
            //成本单位_精度_舍入值
            map.Add(CostUOM_Round_RoundValue, "CostUOM.Round.RoundValue");
        }
    }

    #endregion

    #endregion
}