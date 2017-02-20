





namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 对照信息查询操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class HeXingRelatiomShipBP
	{
	    #region Fields
		private System.String hOrg;
		private System.String hRefType;
		private System.String hColumn;
		private System.String hStr;
		
	    #endregion
		
	    #region constructor
		public HeXingRelatiomShipBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 组织	
		/// 对照信息查询操作.Misc.组织
		/// </summary>
		/// <value></value>
		public System.String HOrg
		{
			get
			{
				return this.hOrg;
			}
			set
			{
				hOrg = value;
			}
		}
		/// <summary>
		/// 关系类型	
		/// 对照信息查询操作.Misc.关系类型
		/// </summary>
		/// <value></value>
		public System.String HRefType
		{
			get
			{
				return this.hRefType;
			}
			set
			{
				hRefType = value;
			}
		}
		/// <summary>
		/// 栏目	
		/// 对照信息查询操作.Misc.栏目
		/// </summary>
		/// <value></value>
		public System.String HColumn
		{
			get
			{
				return this.hColumn;
			}
			set
			{
				hColumn = value;
			}
		}
		/// <summary>
		/// 字符	
		/// 对照信息查询操作.Misc.字符
		/// </summary>
		/// <value></value>
		public System.String HStr
		{
			get
			{
				return this.hStr;
			}
			set
			{
				hStr = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDto> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDto> result =  (List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDto>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
