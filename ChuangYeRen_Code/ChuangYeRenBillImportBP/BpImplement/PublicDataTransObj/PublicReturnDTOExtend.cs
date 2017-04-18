



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace PublicDataTransObj {

	public partial class PublicReturnDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PublicReturnDTO(  System.Boolean flag  , System.String message  , System.String docNo  , System.Int64 docID  )
		{
			this.Flag = flag;
			this.Message = message;
			this.DocNo = docNo;
			this.DocID = docID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
