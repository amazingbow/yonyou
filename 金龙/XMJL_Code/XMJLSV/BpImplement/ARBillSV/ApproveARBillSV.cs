





namespace UFIDA.U9.Cust.XMJL.ARBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 应收单审核服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApproveARBillSV
	{
	    #region Fields
		private List<System.Int64> arBillHeadKey;
		
	    #endregion
		
	    #region constructor
		public ApproveARBillSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 应收单ID集合	
		/// 应收单审核服务.Misc.应收单ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> ArBillHeadKey
		{
			get
			{
				return this.arBillHeadKey;
			}
			set
			{
				arBillHeadKey = value;
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
