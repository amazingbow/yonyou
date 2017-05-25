namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// PickListImportBP partial 
	/// </summary>	
	public partial class PickListImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new PickListImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class PickListImportBPImpementStrategy : BaseStrategy
	{
		public PickListImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			PickListImportBP bpObj = (PickListImportBP)obj;
            PublicReturnDTO pub = new PublicReturnDTO();
            return pub;
			
		}		
	}

	#endregion
	
	
}