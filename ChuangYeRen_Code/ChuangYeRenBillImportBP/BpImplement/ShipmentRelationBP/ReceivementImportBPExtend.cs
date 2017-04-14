namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ReceivementImportBP partial 
	/// </summary>	
	public partial class ReceivementImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new ReceivementImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ReceivementImportBPImpementStrategy : BaseStrategy
	{
		public ReceivementImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ReceivementImportBP bpObj = (ReceivementImportBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}