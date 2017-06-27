





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改广告申请单状态 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModifyAdvApplyStatusBP
	{
	    #region Fields
		private System.Int64 iD;
		private System.Int64 sysVersion;
		
	    #endregion
		
	    #region constructor
		public ModifyAdvApplyStatusBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// ID	
		/// 修改广告申请单状态.Misc.ID
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
		/// <summary>
		/// 事务版本	
		/// 修改广告申请单状态.Misc.事务版本
		/// </summary>
		/// <value></value>
		public System.Int64 SysVersion
		{
			get
			{
				return this.sysVersion;
			}
			set
			{
				sysVersion = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
