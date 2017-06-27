



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.APBillSV {

	public partial class CommonResultDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CommonResultDTO(  System.Boolean success  , System.String message  , System.Object resultObj  )
		{
			this.Success = success;
			this.Message = message;
			this.ResultObj = resultObj;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
