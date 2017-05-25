





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 备料表导入接口 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class PickListImportBP
	{
	    #region Fields
		private System.Int64 relationId;
		private System.Int64 productionId;
		
	    #endregion
		
	    #region constructor
		public PickListImportBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关表ID	
		/// 备料表导入接口.Misc.相关表ID
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
		/// 备料表导入接口.Misc.生产订单ID
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
