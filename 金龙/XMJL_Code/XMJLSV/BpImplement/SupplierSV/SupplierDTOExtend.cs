



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.SupplierSV {

	public partial class SupplierDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SupplierDTO(  System.String code  , System.String name  , System.String address  , UFIDA.U9.Base.Contact.Contact contacts  , System.String bankName  , System.String bankAccount  , System.String bankLineNo  , System.String taxNo  )
		{
			this.Code = code;
			this.Name = name;
			this.Address = address;
			this.Contacts = contacts;
			this.BankName = bankName;
			this.BankAccount = bankAccount;
			this.BankLineNo = bankLineNo;
			this.TaxNo = taxNo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
