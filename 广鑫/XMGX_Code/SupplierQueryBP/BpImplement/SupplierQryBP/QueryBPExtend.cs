using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Cust.FJGX.SupplierQueryBP;
using UFIDA.U9.Query.QueryCaseBP;
using UFIDA.UBF.Query.CommonService;
using UFIDA.UBF.Report.App.Data;
using UFIDA.UBF.Report.App.Data.Util;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Business;
using UFIDA.U9.Query.QueryCaseBE;
using UFIDA.U9.Base;
using UFSoft.UBF.View.Query;

namespace UFIDA.U9.Cust.FJGX.SupplierQryBP
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
            return "UFIDA.U9.CBO.SCM.Supplier.Supplier";
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
            //创建供应商临时表
            CreateSupplierTable(bpParameter, entityViewQuery);
            //实际应付余额临时表
            CreateAPTotalMoneyTable(bpParameter, entityViewQuery);

            //合计总额
            decimal sumAPTotalMoney = 0;
            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sum(sumOql.APTotalMoney)", "SumAPTotalMoney");
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name != APTotalMoney) continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "sumOql." + filterItem.Name);
                sumSimpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            sumSimpleTool.SetFromClause("#APTotalMoneyTable as sumOql");
            ObjectQuery query = entityViewQuery.CreateQuery(sumSimpleTool.GetOqlString());
            DataSet dataSet = entityViewQuery.ExecuteDataSet(query, null);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                sumAPTotalMoney = DataRowConverter.AsDecimal(row, "SumAPTotalMoney");
            }

            SimpleOqlTool resultTool = new SimpleOqlTool();
            resultTool.AddSelect("A.ID", "ID");
            resultTool.AddSelect("A.Supplier_ID", "Supplier_ID");
            resultTool.AddSelect("row_number() over(order by A.ID desc)", "sn");
            resultTool.AddSelect(sumAPTotalMoney.ToString("F2"), "SumAPTotalMoney");
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == APTotalMoney)
                {
                    resultTool.AddSelect("B." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
                else
                {
                    resultTool.AddSelect("A." + columnitem.ColumnAlias, columnitem.ColumnAlias);
                }
            }
            resultTool.SetFromClause(@"#SupplierTable as A left join #APTotalMoneyTable as B on A.ID = B.SupplierID");
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == APTotalMoney)
                {
                    string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, "B." + filterItem.Name);
                    resultTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                        filterItem.ValueType);
                }
            }
            string oqlString = resultTool.GetOqlString();
            //3.处理Order
            foreach (QrySortItem sortItem in bpParameter.QrySortItems)
            {
                if (this.map[sortItem.ColumnName] == null || this.map[sortItem.ColumnName] == "") continue;
                if (sortItem.ColumnName == APTotalMoney)
                {
                    resultTool.AddOrder("B." + sortItem.ColumnName, sortItem.OrderType == OrderType.Ascend);
                }
                else
                {
                    resultTool.AddOrder("A." + sortItem.ColumnName, sortItem.OrderType == OrderType.Ascend);
                }
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
        /// 创建供应商临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateSupplierTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            SimpleOqlTool sqlTool = new SimpleOqlTool();
            sqlTool.AddSelect("ID", "ID");
            sqlTool.AddSelect("Supplier.ID", "Supplier_ID");
            //1.处理栏目，形成Select子句
            foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
            {
                if (columnitem.ColumnAlias == APTotalMoney)
                    continue;
                sqlTool.AddSelect(this.map[columnitem.ColumnAlias], columnitem.ColumnAlias);
            }
            //2.处理条件，形成Where子句
            foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
            {
                if (filterItem.Name == APTotalMoney)
                    continue;
                string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);
                sqlTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues,
                    filterItem.ValueType);
            }
            sqlTool.AddCondition(bpParameter.FilterOpath);
            sqlTool.AddCondition(string.Format("Supplier.Org = {0}", Context.LoginOrg.ID));

            StringBuilder fromSb = new StringBuilder();
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::Supplier as Supplier");
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::SupplierContact as SupplierContact"); //供应商联系人
            fromSb.Append(" on ");
            fromSb.Append("SupplierContact.Supplier = Supplier.ID and SupplierContact.IsDefault = 1"); //供应商联系人 = 默认
            fromSb.Append(" left join ");
            fromSb.Append("UFIDA::U9::CBO::SCM::Supplier::SupplierBankAccount as SupplierBankAccount"); //供应商银行账号  
            fromSb.Append(" on ");
            fromSb.Append("SupplierBankAccount.Supplier = Supplier.ID and SupplierBankAccount.IsDefault = 1");
            //供应商银行账号 = 默认
            //处理From部份，形成From子句
            sqlTool.SetFromClause(fromSb.ToString()); //在这里替换From子句中的实体名称
            TempTableUtil.CreateTempTableByOql("SupplierTable", sqlTool.GetOqlString(), entityViewQuery);
        }

        /// <summary>
        /// 实际应付余额临时表
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <param name="entityViewQuery"></param>
        private void CreateAPTotalMoneyTable(QryCommonParaObj bpParameter, EntityViewQuery entityViewQuery)
        {
            #region 应付单

            SimpleOqlTool simpleTool1 = new SimpleOqlTool();
            simpleTool1.AddSelect("APBillHead.AccrueSupp.Supplier", "SupplierID");
            simpleTool1.AddSelect(@"(case when (APBillHead.BusinessType = 188 or APBillHead.BusinessType = 190) 
                then APBillHead.APOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool1.AddSelect(@"(case when (APBillHead.BusinessType = 187 or APBillHead.BusinessType = 189) 
                then APBillHead.APOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool1.AddCondition(string.Format("APBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool1.AddCondition("APBillHead.BusinessType in (187,188,189,190)");
            simpleTool1.AddCondition("APBillHead.DocumentType.Code not in ('02','03','04','05','11','12','13')");
            simpleTool1.AddCondition("APBillHead.AccrueSupp.Supplier in (select ID from #SupplierTable)");
            simpleTool1.SetFromClause("UFIDA::U9::AP::APBill::APBillHead as APBillHead");

            #endregion

            #region 收货/退货单

            SimpleOqlTool simpleTool2 = new SimpleOqlTool();
            simpleTool2.AddSelect("Rcv.Supplier.Supplier", "SupplierID");
            simpleTool2.AddSelect("case when Rcv.ReceivementType = 0 then Rcv.TotalArriveMnyAC else Rcv.TotalRtnDeductMnyAC*-1 end", "DebitMoney");
            simpleTool2.AddSelect("0.0", "CreditMoney");
            simpleTool2.AddCondition(string.Format("Rcv.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool2.AddCondition("Rcv.Supplier.Supplier in (select ID from #SupplierTable)");
            simpleTool2.AddCondition("Rcv.ReceivementType in (0,1)");
            simpleTool2.SetFromClause("UFIDA::U9::PM::Rcv::Receivement as Rcv");

            #endregion

            #region 付款单

            SimpleOqlTool simpleTool3 = new SimpleOqlTool();
            simpleTool3.AddSelect("PayBillHead.Supp.Supplier", "SupplierID");
            simpleTool3.AddSelect(@"0.0", "DebitMoney");
            simpleTool3.AddSelect(@"PayBillHead.TotalMoney.OCMoney", "CreditMoney");
            simpleTool3.AddCondition(string.Format("PayBillHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool3.AddCondition("PayBillHead.Supp.Supplier in (select ID from #SupplierTable)");
            simpleTool3.SetFromClause("UFIDA::U9::AP::Payment::PayBillHead as PayBillHead");

            #endregion

            #region 应付对冲

            SimpleOqlTool simpleTool4 = new SimpleOqlTool();
            simpleTool4.AddSelect("ARAPCAHead.Supplier.Supplier", "SupplierID");
            simpleTool4.AddSelect(@"0.0", "DebitMoney");
            simpleTool4.AddSelect(@"ARAPCAHead.ARCAMoney.OCMoney", "CreditMoney");
            simpleTool4.AddCondition(string.Format("ARAPCAHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool4.AddCondition("ARAPCAHead.Supplier.Supplier.ID in (select ID from #SupplierTable)");
            simpleTool4.SetFromClause("UFIDA::U9::AP::ARAPCounterApply::ARAPCAHead as ARAPCAHead");

            #endregion

            #region 债权转移单

            #region 转出客户

            SimpleOqlTool simpleTool5 = new SimpleOqlTool();
            simpleTool5.AddSelect("APDTHead.TransOutAccrueSupp.Supplier", "SupplierID");
            simpleTool5.AddSelect(@"sum(case when (APDTLine.TransOutBizType = 186 or APDTLine.TransOutBizType = 187 or APDTLine.TransOutBizType = 189) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool5.AddSelect(@"sum(case when (APDTLine.TransOutBizType = 188 or APDTLine.TransOutBizType = 190 or APDTLine.TransOutBizType = 192 or APDTLine.TransOutBizType = 193) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool5.AddCondition(string.Format("APDTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool5.AddCondition("APDTHead.IsTransAccrueSupp = 1");
            simpleTool5.AddCondition("APDTHead.Cancel.Canceled = 0");//未作废
            simpleTool5.AddCondition("APDTLine.TransOutBizType in (186,187,188,189,190,192,193)");
            simpleTool5.AddCondition("APDTHead.TransOutAccrueSupp.Supplier.ID in (select ID from #SupplierTable)");
            StringBuilder fromSb5 = new StringBuilder();
            fromSb5.Append("UFIDA::U9::AP::APDT::APDTLine as APDTLine");
            fromSb5.Append(" inner join ");
            fromSb5.Append("UFIDA::U9::AP::APDT::APDTHead as APDTHead");
            fromSb5.Append(" on ");
            fromSb5.Append("APDTLine.APDTHead = APDTHead.ID");
            simpleTool5.SetFromClause(fromSb5.ToString());
            simpleTool5.AddGroup("APDTHead.TransOutAccrueSupp.Supplier");

            #endregion

            #region 转入客户

            SimpleOqlTool simpleTool6 = new SimpleOqlTool();
            simpleTool6.AddSelect("APDTHead.TransInAccrueSupp.Supplier", "SupplierID");
            simpleTool6.AddSelect(@"sum(case when (APDTLine.TransInBizType = 188 or APDTLine.TransInBizType = 190 or APDTLine.TransInBizType = 192 or APDTLine.TransInBizType = 193) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "DebitMoney");
            simpleTool6.AddSelect(@"sum(case when (APDTLine.TransInBizType = 186 or APDTLine.TransInBizType = 187 or APDTLine.TransInBizType = 189) 
                then APDTLine.TransOCMoney.TotalMoney else 0.0 end)", "CreditMoney");
            simpleTool6.AddCondition(string.Format("APDTHead.Org = {0}", Base.Context.LoginOrg.ID));
            simpleTool6.AddCondition("APDTHead.IsTransAccrueSupp = 1");
            simpleTool6.AddCondition("APDTHead.Cancel.Canceled = 0");//未作废
            simpleTool6.AddCondition("APDTLine.TransInBizType in (186,187,188,189,190,192,193)");
            simpleTool6.AddCondition("APDTHead.TransInAccrueSupp.Supplier.ID in (select ID from #SupplierTable)");
            StringBuilder fromSb6 = new StringBuilder();
            fromSb6.Append("UFIDA::U9::AP::APDT::APDTLine as APDTLine");
            fromSb6.Append(" inner join ");
            fromSb6.Append("UFIDA::U9::AP::APDT::APDTHead as APDTHead");
            fromSb6.Append(" on ");
            fromSb6.Append("APDTLine.APDTHead = APDTHead.ID");
            simpleTool6.SetFromClause(fromSb6.ToString());
            simpleTool6.AddGroup("APDTHead.TransInAccrueSupp.Supplier");

            #endregion

            #endregion

            SimpleOqlTool sumSimpleTool = new SimpleOqlTool();
            sumSimpleTool.AddSelect("sumOql.SupplierID", "SupplierID");
            sumSimpleTool.AddSelect("sum(sumOql.DebitMoney - sumOql.CreditMoney)", APTotalMoney);
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
            sumSimpleTool.AddGroup("sumOql.SupplierID");
            TempTableUtil.CreateTempTableByOql("APTotalMoneyTable", sumSimpleTool.GetOqlString(), entityViewQuery);
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
            QryPaginateService<SupplierQryDTO> ps = new QryPaginateService<SupplierQryDTO>(bpParameter,
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
        public readonly static string Supplier_ID = "Supplier_ID";
        public readonly static string Supplier_Code = "Supplier_Code";
        public readonly static string Supplier_Name = "Supplier_Name";
        public readonly static string SupplierContact_Contact = "SupplierContact_Contact";
        public readonly static string SupplierContact_Contact_Name = "SupplierContact_Contact_Name";
        public readonly static string SupplierContact_Contact_DefaultMobilNum = "SupplierContact_Contact_DefaultMobilNum";
        public readonly static string SupplierContact_Contact_DefaultPhoneNum = "SupplierContact_Contact_DefaultPhoneNum";
        public readonly static string Supplier_Category = "Supplier_Category";
        public readonly static string Supplier_Category_Name = "Supplier_Category_Name";
        public readonly static string SupplierContact_Contact_DefaultFaxNum = "SupplierContact_Contact_DefaultFaxNum";
        public readonly static string APTotalMoney = "APTotalMoney";
        public readonly static string Supplier_StateTaxNo = "Supplier_StateTaxNo";
        public readonly static string SupplierBankAccount_Name = "SupplierBankAccount_Name";
        public readonly static string Supplier_OfficialLocation_Name = "Supplier_OfficialLocation_Name";
        public readonly static string Supplier_Purchaser = "Supplier_Purchaser";
        public readonly static string Supplier_Purchaser_Name = "Supplier_Purchaser_Name";
        public readonly static string Supplier_Description = "Supplier_Description";
        public readonly static string SumAPTotalMoney = "SumAPTotalMoney";
        #endregion

        private void DoMap()
        {
            //ID
            map.Add(ID, "ID");
            //ID
            map.Add(Supplier_ID, "Supplier.ID");
            //编码
            map.Add(Supplier_Code, "Supplier.Code");
            //名称
            map.Add(Supplier_Name, "Supplier.Name");
            //联系人
            map.Add(SupplierContact_Contact, "SupplierContact.Contact");
            //名称
            map.Add(SupplierContact_Contact_Name, "SupplierContact.Contact.Name");
            //手机
            map.Add(SupplierContact_Contact_DefaultMobilNum, "SupplierContact.Contact.DefaultMobilNum");
            //电话
            map.Add(SupplierContact_Contact_DefaultPhoneNum, "SupplierContact.Contact.DefaultPhoneNum");
            //分类
            map.Add(Supplier_Category, "Supplier.Category");
            //名称
            map.Add(Supplier_Category_Name, "Supplier.Category.Name");
            //传真
            map.Add(SupplierContact_Contact_DefaultFaxNum, "SupplierContact.Contact.DefaultFaxNum");
            //应付余额
            map.Add(APTotalMoney, "APTotalMoney");
            //税号
            map.Add(Supplier_StateTaxNo, "Supplier.StateTaxNo");
            //开户银行
            map.Add(SupplierBankAccount_Name, "SupplierBankAccount.Name");
            //名称
            map.Add(Supplier_OfficialLocation_Name, "Supplier.OfficialLocation.Name");
            //业务员
            map.Add(Supplier_Purchaser, "Supplier.Purchaser");
            //名称
            map.Add(Supplier_Purchaser_Name, "Supplier.Purchaser.Name");
            //描述
            map.Add(Supplier_Description, "Supplier.Description");
            //合计应付金额
            map.Add(SumAPTotalMoney, "SumAPTotalMoney");
        }
    }

    #endregion

    #endregion
}