





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 返回物料状态 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ReturnLBMaster
	{
	    #region Fields
		private System.String lB;
		private System.String cP;
		
	    #endregion
		
	    #region constructor
		public ReturnLBMaster()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// LB编码	
		/// 返回物料状态.Misc.LB编码
		/// </summary>
		/// <value></value>
		public System.String LB
		{
			get
			{
				return this.lB;
			}
			set
			{
				lB = value;
			}
		}
		/// <summary>
		/// 状态	
		/// 返回物料状态.Misc.状态
		/// </summary>
		/// <value></value>
		public System.String CP
		{
			get
			{
				return this.cP;
			}
			set
			{
				cP = value;
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
