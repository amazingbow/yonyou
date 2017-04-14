namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ProductionOutWarehouseBP partial 
	/// </summary>	
	public partial class ProductionOutWarehouseBP 
	{	
		internal BaseStrategy Select()
		{
			return new ProductionOutWarehouseBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ProductionOutWarehouseBPImpementStrategy : BaseStrategy
	{
		public ProductionOutWarehouseBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ProductionOutWarehouseBP bpObj = (ProductionOutWarehouseBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}