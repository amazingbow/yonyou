namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base.PropertyTypes;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.CBO.SCM.PropertyTypes;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.ISV.MiscRcvISV;
    using UFIDA.U9.ISV.MiscRcvISV.Proxy;
    using UFIDA.U9.ISV.MiscShipISV;
    using UFIDA.U9.ISV.MiscShipISV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.Log;

    /// <summary>
    /// MiscTranInProcessBP partial 
    /// </summary>	
    public partial class MiscTranInProcessBP
    {
        internal BaseStrategy Select()
        {
            return new MiscTranInProcessBPImpementStrategy();
        }
    }
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class MiscTranInProcessBPImpementStrategy : BaseStrategy
    {
        public MiscTranInProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            MiscTranInProcessBP bpObj = (MiscTranInProcessBP)obj;
            ILogger logger = LoggerManager.GetLogger(typeof(MiscTranInProcessBPImpementStrategy));
            //bpObj.RelationID
            List<IC_MiscRcvDTOData> ListmiscRcvDTO = new List<IC_MiscRcvDTOData>();//杂收单生单信息
            IC_MiscRcvDTOData miscRcvDTO = GenerateMiscRcv(bpObj);
            ListmiscRcvDTO.Add(miscRcvDTO);
            var pubResult = CreateMiscRcvDoc(ListmiscRcvDTO);
            return pubResult;
        }  
        private PublicReturnDTO CreateMiscRcvDoc(List<IC_MiscRcvDTOData> miscRcvDTO)
        {
            PublicReturnDTO pubResult = new PublicReturnDTO();
            List<CommonArchiveDataDTOData> apiRtnLst = new List<CommonArchiveDataDTOData>();
            #region 生成杂收单
            try
            {
                CommonCreateMiscRcvProxy createMiscRcvProxy = new CommonCreateMiscRcvProxy();
                createMiscRcvProxy.MiscRcvDTOList = new List<IC_MiscRcvDTOData>();
                createMiscRcvProxy.MiscRcvDTOList = miscRcvDTO;
                apiRtnLst = createMiscRcvProxy.Do();
                if (apiRtnLst.Count == 0) throw new Exception("根据所传数据生成杂收单数目为0");
                pubResult.DocID = apiRtnLst[0].ID;
                pubResult.DocNo = apiRtnLst[0].Code;
                pubResult.Flag = true;
                pubResult.Message = "创建杂收单成功！";
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message = "生成杂收单失败：" + ex.Message;
            }

            #endregion
            #region  审核杂收单
            try
            {
                CommonApproveMiscRcvProxy approveMiscRcvProxy = new CommonApproveMiscRcvProxy();
                approveMiscRcvProxy.MiscRcvKeys = apiRtnLst;
                approveMiscRcvProxy.Do();
                pubResult.Flag = true;
                pubResult.Message += "审核杂收单成功！";
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message = "审核杂收单失败：" + ex.Message;
            }
            #endregion
            return pubResult;
        }
        private IC_MiscRcvDTOData GenerateMiscRcv(MiscTranInProcessBP bpObj)
        {
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationID);
            #region  组织杂收单表头
            // 杂收单单头
            IC_MiscRcvDTOData miscRcvDTO = new IC_MiscRcvDTOData() { };
            // 组织
            miscRcvDTO.Org = new CommonArchiveDataDTOData(Base.Context.LoginOrg.ID, Base.Context.LoginOrg.Code, Base.Context.LoginOrg.Name);
            // 业务日期
            miscRcvDTO.BusinessDate = DateTime.Now;
            // 单据类型
            miscRcvDTO.MiscRcvDocType = new CommonArchiveDataDTOData() { };
            // 数据状态
            miscRcvDTO.SysState = UFSoft.UBF.PL.Engine.ObjectState.Inserted;
            // 描述
            miscRcvDTO.Memo = "本单据由进出仓明细主表[" + invStock.BillNO + "]自动生成";
            #endregion
            miscRcvDTO.MiscRcvTransLs = new List<IC_MiscRcvTransLsDTOData>();
            int mvRowNo = 0;
            int Seq = 0;
            foreach (var item in invStock.InvStocks)
            {
                IC_MiscRcvTransLsDTOData miscRcvLineDTO = new IC_MiscRcvTransLsDTOData { };
                mvRowNo += 10;
                Seq += 1;
                #region  组织杂收单表体
                // 料品
                miscRcvLineDTO.ItemInfo = new ItemInfoData()
                {
                    ItemID = item.ItemID.ID,
                    ItemCode = item.ItemID.Code,
                    ItemName = item.ItemID.Name
                };
                miscRcvLineDTO.IsZeroCost = true;
                // 单价
                miscRcvLineDTO.CostPrice = 0;
                // 类型  4:可用
                miscRcvLineDTO.StoreType = 4;
                // 库存主单位及数量
                //if (transferFormL.StoreUOM != null)
                //    miscRcvLineDTO.StoreUOM = new CommonArchiveDataDTOData(transferFormL.StoreUOM.ID, transferFormL.StoreUOM.Code, transferFormL.StoreUOM.Name);
                miscRcvLineDTO.StoreUOMQty = item.InQty;
                miscRcvLineDTO.Memo = item.ID.ToString();
                miscRcvLineDTO.DocLineNo = mvRowNo;
                //存储地点
                miscRcvLineDTO.Wh = new CommonArchiveDataDTOData
                {
                    Code = item.StockID.Code
                };
                //供应商
                miscRcvLineDTO.SupplierInfo = new SupplierMISCInfoData();
                //ItemInvInfo ItemInvInfo = bomHead.Item.InventoryInfo;//料品库存相关信息 


                miscRcvLineDTO.LotInfo = new LotInfoData();
                miscRcvLineDTO.LotInfo.LotMaster = new BizEntityKeyData();
                //miscRcvLineDTO.LotInfo.LotMaster.EntityID = lotMaster.ID;
                //miscRcvLineDTO.LotInfo.LotMaster.EntityType = lotMaster.Key.EntityType;
                //miscRcvLineDTO.LotInfo.LotCode = lotMaster.LotCode;
                //受益组织
                //miscRcvLineDTO.BenefitOrg = Base.Context.LoginOrg.ID;
                //受益货主组织
                miscRcvLineDTO.BenefitOwnerOrg = Base.Context.LoginOrg.ID;
                //受益存储地点
                //miscRcvLineDTO.BenefitWh = bomHead.WareHouse.ID;
                //miscRcvDTO.MiscRcvTransLs.Add(miscRcvLineDTO);


                //生产相关
                miscRcvLineDTO.IsMFG = true;

                //生产订单号
                var mo = MO.MO.MO.Finder.FindByID(bpObj.ProductionID);
                miscRcvLineDTO.MoDocNo = mo.DocNo;
                miscRcvLineDTO.MoDocEntity = bpObj.ProductionID;

                miscRcvLineDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
                miscRcvLineDTO.BenefitProject = new CommonArchiveDataDTOData { Code = item.SCPO.Code };
                miscRcvLineDTO.Project = new CommonArchiveDataDTOData { Code = item.SCPO.Code };

                #endregion
                miscRcvDTO.MiscRcvTransLs.Add(miscRcvLineDTO);
            }
            return miscRcvDTO;
        }
    }
}