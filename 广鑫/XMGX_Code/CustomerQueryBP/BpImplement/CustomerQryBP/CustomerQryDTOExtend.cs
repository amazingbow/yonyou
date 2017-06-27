



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerQryBP {

	public partial class CustomerQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CustomerQryDTO(  System.Int64 iD  , System.Int64 customer_ID  , System.String customer_Code  , System.String customer_Name  , UFIDA.U9.Base.Contact.Contact.EntityKey customerContact_Contact  , System.String customerContact_Contact_DefaultMobilNum  , System.String customerContact_Contact_DefaultPhoneNum  , UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey customer_CustomerCategory  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey customer_Saleser  , System.String customerContact_Contact_DefaultFaxNum  , System.Decimal aROCMoneyBalance_TotalMoney  , System.Decimal lastSOTotalMoneyTC  , System.Decimal lastRecBillTotalMoney  , System.String customer_StateTaxNo  , System.String customerBankAccount_Code  , System.String customer_Description  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum customer_TradeCurrency_MoneyRound_RoundType  , System.Int32 customer_TradeCurrency_MoneyRound_RoundValue  , System.String customer_Saleser_Name  , System.String customerContact_Contact_Name  , System.String customer_CustomerCategory_Name  , System.String customer_OfficialLocation_Name  , System.Int32 customer_TradeCurrency_MoneyRound_Precision  , System.Decimal objectCreditLevelApproval_CreditLimit  , System.Decimal sumBalanceTotalMoney  )
		{
			this.ID = iD;
			this.Customer_ID = customer_ID;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.CustomerContact_Contact = customerContact_Contact;
			this.CustomerContact_Contact_DefaultMobilNum = customerContact_Contact_DefaultMobilNum;
			this.CustomerContact_Contact_DefaultPhoneNum = customerContact_Contact_DefaultPhoneNum;
			this.Customer_CustomerCategory = customer_CustomerCategory;
			this.Customer_Saleser = customer_Saleser;
			this.CustomerContact_Contact_DefaultFaxNum = customerContact_Contact_DefaultFaxNum;
			this.AROCMoneyBalance_TotalMoney = aROCMoneyBalance_TotalMoney;
			this.LastSOTotalMoneyTC = lastSOTotalMoneyTC;
			this.LastRecBillTotalMoney = lastRecBillTotalMoney;
			this.Customer_StateTaxNo = customer_StateTaxNo;
			this.CustomerBankAccount_Code = customerBankAccount_Code;
			this.Customer_Description = customer_Description;
			this.Customer_TradeCurrency_MoneyRound_RoundType = customer_TradeCurrency_MoneyRound_RoundType;
			this.Customer_TradeCurrency_MoneyRound_RoundValue = customer_TradeCurrency_MoneyRound_RoundValue;
			this.Customer_Saleser_Name = customer_Saleser_Name;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.Customer_CustomerCategory_Name = customer_CustomerCategory_Name;
			this.Customer_OfficialLocation_Name = customer_OfficialLocation_Name;
			this.Customer_TradeCurrency_MoneyRound_Precision = customer_TradeCurrency_MoneyRound_Precision;
			this.ObjectCreditLevelApproval_CreditLimit = objectCreditLevelApproval_CreditLimit;
			this.SumBalanceTotalMoney = sumBalanceTotalMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
