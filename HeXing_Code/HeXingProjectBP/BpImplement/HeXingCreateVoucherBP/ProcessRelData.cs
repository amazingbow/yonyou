





namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 扫描中间表先存关系对照表 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ProcessRelData
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public ProcessRelData()
		{}
		
	    #endregion

	    #region member		
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public void Do()
		{	
		    BaseStrategy selector = Select();	
				selector.Execute(this);
		    
		}			
	    #endregion 					
	} 		
}
