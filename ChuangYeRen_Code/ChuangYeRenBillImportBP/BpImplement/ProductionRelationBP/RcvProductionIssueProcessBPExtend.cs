﻿namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// RcvProductionIssueProcessBP partial 
	/// </summary>	
	public partial class RcvProductionIssueProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new RcvProductionIssueProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class RcvProductionIssueProcessBPImpementStrategy : BaseStrategy
	{
		public RcvProductionIssueProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			RcvProductionIssueProcessBP bpObj = (RcvProductionIssueProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}