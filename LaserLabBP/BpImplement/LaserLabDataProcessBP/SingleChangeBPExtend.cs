namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.Business;
    using System.Text.RegularExpressions;

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
            using (ISession session = Session.Open())
            {
                if (bpObj.ChangeModel == 0)
                {
                    LaserLab lab = LaserLab.Finder.Find("LB='" + bpObj.LaserLab + "'");
                    if (lab != null)
                    {
                        switch (bpObj.ChangeCp)
                        {
                            case 1:
                                lab.Cp = LBEnum.GoldOil;
                                lab.GoldOilDT = DateTime.Now;
                                break;
                            case 2:
                                lab.Cp = LBEnum.Packing;
                                lab.PackDT = DateTime.Now;
                                break;
                            case 3:
                                lab.Cp = LBEnum.Shipment;
                                lab.ShipDT = DateTime.Now;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    var labList = LaserLab.Finder.FindAll("BN='" + bpObj.BatchNo + "' and Type='" + bpObj.Type + "'");
                    if (labList.Count > 0)
                    {
                        foreach (var item in labList)
                        {
                            if (bpObj.FlowStart > 0)
                            {
                                Match m = Regex.Match(item.LB, @"\d+");
                                int labCode = m.Success ? int.Parse(m.Value) : 0;
                                if (bpObj.FlowStart <= labCode && bpObj.FlowEnd >= labCode)
                                {
                                    switch (bpObj.ChangeCp)
                                    {
                                        case 1:
                                            item.Cp = LBEnum.GoldOil;
                                            item.GoldOilDT = DateTime.Now;
                                            break;
                                        case 2:
                                            item.Cp = LBEnum.Packing;
                                            item.PackDT = DateTime.Now;
                                            break;
                                        case 3:
                                            item.Cp = LBEnum.Shipment;
                                            item.ShipDT = DateTime.Now;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                switch (bpObj.ChangeCp)
                                {
                                    case 1:
                                        item.Cp = LBEnum.GoldOil;
                                        item.GoldOilDT = DateTime.Now;
                                        break;
                                    case 2:
                                        item.Cp = LBEnum.Packing;
                                        item.PackDT = DateTime.Now;
                                        break;
                                    case 3:
                                        item.Cp = LBEnum.Shipment;
                                        item.ShipDT = DateTime.Now;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                session.Commit();
            }
            return true;
        }
    }

    #endregion


}