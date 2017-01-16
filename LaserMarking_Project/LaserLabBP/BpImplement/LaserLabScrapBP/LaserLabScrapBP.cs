





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 镭射标报废BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LaserLabScrapBP
	{
	    #region Fields
		private System.String lB;
		private System.DateTime scrapDT;
		
	    #endregion
		
	    #region constructor
		public LaserLabScrapBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// LB编码	
		/// 镭射标报废BP.Misc.LB编码
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
		/// 报废时间	
		/// 镭射标报废BP.Misc.报废时间
		/// </summary>
		/// <value></value>
		public System.DateTime ScrapDT
		{
			get
			{
				return this.scrapDT;
			}
			set
			{
				scrapDT = value;
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
