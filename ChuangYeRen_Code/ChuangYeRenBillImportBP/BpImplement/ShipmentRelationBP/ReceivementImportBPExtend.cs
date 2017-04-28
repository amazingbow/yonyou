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
            CreateRCVSRVProxy createProxy = new CreateRCVSRVProxy();
            createProxy.RCVList = new List<OBAReceivementDTOData>();

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
                    //        DeleteRCVSRVProxy deleteProxy = new DeleteRCVSRVProxy();
                    //        deleteProxy.RCVKeyList = new List<long>();
                    //        deleteProxy.RCVKeyList.Add(pub.DocID);
                    //        deleteProxy.Do();
                    //        pub.DocID =0L;
                    //        pub.DocNo = "";
                    //    }
                    //}
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
            return pub;
		}		

        private OBAReceivementDTOData GetRcvInfo(long RelationId)
        {
            Int32 IOC = 1;
            //Int32 IR = 0;
            InvStock order = InvStock.Finder.Find("ID=@RelationId and IOC=@IOC", new OqlParam[2] { new OqlParam(RelationId), new OqlParam(IOC) });
            if (order != null)
            {
                OBAReceivementDTOData rcvDto = new OBAReceivementDTOData();

                //单据类型
                rcvDto.RcvDocType = new BESimp4UIDTOData();
                rcvDto.RcvDocType.Code = "RCV01";//单据类型

                rcvDto.ReceivementType = 0;//收货单类型 0:采购收货 1：采购退货 2：销售退回收货单

                rcvDto.SrcDocType = 0; //来源单据类型 0：手工创建
                if (order.BillDate == null || order.BillDate.ToString() == "" || order.BillDate <= System.DateTime.MinValue)
                {
                    rcvDto.BusinessDate = System.DateTime.Now.Date;//日期
                }
                else
                {
                    rcvDto.BusinessDate = order.BillDate;//日期
                }

                rcvDto.Supplier = new SupplierMISCInfoData();//供应商
                rcvDto.ConfirmTerm = new BESimp4UIDTOData();//立账条件
                rcvDto.PaymentTerm = new BESimp4UIDTOData();//付款条件
                if (order.SupplyID != null)
                {
                    rcvDto.Supplier.Code = order.SupplyID.Code;//供应商编码
                    string supplierCode = order.SupplyID.Code;
                    long orgID = Context.LoginOrg.ID;
                    Supplier supplier = Supplier.Finder.Find("Code=@supplierCode and Org=@orgID", new OqlParam[2] { new OqlParam(supplierCode), new OqlParam(orgID) });
                    if (supplier != null)
                    {
                        if (supplier.APConfirmTerm != null)
                        {
                            rcvDto.ConfirmTerm.Code = supplier.APConfirmTerm.Code;
                        }
                        if (supplier.PaymentTerm != null)
                        {
                            rcvDto.PaymentTerm.Code = supplier.PaymentTerm.Code;
                        }
                    }
                }
                rcvDto.AC = new BESimp4UIDTOData();//核币
                if (order.Currency != null)
                {
                    rcvDto.AC.Code = order.Currency.Code;
                }
                else
                {
                    rcvDto.AC.Code = "C001";
                }
                rcvDto.TC = new BESimp4UIDTOData();//交易币
                if (order.Currency != null)
                {
                    rcvDto.TC.Code = order.Currency.Code;
                }
                else
                {
                    rcvDto.TC.Code = "C001";
                }
                //汇率类型
                if (order.Currency != null)
                {
                    if (order.Currency.Code != "C001")
                    {
                        rcvDto.TCToACExRateType = 2;
                    }
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

                    if (order.BillDate == null || order.BillDate.ToString() == "" || order.BillDate <= System.DateTime.MinValue)
                    {
                        rcvLineDto.ArrivedTime = System.DateTime.Now.Date;//到货时间
                        rcvLineDto.ConfirmDate = System.DateTime.Now.Date;//入库确认日
                    }
                    else
                    {
                        rcvLineDto.ArrivedTime = order.BillDate;//到货时间
                        rcvLineDto.ConfirmDate = order.BillDate;//入库确认日
                    }

                    rcvLineDto.SysPriceTC = invStockLine.Price;//系统价
                    rcvLineDto.OrderPriceTC = invStockLine.Price;//定价
                    rcvLineDto.FinallyPriceTC = invStockLine.Price;//最终价
                    rcvLineDto.PlanQtyTU = invStockLine.InQty; //计划到货量
                    rcvLineDto.ArriveQtyTU = invStockLine.InQty;//实到数量

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
                    if (order.DeptID != null)
                    {
                        rcvLineDto.RcvDept.Code = order.DeptID.Code;//收货部门
                    }
                    rcvLineDto.WhMan = new BESimp4UIDTOData();
                    rcvLineDto.WhMan.Code = "01";//库管员
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