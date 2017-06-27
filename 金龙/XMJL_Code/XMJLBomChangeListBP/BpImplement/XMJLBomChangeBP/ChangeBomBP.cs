





namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 更改缺件表 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ChangeBomBP
	{
	    #region Fields
		private List<System.String> bomChangeIdList;
		
	    #endregion
		
	    #region constructor
		public ChangeBomBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 缺件变更ID列表	
		/// 更改缺件表.Misc.缺件变更ID列表
		/// </summary>
		/// <value></value>
		public List<System.String> BomChangeIdList
		{
			get
			{
				return this.bomChangeIdList;
			}
			set
			{
				bomChangeIdList = value;
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
