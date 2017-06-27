





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 更新缺件仓库 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpdateBomWhBP
	{
	    #region Fields
		private System.Int64 wareHouse;
		private System.String oPath;
		
	    #endregion
		
	    #region constructor
		public UpdateBomWhBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 仓库ID	
		/// 更新缺件仓库.Misc.仓库ID
		/// </summary>
		/// <value></value>
		public System.Int64 WareHouse
		{
			get
			{
				return this.wareHouse;
			}
			set
			{
				wareHouse = value;
			}
		}
		/// <summary>
		/// OQL查询条件	
		/// 更新缺件仓库.Misc.OQL查询条件
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
