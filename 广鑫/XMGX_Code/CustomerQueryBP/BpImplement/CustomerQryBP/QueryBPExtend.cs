using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.FJGX.PubBase;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.Business;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.CustomerQryBP
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
            return "UFIDA.U9.CBO.SCM.Customer.Customer";
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
            //创建客户临时表
            CreateCustomerTable(bpParameter, entityViewQuery);
            //实际应收临时表
            CreateARTotalMoneyTable(bpParameter, entityViewQuery);
            //最后交易额临时表
            CreateLastSOTotalMoneyTCTable(bpParameter, entityViewQuery);
            //最近一笔收款金额临时表
            CreateLastRecBillTotalMoneyTable(bpParameter, entityViewQuery);
            //创建结果临时表
            CreateResultTable(bpParameter, entityViewQuery);
            //获取合计应付金额
            decimal sumBalanceTotalMoney = GetSumBalanceTotalMoney(entityViewQuery);

            #region 返回结果

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("A.Customer_ID", "Customer_ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumBalanceTotalMoney.ToString("F2"), SumBalanceTotalMoney);
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#ResultTable as A");
            string oqlString = resultTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
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

            #endregion
        }

        /// <summary>
        /// 创建客户临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateCustomerTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool sqlTool = new SimpleOqlTool();
            sqlTool.AddSelect("ID", "ID");
            sqlTool.AddSelect("Customer.ID", "Customer_ID");
            sqlTool.AddSelect("Customer.Code", "Customer_Code");
            //1.处理栏目，形成Select子句
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == AROCMoneyBalance_TotalMoney ||
                    columnitem.ColumnAlias == LastSOTotalMoneyTC ||
                    columnitem.ColumnAlias == LastRecBillTotalMoney)
                    continue;
                sqlTool.AddSelect(this.map[columnitem.ColumnAlias], columnitem.ColumnAlias);
            }
            string leftExpr;
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == AROCMoneyBalance_TotalMoney ||
                    filterItem.Name == LastSOTotalMoneyTC ||
                    filterItem.Name == LastRecBillTotalMoney)
                    continue;
                if (filterItem.LeftExpr == Customer_CustomerCategory)
                {
                    leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.CustomerCategory.Code");
                }
                else
                {
                    leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                }
                sqlTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            sqlTool.AddCondition(bpParameter.FilterOpath);
            sqlTool.AddCondition(string.Format("Customer.Org = {0}", Context.LoginOrg.ID));

            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::CustomerContact as CustomerContact"); //客户联系人
            fromSb.Append(" on ");
            fromSb.Append("CustomerContact.Customer = Customer.ID and CustomerContact.IsDefault = 1"); //客户联系人 = 默认
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::CustomerBankAccount as CustomerBankAccount"); //客户银行账号 
            fromSb.Append(" on ");
            fromSb.Append("CustomerBankAccount.Customer = Customer.ID and CustomerBankAccount.IsDefault = 1");
            //客户银行账号 = 默认
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CC::CreditParameter::CreditControlObject as CreditObject");
            fromSb.Append(" on ");
            fromSb.Append("CreditObject.ObjectType = 0 and CreditObject.Customer = Customer.ID"); //对象类型 = 客户
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CC::CreditObjectPolicy::ObjectCreditPolicy as ObjectCreditPolicy");
            fromSb.Append(" on ");
            fromSb.Append("ObjectCreditPolicy.CreditObject = CreditObject.ID"); //对象类型 = 客户
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CC::CreditObjectPolicy::ObjectCreditLevelApproval as ObjectCreditLevelApproval"); //对象信用等级评定表   
            fromSb.Append(" on ");
            fromSb.Append("ObjectCreditLevelApproval.ObjectCreditPolicy = ObjectCreditPolicy.ID and ObjectCreditLevelApproval.ObjectCreditLevel is not null");
            //处理From部份，形成From子句
            sqlTool.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("CustomerTable", sqlTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 实际应收临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateARTotalMoneyTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            #region 应收单

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("ARBillHead.AccrueCust.Customer.Code", "CustomerCode");
            simpleTool1.AddSelect(@"(case when (ARBillHead.BusinessType = 2 or ARBillHead.BusinessType = 4) 
                then ARBillHead.AROCMoney.TotalMoney else 0 end)", "DebitMoney");
            simpleTool1.AddSelect(@"(case when (ARBillHead.BusinessType = 1 or ARBillHead.BusinessType = 3) 
                then ARBillHead.AROCMoney.TotalMoney else 0 end)", "CreditMoney");
            simpleTool1.AddCondition(string.Format("ARBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool1.AddCondition("ARBillHead.BusinessType in (1,2,3,4)");
            simpleTool1.AddCondition("ARBillHead.DocumentType.Code not in ('01','02','04')");
            simpleTool1.AddCondition("ARBillHead.AccrueCust.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool1.SetFromClause("UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead");

            #endregion

            #region 出货单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("Ship.OrderBy.Customer.Code", "CustomerCode");
            simpleTool2.AddSelect("Ship.TotalMoney", "DebitMoney");
            simpleTool2.AddSelect("0.0", "CreditMoney");
            simpleTool2.AddCondition(string.Format("Ship.OperatingOrg = {0}", Base.Context.LoginOrg.ID));
            simpleTool2.AddCondition("Ship.OrderBy.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool2.SetFromClause("UFIDA::U9::SM::Ship::Ship as Ship");

            #endregion

            #region 退回处理单

            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("RMA.Customer.Customer.Code", "CustomerCode");
            simpleTool3.AddSelect(@"(select sum(RMALine.RtnMoneyTC)*-1 as SumRtnMoneyTC from UFIDA::U9::SM::RMA::RMALine as RMALine 
                where RMALine.RMA = RMA.ID)", "DebitMoney");
            simpleTool3.AddSelect(@"0.0", "CreditMoney");
            simpleTool3.AddCondition(string.Format("RMA.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool3.AddCondition("RMA.Customer.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool3.SetFromClause("UFIDA::U9::SM::RMA::RMA as RMA");

            #endregion

            #region 收款单

            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("RecBillHead.Cust.Customer.Code", "CustomerCode");
            simpleTool4.AddSelect(@"0", "DebitMoney");
            simpleTool4.AddSelect(@"RecBillHead.TotalMoney.OCMoney", "CreditMoney");
            simpleTool4.AddCondition(string.Format("RecBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition("RecBillHead.Cust.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool4.SetFromClause("UFIDA::U9::AR::Receival::RecBillHead as RecBillHead");

            #endregion

            #region 付款单

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("PayBillHead.Cust.Customer.Code", "CustomerCode");
            simpleTool5.AddSelect(@"PayBillHead.TotalMoney.OCMoney", "DebitMoney");
            simpleTool5.AddSelect(@"0.0", "CreditMoney");
            simpleTool5.AddCondition(string.Format("PayBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool5.AddCondition("PayBillHead.Cust.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool5.SetFromClause("UFIDA::U9::AP::Payment::PayBillHead as PayBillHead");

            #endregion

            #region 应付对冲

            SimpleOqlTool simpleTool6 = new SimpleOqlTool();
            simpleTool6.AddSelect("ARAPCAHead.Customer.Customer.Code", "CustomerCode");
            simpleTool6.AddSelect(@"0.0", "DebitMoney");
            simpleTool6.AddSelect(@"ARAPCAHead.ARCAMoney.OCMoney", "CreditMoney");
            simpleTool6.AddCondition(string.Format("ARAPCAHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool6.AddCondition("ARAPCAHead.Customer.Customer.Code in (select Customer_Code from #CustomerTable)");
            simpleTool6.SetFromClause("UFIDA::U9::AP::ARAPCounterApply::ARAPCAHead as ARAPCAHead");

            #endregion

            #region 债权转移单

            #region 转出客户

            SimpleOqlTool simpleTool7 = new SimpleOqlTool();
            simpleTool7.AddSelect("ARCTHead.TransOutAccrueCust.Customer.Code", "CustomerCode");
            simpleTool7.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType = 1 or ARCTLine.TransOutARBillBizType = 3 or ARCTLine.TransOutARBillBizType = 6 or ARCTLine.TransOutARBillBizType = 9) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool7.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType = 0 or ARCTLine.TransOutARBillBizType = 2 or ARCTLine.TransOutARBillBizType = 4) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool7.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool7.AddCondition("ARCTHead.IsTransAccrueCust = 1");
            simpleTool7.AddCondition("ARCTLine.TransOutARBillBizType in (0,1,2,3,4,6,9)");
            simpleTool7.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool7.AddCondition("ARCTHead.TransOutAccrueCust.Customer.Code in (select Customer_Code from #CustomerTable)");
            StringBuilder fromSb7 = new StringBuilder();
            fromSb7.Append("UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine");
            fromSb7.Append(" inner join ");
            fromSb7.Append("UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead");
            fromSb7.Append(" on ");
            fromSb7.Append("ARCTLine.ARCTHead = ARCTHead.ID");
            simpleTool7.SetFromClause(fromSb7.ToString());
            simpleTool7.AddGroup("ARCTHead.TransOutAccrueCust.Customer.Code");

            #endregion

            #region 转入客户

            SimpleOqlTool simpleTool8 = new SimpleOqlTool();
            simpleTool8.AddSelect("ARCTHead.TransInAccrueCust.Customer.Code", "CustomerCode");
            simpleTool8.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType = 0 or ARCTLine.TransInARBillBizType = 2 or ARCTLine.TransInARBillBizType = 4) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool8.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType = 1 or ARCTLine.TransInARBillBizType = 3 or ARCTLine.TransInARBillBizType = 6 or ARCTLine.TransInARBillBizType = 9) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool8.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool8.AddCondition("ARCTHead.IsTransAccrueCust = 1");
            simpleTool8.AddCondition("ARCTLine.TransInARBillBizType in (0,1,2,3,4,6,9)");
            simpleTool8.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool8.AddCondition("ARCTHead.TransInAccrueCust.Customer.Code in (select Customer_Code from #CustomerTable)");
            StringBuilder fromSb8 = new StringBuilder();
            fromSb8.Append("UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine");
            fromSb8.Append(" inner join ");
            fromSb8.Append("UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead");
            fromSb8.Append(" on ");
            fromSb8.Append("ARCTLine.ARCTHead = ARCTHead.ID");
            simpleTool8.SetFromClause(fromSb8.ToString());
            simpleTool8.AddGroup("ARCTHead.TransInAccrueCust.Customer.Code");

            #endregion

            #endregion

            SimpleOqlTool resultSimpleTool = new SimpleOqlTool();
            resultSimpleTool.AddSelect("sumOql.CustomerCode", "CustomerCode");
            resultSimpleTool.AddSelect("sum(sumOql.DebitMoney - sumOql.CreditMoney)", "AROCMoneyBalance_TotalMoney");
            resultSimpleTool.SetFromClause(string.Concat(new string[]
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
                " union all ",
				simpleTool7.GetOqlString(),
                " union all ",
				simpleTool8.GetOqlString(),
				") as sumOql "
			}));
            resultSimpleTool.AddGroup("sumOql.CustomerCode");
            TempTableUtil.CreateTempTableByOql("ARTotalMoneyTable", resultSimpleTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 最后交易额临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateLastSOTotalMoneyTCTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool sqlTool = new SimpleOqlTool();
            sqlTool.AddSelect("(row_number() over (partition by A.OrderBy_Customer order by A.BusinessDate desc))", "rowNum");
            sqlTool.AddSelect("A.OrderBy_Customer", "CustomerID");
            sqlTool.AddSelect("A.TotalMoneyTC", "TotalMoneyTC");
            sqlTool.SetFromClause("SM_SO as A");
            sqlTool.AddCondition("A.OrderBy_Customer in (select ID from #CustomerTable)");
            sqlTool.AddCondition("A.[Status] in ( 3, 4, 5, 6 )");
            string oqlString = "select convert(bigint,0) as CustomerID,convert(decimal(23,9),0) as LastSOTotalMoneyTC from CustomerTable where 0 = 1";
            string sqlString = string.Format("insert into #LastSOTotalMoneyTCTable select T.CustomerID as CustomerID,T.TotalMoneyTC as LastSOTotalMoneyTC from ({0}) as T where T.rowNum = 1",
                    sqlTool.GetOqlString());
            TempTableUtil.CreateTempTableByOql("LastSOTotalMoneyTCTable", oqlString, entityViewQuery);
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sqlString, null);
        }

        /// <summary>
        /// 最近一笔收款金额临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateLastRecBillTotalMoneyTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool sqlTool = new SimpleOqlTool();
            sqlTool.AddSelect("(row_number() over (partition by A.Cust_Customer order by A.BusinessDate desc))", "rowNum");
            sqlTool.AddSelect("A.Cust_Customer", "CustomerID");
            sqlTool.AddSelect("A.TotalMoney_OCMoney", "TotalMoneyTC");
            sqlTool.SetFromClause("AR_RecBillHead as A");
            sqlTool.AddCondition("A.Cust_Customer in (select ID from #CustomerTable)");
            sqlTool.AddCondition("A.DocStatus in ( 2, 3, 4 )");
            string oqlString = "select convert(bigint,0) as CustomerID,convert(decimal(23,9),0) as LastRecBillTotalMoney from CustomerTable where 0 = 1";
            string sqlString = string.Format("insert into #LastRecBillTotalMoneyTable select T.CustomerID as CustomerID,T.TotalMoneyTC as LastRecBillTotalMoney from ({0}) as T where T.rowNum = 1",
                    sqlTool.GetOqlString());
            TempTableUtil.CreateTempTableByOql("LastRecBillTotalMoneyTable", oqlString, entityViewQuery);
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sqlString, null);
        }

        /// <summary>
        /// 创建结果临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateResultTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("distinct A.ID", "ID");
            resultTool.AddSelect("A.Customer_ID", "Customer_ID");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == AROCMoneyBalance_TotalMoney)
                {
                    resultTool.AddSelect("B." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
                else if (columnitem.ColumnAlias == LastSOTotalMoneyTC)
                {
                    resultTool.AddSelect("C." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
                else if (columnitem.ColumnAlias == LastRecBillTotalMoney)
                {
                    resultTool.AddSelect("D." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
                else
                {
                    resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
            }
            resultTool.SetFromClause(@"#CustomerTable as A left join #ARTotalMoneyTable as B on A.Customer_Code = B.CustomerCode
                left join #LastSOTotalMoneyTCTable as C on A.ID = C.CustomerID 
                left join #LastRecBillTotalMoneyTable as D on A.ID = D.CustomerID");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == AROCMoneyBalance_TotalMoney)
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "B." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                        filterItem.ValueType);
                }
                else if (filterItem.Name == LastSOTotalMoneyTC)
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "C." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                        filterItem.ValueType);
                }
                else if (filterItem.Name == LastRecBillTotalMoney)
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "D." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                        filterItem.ValueType);
                }
            }
            TempTableUtil.CreateTempTableByOql("ResultTable", resultTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 获取合计应付金额
        /// </summary>
        /// <param name="entityViewQuery"></param>
        private decimal GetSumBalanceTotalMoney(EntityViewQuery entityViewQuery)
        {
            decimal sumBalanceTotalMoney = 0;
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(A.AROCMoneyBalance_TotalMoney)", "SumBalanceTotalMoney");
            sumSimpleTool.SetFromClause("#ResultTable A");
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumBalanceTotalMoney = DataRowConverter.AsDecimal(row, "SumBalanceTotalMoney");
            }
            return sumBalanceTotalMoney;
        }

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
            QryPaginateService<CustomerQryDTO> ps = new QryPaginateService<CustomerQryDTO>(bpParameter,
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
        public static readonly string Customer_ID = "Customer_ID";
        public static readonly string Customer_Code = "Customer_Code";
        public static readonly string Customer_Name = "Customer_Name";
        public static readonly string CustomerContact_Contact = "CustomerContact_Contact";
        public static readonly string CustomerContact_Contact_Name = "CustomerContact_Contact_Name";

        public static readonly string CustomerContact_Contact_DefaultMobilNum =
            "CustomerContact_Contact_DefaultMobilNum";

        public static readonly string CustomerContact_Contact_DefaultPhoneNum =
            "CustomerContact_Contact_DefaultPhoneNum";

        public static readonly string Customer_CustomerCategory = "Customer_CustomerCategory";
        public static readonly string Customer_CustomerCategory_Name = "Customer_CustomerCategory_Name";
        public static readonly string Customer_Saleser = "Customer_Saleser";
        public static readonly string Customer_Saleser_Name = "Customer_Saleser_Name";
        public static readonly string CustomerContact_Contact_DefaultFaxNum = "CustomerContact_Contact_DefaultFaxNum";
        public static readonly string AROCMoneyBalance_TotalMoney = "AROCMoneyBalance_TotalMoney";

        public readonly static string ObjectCreditLevelApproval_CreditLimit = "ObjectCreditLevelApproval_CreditLimit";

        public static readonly string LastSOTotalMoneyTC = "LastSOTotalMoneyTC";
        public static readonly string LastRecBillTotalMoney = "LastRecBillTotalMoney";
        public static readonly string Customer_StateTaxNo = "Customer_StateTaxNo";
        public static readonly string CustomerBankAccount_Code = "CustomerBankAccount_Code";
        public static readonly string Customer_OfficialLocation_Name = "Customer_OfficialLocation_Name";
        public static readonly string Customer_Description = "Customer_Description";

        public static readonly string Customer_TradeCurrency_MoneyRound_Precision =
            "Customer_TradeCurrency_MoneyRound_Precision";

        public static readonly string Customer_TradeCurrency_MoneyRound_RoundType =
            "Customer_TradeCurrency_MoneyRound_RoundType";

        public static readonly string Customer_TradeCurrency_MoneyRound_RoundValue =
            "Customer_TradeCurrency_MoneyRound_RoundValue";
        public readonly static string SumBalanceTotalMoney = "SumBalanceTotalMoney";

        #endregion

        private void DoMap()
        {
            map.Clear();
            //ID
            map.Add(ID, "ID");
            //ID
            map.Add(Customer_ID, "Customer.ID");
            //编码
            map.Add(Customer_Code, "Customer.Code");
            //名称
            map.Add(Customer_Name, "Customer.Name");
            //联系人
            map.Add(CustomerContact_Contact, "CustomerContact.Contact");
            //名称
            map.Add(CustomerContact_Contact_Name, "CustomerContact.Contact.Name");
            //手机
            map.Add(CustomerContact_Contact_DefaultMobilNum, "CustomerContact.Contact.DefaultMobilNum");
            //电话
            map.Add(CustomerContact_Contact_DefaultPhoneNum, "CustomerContact.Contact.DefaultPhoneNum");
            //客户分类
            map.Add(Customer_CustomerCategory, "Customer.CustomerCategory");
            //名称
            map.Add(Customer_CustomerCategory_Name, "Customer.CustomerCategory.Name");
            //业务员
            map.Add(Customer_Saleser, "Customer.Saleser");
            //名称
            map.Add(Customer_Saleser_Name, "Customer.Saleser.Name");
            //传真
            map.Add(CustomerContact_Contact_DefaultFaxNum, "CustomerContact.Contact.DefaultFaxNum");
            //实际应收
            map.Add(AROCMoneyBalance_TotalMoney, "0.0");
            //最后交易额
            map.Add(LastSOTotalMoneyTC, "0.0");
            //最近一笔收款金额
            map.Add(LastRecBillTotalMoney, "0.0");
            //国税号
            map.Add(Customer_StateTaxNo, "Customer.StateTaxNo");
            //开户银行
            map.Add(CustomerBankAccount_Code, "CustomerBankAccount.Code");
            //名称
            map.Add(Customer_OfficialLocation_Name, "Customer.OfficialLocation.Name");
            //描述
            map.Add(Customer_Description, "Customer.Description");
            //客户_交易币种_金额精度_精度
            map.Add(Customer_TradeCurrency_MoneyRound_Precision, "Customer.TradeCurrency.MoneyRound.Precision");
            //客户_交易币种_金额精度_舍入类型
            map.Add(Customer_TradeCurrency_MoneyRound_RoundType, "Customer.TradeCurrency.MoneyRound.RoundType");
            //客户_交易币种_金额精度_舍入值
            map.Add(Customer_TradeCurrency_MoneyRound_RoundValue, "Customer.TradeCurrency.MoneyRound.RoundValue");
            //信用额度
            map.Add(ObjectCreditLevelApproval_CreditLimit, "ObjectCreditLevelApproval.CreditLimit");
            //合计实际应收金额
            map.Add(SumBalanceTotalMoney, "SumBalanceTotalMoney");
        }
    }

    #endregion

    #endregion
}