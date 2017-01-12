namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// SingleChangeBP partial 
    /// </summary>	
    public partial class SingleChangeBP
    {
        internal BaseStrategy Select()
        {
            return new SingleChangeBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SingleChangeBPImpementStrategy : BaseStrategy
    {
        public SingleChangeBPImpementStrategy() { }

        public override object Do(object obj)
        {
            SingleChangeBP bpObj = (SingleChangeBP)obj;
            var lb = bpObj.LaserLab;
            if (!string.IsNullOrEmpty(lb))
            {
                LaserLab lab = LaserLab.Finder.Find("LB='" + line + "'");
            }
            return null;
        }
    }

    #endregion


}