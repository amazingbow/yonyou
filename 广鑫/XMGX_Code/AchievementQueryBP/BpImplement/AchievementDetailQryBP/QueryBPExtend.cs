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

namespace UFIDA.U9.Cust.FJGX.AchievementDetailQryBP
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
            return "UFIDA.U9.AR.Receival.RecBillHead";
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
            //收款单+应收单(12,13)+应付对冲+转入业务类型6,9的转入客户-转出业务类型为6,9的转出客户
            #region 收款单
            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("RecBillHead.ID", "ID");
            simpleTool1.AddSelect("RecBillHead.RecDate", "RecDate");
            simpleTool1.AddSelect("RecBillHead.DocNo", "RecDocNo");
            simpleTool1.AddSelect("RecBillHead.Cust.Customer.Code", "CustomerCode");
            simpleTool1.AddSelect("RecBillHead.Cust.Customer.Name", "CustomerName");
            simpleTool1.AddSelect("Operators.Code", "OperatorsCode");
            simpleTool1.AddSelect("Operators.Name", "OperatorsName");
            simpleTool1.AddSelect("RecBillHead.TotalMoney.OCMoney", "RecTotalMoney");
            simpleTool1.SetFromClause(@"UFIDA::U9::AR::Receival::RecBillHead as RecBillHead left join 
                    UFIDA::U9::CBO::HR::Operator::Operators as Operators on RecBillHead.Transactor = Operators.ID"); //在这里替换From子句中的实体名称
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            #endregion
            #region 应收单 单据类型为12，13的算到贷向金额中。
            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("ARBillHead.ID", "ID");
            simpleTool2.AddSelect("ARBillHead.BusinessDate", "RecDate");
            simpleTool2.AddSelect("ARBillHead.DocNo", "RecDocNo");
            simpleTool2.AddSelect("ARBillHead.AccrueCust.Customer.Code", "CustomerCode");
            simpleTool2.AddSelect("ARBillHead.AccrueCust.Customer.Name", "CustomerName");
            simpleTool2.AddSelect("Operators.Code", "OperatorsCode");
            simpleTool2.AddSelect("Operators.Name", "OperatorsName");
            simpleTool2.AddSelect("ARBillHead.AROCMoney.TotalMoney", "RecTotalMoney");
            simpleTool2.SetFromClause(@"UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead left join 
                    UFIDA::U9::CBO::HR::Operator::Operators as Operators on ARBillHead.Transactor = Operators.ID");
            simpleTool2.AddCondition("ARBillHead.DocumentType.Code in('12','13')");
            simpleTool2.AddCondition(bpParameter.FilterOpath);
            #endregion
            #region 应付对冲
            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("ARAPCALine.ID", "ID");
            simpleTool3.AddSelect("ARAPCALine.ARAPCAHead.BusinessDate", "RecDate");
            simpleTool3.AddSelect("ARAPCALine.ARAPCAHead.DocNo", "RecDocNo");
            simpleTool3.AddSelect("ARBillHead.AccrueCust.Customer.Code", "CustomerCode");
            simpleTool3.AddSelect("ARBillHead.AccrueCust.Customer.Name", "CustomerName");
            simpleTool3.AddSelect("Operators.Code", "OperatorsCode");
            simpleTool3.AddSelect("Operators.Name", "OperatorsName");
            simpleTool3.AddSelect("ARAPCALine.ARCAOCMoney.TotalMoney", "RecTotalMoney");
            simpleTool3.SetFromClause(@"UFIDA::U9::AP::ARAPCounterApply::ARAPCALine as ARAPCALine
                        left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARAPCALine.ARBillNo=ARBillHead.DocNo 
                        left join UFIDA::U9::CBO::HR::Operator::Operators as Operators on ARBillHead.Transactor = Operators.ID");
            simpleTool3.AddCondition(bpParameter.FilterOpath);
            #endregion
            #region 债权转移单 转入客户
            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("ARCTLine.ID", "ID");
            simpleTool5.AddSelect("ARCTHead.BusinessDate", "RecDate");
            simpleTool5.AddSelect("ARCTHead.DocNo", "RecDocNo");
            simpleTool5.AddSelect("ARBillHead.AccrueCust.Customer.Code", "CustomerCode");
            simpleTool5.AddSelect("ARBillHead.AccrueCust.Customer.Name", "CustomerName");
            simpleTool5.AddSelect("Operators.Code", "OperatorsCode");
            simpleTool5.AddSelect("Operators.Name", "OperatorsName");
            simpleTool5.AddSelect("ARCTLine.TransOCMoney.TotalMoney", "RecTotalMoney");
            simpleTool5.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine
                            inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                            left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransOutARBillHead =ARBillHead.ID
                            left join UFIDA::U9::CBO::HR::Operator::Operators as Operators on ARBillHead.Transactor = Operators.ID");
            simpleTool5.AddCondition("ARCTLine.TransInARBillBizType in (6,9)");
            simpleTool5.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool5.AddCondition(bpParameter.FilterOpath);
            #endregion
            #region 债权转移单 转出客户
            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("ARCTLine.ID", "ID");
            simpleTool4.AddSelect("ARCTHead.BusinessDate", "RecDate");
            simpleTool4.AddSelect("ARCTHead.DocNo", "RecDocNo");
            simpleTool4.AddSelect("ARBillHead.AccrueCust.Customer.Code", "CustomerCode");
            simpleTool4.AddSelect("ARBillHead.AccrueCust.Customer.Name", "CustomerName");
            simpleTool4.AddSelect("Operators.Code", "OperatorsCode");
            simpleTool4.AddSelect("Operators.Name", "OperatorsName");
            simpleTool4.AddSelect("0-ARCTLine.TransOCMoney.TotalMoney", "RecTotalMoney");
            simpleTool4.SetFromClause(@"UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine
                            inner join UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead on ARCTLine.ARCTHead = ARCTHead.ID
                            left join UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead on ARCTLine.TransOutARBillHead =ARBillHead.ID
                            left join UFIDA::U9::CBO::HR::Operator::Operators as Operators on ARBillHead.Transactor = Operators.ID");
            //simpleTool4.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition("ARCTLine.TransOutARBillBizType in (6,9)");
            simpleTool4.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool4.AddCondition(bpParameter.FilterOpath);
            #endregion
            
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                switch (filterItem.Name)
                {
                    case "RecDate":
                        string leftExpr1 = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.RecDate");
                        simpleTool1.AddCondition(leftExpr1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string leftExpr2 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.BusinessDate");
                        simpleTool2.AddCondition(leftExpr2, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string leftExpr3 = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCALine.ARAPCAHead.BusinessDate");
                        simpleTool3.AddCondition(leftExpr3, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string leftExpr4 = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.BusinessDate");
                        simpleTool4.AddCondition(leftExpr4, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(leftExpr4, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "RecDocNo":
                        string DocNo1 = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.DocNo");
                        simpleTool1.AddCondition(DocNo1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string DocNo2 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.DocNo");
                        simpleTool2.AddCondition(DocNo2, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string DocNo3 = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCALine.ARAPCAHead.DocNo");
                        simpleTool3.AddCondition(DocNo3, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        string DocNo4 = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.DocNo");
                        simpleTool4.AddCondition(DocNo4, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(DocNo4, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "CustomerCode":
                        string CustomerCode = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.Cust.Customer.Code");
                        string CustomerCode1 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.AccrueCust.Customer.Code");
                        simpleTool1.AddCondition(CustomerCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool2.AddCondition(CustomerCode1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool3.AddCondition(CustomerCode1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool4.AddCondition(CustomerCode1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(CustomerCode1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "CustomerName":
                        string CustomerName = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.Cust.Customer.Name");
                        string CustomerName1 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.AccrueCust.Customer.Name");
                        simpleTool1.AddCondition(CustomerName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool2.AddCondition(CustomerName1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool3.AddCondition(CustomerName1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool4.AddCondition(CustomerName1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(CustomerName1, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "OperatorsCode":
                        string OperatorsCode = filterItem.LeftExpr.Replace(filterItem.Name, "Operators.Code");
                        simpleTool1.AddCondition(OperatorsCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool2.AddCondition(OperatorsCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool3.AddCondition(OperatorsCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool4.AddCondition(OperatorsCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(OperatorsCode, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "OperatorsName":
                        string OperatorsName = filterItem.LeftExpr.Replace(filterItem.Name, "Operators.Name");
                        simpleTool1.AddCondition(OperatorsName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool2.AddCondition(OperatorsName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool3.AddCondition(OperatorsName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool4.AddCondition(OperatorsName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(OperatorsName, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    case "RecTotalMoney":
                        string RecTotalMoney = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.TotalMoney.OCMoney");
                        simpleTool1.AddCondition(RecTotalMoney, filterItem.DataType, filterItem.Operation, filterItem.RightValues,filterItem.ValueType);
                        string RecTotalMoney1 = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.AROCMoney.TotalMoney");
                        simpleTool2.AddCondition(RecTotalMoney1, filterItem.DataType, filterItem.Operation, filterItem.RightValues,filterItem.ValueType);
                        string RecTotalMoney2 = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCALine.ARCAOCMoney.TotalMoney");
                        simpleTool3.AddCondition(RecTotalMoney2, filterItem.DataType, filterItem.Operation, filterItem.RightValues,filterItem.ValueType);
                        string RecTotalMoney3 = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTLine.TransOCMoney.TotalMoney");
                        simpleTool4.AddCondition(RecTotalMoney3, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        simpleTool5.AddCondition(RecTotalMoney3, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
                        break;
                    default:
                        break;
                }
            }
            SimpleOqlTool totalSimpleTool = new SimpleOqlTool();
            totalSimpleTool.AddSelect("sumOql.ID", "ID");
            totalSimpleTool.AddSelect("sumOql.RecDate", "RecDate");
            totalSimpleTool.AddSelect("sumOql.RecDocNo", "RecDocNo");
            totalSimpleTool.AddSelect("sumOql.CustomerCode", "CustomerCode");
            totalSimpleTool.AddSelect("sumOql.CustomerName", "CustomerName");
            totalSimpleTool.AddSelect("sumOql.OperatorsCode", "OperatorsCode");
            totalSimpleTool.AddSelect("sumOql.OperatorsName", "OperatorsName");
            totalSimpleTool.AddSelect("sumOql.RecTotalMoney", "RecTotalMoney");
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
            TempTableUtil.CreateTempTableByOql("RecBillHeadTempTable", totalSimpleTool.GetOqlString(), entityViewQuery);
            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            resultTool.SetFromClause(@"#RecBillHeadTempTable as A ");
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
            QryPaginateService<AchievementDetailQryDTO> ps = new QryPaginateService<AchievementDetailQryDTO>(
                bpParameter, isNeedTempTable());
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
        public static readonly string RecDate = "RecDate";
        public static readonly string RecDocNo = "RecDocNo";
        public static readonly string CustomerCode = "CustomerCode";
        public static readonly string CustomerName = "CustomerName";
        public static readonly string OperatorsCode = "OperatorsCode";
        public static readonly string OperatorsName = "OperatorsName";
        public static readonly string RecTotalMoney = "RecTotalMoney";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //收款日期
            map.Add(RecDate, "RecDate");
            //收款单号
            map.Add(RecDocNo, "RecDocNo");
            //客户编码
            map.Add(CustomerCode, "CustomerCode");
            //客户名称
            map.Add(CustomerName, "CustomerName");
            //业务员编码
            map.Add(OperatorsCode, "OperatorsCode");
            //业务员
            map.Add(OperatorsName, "OperatorsName");
            //收款金额
            map.Add(RecTotalMoney, "RecTotalMoney");
        }
    }

    #endregion

    #endregion
}