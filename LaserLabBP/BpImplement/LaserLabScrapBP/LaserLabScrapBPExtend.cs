namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// LaserLabScrapBP partial 
	/// </summary>	
	public partial class LaserLabScrapBP 
	{	
		internal BaseStrategy Select()
		{
			return new LaserLabScrapBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class LaserLabScrapBPImpementStrategy : BaseStrategy
	{
		public LaserLabScrapBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			LaserLabScrapBP bpObj = (LaserLabScrapBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}