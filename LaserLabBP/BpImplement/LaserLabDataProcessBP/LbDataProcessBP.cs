





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 镭射表数据处理 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LbDataProcessBP
	{
	    #region Fields
		private System.Int32 processType;
		
	    #endregion
		
	    #region constructor
		public LbDataProcessBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 数据转换类型	
		/// 镭射表数据处理.Misc.数据转换类型
		/// </summary>
		/// <value></value>
		public System.Int32 ProcessType
		{
			get
			{
				return this.processType;
			}
			set
			{
				processType = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Int32 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int32 result =  (System.Int32)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
