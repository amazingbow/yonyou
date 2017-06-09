





namespace UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据值集代码获取值集值 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetValueSetInfo
	{
	    #region Fields
		private System.String valueCode;
		
	    #endregion
		
	    #region constructor
		public GetValueSetInfo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 属性	
		/// 根据值集代码获取值集值.Misc.属性
		/// </summary>
		/// <value></value>
		public System.String ValueCode
		{
			get
			{
				return this.valueCode;
			}
			set
			{
				valueCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDef> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDef> result =  (List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDef>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
