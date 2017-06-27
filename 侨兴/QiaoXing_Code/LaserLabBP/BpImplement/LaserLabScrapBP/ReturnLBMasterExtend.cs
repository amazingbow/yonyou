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
    /// ReturnLBMaster partial 
    /// </summary>	
    public partial class ReturnLBMaster
    {
        internal BaseStrategy Select()
        {
            return new ReturnLBMasterImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ReturnLBMasterImpementStrategy : BaseStrategy
    {
        public ReturnLBMasterImpementStrategy() { }

        public override object Do(object obj)
        {
            ReturnLBMaster bpObj = (ReturnLBMaster)obj;
            var str = "";
            if (!string.IsNullOrEmpty(bpObj.LB) && bpObj.CP=="Scrap")
            {
                using (ISession session = Session.Open())
                {
                    LaserLab LaserLab = LaserLab.Finder.Find("LB=@LB and Cp=@Cp", new OqlParam[] { new OqlParam(bpObj.LB), new OqlParam(4) });
                    LaserLab.Cp = LBEnum.Master;
                    session.Commit();
                    str = "True";
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