





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取所有存储地点BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetAllWhBP
	{
	    #region Fields
		private System.Int64 org;
		
	    #endregion
		
	    #region constructor
		public GetAllWhBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 组织	
		/// 获取所有存储地点BP.Misc.组织
		/// </summary>
		/// <value></value>
		public System.Int64 Org
		{
			get
			{
				return this.org;
			}
			set
			{
				org = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTO> result =  (List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
