





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 关闭广告申请单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CloseAdvApply
	{
	    #region Fields
		private System.Int64 iD;
		
	    #endregion
		
	    #region constructor
		public CloseAdvApply()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// ID	
		/// 关闭广告申请单.Misc.ID
		/// </summary>
		/// <value></value>
		public System.Int64 ID
		{
			get
			{
				return this.iD;
			}
			set
			{
				iD = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
