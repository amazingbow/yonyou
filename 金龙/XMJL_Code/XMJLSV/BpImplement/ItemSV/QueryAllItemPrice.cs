





namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取所有的料品价格 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryAllItemPrice
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public QueryAllItemPrice()
		{}
		
	    #endregion

	    #region member		
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO> result =  (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
