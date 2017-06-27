



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP {

	public partial class SOHeadInfoQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
        public SOHeadInfoQryDTO(System.Int64 iD, System.String sO_DocNo, System.DateTime sO_BusinessDate, System.String customer_Code, System.String customer_Name, System.String customerContact_Contact_Name, UFIDA.U9.CBO.HR.Operator.Operators.EntityKey sO_Seller, System.String sO_Seller_Code, System.String sO_Seller_Name, UFIDA.U9.CBO.HR.Department.Department.EntityKey sO_SaleDepartment, System.String sO_SaleDepartment_Code, System.String sO_SaleDepartment_Name, System.Int64 sO_ID, System.Decimal sO_TotalMoneyAC, System.String customerContact_Contact_DefaultPhoneNum, System.String customerContact_Contact_DefaultMobilNum, UFIDA.U9.Base.Contact.Contact.EntityKey customerContact_Contact, System.Decimal sumTotalMoney, System.Decimal totalShipMoney)
		{
			this.ID = iD;
			this.SO_DocNo = sO_DocNo;
			this.SO_BusinessDate = sO_BusinessDate;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.SO_Seller = sO_Seller;
			this.SO_Seller_Code = sO_Seller_Code;
			this.SO_Seller_Name = sO_Seller_Name;
			this.SO_SaleDepartment = sO_SaleDepartment;
			this.SO_SaleDepartment_Code = sO_SaleDepartment_Code;
			this.SO_SaleDepartment_Name = sO_SaleDepartment_Name;
			this.SO_ID = sO_ID;
			this.SO_TotalMoneyAC = sO_TotalMoneyAC;
			this.CustomerContact_Contact_DefaultPhoneNum = customerContact_Contact_DefaultPhoneNum;
			this.CustomerContact_Contact_DefaultMobilNum = customerContact_Contact_DefaultMobilNum;
			this.CustomerContact_Contact = customerContact_Contact;
			this.SumTotalMoney = sumTotalMoney;
			this.TotalShipMoney = totalShipMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
