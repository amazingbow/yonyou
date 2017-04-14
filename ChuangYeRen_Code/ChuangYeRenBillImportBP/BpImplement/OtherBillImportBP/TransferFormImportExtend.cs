namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// TransferFormImport partial 
	/// </summary>	
	public partial class TransferFormImport 
	{	
		internal BaseStrategy Select()
		{
			return new TransferFormImportImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class TransferFormImportImpementStrategy : BaseStrategy
	{
		public TransferFormImportImpementStrategy() { }

		public override object Do(object obj)
		{						
			TransferFormImport bpObj = (TransferFormImport)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}