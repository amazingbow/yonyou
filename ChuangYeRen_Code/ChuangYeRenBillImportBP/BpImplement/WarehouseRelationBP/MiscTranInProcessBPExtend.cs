namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// MiscTranInProcessBP partial 
	/// </summary>	
	public partial class MiscTranInProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new MiscTranInProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class MiscTranInProcessBPImpementStrategy : BaseStrategy
	{
		public MiscTranInProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			MiscTranInProcessBP bpObj = (MiscTranInProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}