





namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 特定物料BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SpeciFicItemInfoBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto> speciFicItemInfoDto;
		private System.Int64 operators;
		
	    #endregion
		
	    #region constructor
		public SpeciFicItemInfoBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 特定物料DTO	
		/// 特定物料BP.Misc.特定物料DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto> SpeciFicItemInfoDto
		{
			get
			{
				return this.speciFicItemInfoDto;
			}
			set
			{
				speciFicItemInfoDto = value;
			}
		}
		/// <summary>
		/// 业务员	
		/// 特定物料BP.Misc.业务员
		/// </summary>
		/// <value></value>
		public System.Int64 Operators
		{
			get
			{
				return this.operators;
			}
			set
			{
				operators = value;
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
