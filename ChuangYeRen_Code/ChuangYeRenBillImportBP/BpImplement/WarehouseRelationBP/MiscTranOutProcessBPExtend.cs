namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// MiscTranOutProcessBP partial 
	/// </summary>	
	public partial class MiscTranOutProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new MiscTranOutProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class MiscTranOutProcessBPImpementStrategy : BaseStrategy
	{
		public MiscTranOutProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			MiscTranOutProcessBP bpObj = (MiscTranOutProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}