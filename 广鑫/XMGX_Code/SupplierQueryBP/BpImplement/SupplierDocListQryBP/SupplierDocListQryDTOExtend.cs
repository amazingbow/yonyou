



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.SupplierDocListQryBP {

	public partial class SupplierDocListQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SupplierDocListQryDTO(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.Decimal sumUnPayedMnyTC  , System.String createdBy  , System.String operatorsName  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.SumUnPayedMnyTC = sumUnPayedMnyTC;
			this.CreatedBy = createdBy;
			this.OperatorsName = operatorsName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
