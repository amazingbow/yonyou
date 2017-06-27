



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ReceivementSV {

	public partial class SrmRcvLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SrmRcvLineDTO(  UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO sRMRcvDTO  , System.Int64 iD  , System.Int32 lineNum  , System.String itemCode  , System.Decimal inQty  , System.Decimal price  )
		{
			this.SRMRcvDTO = sRMRcvDTO;
			this.ID = iD;
			this.LineNum = lineNum;
			this.ItemCode = itemCode;
			this.InQty = inQty;
			this.Price = price;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
