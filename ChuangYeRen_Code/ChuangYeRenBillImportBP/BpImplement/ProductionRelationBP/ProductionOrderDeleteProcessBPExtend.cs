namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ProductionOrderDeleteProcessBP partial 
	/// </summary>	
	public partial class ProductionOrderDeleteProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new ProductionOrderDeleteProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ProductionOrderDeleteProcessBPImpementStrategy : BaseStrategy
	{
		public ProductionOrderDeleteProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ProductionOrderDeleteProcessBP bpObj = (ProductionOrderDeleteProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}