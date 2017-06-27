namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// GetFirstData partial 
    /// </summary>	
    public partial class GetFirstData
    {
        internal BaseStrategy Select()
        {
            return new GetFirstDataImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetFirstDataImpementStrategy : BaseStrategy
    {
        public GetFirstDataImpementStrategy() { }

        public override object Do(object obj)
        {
            GetFirstData bpObj = (GetFirstData)obj;
            CostSharingRatioBE cost = CostSharingRatioBE.Finder.Find("1=1");
            if (cost != null)
            {
                CostSharingRationDTO dto = new CostSharingRationDTO
                {
                    ID = cost.ID,
                    SysVersion = cost.SysVersion,
                    Ratio = cost.Ratio
                };
                return dto;
            }

            return null;
        }
    }

    #endregion


}