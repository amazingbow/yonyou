namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ProductionOrderImportProcessBP partial 
	/// </summary>	
	public partial class ProductionOrderImportProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new ProductionOrderImportProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ProductionOrderImportProcessBPImpementStrategy : BaseStrategy
	{
		public ProductionOrderImportProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ProductionOrderImportProcessBP bpObj = (ProductionOrderImportProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}