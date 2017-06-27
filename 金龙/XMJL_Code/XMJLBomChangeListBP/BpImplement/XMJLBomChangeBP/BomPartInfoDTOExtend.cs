



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class BomPartInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomPartInfoDTO(  System.Int64 item  , System.String itemCode  , System.String itemName  , System.Int64 supplier  , System.String supplierCode  , System.String supplierName  , System.String workPlace  , System.Decimal qty  )
		{
			this.Item = item;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Supplier = supplier;
			this.SupplierCode = supplierCode;
			this.SupplierName = supplierName;
			this.WorkPlace = workPlace;
			this.Qty = qty;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
