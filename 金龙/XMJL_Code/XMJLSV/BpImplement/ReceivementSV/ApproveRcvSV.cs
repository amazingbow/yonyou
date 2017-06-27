





namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 收货单审核服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApproveRcvSV
	{
	    #region Fields
		private List<System.Int64> docHeadIDs;
		
	    #endregion
		
	    #region constructor
		public ApproveRcvSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 收货单ID集合	
		/// 收货单审核服务.Misc.收货单ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> DocHeadIDs
		{
			get
			{
				return this.docHeadIDs;
			}
			set
			{
				docHeadIDs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.String Do()
		{	
		    BaseStrategy selector = Select();	
				System.String result =  (System.String)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
