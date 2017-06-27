



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV {

	public partial class BillBalanceQueryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BillBalanceQueryDTO(  System.String vendorCode  , System.String cPersonCode  , System.Int32 year  , System.Int32 month  )
		{
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
			this.Year = year;
			this.Month = month;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
