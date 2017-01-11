namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// LookScrapInfoBP partial 
	/// </summary>	
	public partial class LookScrapInfoBP 
	{	
		internal BaseStrategy Select()
		{
			return new LookScrapInfoBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class LookScrapInfoBPImpementStrategy : BaseStrategy
	{
		public LookScrapInfoBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			LookScrapInfoBP bpObj = (LookScrapInfoBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}