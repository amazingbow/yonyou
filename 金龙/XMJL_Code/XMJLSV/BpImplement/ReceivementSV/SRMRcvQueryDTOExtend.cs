



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ReceivementSV {

	public partial class SRMRcvQueryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
        public SRMRcvQueryDTO(System.String vendorCode, System.String cPersonCode, System.String docNo, System.String type, System.DateTime inDateFrom, System.DateTime inDateTo)
		{
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
			this.DocNo = docNo;
			this.Type = type;
			this.InDateFrom = inDateFrom;
			this.InDateTo = inDateTo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
