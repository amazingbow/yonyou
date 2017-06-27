namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.InvDoc.MiscShip;
    using UFIDA.U9.InvTrans.WhQoh;
    using UFIDA.U9.InvTrans.WhQoh.Proxy;
    using UFIDA.U9.Lot;
    using UFIDA.U9.Lot.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// ShipmentDistributeBP partial 
    /// </summary>	
    public partial class ShipmentDistributeBP
    {
        internal BaseStrategy Select()
        {
            return new ShipmentDistributeBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ShipmentDistributeBPImpementStrategy : BaseStrategy
    {
        public ShipmentDistributeBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ShipmentDistributeBP bpObj = (ShipmentDistributeBP)obj;
            INVLotShipmentDistributeSVProxy lotQuerySV = new INVLotShipmentDistributeSVProxy();
            List<string> ids = new List<string>();
            if (bpObj.IDList.Count == 0)
            {
                return null;
            }
            foreach (var item in bpObj.IDList)
            {
                ids.Add(item.ToString());
            }
            var ms = MiscShipmentL.Finder.FindAll("ID in (" + string.Join(",", ids.ToArray()) + ")");
            //sv.IsCalToRetStQty = false;
            //sv.ShipmentLotQueryDTOList = new List<ShipmentLotQueryDTO>();

            foreach (var miscLine in ms)
            {
                List<ShipmentLotQueryDTOData> lotQueryDTOList = new List<ShipmentLotQueryDTOData>();
                ShipmentLotQueryDTOData lotQueryDTO = new ShipmentLotQueryDTOData();
                lotQueryDTO.ID = miscLine.ID;
                lotQueryDTO.ItemInfo = new CBO.SCM.Item.ItemInfoData();
                if (miscLine.ItemInfo != null)
                {
                    lotQueryDTO.ItemInfo.ItemID = miscLine.ItemInfo.ItemID.ID;
                    lotQueryDTO.ItemInfo.ItemCode = miscLine.ItemInfo.ItemCode;
                    lotQueryDTO.ItemInfo.ItemName = miscLine.ItemInfo.ItemName;
                }

                if (miscLine.Wh != null)
                    lotQueryDTO.Wh = miscLine.Wh.ID;
                lotQueryDTO.StoreQty = new UFIDA.U9.CBO.DTOs.SingleQuantityData();
                lotQueryDTO.StoreQty.UOM = new UFIDA.U9.CBO.DTOs.UOMInfoDTOData();
                lotQueryDTO.StoreQty.Amount = miscLine.StoreUOMQty;
                lotQueryDTO.StoreQty.UOM.UOMMain = miscLine.StoreUOM.ID;
                lotQueryDTO.StoreQty.UOM.UOMSub = miscLine.StoreBaseUOM.ID;
                lotQueryDTO.StoreQty.UOM.Rate = miscLine.SUToSBURate;
                lotQueryDTO.StorageType = miscLine.StoreType.Value;
                lotQueryDTO.BusinessDate = miscLine.MiscShip.BusinessDate;
                if (miscLine.CustomerInfo != null
                    && miscLine.Wh.OutboundType == OutboundTypeEnum.ConsignSell)
                    lotQueryDTO.Customer = Convert.ToInt64(miscLine.CustomerInfo.Customer);
                if (miscLine.SupplierInfo != null && miscLine.SupplierInfo.Supplier != null &&
                      (miscLine.IsVMI || miscLine.Wh.OutboundType == OutboundTypeEnum.SubcontractPart))
                    lotQueryDTO.Supplier = miscLine.SupplierInfo.Supplier.ID;
                if (miscLine.OwnerOrg != null)
                    lotQueryDTO.OwnedOrg = miscLine.OwnerOrg.ID;
                if (miscLine.Project != null)
                    lotQueryDTO.Project = miscLine.Project.ID;
                if (miscLine.Task != null)
                    lotQueryDTO.Task = miscLine.Task.ID;
                if (miscLine.ManufacturerInfo != null && miscLine.ManufacturerInfo.Supplier != null)
                    lotQueryDTO.Mfc = miscLine.ManufacturerInfo.Supplier.ID;
                if (miscLine.MiscShipBins != null && miscLine.MiscShipBins.Count > 0)
                {
                    if (miscLine.MiscShipBins[0].BinInfo != null && miscLine.MiscShipBins[0].BinInfo.Bin != null)
                    {
                        lotQueryDTO.Bin = miscLine.MiscShipBins[0].BinInfo.Bin.ID;
                    }
                }
                lotQueryDTOList.Add(lotQueryDTO);
                lotQuerySV.ShipmentLotQueryDTOList = lotQueryDTOList;
                List<ShipmentLotResultDTOData> resultDTOs = lotQuerySV.Do();

                var miscShipment = MiscShipment.Finder.FindByID(miscLine.MiscShip.ID);
                var lineNo = miscShipment.MiscShipLs.Count * 10;
                if (resultDTOs != null && resultDTOs.Count > 0)
                {
                    using (ISession session = Session.Open())
                    {
                        decimal patchNum = 0, storeUOMQty = miscLine.StoreUOMQty;
                        resultDTOs.ForEach(i => patchNum += i.DistributeQty.Amount);
                        ShipmentLotResultDTOData resultDTO0 = resultDTOs[0];
                        if (resultDTO0.LotInfo != null && resultDTO0.LotInfo.LotMaster != null)
                        {
                            if (miscLine.LotInfo == null)
                            {
                                miscLine.LotInfo = new LotMasterInfo();
                            }
                            miscLine.LotInfo.LotMaster = LotMaster.Finder.FindByID(resultDTO0.LotInfo.LotMaster.EntityID);
                            miscLine.LotInfo.LotCode = resultDTO0.LotInfo.LotCode;
                            miscLine.LotInfo.LotValidDate = resultDTO0.LotInfo.LotValidDate;
                            miscLine.StoreUOMQty = resultDTO0.DistributeQty.Amount;
                            miscLine.TradeUOMQty = miscLine.StoreUOMQty;
                            miscLine.CostUOMQty = miscLine.StoreUOMQty;

                        }
                        resultDTOs.RemoveAt(0);
                        if (resultDTOs.Count > 0)
                        {
                            foreach (ShipmentLotResultDTOData resultDTO in resultDTOs)
                            {
                                var line = MiscShipmentL.Create(miscShipment);
                                CopyLine(miscLine, line);
                                //miscLine.CopyTo(line);
                                lineNo+=10;
                                if (resultDTO.LotInfo != null && resultDTO.LotInfo.LotMaster != null)
                                {
                                    if (line.LotInfo == null)
                                    {
                                        line.LotInfo = new LotMasterInfo();
                                    }
                                    line.LotInfo.LotMaster = LotMaster.Finder.FindByID(resultDTO.LotInfo.LotMaster.EntityID);
                                    line.LotInfo.LotCode = resultDTO.LotInfo.LotCode;
                                    line.LotInfo.LotValidDate = resultDTO.LotInfo.LotValidDate;
                                    line.StoreUOMQty = resultDTO.DistributeQty.Amount;
                                    line.TradeUOMQty = line.StoreUOMQty;
                                    line.CostUOMQty = line.StoreUOMQty;
                                    line.DocLineNo = lineNo;
                                }
                            }
                        }
                        if (patchNum < storeUOMQty)//如果批号的发料数量小于，则新建一条出来
                        {
                            var line = MiscShipmentL.Create(miscShipment);
                            miscLine.CopyTo(line);
                            lineNo += 10;
                            line.StoreUOMQty = storeUOMQty - patchNum;
                            line.TradeUOMQty = line.StoreUOMQty;
                            line.CostUOMQty = line.StoreUOMQty;
                            line.DocLineNo = lineNo;
                        }
                        #region 单据行批号失效日期

                        //if (miscLine.LotInfo != null && miscLine.LotInfo.LotMaster != null && miscLine.LotInfo.LotCode != string.Empty
                        //    && miscLine.LotInfo.DisabledDatetime == DateTime.MinValue)
                        //{
                        //    int POVType = miscLine.ItemInfo.ItemID.InventoryInfo.LotParam.LotPOVType.Value;
                        //    //BUG :不控制时，失效日期 为  9999.12.31
                        //    if (POVType != (int)UFIDA.U9.CBO.SCM.Lot.LotPOVTypeEnumData.NoCharge)
                        //    {
                        //        GetLotInvalidDateSVProxy bp = new GetLotInvalidDateSVProxy();
                        //        List<LotInvalidDateDTOData> dtoList = new List<LotInvalidDateDTOData>();
                        //        LotInvalidDateDTOData dto = new LotInvalidDateDTOData();
                        //        dto.Item = miscLine.ItemInfo.ItemID.ID;
                        //        dto.ItemCode = miscLine.ItemInfo.ItemCode;
                        //        // dto.LotInfo = miscLine.LotInfo.ToEntityData();

                        //        dto.LotInfo.LotCode = miscLine.LotInfo.LotCode;
                        //        if (miscLine.LotInfo.LotMaster != null)
                        //        {
                        //            dto.LotInfo.LotMaster.EntityID = miscLine.LotInfo.LotMaster.ID;
                        //            dto.LotInfo.LotMaster.EntityType = "UFIDA.U9.Lot.LotMaster";
                        //        }
                        //        dto.Org = miscLine.Org.ID;

                        //        dtoList.Add(dto);
                        //        bp.LotInvalidDateDTOList = dtoList;
                        //        dtoList = bp.Do();
                        //        //得到失效日期
                        //        miscLine.LotInfo.LotValidDate = miscLine.LotInfo.LotValidDate;
                        //        double ValidData = Convert.ToDouble(miscLine.LotInfo.LotValidDate);
                        //        miscLine.LotInfo.DisabledDatetime = miscLine.MiscShip.BusinessDate.AddDays(ValidData);

                        //        if (dtoList != null && dtoList.Count > 0)
                        //        {
                        //            LotInvalidDateDTOData RtnDTO = dtoList[0];
                        //            if (RtnDTO.LotInfo != null && !RtnDTO.LotInfo.DisabledDatetime.Equals(DateTime.MinValue))
                        //                miscLine.LotInfo.DisabledDatetime = RtnDTO.LotInfo.DisabledDatetime;
                        //        }
                        //    }
                        //}
                        #endregion
                        session.Commit();
                    }
                }
            }
            return string.Empty;
        }

        private void CopyLine(MiscShipmentL miscLine, MiscShipmentL line)
        {
            line.AAIStatus = miscLine.AAIStatus;
            line.AssertCardNO = miscLine.AssertCardNO;
            line.AssetCardID = miscLine.AssetCardID;
            line.AssetCardQty = miscLine.AssetCardQty;
            line.Attribute = miscLine.Attribute;
            line.BalanceRoute = miscLine.BalanceRoute;
            line.BalanceRouteKey = miscLine.BalanceRouteKey;
            line.BatchBusinessExceptions = miscLine.BatchBusinessExceptions;
            line.BenefitBin = miscLine.BenefitBin;
            line.BenefitDept = miscLine.BenefitDept;
            line.BenefitDeptKey = miscLine.BenefitDeptKey;
            line.BenefitOrg = miscLine.BenefitOrg;
            line.BenefitOrgKey = miscLine.BenefitOrgKey;
            line.BenefitOwnerOrg = miscLine.BenefitOwnerOrg;
            line.BenefitOwnerOrgKey = miscLine.BenefitOwnerOrgKey;
            line.BenefitProject = miscLine.BenefitProject;
            line.BenefitProjectKey = miscLine.BenefitProjectKey;
            line.BenefitPsn = miscLine.BenefitPsn;
            line.BenefitPsnKey = miscLine.BenefitPsnKey;
            line.BenefitWh = miscLine.BenefitWh;
            line.BenefitWhKey = miscLine.BenefitWhKey;
            line.BOMLineNO = miscLine.BOMLineNO;
            line.CostBaseUOM = miscLine.CostBaseUOM;
            line.CostBaseUOMKey = miscLine.CostBaseUOMKey;
            line.CostMny = miscLine.CostMny;
            line.CostPrice = miscLine.CostPrice;
            line.CostUOM = miscLine.CostUOM;
            line.CostUOMKey = miscLine.CostUOMKey;
            line.CustomerInfo = miscLine.CustomerInfo;
            line.CUToCBURate = miscLine.CUToCBURate;
            line.HandleDept = miscLine.HandleDept;
            line.HandleDeptKey = miscLine.HandleDeptKey;
            line.HandlePsn = miscLine.HandlePsn;
            line.HandlePsnKey = miscLine.HandlePsnKey;
            line.IsComponentChanged = miscLine.IsComponentChanged;
            line.IsGernerTBD = miscLine.IsGernerTBD;
            line.IsGhost = miscLine.IsGhost;
            line.OwnerOrg = miscLine.OwnerOrg;
            line.OwnerOrgKey = miscLine.OwnerOrgKey;
            line.Seiban = miscLine.Seiban;
            line.SeibanCode = line.SeibanCode;
            line.SeibanKey = miscLine.SeibanKey;
            line.SMUToSMBURate = miscLine.SMUToSMBURate;
            line.SnCode = miscLine.SnCode;
            line.SobCurrency = miscLine.SobCurrency;
            line.SobCurrencyKey = miscLine.SobCurrencyKey;
            line.StoreBaseUOM = miscLine.StoreBaseUOM;
            line.StoreBaseUOMKey = miscLine.StoreBaseUOMKey;
            line.StoreMainUOM = miscLine.StoreMainUOM;
            line.StoreMainUOMKey = miscLine.StoreMainUOMKey;
            line.StoreMainUOMQty = miscLine.StoreMainUOMQty;
            line.StoreSubUOM = miscLine.StoreSubUOM;
            line.StoreSubUOMKey = miscLine.StoreSubUOMKey;
            line.StoreType = miscLine.StoreType;
            line.StoreUOM = miscLine.StoreUOM;
            line.StoreUOMKey = miscLine.StoreUOMKey;
            line.StoreUOMQty = miscLine.StoreUOMQty;
            line.SupplierInfo = miscLine.SupplierInfo;
            line.SUToCURate = miscLine.SUToCURate;
            line.SUToSBURate = miscLine.SUToSBURate;
            line.SUTOSMURate = miscLine.SUTOSMURate;
            line.Task = miscLine.Task;
            line.TaskKey = miscLine.TaskKey;
            line.TBUToCBURate = miscLine.TBUToCBURate;
            line.TBUToSBURate = miscLine.TBUToSBURate;
            line.TradeBaseUOM = miscLine.TradeBaseUOM;
            line.TradeBaseUOMKey = miscLine.TradeBaseUOMKey;
            line.TradeBaseUOMQty = miscLine.TradeBaseUOMQty;
            line.TradeUOM = miscLine.TradeUOM;
            line.TradeUOMKey = miscLine.TradeUOMKey;
            line.TradeUOMQty = miscLine.TradeUOMQty;
            line.TUToTBURate = miscLine.TUToTBURate;
            line.UseReturnMny = miscLine.UseReturnMny;
            line.VoucherID = miscLine.VoucherID;
            line.VoucherNo = miscLine.VoucherNo;
            line.VoucherTypeID = miscLine.VoucherTypeID;
            line.Wh = miscLine.Wh;
            line.IsVMI = miscLine.IsVMI;
            line.WhKey = miscLine.WhKey;
            line.WhMan = miscLine.WhMan;
            line.WhManKey = miscLine.WhManKey;
            line.WorkProcNo = miscLine.WorkProcNo;
            line.WorkProcNoEnity = miscLine.WorkProcNoEnity;
            line.WorkProcNoEnity_Key = miscLine.WorkProcNoEnity_Key;
            line.ItemInfo = miscLine.ItemInfo;
        }
    }

    #endregion


}