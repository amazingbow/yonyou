





namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询物料价格 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetItemPrice
	{
	    #region Fields
		private System.String itemCode;
		
	    #endregion
		
	    #region constructor
		public GetItemPrice()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 属性	
		/// 查询物料价格.Misc.属性
		/// </summary>
		/// <value></value>
		public System.String ItemCode
		{
			get
			{
				return this.itemCode;
			}
			set
			{
				itemCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO result =  (UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
