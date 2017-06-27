





namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取缺件信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class Operation
	{
	    #region Fields
		private System.String carCodeList;
		
	    #endregion
		
	    #region constructor
		public Operation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 车号	
		/// 获取缺件信息.Misc.车号
		/// </summary>
		/// <value></value>
		public System.String CarCodeList
		{
			get
			{
				return this.carCodeList;
			}
			set
			{
				carCodeList = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTO> result =  (List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
