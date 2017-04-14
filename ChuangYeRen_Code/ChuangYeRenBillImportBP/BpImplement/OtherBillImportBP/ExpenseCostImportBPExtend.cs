namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ExpenseCostImportBP partial 
	/// </summary>	
	public partial class ExpenseCostImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new ExpenseCostImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ExpenseCostImportBPImpementStrategy : BaseStrategy
	{
		public ExpenseCostImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ExpenseCostImportBP bpObj = (ExpenseCostImportBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}