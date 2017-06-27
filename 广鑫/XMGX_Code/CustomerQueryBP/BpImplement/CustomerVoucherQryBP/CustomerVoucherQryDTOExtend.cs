



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP {

	public partial class CustomerVoucherQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CustomerVoucherQryDTO(  System.Int64 iD  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  , System.String customer_Name  , System.String docNo  , System.String docTypeName  , System.String createdBy  , System.String memo  , System.Decimal debitMoney  , System.Decimal creditMoney  , System.Decimal sumDebitMoney  , System.Decimal sumCreditMoney  , System.Decimal sumMoney  , System.DateTime businessDate  , System.Decimal balanceMoney  )
		{
			this.ID = iD;
			this.Customer = customer;
			this.Customer_Name = customer_Name;
			this.DocNo = docNo;
			this.DocTypeName = docTypeName;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.DebitMoney = debitMoney;
			this.CreditMoney = creditMoney;
			this.SumDebitMoney = sumDebitMoney;
			this.SumCreditMoney = sumCreditMoney;
			this.SumMoney = sumMoney;
			this.BusinessDate = businessDate;
			this.BalanceMoney = balanceMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
