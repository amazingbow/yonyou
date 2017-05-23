





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
		private System.Int64 inSourceID;
		private System.Int64 outSourceID;
		
	    #endregion
		
	    #region constructor
		public TransferApplyImportBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 入库单ID	
		/// 调拨申请单导入.Misc.入库单ID
		/// </summary>
		/// <value></value>
		public System.Int64 InSourceID
		{
			get
			{
				return this.inSourceID;
			}
			set
			{
				inSourceID = value;
			}
		}
		/// <summary>
		/// 出库单ID	
		/// 调拨申请单导入.Misc.出库单ID
		/// </summary>
		/// <value></value>
		public System.Int64 OutSourceID
		{
			get
			{
				return this.outSourceID;
			}
			set
			{
				outSourceID = value;
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
