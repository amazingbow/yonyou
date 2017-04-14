namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ProductionInWarehouseBP partial 
	/// </summary>	
	public partial class ProductionInWarehouseBP 
	{	
		internal BaseStrategy Select()
		{
			return new ProductionInWarehouseBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ProductionInWarehouseBPImpementStrategy : BaseStrategy
	{
		public ProductionInWarehouseBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ProductionInWarehouseBP bpObj = (ProductionInWarehouseBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}