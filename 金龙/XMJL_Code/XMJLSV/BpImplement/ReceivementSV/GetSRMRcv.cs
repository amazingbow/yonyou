





namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 入库单查询 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetSRMRcv
	{
	    #region Fields
		private UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTO sRMRcvQueryDTO;
		
	    #endregion
		
	    #region constructor
		public GetSRMRcv()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// SRM入库单查询条件	
		/// 入库单查询.Misc.SRM入库单查询条件
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTO SRMRcvQueryDTO
		{
			get
			{
				return this.sRMRcvQueryDTO;
			}
			set
			{
				sRMRcvQueryDTO = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO> result =  (List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
