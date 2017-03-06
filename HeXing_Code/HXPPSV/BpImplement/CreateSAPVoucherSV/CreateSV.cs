





namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建SAP与U9凭证对接中间表服务 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateSV
	{
	    #region Fields
		private List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO> sAPU9GLVoucherDTOS;
		
	    #endregion
		
	    #region constructor
		public CreateSV()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// SAP与U9凭证对接中间表列表	
		/// 创建SAP与U9凭证对接中间表服务.Misc.SAP与U9凭证对接中间表列表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO> SAPU9GLVoucherDTOS
		{
			get
			{
				return this.sAPU9GLVoucherDTOS;
			}
			set
			{
				sAPU9GLVoucherDTOS = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTO result =  (UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
