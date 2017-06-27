



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP {

	public partial class GLVoucherSecondQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public GLVoucherSecondQryDTO(  System.String companyName  , System.String aRDocNo  , System.DateTime createDate  , System.String createdBy  , System.String memo  , System.Decimal accountedDr  , System.Decimal accountedCr  , System.Int64 iD  , System.Decimal sumDr  )
		{
			this.CompanyName = companyName;
			this.ARDocNo = aRDocNo;
			this.CreateDate = createDate;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.AccountedDr = accountedDr;
			this.AccountedCr = accountedCr;
			this.ID = iD;
			this.SumDr = sumDr;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
