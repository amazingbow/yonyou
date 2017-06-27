



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP {

	public partial class BomChangeCarDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BomChangeCarDTO(  UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO bomChangeDTO  , System.Int64 carID  , System.String carType  , System.String contractNo  , System.String carCode  , System.String carName  )
		{
			this.BomChangeDTO = bomChangeDTO;
			this.CarID = carID;
			this.CarType = carType;
			this.ContractNo = contractNo;
			this.CarCode = carCode;
			this.CarName = carName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
