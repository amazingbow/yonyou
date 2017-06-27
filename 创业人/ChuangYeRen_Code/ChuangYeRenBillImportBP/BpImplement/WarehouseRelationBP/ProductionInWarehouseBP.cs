





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 成品入库操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ProductionInWarehouseBP
	{
	    #region Fields
		private System.Int64 relationId;
		private System.Int64 moId;
		
	    #endregion
		
	    #region constructor
		public ProductionInWarehouseBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// RelationId	
		/// 成品入库操作.Misc.RelationId
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
		/// MoId	
		/// 成品入库操作.Misc.MoId
		/// </summary>
		/// <value></value>
		public System.Int64 MoId
		{
			get
			{
				return this.moId;
			}
			set
			{
				moId = value;
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
