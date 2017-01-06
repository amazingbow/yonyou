namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// LaserLabBNChangeBP partial 
    /// </summary>	
    public partial class LaserLabBNChangeBP
    {
        internal BaseStrategy Select()
        {
            return new LaserLabBNChangeBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class LaserLabBNChangeBPImpementStrategy : BaseStrategy
    {
        public LaserLabBNChangeBPImpementStrategy() { }

        public override object Do(object obj)
        {
            LaserLabBNChangeBP bpObj = (LaserLabBNChangeBP)obj;
            var str = "";
            LaserLab LaserLab = LaserLab.Finder.Find("LB=@LB and BN=@BN", new OqlParam[2] { new OqlParam(bpObj.LB), new OqlParam(bpObj.BN) });
            if (LaserLab != null)
            {
                if (LaserLab.ID != 0L)
                {
                    using (ISession session = Session.Open())
                    {
                        LaserLab.BN = bpObj.AmendBN;
                        session.Commit();
                    }
                    str = LaserLab.BN;
                }
            }
            else
            {
                str = "Flase";                
            }

            return str;
        }
    }

    #endregion


}