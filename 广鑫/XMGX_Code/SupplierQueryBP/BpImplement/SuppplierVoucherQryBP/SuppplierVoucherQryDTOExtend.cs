



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP {

	public partial class SuppplierVoucherQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SuppplierVoucherQryDTO(  System.Int64 iD  , System.String docNo  , System.String docTypeName  , System.String supplierName  , System.DateTime businessDate  , System.String createdBy  , System.Decimal debitMoney  , System.Decimal creditMoney  , System.Decimal sumDebitMoney  , System.Decimal sumCreditMoney  , System.Decimal sumMoney  , System.Decimal balanceMoney  , System.String memo  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.DocTypeName = docTypeName;
			this.SupplierName = supplierName;
			this.BusinessDate = businessDate;
			this.CreatedBy = createdBy;
			this.DebitMoney = debitMoney;
			this.CreditMoney = creditMoney;
			this.SumDebitMoney = sumDebitMoney;
			this.SumCreditMoney = sumCreditMoney;
			this.SumMoney = sumMoney;
			this.BalanceMoney = balanceMoney;
			this.Memo = memo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
