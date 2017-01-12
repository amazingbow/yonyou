namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.Business;

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
            if (bpObj.ChangeModel == 0)
            {
                LaserLab lab = LaserLab.Finder.Find("LB='" + bpObj.LaserLab + "'");
                if (lab != null)
                {
                    lab.Cp = LBEnum.Shipment;
                    lab.ShipDT = DateTime.Now;
                }
            }
            else
            {
                using (ISession session = Session.Open())
                {
                    var labList = LaserLab.Finder.FindAll("BN='" + bpObj.BatchNo + "' and Type='" + bpObj.Type + "'");
                    if (labList.Count > 0)
                    {
                        foreach (var item in labList)
                        {
                            if (bpObj.FlowStart > 0)
                            {
                                var labCode = int.Parse(item.LB.Substring(1));
                                if (bpObj.FlowStart <= labCode && bpObj.FlowEnd >= labCode)
                                {
                                    item.Cp = LBEnum.Shipment;
                                    item.ShipDT = DateTime.Now;
                                }
                            }
                            else
                            {
                                item.Cp = LBEnum.Shipment;
                                item.ShipDT = DateTime.Now;
                            }
                        }
                    }
                    session.Commit();
                }
            }
            return false;
        }
    }

    #endregion


}