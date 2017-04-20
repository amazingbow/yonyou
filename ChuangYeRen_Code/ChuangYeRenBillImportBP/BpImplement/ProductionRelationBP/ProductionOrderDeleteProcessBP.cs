





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
		private System.Int64 productionID;
		
	    #endregion
		
	    #region constructor
		public ProductionOrderDeleteProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 生产订单ID	
		/// 生产订单删除处理.Misc.生产订单ID
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
