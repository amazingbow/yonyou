namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using pMakReqOrderBE;
    using PublicDataTransObj;
    using SCPOBE;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.CBO.MFG.CO;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.ISV.MO;
    using UFIDA.U9.ISV.MO.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// ProductionOrderImportProcessBP partial 
    /// </summary>	
    public partial class ProductionOrderImportProcessBP
    {
        internal BaseStrategy Select()
        {
            return new ProductionOrderImportProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ProductionOrderImportProcessBPImpementStrategy : BaseStrategy
    {
        public ProductionOrderImportProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ProductionOrderImportProcessBP bpObj = (ProductionOrderImportProcessBP)obj;
            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            CreateMO4ExternalProxy createProxy = new CreateMO4ExternalProxy();
            createProxy.MODTOs = new List<MODTOData>();

            try
            {
                MODTOData moDto = GetMoInfo(bpObj.RelationId);
                createProxy.MODTOs.Add(moDto);
                var data = createProxy.Do();
                if (data.Count == 0) return pub;
                pub.DocID = data[0].ID;
                pub.DocNo = data[0].DocNo;
                ApproveMoProxy approveProxy = new ApproveMoProxy();
                approveProxy.MOOperateParamDTOs = new List<MOOperateParamDTOData>();
                MOOperateParamDTOData appData = new MOOperateParamDTOData
                {
                    MODocNo = pub.DocNo,
                    OperateBy = Context.LoginUser,
                    OperateOn = DateTime.Now,
                    OperateQty = moDto.MRPQty,
                    Org = new CBO.Pub.Controller.CommonArchiveDataDTOData { ID = Context.LoginOrg.ID, Code = Context.LoginOrg.Code, Name = Context.LoginOrg.Name }
                };
                approveProxy.MOOperateParamDTOs.Add(appData);
                var appResult = approveProxy.Do();
                StartMoProxy startMoProxy = new StartMoProxy();
                startMoProxy.MOOperateParamDTOs = new List<MOOperateParamDTOData>();
                startMoProxy.MOOperateParamDTOs.Add(appData);
                var startResult = startMoProxy.Do();
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = ex.Message;
            }
            return pub;
        }


        private MODTOData GetMoInfo(long RelationId)
        {
            PMakReqOrder order = PMakReqOrder.Finder.FindByID(RelationId);
            MODTOData moDto = new MODTOData();
            moDto.ActualStartDate = order.ReceiveDate;//业务开始时间
            //moDto.AlternateType = 0;//生产目的
            ////moDto.BOMECONo//BOMECONo  BOM变更号 
            //moDto.BOMEffDate = DateTime.MaxValue;//BOMEffeDate  BOM有效日期  
            //moDto.BOMType = 0;//BOM类型，0是自制，默认自制
            //moDto.BOMVersion = new CBO.Pub.Controller.CommonArchiveDataDTOData();
            moDto.BusinessPerson = new CommonArchiveDataDTOData
            {
                ID = order.COperator.ID,
                Code = order.COperator.Code,
                Name = order.COperator.Name
            }; // 业务员  
            moDto.CompleteDate = order.DeliverDate;

            //moDto.CUD//暂时不知道是什么东西
            //moDto.DemandCode = 0;//需求分类
            moDto.Department = new CommonArchiveDataDTOData
            {
                Code = order.Department.Code,
                Name = order.Department.Name
            };//生产部门
            moDto.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
            moDto.DocNo = order.MakReq;
            moDto.DocType = new CommonArchiveDataDTOData
            {
                Code = "",
                Name = ""
            };
            moDto.ExpandLevel = 2;
            //moDto.IsCapacityLimit
            //moDto.IsFirmed
            moDto.ItemMaster = new CommonArchiveDataDTOData
            {
                Code = order.ItemID.Code,
                Name = order.ItemID.Name
            };
            //moDto.ItemVersion
            moDto.MOOperationDTOs = new List<MOOperationDTOData>();
            moDto.MOPickListDTOs = new List<MOPickListDTOData>();
            //moDto.MOSourceDocType
            moDto.MOSrcRelationDTOs = new List<MOSrcRelationDTOData>();
            moDto.MRPQty = (decimal)order.Qty;
            moDto.Org = new CommonArchiveDataDTOData
            {
                ID = order.Org
            };
            moDto.OwnerOrg = new CommonArchiveDataDTOData
            {
                ID = order.Org
            };
            //moDto.Priority
            //moDto.ProductLotMaster
            //moDto.ProductLotNo
            moDto.ProductQty = (decimal)order.Qty;
            moDto.ProductUOM = new CommonArchiveDataDTOData
            {
                Code = order.ProductUOM.Code,
                Name = order.ProductUOM.Name,
            };
            moDto.Project = new CommonArchiveDataDTOData
            {
                Code = order.SCPOID.Code,//SCPOBE.SCPO
                Name = order.SCPOID.Name
            };
            //moDto.RoutingAlternate = 0;
            //moDto.RoutingECONo = "";
            //moDto.RoutingEffeDate
            //moDto.RoutingVer
            //moDto.SCVBin
            Organization org = Organization.Finder.FindByID(order.SCVWh.OrgID);
            Warehouse wh = Warehouse.FindByCode(org, order.SCVWh.Code);
            moDto.SCVWh = new CommonArchiveDataDTOData
            {
                Code = wh.Code,
                Name = wh.Name,
                ID = wh.ID
            };
            CostFieldObject costFieldObject = CostFieldObject.Finder.Find("Warehouse=" + wh.ID);
            moDto.CostField = new CommonArchiveDataDTOData
            {
                Code = costFieldObject.CostField.Code,
                Name = costFieldObject.CostField.Name,
                ID = costFieldObject.CostField.ID
            };//根据入库仓库带出
            //moDto.Seiban
            //moDto.SnList = new List<string>();
            moDto.StartDate = order.ReceiveDate;
            //moDto.Task 
            return moDto;
        }
    }

    #endregion


}