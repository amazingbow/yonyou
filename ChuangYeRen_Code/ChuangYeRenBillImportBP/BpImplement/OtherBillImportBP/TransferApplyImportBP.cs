





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 调拨申请单导入 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class TransferApplyImportBP
	{
	    #region Fields
		private System.Int64 iD;
		
	    #endregion
		
	    #region constructor
		public TransferApplyImportBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// ID	
		/// 调拨申请单导入.Misc.ID
		/// </summary>
		/// <value></value>
		public System.Int64 ID
		{
			get
			{
				return this.iD;
			}
			set
			{
				iD = value;
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
