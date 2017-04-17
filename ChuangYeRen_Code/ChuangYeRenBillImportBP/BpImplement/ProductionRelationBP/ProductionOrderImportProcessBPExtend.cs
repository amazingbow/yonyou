namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using pMakReqOrderBE;
    using SCPOBE;
    using System;
    using System.Collections.Generic;
    using System.Text;
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

            CreateMO4ExternalProxy createProxy = new CreateMO4ExternalProxy();
            createProxy.MODTOs = new List<MODTOData>();

            try
            {
                MODTOData moDto = GetMoInfo(bpObj.RelationId);
                createProxy.MODTOs.Add(moDto);
                createProxy.Do();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private MODTOData GetMoInfo(long RelationId)
        {
            PMakReqOrder order = PMakReqOrder.Finder.FindByID(RelationId);
            MODTOData moDto = new MODTOData();
            //moDto.ActualStartDate//业务开始时间
            moDto.AlternateType = 0;//生产目的
            //moDto.BOMECONo//BOMECONo  BOM变更号 
            //moDto.BOMEffDate//BOMEffeDate  BOM有效日期  
            moDto.BOMType = 0;//BOM类型，0是自制，默认自制
            //moDto.BOMVersion
            moDto.BusinessPerson = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData
            {
                ID = order.COperator.ID,
                Code = order.COperator.Code,
                Name = order.COperator.Name
            }; // 业务员  
            //moDto.CompleteDate
            //moDto.CostField
            //moDto.CUD//暂时不知道是什么东西
            moDto.DemandCode = 0;//需求分类
            //moDto.Department//生产部门
            moDto.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
            moDto.Description = "";
            moDto.DocNo = "";
            moDto.DocType = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData
            {
                Code = "",//SCPOBE.SCPO
                Name = ""
            };
            //moDto.ExpandLevel
            //moDto.IsCapacityLimit
            //moDto.IsFirmed
            //moDto.ItemMaster
            //moDto.ItemVersion
            moDto.MOOperationDTOs = new List<MOOperationDTOData>();
            moDto.MOPickListDTOs = new List<MOPickListDTOData>();
            //moDto.MOSourceDocType
            moDto.MOSrcRelationDTOs = new List<MOSrcRelationDTOData>();
            moDto.MRPQty = 0;
            //moDto.Org
            //moDto.OwnerOrg
            //moDto.Priority
            //moDto.ProductLotMaster
            //moDto.ProductLotNo
            //moDto.ProductQty
            //moDto.ProductUOM
            moDto.Project = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData
            {
                Code = order.SCPOID.Code,//SCPOBE.SCPO
                Name = order.SCPOID.Name
            };
            moDto.RoutingAlternate = 0;
            moDto.RoutingECONo = "";
            //moDto.RoutingEffeDate
            //moDto.RoutingVer
            //moDto.SCVBin
            //moDto.SCVWh=
            //moDto.Seiban
            moDto.SnList = new List<string>();
            moDto.StartDate = DateTime.MinValue;
            moDto.Task = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData
            {
                Code = "",//SCPOBE.SCPO
                Name = ""
            };
            return moDto;
        }
    }

    #endregion


}