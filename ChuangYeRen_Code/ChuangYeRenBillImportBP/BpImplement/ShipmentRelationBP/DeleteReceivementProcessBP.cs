





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 标准收货删除操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DeleteReceivementProcessBP
	{
	    #region Fields
		private System.Int64 relationU9Id;
		
	    #endregion
		
	    #region constructor
		public DeleteReceivementProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关U9ID	
		/// 标准收货删除操作.Misc.相关U9ID
		/// </summary>
		/// <value></value>
		public System.Int64 RelationU9Id
		{
			get
			{
				return this.relationU9Id;
			}
			set
			{
				relationU9Id = value;
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
