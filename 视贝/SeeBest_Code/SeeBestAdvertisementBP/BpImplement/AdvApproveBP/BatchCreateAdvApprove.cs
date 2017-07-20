





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 批量生成核销单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class BatchCreateAdvApprove
	{
	    #region Fields
		private System.DateTime startDate;
		private System.DateTime endDate;
		
	    #endregion
		
	    #region constructor
		public BatchCreateAdvApprove()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 开始日期	
		/// 批量生成核销单.Misc.开始日期
		/// </summary>
		/// <value></value>
		public System.DateTime StartDate
		{
			get
			{
				return this.startDate;
			}
			set
			{
				startDate = value;
			}
		}
		/// <summary>
		/// 结束日期	
		/// 批量生成核销单.Misc.结束日期
		/// </summary>
		/// <value></value>
		public System.DateTime EndDate
		{
			get
			{
				return this.endDate;
			}
			set
			{
				endDate = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public System.Int32 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int32 result =  (System.Int32)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
