





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 杂发单列表批量拣货 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ShipmentDistributeBP
	{
	    #region Fields
		private List<System.Int64> iDList;
		
	    #endregion
		
	    #region constructor
		public ShipmentDistributeBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 杂发单ID	
		/// 杂发单列表批量拣货.Misc.杂发单ID
		/// </summary>
		/// <value></value>
		public List<System.Int64> IDList
		{
			get
			{
				return this.iDList;
			}
			set
			{
				iDList = value;
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
