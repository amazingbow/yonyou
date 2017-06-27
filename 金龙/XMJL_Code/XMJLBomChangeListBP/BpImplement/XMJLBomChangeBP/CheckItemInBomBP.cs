





namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 校验料品是否在缺件表中 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CheckItemInBomBP
	{
	    #region Fields
		private List<System.String> itemIdList;
		
	    #endregion
		
	    #region constructor
		public CheckItemInBomBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 属性	
		/// 校验料品是否在缺件表中.Misc.属性
		/// </summary>
		/// <value></value>
		public List<System.String> ItemIdList
		{
			get
			{
				return this.itemIdList;
			}
			set
			{
				itemIdList = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTO> result =  (List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
