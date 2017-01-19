namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// LaserLaBGetInfoBP partial 
	/// </summary>	
	public partial class LaserLaBGetInfoBP 
	{	
		internal BaseStrategy Select()
		{
			return new LaserLaBGetInfoBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class LaserLaBGetInfoBPImpementStrategy : BaseStrategy
	{
		public LaserLaBGetInfoBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			LaserLaBGetInfoBP bpObj = (LaserLaBGetInfoBP)obj;            
            List<LabBNInfoDTO> labBNInfoDto = new List<LabBNInfoDTO>();
            StringBuilder str = new StringBuilder();
            str.Append("1=1");
            if (!string.IsNullOrEmpty(bpObj.BN))
            {
                str.Append("and BN='"+bpObj.BN+"'");
            }
            if (!string.IsNullOrEmpty(bpObj.Type))
            {
                str.Append("and Type='" + bpObj.Type + "'");
            }

            LaserLab.EntityList laserLabList = LaserLab.Finder.FindAll(str.ToString(),null);
            if (laserLabList != null)
            {
                foreach (LaserLab laserLab in laserLabList)
                {
                    LabBNInfoDTO labBNInfo = new LabBNInfoDTO();
                    labBNInfo.BN = laserLab.BN;
                    labBNInfo.LB = laserLab.LB;
                    labBNInfo.CP = laserLab.Cp.Res_Name;
                    labBNInfo.MasterDT = laserLab.MasterDT;
                    labBNInfoDto.Add(labBNInfo);
                }
            }
            return labBNInfoDto;
		}		
	}

	#endregion
	
	
}