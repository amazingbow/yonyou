





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 成品出库操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ProductionOutWarehouseBP
	{
	    #region Fields
		private System.Int64 relationId;
		
	    #endregion
		
	    #region constructor
		public ProductionOutWarehouseBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关ID	
		/// 成品出库操作.Misc.相关ID
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
		public PublicDataTransObj.PublicReturnDTO Do()
		{	
		    BaseStrategy selector = Select();	
				PublicDataTransObj.PublicReturnDTO result =  (PublicDataTransObj.PublicReturnDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
