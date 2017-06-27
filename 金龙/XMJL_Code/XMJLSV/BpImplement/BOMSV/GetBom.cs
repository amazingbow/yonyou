





namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取车辆单台料单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBom
	{
	    #region Fields
		private System.String manufactureNo;
		private System.DateTime lastSynTimeStamp;
		
	    #endregion
		
	    #region constructor
		public GetBom()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 车号	
		/// 获取车辆单台料单.Misc.车号
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
		/// 最后同步时间	
		/// 获取车辆单台料单.Misc.最后同步时间
		/// </summary>
		/// <value></value>
		public System.DateTime LastSynTimeStamp
		{
			get
			{
				return this.lastSynTimeStamp;
			}
			set
			{
				lastSynTimeStamp = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO> result =  (List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
