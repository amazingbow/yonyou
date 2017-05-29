namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using pMakReqOrderBE;
    using PublicDataTransObj;
    using SCPOBE;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.FlexField.KeyFlexField;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.CBO.MFG.BOM;
    using UFIDA.U9.CBO.MFG.BOM.Proxy;
    using UFIDA.U9.CBO.MFG.CO;
    using UFIDA.U9.CBO.MFG.Enums;
    using UFIDA.U9.CBO.MFG.Routing;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.ISV.MO;
    using UFIDA.U9.ISV.MO.Proxy;
    using UFIDA.U9.MO.MO;
    using UFIDA.U9.MO.MO.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context; 
    using pMakGydGyBE;
    using pMakBomBE;
    using System.Collections;
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
            createProxy.MODTOs = new List<ISV.MO.MODTOData>();
            PMakReqOrder order = PMakReqOrder.Finder.FindByID(bpObj.RelationId);
        
            ISV.MO.MODTOData moDto = GetMoInfo(order);

            MO P = MO.Finder.Find("Org=" + Context.LoginOrg.ID.ToString() + " and DocNo='" + order.MakReq + "'");
          
            if (P == null)
            {
                #region 生产订单创建
                try
                {
                    createProxy.MODTOs.Add(moDto);
                    var data = createProxy.Do();
                    if (data.Count == 0) return pub;
                    if (data[0].ID == 0)
                    {
                        throw new Exception(data[0].ErrMsg);
                    }
                    pub.DocID = data[0].ID;
                    CyrLibH.DB.RunSQL("update PMakReqOrder set U9ID='" + data[0].ID + "' where ID ='"+bpObj.RelationId+"'");
                    pub.DocNo = data[0].DocNo;
                    pub.Message = "生产订单创建成功！";
                    pub.Flag = true;
                    AddStdOperation(pub.DocID, order);
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message = "生产订单创建失败：" + ex.Message;
                    return pub;
                }
            #endregion
                #region 生产订单提交
                try
                {
                    BatchSubmitMOProxy submitProxy = new BatchSubmitMOProxy();
                    submitProxy.MOs = new List<BatchOperationDTOData>();
                    BatchOperationDTOData submit = new BatchOperationDTOData
                    {
                        ID = pub.DocID
                    };
                    submitProxy.MOs.Add(submit);
                    submitProxy.Do();
                    pub.Message += "生产订单提交成功！";
                    pub.Flag = true;
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message += "生产订单提交失败：" + ex.Message;
                    return pub;
                }
                #endregion

                MOOperateParamDTOData appData = new MOOperateParamDTOData
                {
                    MODocNo = pub.DocNo,
                    OperateBy = Context.LoginUser,
                    OperateOn = DateTime.Now,
                    OperateQty = moDto.MRPQty,
                    OperateType = true,//false 反开工
                    Org = new CBO.Pub.Controller.CommonArchiveDataDTOData { ID = Context.LoginOrg.ID, Code = Context.LoginOrg.Code, Name = Context.LoginOrg.Name }
                };

                #region 生产订单审核
                try
                {
                    ApproveMoProxy approveProxy = new ApproveMoProxy();
                    approveProxy.MOOperateParamDTOs = new List<MOOperateParamDTOData>();
                    approveProxy.MOOperateParamDTOs.Add(appData);
                    var appResult = approveProxy.Do();
                    pub.Message += "生产订单审核成功！";
                    pub.Flag = true;
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message += "生产订单审核失败：" + ex.Message;
                    return pub;
                }
                #endregion
                #region 生产订单开工
                try
                {
                    StartMoProxy startMoProxy = new StartMoProxy();
                    startMoProxy.MOOperateParamDTOs = new List<MOOperateParamDTOData>();
                    startMoProxy.MOOperateParamDTOs.Add(appData);
                    var startResult = startMoProxy.Do();
                    pub.Message += "生产订单开工成功！";
                    pub.Flag = true;
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message += "生产订单开工失败：" + ex.Message;
                }
                #endregion
            }
            return pub;
        }

        private void AddStdOperation(long p, PMakReqOrder order)
        {
            //item.WPID.Code
            using (ISession session = Session.Open())
            {
                MO mo = MO.Finder.FindByID(p);
                if (mo == null) return;
                foreach (var item in mo.MOOperations)
                {
                    foreach (var pm in order.GydID.PMakgydGy)
                    { 
                        if (pm.PX.ToString() == item.OperationNum)
                        {
                            StdOperation std = StdOperation.Finder.Find("Code='" + pm.WPID.Code + "'");
                            item.StdOp = std;
                        }
                    }
                }
                session.Commit();
            }
        }
        private ISV.MO.MODTOData GetMoInfo(PMakReqOrder order)
        {
            ISV.MO.MODTOData moDto = new ISV.MO.MODTOData(); 
            moDto.StartDate = (order.ReceiveDate <= DateTime.Parse("2015-1-1") ? DateTime.Parse("2015-1-1") : order.ReceiveDate);//业务开始时间
            //moDto.AlternateType = 0;//生产目的
            ////moDto.BOMECONo//BOMECONo  BOM变更号 
            //moDto.BOMEffDate = DateTime.MaxValue;//BOMEffeDate  BOM有效日期  
            //moDto.BOMType = 0;//BOM类型，0是自制，默认自制
            //moDto.BOMVersion = new CBO.Pub.Controller.CommonArchiveDataDTOData();
            string ProjectCode = "";
            if (order.SCPOID == null)
                ProjectCode = order.MakReq;
            else
                ProjectCode = order.SCPOID.Code;
            moDto.Project = new CommonArchiveDataDTOData
            {
                Code = ProjectCode
            };
          
            moDto.CompleteDate = (order.DeliverDate <= DateTime.Parse("2015-10-1") ? DateTime.Parse("2015-10-1") : order.DeliverDate); 
            //moDto.CUD//暂时不知道是什么东西
            moDto.DemandCode = -1;//需求分类
            moDto.Department = new CommonArchiveDataDTOData
            {
                Code = order.Department.Code,
                Name = order.Department.Name
            };//生产部门
            moDto.BusinessPerson = new CommonArchiveDataDTOData // 业务员 不填，会出现指定的业务员与生产部门不匹配 
            {
               // ID =long.Parse("9")// order.COperator.ID,
                Code =order.Department.DescFlexField.PrivateDescSeg2,
              //  Name = order.COperator.Name
            };
            moDto.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
            moDto.DocNo = order.MakReq;
            moDto.DocType = new CommonArchiveDataDTOData
            {
                Code = order.DocType.Code,
                Name = order.DocType.Name
            };
            moDto.ExpandLevel = 0;
            moDto.ItemMaster = new CommonArchiveDataDTOData
            {
                Code = order.ItemID.Code,
                Name = order.ItemID.Name
            };
            //moDto.ItemVersion
            moDto.MOOperationDTOs = new List<MOOperationDTOData>();
            if (order.GydID != null)
            {
                #region 工序表
                if (order.GydID != null)
                {
                    Hashtable hPx= new Hashtable();
                    foreach (var item in order.GydID.PMakgydGy)
                    {
                        if (!(hPx.ContainsKey(item.PX)))
                        {
                            hPx.Add(item.PX, item.PX);
                            MOOperationDTOData op = new MOOperationDTOData();
                            //op.ActualIdleHours = 0;
                            //op.ActualPrepareHours = item.ActualPrepareHours;
                            //op.ActualProcessHours = item.ActualProcessHours;
                            //op.Coeffecient = item.Coeffecient;
                            op.CompleteWh = new CommonArchiveDataDTOData();
                            op.TimeUOM = new CommonArchiveDataDTOData { Code = order.ItemID.UOM.Code };
                            op.OpOrg = new CommonArchiveDataDTOData { ID = order.Org };
                            op.StdOp = new CommonArchiveDataDTOData { Code = item.WPID.Code };
                            op.WorkCenter = new CommonArchiveDataDTOData { Code = order.Department.Code };
                            op.IsAutoCreate = true;
                            op.DispatchQty = item.Qty;//订单量
                            op.CompleteBin = new CommonArchiveDataDTOData();
                            op.OperationNum = item.PX.ToString();//工序号
                            op.OpDescription = item.WPID.Name;
                            op.NextOperation = new CommonArchiveDataDTOData();//下道序 
                            op.Operation = new CommonArchiveDataDTOData();//工序
                            op.OpMaxTransTime = 0;//本序最大转移时间
                            op.OpMinTransTime = 0;// 本序最小转移时间 
                            op.OutputBaseUOM = new CommonArchiveDataDTOData { Code = order.ItemID.UOM.Code };//工序产出副单位 
                            op.OutputUOM = new CommonArchiveDataDTOData { Code = order.ItemID.UOM.Code };//工序产出单位 
                            op.OutputUOMRatio2Base = 0;//产出单位主副转换率 
                            op.OutputUOMRatio2PU = 0;//产出单位与生产单位转换率
                            op.OverlapOp = "";//重叠工序
                            op.OverlapPercent = 0;//重叠比例
                            op.PlanCompleteDate = (order.DeliverDate <= DateTime.Parse("2015-10-1") ? DateTime.Parse("2015-10-1") : order.DeliverDate);// 计划完工日期  
                            op.PlanPrepareHours = 0;//计划准备工时 
                            op.PlanProcessHours = 0;// 计划加工工时  
                            //op.PlanProductQty = item.FQty;//计划生产数量 
                            op.PlanStartDate = (order.ReceiveDate <= DateTime.Parse("2015-1-1") ? DateTime.Parse("2015-1-1") : order.ReceiveDate);//计划开始时间
                            op.PreOpMaxTransTime = 0;//前序最大转移时间
                            op.PreOpMinTransTime = 0;// 前序最小转移时间  
                            op.QCSchemeVer = null;
                            op.RatedPrepareHours = 0;//额定准备工时
                            op.RatedProcessHours = 0;// 额定加工工时  
                            op.RejectQty = 0;//拒绝数量 
                            op.ReworkQty = 0;// 返工数量 
                            op.StartInWholeSet = false;//开工齐套 
                            op.SubInINVQty = 0;//期初委外在库量
                            //op.TotalProcessQty = item.FQty;
                            op.TotalQueueQty = 0;
                            op.TotalScrapQty = 0;
                            op.TransferringQty = 0;
                            op.UrgentRatio = 0;
                            op.WIPRcvQty = 0;//半成品入库数量
                            moDto.MOOperationDTOs.Add(op);
                        } 
                    }
                }
                #endregion
                #region 备料表
                int lineNo = 0;
                var makbom = PMakBom.Finder.FindAll("MakReqID='"+order.ID+"'");
                foreach(var item in makbom)
                //foreach (var item in order.GydID.PMakgydBom)
                {
                    lineNo += 10;
                    MOPickListDTOData moPick = new MOPickListDTOData();
                    moPick.DocLineNo = lineNo;
                    moPick.MO = new CommonArchiveDataDTOData { };
                    moPick.IsControlPos = false;
                    moPick.IsControlSupplier = false;
                    //moPick.IsIssueOrgFixed = false;//特定供应组织 
                    moPick.IsCalcCost = true;//计算成本
                    moPick.CostElement = new CommonArchiveDataDTOData { Code = "No101" };//成本要素
                    moPick.SupplyStyle = 0;//0生产组织
                    moPick.ConsignProcessItemSrc = 2;// 受托方领料  2  
                    moPick.IssueStyle = 0; 
                    moPick.FromElement = -1;
                    moPick.ToElement = -1;
                    moPick.FromGrade = -1;
                    moPick.ToGrade = -1; 
                    
                    var pmLst = PMakgydGy.Finder.FindAll("PMakGyd=" +order.GydID.ID + " and Dept=" + item.Dept.ID);
                    short opNum = 0;
                    foreach (var pm in pmLst)
                    {
                        if (opNum < pm.PX)
                        {
                            opNum = pm.PX;
                        }
                    } 
                    moPick.OperationNum = opNum.ToString();//取最大工序
                    moPick.ItemMaster = new CommonArchiveDataDTOData { Code = item.ItemID.Code };
                    moPick.ActualReqDate = (order.ReceiveDate <= DateTime.Parse("2015-1-1") ? DateTime.Parse("2015-1-1") : order.ReceiveDate); 
                    moPick.ActualReqQty = (decimal)item.FQty;
                    moPick.QPA = item.FQty / (decimal)order.Qty;
                    moPick.QtyType = 1;//变动
                    moDto.MOPickListDTOs.Add(moPick);
                }
                #endregion
            }
            moDto.MOSrcRelationDTOs = new List<ISV.MO.MOSrcRelationDTOData>();
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
                Code = ProjectCode
            }; 
            //moDto.RoutingAlternate = 0;
            //moDto.RoutingECONo = "";
            //moDto.RoutingEffeDate
            //moDto.RoutingVer
            //moDto.SCVBin
            Organization org = Organization.Finder.FindByID(order.SCVWh.Org.ID);
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
            //moDto.Task 
            return moDto;
        }
    }

    #endregion


}