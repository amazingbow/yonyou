



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV {

	public partial class SAPU9GLVoucherDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SAPU9GLVoucherDTO(  System.String companyCode  , System.String companyName  , System.String sAPVoucherDisplayCode  , System.String voucherCategoryCode  , System.String voucherCategoryDescription  , System.DateTime postDate  , System.Int64 postedPeriod  , System.String currencyCode  , System.String currencyDescription  , List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO> sAPU9GLVoucherLineDTOS  )
		{
			this.CompanyCode = companyCode;
			this.CompanyName = companyName;
			this.SAPVoucherDisplayCode = sAPVoucherDisplayCode;
			this.VoucherCategoryCode = voucherCategoryCode;
			this.VoucherCategoryDescription = voucherCategoryDescription;
			this.PostDate = postDate;
			this.PostedPeriod = postedPeriod;
			this.CurrencyCode = currencyCode;
			this.CurrencyDescription = currencyDescription;
			this.SAPU9GLVoucherLineDTOS = sAPU9GLVoucherLineDTOS;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
