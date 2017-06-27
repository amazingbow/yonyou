



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerQucikQryBP {

	public partial class CustomerQucikQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CustomerQucikQryDTO(  System.Int64 customer_ID  , System.String customer_Code  , System.String customer_Name  , System.String enterpriseLegalPerson  , System.String mobileNo  , System.String phoneNo  , UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey customer_CustomerCategory  , System.String fax  , System.Decimal actualAPMoney  , System.Decimal creditMoney  , System.Decimal lastTransMoney  , System.Decimal lastRecMoney  , System.String taxNo  , System.String bankName  , System.String memo  , System.String address  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey customer_Saleser  , System.String customerCategoryName  , System.String saleserName  )
		{
			this.Customer_ID = customer_ID;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.EnterpriseLegalPerson = enterpriseLegalPerson;
			this.MobileNo = mobileNo;
			this.PhoneNo = phoneNo;
			this.Customer_CustomerCategory = customer_CustomerCategory;
			this.Fax = fax;
			this.ActualAPMoney = actualAPMoney;
			this.CreditMoney = creditMoney;
			this.LastTransMoney = lastTransMoney;
			this.LastRecMoney = lastRecMoney;
			this.TaxNo = taxNo;
			this.BankName = bankName;
			this.Memo = memo;
			this.Address = address;
			this.Customer_Saleser = customer_Saleser;
			this.CustomerCategoryName = customerCategoryName;
			this.SaleserName = saleserName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
