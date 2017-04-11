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
                        ProcessData(bpObj, lab);
                    }
                }
                else
                {
                    LaserLab.EntityList labList;
                    if (!string.IsNullOrEmpty(bpObj.Type))
                    {
                        labList = LaserLab.Finder.FindAll("BN='" + bpObj.BatchNo + "' and Type='" + bpObj.Type + "'");
                    }
                    else
                    {
                        labList = LaserLab.Finder.FindAll("BN='" + bpObj.BatchNo + "'");
                    }
                    if (labList.Count > 0)
                    {
                        foreach (var item in labList)
                        {
                            if (!string.IsNullOrEmpty(bpObj.FlowStart))
                            {
                                Match m = Regex.Match(item.LB, @"\d+");
                                int labCode = m.Success ? int.Parse(m.Value) : 0;
                                var haveFirst = bpObj.FlowStart.Substring(1) == item.LB.Substring(1) && bpObj.FlowEnd.Substring(1) == item.LB.Substring(1);
                                int start, end = 0;
                                int.TryParse(bpObj.FlowStart.Remove(0), out start);
                                int.TryParse(bpObj.FlowEnd.Remove(0), out end);
                                if (start == 0)
                                {
                                    throw new Exception("流水码输入错误");
                                }
                                if (haveFirst && labCode >= start && end >= labCode)
                                {
                                    ProcessData(bpObj, item);
                                }
                            }
                            else
                            {
                                ProcessData(bpObj, item);
                            }
                        }
                    }
                }
                session.Commit();
            }
            return true;
        }

        private void ProcessData(SingleChangeBP bpObj, LaserLab lab)
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
                    if (lab.Cp == LBEnum.Scrap)
                    {
                        throw new Exception(lab.LB + "当前镭射表已经报废，不能出货！");
                    }
                    lab.Cp = LBEnum.Shipment;
                    //如果时间不填写，就默认当前时间
                    lab.ShipDT = DateTime.Now;
                    if (bpObj.ShipDateTime != DateTime.MinValue && bpObj.ShipDateTime != null)
                    {
                        lab.ShipDT = bpObj.ShipDateTime;
                    }
                    if (!string.IsNullOrEmpty(bpObj.ShipBatchNo))
                    {
                        lab.ShipBN = bpObj.ShipBatchNo;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    #endregion


}