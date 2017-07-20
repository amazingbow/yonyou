



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo {

	public partial class SpeciFicItemInfoDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SpeciFicItemInfoDto(  System.Int64 itemMaster  , System.String itemMaster_Code  , System.String itemMaster_Name  , System.Int64 wh  , System.String wh_Code  , System.String wh_Name  , System.Decimal reqPRQty  )
		{
			this.ItemMaster = itemMaster;
			this.ItemMaster_Code = itemMaster_Code;
			this.ItemMaster_Name = itemMaster_Name;
			this.Wh = wh;
			this.Wh_Code = wh_Code;
			this.Wh_Name = wh_Name;
			this.ReqPRQty = reqPRQty;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
