



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.APBillSV {

	public partial class APBillLineInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public APBillLineInfoDTO(  System.String itemCode  , System.Decimal moneyWithOutTax  , System.Decimal tax  )
		{
			this.ItemCode = itemCode;
			this.MoneyWithOutTax = moneyWithOutTax;
			this.Tax = tax;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
