





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 杂收操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class MiscTranInProcessBP
	{
	    #region Fields
		private System.Int64 relationID;
		private System.Int64 productionID;
		
	    #endregion
		
	    #region constructor
		public MiscTranInProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关ID	
		/// 杂收操作.Misc.相关ID
		/// </summary>
		/// <value></value>
		public System.Int64 RelationID
		{
			get
			{
				return this.relationID;
			}
			set
			{
				relationID = value;
			}
		}
		/// <summary>
		/// U9生产订单ID	
		/// 杂收操作.Misc.U9生产订单ID
		/// </summary>
		/// <value></value>
		public System.Int64 ProductionID
		{
			get
			{
				return this.productionID;
			}
			set
			{
				productionID = value;
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
