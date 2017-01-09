



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP {

	public partial class LaserLabBNChangeBPDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LaserLabBNChangeBPDTO(  List<System.String> lB  , List<System.String> bN  , List<System.String> cP  , List<System.DateTime> masterDT  )
		{
			this.LB = lB;
			this.BN = bN;
			this.CP = cP;
			this.MasterDT = masterDT;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
