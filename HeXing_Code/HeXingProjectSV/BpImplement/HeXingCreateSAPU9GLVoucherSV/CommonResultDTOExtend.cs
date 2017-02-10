



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV {

	public partial class CommonResultDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CommonResultDTO(  System.Boolean isSuccess  , System.String message  , System.Object resultObj  )
		{
			this.IsSuccess = isSuccess;
			this.Message = message;
			this.ResultObj = resultObj;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
