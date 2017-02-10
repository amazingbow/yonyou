





namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class Operation
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public Operation()
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
