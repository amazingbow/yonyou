





namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 生产线料品日计划拆分车号 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SplitCarNoToPls
	{
	    #region Fields
		private List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTO> splitCarDTOList;
		
	    #endregion
		
	    #region constructor
		public SplitCarNoToPls()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 拆分车号数据列表	
		/// 生产线料品日计划拆分车号.Misc.拆分车号数据列表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTO> SplitCarDTOList
		{
			get
			{
				return this.splitCarDTOList;
			}
			set
			{
				splitCarDTOList = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
