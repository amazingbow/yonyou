using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.FJGX.SupplierQueryBP;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.SupplierDocListQryBP
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
            return "UFIDA.U9.PM.Rcv.Receivement";
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
            simpleTool1.AddSelect("Rcv.ID", "ID");
            simpleTool1.AddSelect("Rcv.DocNo", "DocNo");
            simpleTool1.AddSelect("Rcv.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect(@"case when Rcv.ReceivementType = 0 then 
                (select sum(A.ArriveTotalMnyAC - A.PayedMnyAC) from UFIDA::U9::PM::Rcv::RcvLine A where A.Receivement = Rcv.ID) else Rcv.TotalRtnDeductMnyAC * -1 end",
                "SumUnPayedMnyTC");
            simpleTool1.AddSelect("Rcv.Supplier.Supplier.Purchaser.Name", "OperatorsName");
            simpleTool1.AddSelect("Rcv.CreatedBy", "CreatedBy");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Rcv." + filterItem.Name);
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "OperatorsName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Rcv.Supplier.Supplier.Purchaser.Name");
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    default:
                        break;
                }
            }
            simpleTool1.AddCondition("Rcv.ReceivementType in (0,1)");
            simpleTool1.AddCondition(string.Format("Rcv.Org  = {0}", Context.LoginOrg.ID));
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::PM::Rcv::Receivement as Rcv");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb.Append(" on ");
            fromSb.Append("Supplier.ID = Rcv.Supplier.Supplier"); //客户联系人 = 默认
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("RcvTable", simpleTool1.GetOqlString(), entityViewQuery);


            //合计总额
            decimal sumTotalUnPayedMnyTC = 0;
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.SumUnPayedMnyTC)", "SumTotalUnPayedMnyTC");
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != SumUnPayedMnyTC) continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "sumOql." + filterItem.Name);
                sumSimpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            sumSimpleTool.SetFromClause("#RcvTable as sumOql");
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumTotalUnPayedMnyTC = DataRowConverter.AsDecimal(row, "SumTotalUnPayedMnyTC");
            }

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumTotalUnPayedMnyTC.ToString("F2"), "SumTotalUnPayedMnyTC");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#RcvTable as A");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == SumUnPayedMnyTC)
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "A." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                        filterItem.ValueType);
                }
            }
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
            QryPaginateService<SupplierDocListQryDTO> ps = new QryPaginateService<SupplierDocListQryDTO>(bpParameter,
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
        private readonly IDictionary<String, String> map = new Dictionary<String, String>();

        #region 实体属性对应的别名定义

        public static readonly string ID = "ID";
        public static readonly string DocNo = "DocNo";
        public static readonly string BusinessDate = "BusinessDate";
        public static readonly string SumUnPayedMnyTC = "SumUnPayedMnyTC";
        public static readonly string OperatorsName = "OperatorsName";
        public static readonly string CreatedBy = "CreatedBy";
        public readonly static string SumTotalUnPayedMnyTC = "SumTotalUnPayedMnyTC";
        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //单号
            map.Add(DocNo, "DocNo");
            //入库时间
            map.Add(BusinessDate, "BusinessDate");
            //应付余额
            map.Add(SumUnPayedMnyTC, "SumUnPayedMnyTC");
            //业务员
            map.Add(OperatorsName, "OperatorsName");
            //制单人
            map.Add(CreatedBy, "CreatedBy");
            //合计应付余额
            map.Add(SumTotalUnPayedMnyTC, "SumTotalUnPayedMnyTC");
        }
    }

    #endregion

    #endregion
}