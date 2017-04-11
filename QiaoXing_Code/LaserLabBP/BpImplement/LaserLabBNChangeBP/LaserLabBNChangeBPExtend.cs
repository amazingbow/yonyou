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
            int ChangeCount = 0;
            using (ISession session = Session.Open())
            {
                foreach (var LaserLB in bpObj.LB)
                {
                    ChangeCount += 1;
                    StringBuilder SqlBulder = new StringBuilder();
                    SqlBulder.Append("1=1");                  
                    SqlBulder.Append("and LB='" + LaserLB + "'");
                    if (!string.IsNullOrEmpty(bpObj.BN))
                    {
                        SqlBulder.Append("and BN='" + bpObj.BN + "'");
                    } 
                    LaserLab LaserLab = LaserLab.Finder.Find(SqlBulder.ToString(), null);
                    if (LaserLab != null)
                    {
                        if (LaserLab.ID != 0L)
                        {
                            LaserLab.BN = bpObj.AmendBN;
                        }
                    }
                }
                session.Commit();            
            }

                if (ChangeCount != 0)
                {
                    str = "已成功修改" + ChangeCount + "条批次号";
                }


            return str;
        }
    }

    #endregion


}