namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.Cust.XMJLBomChangeBE;
    using UFIDA.U9.Cust.XMJL.DocumentTypeBE;

    /// <summary>
    /// ChangeBomBP partial 
    /// </summary>	
    public partial class ChangeBomBP
    {
        internal BaseStrategy Select()
        {
            return new ChangeBomBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ChangeBomBPImpementStrategy : BaseStrategy
    {
        public ChangeBomBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ChangeBomBP bpObj = (ChangeBomBP)obj;
            string returnStr = string.Empty;
            if (bpObj.BomChangeIdList == null) return "传入数据为空！";
            if (bpObj.BomChangeIdList.Count == 0) return "传入数据为空！";
            var bomChange = Cust_Xmjl_MO_BomChange.Finder.FindAll(" ID in (" + string.Join(",", bpObj.BomChangeIdList.ToArray()) + ")");
            if (bomChange.Count == 0) return "请先保存！";
            Dictionary<long, Warehouse> warehouse = new Dictionary<long, Warehouse>();
            var doctype = Cust_Xmjl_DocumentType.Finder.Find("Code='01'");
            using (ISession session = Session.Open())
            {
                foreach (var change in bomChange)
                {
                    if (change.ChangeStat) 
                    {
                        returnStr += change.DocNo + "已经执行过变更缺件；";
                        continue; 
                    }
                    foreach (var car in change.Cust_Xmjl_MO_BomChangeManufactureNo)
                    {
                        Cust_Xmjl_MO_BomMain bomMain = Cust_Xmjl_MO_BomMain.Create();
                        bomMain.DocumentType = doctype;
                        bomMain.CarType = car.CarType;
                        bomMain.ManufactureNo = car.ManufactureNO;
                        bomMain.BusinessDate = DateTime.Now;
                        bomMain.Status = BomMainStatusEnum.UnDisburse;
                        bomMain.ContractNo = car.ContractNo;
                        bomMain.DisburseType = BomMainType.Rtn;
                        bomMain.DescFlexField.PrivateDescSeg4 = change.DocNo;//缺件变更单据
                        bomMain.DescFlexField.PrivateDescSeg2 = "True";
                        int i=10;
                        foreach (var item in change.Cust_Xmjl_MO_BomChangeItem)
                        {
                            Cust_Xmjl_MO_BomHead bomHead = Cust_Xmjl_MO_BomHead.Create(bomMain);
                            bomHead.WareHouse = GetWareHouseByCarAndItem(car.ManufactureNO.Code, item.Item, item.WorkPlace);
                            bomHead.Item = item.Item;
                            bomHead.Status = BomHeadStatus.InitStat;
                            bomHead.Supplier = item.Supplier;
                            bomHead.WorkPlace = item.WorkPlace;
                            bomHead.Qty = item.DistQty;
                            bomHead.RowNo = i;
                            i += 10;
                        }
                    }
                    change.ChangeStat = true;
                }
                session.Commit();
            }
            return returnStr;
        }

        private Warehouse GetWareHouseByCarAndItem(string carCode, ItemMaster item, string workPlace)
        {
            if (item == null) return null;
            string whCode = "";
            switch (carCode.Substring(0, 1))
            {
                case "1":
                    {
                        if (workPlace.Trim() != "DP") { whCode = item.DescFlexField.PrivateDescSeg2; }
                        else { whCode = item.DescFlexField.PrivateDescSeg3; }; break;
                    }
                case "3":
                    {
                        if (workPlace.Trim() != "DP") { whCode = item.DescFlexField.PrivateDescSeg4; }
                        else { whCode = item.DescFlexField.PrivateDescSeg5; }; break;
                    }
                case "7":
                    {
                        if (workPlace.Trim() != "DP") { whCode = item.DescFlexField.PrivateDescSeg6; }
                        else { whCode = item.DescFlexField.PrivateDescSeg7; }; break;
                    }
                case "2": whCode = item.DescFlexField.PrivateDescSeg8; break;
                case "4":
                case "5": whCode = item.DescFlexField.PrivateDescSeg1; break;
            }
            return Warehouse.FindByCode(Context.LoginOrg, whCode);
        }
        //private WareHouse
    }

    #endregion


}