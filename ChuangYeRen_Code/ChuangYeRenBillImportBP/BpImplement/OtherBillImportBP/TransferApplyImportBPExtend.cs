namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// TransferApplyImportBP partial 
	/// </summary>	
	public partial class TransferApplyImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new TransferApplyImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class TransferApplyImportBPImpementStrategy : BaseStrategy
	{
		public TransferApplyImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			TransferApplyImportBP bpObj = (TransferApplyImportBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}