namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// DeleteReceivementProcessBP partial 
	/// </summary>	
	public partial class DeleteReceivementProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteReceivementProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteReceivementProcessBPImpementStrategy : BaseStrategy
	{
		public DeleteReceivementProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteReceivementProcessBP bpObj = (DeleteReceivementProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}