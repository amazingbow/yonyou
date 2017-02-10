namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// CreateVoucherfromSAP partial 
	/// </summary>	
	public partial class CreateVoucherfromSAP 
	{	
		internal BaseStrategy Select()
		{
			return new CreateVoucherfromSAPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateVoucherfromSAPImpementStrategy : BaseStrategy
	{
		public CreateVoucherfromSAPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateVoucherfromSAP bpObj = (CreateVoucherfromSAP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}