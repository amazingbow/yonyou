



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ItemSV {

	public partial class ItemDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ItemDTO(  System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  , System.String uomShortName  , System.DateTime effectiveDate  , System.DateTime disableDate  , System.Double refrenceCost  )
		{
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
			this.UomShortName = uomShortName;
			this.EffectiveDate = effectiveDate;
			this.DisableDate = disableDate;
			this.RefrenceCost = refrenceCost;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
