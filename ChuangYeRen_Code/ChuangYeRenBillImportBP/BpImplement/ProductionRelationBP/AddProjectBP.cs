





namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 添加项目 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class AddProjectBP
	{
	    #region Fields
		private System.String code;
		private System.DateTime startDate;
		private System.DateTime endDate;
		private System.Int64 fromOrg;
		private System.Int64 toOrg;
		
	    #endregion
		
	    #region constructor
		public AddProjectBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 项目号	
		/// 添加项目.Misc.项目号
		/// </summary>
		/// <value></value>
		public System.String Code
		{
			get
			{
				return this.code;
			}
			set
			{
				code = value;
			}
		}
		/// <summary>
		/// 开始时间	
		/// 添加项目.Misc.开始时间
		/// </summary>
		/// <value></value>
		public System.DateTime StartDate
		{
			get
			{
				return this.startDate;
			}
			set
			{
				startDate = value;
			}
		}
		/// <summary>
		/// 结束时间	
		/// 添加项目.Misc.结束时间
		/// </summary>
		/// <value></value>
		public System.DateTime EndDate
		{
			get
			{
				return this.endDate;
			}
			set
			{
				endDate = value;
			}
		}
		/// <summary>
		/// 组织	
		/// 添加项目.Misc.组织
		/// </summary>
		/// <value></value>
		public System.Int64 FromOrg
		{
			get
			{
				return this.fromOrg;
			}
			set
			{
				fromOrg = value;
			}
		}
		/// <summary>
		/// 下发组织	
		/// 添加项目.Misc.下发组织
		/// </summary>
		/// <value></value>
		public System.Int64 ToOrg
		{
			get
			{
				return this.toOrg;
			}
			set
			{
				toOrg = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public PublicDataTransObj.PublicReturnDTO Do()
		{	
		    BaseStrategy selector = Select();	
				PublicDataTransObj.PublicReturnDTO result =  (PublicDataTransObj.PublicReturnDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
