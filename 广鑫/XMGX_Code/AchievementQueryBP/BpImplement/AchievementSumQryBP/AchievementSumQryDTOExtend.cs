



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.AchievementSumQryBP {

	public partial class AchievementSumQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public AchievementSumQryDTO(  System.Int64 iD  , System.String operatorsCode  , System.String operatorsName  , System.Decimal recTotalMoney  , System.Decimal aRTotalMoney  , System.Decimal backMoneyRatio  , System.Decimal sumRecTotalMoney  , System.Decimal sumARTotalMoney  , System.DateTime businessDate  )
		{
			this.ID = iD;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
			this.RecTotalMoney = recTotalMoney;
			this.ARTotalMoney = aRTotalMoney;
			this.BackMoneyRatio = backMoneyRatio;
			this.SumRecTotalMoney = sumRecTotalMoney;
			this.SumARTotalMoney = sumARTotalMoney;
			this.BusinessDate = businessDate;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
