using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.FJGX.AchievementSumQryBP.PubBase;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.AchievementSumQryBP
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
            return "UFIDA.U9.CBO.HR.Operator.Operators";
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
            //创建业务员临时表
            CreateOperatorsTable(bpParameter, entityViewQuery);
            //计算总计合计金额
            decimal sumRecTotalMoney = 0;
            decimal sumARTotalMoney = 0;
            //收款金额
            CreateRecTotalMoneyTable(bpParameter, entityViewQuery, ref sumRecTotalMoney);
            //应收金额
            CreateARTotalMoneyTable(bpParameter, entityViewQuery, ref sumARTotalMoney);

            SimpleOqlTool tmpResultTool = new SimpleOqlTool();
            tmpResultTool.AddSelect("A.ID", "ID");
            tmpResultTool.AddSelect("A.OperatorsCode", "OperatorsCode");
            tmpResultTool.AddSelect("A.OperatorsName", "OperatorsName");
            tmpResultTool.AddSelect("B.RecTotalMoney", "RecTotalMoney");
            tmpResultTool.AddSelect("C.ARTotalMoney", "ARTotalMoney");
            tmpResultTool.AddSelect("case when C.ARTotalMoney = 0 then 1.0 else B.RecTotalMoney/C.ARTotalMoney end",
                "BackMoneyRatio");
            tmpResultTool.SetFromClause(
                @"#OperatorsTable as A left join #RecTotalMoneyTable as B on A.ID = B.OperatorsID
                left join #ARTotalMoneyTable as C on A.ID = C.OperatorsID");
            TempTableUtil.CreateTempTableByOql("TempResultTable", tmpResultTool.GetOqlString(), entityViewQuery);

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumRecTotalMoney.ToString("F2"), "SumRecTotalMoney");
            resultTool.AddSelect(sumARTotalMoney.ToString("F2"), "SumARTotalMoney");
            foreach (QryColumnItem current in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + current.ColumnAlias, current.ColumnAlias);
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == BusinessDate || filterItem.Name == OperatorsCode ||
                    filterItem.Name == OperatorsName) continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "A." + filterItem.Name);
                resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            resultTool.SetFromClause("#TempResultTable as A");
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
        } //end DoLogic 


        /// <summary>
        ///     创建业务员临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateOperatorsTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool sqlTool = new SimpleOqlTool();
            sqlTool.AddSelect("Operators.ID", "ID");
            sqlTool.AddSelect("Operators.Code", "OperatorsCode");
            sqlTool.AddSelect("Operators.Name", "OperatorsName");
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "OperatorsCode":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Operators.Code");
                        sqlTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                    case "OperatorsName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Operators.Name");
                        sqlTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                            filterItem.RightValues,
                            filterItem.ValueType);
                        break;
                }
            }

            sqlTool.AddCondition(bpParameter.FilterOpath);
            sqlTool.AddCondition(string.Format("Operators.Org = {0}", Context.LoginOrg.ID));
            sqlTool.AddCondition(
                "Operators.ID in (select A.Operators from UFIDA::U9::CBO::HR::Operator::OperatorLine A where A.OperatorType = 1)");
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::CBO::HR::Operator::Operators as Operators");
            //处理From部份，形成From子句
            sqlTool.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("OperatorsTable", sqlTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        ///     收款单金额
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        /// <param name="sumRecTotalMoney"></param>
        private void CreateRecTotalMoneyTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery,
            ref decimal sumRecTotalMoney)
        {
            //收款单+应收单(12,13)+应付对冲+转入业务类型6,9的转入客户-转出业务类型为6,9的转出客户
            #region 收款单  

            SimpleOqlTool simpleTool = new SimpleOqlTool();
            simpleTool.AddSelect("RecBillHead.Transactor", "OperatorsID");
            simpleTool.AddSelect(@"sum(RecBillHead.TotalMoney.OCMoney)", "RecTotalMoney");
            simpleTool.AddCondition("RecBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool.SetFromClause("UFIDA::U9::AR::Receival::RecBillHead as RecBillHead");
            simpleTool.AddGroup("RecBillHead.Transactor");
            #endregion
            #region 应收单 单据类型为12，13的算到贷向金额中。
            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool2.AddSelect("sum(ARBillHead.AROCMoney.TotalMoney)", "RecTotalMoney");
            simpleTool2.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool2.AddCondition("ARBillHead.DocumentType.Code in ('12','13')");
            simpleTool2.SetFromClause("UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead");
            simpleTool2.AddGroup("ARBillHead.Transactor");
            #endregion
            #region 应付对冲
            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool3.AddSelect(@"sum(ARAPCALine.ARCAOCMoney.TotalMoney)", "RecTotalMoney");
            simpleTool3.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool3.SetFromClause(@"UFIDA::U9::AP::ARAPCounterApply::ARAPCALine as ARAPCALine
                        left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARAPCALine.ARBillNo=ARBillHead.DocNo");
            simpleTool3.AddGroup("ARBillHead.Transactor");
            #endregion
            #region 债权转移单 转入客户

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool5.AddSelect(@"sum(ARCTLine.TransOCMoney.TotalMoney)", "RecTotalMoney");
            simpleTool5.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine  
                                    inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                                    left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransInARBillHead =ARBillHead.ID");
            //simpleTool5.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool5.AddCondition("ARCTLine.TransInARBillBizType in (6,9)");
            simpleTool5.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool5.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool5.AddGroup("ARBillHead.Transactor");
            #endregion
            #region 债权转移单 转出客户

            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool4.AddSelect(@"0-sum(ARCTLine.TransOCMoney.TotalMoney)", "RecTotalMoney");
            simpleTool4.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine
                            inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                            left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransOutARBillHead =ARBillHead.ID");
            //simpleTool4.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition("ARCTLine.TransOutARBillBizType in (6,9)");
            simpleTool4.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool4.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool4.AddGroup("ARBillHead.Transactor");
            #endregion
            

            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != BusinessDate) continue;
                string leftExpr1 = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.RecDate");
                simpleTool.AddCondition(leftExpr1, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                string leftExpr2 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.BusinessDate");
                simpleTool2.AddCondition(leftExpr2, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                string leftExpr3 = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCALine.ARAPCAHead.BusinessDate");
                simpleTool3.AddCondition(leftExpr3, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                string leftExpr4 = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.BusinessDate");
                simpleTool4.AddCondition(leftExpr4, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                simpleTool5.AddCondition(leftExpr4, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            SimpleOqlTool totalSimpleTool = new SimpleOqlTool();
            totalSimpleTool.AddSelect("sumOql.OperatorsID", "OperatorsID");
            totalSimpleTool.AddSelect("sum(RecTotalMoney)", "RecTotalMoney");
            totalSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool.GetOqlString(),
                " union all ",
                simpleTool2.GetOqlString(),
                " union all ",
                simpleTool3.GetOqlString(),
                " union all ",
                simpleTool4.GetOqlString(),
                " union all ",
                simpleTool5.GetOqlString(),
                ") as sumOql "
            }));
            totalSimpleTool.AddGroup("sumOql.OperatorsID");
            TempTableUtil.CreateTempTableByOql("RecTotalMoneyTable", totalSimpleTool.GetOqlString(), entityViewQuery);

            //合计总额
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.RecTotalMoney)", "SumRecTotalMoney");
            sumSimpleTool.SetFromClause(string.Concat(new[]
            {
                  "(",
                simpleTool.GetOqlString(),
                " union all ",
                simpleTool2.GetOqlString(),
                " union all ",
                simpleTool3.GetOqlString(),
                " union all ",
                simpleTool4.GetOqlString(),
                " union all ",
                simpleTool5.GetOqlString(),
                ") as sumOql "
            }));
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumRecTotalMoney = DataRowConverter.AsDecimal(row, "SumRecTotalMoney");
            }
        }

        /// <summary>
        ///     出货单金额
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        /// <param name="sumARTotalMoney"></param>
        private void CreateARTotalMoneyTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery,
            ref decimal sumARTotalMoney)
        {
            //出货-退回处理+应收单（03+05-14-16）+转出业务类型为1,3的转出客户-转出业务类型024的转出客户+转入业务类型为0,2,4的转入客户-转入业务类型1,3的转入客户
            #region 出货单

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("Ship.Seller", "OperatorsID");
            simpleTool1.AddSelect("sum(Ship.TotalMoney)", "DebitMoney");
            simpleTool1.AddSelect("0.0", "CreditMoney");
            simpleTool1.AddCondition("Ship.Seller in (select ID from #OperatorsTable)");
            simpleTool1.SetFromClause("UFIDA::U9::SM::Ship::Ship as Ship");
            simpleTool1.AddGroup("Ship.Seller");

            #endregion
            #region 退回处理单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("RMALine.RMA.Seller", "OperatorsID");
            simpleTool2.AddSelect("0.0", "DebitMoney");
            simpleTool2.AddSelect(@"sum(RMALine.RtnMoneyTC)", "CreditMoney");
            simpleTool2.AddCondition("RMALine.RMA.Seller in (select ID from #OperatorsTable)");
            simpleTool2.SetFromClause("UFIDA::U9::SM::RMA::RMALine as RMALine");
            simpleTool2.AddGroup("RMALine.RMA.Seller");

            #endregion
            #region 应收单

            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool3.AddSelect(@"sum(case when (ARBillHead.DocumentType.Code = '03' or ARBillHead.DocumentType.Code = '05') 
                then ARBillHead.AROCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool3.AddSelect(@"sum(case when (ARBillHead.DocumentType.Code = '14' or ARBillHead.DocumentType.Code = '16') 
                then ARBillHead.AROCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool3.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool3.SetFromClause("UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead");
            simpleTool3.AddGroup("ARBillHead.Transactor");

            #endregion
            #region 债权转移单 转出客户
            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool4.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType in (1,3)) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool4.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType in (0,2,4)) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool4.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine
                            inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                            left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransOutARBillHead =ARBillHead.ID");
            //simpleTool4.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool4.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool4.AddGroup("ARBillHead.Transactor");
            #endregion
            #region 债权转移单 转入客户

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("ARBillHead.Transactor", "OperatorsID");
            simpleTool5.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType in (0,2,4)) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool5.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType in (1,3)) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool5.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine  
                                    inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                                    left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransInARBillHead =ARBillHead.ID");
            //simpleTool5.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            //simpleTool5.AddCondition("ARCTLine.TransInARBillBizType in (0,2,4)");
            simpleTool5.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool5.AddCondition("ARBillHead.Transactor in (select ID from #OperatorsTable)");
            simpleTool5.AddGroup("ARBillHead.Transactor");
            #endregion

            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != BusinessDate) continue;
                string leftExpr1 = filterItem.LeftExpr.Replace(filterItem.Name, "Ship.BusinessDate");
                simpleTool1.AddCondition(leftExpr1, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                string leftExpr2 = filterItem.LeftExpr.Replace(filterItem.Name, "RMALine.RMA.BusinessDate");
                simpleTool2.AddCondition(leftExpr2, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
                string leftExpr3 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.BusinessDate");
                simpleTool3.AddCondition(leftExpr3, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }

            SimpleOqlTool totalSimpleTool = new SimpleOqlTool();
            totalSimpleTool.AddSelect("sumOql.OperatorsID", "OperatorsID");
            totalSimpleTool.AddSelect("sum(sumOql.DebitMoney - sumOql.CreditMoney)", "ARTotalMoney");
            totalSimpleTool.SetFromClause(string.Concat(new[]
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
                ") as sumOql "
            }));
            totalSimpleTool.AddGroup("sumOql.OperatorsID");
            TempTableUtil.CreateTempTableByOql("ARTotalMoneyTable", totalSimpleTool.GetOqlString(), entityViewQuery);

            //合计总额
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.DebitMoney - sumOql.CreditMoney)", "SumARTotalMoney");
            sumSimpleTool.SetFromClause(string.Concat(new[]
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
                ") as sumOql "
            }));
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumARTotalMoney = DataRowConverter.AsDecimal(row, "SumARTotalMoney");
            }
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
            QryPaginateService<AchievementSumQryDTO> ps = new QryPaginateService<AchievementSumQryDTO>(bpParameter,
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
        public static readonly string OperatorsCode = "OperatorsCode";
        public static readonly string OperatorsName = "OperatorsName";
        public static readonly string RecTotalMoney = "RecTotalMoney";
        public static readonly string ARTotalMoney = "ARTotalMoney";
        public static readonly string BackMoneyRatio = "BackMoneyRatio";
        public static readonly string SumRecTotalMoney = "SumRecTotalMoney";
        public static readonly string SumARTotalMoney = "SumARTotalMoney";
        public static readonly string BusinessDate = "BusinessDate";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //业务员编码
            map.Add(OperatorsCode, "OperatorsCode");
            //业务员
            map.Add(OperatorsName, "OperatorsName");
            //收款金额
            map.Add(RecTotalMoney, "RecTotalMoney");
            //应收金额
            map.Add(ARTotalMoney, "ARTotalMoney");
            //回款率
            map.Add(BackMoneyRatio, "BackMoneyRatio");
            //回款总额
            map.Add(SumRecTotalMoney, "SumRecTotalMoney");
            //应收总额
            map.Add(SumARTotalMoney, "SumARTotalMoney");
            //业务日期
            map.Add(BusinessDate, "BusinessDate");
        }
    }

    #endregion

    #endregion
}