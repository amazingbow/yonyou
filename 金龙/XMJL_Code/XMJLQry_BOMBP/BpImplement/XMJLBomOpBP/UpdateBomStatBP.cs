





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 更新缺件行状态 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpdateBomStatBP
	{
	    #region Fields
		private System.String oPath;
		
	    #endregion
		
	    #region constructor
		public UpdateBomStatBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// OQL查询条件	
		/// 更新缺件行状态.Misc.OQL查询条件
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
