





namespace UFIDA.U9.Cust.XMJL.SupplierSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取全部已核准供应商 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryAllVerifiedSupply
	{
	    #region Fields
		private System.DateTime synDateTime;
		
	    #endregion
		
	    #region constructor
		public QueryAllVerifiedSupply()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 最后同步时间	
		/// 获取全部已核准供应商.Misc.最后同步时间
		/// </summary>
		/// <value></value>
		public System.DateTime SynDateTime
		{
			get
			{
				return this.synDateTime;
			}
			set
			{
				synDateTime = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTO> result =  (List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
