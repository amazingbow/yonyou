



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SOSecondQryBP {

	public partial class SOSecondQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SOSecondQryDTO(  System.String docNo  , System.String customerName  , System.String enterpriseLegalPerson  , System.String saleserName  , System.Decimal totalMoney  , System.Int64 iD  , System.DateTime businessDate  )
		{
			this.DocNo = docNo;
			this.CustomerName = customerName;
			this.EnterpriseLegalPerson = enterpriseLegalPerson;
			this.SaleserName = saleserName;
			this.TotalMoney = totalMoney;
			this.ID = iD;
			this.BusinessDate = businessDate;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
