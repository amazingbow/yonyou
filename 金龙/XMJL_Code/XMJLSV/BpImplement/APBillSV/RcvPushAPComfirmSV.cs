





namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 收货单推式应付立账服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class RcvPushAPComfirmSV
	{
	    #region Fields
		private System.Boolean isMergerAPConfirm;
		private System.Int64 rcvID;
		private List<System.Int64> rcvLineIDs;
		
	    #endregion
		
	    #region constructor
		public RcvPushAPComfirmSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 是否合并立账	
		/// 收货单推式应付立账服务.Misc.是否合并立账
		/// </summary>
		/// <value></value>
		public System.Boolean IsMergerAPConfirm
		{
			get
			{
				return this.isMergerAPConfirm;
			}
			set
			{
				isMergerAPConfirm = value;
			}
		}
		/// <summary>
		/// 收货单ID	
		/// 收货单推式应付立账服务.Misc.收货单ID
		/// </summary>
		/// <value></value>
		public System.Int64 RcvID
		{
			get
			{
				return this.rcvID;
			}
			set
			{
				rcvID = value;
			}
		}
		/// <summary>
		/// 收货单行ID集合	
		/// 收货单推式应付立账服务.Misc.收货单行ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> RcvLineIDs
		{
			get
			{
				return this.rcvLineIDs;
			}
			set
			{
				rcvLineIDs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO result =  (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
