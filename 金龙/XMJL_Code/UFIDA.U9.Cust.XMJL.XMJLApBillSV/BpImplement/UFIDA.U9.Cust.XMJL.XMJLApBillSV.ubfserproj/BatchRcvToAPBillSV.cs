





namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 发票生成应付单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class BatchRcvToAPBillSV
	{
	    #region Fields
		private List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO> rCVLineInfoDTO;
		private System.Int64 sRCOrgID;
		private System.Int64 currency;
		private System.String supplierCode;
		private System.String aPBillCode;
		
	    #endregion
		
	    #region constructor
		public BatchRcvToAPBillSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 行集合	
		/// 发票生成应付单.Misc.行集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO> RCVLineInfoDTO
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
		/// 组织ID	
		/// 发票生成应付单.Misc.组织ID
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
		/// 币种	
		/// 发票生成应付单.Misc.币种
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
		/// 立账供应商	
		/// 发票生成应付单.Misc.立账供应商
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
		/// 应付单单号	
		/// 发票生成应付单.Misc.应付单单号
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public System.Int64 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int64 result =  (System.Int64)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
