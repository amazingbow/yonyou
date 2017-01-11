namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ScarpGetLBInfoBP partial 
	/// </summary>	
	public partial class ScarpGetLBInfoBP 
	{	
		internal BaseStrategy Select()
		{
			return new ScarpGetLBInfoBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ScarpGetLBInfoBPImpementStrategy : BaseStrategy
	{
		public ScarpGetLBInfoBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ScarpGetLBInfoBP bpObj = (ScarpGetLBInfoBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}