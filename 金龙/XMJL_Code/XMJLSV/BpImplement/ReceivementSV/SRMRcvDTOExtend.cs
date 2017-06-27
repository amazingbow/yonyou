



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.XMJL.ReceivementSV {

	public partial class SRMRcvDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SRMRcvDTO(  System.Int64 iD  , System.String docNo  , System.String sTNO  , System.String type  , System.String status  , System.String inType  , System.String cPersonCode  , System.DateTime inDate  , System.String cMaker  , System.String wareHouser  , System.String vendorCode  , List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO> srmRcvLine  )
		{
			this.ID = iD;
			this.DocNo = docNo;
			this.STNO = sTNO;
			this.Type = type;
			this.Status = status;
			this.InType = inType;
			this.CPersonCode = cPersonCode;
			this.InDate = inDate;
			this.CMaker = cMaker;
			this.WareHouser = wareHouser;
			this.VendorCode = vendorCode;
			this.SrmRcvLine = srmRcvLine;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
