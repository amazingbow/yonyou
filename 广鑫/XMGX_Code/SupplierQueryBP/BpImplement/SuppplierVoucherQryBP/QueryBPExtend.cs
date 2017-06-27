using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.View.Query;
using UFIDA.U9.Cust.FJGX.SupplierQueryBP;
using UFSoft.UBF.Util.DataAccess;

namespace UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP
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
            return "UFIDA.U9.AP.APBill.APBillHead";
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
             this.DoMap();

            #region 应付单

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("APBillHead.ID", "ID");
            simpleTool1.AddSelect("APBillHead.DocNo", "DocNo");
            simpleTool1.AddSelect("APBillHead.DocumentType.Name", "DocTypeName");
            simpleTool1.AddSelect("Supplier.Name", "SupplierName");
            simpleTool1.AddSelect("APBillHead.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("APBillHead.CreatedBy", "CreatedBy");
            simpleTool1.AddSelect(@"(case when (APBillHead.BusinessType = 188 or APBillHead.BusinessType = 190) 
                then APBillHead.APOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool1.AddSelect(@"(case when (APBillHead.BusinessType = 187 or APBillHead.BusinessType = 189) 
                then APBillHead.APOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool1.AddSelect("APBillHead.Memo", "Memo");
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::AP::APBill::APBillHead as APBillHead");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb.Append(" on ");
            fromSb.Append("Supplier.ID = APBillHead.AccrueSupp.Supplier"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name) 
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APBillHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APBillHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool1.AddCondition(string.Format("APBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool1.AddCondition("APBillHead.BusinessType in (187,188,189,190)");
            simpleTool1.AddCondition("APBillHead.DocumentType.Code not in ('02','03','04','05','11','12','13')");
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString());
            
            #endregion

            #region 出货单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("Rcv.ID", "ID");
            simpleTool2.AddSelect("Rcv.DocNo", "DocNo");
            simpleTool2.AddSelect("Rcv.RcvDocType.Name", "DocTypeName");
            simpleTool2.AddSelect("Supplier.Name", "SupplierName");
            simpleTool2.AddSelect("Rcv.BusinessDate", "BusinessDate");
            simpleTool2.AddSelect("Rcv.CreatedBy", "CreatedBy");
            simpleTool2.AddSelect("case when Rcv.ReceivementType = 0 then Rcv.TotalArriveMnyAC else Rcv.TotalRtnDeductMnyAC*-1 end", "DebitMoney");
            simpleTool2.AddSelect("0.0", "CreditMoney");
            simpleTool2.AddSelect("case when Rcv.ReceivementType = 0 then '采购入库' else '采购退货' end", "Memo");
            StringBuilder fromSb2 = new StringBuilder();
            fromSb2.Append("UFIDA::U9::PM::Rcv::Receivement as Rcv");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb2.Append(" on ");
            fromSb2.Append("Supplier.ID = Rcv.Supplier.Supplier"); //客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Rcv.RcvDocType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Rcv." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool2.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool2.AddCondition(string.Format("Rcv.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool2.AddCondition("Rcv.ReceivementType in (0,1)");
            simpleTool2.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool2.SetFromClause(fromSb2.ToString()); 

            #endregion

            #region 付款单

            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("PayBillHead.ID", "ID");
            simpleTool3.AddSelect("PayBillHead.DocNo", "DocNo");
            simpleTool3.AddSelect("PayBillHead.DocumentType.Name", "DocTypeName");
            simpleTool3.AddSelect("Supplier.Name", "SupplierName");
            simpleTool3.AddSelect("PayBillHead.BusinessDate", "BusinessDate");
            simpleTool3.AddSelect("PayBillHead.CreatedBy", "CreatedBy");
            simpleTool3.AddSelect(@"0.0", "DebitMoney");
            simpleTool3.AddSelect(@"PayBillHead.TotalMoney.OCMoney", "CreditMoney");
            simpleTool3.AddSelect("PayBillHead.Memo", "Memo");
            StringBuilder fromSb3 = new StringBuilder();
            fromSb3.Append("UFIDA::U9::AP::Payment::PayBillHead as PayBillHead");
            fromSb3.Append(" left join ");
            fromSb3.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb3.Append(" on ");
            fromSb3.Append("Supplier.ID = PayBillHead.Supp.Supplier"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "PayBillHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "PayBillHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool3.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool3.AddCondition(string.Format("PayBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool3.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool3.SetFromClause(fromSb3.ToString());

            #endregion

            #region 应付对冲

            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("ARAPCAHead.ID", "ID");
            simpleTool4.AddSelect("ARAPCAHead.DocNo", "DocNo");
            simpleTool4.AddSelect("ARAPCAHead.DocumentType.Name", "DocTypeName");
            simpleTool4.AddSelect("Supplier.Name", "SupplierName");
            simpleTool4.AddSelect("ARAPCAHead.BusinessDate", "BusinessDate");
            simpleTool4.AddSelect("ARAPCAHead.CreatedBy", "CreatedBy");
            simpleTool4.AddSelect(@"0.0", "DebitMoney");
            simpleTool4.AddSelect(@"ARAPCAHead.ARCAMoney.OCMoney", "CreditMoney");
            simpleTool4.AddSelect("ARAPCAHead.Memo", "Memo");
            StringBuilder fromSb4 = new StringBuilder();
            fromSb4.Append("UFIDA::U9::AP::ARAPCounterApply::ARAPCAHead as ARAPCAHead");
            fromSb4.Append(" left join ");
            fromSb4.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb4.Append(" on ");
            fromSb4.Append("Supplier.ID = ARAPCAHead.Supplier.Supplier"); //客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCAHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCAHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool4.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool4.AddCondition(string.Format("ARAPCAHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool4.SetFromClause(fromSb4.ToString());

            #endregion

            #region 债权转移单

            #region 转出客户

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("APDTHead.ID", "ID");
            simpleTool5.AddSelect("APDTHead.DocNo", "DocNo");
            simpleTool5.AddSelect("APDTHead.DocumentType.Name", "DocTypeName");
            simpleTool5.AddSelect("Supplier.Name", "SupplierName");
            simpleTool5.AddSelect("APDTHead.BusinessDate", "BusinessDate");
            simpleTool5.AddSelect("APDTHead.CreatedBy", "CreatedBy");
            simpleTool5.AddSelect(@"sum(case when (APDTLine.TransOutBizType = 186 or APDTLine.TransOutBizType = 187 or APDTLine.TransOutBizType = 189) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool5.AddSelect(@"sum(case when (APDTLine.TransOutBizType = 188 or APDTLine.TransOutBizType = 190 or APDTLine.TransOutBizType = 192 or APDTLine.TransOutBizType = 193) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool5.AddSelect("APDTHead.Memo", "Memo");
            StringBuilder fromSb5 = new StringBuilder();
            fromSb5.Append("UFIDA::U9::AP::APDT::APDTLine as APDTLine");
            fromSb5.Append(" inner join ");
            fromSb5.Append("UFIDA::U9::AP::APDT::APDTHead as APDTHead");
            fromSb5.Append(" on ");
            fromSb5.Append("APDTLine.APDTHead = APDTHead.ID");
            fromSb5.Append(" left join ");
            fromSb5.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb5.Append(" on ");
            fromSb5.Append("Supplier.ID = APDTHead.TransOutAccrueSupp.Supplier"); //转出客户 
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APDTHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APDTHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool5.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool5.AddCondition(string.Format("APDTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool5.AddCondition("APDTHead.IsTransAccrueSupp = 1");
            simpleTool5.AddCondition("APDTHead.Cancel.Canceled = 0");//未作废
            simpleTool5.AddCondition("APDTLine.TransOutBizType in (186,187,188,189,190,192,193)");
            simpleTool5.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool5.SetFromClause(fromSb5.ToString());
            simpleTool5.AddGroup("APDTHead.ID,APDTHead.DocNo,APDTHead.DocumentType.Name,Supplier.ID,Supplier.Name,APDTHead.BusinessDate,APDTHead.CreatedBy,APDTHead.Memo");

            #endregion

            #region 转入客户

            SimpleOqlTool simpleTool6 = new SimpleOqlTool();
            simpleTool6.AddSelect("APDTHead.ID", "ID");
            simpleTool6.AddSelect("APDTHead.DocNo", "DocNo");
            simpleTool6.AddSelect("APDTHead.DocumentType.Name", "DocTypeName");
            simpleTool6.AddSelect("Supplier.Name", "SupplierName");
            simpleTool6.AddSelect("APDTHead.BusinessDate", "BusinessDate");
            simpleTool6.AddSelect("APDTHead.CreatedBy", "CreatedBy");
            simpleTool6.AddSelect(@"sum(case when (APDTLine.TransInBizType = 188 or APDTLine.TransInBizType = 190 or APDTLine.TransInBizType = 192 or APDTLine.TransInBizType = 193) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool6.AddSelect(@"sum(case when (APDTLine.TransInBizType = 186 or APDTLine.TransInBizType = 187 or APDTLine.TransInBizType = 189) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool6.AddSelect("APDTHead.Memo", "Memo");
            StringBuilder fromSb6 = new StringBuilder();
            fromSb6.Append("UFIDA::U9::AP::APDT::APDTLine as APDTLine");
            fromSb6.Append(" inner join ");
            fromSb6.Append("UFIDA::U9::AP::APDT::APDTHead as APDTHead");
            fromSb6.Append(" on ");
            fromSb6.Append("APDTLine.APDTHead = APDTHead.ID");
            fromSb6.Append(" left join ");
            fromSb6.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb6.Append(" on ");
            fromSb6.Append("Supplier.ID = APDTHead.TransInAccrueSupp.Supplier"); //转入客户 
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "SupplierName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Supplier.Name");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APDTHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "APDTHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool6.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool6.AddCondition(string.Format("APDTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool6.AddCondition("APDTHead.IsTransAccrueSupp = 1");
            simpleTool6.AddCondition("APDTHead.Cancel.Canceled = 0");//未作废
            simpleTool6.AddCondition("APDTLine.TransInBizType in (186,187,188,189,190,192,193)");
            simpleTool6.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool6.SetFromClause(fromSb6.ToString());
            simpleTool6.AddGroup("APDTHead.ID,APDTHead.DocNo,APDTHead.DocumentType.Name,Supplier.ID,Supplier.Name,APDTHead.BusinessDate,APDTHead.CreatedBy,APDTHead.Memo");

            #endregion

            #endregion

            #region 合计

            decimal sumDebitMoney = 0;
            decimal sumCreditMoney = 0;
            EntityViewQuery entityViewQuery = new EntityViewQuery();
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.DebitMoney)", "SumDebitMoney");
            sumSimpleTool.AddSelect("sum(sumOql.CreditMoney)", "SumCreditMoney");
            sumSimpleTool.SetFromClause(string.Concat(new string[]
			{
				"(",
				simpleTool1.GetOqlString(),
				" union all ",
				simpleTool2.GetOqlString(),
                " union all ",
				simpleTool3.GetOqlString(),
                " union all ",
				simpleTool4.GetOqlString(),
                " union all ",
				simpleTool5.GetOqlString(),
                " union all ",
				simpleTool6.GetOqlString(),
				") as sumOql "
			}));
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == "DebitMoney" || filterItem.Name == "CreditMoney")
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "sumOql." + filterItem.Name);
                    sumSimpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                }
            }
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumDebitMoney = DataRowConverter.AsDecimal(row, "SumDebitMoney");
                sumCreditMoney = DataRowConverter.AsDecimal(row, "SumCreditMoney");
            }

            #endregion

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("finallOql.ID", "ID");
            resultTool.AddSelect("row_number() over(order by finallOql.ID desc)", "sn");
            resultTool.AddSelect(sumDebitMoney.ToString("F2"), "SumDebitMoney");
            resultTool.AddSelect(sumCreditMoney.ToString("F2"), "SumCreditMoney");
            resultTool.AddSelect((sumDebitMoney - sumCreditMoney).ToString("F2"), "SumMoney");
            resultTool.AddSelect("convert(decimal(23,9),0)", "BalanceMoney");
            foreach (QryColumnItem current in bpParameter.QryColumnItems)
            {
                if (current.ColumnAlias == "SumDebitMoney" || current.ColumnAlias == "SumCreditMoney" || current.ColumnAlias == "SumMoney" || current.ColumnAlias == "BalanceMoney")
                    continue;
                resultTool.AddSelect("finallOql." + current.ColumnAlias, current.ColumnAlias);
            }
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == "DebitMoney" || filterItem.Name == "CreditMoney" || filterItem.Name == "BalanceMoney")
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "finallOql." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                }
            }
            resultTool.SetFromClause(string.Concat(new string[]
			{
				"(",
				simpleTool1.GetOqlString(),
				" union all ",
				simpleTool2.GetOqlString(),
                " union all ",
				simpleTool3.GetOqlString(),
                " union all ",
				simpleTool4.GetOqlString(),
                " union all ",
				simpleTool5.GetOqlString(),
                " union all ",
				simpleTool6.GetOqlString(),
				") as finallOql "
			}));
            string oqlString = resultTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                resultTool.AddOrder("finallOql." + sortItem.ColumnName,
                    sortItem.OrderType == OrderType.Ascend);
            }
            if (resultTool.Orders != null && resultTool.Orders.Count > 0)
            {
                oqlString = oqlString + " order by " + resultTool.Orders;
            }
            TempTableUtil.CreateTempTableByOql("ResultTable", oqlString, entityViewQuery);
            DataParamList paramList = new DataParamList();
            paramList.Add(DataParamFactory.CreateInput("@SumMoney", sumDebitMoney - sumCreditMoney, DbType.Decimal));
            DataAccessor.RunSP(DatabaseManager.GetCurrentConnection(), "dbo.FJGX_CustomerQuery_SetBalanceMoney", paramList);

            return "select * from #ResultTable";
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
            QryPaginateService<SuppplierVoucherQryDTO> ps = new QryPaginateService<SuppplierVoucherQryDTO>(bpParameter,
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
        public readonly static string SupplierName = "SupplierName";
        public readonly static string DocNo = "DocNo";
        public readonly static string DocTypeName = "DocTypeName";
        public readonly static string BusinessDate = "BusinessDate";
        public readonly static string CreatedBy = "CreatedBy";
        public readonly static string DebitMoney = "DebitMoney";
        public readonly static string CreditMoney = "CreditMoney";
        public readonly static string SumDebitMoney = "SumDebitMoney";
        public readonly static string SumCreditMoney = "SumCreditMoney";
        public readonly static string SumMoney = "SumMoney";
        public readonly static string BalanceMoney = "BalanceMoney";
        public readonly static string Memo = "Memo";
        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //公司名称
            map.Add(SupplierName, "SupplierName");
            //单据号
            map.Add(DocNo, "DocNo");
            //单据类型
            map.Add(DocTypeName, "DocTypeName");
            //制单日期
            map.Add(BusinessDate, "BusinessDate");
            //制单人
            map.Add(CreatedBy, "CreatedBy");
            //借方金额
            map.Add(DebitMoney, "DebitMoney");
            //贷方金额
            map.Add(CreditMoney, "CreditMoney");
            //合计借方金额
            map.Add(SumDebitMoney, "SumDebitMoney");
            //合计贷方金额
            map.Add(SumCreditMoney, "SumCreditMoney");
            //合计金额
            map.Add(SumMoney, "SumMoney");
            //小计
            map.Add(BalanceMoney, "BalanceMoney");
            //摘要
            map.Add(Memo, "Memo");
        }
    }

    #endregion

    #endregion
}