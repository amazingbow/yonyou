namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using System.Data;
    using UFIDA.U9.AP.APBill;
    using UFIDA.U9.AP.Payment;
    using UFIDA.U9.AR.Receival;
    using UFIDA.U9.AP.APPost;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetBillBalance partial 
    /// </summary>	
    public partial class GetBillBalance
    {
        internal BaseStrategy Select()
        {
            return new GetBillBalanceImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetBillBalanceImpementStrategy : BaseStrategy
    {
        public GetBillBalanceImpementStrategy() { }

        public override object Do(object obj)
        {
            GetBillBalance bpObj = (GetBillBalance)obj;

            List<BillBalanceDTO> listResult = GetData(bpObj);

            #region old
            //int year = bpObj.BillBalanceQueryDTO.Year;
            //int month = bpObj.BillBalanceQueryDTO.Month;

            //string dateBegin = year + "0101";
            //string dateEnd = month == 12 ? year + 1 + "0101" : year + "" + (month + 1).ToString("D2") + "01";
            //OqlParam[] oqlParameters = new OqlParam[]
            //{
            //    new OqlParam(bpObj.BillBalanceQueryDTO.VendorCode)
            //    {
            //        ParamName = "VendorCode",
            //        Value = bpObj.BillBalanceQueryDTO.VendorCode,
            //        Type = DbType.String,
            //    },
            //    new OqlParam(bpObj.BillBalanceQueryDTO.CPersonCode)
            //    {
            //        ParamName = "CPersonCode",
            //        Value = bpObj.BillBalanceQueryDTO.CPersonCode,
            //        Type = DbType.String,
            //    },
            //    new OqlParam(dateBegin)
            //    {
            //        ParamName = "DateBegin",
            //        Value = dateBegin,
            //        Type = DbType.String,
            //    },
            //    new OqlParam(dateEnd)
            //    {
            //        ParamName = "DateEnd",
            //        Value = dateEnd,
            //        Type = DbType.String,
            //    },
            //};

            ////期初
            //string oql1 = "(DocStatus=2 or DocStatus=4) and IsPeriodBegin = 1 and IsSureAccrue=1 and AccrueSupp.Code=@VendorCode and Transactor.Code=@CPersonCode and AccrueDate>=@DateBegin and AccrueDate<@DateEnd";

            //APBillHead.EntityList list1 = APBillHead.Finder.FindAll(oql1, oqlParameters);
            //foreach (APBillHead bill in list1)
            //{
            //    BillBalanceDTO dto = new BillBalanceDTO();
            //    dto.AccrueDate = bill.AccrueDate;
            //    dto.VoucherDisplayCode = bill.VoucherNum;
            //    dto.Abstracts = bill.Memo;
            //    dto.DocType = bill.DocumentType.Name;
            //    dto.DocNo = bill.DocNo;
            //    dto.ACName = bill.AC.Name;
            //    dto.APBillMoney = 0;
            //    dto.PayBillMoney = 0;
            //    dto.BalanceMoney = bill.APFCMoney.TotalMoney;
            //    dto.VendorCode = bill.AccrueSupp.Code;
            //    dto.CPersonCode = bill.Transactor.Code;

            //    listResult.Add(dto);
            //}

            ////期中
            //string oql2 = "(DocStatus=2 or DocStatus=4) and IsSureAccrue=1 and IsPeriodBegin = 0 and AccrueSupp.Code=@VendorCode and Transactor.Code=@CPersonCode and AccrueDate>=@DateBegin and AccrueDate<@DateEnd";


            //APBillHead.EntityList list2 = APBillHead.Finder.FindAll(oql2, oqlParameters);
            //foreach (APBillHead bill in list2)
            //{
            //    BillBalanceDTO dto = new BillBalanceDTO();
            //    dto.AccrueDate = bill.AccrueDate;
            //    dto.VoucherDisplayCode = bill.VoucherNum;
            //    dto.Abstracts = bill.Memo;
            //    dto.DocType = bill.DocumentType.Name;
            //    dto.DocNo = bill.DocNo;
            //    dto.ACName = bill.AC.Name;
            //    dto.APBillMoney = bill.APFCMoney.TotalMoney;
            //    dto.PayBillMoney = 0;
            //    dto.BalanceMoney = listResult.Count == 0 ? 0 : listResult[listResult.Count - 1].BalanceMoney + dto.APBillMoney;//计算余额
            //    dto.VendorCode = bill.AccrueSupp.Code;
            //    dto.CPersonCode = bill.Transactor.Code;

            //    listResult.Add(dto);
            //}


            ////付款单
            //string oql3 = " (DocStatus=2 or DocStatus=4) and Supp.Code=@VendorCode and Transactor.Code=@CPersonCode and PayDate>=@DateBegin and PayDate<@DateEnd";

            //PayBillHead.EntityList list3 = PayBillHead.Finder.FindAll(oql3, oqlParameters);
            //foreach (PayBillHead bill in list3)
            //{
            //    BillBalanceDTO dto = new BillBalanceDTO();
            //    dto.AccrueDate = bill.PayDate;
            //    dto.VoucherDisplayCode = bill.VoucherNum;
            //    dto.Abstracts = bill.Memo;
            //    dto.DocType = bill.DocumentType.Name;
            //    dto.DocNo = bill.DocNo;
            //    dto.ACName = bill.PC.Name;
            //    dto.APBillMoney = 0;
            //    dto.PayBillMoney = bill.TotalMoney.OCMoney;
            //    dto.BalanceMoney = listResult.Count == 0 ? 0 : listResult[listResult.Count - 1].BalanceMoney - dto.PayBillMoney;//计算余额
            //    dto.VendorCode = bill.Supp.Code;
            //    dto.CPersonCode = bill.Transactor.Code;

            //    listResult.Add(dto);
            //}

            ////收款单
            //string oql4 = " (DocStatus=2 or DocStatus = 4) and Supp.Code=@VendorCode and Transactor.Code=@CPersonCode and RecDate>=@DateBegin and RecDate<@DateEnd";

            //RecBillHead.EntityList list4 = RecBillHead.Finder.FindAll(oql4, oqlParameters);

            //foreach (RecBillHead bill in list4)
            //{
            //    BillBalanceDTO dto = new BillBalanceDTO();
            //    dto.AccrueDate = bill.RecDate;
            //    dto.VoucherDisplayCode = bill.VoucherNum;
            //    dto.Abstracts = bill.Note;
            //    dto.DocType = bill.DocumentType.Name;
            //    dto.DocNo = bill.DocNo;
            //    dto.ACName = bill.RC.Name;
            //    dto.APBillMoney = 0;
            //    dto.PayBillMoney = 0 - bill.TotalMoney.OCMoney;
            //    dto.BalanceMoney = listResult.Count == 0 ? 0 : listResult[listResult.Count - 1].BalanceMoney - dto.PayBillMoney;//计算余额
            //    dto.VendorCode = bill.Supp.Code;
            //    dto.CPersonCode = bill.Transactor.Code;

            //    listResult.Add(dto);
            //}
            #endregion

            return listResult;
        }
        private List<BillBalanceDTO> GetData(GetBillBalance bpObj)
        {
            int year = bpObj.BillBalanceQueryDTO.Year;
            int month = bpObj.BillBalanceQueryDTO.Month;

            string dateBegin = year + "0101";
            string dateEnd = month == 12 ? year + 1 + "0101" : year + "" + (month + 1).ToString("D2") + "01";

            string oql = @"select A.BillDate AccrueDate,BillNum VID,PaySupp.Code CDWCode,PaySupp.Name CDWName,IsSureAccrue,
Transactor.Code CPersonCode,Transactor.Name CPersonName,VoucherNum CPZNum,GetEnumName('UFIDA.U9.Base.Doc.BusinessTypeEnum',BusinessType) VType,BC.Name ExchName,Max(Digest) Digest,
case BillDirect when 1 then 0-sum(DRFCMoney.TotalMoney) else sum(CRFCMoney.TotalMoney) end as JF,
case BillDirect when 1 then 0-SUM(CRFCMoney.TotalMoney) else sum(DRFCMoney.TotalMoney) end as DF
from UFIDA::U9::AP::APPost::APPostedDetail A
left join UFIDA::U9::AP::APBill::APBillHead B on A.BillNum=B.DocNo 
where Org=@Org and DocStatus in (2,3,4) and IsSureAccrue=1 and BillDate>=@DateBegin and BillDate<@DateEnd";

            EntityDataQuery q = new EntityDataQuery("UFIDA.U9.AP.APPost.APPostedDetail");
            q.Parameters.Add(new OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID));
            q.Parameters.Add(new OqlParam("DateBegin", dateBegin));
            q.Parameters.Add(new OqlParam("DateEnd", dateEnd));

            if (!string.IsNullOrEmpty(bpObj.BillBalanceQueryDTO.VendorCode))
            {
                oql += " and PaySupp.Code=@VendorCode ";
                q.Parameters.Add(new OqlParam("VendorCode", bpObj.BillBalanceQueryDTO.VendorCode));
            }

            if (!string.IsNullOrEmpty(bpObj.BillBalanceQueryDTO.CPersonCode))
            {
                oql += "  and Transactor.Code=@CPersonCode ";
                q.Parameters.Add(new OqlParam("CPersonCode", bpObj.BillBalanceQueryDTO.CPersonCode));
            }

            oql += @"
and  (OperationType not in (0, 1, 8, 9, 10) or OperationType is null)
group by 
BillDirect,BillDate,BillNum,PaySupp.Code,PaySupp.Name,Transactor.Code,Transactor.Name,VoucherNum,BusinessType,BC.Name,IsSureAccrue
order by PaySupp.Code desc,BillDate";

            DataSet ds = q.FindDataSet(oql);

            List<BillBalanceDTO> listResult = new List<BillBalanceDTO>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BillBalanceDTO dto = new BillBalanceDTO();
                dto.AccrueDate = DateTime.Parse(dr["AccrueDate"].ToString());
                dto.VoucherDisplayCode = dr["CPZNum"].ToString();
                dto.Abstracts = dr["Digest"].ToString();
                dto.DocType = dr["VType"].ToString();
                dto.DocNo = dr["VID"].ToString();
                dto.ACName = dr["ExchName"].ToString();
                dto.APBillMoney = decimal.Parse(dr["JF"].ToString());
                dto.PayBillMoney = decimal.Parse(dr["DF"].ToString());
                dto.BalanceMoney = listResult.Count == 0 ? dto.APBillMoney - dto.PayBillMoney : listResult[listResult.Count - 1].BalanceMoney + dto.APBillMoney - dto.PayBillMoney;//计算余额
                dto.VendorCode = dr["CDWCode"].ToString();
                dto.CPersonCode = dr["CPersonCode"].ToString();

                listResult.Add(dto);
            }

            return listResult;
        }
    }

    #endregion


}