





namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// SAP凭证导入U9凭证 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateVoucherfromSAP
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public CreateVoucherfromSAP()
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
