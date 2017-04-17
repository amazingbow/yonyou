





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 生产订单删除处理 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ProductionOrderDeleteProcessBP
	{
	    #region Fields
		private System.Int64 relationId;
		
	    #endregion
		
	    #region constructor
		public ProductionOrderDeleteProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关表ID	
		/// 生产订单删除处理.Misc.相关表ID
		/// </summary>
		/// <value></value>
		public System.Int64 RelationId
		{
			get
			{
				return this.relationId;
			}
			set
			{
				relationId = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public void Do()
		{	
		    BaseStrategy selector = Select();	
				selector.Execute(this);
		    
		}			
	    #endregion 					
	} 		
}
