namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.ISV.RCV.DTO;
    using UFIDA.U9.ISV.RCV.Proxy;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.PL.Engine;
    using InvStockBE;
    using UFIDA.U9.Base;

    /// <summary>
    /// PMRtnImportBP partial 
    /// </summary>	
    public partial class PMRtnImportBP
    {
        internal BaseStrategy Select()
        {
            return new PMRtnImportBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class PMRtnImportBPImpementStrategy : BaseStrategy
    {
        public PMRtnImportBPImpementStrategy() { }

        public override object Do(object obj)
        {
            PMRtnImportBP bpObj = (PMRtnImportBP)obj;
            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            CreateRCVSRVProxy createProxy = new CreateRCVSRVProxy();//采购退货单导入
            createProxy.RCVList = new List<OBAReceivementDTOData>();
            try
            {
                OBAReceivementDTOData headDto = getInfo(bpObj.ID);
                createProxy.RCVList.Add(headDto);
                var data = createProxy.Do();
                if (data.Count == 0) return pub;
                pub.DocID = data[0].ID;
                pub.DocNo = data[0].DocNo;             
                ApproveRCVSRVProxy approveproxy = new ApproveRCVSRVProxy();
                approveproxy.RCVLogicKeyINFOs = new List<RCVLogicKeyINFOData>();
                RCVLogicKeyINFOData AppData = new RCVLogicKeyINFOData
                {
                    DocNo = pub.DocNo,
                    Org=Context.LoginOrg.ID,
                    RcvID=pub.DocID,
                };
                approveproxy.RCVLogicKeyINFOs.Add(AppData);
                approveproxy.Do();
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = ex.Message;
                throw new Exception(ex.Message);
            }

            return pub;
        }
        private OBAReceivementDTOData getInfo(long stockID)
        {
            //头
            //通过传入的StockID找到对应进出仓明细表数据
            InvStock Invstock = InvStock.Finder.FindByID(stockID); //进出仓明细表头
            ////为头信息赋值
            InvStocks.EntityList<InvStocks> InvstocksList = Invstock.InvStocks; //进出仓明细表行表集合
            ////为对应行信息赋值，添加到头对应行集合里面
            OBAReceivementDTOData headDto = new OBAReceivementDTOData();
            //headDto.RcvDocType = new 
            headDto.RcvDocType = new PM.DTOs.BESimp4UIDTOData //单据类型
            {
                Name = Invstock.IOC.Name,
            };
            headDto.ReceivementType = 1; ////收货单类型 0:采购收货 1：采购退货 2：销售退回收货单
            headDto.SrcDocType = 0;//来源单据类型 0：手工创建
            headDto.Supplier = new CBO.SCM.Supplier.SupplierMISCInfoData  //供应商
            {
                Code = Invstock.SupplyID.Code,
            };
            //headDto.Payer = new CBO.SCM.Supplier.SupplierMISCInfoData //付款供应商
            //{
            //    Code = "XX01",
            //};
            headDto.IsInitEvaluation = false; //是否期初
            headDto.BusinessDate = System.DateTime.Now; //业务制单时间
            headDto.AC = new PM.DTOs.BESimp4UIDTOData   //核币
            {

                ID = Invstock.Currency.ID,
            };
            headDto.TC = new PM.DTOs.BESimp4UIDTOData  //币种
            {
                ID = Invstock.Currency.ID,
            };
            headDto.AccountOrg = new PM.DTOs.BESimp4UIDTOData //核算组织
            {
               ID = Invstock.OrgID,
            };
            headDto.Memo = Invstock.CNote;  //备注
            //headDto.PostPeriod //记账期间
            headDto.PaymentTerm = new PM.DTOs.BESimp4UIDTOData //付款条件
            {
                Code = "01",
            };
            headDto.ConfirmTerm = new PM.DTOs.BESimp4UIDTOData //立账条件
            {
                Code = "02",
            };
            headDto.FindPriceDate = System.DateTime.Now; //取价日期
            headDto.IsPriceIncludeTax = true; //价格含税
            headDto.SysState = ObjectState.Inserted;
            List<OBARcvLineDTOData> LineDtolist = new List<OBARcvLineDTOData>();
            foreach (InvStocks Invstocks in InvstocksList) //遍历进出仓明细表行表中所有的行信息
            {
                //    //Invstocks.属性 //               
                OBARcvLineDTOData lineDto = new OBARcvLineDTOData();
                lineDto.ItemInfo = new CBO.SCM.Item.ItemInfoData
                {
                    ItemCode = Invstocks.ItemID.Code,
                };
                lineDto.SysPriceTC = Invstocks.BalPrice; //系统价
                lineDto.OrderPriceTC = Invstocks.BalPrice;  //定价
                lineDto.FinallyPriceTC = Invstocks.BalPrice; //最终价
                lineDto.RejectQtyTU = Invstocks.InQty-Invstocks.RcvQty; //拒收数量
                lineDto.RtnFillQtyTU = Invstocks.RcvQty; //补退数量
                //lineDto.RtnDeductQtyTU = 1; //退扣数量
                lineDto.Wh = new PM.DTOs.BESimp4UIDTOData   //存储地点
                {
                    Code = Invstocks.StockID.Code,
                };
                //lineDto.RcvDept = new PM.DTOs.BESimp4UIDTOData //部门
                //{
                //    Code = Invstocks.
                //};
                //lineDto.WhMan = new PM.DTOs.BESimp4UIDTOData
                //{
                //    Code = "YZ0252"
                //};
                lineDto.SysState = ObjectState.Inserted;
                lineDto.FreeReason = -1;
                lineDto.FreeType = -1;
                lineDto.RejectReason = -1;
                LineDtolist.Add(lineDto);
            }
            //headDto.TaxRate = //税率
            
            headDto.RcvLines = LineDtolist;
            return headDto;
        }
    }

    #endregion


}