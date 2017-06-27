namespace UFIDA.U9.Cust.XMJL.CustomerSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.AR.Receival;
    using System.Data;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.AR.ARBill;
    using UFIDA.U9.AP.Payment;
    using UFIDA.U9.AR.ARCT;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.SCM.Customer;

    /// <summary>
    /// QueryBalance partial 
    /// </summary>	
    public partial class QueryBalance
    {
        internal BaseStrategy Select()
        {
            return new QueryBalanceImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryBalanceImpementStrategy : BaseStrategy
    {
        public QueryBalanceImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryBalance bpObj = (QueryBalance)obj;

            List<CustomerBalanceDTO> result = new List<CustomerBalanceDTO>();
            foreach (string code in bpObj.Codes)
            {
                UFSoft.UBF.PL.OqlParam[] oqlParameters = new UFSoft.UBF.PL.OqlParam[]
                {
                    new UFSoft.UBF.PL.OqlParam(code)
                    {
                        ParamName = "Code",
                        Value = code,
                        Type = DbType.String,
                    },
                };
                string name = "";

                Customer cust = Customer.Finder.Find("Code=@Code", oqlParameters);
                if (cust == null)
                {
                    continue;
                }
                else
                {
                    name = cust.Name;
                }
                #region old
                ////收款单  (-Money.OCMoney)
                //string oql = "Cust.Code=@Code and DocStatus in (2,3,4)";
                //RecBillHead.EntityList list1 = RecBillHead.Finder.FindAll(oql, oqlParameters);
                //foreach (RecBillHead data in list1)
                //{
                //    balance -= data.Money.OCMoney;
                //}

                ////收款转入/贷项账户单/发票/借项账户单 (+AROCMoney.NonTax)
                //string oql2 = "PayCust.Code=@Code and DocStatus in (2,3,4) and BusinessType in (0,3,4,5,6,9)";
                //ARBillHead.EntityList list2 = ARBillHead.Finder.FindAll(oql2, oqlParameters);
                //foreach (ARBillHead data in list2)
                //{
                //    balance += data.AROCMoney.NonTax;
                //}

                ////付款单 (-Money.OCMoney)
                //string oql3 = "Cust.Code=@Code and DocStatus in (2,3,4)";
                //PayBillHead.EntityList list3 = PayBillHead.Finder.FindAll(oql3, oqlParameters);
                //foreach (PayBillHead data in list3)
                //{
                //    balance -= data.Money.OCMoney;
                //}

                ////债权转移 (+TotalMoney.OCMoney)
                //string oql4 = "TransOutPayCust.Code=@Code and DocStatus in (2,3,4)";
                //ARCTHead.EntityList list4 = ARCTHead.Finder.FindAll(oql4, oqlParameters);
                //foreach (ARCTHead data in list4)
                //{
                //    balance += data.TotalMoney.OCMoney;
                //}
                #endregion
                CustomerBalanceDTO dto = new CustomerBalanceDTO();
                {
                    dto.Code = code;
                    dto.Name = name;
                    dto.Balance = GetBalance(code);
                }
                result.Add(dto);

            }
            return result;
        }
        private decimal GetBalance(string code)
        {
            string oql = @"select sum(DRFCMoney.TotalMoney)-sum(CRFCMoney.TotalMoney)
from  UFIDA::U9::AR::ARPost::ARPostedDetail where  Org=@Org and  PayCust.Code = @Code and DocStatus in (2,3,4)";

            EntityDataQuery q = new EntityDataQuery("UFIDA.U9.AR.ARPost.ARPostedDetail");
            q.Parameters.Add(new UFSoft.UBF.PL.OqlParam("Code", code));
            q.Parameters.Add(new OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID));//组织

            DataSet ds = q.FindDataSet(oql);
            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0][0].ToString()))
            {
                return decimal.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else return 0;
        }
    }

    #endregion


}