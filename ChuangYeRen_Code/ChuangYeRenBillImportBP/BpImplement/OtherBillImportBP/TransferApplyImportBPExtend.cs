namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.ISV.TransferInISV;
    using UFIDA.U9.ISV.TransferInISV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL.Engine;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// TransferApplyImportBP partial 
    /// </summary>	
    public partial class TransferApplyImportBP
    {
        internal BaseStrategy Select()
        {
            return new TransferApplyImportBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class TransferApplyImportBPImpementStrategy : BaseStrategy
    {
        public TransferApplyImportBPImpementStrategy() { }

        public override object Do(object obj)
        {
            TransferApplyImportBP bpObj = (TransferApplyImportBP)obj;
            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            

            CommonCreateTransferInSVProxy createProxy = new CommonCreateTransferInSVProxy();
            createProxy.TransferInDTOList = new List<ISV.TransferInISV.IC_TransferInDTOData>();
            try
            {
                IC_TransferInDTOData ApplyDto = getInfo(bpObj.ID);
                createProxy.TransferInDTOList.Add(ApplyDto);
                var data = createProxy.Do();                
                if (data.Count == 0) return pub;
                pub.DocID = data[0].ID;
                pub.DocNo = data[0].Code;
                TransferInBatchApproveSRVProxy arrpoveProxy = new TransferInBatchApproveSRVProxy();
                arrpoveProxy.ApprovedBy = Context.LoginUser;
                arrpoveProxy.ApprovedOn = Context.OperationDate;
                arrpoveProxy.DocList = new List<CommonArchiveDataDTOData>();
                CommonArchiveDataDTOData archivedata = new CommonArchiveDataDTOData
                {
                    Code=pub.DocNo,
                    ID=pub.DocID,
                };
                arrpoveProxy.DocList.Add(archivedata);
                arrpoveProxy.Do();
  

            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = ex.Message;
                throw new Exception(ex.Message);
            }
            
            return pub;
        }

        private IC_TransferInDTOData getInfo(long stockID)
        {

            //表头
            IC_TransferInDTOData headDto = new IC_TransferInDTOData();
            InvStock Stock = InvStock.Finder.FindByID(stockID);
            InvStocks.EntityList<InvStocks> stocksList = Stock.InvStocks;

            headDto.CreatedBy = Stock.CreatedBy;
            headDto.CreatedOn = Stock.CreatedOn;    //创建时间
            //headDto.DescFlexField //实体扩展字段
            //headDto.ID //ID
            //headDto.SOBAccountPeriod = Stock.peroid //记账期间
            headDto.Org = new CommonArchiveDataDTOData //组织
            {
                ID = Stock.OrgID,
            };
            headDto.TransInDocType = new CommonArchiveDataDTOData   //单据类型
            {
                Name=Stock.IOC.Name,
                //Code = "DR01",

            };
            //headDto.ApprovedBy = Stock.;  //审核人
           // headDto.Status = 2; // 状态
            headDto.TransferType = 0;       //调入类型
            headDto.TransferDirection = 0;      //调拨方向
            headDto.BusinessDate = System.DateTime.Now; //日期
            headDto.Memo = Stock.CNote;    //备注
            headDto.DocNo =Stock.BillNO;//单据编号
            headDto.SysState = ObjectState.Inserted;
            //表行
            List<IC_TransInLineDTOData> LineList = new List<IC_TransInLineDTOData>();
            foreach (InvStocks stocks in stocksList)
            {
            IC_TransInLineDTOData lineDto = new IC_TransInLineDTOData();
            //lineDto.DocLineNo=  //行号 
            //lineDto.Project=stocks.     //项目
            lineDto.StoreUOM = new CommonArchiveDataDTOData
            {
                ID = stocks.ItemID.UOM.ID,
            };    //调入库存单位
            lineDto.StoreUOMQty = stocks.InQty;  //调入库存数量
            //lineDto.CostUOM   //成本单位
            lineDto.CostPrice = stocks.Price; //单价
            lineDto.CostUOMQty = stocks.InQty;
            lineDto.LotInfo = new CBO.SCM.PropertyTypes.LotInfoData
            {
                LotCode=stocks.BarCode,
            }; //批号
            lineDto.CostCurrency = new CommonArchiveDataDTOData
            {
                ID = stocks.Currency.ID,
            };  //币种
            lineDto.CostMoney = (lineDto.CostPrice * lineDto.CostUOMQty); //成本
            //lineDto.IsVMI     //IsVMI标志
            lineDto.TransInSuppInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
            //lineDto.TransInSuppInfo.Code = "006";
            //lineDto.TransInSuppInfo.Code = "006"; //供应商       
            lineDto.ItemInfo = new CBO.SCM.Item.ItemInfoData();
            lineDto.ItemInfo.ItemCode = stocks.ItemID.Code;    
            //lineDto.ItemInfo.ItemCode = "320060023";   //料品信息
            lineDto.TransInWh = new CommonArchiveDataDTOData //库位
            {
                ID = stocks.StockID.ID,
            };
            lineDto.ZeroCost = true;  //零成本
            lineDto.SysState = ObjectState.Inserted;

            //子表
            List<IC_TransInSubLineDTOData> SubLineList = new List<IC_TransInSubLineDTOData>();
            IC_TransInSubLineDTOData SubLine = new IC_TransInSubLineDTOData();
            SubLine.TransOutOrg = new CommonArchiveDataDTOData  //调出组织
            {
                Code = "201",
            };
            SubLine.TransOutWh = new CommonArchiveDataDTOData //库存地址
            {
                Code = "20101",
            };
            //SubLine.TransOutSuppInfo  //供应商
            //SubLine.TransOutCustInfo //客户
            //SubLine.TransInSUQty   //调入数量
            //SubLine.DocLineNo  //子行号
            //SubLine.StoreUOM  //调出单位
            //SubLine.StoreUOMQty  //调出数量
            //SubLine.CostPrice //单价
            //SubLine.CostMoney  //成本
            //SubLine.ZeroCost   //零成本
            SubLine.LotInfo = new CBO.SCM.PropertyTypes.LotInfoData();
            //SubLine.LotInfo   //有效性
            //SubLine.TransOutDept      //部门
            SubLine.SysState = ObjectState.Inserted;
            SubLineList.Add(SubLine);
            lineDto.TransInSubLines = SubLineList;
            LineList.Add(lineDto);
            }
            headDto.TransInLines = LineList;
            return headDto;
        }
    }

    #endregion


}