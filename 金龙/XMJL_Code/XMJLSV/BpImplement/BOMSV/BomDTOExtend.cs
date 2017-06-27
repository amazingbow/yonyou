



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.BOMSV {

	public partial class BomDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomDTO(  System.String itemCode  , System.String itemName  , System.String vendorCode  , System.String vendorName  , System.Decimal qty  , System.String bomType  , UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO productBomDTO  )
		{
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.VendorCode = vendorCode;
			this.VendorName = vendorName;
			this.Qty = qty;
			this.BomType = bomType;
			this.ProductBomDTO = productBomDTO;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
