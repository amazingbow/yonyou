namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.CBO.HR.Department;
    using UFIDA.U9.CBO.MFG.CO;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.Complete.RCVRpt;
    using UFIDA.U9.Complete.RcvRptBP.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.Log;

    /// <summary>
    /// ProductionInWarehouseBP partial 
    /// </summary>	
    public partial class ProductionInWarehouseBP
    {
        internal BaseStrategy Select()
        {
            return new ProductionInWarehouseBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ProductionInWarehouseBPImpementStrategy : BaseStrategy
    {
        public ProductionInWarehouseBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ProductionInWarehouseBP bpObj = (ProductionInWarehouseBP)obj;
            ILogger logger = LoggerManager.GetLogger(typeof(MiscTranInProcessBPImpementStrategy));
            //bpObj.RelationID

            var pubResult = CreateRcvRpt(bpObj);
            return pubResult;
        }

        private PublicReturnDTO CreateRcvRpt(ProductionInWarehouseBP bpObj)
        {
            PublicReturnDTO pub = new PublicReturnDTO();
            Complete.RcvRptBP.RcvRptInfoDTOData result = new Complete.RcvRptBP.RcvRptInfoDTOData();
            #region 创建成品入库单
            try
            {
                CreateRcvRptProxy rcvRptProxy = new CreateRcvRptProxy();
                PrepareProxyInfo(rcvRptProxy, bpObj);

                result = rcvRptProxy.Do();
                if (!string.IsNullOrEmpty(result.ErrMessage))
                {
                    throw new Exception(result.ErrMessage);
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = "创建成品入库单失败：" + ex.Message;
                return pub;
            }
            #endregion
            #region 审核成品入库单
            try
            {
                ApproveRcvRptProxy rcvRptProxy = new ApproveRcvRptProxy();
                rcvRptProxy.IsAutoApproved = true;
                rcvRptProxy.RcvRptDocKey = result.RcvRptKey;
                rcvRptProxy.Do();
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message += "审核成品入库单失败：" + ex.Message;
                return pub;
            }
            #endregion
            return pub;
        }

        private void PrepareProxyInfo(CreateRcvRptProxy rcvRptProxy, ProductionInWarehouseBP bpObj)
        {
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationId);
            Department dept = Department.FindByCode(invStock.DeptID.Code2);
            rcvRptProxy.RcvRpt = new RcvRptDocData
            {
                ActualRcvTime = invStock.BillDate,
                //ApproveBy=Context.LoginUser,
                //ApproveOn=DateTime.Now,
                BusinessCreatedOn = DateTime.Now,
                BusinessCreatedBy = long.Parse(Context.LoginUserID),
                BusinessDate = invStock.BillDate,
                CreatedBy = Context.LoginUser,
                CreatedOn = DateTime.Now,
                Direction = 0,//收发类型：0 入库，1 出库
                DocDate = DateTime.Now,
                //DocState=1
                DocNo = invStock.BillNO,
                //FlowInstance
                //HoldDate
                IsReWriteCompleteQty = false,
                IsHoldRelease = false,
                RcvOrg = invStock.OrgID,
                //RcvPerson=invStock.
                Remark = "导入：" + invStock.BillNO,
            };
         
            var type = RcvRptDocType.Finder.Find("Code='W01'");
            if (type != null )
            {
                rcvRptProxy.RcvRpt.RcvRptDocType = type.ID;
            }
            //rcvRptProxy.RcvRpt.RcvRptDocType
            if (dept != null)
            {
                rcvRptProxy.RcvRpt.RcvDep = dept.ID;
            }
            rcvRptProxy.RcvRptLines = new List<RcvRptDocLineData>();
            foreach (var item in invStock.InvStocks)
            {
                //Organization org = Organization.Finder.FindByID(order.SCVWh.Org.ID);
                //Warehouse wh = Warehouse.FindByCode(org, order.SCVWh.Code);
                //moDto.SCVWh = new CommonArchiveDataDTOData
                //{
                //    Code = wh.Code,
                //    Name = wh.Name,
                //    ID = wh.ID
                //};
                //CostFieldObject costFieldObject = CostFieldObject.Finder.Find("Warehouse=" + wh.ID);
                //moDto.CostField = new CommonArchiveDataDTOData
                //{
                //    Code = costFieldObject.CostField.Code,
                //    Name = costFieldObject.CostField.Name,
                //    ID = costFieldObject.CostField.ID
                //};//根据入库仓库带出
                //Currency currency = Currency.FindByCode();
                Organization org = Organization.Finder.FindByID(invStock.OrgID);
                Warehouse wh = Warehouse.FindByCode(org, item.StockID.Code);
               
                Project project = Project.FindByCode(item.SCPO.Code);
                RcvRptDocLineData line = new RcvRptDocLineData
                {
                    AAIFlag = false,
                    Cost = 0,
                    CostBaseUOM = 0,
                    CostPercent = 0,
                    CoUOM = 0,
                    Currency = item.Currency.ID,
                    Element = 0,
                    Grade = 0,
                    Item = ItemMaster.Finder.Find("Code='" + item.ItemID.Code + "'").ID,
                    MO = bpObj.MoId,//生产订单ID
                    OwnerOrg = invStock.OrgID,

                };
                if (wh != null)
                {
                    line.Wh = wh.ID;
                    CostFieldObject costFieldObject = CostFieldObject.Finder.Find("Warehouse=" + wh.ID);
                    if (costFieldObject != null)
                    {
                        line.CostField = costFieldObject.ID;
                    }
                }
                if (project != null)
                {
                    line.Project = project.ID;
                }
            
            }
        }
    }

    #endregion


}