



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerDocListQryBP {

	public partial class CustomerDocListQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CustomerDocListQryDTO(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  , System.String customer_Name  , UFIDA.U9.CBO.SCM.Customer.CustomerContact.EntityKey customerContact  , System.String customerContact_Contact_Name  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey operators  , System.String operators_Name  , System.Decimal totalMoney  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.Customer = customer;
			this.Customer_Name = customer_Name;
			this.CustomerContact = customerContact;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.Operators = operators;
			this.Operators_Name = operators_Name;
			this.TotalMoney = totalMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
