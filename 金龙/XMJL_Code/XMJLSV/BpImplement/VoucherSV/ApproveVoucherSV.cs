





namespace UFIDA.U9.Cust.XMJL.VoucherSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 凭证审核服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApproveVoucherSV
	{
	    #region Fields
		private List<System.Int64> keyList;
		
	    #endregion
		
	    #region constructor
		public ApproveVoucherSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 凭证ID集合	
		/// 凭证审核服务.Misc.凭证ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> KeyList
		{
			get
			{
				return this.keyList;
			}
			set
			{
				keyList = value;
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
