



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP {

	public partial class CustomerDocLineListQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CustomerDocLineListQryDTO(  System.Int64 iD  , System.DateTime businessDate  , System.String docNo  , System.String itemCode  , System.String itemName  , System.String sPECS  , System.Decimal mainSOQty  , System.String mainUOM_Name  , System.Decimal finallyPrice  , System.Decimal invSOQty  , System.String invUOM_Name  , System.Decimal totalMoney  , System.Decimal conversionRates  , System.String customer_Name  , System.Int32 docLineNo  , System.String operators_Name  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum mainUOM_Round_RoundType  , System.Int32 mainUOM_Round_RoundValue  , System.Int32 mainUOM_Round_Precision  , System.Int32 invUOM_Round_Precision  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum invUOM_Round_RoundType  , System.Int32 invUOM_Round_RoundValue  )
		{
			this.ID = iD;
			this.BusinessDate = businessDate;
			this.DocNo = docNo;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.SPECS = sPECS;
			this.MainSOQty = mainSOQty;
			this.MainUOM_Name = mainUOM_Name;
			this.FinallyPrice = finallyPrice;
			this.InvSOQty = invSOQty;
			this.InvUOM_Name = invUOM_Name;
			this.TotalMoney = totalMoney;
			this.ConversionRates = conversionRates;
			this.Customer_Name = customer_Name;
			this.DocLineNo = docLineNo;
			this.Operators_Name = operators_Name;
			this.MainUOM_Round_RoundType = mainUOM_Round_RoundType;
			this.MainUOM_Round_RoundValue = mainUOM_Round_RoundValue;
			this.MainUOM_Round_Precision = mainUOM_Round_Precision;
			this.InvUOM_Round_Precision = invUOM_Round_Precision;
			this.InvUOM_Round_RoundType = invUOM_Round_RoundType;
			this.InvUOM_Round_RoundValue = invUOM_Round_RoundValue;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
