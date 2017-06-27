





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 标准收货单导入操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ReceivementImportBP
	{
	    #region Fields
		private System.Int64 relationId;
		
	    #endregion
		
	    #region constructor
		public ReceivementImportBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关表ID	
		/// 标准收货单导入操作.Misc.相关表ID
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
