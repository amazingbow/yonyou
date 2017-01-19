namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
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
            var str = "";
            if (!string.IsNullOrEmpty(bpObj.LB))
            {
                LaserLab laserLab = LaserLab.Finder.Find("LB=@LB", new OqlParam[] { new OqlParam(bpObj.LB) });
                if (laserLab != null)
                {
                    using (ISession session = Session.Open())
                    {
                        laserLab.ScarpDT = bpObj.ScrapDT;
                        laserLab.Cp = LBEnum.Scrap;
                        str = "LB编码为" + bpObj.LB + "的数据已经报废,报废时间为" + laserLab.ScarpDT;
                        session.Commit();
                    }
                }

            }
            return str;
        }
    }

    #endregion


}