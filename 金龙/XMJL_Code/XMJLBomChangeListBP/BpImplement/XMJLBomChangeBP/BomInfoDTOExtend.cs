



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class BomInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomInfoDTO(  System.Int64 carNoId  , System.String carNoCode  , System.String carNoName  , System.String contractNo  , System.String carType  )
		{
			this.CarNoId = carNoId;
			this.CarNoCode = carNoCode;
			this.CarNoName = carNoName;
			this.ContractNo = contractNo;
			this.CarType = carType;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
