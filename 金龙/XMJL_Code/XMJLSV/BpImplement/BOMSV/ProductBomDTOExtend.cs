



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.BOMSV {

	public partial class ProductBomDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ProductBomDTO(  System.String manufactureNo  , List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO> bom  )
		{
			this.ManufactureNo = manufactureNo;
			this.Bom = bom;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
