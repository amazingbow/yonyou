



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.APBillSV {

	public partial class APBillHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public APBillHeadDTO(  System.String docTypeCode  , System.String vendorCode  , System.DateTime accrueDate  , System.DateTime invoiceDate  , System.String invoiceCode  , System.String currencyCode  , System.String memo  , System.Int32 businessType  )
		{
			this.DocTypeCode = docTypeCode;
			this.VendorCode = vendorCode;
			this.AccrueDate = accrueDate;
			this.InvoiceDate = invoiceDate;
			this.InvoiceCode = invoiceCode;
			this.CurrencyCode = currencyCode;
			this.Memo = memo;
			this.BusinessType = businessType;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
