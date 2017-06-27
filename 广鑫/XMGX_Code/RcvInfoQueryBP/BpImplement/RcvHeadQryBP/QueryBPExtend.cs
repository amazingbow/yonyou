using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFSoft.UBF.View.Query;
using UIFIA.U9.Cust.FJGX.RcvInfoQueryBP.PubBase;

namespace UIFIA.U9.Cust.FJGX.RcvHeadQryBP
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

            #region 收货、退货

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("Rcv.ID", "ID");
            simpleTool1.AddSelect("Rcv.DocNo", "DocNo");
            simpleTool1.AddSelect("Rcv.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("Supplier.Code", "SupplierCode");
            simpleTool1.AddSelect("Supplier.Name", "SupplierName");
            simpleTool1.AddSelect("SupplierContact.Contact.Name", "SupplierContactName");
            simpleTool1.AddSelect(
                @"case when Rcv.ReceivementType = 0 then Rcv.TotalArriveMnyAC else Rcv.TotalRtnDeductMnyAC * -1 end",
                "TotalMoney");
            simpleTool1.AddSelect("Rcv.CreatedBy", "CreatedBy");
            simpleTool1.AddSelect("Rcv.Memo", "Memo");
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
                    case "SupplierCode":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Code");
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "SupplierContactName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SupplierContact.Contact.Name");
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
            fromSb.Append("Supplier.ID = Rcv.Supplier.Supplier");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::SupplierContact as SupplierContact"); //供应商联系人
            fromSb.Append(" on ");
            fromSb.Append("SupplierContact.Supplier = Supplier.ID and SupplierContact.IsDefault = 1"); //供应商联系人 = 默认
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("RcvTable", simpleTool1.GetOqlString(), entityViewQuery); 

            #endregion

            #region 计算合计金额

            decimal sumTotalMoney = 0;
            //合计总额
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.TotalMoney)", "SumTotalMoney");
            sumSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool1.GetOqlString(),
                ") as sumOql "
            }));
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != TotalMoney) continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "sumOql." + filterItem.Name);
                sumSimpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumTotalMoney = DataRowConverter.AsDecimal(row, "SumTotalMoney");
            }

            #endregion

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumTotalMoney.ToString("F2"), "SumTotalMoney");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == SumTotalMoney) continue;
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#RcvTable as A");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != TotalMoney) continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "A." + filterItem.Name);
                resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
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
            QryPaginateService<RcvHeadQryDTO> ps = new QryPaginateService<RcvHeadQryDTO>(bpParameter, isNeedTempTable());
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
        public readonly static string DocNo = "DocNo";
        public readonly static string BusinessDate = "BusinessDate";
        public readonly static string SupplierCode = "SupplierCode";
        public readonly static string SupplierName = "SupplierName";
        public readonly static string SupplierContactName = "SupplierContactName";
        public readonly static string TotalMoney = "TotalMoney";
        public readonly static string CreatedBy = "CreatedBy";
        public readonly static string Memo = "Memo";
        public readonly static string SumTotalMoney = "SumTotalMoney";
        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //收发单据号
            map.Add(DocNo, "DocNo");
            //单据日期
            map.Add(BusinessDate, "BusinessDate");
            //供应商编码
            map.Add(SupplierCode, "SupplierCode");
            //供应商名称
            map.Add(SupplierName, "SupplierName");
            //供应商联系人
            map.Add(SupplierContactName, "SupplierContactName");
            //金额
            map.Add(TotalMoney, "TotalMoney");
            //制单人
            map.Add(CreatedBy, "CreatedBy");
            //备注
            map.Add(Memo, "Memo");
            //合计金额
            map.Add(SumTotalMoney, "SumTotalMoney");
        }
    }

    #endregion

    #endregion
}