





namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取所有的物料库存 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryAllItemStore
	{
	    #region Fields
		private System.Boolean isSum;
		private List<System.String> excludeWHCode;
		
	    #endregion
		
	    #region constructor
		public QueryAllItemStore()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 是否合并存储地点统计数量	
		/// 获取所有的物料库存.Misc.是否合并存储地点统计数量
		/// </summary>
		/// <value></value>
		public System.Boolean IsSum
		{
			get
			{
				return this.isSum;
			}
			set
			{
				isSum = value;
			}
		}
		/// <summary>
		/// 不查询的储存地点	
		/// 获取所有的物料库存.Misc.不查询的储存地点
		/// </summary>
		/// <value></value>
		public List<System.String> ExcludeWHCode
		{
			get
			{
				return this.excludeWHCode;
			}
			set
			{
				excludeWHCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTO> result =  (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
