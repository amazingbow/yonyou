





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// LB批号修改 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LaserLabBNChangeBP
	{
	    #region Fields
		private System.String lB;
		private System.String bN;
		private System.String amendBN;
		
	    #endregion
		
	    #region constructor
		public LaserLabBNChangeBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 镭射标	
		/// LB批号修改.Misc.镭射标
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
		/// 批次号	
		/// LB批号修改.Misc.批次号
		/// </summary>
		/// <value></value>
		public System.String BN
		{
			get
			{
				return this.bN;
			}
			set
			{
				bN = value;
			}
		}
		/// <summary>
		/// 修改批号	
		/// LB批号修改.Misc.修改批号
		/// </summary>
		/// <value></value>
		public System.String AmendBN
		{
			get
			{
				return this.amendBN;
			}
			set
			{
				amendBN = value;
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
