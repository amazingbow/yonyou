





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 恢复默认仓库 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ResetBomWhBP
	{
	    #region Fields
		private System.String oPath;
		
	    #endregion
		
	    #region constructor
		public ResetBomWhBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// OQL查询条件	
		/// 恢复默认仓库.Misc.OQL查询条件
		/// </summary>
		/// <value></value>
		public System.String OPath
		{
			get
			{
				return this.oPath;
			}
			set
			{
				oPath = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTO result =  (UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
