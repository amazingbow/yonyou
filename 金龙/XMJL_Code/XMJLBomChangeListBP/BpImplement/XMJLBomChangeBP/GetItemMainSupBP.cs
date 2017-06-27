





namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取料品主供应商信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetItemMainSupBP
	{
	    #region Fields
		private List<System.Int64> itemIds;
		
	    #endregion
		
	    #region constructor
		public GetItemMainSupBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 料品ID 	
		/// 获取料品主供应商信息.Misc.料品ID 
		/// </summary>
		/// <value></value>
		public List<System.Int64> ItemIds
		{
			get
			{
				return this.itemIds;
			}
			set
			{
				itemIds = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTO> result =  (List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
