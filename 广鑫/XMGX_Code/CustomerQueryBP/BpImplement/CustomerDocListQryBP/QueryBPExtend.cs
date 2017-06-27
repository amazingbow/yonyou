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
using UFSoft.UBF.Business;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.CustomerDocListQryBP
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
            return "UFIDA.U9.SM.Ship.Ship";
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
            this.DoMap();

            #region 出货

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("Ship.ID", "ID");
            simpleTool1.AddSelect("0", "DocType");
            simpleTool1.AddSelect("Ship.DocNo", "DocNo");
            simpleTool1.AddSelect("Ship.BusinessDate", "BusinessDate");
            simpleTool1.AddSelect("Customer.ID", "Customer");
            simpleTool1.AddSelect("Customer.Name", "Customer_Name");
            simpleTool1.AddSelect("CustomerContact.ID", "CustomerContact");
            simpleTool1.AddSelect("CustomerContact.Contact.Name", "CustomerContact_Contact_Name");
            simpleTool1.AddSelect("Ship.Seller.ID", "Operators");
            simpleTool1.AddSelect("Ship.Seller.Name", "Operators_Name");
            simpleTool1.AddSelect("Ship.TotalMoneyTC", "TotalMoney");
            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::SM::Ship::Ship as Ship");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb.Append(" on ");
            fromSb.Append("Customer.ID = Ship.OrderBy.Customer"); //客户联系人 = 默认
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Customer::CustomerContact as CustomerContact"); //客户联系人
            fromSb.Append(" on ");
            fromSb.Append("Customer.ID = CustomerContact.Customer and CustomerContact.IsDefault = 1"); //客户联系人 = 默认
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "DocNo":
                    case "BusinessDate":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship." + filterItem.Name);
                        break;
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "CustomerContact":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "CustomerContact.ID");
                        break;
                    case "Operators":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship.Seller.ID");
                        break;
                    case "Operators_Name":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Ship.Seller.Name");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool1.AddCondition(string.Format("Ship.OperatingOrg  = {0}", Context.LoginOrg.ID));
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool1.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称

            #endregion

            #region 退回处理单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("RMA.ID", "ID");
            simpleTool2.AddSelect("1", "DocType");
            simpleTool2.AddSelect("RMA.DocNo", "DocNo");
            simpleTool2.AddSelect("RMA.BusinessDate", "BusinessDate");
            simpleTool2.AddSelect("Customer.ID", "Customer");
            simpleTool2.AddSelect("Customer.Name", "Customer_Name");
            simpleTool2.AddSelect("CustomerContact.ID", "CustomerContact");
            simpleTool2.AddSelect("CustomerContact.Contact.Name", "CustomerContact_Contact_Name");
            simpleTool2.AddSelect("RMA.Seller.ID", "Operators");
            simpleTool2.AddSelect("RMA.Seller.Name", "Operators_Name");
            simpleTool2.AddSelect(@"(select sum(RMALine.RtnMoneyTC)*-1 as SumRtnMoneyTC from UFIDA::U9::SM::RMA::RMALine as RMALine 
                where RMALine.RMA = RMA.ID)", "TotalMoney");
            StringBuilder fromSb2 = new StringBuilder();
            fromSb2.Append("UFIDA::U9::SM::RMA::RMA as RMA");
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Customer::Customer as Customer");
            fromSb2.Append(" on ");
            fromSb2.Append("Customer.ID = RMA.Customer.Customer"); //客户 = 退货客户
            fromSb2.Append(" left join ");
            fromSb2.Append("UFIDA::U9::CBO::SCM::Customer::CustomerContact as CustomerContact"); //客户联系人
            fromSb2.Append(" on ");
            fromSb2.Append("Customer.ID = CustomerContact.Customer and CustomerContact.IsDefault = 1"); //客户联系人 = 默认
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr;
                switch (filterItem.Name)
                {
                    case "DocNo":
                    case "BusinessDate":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA." + filterItem.Name);
                        break;
                    case "Customer":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "Customer.ID");
                        break;
                    case "CustomerContact":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "CustomerContact.ID");
                        break;
                    case "Operators":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA.Seller.ID");
                        break;
                    case "Operators_Name":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "RMA.Seller.Name");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool2.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool2.AddCondition(string.Format("RMA.Org = {0}", Context.LoginOrg.ID));
            simpleTool2.AddCondition(bpParameter.FilterOpath);
            //处理From部份，形成From子句
            simpleTool2.SetFromClause(fromSb2.ToString()); //在这里替换From子句中的实体名称

            #endregion

            #region 计算合计金额

            //合计
            decimal sumTotalMoney = 0;
            EntityViewQuery entityViewQuery = new EntityViewQuery();
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.TotalMoney)", "SumTotalMoney");
            sumSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool1.GetOqlString(),
                " union all ",
                simpleTool2.GetOqlString(),
                ") as sumOql "
            }));
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == "TotalMoney" || filterItem.Name == "DocType")
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "sumOql." + filterItem.Name);
                    sumSimpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                        filterItem.RightValues,
                        filterItem.ValueType);
                }
            }
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumTotalMoney = DataRowConverter.AsDecimal(row, "SumTotalMoney");
            }

            #endregion

            #region 返回结果

            SimpleOqlTool resultOqlTool = new SimpleOqlTool();
            resultOqlTool.AddSelect("finallOql.ID", "ID");
            resultOqlTool.AddSelect("row_number() over(order by finallOql.ID desc)", "sn");
            resultOqlTool.AddSelect(sumTotalMoney.ToString(), "SumTotalMoney");
            foreach (QryColumnItem current in bpParameter.QryColumnItems)
            {
                if (current.ColumnAlias == "SumTotalMoney")
                    continue;
                resultOqlTool.AddSelect("finallOql." + current.ColumnAlias, current.ColumnAlias);
            }
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == "TotalMoney" || filterItem.Name == "DocType")
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "finallOql." + filterItem.Name);
                    resultOqlTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation,
                        filterItem.RightValues,
                        filterItem.ValueType);
                }
            }
            resultOqlTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool1.GetOqlString(),
                " union all ",
                simpleTool2.GetOqlString(),
                ") as finallOql "
            }));
            string oqlString = resultOqlTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                resultOqlTool.AddOrder("finallOql." + sortItem.ColumnName,
                    sortItem.OrderType == OrderType.Ascend);
            }
            if (resultOqlTool.Orders != null && resultOqlTool.Orders.Count > 0)
            {
                return oqlString + " order by " + resultOqlTool.Orders;
            }
            return oqlString;

            #endregion
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
            QryPaginateService<CustomerDocListQryDTO> ps = new QryPaginateService<CustomerDocListQryDTO>(bpParameter,
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
        public static readonly string Customer = "Customer";
        public static readonly string Customer_Name = "Customer_Name";
        public static readonly string CustomerContact = "CustomerContact";
        public static readonly string CustomerContact_Contact_Name = "CustomerContact_Contact_Name";
        public static readonly string Operators = "Operators";
        public static readonly string Operators_Name = "Operators_Name";
        public static readonly string TotalMoney = "TotalMoney";
        public static readonly string DocType = "DocType";

        #endregion

        private void DoMap()
        {
            map.Clear();
            //ID
            map.Add(ID, "ID");
            //单据编号
            map.Add(DocNo, "DocNo");
            //单据日期
            map.Add(BusinessDate, "BusinessDate");
            //客户
            map.Add(Customer, "Customer");
            //名称
            map.Add(Customer_Name, "Customer.Name");
            //联系人
            map.Add(CustomerContact, "CustomerContact");
            //名称
            map.Add(CustomerContact_Contact_Name, "CustomerContact.Contact.Name");
            //业务员
            map.Add(Operators, "Operators");
            //名称
            map.Add(Operators_Name, "Operators.Name");
            //总金额
            map.Add(TotalMoney, "TotalMoney");
            //单据种类
            map.Add(DocType, "DocType");
        }
    }

    #endregion

    #endregion
}