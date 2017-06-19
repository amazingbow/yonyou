





namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取第一条数据 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetFirstData
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public GetFirstData()
		{}
		
	    #endregion

	    #region member		
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTO result =  (UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
