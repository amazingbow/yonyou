





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 生产领料操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class RcvProductionIssueProcessBP
	{
	    #region Fields
		private System.Int64 relationId;
		private System.Int64 productionId;
		
	    #endregion
		
	    #region constructor
		public RcvProductionIssueProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关表ID	
		/// 生产领料操作.Misc.相关表ID
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
		/// <summary>
		/// 生产订单ID	
		/// 生产领料操作.Misc.生产订单ID
		/// </summary>
		/// <value></value>
		public System.Int64 ProductionId
		{
			get
			{
				return this.productionId;
			}
			set
			{
				productionId = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public PublicDataTransObj.PublicReturnDTO Do()
		{	
		    BaseStrategy selector = Select();	
				PublicDataTransObj.PublicReturnDTO result =  (PublicDataTransObj.PublicReturnDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
