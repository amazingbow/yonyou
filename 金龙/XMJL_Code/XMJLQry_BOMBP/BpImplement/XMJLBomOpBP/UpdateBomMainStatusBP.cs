





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 更新缺件主表状态和发料单号 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpdateBomMainStatusBP
	{
	    #region Fields
		private List<System.String> manufactureNoList;
		private System.Int32 disburseType;
		
	    #endregion
		
	    #region constructor
		public UpdateBomMainStatusBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 缺件主表车号集合	
		/// 更新缺件主表状态和发料单号.Misc.缺件主表车号集合
		/// </summary>
		/// <value></value>
		public List<System.String> ManufactureNoList
		{
			get
			{
				return this.manufactureNoList;
			}
			set
			{
				manufactureNoList = value;
			}
		}
		/// <summary>
		/// 发料类型	
		/// 更新缺件主表状态和发料单号.Misc.发料类型
		/// </summary>
		/// <value></value>
		public System.Int32 DisburseType
		{
			get
			{
				return this.disburseType;
			}
			set
			{
				disburseType = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
