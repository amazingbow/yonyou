





namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 汇总立账生单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SumAccrueDocToAPBillSV
	{
	    #region Fields
		private System.String supplierCode;
		private System.Int64 currency;
		private System.Int64 sRCOrgID;
		private List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO> rCVLineInfoDTO;
		private System.String aPBillCode;
		private System.String memo;
		private System.String opCode;
		private System.String opDptCode;
		
	    #endregion
		
	    #region constructor
		public SumAccrueDocToAPBillSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 立账供应商	
		/// 汇总立账生单.Misc.立账供应商
		/// </summary>
		/// <value></value>
		public System.String SupplierCode
		{
			get
			{
				return this.supplierCode;
			}
			set
			{
				supplierCode = value;
			}
		}
		/// <summary>
		/// 币种	
		/// 汇总立账生单.Misc.币种
		/// </summary>
		/// <value></value>
		public System.Int64 Currency
		{
			get
			{
				return this.currency;
			}
			set
			{
				currency = value;
			}
		}
		/// <summary>
		/// 来源组织ID	
		/// 汇总立账生单.Misc.来源组织ID
		/// </summary>
		/// <value></value>
		public System.Int64 SRCOrgID
		{
			get
			{
				return this.sRCOrgID;
			}
			set
			{
				sRCOrgID = value;
			}
		}
		/// <summary>
		/// 收货行信息	
		/// 汇总立账生单.Misc.收货行信息
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO> RCVLineInfoDTO
		{
			get
			{
				return this.rCVLineInfoDTO;
			}
			set
			{
				rCVLineInfoDTO = value;
			}
		}
		/// <summary>
		/// 发票号	
		/// 汇总立账生单.Misc.发票号
		/// </summary>
		/// <value></value>
		public System.String APBillCode
		{
			get
			{
				return this.aPBillCode;
			}
			set
			{
				aPBillCode = value;
			}
		}
		/// <summary>
		/// 备注	
		/// 汇总立账生单.Misc.备注
		/// </summary>
		/// <value></value>
		public System.String Memo
		{
			get
			{
				return this.memo;
			}
			set
			{
				memo = value;
			}
		}
		/// <summary>
		/// 业务员代码	
		/// 汇总立账生单.Misc.业务员代码
		/// </summary>
		/// <value></value>
		public System.String OpCode
		{
			get
			{
				return this.opCode;
			}
			set
			{
				opCode = value;
			}
		}
		/// <summary>
		/// 业务员部门	
		/// 汇总立账生单.Misc.业务员部门
		/// </summary>
		/// <value></value>
		public System.String OpDptCode
		{
			get
			{
				return this.opDptCode;
			}
			set
			{
				opDptCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO result =  (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
