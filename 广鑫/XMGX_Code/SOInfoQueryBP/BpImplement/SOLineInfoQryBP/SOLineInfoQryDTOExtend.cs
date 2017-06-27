



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SOLineInfoQryBP {

	public partial class SOLineInfoQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SOLineInfoQryDTO(  System.Int64 iD  , System.Int64 sOLine_ID  , System.String sOLine_ItemInfo_ItemCode  , System.String sOLine_ItemInfo_ItemName  , System.String sOLine_ItemInfo_ItemID_SPECS  , System.String sOLine_PU_Name  , System.String sOLine_CU_Name  , System.Decimal sOLine_FinallyPriceTC  , System.String sOLine_Memo  , System.Decimal sOLine_OrderByQtyTU  , System.Int32 sOLine_DocLineNo  , System.Decimal sOLine_TotalMoneyTC  , System.String sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5  , System.Int32 sOLine_TU_Round_Precision  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum sOLine_TU_Round_RoundType  , System.Int32 sOLine_TU_Round_RoundValue  , System.Decimal totalShipQty  , System.Decimal totalShipMoney  )
		{
			this.ID = iD;
			this.SOLine_ID = sOLine_ID;
			this.SOLine_ItemInfo_ItemCode = sOLine_ItemInfo_ItemCode;
			this.SOLine_ItemInfo_ItemName = sOLine_ItemInfo_ItemName;
			this.SOLine_ItemInfo_ItemID_SPECS = sOLine_ItemInfo_ItemID_SPECS;
			this.SOLine_PU_Name = sOLine_PU_Name;
			this.SOLine_CU_Name = sOLine_CU_Name;
			this.SOLine_FinallyPriceTC = sOLine_FinallyPriceTC;
			this.SOLine_Memo = sOLine_Memo;
			this.SOLine_OrderByQtyTU = sOLine_OrderByQtyTU;
			this.SOLine_DocLineNo = sOLine_DocLineNo;
			this.SOLine_TotalMoneyTC = sOLine_TotalMoneyTC;
			this.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5;
			this.SOLine_TU_Round_Precision = sOLine_TU_Round_Precision;
			this.SOLine_TU_Round_RoundType = sOLine_TU_Round_RoundType;
			this.SOLine_TU_Round_RoundValue = sOLine_TU_Round_RoundValue;
			this.TotalShipQty = totalShipQty;
			this.TotalShipMoney = totalShipMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
