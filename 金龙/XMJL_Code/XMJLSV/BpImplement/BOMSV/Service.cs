





namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class Service
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public Service()
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
