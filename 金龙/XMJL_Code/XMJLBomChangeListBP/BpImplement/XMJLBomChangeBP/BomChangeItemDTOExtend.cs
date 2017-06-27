



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class BomChangeItemDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomChangeItemDTO(  UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO bomChangeDTO  , System.Int64 item  , System.Int64 supplier  , System.String workPlace  , System.Decimal distQty  , System.String itemCode  , System.String itemName  )
		{
			this.BomChangeDTO = bomChangeDTO;
			this.Item = item;
			this.Supplier = supplier;
			this.WorkPlace = workPlace;
			this.DistQty = distQty;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
