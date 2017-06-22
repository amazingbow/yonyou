



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP {

	public partial class ApplyInfoDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ApplyInfoDto(  System.String location  , System.String advAppCustName  , System.String country  , System.String custCounterName  , System.String relPeople  , System.String relPhone  , System.String custAddress  , System.Decimal width  , System.Decimal thick  , System.Decimal height  , System.String applyAdvCode  , System.String advCarrier  , System.String advItem  )
		{
			this.Location = location;
			this.AdvAppCustName = advAppCustName;
			this.Country = country;
			this.CustCounterName = custCounterName;
			this.RelPeople = relPeople;
			this.RelPhone = relPhone;
			this.CustAddress = custAddress;
			this.Width = width;
			this.Thick = thick;
			this.Height = height;
			this.ApplyAdvCode = applyAdvCode;
			this.AdvCarrier = advCarrier;
			this.AdvItem = advItem;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
