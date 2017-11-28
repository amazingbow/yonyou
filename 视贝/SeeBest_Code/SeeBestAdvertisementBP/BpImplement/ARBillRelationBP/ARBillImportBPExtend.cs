namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.ISV.AR.Proxy;
    using UFIDA.U9.ISV.AR;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.CBO.SCM.Customer;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// ARBillImportBP partial 
    /// </summary>	
    public partial class ARBillImportBP
    {
        internal BaseStrategy Select()
        {
            return new ARBillImportBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ARBillImportBPImpementStrategy : BaseStrategy
    {
        public ARBillImportBPImpementStrategy() { }

        public override object Do(object obj)
		{						
			ARBillImportBP bpObj = (ARBillImportBP)obj;

            ARBillReturnDTO pub = new ARBillReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            CreateImportARBillSVProxy createProxy = new CreateImportARBillSVProxy();
            createProxy.ImportARBillHeadDTOs = new List<ImportARBillHeadDTOData>();

            try
            {
                ImportARBillHeadDTOData arBillDTO = GetARBillInfo(bpObj.RelationId);
                if (arBillDTO != null)
                {
                    createProxy.ImportARBillHeadDTOs.Add(arBillDTO);
                    var data = createProxy.Do();
                    if (data.Count == 0) return pub;
                    pub.Flag = true;
                    pub.Message = "创建应收单成功！";
                    pub.DocID = data[0].ID;
                    pub.DocNo = data[0].DocNO;
                    using (ISession session=Session.Open())
                    {
                        AdvApproveBE advApprove = AdvApproveBE.Finder.FindByID(bpObj.RelationId);
                        advApprove.DescFlexField.PrivateDescSeg1 = pub.DocID.ToString();
                        advApprove.DescFlexField.PrivateDescSeg2 = pub.DocNo;
                        session.Commit();
                    }
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "创建应收单失败！失败信息：在广告核销单没有找到对应的单据：ID：" + bpObj.RelationId + "！";
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = "创建应收单失败！失败信息：" + ex.Message;
            }
            return pub;
		}

        private ImportARBillHeadDTOData GetARBillInfo(long RelationId)
        {
            AdvApproveBE advApprove = AdvApproveBE.Finder.FindByID(RelationId);

            if (advApprove != null)
            {
                ImportARBillHeadDTOData arBillDTO = new ImportARBillHeadDTOData();

                #region  应收单表头

                //单据类型
                arBillDTO.DocumentType = new CommonArchiveDataDTOData();
                arBillDTO.DocumentType.Code = "AR11";

                //币种
                arBillDTO.AC = new CommonArchiveDataDTOData();
                arBillDTO.AC.Code = "C001";
                //汇率类型
                arBillDTO.ACToFCERType = -1;
                //汇率
                arBillDTO.ACToFCExRate = 1;

                //客户 
                arBillDTO.AccrueCust = new CustomerMISCInfoData();//立账客户 
                arBillDTO.PayCust = new CustomerMISCInfoData();//付款客户
                arBillDTO.AccrueCustSite = new CustomerSiteMISCInfoData();//立账客户位置
                arBillDTO.PayCustSite = new CustomerSiteMISCInfoData();//付款客户位置
                if (advApprove.AdvApplyCust != null)
                {
                    arBillDTO.AccrueCust.Code = advApprove.AdvApplyCust.Code;
                    arBillDTO.PayCust.Code = advApprove.AdvApplyCust.Code;
                    if (advApprove.AdvApplyCust.CustomerSites != null)
                    {
                        arBillDTO.AccrueCustSite.Code = advApprove.AdvApplyCust.CustomerSites[0].Code;
                        arBillDTO.PayCustSite.Code = advApprove.AdvApplyCust.CustomerSites[0].Code;
                    }
                }

                //立账日期
                arBillDTO.AccrueDate = System.DateTime.Now;

                //组织
                arBillDTO.BizOrg = new CommonArchiveDataDTOData();//业务组织
                arBillDTO.SettleOrg = new CommonArchiveDataDTOData();//结算组织 
                if (advApprove.Org != null)
                {
                    arBillDTO.BizOrg.Code = advApprove.Org.Code;
                    arBillDTO.SettleOrg.Code = advApprove.Org.Code;
                }
                else
                {
                    arBillDTO.BizOrg.Code = Context.LoginOrg.Code;
                    arBillDTO.SettleOrg.Code = Context.LoginOrg.Code;
                }

                //业务类型 
                arBillDTO.BusinessType = 3;//3为应收贷项账户单

                //信用对象类型 
                arBillDTO.CreditControlSiteType = 0;//0为立账客户地址 

                //期初
                arBillDTO.IsPeriodBegin = false;

                //优先等级 
                arBillDTO.PriorityGrade = 4;

                //收入规则 
                arBillDTO.RCR = 2;//2为同期确认 

                arBillDTO.SrcBillID = 0;//来源单据
                arBillDTO.SrcBillNum = "";//来源单据号
                arBillDTO.SrcBusinessType = 253;//来源业务类型
                arBillDTO.SrcOrg = new CommonArchiveDataDTOData();//来源组织
                if (advApprove.Org != null)
                {
                    arBillDTO.SrcOrg.Code = advApprove.Org.Code;
                }
                else
                {
                    arBillDTO.SrcOrg.Code = Context.LoginOrg.Code;
                }

                //税组合 
                //arBillDTO.TaxSchedule = new CommonArchiveDataDTOData();

                #endregion

                #region  应收单表行

                foreach (AdvApproveLine advApproveLine in advApprove.AdvApproveLine)
                {
                    if ((advApproveLine.ActualApproveQty > 0 && advApproveLine.ApproveMoney > 0) || (advApproveLine.Momo == "封底" && advApproveLine.ApproveMoney > 0))
                    {
                        ImportARBillLineDTOData arBillDTOLine = new ImportARBillLineDTOData();

                        arBillDTOLine.AccrueTerm = new CommonArchiveDataDTOData();//立账条件
                        arBillDTOLine.RecTerm = new CommonArchiveDataDTOData();//收款条件 
                        if (advApprove.AdvApplyCust != null)
                        {
                            if (advApprove.AdvApplyCust.ARConfirmTerm != null)
                            {
                                arBillDTOLine.AccrueTerm.Code = advApprove.AdvApplyCust.ARConfirmTerm.Code;
                            }
                            if (advApprove.AdvApplyCust.RecervalTerm != null)
                            {
                                arBillDTOLine.RecTerm.Code = advApprove.AdvApplyCust.RecervalTerm.Code;
                            }
                        }
                        arBillDTOLine.ShipToCustSite = arBillDTO.AccrueCustSite;//收货客户位置 
                        arBillDTOLine.IsIncludeTax = true;//是否含税
                        arBillDTOLine.IsOccupyCredit = true;//是否占用额度
                        arBillDTOLine.IsQA = false;//质保金
                        //料品 
                        arBillDTOLine.Item = new CBO.SCM.Item.ItemInfoData();
                        if (string.IsNullOrEmpty(advApproveLine.AdvCarrierCode))
                        {

                        }
                        else
                        {
                            if (advApprove.Org != null)
                            {
                                ItemMaster itemMaster = ItemMaster.Finder.Find("Code=@Code and Org.ID=@IOC", new OqlParam[2] { new OqlParam(advApproveLine.AdvCarrierCode), new OqlParam(advApprove.Org.ID) });

                                if (itemMaster != null)
                                {
                                    arBillDTOLine.Item.ItemCode = itemMaster.Code;
                                }

                            }
                        }
                        arBillDTOLine.Maturity = System.DateTime.Now;//到期日
                        arBillDTOLine.ReceiveInvoiceDate = System.DateTime.Now;//收票日期 
                        arBillDTOLine.TDMode = 0;//贸易方式：0为一般贸易
                        arBillDTOLine.RequisitionAdjustMode = 0;//通知单调整方式：0为调量

                        if (advApproveLine.Momo == "封底")
                        {
                            arBillDTOLine.PUAmount = 1;//数量
                        }
                        else
                        {
                            arBillDTOLine.PUAmount = advApproveLine.ActualApproveQty;//数量
                        }
                        arBillDTOLine.UnitPrice = advApproveLine.ActualPrice * advApproveLine.Area * advApproveLine.Discount;//单价

                        arBillDTO.ImportARBillLineDTOs.Add(arBillDTOLine);
                    }
                }

                #endregion

                return arBillDTO;
            }
            else
            {
                return null;
            }
        }
    }

    #endregion


}