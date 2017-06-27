





namespace UFIDA.U9.Cust.XM.TGBP.TaecoUnBusiInterface
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 读中间表创建凭证 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateVoucherByTableBP
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public CreateVoucherByTableBP()
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
