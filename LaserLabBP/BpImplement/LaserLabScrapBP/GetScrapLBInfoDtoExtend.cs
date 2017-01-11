



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP {

	public partial class GetScrapLBInfoDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public GetScrapLBInfoDto(  System.String bN  , System.String type  , System.DateTime date  , System.DateTime time  , System.String cP  , System.String lB  )
		{
			this.BN = bN;
			this.Type = type;
			this.Date = date;
			this.Time = time;
			this.CP = cP;
			this.LB = lB;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
