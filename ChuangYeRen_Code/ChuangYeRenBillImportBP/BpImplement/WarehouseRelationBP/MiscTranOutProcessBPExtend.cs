namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.ISV.MiscShipISV;
    using UFIDA.U9.ISV.MiscShipISV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// MiscTranOutProcessBP partial 
    /// </summary>	
    public partial class MiscTranOutProcessBP
    {
        internal BaseStrategy Select()
        {
            return new MiscTranOutProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class MiscTranOutProcessBPImpementStrategy : BaseStrategy
    {
        public MiscTranOutProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            MiscTranOutProcessBP bpObj = (MiscTranOutProcessBP)obj;
            //bpObj.RelationID
            List<IC_MiscShipmentDTOData> ListmiscRcvDTO = new List<IC_MiscShipmentDTOData>();//杂收单生单信息
            IC_MiscShipmentDTOData miscRcvDTO = GetHeadInfoData(bpObj);
            ListmiscRcvDTO.Add(miscRcvDTO);
            var pubResult = CreateMiscShipMent(ListmiscRcvDTO);
            return pubResult;
        }
        #region 生成杂发单
        private PublicReturnDTO CreateMiscShipMent(List<IC_MiscShipmentDTOData> callERPApiInputParamLst)
        {
            PublicReturnDTO pubResult = new PublicReturnDTO();
            List<CommonArchiveDataDTOData> apiRtnLst = new List<CommonArchiveDataDTOData>();
            #region 调用标准产品API进行推单处理
            try
            {
                CommonCreateMiscShipProxy createMiscShipProxy = new CommonCreateMiscShipProxy();
                createMiscShipProxy.TargetOrgName = null;
                createMiscShipProxy.MiscShipmentDTOList = new List<IC_MiscShipmentDTOData>();
                createMiscShipProxy.MiscShipmentDTOList = callERPApiInputParamLst;
                apiRtnLst = createMiscShipProxy.Do();
                if (apiRtnLst.Count == 0) throw new Exception("未查询到数据!");
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message = "生成杂发单失败：" + ex.Message;
            }
            // 审核杂发单
            try
            {
                CommonApproveMiscShipSVProxy approveMiscShipSVProxy = new CommonApproveMiscShipSVProxy();
                approveMiscShipSVProxy.MiscShipmentKeyList = apiRtnLst;
                approveMiscShipSVProxy.Do();
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message = "审核杂发单失败：" + ex.Message;
            }
            #endregion
            return pubResult;
        }

        /// <summary>
        /// 杂发单头信息
        /// </summary>
        /// <returns></returns>
        private IC_MiscShipmentDTOData GetHeadInfoData(MiscTranOutProcessBP bpObj)
        {
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationID);
            //List<IC_MiscShipmentDTOData> callERPApiInputParamLst = new List<IC_MiscShipmentDTOData>();
            IC_MiscShipmentDTOData inputMiscShipmentDTO;
            #region 做成杂发单表头
            inputMiscShipmentDTO = new IC_MiscShipmentDTOData();
            //组织
            inputMiscShipmentDTO.Org = new CommonArchiveDataDTOData(Base.Context.LoginOrg.ID, Base.Context.LoginOrg.Code, Base.Context.LoginOrg.Name);
            //业务日期
            inputMiscShipmentDTO.BusinessDate = DateTime.Today;
            //inputMiscShipmentDTO.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
            //单据类型
            inputMiscShipmentDTO.MiscShipDocType = new CommonArchiveDataDTOData();
            // 数据状态
            inputMiscShipmentDTO.SysState = UFSoft.UBF.PL.Engine.ObjectState.Inserted;
            // 描述
            inputMiscShipmentDTO.Memo = "本单据由进出仓明细主表[" + invStock.BillNO + "]自动生成";
            inputMiscShipmentDTO.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
            #endregion
            #region 做成杂发单表体
            int mvRowNo = 0;
            int Seq = 0;
            foreach (var item in invStock.InvStocks)
            {
                mvRowNo += 10;
                Seq += 1;
                IC_MiscShipmentLDTOData inputMiscShipmentLineDTO = new IC_MiscShipmentLDTOData();
                //料品
                inputMiscShipmentLineDTO.ItemInfo = new UFIDA.U9.CBO.SCM.Item.ItemInfoData();
                inputMiscShipmentLineDTO.ItemInfo.ItemCode = item.ItemID.Code;
                inputMiscShipmentLineDTO.ItemInfo.ItemName = item.ItemID.Name;
                //供应商
                inputMiscShipmentLineDTO.SupplierInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
                //inputMiscShipmentLineDTO.SupplierInfo.Supplier = Supplier;
                //inputMiscShipmentLineDTO.SupplierInfo.Code = SupplierCode;
                //inputMiscShipmentLineDTO.SupplierInfo.Name = SupplierName;
                //inputMiscShipmentLineDTO.SupplierInfo.ShortName = SupplierShortName;
                //批号
                //inputMiscShipmentLineDTO.LotInfo = new UFIDA.U9.CBO.SCM.PropertyTypes.LotInfoData();
                //inputMiscShipmentLineDTO.LotInfo.LotMaster = new UFIDA.U9.Base.PropertyTypes.BizEntityKeyData();
                //inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityID = lotMaster.ID;
                //inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityType = lotMaster.Key.EntityType;
                //inputMiscShipmentLineDTO.LotInfo.LotCode = lotMaster.LotCode;

                //inputMiscShipmentLineDTO.StoreType = 4;

                inputMiscShipmentLineDTO.DocLineNo = mvRowNo;
                //inputMiscShipmentLineDTO.BOMLineNO = msRowNo.ToString();

                inputMiscShipmentLineDTO.StoreUOMQty = item.OutQty;
                inputMiscShipmentLineDTO.Memo = "";
                ////单价
                //inputMiscShipmentLineDTO.CostPrice = subItemIssueLine.Univalence;
                //存储地点

                inputMiscShipmentLineDTO.Wh = new CommonArchiveDataDTOData { Code =item.StockID.Code };
                //受益存储地点
                //inputMiscShipmentLineDTO.BenefitWh = WareHouse;

                //受益组织
                inputMiscShipmentLineDTO.BenefitOrg = Base.Context.LoginOrg.ID;
                //受益货主组织
                inputMiscShipmentLineDTO.BenefitOwnerOrg = Base.Context.LoginOrg.ID;
                inputMiscShipmentLineDTO.BenefitProject = new CommonArchiveDataDTOData { Code = item.SCPO.Code };
                inputMiscShipmentLineDTO.Project = new CommonArchiveDataDTOData { Code = item.SCPO.Code };
                //生产相关
                inputMiscShipmentLineDTO.IsMFG = true;
                //生产订单号
                //inputMiscShipmentLineDTO.MoDocNo = MoDocNo;
                //inputMiscShipmentLineDTO.MoDocEntity = MoID;
            }
            #endregion
            return inputMiscShipmentDTO;
        }
        #endregion
    }

    #endregion


}