using System.Data;
using UFIDA.U9.Cust.FJGX.PubBase;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Report.App.Data;
using UFSoft.UBF.Business;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.UBF.Report.App.Data.Util;

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
            return "UFIDA.U9.AR.ARBill.ARBillHead";
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
            this.DoMap();
            
            #region 应收单

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("ARBillHead.ID", "ID");
            simpleTool1.AddSelect("ARBillHead.DocNo", "DocNo");
            simpleTool1.AddSelect("ARBillHead.DocumentType.Name", "DocTypeName");
            simpleTool1.AddSelect("Customer.ID", "Customer");
            simpleTool1.AddSelect("Customer.Name", "Customer_Name");
            simpleTool1.AddSelect("ARBillHead.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("ARBillHead.CreatedBy", "CreatedBy");
            simpleTool1.AddSelect(@"(case when (ARBillHead.BusinessType = 2 or ARBillHead.BusinessType = 4) 
                then ARBillHead.AROCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool1.AddSelect(@"(case when (ARBillHead.BusinessType = 1 or ARBillHead.BusinessType = 3) 
                then ARBillHead.AROCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool1.AddSelect("ARBillHead.Memo", "Memo");
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::AR::ARBill::ARBillHead as ARBillHead");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb.Append(" on ");
            fromSb.Append("Customer.ID = ARBillHead.AccrueCust.Customer"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name) 
                { 
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARBillHead." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool1.AddCondition(string.Format("ARBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool1.AddCondition("ARBillHead.BusinessType in (1,2,3,4)");
            simpleTool1.AddCondition("ARBillHead.DocumentType.Code not in ('01','02','04')");
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString());
            
            #endregion

            #region 出货单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("Ship.ID", "ID");
            simpleTool2.AddSelect("Ship.DocNo", "DocNo");
            simpleTool2.AddSelect("Ship.DocumentType.Name", "DocTypeName");
            simpleTool2.AddSelect("Customer.ID", "Customer");
            simpleTool2.AddSelect("Customer.Name", "Customer_Name");
            simpleTool2.AddSelect("Ship.BusinessDate", "BusinessDate");
            simpleTool2.AddSelect("Ship.CreatedBy", "CreatedBy");
            simpleTool2.AddSelect("Ship.TotalMoney", "DebitMoney");
            simpleTool2.AddSelect("0.0", "CreditMoney");
            simpleTool2.AddSelect("Ship.ShipMemo", "Memo");
            StringBuilder fromSb2 = new StringBuilder();
            fromSb2.Append("UFIDA::U9::SM::Ship::Ship as Ship");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb2.Append(" on ");
            fromSb2.Append("Customer.ID = Ship.OrderBy.Customer"); //客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship.ShipMemo");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship." + filterItem.Name);
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool2.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool2.AddCondition(string.Format("Ship.OperatingOrg = {0}", Base.Context.LoginOrg.ID));
            simpleTool2.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool2.SetFromClause(fromSb2.ToString()); 

            #endregion

            #region 退回处理单

            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("RMA.ID", "ID");
            simpleTool3.AddSelect("RMA.DocNo", "DocNo");
            simpleTool3.AddSelect("RMA.DocumentType.Name", "DocTypeName");
            simpleTool3.AddSelect("Customer.ID", "Customer");
            simpleTool3.AddSelect("Customer.Name", "Customer_Name");
            simpleTool3.AddSelect("RMA.BusinessDate", "BusinessDate");
            simpleTool3.AddSelect("RMA.CreatedBy", "CreatedBy");
            simpleTool3.AddSelect(@"(select sum(RMALine.RtnMoneyTC)*-1 as SumRtnMoneyTC from UFIDA::U9::SM::RMA::RMALine as RMALine 
                where RMALine.RMA = RMA.ID)","DebitMoney");
            simpleTool3.AddSelect(@"0.0", "CreditMoney");
            simpleTool3.AddSelect("RMA.Remark", "Memo");
            StringBuilder fromSb3 = new StringBuilder();
            fromSb3.Append("UFIDA::U9::SM::RMA::RMA as RMA");
            fromSb3.Append(" left join ");
            fromSb3.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb3.Append(" on ");
            fromSb3.Append("Customer.ID = RMA.Customer.Customer"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA.Remark");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool3.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool3.AddCondition(string.Format("RMA.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool3.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool3.SetFromClause(fromSb3.ToString());
            
            #endregion

            #region 收款单

            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("RecBillHead.ID", "ID");
            simpleTool4.AddSelect("RecBillHead.DocNo", "DocNo");
            simpleTool4.AddSelect("RecBillHead.DocumentType.Name", "DocTypeName");
            simpleTool4.AddSelect("Customer.ID", "Customer");
            simpleTool4.AddSelect("Customer.Name", "Customer_Name");
            simpleTool4.AddSelect("RecBillHead.BusinessDate", "BusinessDate");
            simpleTool4.AddSelect("RecBillHead.CreatedBy", "CreatedBy");
            simpleTool4.AddSelect(@"0.0", "DebitMoney");
            simpleTool4.AddSelect(@"RecBillHead.TotalMoney.OCMoney", "CreditMoney");
            simpleTool4.AddSelect("RecBillHead.Note", "Memo");
            StringBuilder fromSb4 = new StringBuilder();
            fromSb4.Append("UFIDA::U9::AR::Receival::RecBillHead as RecBillHead");
            fromSb4.Append(" left join ");
            fromSb4.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb4.Append(" on ");
            fromSb4.Append("Customer.ID = RecBillHead.Cust.Customer"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RecBillHead.Note");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool4.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool4.AddCondition(string.Format("RecBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool4.SetFromClause(fromSb4.ToString());

            #endregion

            #region 付款单

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("PayBillHead.ID", "ID");
            simpleTool5.AddSelect("PayBillHead.DocNo", "DocNo");
            simpleTool5.AddSelect("PayBillHead.DocumentType.Name", "DocTypeName");
            simpleTool5.AddSelect("Customer.ID", "Customer");
            simpleTool5.AddSelect("Customer.Name", "Customer_Name");
            simpleTool5.AddSelect("PayBillHead.BusinessDate", "BusinessDate");
            simpleTool5.AddSelect("PayBillHead.CreatedBy", "CreatedBy");
            simpleTool5.AddSelect(@"PayBillHead.TotalMoney.OCMoney", "DebitMoney");
            simpleTool5.AddSelect(@"0.0", "CreditMoney");
            simpleTool5.AddSelect("PayBillHead.Memo", "Memo");
            StringBuilder fromSb5 = new StringBuilder();
            fromSb5.Append("UFIDA::U9::AP::Payment::PayBillHead as PayBillHead");
            fromSb5.Append(" left join ");
            fromSb5.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb5.Append(" on ");
            fromSb5.Append("Customer.ID = PayBillHead.Cust.Customer"); //立账客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "PayBillHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "PayBillHead." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "PayBillHead.Memo");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool5.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool5.AddCondition(string.Format("PayBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool5.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool5.SetFromClause(fromSb5.ToString());

            #endregion

            #region 应付对冲

            SimpleOqlTool simpleTool6 = new SimpleOqlTool();
            simpleTool6.AddSelect("ARAPCAHead.ID", "ID");
            simpleTool6.AddSelect("ARAPCAHead.DocNo", "DocNo");
            simpleTool6.AddSelect("ARAPCAHead.DocumentType.Name", "DocTypeName");
            simpleTool6.AddSelect("Customer.ID", "Customer");
            simpleTool6.AddSelect("Customer.Name", "Customer_Name");
            simpleTool6.AddSelect("ARAPCAHead.BusinessDate", "BusinessDate");
            simpleTool6.AddSelect("ARAPCAHead.CreatedBy", "CreatedBy");
            simpleTool6.AddSelect(@"0.0", "DebitMoney");
            simpleTool6.AddSelect(@"ARAPCAHead.ARCAMoney.OCMoney", "CreditMoney");
            simpleTool6.AddSelect("ARAPCAHead.Memo", "Memo");
            StringBuilder fromSb6 = new StringBuilder();
            fromSb6.Append("UFIDA::U9::AP::ARAPCounterApply::ARAPCAHead as ARAPCAHead");
            fromSb6.Append(" left join ");
            fromSb6.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb6.Append(" on ");
            fromSb6.Append("Customer.ID = ARAPCAHead.Customer.Customer"); //客户
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCAHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCAHead." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARAPCAHead.Memo");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool6.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool6.AddCondition(string.Format("ARAPCAHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool6.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool6.SetFromClause(fromSb6.ToString());

            #endregion

            #region 债权转移单

            #region 转出客户

            SimpleOqlTool simpleTool7 = new SimpleOqlTool();
            simpleTool7.AddSelect("ARCTHead.ID", "ID");
            simpleTool7.AddSelect("ARCTHead.DocNo", "DocNo");
            simpleTool7.AddSelect("ARCTHead.DocumentType.Name", "DocTypeName");
            simpleTool7.AddSelect("Customer.ID", "Customer");
            simpleTool7.AddSelect("Customer.Name", "Customer_Name");
            simpleTool7.AddSelect("ARCTHead.BusinessDate", "BusinessDate");
            simpleTool7.AddSelect("ARCTHead.CreatedBy", "CreatedBy");
            simpleTool7.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType = 1 or ARCTLine.TransOutARBillBizType = 3 or ARCTLine.TransOutARBillBizType = 6 or ARCTLine.TransOutARBillBizType = 9) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool7.AddSelect(@"sum(case when (ARCTLine.TransOutARBillBizType = 0 or ARCTLine.TransOutARBillBizType = 2 or ARCTLine.TransOutARBillBizType = 4) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool7.AddSelect("ARCTHead.Memo", "Memo");
            StringBuilder fromSb7 = new StringBuilder();
            fromSb7.Append("UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine");
            fromSb7.Append(" inner join ");
            fromSb7.Append("UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead");
            fromSb7.Append(" on ");
            fromSb7.Append("ARCTLine.ARCTHead = ARCTHead.ID");
            fromSb7.Append(" left join ");
            fromSb7.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb7.Append(" on ");
            fromSb7.Append("Customer.ID = ARCTHead.TransOutAccrueCust.Customer"); //转出客户 
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.Memo");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool7.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool7.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool7.AddCondition("ARCTHead.IsTransAccrueCust = 1");
            simpleTool7.AddCondition("ARCTLine.TransOutARBillBizType in (0,1,2,3,4,6,9)");
            simpleTool7.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool7.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool7.SetFromClause(fromSb7.ToString());
            simpleTool7.AddGroup("ARCTHead.ID,ARCTHead.DocNo,ARCTHead.DocumentType.Name,Customer.ID,Customer.Name,ARCTHead.BusinessDate,ARCTHead.CreatedBy,ARCTHead.Memo");

            #endregion

            #region 转入客户

            SimpleOqlTool simpleTool8 = new SimpleOqlTool();
            simpleTool8.AddSelect("ARCTHead.ID", "ID");
            simpleTool8.AddSelect("ARCTHead.DocNo", "DocNo");
            simpleTool8.AddSelect("ARCTHead.DocumentType.Name", "DocTypeName");
            simpleTool8.AddSelect("Customer.ID", "Customer");
            simpleTool8.AddSelect("Customer.Name", "Customer_Name");
            simpleTool8.AddSelect("ARCTHead.BusinessDate", "BusinessDate");
            simpleTool8.AddSelect("ARCTHead.CreatedBy", "CreatedBy");
            simpleTool8.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType = 0 or ARCTLine.TransInARBillBizType = 2 or ARCTLine.TransInARBillBizType = 4) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool8.AddSelect(@"sum(case when (ARCTLine.TransInARBillBizType = 1 or ARCTLine.TransInARBillBizType = 3 or ARCTLine.TransInARBillBizType = 6 or ARCTLine.TransInARBillBizType = 9) 
                then ARCTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool8.AddSelect("ARCTHead.Memo", "Memo");
            StringBuilder fromSb8 = new StringBuilder();
            fromSb8.Append("UFIDA::U9::AR::ARCT::ARCTLine as ARCTLine");
            fromSb8.Append(" inner join ");
            fromSb8.Append("UFIDA::U9::AR::ARCT::ARCTHead as ARCTHead");
            fromSb8.Append(" on ");
            fromSb8.Append("ARCTLine.ARCTHead = ARCTHead.ID");
            fromSb8.Append(" left join ");
            fromSb8.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb8.Append(" on ");
            fromSb8.Append("Customer.ID = ARCTHead.TransInAccrueCust.Customer"); //转入客户 
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "DocTypeName":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.DocumentType.Name");
                        break;
                    case "DocNo":
                    case "BusinessDate":
                    case "CreatedBy":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead." + filterItem.Name);
                        break;
                    case "Memo":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "ARCTHead.Memo");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool8.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool8.AddCondition(string.Format("ARCTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool8.AddCondition("ARCTHead.IsTransAccrueCust = 1");
            simpleTool8.AddCondition("ARCTLine.TransInARBillBizType in (0,1,2,3,4,6,9)");
            simpleTool8.AddCondition("ARCTHead.Cancel.Canceled = 0");//未作废
            simpleTool8.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool8.SetFromClause(fromSb8.ToString());
            simpleTool8.AddGroup("ARCTHead.ID,ARCTHead.DocNo,ARCTHead.DocumentType.Name,Customer.ID,Customer.Name,ARCTHead.BusinessDate,ARCTHead.CreatedBy,ARCTHead.Memo");

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
                " union all ",
				simpleTool7.GetOqlString(),
                " union all ",
				simpleTool8.GetOqlString(),
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

            #region 返回结果

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
                " union all ",
				simpleTool7.GetOqlString(),
                " union all ",
				simpleTool8.GetOqlString(),
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

            #endregion

            //计算小计
            DataParamList paramList = new DataParamList();
            paramList.Add(DataParamFactory.CreateInput("@SumMoney", sumDebitMoney - sumCreditMoney, DbType.Decimal));
            DataAccessor.RunSP(DatabaseManager.GetCurrentConnection(), "dbo.FJGX_CustomerQuery_SetBalanceMoney", paramList);
            
            return "select * from #ResultTable";
        } //end DoLogic 


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
            UFIDA.UBF.Query.CommonService.QryPaginateService<UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.CustomerVoucherQryDTO> ps = new UFIDA.UBF.Query.CommonService.QryPaginateService<UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.CustomerVoucherQryDTO>(bpParameter, isNeedTempTable());
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
        public readonly static string Customer = "Customer";
        public readonly static string Customer_Name = "Customer_Name";
        public readonly static string DocNo = "DocNo";
        public readonly static string DocTypeName = "DocTypeName";
        public readonly static string BusinessDate = "BusinessDate";
        public readonly static string CreatedBy = "CreatedBy";
        public readonly static string Memo = "Memo";
        public readonly static string DebitMoney = "DebitMoney";
        public readonly static string CreditMoney = "CreditMoney";
        public readonly static string SumDebitMoney = "SumDebitMoney";
        public readonly static string SumCreditMoney = "SumCreditMoney";
        public readonly static string SumMoney = "SumMoney";
        public readonly static string BalanceMoney = "BalanceMoney";
        #endregion

        private void DoMap()
        {
            map.Clear();
            //ID
            map.Add(ID, "ID");
            //客户
            map.Add(Customer, "Customer");
            //名称
            map.Add(Customer_Name, "Customer.Name");
            //应收单据
            map.Add(DocNo, "DocNo");
            //单据类型
            map.Add(DocTypeName, "DocTypeName");
            //业务日期
            map.Add(BusinessDate, "BusinessDate");
            //制单人
            map.Add(CreatedBy, "CreatedBy");
            //摘要
            map.Add(Memo, "Memo");
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
            //结存
            map.Add(BalanceMoney, "BalanceMoney");
        }
    }
    #endregion
    
	#endregion
	
	
}