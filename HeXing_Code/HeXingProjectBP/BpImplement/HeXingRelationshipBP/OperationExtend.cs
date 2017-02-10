namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// Operation partial 
	/// </summary>	
	public partial class Operation 
	{	
		internal BaseStrategy Select()
		{
			return new OperationImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class OperationImpementStrategy : BaseStrategy
	{
		public OperationImpementStrategy() { }

		public override object Do(object obj)
		{						
			Operation bpObj = (Operation)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}