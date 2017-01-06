



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP {

	public partial class LabBNInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LabBNInfoDTO(  System.String lB  , System.String bN  , System.String cP  , System.DateTime masterDT  )
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
