



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SupplierQryBP {

	public partial class SupplierQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SupplierQryDTO(  System.Int64 iD  , System.String supplier_Code  , System.String supplier_Name  , UFIDA.U9.Base.Contact.Contact.EntityKey supplierContact_Contact  , System.String supplierContact_Contact_Name  , System.String supplierContact_Contact_DefaultMobilNum  , UFIDA.U9.CBO.SCM.Supplier.SupplierCategory.EntityKey supplier_Category  , System.String supplier_Category_Name  , System.String supplierContact_Contact_DefaultFaxNum  , System.Decimal aPTotalMoney  , System.String supplier_StateTaxNo  , System.String supplierBankAccount_Name  , System.String supplier_OfficialLocation_Name  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey supplier_Purchaser  , System.String supplier_Purchaser_Name  , System.String supplier_Description  , System.Int64 supplier_ID  , System.String supplierContact_Contact_DefaultPhoneNum  , System.Decimal sumAPTotalMoney  )
		{
			this.ID = iD;
			this.Supplier_Code = supplier_Code;
			this.Supplier_Name = supplier_Name;
			this.SupplierContact_Contact = supplierContact_Contact;
			this.SupplierContact_Contact_Name = supplierContact_Contact_Name;
			this.SupplierContact_Contact_DefaultMobilNum = supplierContact_Contact_DefaultMobilNum;
			this.Supplier_Category = supplier_Category;
			this.Supplier_Category_Name = supplier_Category_Name;
			this.SupplierContact_Contact_DefaultFaxNum = supplierContact_Contact_DefaultFaxNum;
			this.APTotalMoney = aPTotalMoney;
			this.Supplier_StateTaxNo = supplier_StateTaxNo;
			this.SupplierBankAccount_Name = supplierBankAccount_Name;
			this.Supplier_OfficialLocation_Name = supplier_OfficialLocation_Name;
			this.Supplier_Purchaser = supplier_Purchaser;
			this.Supplier_Purchaser_Name = supplier_Purchaser_Name;
			this.Supplier_Description = supplier_Description;
			this.Supplier_ID = supplier_ID;
			this.SupplierContact_Contact_DefaultPhoneNum = supplierContact_Contact_DefaultPhoneNum;
			this.SumAPTotalMoney = sumAPTotalMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
