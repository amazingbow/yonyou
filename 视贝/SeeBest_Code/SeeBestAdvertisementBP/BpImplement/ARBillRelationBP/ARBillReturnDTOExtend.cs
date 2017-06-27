



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP {

	public partial class ARBillReturnDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ARBillReturnDTO(  System.Boolean flag  , System.String message  , System.String docNo  , System.Int64 docID  )
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
