





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查看报废信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LookScrapInfoBP
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public LookScrapInfoBP()
		{}
		
	    #endregion

	    #region member		
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTO> result =  (List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
