



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj {

	public partial class RCVLineInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public RCVLineInfoDTO(  System.Int64 rCVLine  , System.Decimal amount  , System.Decimal totalMoney  , System.Decimal tax  )
		{
			this.RCVLine = rCVLine;
			this.Amount = amount;
			this.TotalMoney = totalMoney;
			this.Tax = tax;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
