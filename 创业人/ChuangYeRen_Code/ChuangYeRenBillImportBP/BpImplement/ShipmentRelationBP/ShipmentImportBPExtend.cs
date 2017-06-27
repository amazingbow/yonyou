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
    using UFIDA.U9.CBO.HR.Department;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFIDA.U9.SM.Ship;

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
            #region 校验
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationId);
            string strproject = "";
            if (invStock != null)
            {
                foreach (InvStocks invStockLine in invStock.InvStocks)
                {
                    if (invStockLine.MakReq != null && invStockLine.MakReq != "")
                    {
                        Project project = Project.Finder.Find("Code='" + invStockLine.MakReq + "' and Org='" + invStock.OrgID + "'");
                        if (project == null)
                        {
                            strproject = strproject + invStockLine.MakReq + "，";
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
            CreateShipSVProxy createProxy = new CreateShipSVProxy();
            createProxy.ShipDTOs = new List<ShipDTOForIndustryChainData>();
            Ship P = Ship.Finder.Find("DescFlexField.PrivateDescSeg29='" + bpObj.RelationId + "'");
            if (P == null)
            {
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
                        #region 审核
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
                        #endregion
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
            }
            else
            {
                pub.Flag = false;
                pub.Message = "导入失败！已存在此单:" + bpObj.RelationId.ToString();
            }
            return pub;
        }

        private ShipDTOForIndustryChainData GetShipInfo(long RelationId)
        {
            InvStock order = InvStock.Finder.FindByID(RelationId);
            if (order != null)
            {
                ShipDTOForIndustryChainData shipDTO = new ShipDTOForIndustryChainData();

                //单头
                //单据类型
                shipDTO.DocumentType = new CommonArchiveDataDTOData();
                shipDTO.DocumentType.Code = "SM1";
                //组织
                shipDTO.Org = new CommonArchiveDataDTOData();
                shipDTO.Org.ID = order.OrgID;

                //业务日期、出货确认日

                shipDTO.BusinessDate = order.BillDate;//业务日期
                shipDTO.ShipConfirmDate = order.BillDate;//出货确认日

                //客户
                shipDTO.OrderBy = new CommonArchiveDataDTOData();
                shipDTO.BillToSite = new CommonArchiveDataDTOData();//立账位置
                shipDTO.PayerSite = new CommonArchiveDataDTOData();//付款位置
                shipDTO.ReceivableTerm = new CommonArchiveDataDTOData();//收款条件
                shipDTO.ConfirmTerm = new CommonArchiveDataDTOData();//立账条件
      
                Customer customer = null;
                if (order.CustID != null)
                {
                    shipDTO.OrderBy.Code = order.CustID.Code;
                    string customerCode = order.CustID.Code;
                    long orgID = order.OrgID;
                    customer = Customer.Finder.Find("Code=@customerCode and Org=@orgID", new OqlParam[2] { new OqlParam(customerCode), new OqlParam(orgID) });
                    if (customer != null)
                    {
                        if (customer.CustomerSites != null)
                        {
                            shipDTO.BillToSite.Code = customer.CustomerSites[0].Code;
                            shipDTO.PayerSite.Code = customer.CustomerSites[0].Code;
                            shipDTO.PayerSite.ID = customer.CustomerSites[0].ID;
                            shipDTO.PayerSite.ID = customer.CustomerSites[0].ID; 
                        }
                        if (customer.RecervalTerm != null)
                        {
                            shipDTO.ReceivableTerm.Code = customer.RecervalTerm.Code;
                            shipDTO.ReceivableTerm.ID = customer.RecervalTerm.ID;
                        }
                        if (customer.ARConfirmTerm != null)
                        {
                            shipDTO.ConfirmTerm.Code = customer.ARConfirmTerm.Code;
                            shipDTO.ConfirmTerm.ID = customer.ARConfirmTerm.ID;
                        }
                    }
                }
                shipDTO.ConfirmAccording = new CommonArchiveDataDTOData();//立帐依据
                shipDTO.ConfirmAccording.Code = "SD02";//立帐依据 
                shipDTO.ConfirmMode = 0;

                shipDTO.TC = new CommonArchiveDataDTOData();
                shipDTO.AC = new CommonArchiveDataDTOData();
                if (order.Currency != null)
                {
                    shipDTO.TC.Code = order.Currency.Code; //交易币
                    shipDTO.AC.Code = order.Currency.Code;  //核币
                    if (order.Currency.Code != "C001")
                    {
                        shipDTO.ExchangeRateType = 2;//汇率类型
                    }
                }
                else
                {
                    shipDTO.TC.Code = "C001";
                    shipDTO.AC.Code = "C001";
                }


                //部门
                shipDTO.SaleDept = new CommonArchiveDataDTOData();
                shipDTO.SaleDept.Code = order.DeptID.Code2;
                //业务员
                Organization oOrg = new Organization();
                {
                    oOrg.ID = order.OrgID;
                }
                Department Dp = Department.FindByCode(oOrg, order.DeptID.Code2);
                shipDTO.Seller = new CommonArchiveDataDTOData();
                shipDTO.Seller.Code = Dp.DescFlexField.PrivateDescSeg2;//业务员
                shipDTO.ShipMemo = order.CNote;
                shipDTO.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
                shipDTO.DescFlexField.PrivateDescSeg29 = Convert.ToString(order.ID);//用私有段29记录ID
                shipDTO.DescFlexField.PrivateDescSeg30 = order.BillNO;//用私有段30记录单据编号

                //单行
                foreach (InvStocks invStockLine in order.InvStocks)
                {
                    ShipLineDTOForIndustryChainData shipLineDTO = new ShipLineDTOForIndustryChainData();

                    //料品
                    shipLineDTO.ItemInfo = new ItemInfoData();
                    if (invStockLine.ItemID != null)
                    {
                        shipLineDTO.ItemInfo.ItemCode = invStockLine.ItemID.Code;//料品
                    }
                    //库存数量
                    //shipLineDTO.ShipQtyInvAmount = invStockLine.RcvQty;

                    shipLineDTO.DonationReason = -1;  //免费品原因 
                    shipLineDTO.RejectReason = -1;     //拒收原因
                    shipLineDTO.ShipToSite = shipDTO.BillToSite;   //收货位置
                    shipLineDTO.WH = new CommonArchiveDataDTOData();    //存储地点
                    if (invStockLine.StockID != null)
                    {
                        shipLineDTO.WH.Code = invStockLine.StockID.Code;//存储地点
                    }
                    if (order.CustID != null)
                    {
                        shipLineDTO.BillToSite = new CommonArchiveDataDTOData();//立账位置
                        shipLineDTO.PayerSite = new CommonArchiveDataDTOData();//付款位置
                        shipLineDTO.ReceivableTerm = new CommonArchiveDataDTOData();//收款条件
                        shipLineDTO.ConfirmTerm = new CommonArchiveDataDTOData();//立账条件 
                        shipLineDTO.CreditObj = new CommonArchiveDataDTOData();//信用客户位置 
                        shipLineDTO.ConfirmAccording = new CommonArchiveDataDTOData();
                        shipLineDTO.BillToSite = shipLineDTO.ShipToSite; //立账位置 
                        shipLineDTO.PayerSite = shipDTO.PayerSite; //付款位置 
                        shipLineDTO.ReceivableTerm = shipDTO.ReceivableTerm;//收款条件 
                        shipLineDTO.ConfirmTerm = shipDTO.ConfirmTerm; //立账条件
                        shipLineDTO.ConfirmAccording.Code = "SD02";//立帐依据
                        shipLineDTO.MaturityDate = order.BillDate;
                        shipLineDTO.ConfirmMode = 0;
                        //if (customer != null)
                        //{
                        //    if (customer.ARConfirmTerm != null)
                        //    {
                        //        shipLineDTO.ConfirmTerm.Code = customer.ARConfirmTerm.Code;
                        //        shipLineDTO.ConfirmTerm.ID = customer.ARConfirmTerm.ID;
                        //        shipLineDTO.ConfirmMode = 0;
                        //        shipLineDTO.ConfirmAccording.Code = "SD02";//立帐依据
                        //        shipLineDTO.MaturityDate = order.BillDate;
                        //    }
                        //}
                        shipLineDTO.CreditObj = shipLineDTO.ShipToSite;  //信用客户位置 
                    }
                    shipLineDTO.ShipQtyTUAmount = invStockLine.OutQty;   //数量
                    //价格 
                    shipLineDTO.OrderPrice = invStockLine.Price;
                    shipLineDTO.OrderPriceTC = invStockLine.Price;
                    shipLineDTO.FinallyPrice = invStockLine.Price;
                    shipLineDTO.FinallyPriceTC = invStockLine.Price;
                    //KIT
                    shipLineDTO.ShipTogetherFlag = -1;
                    //项目
                    shipLineDTO.Project = new CommonArchiveDataDTOData();
                    shipLineDTO.Project.Code = invStockLine.MakReq;

                    //库位子表
                    if (invStockLine.FLocator != null)
                    {
                        ShipLineLocationDTOForIndustryChainData shipLineLocation = new ShipLineLocationDTOForIndustryChainData();
                        shipLineLocation.Location = new CommonArchiveDataDTOData();
                        shipLineLocation.Location.Code = invStockLine.FLocator.Code;
                        shipLineLocation.LocationCode = invStockLine.FLocator.Code;
                        shipLineLocation.LocationQtyInvAmount = invStockLine.OutQty;
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