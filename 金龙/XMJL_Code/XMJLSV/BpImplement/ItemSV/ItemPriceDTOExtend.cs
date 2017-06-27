



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ItemSV {

	public partial class ItemPriceDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ItemPriceDTO(  System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  , System.String uomShortName  , System.Decimal price  )
		{
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
			this.UomShortName = uomShortName;
			this.Price = price;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
