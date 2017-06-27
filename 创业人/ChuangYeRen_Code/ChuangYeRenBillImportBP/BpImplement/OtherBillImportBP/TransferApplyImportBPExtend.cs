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
                IC_TransferInDTOData ApplyDto = getInfo(bpObj.InSourceID, bpObj.OutSourceID);
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
                    Code = pub.DocNo,
                    ID = pub.DocID,
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

        private IC_TransferInDTOData getInfo(long InSourceID, long OutSourceID)
        {

            #region  表头信息(含表行、子行)
            IC_TransferInDTOData headDto = new IC_TransferInDTOData();
            //入库单头信息inStock
            //InvStock inStock = InvStock.Finder.FindByID(InSourceID);
            headDto.CreatedBy = Context.LoginUser;//inStock.CreatedBy;
            headDto.CreatedOn = System.DateTime.Now;//inStock.CreatedOn;
            //headDto.CreatedOn = //inStock.CreatedOn;    //创建时间
            headDto.Org = new CommonArchiveDataDTOData //组织
            {
                ID = 1001504150120242, //inStock.OrgID,
            };
            headDto.TransInDocType = new CommonArchiveDataDTOData   //单据类型
            {
                Code = "DR02"
                //Name = inStock.IOC.Name,
            };
            headDto.TransferType = 0;       //调入类型
            headDto.TransferDirection = 0;      //调拨方向
            headDto.BusinessDate = System.DateTime.Now; //日期
            headDto.Memo = "测试";//inStock.CNote;    //备注
            //headDto.DocNo = inStock.BillNO;//单据编号
            #region 表头不需传值部分
            //headDto.DescFlexField //实体扩展字段
            //headDto.ID //ID
            //headDto.SOBAccountPeriod = Stock.peroid //记账期间
            //headDto.ApprovedBy = Stock.;  //审核人
            // headDto.Status = 2; // 状态
            #endregion

            #region 表行含子行
            List<IC_TransInLineDTOData> LineList = new List<IC_TransInLineDTOData>();
            //入库单行信息
            //InvStocks.EntityList<InvStocks> stocksList = inStock.InvStocks;
            //foreach (InvStocks stocks in stocksList)
            //{
            IC_TransInLineDTOData lineDto = new IC_TransInLineDTOData();
            //lineDto.DocLineNo=  //行号 
            //lineDto.Project=stocks.     //项目

            //lineDto.StoreUOM = new CommonArchiveDataDTOData
            //{
            //    ID = stocks.ItemID.UOM.ID,
            //};    //调入库存单位
            lineDto.StoreUOMQty = 1; //stocks.InQty;  //调入库存数量

            //lineDto.LotInfo = new CBO.SCM.PropertyTypes.LotInfoData
            //{
            //    LotCode = stocks.BarCode,
            //}; //批号
            lineDto.CostCurrency = new CommonArchiveDataDTOData
            {
                ID = 1,
                //ID = stocks.Currency.ID,
            };  //币种
            //lineDto.CostPrice = 1; //单价
            //lineDto.CostUOMQty = 1;
            //lineDto.CostMoney = (lineDto.CostPrice * lineDto.CostUOMQty); //成本

            // lineDto.TransInSuppInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();

            lineDto.ItemInfo = new CBO.SCM.Item.ItemInfoData();
            lineDto.ItemInfo.ItemCode = "301020001";//stocks.ItemID.Code;
            lineDto.StorageType = 4;
            //UFIDA.U9.CBO.SCM.ProjectTask.Project Project = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.Find("Org ='" + 组织编码 + "' and Code='" + 项目编码 + "'");
            UFIDA.U9.CBO.SCM.ProjectTask.Project Project = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.Find("Org =" + 组织ID + " and Code='" + 项目编码 + "'");
            long ProjectId =Project.ID;
            lineDto.Project = new CommonArchiveDataDTOData();
            lineDto.Project.ID = 1001508120038268;
            lineDto.TransInWh = new CommonArchiveDataDTOData //库位
            {
                Code = "20201",
                // ID = stocks.StockID.ID,
            };
            // lineDto.ZeroCost = true;  //零成本
            #region 表行不需传值部分
            //lineDto.CostUOM   //成本单位

            //lineDto.CostUOMQty = stocks.InQty;
            //lineDto.IsVMI     //IsVMI标志
            //lineDto.TransInSuppInfo.Code = "006";
            //lineDto.TransInSuppInfo.Code = "006"; //供应商       
            //lineDto.ItemInfo.ItemCode = "320060023";   //料品信息
            #endregion

            #region  子行信息

            //出库单信息
            //InvStock outStock = InvStock.Finder.FindByID(OutSourceID);
            //InvStocks.EntityList outInvStocksList = outStock.InvStocks;
            //子行信息
            List<IC_TransInSubLineDTOData> SubLineList = new List<IC_TransInSubLineDTOData>();
            IC_TransInSubLineDTOData SubLine = new IC_TransInSubLineDTOData();
            //foreach (var outInvStocks in outInvStocksList)
            //{
            SubLine.TransOutOrg = new CommonArchiveDataDTOData
            {
                ID = 1001504150120017,
            };
            //if (outInvStocks.Item != outInvStocks.Item) continue;
            SubLine.TransOutWh = new CommonArchiveDataDTOData //库存地址
            {
                Code = "20101",//outInvStocks.StockID.ID,
            };
            SubLine.StoreUOMQty = 1;//outInvStocks.InQty;  //调出数量
            SubLine.StorageType = 4;
            SubLine.TransOutCustInfo = new CBO.SCM.Customer.CustomerMISCInfoData
            {
                Customer = 1001505050112514,//客户ID
                //Code = "",  //客户Code
                //Name = "", //客户名称                
            };
            //SubLine.Project = new CommonArchiveDataDTOData
            //{
            //    ID = 1001508120038459,
            //    SysState = ObjectState.NeedLoad,
            //};
            //SubLine.LotInfo = new CBO.SCM.PropertyTypes.LotInfoData()
            //{
            //    LotCode = outInvStocks.BarCode,
            //};
            #region 子行不需传值部分
            //        SubLine.TransOutOrg = new CommonArchiveDataDTOData  //调出组织
            //{
            //    ID = outInvStocks.,
            //};
            //SubLine.DocLineNo=outStock.
            //SubLine.TransOutSuppInfo  //供应商
            //SubLine.TransOutCustInfo //客户
            //SubLine.TransInSUQty   //调入数量
            //SubLine.DocLineNo  //子行号
            //SubLine.StoreUOM  //调出单位
            //SubLine.CostPrice //单价
            //SubLine.CostMoney  //成本
            //SubLine.ZeroCost   //零成本
            //SubLine.LotInfo   //有效性
            //SubLine.TransOutDept      //部门
            #endregion
            SubLine.SysState = ObjectState.Inserted;
            SubLineList.Add(SubLine);

            //   }
            lineDto.TransInSubLines = SubLineList;
            #endregion
            lineDto.SysState = ObjectState.Inserted;
            LineList.Add(lineDto);
            headDto.TransInLines = LineList;
            headDto.SysState = ObjectState.Inserted;

            // }
            #endregion

            return headDto;
            #endregion
        }
    }


    #endregion
}