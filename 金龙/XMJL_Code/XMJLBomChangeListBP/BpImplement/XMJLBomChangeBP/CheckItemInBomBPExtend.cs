namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// CheckItemInBomBP partial 
	/// </summary>	
	public partial class CheckItemInBomBP 
	{	
		internal BaseStrategy Select()
		{
			return new CheckItemInBomBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CheckItemInBomBPImpementStrategy : BaseStrategy
	{
		public CheckItemInBomBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CheckItemInBomBP bpObj = (CheckItemInBomBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}