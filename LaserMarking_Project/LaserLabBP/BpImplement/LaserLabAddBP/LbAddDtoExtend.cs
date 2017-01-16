



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP {

	public partial class LbAddDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LbAddDto(  System.String bN  , System.String lB  , System.String type  , System.DateTime masterDT  , System.String customer  )
		{
			this.BN = bN;
			this.LB = lB;
			this.Type = type;
			this.MasterDT = masterDT;
			this.Customer = customer;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
