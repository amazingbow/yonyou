using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.FJGX.SOInfoQueryBP.PubBase;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP
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
            return "UFIDA.U9.SM.SO.SO";
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
            //必须引用UFIDA.UBF.Report.App.Data.dll
            #region 销售单
            SimpleOqlTool simpleTool = new SimpleOqlTool();
            foreach (string strKey in map.Keys)
            {
                switch (strKey)
                {
                    case "ID":
                        simpleTool.AddSelect("SO.ID", "ID");
                        break;
                    case "TotalShipMoney":
                        simpleTool.AddSelect(@"(select sum(SOLine.SOLineSumInfo.SumShipQtyTU*SOLine.FinallyPriceTC) as TotalShipMoney 
                            from UFIDA::U9::SM::SO::SOLine as SOLine where SOLine.SO = SO.ID)", "TotalShipMoney");
                        break;
                    case "SumTotalMoney":
                    case "SumTotalShipMoney":
                        //                        simpleTool.AddSelect(@"(select sum(SOLine.SOLineSumInfo.TotalShipQty*TotalShipMoney) as SumTotalMoney 
                        //                            from UFIDA::U9::SM::SO::SOLine as SOLine where SOLine.SO = SO.ID)", "SumTotalMoney");
                        break;
                    default:
                        simpleTool.AddSelect(this.map[strKey], strKey);
                        break;
                }
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == "TotalShipMoney") continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            simpleTool.AddCondition(bpParameter.FilterOpath);
            simpleTool.AddCondition(string.Format("SO.Org = {0}", Context.LoginOrg.ID));
            simpleTool.SetFromClause(@"UFIDA::U9::SM::SO::SO as SO inner join UFIDA::U9::CBO::SCM::Customer::Customer as Customer on 
                                  SO.OrderBy.Customer = Customer.ID left join UFIDA::U9::CBO::SCM::Customer::CustomerContact as CustomerContact on 
                                  CustomerContact.Customer = Customer.ID and CustomerContact.IsDefault = 1"); //在这里替换From子句中的实体名称
            #endregion
            #region 退回处理单
            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            foreach (string strKey in map.Keys)
            {
                switch (strKey)
                {
                    case "ID":
                        simpleTool1.AddSelect("SO.ID", "ID");
                        break;
                    case "TotalShipMoney":
                        simpleTool1.AddSelect(@"(select sum(SOLine.RtnMoneyFCNet )  from UFIDA::U9::SM::RMA::RMALine as SOLine 
                                                        where SOLine.RMA = SO.ID)*-1", "TotalShipMoney");
                        break;
                    case "SO_SaleDepartment":
                        simpleTool1.AddSelect("SO.SaleDept", "SO_SaleDepartment");
                        break;
                    case "SO_SaleDepartment_Code":
                        simpleTool1.AddSelect("SO.SaleDept.Code", "SO_SaleDepartment_Code");
                        break;
                    case "SO_SaleDepartment_Name":
                        simpleTool1.AddSelect("SO.SaleDept.Name", "SO_SaleDepartment_Name");
                        break;
                    case "SO_TotalMoneyAC":
                        simpleTool1.AddSelect(@"(select sum(SOLine.RtnMoneyFCNet )  from UFIDA::U9::SM::RMA::RMALine as SOLine 
                                                        where SOLine.RMA = SO.ID)*-1", "SO_TotalMoneyAC");
                        break;
                    case "SumTotalMoney":
                    case "SumTotalShipMoney":
                        break;
                    default:
                        simpleTool1.AddSelect(this.map[strKey], strKey);
                        break;
                }
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                string leftExpr = string.Empty;
                switch (filterItem.Name)
                {
                    case "TotalShipMoney":
                    case "SO_TotalMoneyAC":
                        break;
                    case "SO_SaleDepartment":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SO.SaleDept");
                        break;
                    case "SO_SaleDepartment_Code":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SO.SaleDept.Code");
                        break;
                    case "SO_SaleDepartment_Name":
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "SO.SaleDept.Name");
                        break;
                    default:
                        leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                        break;
                }
                simpleTool1.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);
            }
            simpleTool1.AddCondition(bpParameter.FilterOpath);
            simpleTool1.AddCondition(string.Format("SO.Org = {0}", Context.LoginOrg.ID));
            simpleTool1.SetFromClause(@"UFIDA::U9::SM::RMA::RMA as SO inner join UFIDA::U9::CBO::SCM::Customer::Customer as Customer on 
                                  SO.Customer.Customer = Customer.ID left join UFIDA::U9::CBO::SCM::Customer::CustomerContact as CustomerContact on 
                                  CustomerContact.Customer = Customer.ID and CustomerContact.IsDefault = 1"); //在这里替换From子句中的实体名称
            #endregion
            SimpleOqlTool totalSimpleTool = new SimpleOqlTool();
            foreach (string strKey in map.Keys)
            {
                if (strKey == "SumTotalMoney" || strKey == "SumTotalShipMoney")
                {
                    continue;
                }
                totalSimpleTool.AddSelect(strKey, strKey);
            }
            totalSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                simpleTool.GetOqlString(),
                " union all ",
                simpleTool1.GetOqlString(),
                ") as SO "
            }));
            TempTableUtil.CreateTempTableByOql("SOTempTable", totalSimpleTool.GetOqlString(), entityViewQuery);

            #region 计算合计金额

            decimal sumTotalMoney = 0;
            //合计总额
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.SO_TotalMoneyAC)", "SumTotalMoney");
            sumSimpleTool.SetFromClause(string.Concat(new[]
            {
                "(",
                totalSimpleTool.GetOqlString(),
                ") as sumOql "
            }));
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumTotalMoney = DataRowConverter.AsDecimal(row, "SumTotalMoney");
            }

            #endregion

            #region 计算出货金额

            decimal SumTotalShipMoney = 0;
            //合计总额
            SimpleOqlTool sumTotalShipTool = new SimpleOqlTool();
            sumTotalShipTool.AddSelect("sum(shipOql.TotalShipMoney)", "SumTotalShipMoney");
            sumTotalShipTool.SetFromClause(string.Concat(new[]
            {
                "(",
                totalSimpleTool.GetOqlString(),
                ") as shipOql "
            }));
            ObjectQuery query1 = entityViewQuery.CreateQuery(sumTotalShipTool.GetOqlString());
            DataSet dataSet1 = entityViewQuery.ExecuteDataSet(query1, null);
            if (dataSet1 != null && dataSet1.Tables.Count > 0 && dataSet1.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet1.Tables[0].Rows[0];
                SumTotalShipMoney = DataRowConverter.AsDecimal(row, "SumTotalShipMoney");
            }

            #endregion

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumTotalMoney.ToString("F2"), "SumTotalMoney");
            resultTool.AddSelect(SumTotalShipMoney.ToString("F2"), "SumTotalShipMoney");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == "SumTotalShipMoney") continue;
                resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
            }
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != "TotalShipMoney") continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "A." + filterItem.Name);
                resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            resultTool.SetFromClause(@"#SOTempTable as A ");
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
            QryPaginateService<SOHeadInfoQryDTO> ps = new QryPaginateService<SOHeadInfoQryDTO>(bpParameter,
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
        public static readonly string SO_ID = "SO_ID";
        public static readonly string SO_DocNo = "SO_DocNo";
        public static readonly string SO_BusinessDate = "SO_BusinessDate";
        public static readonly string Customer_Code = "Customer_Code";
        public static readonly string Customer_Name = "Customer_Name";
        public static readonly string CustomerContact_Contact = "CustomerContact_Contact";
        public static readonly string CustomerContact_Contact_Name = "CustomerContact_Contact_Name";
        public static readonly string SO_Seller = "SO_Seller";
        public static readonly string SO_Seller_Code = "SO_Seller_Code";
        public static readonly string SO_Seller_Name = "SO_Seller_Name";
        public static readonly string SO_SaleDepartment = "SO_SaleDepartment";
        public static readonly string SO_SaleDepartment_Code = "SO_SaleDepartment_Code";
        public static readonly string SO_SaleDepartment_Name = "SO_SaleDepartment_Name";
        public static readonly string SO_TotalMoneyAC = "SO_TotalMoneyAC";

        public static readonly string CustomerContact_Contact_DefaultPhoneNum =
            "CustomerContact_Contact_DefaultPhoneNum";

        public static readonly string CustomerContact_Contact_DefaultMobilNum =
            "CustomerContact_Contact_DefaultMobilNum";
        public readonly static string SumTotalMoney = "SumTotalMoney";
        public readonly static string TotalShipMoney = "TotalShipMoney";
        public readonly static string SumTotalShipMoney = "SumTotalShipMoney";

        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //ID
            map.Add(SO_ID, "SO.ID");
            //单号
            map.Add(SO_DocNo, "SO.DocNo");
            //单据日期
            map.Add(SO_BusinessDate, "SO.BusinessDate");
            //编码
            map.Add(Customer_Code, "Customer.Code");
            //名称
            map.Add(Customer_Name, "Customer.Name");
            //负责人
            map.Add(CustomerContact_Contact, "CustomerContact.Contact");
            //名称
            map.Add(CustomerContact_Contact_Name, "CustomerContact.Contact.Name");
            //业务员
            map.Add(SO_Seller, "SO.Seller");
            //编码
            map.Add(SO_Seller_Code, "SO.Seller.Code");
            //名称
            map.Add(SO_Seller_Name, "SO.Seller.Name");
            //部门
            map.Add(SO_SaleDepartment, "SO.SaleDepartment");
            //编码
            map.Add(SO_SaleDepartment_Code, "SO.SaleDepartment.Code");
            //名称
            map.Add(SO_SaleDepartment_Name, "SO.SaleDepartment.Name");
            //金额
            map.Add(SO_TotalMoneyAC, "SO.TotalMoneyAC");
            //电话
            map.Add(CustomerContact_Contact_DefaultPhoneNum, "CustomerContact.Contact.DefaultPhoneNum");
            //手机
            map.Add(CustomerContact_Contact_DefaultMobilNum, "CustomerContact.Contact.DefaultMobilNum");
            //合计金额
            map.Add(SumTotalMoney, "SumTotalMoney");
            //累计出货金额
            map.Add(TotalShipMoney, "TotalShipMoney ");
            //标准收货
            map.Add(SumTotalShipMoney, "SumTotalShipMoney ");
        }
    }

    #endregion

    #endregion
}