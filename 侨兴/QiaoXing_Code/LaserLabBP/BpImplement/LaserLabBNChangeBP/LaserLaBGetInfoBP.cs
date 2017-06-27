





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// GetLB信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LaserLaBGetInfoBP
	{
	    #region Fields
		private System.String bN;
		private System.String type;
		
	    #endregion
		
	    #region constructor
		public LaserLaBGetInfoBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 批次号	
		/// GetLB信息.Misc.批次号
		/// </summary>
		/// <value></value>
		public System.String BN
		{
			get
			{
				return this.bN;
			}
			set
			{
				bN = value;
			}
		}
		/// <summary>
		/// 型号	
		/// GetLB信息.Misc.型号
		/// </summary>
		/// <value></value>
		public System.String Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTO> result =  (List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
