





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 应收单导入操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ARBillImportBP
	{
	    #region Fields
		private System.Int64 relationId;
		
	    #endregion
		
	    #region constructor
		public ARBillImportBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 相关表ID	
		/// 应收单导入操作.Misc.相关表ID
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
		public UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP.ARBillReturnDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP.ARBillReturnDTO result =  (UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP.ARBillReturnDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
