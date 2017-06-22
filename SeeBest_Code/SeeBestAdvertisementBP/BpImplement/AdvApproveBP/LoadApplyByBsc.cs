





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据办事处拉取申请单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LoadApplyByBsc
	{
	    #region Fields
		private System.Int64 custBscID;
		private System.DateTime startDate;
		private System.DateTime endDate;
		
	    #endregion
		
	    #region constructor
		public LoadApplyByBsc()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 办事处ID	
		/// 根据办事处拉取申请单.Misc.办事处ID
		/// </summary>
		/// <value></value>
		public System.Int64 CustBscID
		{
			get
			{
				return this.custBscID;
			}
			set
			{
				custBscID = value;
			}
		}
		/// <summary>
		/// 开始日期	
		/// 根据办事处拉取申请单.Misc.开始日期
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
		/// 根据办事处拉取申请单.Misc.结束日期
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDto> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDto> result =  (List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDto>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
