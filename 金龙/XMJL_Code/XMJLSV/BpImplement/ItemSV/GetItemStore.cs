





namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询物料库存 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetItemStore
	{
	    #region Fields
		private System.Boolean isSum;
		private List<System.String> excludeWHCode;
		private System.String itemCode;
		
	    #endregion
		
	    #region constructor
		public GetItemStore()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 是否合并存储地点统计数量	
		/// 查询物料库存.Misc.是否合并存储地点统计数量
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
		/// 查询物料库存.Misc.不查询的储存地点
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
		/// <summary>
		/// 属性	
		/// 查询物料库存.Misc.属性
		/// </summary>
		/// <value></value>
		public System.String ItemCode
		{
			get
			{
				return this.itemCode;
			}
			set
			{
				itemCode = value;
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
