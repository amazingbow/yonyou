namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
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
    /// LaserLabAddBP partial 
    /// </summary>	
    public partial class LaserLabAddBP
    {
        internal BaseStrategy Select()
        {
            return new LaserLabAddBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class LaserLabAddBPImpementStrategy : BaseStrategy
    {
        public LaserLabAddBPImpementStrategy() { }

        public override object Do(object obj)
        {
            LaserLabAddBP bpObj = (LaserLabAddBP)obj;
            var str = "";
            using (ISession session = Session.Open())
            {
                foreach (var LB in bpObj.LBList)
                {
                    if (UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.Finder.FindAll("LB='" + LB + "'", null).Count < 1)
                    {

                        UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab Laser = LaserLab.Create();
                        Laser.BN = bpObj.BN;
                        Laser.LB = LB;
                        Laser.MasterDT = bpObj.MasterDT;
                        Laser.Type = bpObj.Type;
                        Laser.Cp = LBEnum.Master;

                    }
                    else
                    {
                        str = "LB编号：" + LB + "在数据库中已存在！";
                    }

                }
                session.Commit();
            }
            if (str == "")
            {
                str = "保存成功！";
            }
            return str;
        }
    }

    #endregion


}