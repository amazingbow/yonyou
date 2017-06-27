



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UIFIA.U9.Cust.FJGX.RcvHeadQryBP {

	public partial class RcvHeadQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public RcvHeadQryDTO(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.String supplierCode  , System.String supplierName  , System.String supplierContactName  , System.Decimal totalMoney  , System.String createdBy  , System.String memo  , System.Decimal sumTotalMoney  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.SupplierCode = supplierCode;
			this.SupplierName = supplierName;
			this.SupplierContactName = supplierContactName;
			this.TotalMoney = totalMoney;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.SumTotalMoney = sumTotalMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
