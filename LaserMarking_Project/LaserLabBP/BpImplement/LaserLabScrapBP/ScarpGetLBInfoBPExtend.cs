namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL;
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
            GetScrapLBInfoDto labBNInfo = new GetScrapLBInfoDto();
            LaserLab laserLab = LaserLab.Finder.Find("LB=@LB",new OqlParam[]{new OqlParam(bpObj.LB)});
            if (laserLab!= null)
            {                   
                    labBNInfo.BN = laserLab.BN;
                    labBNInfo.Type = laserLab.Type;
                    labBNInfo.CP = laserLab.Cp.Name;
                    labBNInfo.Date = DateTime.Parse(laserLab.CreatedOn.Date.ToString("yyyy-MM-dd"));
                    labBNInfo.Time = DateTime.Parse(laserLab.CreatedOn.ToString());
                    labBNInfo.LB = laserLab.LB;
            }
            return labBNInfo;
		}		
	}

	#endregion
	
	
}