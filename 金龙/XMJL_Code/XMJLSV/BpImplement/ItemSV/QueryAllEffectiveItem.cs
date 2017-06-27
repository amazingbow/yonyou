





namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取所有在用的料品 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryAllEffectiveItem
	{
	    #region Fields
		private System.DateTime synDateTime;
		
	    #endregion
		
	    #region constructor
		public QueryAllEffectiveItem()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 最后同步时间	
		/// 获取所有在用的料品.Misc.最后同步时间
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
		public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTO> result =  (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
