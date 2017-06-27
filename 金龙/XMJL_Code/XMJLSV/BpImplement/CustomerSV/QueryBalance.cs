





namespace UFIDA.U9.Cust.XMJL.CustomerSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取客户金额额度 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryBalance
	{
	    #region Fields
		private List<System.String> codes;
		
	    #endregion
		
	    #region constructor
		public QueryBalance()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 客户代码集合	
		/// 获取客户金额额度.Misc.客户代码集合
		/// </summary>
		/// <value></value>
		public List<System.String> Codes
		{
			get
			{
				return this.codes;
			}
			set
			{
				codes = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTO> result =  (List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
