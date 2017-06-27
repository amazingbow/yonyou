



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class ItemSupplyDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ItemSupplyDTO(  System.Int64 itemId  , System.Int64 supply  , System.String supplyCode  , System.String supplyName  )
		{
			this.ItemId = itemId;
			this.Supply = supply;
			this.SupplyCode = supplyCode;
			this.SupplyName = supplyName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
