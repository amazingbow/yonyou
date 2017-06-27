





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获得LB信息操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ScarpGetLBInfoBP
	{
	    #region Fields
		private System.String lB;
		
	    #endregion
		
	    #region constructor
		public ScarpGetLBInfoBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// LB编码	
		/// 获得LB信息操作.Misc.LB编码
		/// </summary>
		/// <value></value>
		public System.String LB
		{
			get
			{
				return this.lB;
			}
			set
			{
				lB = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDto Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDto result =  (UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDto)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
