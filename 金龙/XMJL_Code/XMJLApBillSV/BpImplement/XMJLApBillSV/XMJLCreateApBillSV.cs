





namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// XMJL生成应付单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class XMJLCreateApBillSV
	{
	    #region Fields
		private System.String supplierCode;
		private List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.RCVLineInfoDTO> rCVLineInfoDTO;
		private System.Int64 currency;
		private System.Int64 srcOrgID;
		
	    #endregion
		
	    #region constructor
		public XMJLCreateApBillSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 立账供应商	
		/// XMJL生成应付单.Misc.立账供应商
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
		/// 收货行信息（退货）	
		/// XMJL生成应付单.Misc.收货行信息（退货）
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.RCVLineInfoDTO> RCVLineInfoDTO
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
		/// 币种	
		/// XMJL生成应付单.Misc.币种
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
		/// XMJL生成应付单.Misc.来源组织ID
		/// </summary>
		/// <value></value>
		public System.Int64 SrcOrgID
		{
			get
			{
				return this.srcOrgID;
			}
			set
			{
				srcOrgID = value;
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
