



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP {

	public partial class SupplierDocLineListQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SupplierDocLineListQryDTO(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.String itemCode  , System.String itemName  , System.String sPECS  , System.Decimal packageNum  , System.Decimal qtyTU  , System.String tradeUOMName  , System.Decimal pieceOrMeterQty  , System.String assistUOMName  , System.Decimal finallyPriceTC  , System.Decimal arriveTotalMnyTC  , System.String createdBy  , System.Int32 docLineNo  , System.String memo  , System.Int32 rcvLine_TradeUOM_Round_Precision  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum rcvLine_TradeUOM_Round_RoundType  , System.Int32 rcvLine_TradeUOM_Round_RoundValue  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.SPECS = sPECS;
			this.PackageNum = packageNum;
			this.QtyTU = qtyTU;
			this.TradeUOMName = tradeUOMName;
			this.PieceOrMeterQty = pieceOrMeterQty;
			this.AssistUOMName = assistUOMName;
			this.FinallyPriceTC = finallyPriceTC;
			this.ArriveTotalMnyTC = arriveTotalMnyTC;
			this.CreatedBy = createdBy;
			this.DocLineNo = docLineNo;
			this.Memo = memo;
			this.RcvLine_TradeUOM_Round_Precision = rcvLine_TradeUOM_Round_Precision;
			this.RcvLine_TradeUOM_Round_RoundType = rcvLine_TradeUOM_Round_RoundType;
			this.RcvLine_TradeUOM_Round_RoundValue = rcvLine_TradeUOM_Round_RoundValue;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
