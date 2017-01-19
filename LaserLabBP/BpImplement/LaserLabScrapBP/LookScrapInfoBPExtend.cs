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
            List<LookScrapInfoDTO> ScrapInfoDTo = new List<LookScrapInfoDTO>();
            LaserLab.EntityList LaserLabList = LaserLabBE.LaserLab.LaserLab.Finder.FindAll("CP=@CP",new  OqlParam[]{ new OqlParam(LBEnum.Scrap.Value)});
            if (LaserLabList.Count > 0) 
            {
                foreach (LaserLab laserlab in LaserLabList)
                {
                    LookScrapInfoDTO ScrapInfo = new LookScrapInfoDTO();
                    ScrapInfo.BN = laserlab.BN;
                    ScrapInfo.LB = laserlab.LB;
                    ScrapInfo.TYPE = laserlab.Type;
                    ScrapInfo.CP = laserlab.Cp.Res_Name;
                    ScrapInfo.ScrapDT = laserlab.ScarpDT;
                    ScrapInfoDTo.Add(ScrapInfo);                   
                }
            }
            return ScrapInfoDTo;		
		}		
	}

	#endregion
	
	
}