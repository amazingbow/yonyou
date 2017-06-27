



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP {

	public partial class LookScrapInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public LookScrapInfoDTO(  System.String lB  , System.String cP  , System.String bN  , System.String tYPE  , System.DateTime scrapDT  )
		{
			this.LB = lB;
			this.CP = cP;
			this.BN = bN;
			this.TYPE = tYPE;
			this.ScrapDT = scrapDT;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
