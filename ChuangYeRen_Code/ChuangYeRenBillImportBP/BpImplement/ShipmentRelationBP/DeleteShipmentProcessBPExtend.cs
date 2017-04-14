namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// DeleteShipmentProcessBP partial 
	/// </summary>	
	public partial class DeleteShipmentProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteShipmentProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteShipmentProcessBPImpementStrategy : BaseStrategy
	{
		public DeleteShipmentProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteShipmentProcessBP bpObj = (DeleteShipmentProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}