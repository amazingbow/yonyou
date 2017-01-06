





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 镭射标添加 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class LaserLabAddBP
	{
	    #region Fields
		private System.String bN;
		private System.String lB;
		private System.String type;
		private System.DateTime masterDT;
		private System.String customer;
		
	    #endregion
		
	    #region constructor
		public LaserLabAddBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 批次号	
		/// 镭射标添加.Misc.批次号
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
		/// 镭射标	
		/// 镭射标添加.Misc.镭射标
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
		/// 型号	
		/// 镭射标添加.Misc.型号
		/// </summary>
		/// <value></value>
		public System.String Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
			}
		}
		/// <summary>
		/// 物料时间	
		/// 镭射标添加.Misc.物料时间
		/// </summary>
		/// <value></value>
		public System.DateTime MasterDT
		{
			get
			{
				return this.masterDT;
			}
			set
			{
				masterDT = value;
			}
		}
		/// <summary>
		/// 客户	
		/// 镭射标添加.Misc.客户
		/// </summary>
		/// <value></value>
		public System.String Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				customer = value;
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
