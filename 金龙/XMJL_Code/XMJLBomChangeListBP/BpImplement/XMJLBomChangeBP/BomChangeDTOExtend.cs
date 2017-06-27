



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class BomChangeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomChangeDTO(  List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeItemDTO> bomChangeItem  , List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeCarDTO> bomChangeCar  )
		{
			this.BomChangeItem = bomChangeItem;
			this.BomChangeCar = bomChangeCar;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
