



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ItemSV {

	public partial class ItemStoreDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ItemStoreDTO(  System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  , System.String uomShortName  , System.Decimal storeQty  , System.String wHCode  , System.String wHName  )
		{
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
			this.UomShortName = uomShortName;
			this.StoreQty = storeQty;
			this.WHCode = wHCode;
			this.WHName = wHName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
