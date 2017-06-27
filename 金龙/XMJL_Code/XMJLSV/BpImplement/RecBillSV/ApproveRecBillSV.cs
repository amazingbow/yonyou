





namespace UFIDA.U9.Cust.XMJL.RecBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 收款单审核服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApproveRecBillSV
	{
	    #region Fields
		private List<System.Int64> recBillHeadKey;
		
	    #endregion
		
	    #region constructor
		public ApproveRecBillSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 收款单ID集合	
		/// 收款单审核服务.Misc.收款单ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> RecBillHeadKey
		{
			get
			{
				return this.recBillHeadKey;
			}
			set
			{
				recBillHeadKey = value;
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
