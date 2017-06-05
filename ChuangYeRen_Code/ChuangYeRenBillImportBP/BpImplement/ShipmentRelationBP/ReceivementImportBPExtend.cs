namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.ISV.RCV.Proxy;
    using UFIDA.U9.ISV.RCV.DTO;
    using InvStockBE;
    using UFSoft.UBF.PL;
    using UFIDA.U9.PM.DTOs;
    using UFSoft.UBF.PL.Engine;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.HR.Operator;
    using UFIDA.U9.PM.Rcv;
    using UFIDA.U9.CBO.SCM.ProjectTask;

	/// <summary>
	/// ReceivementImportBP partial 
	/// </summary>	
	public partial class ReceivementImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new ReceivementImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ReceivementImportBPImpementStrategy : BaseStrategy
	{
		public ReceivementImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ReceivementImportBP bpObj = (ReceivementImportBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            Receivement P = Receivement.Finder.Find("DescFlexField.PrivateDescSeg29='" + bpObj.RelationId + "'");
            if (P == null)
            {
                #region 采购入库创建
                CreateRCVSRVProxy createProxy = new CreateRCVSRVProxy();
                createProxy.RCVList = new List<OBAReceivementDTOData>();
                #region 校验
                InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationId);
                string strproject = "";
                if (invStock != null)
                {
                    foreach (InvStocks invStockLine in invStock.InvStocks)
                    {
                        if (invStockLine.MakReqID != null)
                        {
                            Project project = Project.Finder.Find("Code='" + invStockLine.MakReqID.MakReq + "' and Org='" + invStock.OrgID + "'");
                            if (project == null)
                            {
                                strproject = strproject + invStockLine.MakReqID.MakReq + "，";
                            }
                            project = null;
                        }
                    }
                }
                if (strproject != "")
                {
                    pub.Flag = false;
                    pub.Message = "导入失败！失败信息：项目档案中不存在对应的项目：Code：" + strproject + "！";
                    return pub;
                }
                #endregion
                try
                {
                    OBAReceivementDTOData receivementDTO = GetRcvInfo(bpObj.RelationId);
                    if (receivementDTO != null)
                    {
                        createProxy.RCVList.Add(receivementDTO);
                        var data = createProxy.Do();
                        if (data.Count == 0) return pub;
                        pub.Flag = true;
                        pub.Message = "导入成功！";
                        pub.DocID = data[0].ID;
                        pub.DocNo = data[0].DocNo;
                        CyrLibH.DB.RunSQL("update InvStock set U9ID='" + data[0].ID + "' where ID ='" + bpObj.RelationId + "'");
                    }
                    else
                    {
                        pub.Flag = false;
                        pub.Message = "导入失败！失败信息：在进出仓明细主表没有找到对应的单据：ID：" + bpObj.RelationId + "，进出仓类型：普通采购！";
                    }
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message = "导入失败！失败信息：" + ex.Message;
                }
                #endregion
                #region 审核
                //if (pub.DocID > 0)
                //{ 
                //    try
                //    { 
                //        ApproveRCVSRVProxy approvedProxy = new ApproveRCVSRVProxy();
                //        approvedProxy.ActType = 8;//8为审核
                //        approvedProxy.RCVLogicKeyINFOs = new List<RCVLogicKeyINFOData>();
                //        RCVLogicKeyINFOData infoData = new RCVLogicKeyINFOData();
                //        infoData.DocNo = pub.DocNo;
                //        infoData.Org = Context.LoginOrg.ID;
                //        infoData.RcvID = pub.DocID;
                //        approvedProxy.RCVLogicKeyINFOs.Add(infoData);
                //        approvedProxy.Do();
                //        pub.Flag = true;
                //        pub.Message = "导入成功！审核成功！";
                //    }
                //    catch (Exception ex)
                //    {
                //        pub.Flag = false;
                //        pub.Message = "审核失败！失败信息：" + ex.Message;
                //        //DeleteRCVSRVProxy deleteProxy = new DeleteRCVSRVProxy();
                //        //deleteProxy.RCVKeyList = new List<long>();
                //        //deleteProxy.RCVKeyList.Add(pub.DocID);
                //        //deleteProxy.Do();
                //        pub.DocID = 0L;
                //        pub.DocNo = "";
                //    }
                //}
                #endregion
            }
            else
            {
                pub.Flag = false;
                pub.Message = "导入失败！已存在此单:" + bpObj.RelationId.ToString();
            }
            return pub;
		}		

        private OBAReceivementDTOData GetRcvInfo(long RelationId)
        {
            InvStock order = InvStock.Finder.FindByID(RelationId);
            if (order != null)
            {
                OBAReceivementDTOData rcvDto = new OBAReceivementDTOData();

                //单据类型
                rcvDto.RcvDocType = new BESimp4UIDTOData();
                rcvDto.RcvDocType.Code = "RCV01";//单据类型
                rcvDto.ReceivementType = 0;//收货单类型 0:采购收货 1：采购退货 2：销售退回收货单
                rcvDto.SrcDocType = 0; //来源单据类型 0：手工创建]
                
                if (order.BillDate == null)
                {
                    rcvDto.BusinessDate = System.DateTime.Now.Date;//日期
                }
                else
                {
                    rcvDto.BusinessDate = order.BillDate;//日期
                }
                rcvDto.CreatedBy = order.CreatedBy;//制单人
                
                rcvDto.Supplier = new SupplierMISCInfoData();//供应商
                rcvDto.ConfirmTerm = new BESimp4UIDTOData();//立账条件
                rcvDto.PaymentTerm = new BESimp4UIDTOData();//付款条件
                if (order.SupplyID != null)
                {
                    rcvDto.Supplier.Code = order.SupplyID.Code;//供应商编码
                    string supplierCode = order.SupplyID.Code; 
                    Supplier supplier = Supplier.Finder.Find("Code='" + order.SupplyID.Code + "' and Org='" + order.OrgID + "'");
                    if (supplier != null)
                    {
                        if (supplier.APConfirmTerm != null)
                        {
                            rcvDto.ConfirmTerm.Code =  supplier.APConfirmTerm.Code;
                        }
                        if (supplier.PaymentTerm != null)
                        {
                            rcvDto.PaymentTerm.Code = supplier.PaymentTerm.Code;
                        }
                    }
                }
                rcvDto.AC = new BESimp4UIDTOData();
                rcvDto.TC = new BESimp4UIDTOData();
                if (order.Currency != null)
                {
                    rcvDto.AC.Code = order.Currency.Code;//核币
                    rcvDto.TC.Code = order.Currency.Code;//交易币
                    if (order.Currency.Code != "C001")
                    {
                        rcvDto.TCToACExRateType = 2; //汇率类型
                    }
                }
                else
                {
                    rcvDto.AC.Code = "C001";
                    rcvDto.TC.Code = "C001";
                } 
                
                rcvDto.IsInitEvaluation = false;//是否期初 
               
                rcvDto.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
                rcvDto.DescFlexField.PrivateDescSeg29 = Convert.ToString(order.ID);//用私有段29记录ID
                rcvDto.DescFlexField.PrivateDescSeg30 = order.BillNO;//用私有段30记录单据编号

                rcvDto.SysState = ObjectState.Inserted;

                rcvDto.RcvLines = new List<OBARcvLineDTOData>();

                //行
                foreach (InvStocks invStockLine in order.InvStocks)
                {
                    OBARcvLineDTOData rcvLineDto = new OBARcvLineDTOData();
                    rcvLineDto.ItemInfo = new UFIDA.U9.CBO.SCM.Item.ItemInfoData();
                    if (invStockLine.ItemID != null)
                    {
                        rcvLineDto.ItemInfo.ItemCode = invStockLine.ItemID.Code;//料品
                    }
                    rcvLineDto.ArrivedTime = order.BillDate;//到货时间
                    rcvLineDto.ConfirmDate = order.BillDate;//入库确认日 
                    rcvLineDto.SysPriceTC = invStockLine.Price;//系统价
                    rcvLineDto.OrderPriceTC = invStockLine.Price;//定价
                    rcvLineDto.FinallyPriceTC = invStockLine.Price;//最终价
                    if (invStockLine.Price == 0)
                    {
                        rcvLineDto.IsPresent = true;
                        rcvLineDto.IsZeroCost = true;
                    }
                    rcvLineDto.PlanQtyTU = invStockLine.InQty; //计划到货量
                    rcvLineDto.ArriveQtyTU = invStockLine.InQty;//实到数量
                    rcvLineDto.Project = new BESimp4UIDTOData(); 
                    if (invStockLine.MakReqID  != null)
                    { 
                        rcvLineDto.Project.Code = invStockLine.MakReqID.MakReq; 
                    }
                    if (invStockLine.TaxRat > 0)
                    {
                        rcvLineDto.IsPriceIncludeTax = true;
                        rcvLineDto.TaxRate = invStockLine.TaxRat;//税率
                    }

                    rcvLineDto.Wh = new BESimp4UIDTOData();
                    if (invStockLine.StockID != null)
                    {
                        rcvLineDto.Wh.Code = invStockLine.StockID.Code;//存储地点
                    }
                    rcvLineDto.RcvDept = new BESimp4UIDTOData();
                    rcvLineDto.WhMan = new BESimp4UIDTOData();
                    rcvLineDto.SysState = ObjectState.Inserted;
                    rcvLineDto.FreeReason = -1;
                    //rcvLineDto.FreeType = -1;
                    rcvLineDto.RejectReason = -1;

                    rcvDto.RcvLines.Add(rcvLineDto);
                }

                return rcvDto;
            }
            else
            {
                return null;
            }
        }
	}

	#endregion
	
	
}