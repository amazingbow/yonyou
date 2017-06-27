



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.AchievementDetailQryBP {

	public partial class AchievementDetailQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public AchievementDetailQryDTO(  System.Int64 iD  , System.DateTime recDate  , System.String recDocNo  , System.String customerCode  , System.String customerName  , System.String operatorsCode  , System.String operatorsName  , System.Decimal recTotalMoney  )
		{
			this.ID = iD;
			this.RecDate = recDate;
			this.RecDocNo = recDocNo;
			this.CustomerCode = customerCode;
			this.CustomerName = customerName;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
			this.RecTotalMoney = recTotalMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
