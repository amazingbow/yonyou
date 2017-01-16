





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
		private List<System.String> lBList;
		private System.String bN;
		private System.String type;
		private System.String customer;
		private System.DateTime masterDT;
		
	    #endregion
		
	    #region constructor
		public LaserLabAddBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// LB集合	
		/// 镭射标添加.Misc.LB集合
		/// </summary>
		/// <value></value>
		public List<System.String> LBList
		{
			get
			{
				return this.lBList;
			}
			set
			{
				lBList = value;
			}
		}
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
