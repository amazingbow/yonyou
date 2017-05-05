





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 杂发操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class MiscTranOutProcessBP
	{
	    #region Fields
		private System.Int64 relationID;
		
	    #endregion
		
	    #region constructor
		public MiscTranOutProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关ID	
		/// 杂发操作.Misc.相关ID
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
