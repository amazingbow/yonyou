namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ProcessRelData partial 
	/// </summary>	
	public partial class ProcessRelData 
	{	
		internal BaseStrategy Select()
		{
			return new ProcessRelDataImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ProcessRelDataImpementStrategy : BaseStrategy
	{
		public ProcessRelDataImpementStrategy() { }

		public override object Do(object obj)
		{						
			ProcessRelData bpObj = (ProcessRelData)obj;

            return null;
		}		
	}

	#endregion
	
	
}