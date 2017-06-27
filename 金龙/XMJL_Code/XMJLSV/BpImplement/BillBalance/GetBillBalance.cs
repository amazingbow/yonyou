





namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询应付明细帐 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBillBalance
	{
	    #region Fields
		private UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTO billBalanceQueryDTO;
		
	    #endregion
		
	    #region constructor
		public GetBillBalance()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 应付明细账查询条件	
		/// 查询应付明细帐.Misc.应付明细账查询条件
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTO BillBalanceQueryDTO
		{
			get
			{
				return this.billBalanceQueryDTO;
			}
			set
			{
				billBalanceQueryDTO = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTO> result =  (List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
