





namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取缺件主表信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBOMMainInfo
	{
	    #region Fields
		private System.String manufactureNo;
		private System.String contractNo;
		private System.String carType;
		private System.Int32 disburseType;
		
	    #endregion
		
	    #region constructor
		public GetBOMMainInfo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 车号	
		/// 获取缺件主表信息.Misc.车号
		/// </summary>
		/// <value></value>
		public System.String ManufactureNo
		{
			get
			{
				return this.manufactureNo;
			}
			set
			{
				manufactureNo = value;
			}
		}
		/// <summary>
		/// 合同号	
		/// 获取缺件主表信息.Misc.合同号
		/// </summary>
		/// <value></value>
		public System.String ContractNo
		{
			get
			{
				return this.contractNo;
			}
			set
			{
				contractNo = value;
			}
		}
		/// <summary>
		/// 车型	
		/// 获取缺件主表信息.Misc.车型
		/// </summary>
		/// <value></value>
		public System.String CarType
		{
			get
			{
				return this.carType;
			}
			set
			{
				carType = value;
			}
		}
		/// <summary>
		/// 发料类型	
		/// 获取缺件主表信息.Misc.发料类型
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDto> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDto> result =  (List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDto>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
