



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.APBillSV {

	public partial class APBillLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public APBillLineDTO(  System.String deptCode  , System.String itemCode  , System.String itemName  , System.Double qty  , System.Double unitPrice  , System.Double totalMoney  , System.Boolean isIncludeTax  , System.String transactorCode  , System.String taxCode  , UFIDA.U9.PM.Rcv.Receivement receivement  )
		{
			this.DeptCode = deptCode;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Qty = qty;
			this.UnitPrice = unitPrice;
			this.TotalMoney = totalMoney;
			this.IsIncludeTax = isIncludeTax;
			this.TransactorCode = transactorCode;
			this.TaxCode = taxCode;
			this.Receivement = receivement;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
