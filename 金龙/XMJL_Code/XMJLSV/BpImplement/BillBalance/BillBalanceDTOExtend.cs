



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV {

	public partial class BillBalanceDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BillBalanceDTO(  System.DateTime accrueDate  , System.String voucherDisplayCode  , System.String abstracts  , System.String docType  , System.String docNo  , System.String aCName  , System.Decimal aPBillMoney  , System.Decimal payBillMoney  , System.Decimal balanceMoney  , System.String vendorCode  , System.String cPersonCode  )
		{
			this.AccrueDate = accrueDate;
			this.VoucherDisplayCode = voucherDisplayCode;
			this.Abstracts = abstracts;
			this.DocType = docType;
			this.DocNo = docNo;
			this.ACName = aCName;
			this.APBillMoney = aPBillMoney;
			this.PayBillMoney = payBillMoney;
			this.BalanceMoney = balanceMoney;
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
