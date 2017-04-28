namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.ISV.SM.Proxy;
    using UFIDA.U9.ISV.SM;
    using InvStockBE;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.SCM.Customer;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.SM.Ship.Proxy;
    using UFIDA.U9.SM.Common;
    using UFSoft.UBF.PL.Engine;

	/// <summary>
	/// ShipmentImportBP partial 
	/// </summary>	
	public partial class ShipmentImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new ShipmentImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ShipmentImportBPImpementStrategy : BaseStrategy
	{
		public ShipmentImportBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ShipmentImportBP bpObj = (ShipmentImportBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            CreateShipSVProxy createProxy = new CreateShipSVProxy();
            createProxy.ShipDTOs = new List<ShipDTOForIndustryChainData>();

            try
            {
                ShipDTOForIndustryChainData shipDTO = GetShipInfo(bpObj.RelationId);
                if (shipDTO != null)
                {
                    createProxy.ShipDTOs.Add(shipDTO);
                    var data = createProxy.Do();
                    if (data.Count == 0) return pub;
                    pub.Flag = true;
                    pub.Message = "导入成功！";
                    pub.DocID = data[0].DocID;
                    pub.DocNo = data[0].DocNO;
                    //if (pub.DocID > 0)
                    //{
                    //    try
                    //    {
                    //        //AuditShipSVProxy approvedProxy = new AuditShipSVProxy();
                    //        //approvedProxy.IsSubmitAndApprove = true;
                    //        //approvedProxy.ShipKeys = new List<DocKeyDTOData>();
                    //        //DocKeyDTOData infoData = new DocKeyDTOData();
                    //        //infoData.DocID = pub.DocID;
                    //        //infoData.DocNO = pub.DocNo;
                    //        //approvedProxy.ShipKeys.Add(infoData);
                    //        ShipmentApproveProxy approvedProxy = new ShipmentApproveProxy();
                    //        approvedProxy.IsUnApprove = false;
                    //        approvedProxy.ShipmentKey = pub.DocID;
                    //        approvedProxy.SysVersion = 0;
                    //        ErrorMessageDTOData errordata = approvedProxy.Do();
                    //        if ((errordata != null) && !string.IsNullOrEmpty(errordata.ErrorMessage))
                    //        {
                    //            data[0].SysState = ObjectState.Unchanged;
                    //        }
                    //        pub.Flag = true;
                    //        pub.Message = "导入成功！审核成功！";
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        pub.Flag = false;
                    //        pub.Message = "审核失败！失败信息：" + ex.Message;
                    //        DeleteShipProxy deleteProxy = new DeleteShipProxy();
                    //        deleteProxy.ShipIDs = new List<long>();
                    //        deleteProxy.ShipIDs.Add(pub.DocID);
                    //        deleteProxy.Do();
                    //        pub.DocID = 0L;
                    //        pub.DocNo = "";
                    //    }
                    //}
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "导入失败！失败信息：在进出仓明细主表没有找到对应的单据：ID：" + bpObj.RelationId + "，进出仓类型：普通销售！";
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = "导入失败！失败信息：" + ex.Message;
            }
            return pub;
		}

        private ShipDTOForIndustryChainData GetShipInfo(long RelationId)
        {
            Int32 IOC = 2;
            //Int32 IR = 1;
            InvStock order = InvStock.Finder.Find("ID=@RelationId and IOC=@IOC", new OqlParam[2] { new OqlParam(RelationId), new OqlParam(IOC) });
            if (order != null)
            {
                ShipDTOForIndustryChainData shipDTO = new ShipDTOForIndustryChainData();

                //单头
                //单据类型
                shipDTO.DocumentType = new CommonArchiveDataDTOData();
                shipDTO.DocumentType.Code = "SM1";
                //组织
                shipDTO.Org = new CommonArchiveDataDTOData();
                Organization organization = Organization.Finder.FindByID(order.OrgID);
                if (organization != null)
                {
                    shipDTO.Org.Code = organization.Code;
                }
                //业务日期、出货确认日
                if (order.BillDate == null || order.BillDate.ToString() == "" || order.BillDate <= System.DateTime.MinValue)
                {
                    shipDTO.BusinessDate = System.DateTime.Now.Date;//业务日期
                    shipDTO.ShipConfirmDate = System.DateTime.Now.Date;//出货确认日
                }
                else
                {
                    shipDTO.BusinessDate = order.BillDate;//业务日期
                    shipDTO.ShipConfirmDate = order.BillDate;//出货确认日
                }
                //客户
                shipDTO.OrderBy = new CommonArchiveDataDTOData();
                shipDTO.BillToSite = new CommonArchiveDataDTOData();//立账位置
                shipDTO.PayerSite = new CommonArchiveDataDTOData();//付款位置
                shipDTO.ReceivableTerm = new CommonArchiveDataDTOData();//收款条件
                shipDTO.ConfirmTerm = new CommonArchiveDataDTOData();//立账条件
                if (order.CustID != null)
                {
                    shipDTO.OrderBy.Code = order.CustID.Code;
                    string customerCode = order.CustID.Code;
                    long orgID = 0L;
                    if (organization != null)
                    {
                        orgID = organization.ID;
                    }
                    else
                    {
                        orgID = Context.LoginOrg.ID;
                    }
                    Customer customer = Customer.Finder.Find("Code=@customerCode and Org=@orgID", new OqlParam[2] { new OqlParam(customerCode), new OqlParam(orgID) });
                    if (customer != null)
                    {
                        if (customer.CustomerSites != null)
                        {
                            shipDTO.BillToSite.Code = customer.CustomerSites[0].Code;
                            shipDTO.PayerSite.Code = customer.CustomerSites[0].Code;
                        }
                        if (customer.RecervalTerm != null)
                        {
                            shipDTO.ReceivableTerm.Code = customer.RecervalTerm.Code;
                        }
                        if (customer.ARConfirmTerm != null)
                        {
                            shipDTO.ConfirmTerm.Code = customer.ARConfirmTerm.Code;
                        }
                    }
                }
                //交易币
                shipDTO.TC = new CommonArchiveDataDTOData();
                if (order.Currency != null)
                {
                    shipDTO.TC.Code = order.Currency.Code;
                }
                else
                {
                    shipDTO.TC.Code = "C001";
                }
                //核币
                shipDTO.AC = new CommonArchiveDataDTOData();
                if (order.Currency != null)
                {
                    shipDTO.AC.Code = order.Currency.Code;
                }
                else
                {
                    shipDTO.AC.Code = "C001";
                }
                //汇率类型
                if (order.Currency != null)
                {
                    if (order.Currency.Code != "C001")
                    {
                        shipDTO.ExchangeRateType = 2;
                    }
                }
                //业务员
                shipDTO.Seller = new CommonArchiveDataDTOData();
                shipDTO.Seller.Code = "01";
                //部门
                shipDTO.SaleDept = new CommonArchiveDataDTOData();
                shipDTO.SaleDept.Code = "101";

                shipDTO.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
                shipDTO.DescFlexField.PrivateDescSeg29 = Convert.ToString(order.ID);//用私有段29记录ID
                shipDTO.DescFlexField.PrivateDescSeg30 = order.BillNO;//用私有段30记录单据编号

                //单行
                foreach (InvStocks invStockLine in order.InvStocks)
                {
                    ShipLineDTOForIndustryChainData shipLineDTO=new ShipLineDTOForIndustryChainData();

                    //料品
                    shipLineDTO.ItemInfo = new ItemInfoData();
                    if (invStockLine.ItemID != null)
                    {
                        shipLineDTO.ItemInfo.ItemCode = invStockLine.ItemID.Code;//料品
                    }
                    //库存数量
                    //shipLineDTO.ShipQtyInvAmount = invStockLine.RcvQty;
                    //免费品原因
                    shipLineDTO.DonationReason = -1;
                    //拒收原因
                    shipLineDTO.RejectReason = -1;
                    //收货位置
                    shipLineDTO.ShipToSite = shipDTO.BillToSite;
                    //存储地点
                    shipLineDTO.WH = new CommonArchiveDataDTOData();
                    if (invStockLine.StockID != null)
                    {
                        shipLineDTO.WH.Code = invStockLine.StockID.Code;//存储地点
                    }
                    //立账位置
                    shipLineDTO.BillToSite = shipLineDTO.ShipToSite;
                    //信用客户位置
                    shipLineDTO.CreditObj = shipLineDTO.ShipToSite;
                    //数量
                    shipLineDTO.ShipQtyTUAmount = invStockLine.OutQty;
                    //收款条件
                    shipLineDTO.ReceivableTerm = shipDTO.ReceivableTerm;
                    //价格
                    shipLineDTO.OrderPrice = invStockLine.Price;
                    shipLineDTO.OrderPriceTC = invStockLine.Price;
                    shipLineDTO.FinallyPrice = invStockLine.Price;
                    shipLineDTO.FinallyPriceTC = invStockLine.Price;
                    //KIT
                    shipLineDTO.ShipTogetherFlag = -1;
                    //项目
                    shipLineDTO.Project = new CommonArchiveDataDTOData();
                    if (invStockLine.SCPO != null)
                    {
                        shipLineDTO.Project.Code = invStockLine.SCPO.Code;
                    }

                    //库位子表
                    if (invStockLine.FLocator != null)
                    {
                        ShipLineLocationDTOForIndustryChainData shipLineLocation = new ShipLineLocationDTOForIndustryChainData();
                        shipLineLocation.Location = new CommonArchiveDataDTOData();
                        shipLineLocation.Location.Code = invStockLine.FLocator.Code;
                        shipLineLocation.LocationCode = invStockLine.FLocator.Code;
                        shipLineLocation.LocationQtyInvAmount = invStockLine.RcvQty;
                        shipLineLocation.LocationQtyTUAmount = invStockLine.OutQty;
                        shipLineDTO.ShipLineLocations.Add(shipLineLocation);
                    }

                    shipDTO.ShipLines.Add(shipLineDTO);
                }

                return shipDTO;
            }
            else
            {
                return null;
            }
        }
	}

	#endregion
	
	
}