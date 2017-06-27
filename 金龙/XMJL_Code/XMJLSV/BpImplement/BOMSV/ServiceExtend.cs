namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// Service partial 
	/// </summary>	
	public partial class Service 
	{	
		internal BaseStrategy Select()
		{
			return new ServiceImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ServiceImpementStrategy : BaseStrategy
	{
		public ServiceImpementStrategy() { }

		public override object Do(object obj)
		{						
			Service bpObj = (Service)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}