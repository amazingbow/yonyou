



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJLBomOpBP {

	public partial class BOMMainInfoDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BOMMainInfoDto(  System.Int64 manufactureNo  , System.String contractNo  , System.String carType  , System.String manufactureNo_Code  , System.String manufactureNo_Name  , System.Int32 no  )
		{
			this.ManufactureNo = manufactureNo;
			this.ContractNo = contractNo;
			this.CarType = carType;
			this.ManufactureNo_Code = manufactureNo_Code;
			this.ManufactureNo_Name = manufactureNo_Name;
			this.No = no;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
