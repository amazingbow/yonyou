namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFIDA.U9.MO.REP;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.CBO.MFG.ProductionLine;
    using MO.MO;

    /// <summary>
    /// SplitCarNoToPls partial 
    /// </summary>	
    public partial class SplitCarNoToPls
    {
        internal BaseStrategy Select()
        {
            return new SplitCarNoToPlsImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SplitCarNoToPlsImpementStrategy : BaseStrategy
    {
        public SplitCarNoToPlsImpementStrategy() { }

        public override object Do(object obj)
        {
            SplitCarNoToPls bpObj = (SplitCarNoToPls)obj;
            //bpObj
            if (bpObj.SplitCarDTOList.Count == 0) return false;
            List<string> PlsIDList = new List<string>();
            bpObj.SplitCarDTOList.ForEach(i =>
            {
                if (!PlsIDList.Contains(i.PlsID))
                {
                    PlsIDList.Add(i.PlsID);
                }
            });
            
            using (ISession session = Session.Open())
            {
                var plsList = MO.Finder.FindAll("ID in (" + string.Join(",", PlsIDList.ToArray()) + ")");
                if (plsList == null || plsList.Count == 0) return false;
                foreach (MO item in plsList)
                {
                    foreach (var splitCar in bpObj.SplitCarDTOList)
                    {
                        if (item.ID.ToString() == splitCar.PlsID)
                        {
                            var project = Project.FindByCode(splitCar.ManufactureNo);
                            project.DescFlexField.PrivateDescSeg1 = "true";
                            if (item.Project != null)
                            {
                                var alPro = Project.FindByCode(item.Project.Code);
                                alPro.DescFlexField.PrivateDescSeg1 = "false";
                            }
                            project.StartDate = DateTime.Parse("2016-01-01");
                            project.EndDate = DateTime.Now;
                            string zzTime = string.Empty;
                            string tzTime = string.Empty;
                            string tsTime = string.Empty;
                            string hzTime = string.Empty;
                            string dpTime = string.Empty;
                            string nsTime = string.Empty;
                            ProductionLine production = ProductionLine.Finder.Find("Code='"+item.DescFlexField.PrivateDescSeg11);//生产订单的扩展字段8 用于存生产线
                            foreach (var posi in production.ProductionLinePosition)
                            {
                                switch (posi.Name)
                                {
                                    case "焊装":
                                        hzTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    case "涂装":
                                        tzTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    case "底盘":
                                        dpTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    case "总装":
                                        zzTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    case "调试":
                                        tsTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    case "内饰":
                                        nsTime = item.ProductDate.AddDays((double)posi.CycleHighValue).ToString();
                                        break;
                                    default:
                                        break;
                                }
                            }
                            if (item.ProductQty == 1)
                            {
                                item.DocNo = splitCar.ManufactureNo;
                                item.Project = project;
                                item.DescFlexField.PrivateDescSeg4 = splitCar.Sequence.ToString();//车序
                                item.DescFlexField.PrivateDescSeg5 = hzTime;//焊装
                                item.DescFlexField.PrivateDescSeg6 = tzTime;//涂装
                                item.DescFlexField.PrivateDescSeg7 = dpTime;//底盘
                                item.DescFlexField.PrivateDescSeg8 = zzTime;//总装
                                item.DescFlexField.PrivateDescSeg9 = tsTime;//调试
                                item.DescFlexField.PrivateDescSeg10 = nsTime;//内饰
                                //item.DescFlexField.PrivateDescSeg11//生产线Code
                            }
                            else
                            {
                                MO pls = MO .Create();
                                item.CopyTo(pls);
                                pls.DocNo = splitCar.ManufactureNo;
                                pls.Project = project;
                                //pls.Project.DescFlexField.PrivateDescSeg1 = "true";
                                pls.ProductQty = 1;
                                item.ProductQty = item.ProductQty - 1;
                                pls.DescFlexField.PrivateDescSeg4 = splitCar.Sequence.ToString();
                                pls.DescFlexField.PrivateDescSeg5 = hzTime;
                                pls.DescFlexField.PrivateDescSeg6 = tzTime;
                                pls.DescFlexField.PrivateDescSeg7 = dpTime;
                                pls.DescFlexField.PrivateDescSeg8 = zzTime;
                                pls.DescFlexField.PrivateDescSeg9 = tsTime;
                                pls.DescFlexField.PrivateDescSeg10 = nsTime;
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