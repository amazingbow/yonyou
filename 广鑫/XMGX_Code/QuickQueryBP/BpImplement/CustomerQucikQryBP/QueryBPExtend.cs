using System;
using System.Collections.Generic;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFSoft.UBF.AopFrame;

namespace UFIDA.U9.Cust.FJGX.CustomerQucikQryBP
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
            object result= DoProcess(bpObj.QryInParameter);
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
            return false;
        } //end isNeedMultiLang


        /// <summary>
        ///     执行业务逻辑，返回OQL串，由BP开发人员添加代码。
        ///     参数bpParameter中带有已选栏目、过滤及排序信息
        /// </summary>
        /// <returns></returns>
        private string DoLogic(QryCommonParaObj bpParameter)
        {
            DoMap();
            //必须引用UFIDA.UBF.Report.App.Data.dll
            SimpleOqlTool simpleTool = new SimpleOqlTool();
            simpleTool.AddSelect("ID", "ID");
            simpleTool.AddSelect("Customer.ID", "Customer_ID");
            //1.处理栏目，形成Select子句
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                simpleTool.AddSelect(this.map[columnitem.ColumnAlias], columnitem.ColumnAlias);
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool.AddCondition(bpParameter.FilterOpath);
            simpleTool.AddCondition(string.Format("Org = {0}",UFIDA.U9.Base.Context.LoginOrg.ID));
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                simpleTool.AddOrder(this.map[sortItem.ColumnName],
                    sortItem.OrderType == OrderType.Ascend);
            }
            //处理From部份，形成From子句
            simpleTool.SetFromClause("UFIDA::U9::CBO::SCM::Customer::Customer as Customer"); //在这里替换From子句中的实体名称
            //获取OQL串 
            string selectResult = simpleTool.GetOqlString();
            return selectResult;
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
            QryPaginateService<CustomerQucikQryDTO> ps = new QryPaginateService<CustomerQucikQryDTO>(bpParameter,
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

        public readonly static string ID = "ID";
        public static readonly string Customer_ID = "Customer_ID";
        public static readonly string Customer_Code = "Customer_Code";
        public static readonly string Customer_Name = "Customer_Name";
        public static readonly string EnterpriseLegalPerson = "EnterpriseLegalPerson";
        public static readonly string MobileNo = "MobileNo";
        public static readonly string PhoneNo = "PhoneNo";
        public static readonly string Customer_CustomerCategory = "Customer_CustomerCategory";
        public static readonly string Fax = "Fax";
        public static readonly string ActualAPMoney = "ActualAPMoney";
        public static readonly string CreditMoney = "CreditMoney";
        public static readonly string LastTransMoney = "LastTransMoney";
        public static readonly string LastRecMoney = "LastRecMoney";
        public static readonly string TaxNo = "TaxNo";
        public static readonly string BankName = "BankName";
        public static readonly string Memo = "Memo";
        public static readonly string Address = "Address";
        public static readonly string Customer_Saleser = "Customer_Saleser";
        public static readonly string CustomerCategoryName = "CustomerCategoryName";
        public static readonly string SaleserName = "SaleserName";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(Customer_ID, "Customer.ID");
            //编码
            map.Add(Customer_Code, "Customer.Code");
            //名称
            map.Add(Customer_Name, "Customer.Name");
            //负责人
            map.Add(EnterpriseLegalPerson, "''");
            //手机
            map.Add(MobileNo, "''");
            //电话
            map.Add(PhoneNo, "''");
            //客户_分类
            map.Add(Customer_CustomerCategory, "Customer.CustomerCategory");
            //传真
            map.Add(Fax, "''");
            //实际应收
            map.Add(ActualAPMoney, "0.0");
            //信用额度
            map.Add(CreditMoney, "0.0");
            //最后交易额
            map.Add(LastTransMoney, "0.0");
            //最后收款金额
            map.Add(LastRecMoney, "0.0");
            //税号
            map.Add(TaxNo, "''");
            //开户银行
            map.Add(BankName, "''");
            //说明
            map.Add(Memo, "''");
            //地址
            map.Add(Address, "''");
            //客户_业务员
            map.Add(Customer_Saleser, "Customer.Saleser");
            //客户分类
            map.Add(CustomerCategoryName, "''");
            //业务员
            map.Add(SaleserName, "''");
            //ID
            map.Add(ID, "ID");
        }
    }

    #endregion

    #endregion
}