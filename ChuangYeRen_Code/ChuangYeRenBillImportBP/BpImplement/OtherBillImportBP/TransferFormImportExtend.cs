namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.ISV.TransferFormISV;
    using UFIDA.U9.ISV.TransferFormISV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL.Engine;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// TransferFormImport partial 
    /// </summary>	
    public partial class TransferFormImport
    {
        internal BaseStrategy Select()
        {
            return new TransferFormImportImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class TransferFormImportImpementStrategy : BaseStrategy
    {
        public TransferFormImportImpementStrategy() { }//形态转换导入

        public override object Do(object obj)
        {
            TransferFormImport bpObj = (TransferFormImport)obj;
            //UFIDA::U9::ISV::TransferFormISV::CommonCreateTransferFormSRV 
            //UFIDA.U9.ISV.TransferFormISV.dll 
            CommonCreateTransferFormSRVProxy  CreateProxy= new CommonCreateTransferFormSRVProxy();
            #region 公共传输对象PublicReturnDTO
            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            #endregion            
            CreateProxy.TransferFormDTOList = new List<IC_TransferFormDTOData>();
            try
            {
               
                #region  创建形态转换单
                IC_TransferFormDTOData transferhead = getInfo(bpObj.ID);
                CreateProxy.TransferFormDTOList.Add(transferhead);
                var data = CreateProxy.Do();
                if (data.Count == 0) return pub;
                pub.DocNo = data[0].Code;
                pub.DocID = data[0].ID;
                #endregion
                #region  提交形态转换单服务
                CommonCommitTransferFormSRVProxy commitProxy = new CommonCommitTransferFormSRVProxy();
                commitProxy.QueryList = new List<CommonArchiveDataDTOData>();
                CommonArchiveDataDTOData commitDto = new CommonArchiveDataDTOData();
                commitDto.ID = pub.DocID;
                commitDto.SysState = ObjectState.NeedLoad;
                commitProxy.QueryList.Add(commitDto);
                commitProxy.Do();
                #endregion
                #region 形态转换单审核
                CommonApprovedTransferFormSRVProxy approvedProxy = new CommonApprovedTransferFormSRVProxy();
                approvedProxy.QueryList = new List<CommonArchiveDataDTOData>();
                CommonArchiveDataDTOData archivedto = new CommonArchiveDataDTOData();
                archivedto.ID = pub.DocID;
               // dataDto.Code = pub.DocNo;
                archivedto.SysState = ObjectState.Operating;
                approvedProxy.QueryList.Add(archivedto);
                approvedProxy.Do();
                #endregion

            }
            catch (Exception ex)
            {
                pub.Message = ex.Message;

            }
            return pub;
        }

        private IC_TransferFormDTOData getInfo(long stockID)
        {
            //InvStockBE.InvStock invHead = InvStockBE.InvStock.Finder.FindByID(stockID);
            //InvStockBE.InvStocks.EntityList invLines = invHead.InvStocks;    
            #region 表头                   
            IC_TransferFormDTOData transferhead = new IC_TransferFormDTOData();
            transferhead.TransferFormTransType = new CommonArchiveDataDTOData  //单据类型
            {
                //Code = "TransForm001",
                Code = "ZH01",
            };
            //headDto.DocNo = "";//单据号
            transferhead.BussinessDate = System.DateTime.Now; //日期
            transferhead.SOBAccountPeriod = new CommonArchiveDataDTOData //记账期间
            {
                ID = 1001509010000298,
            };
            transferhead.Org = new CommonArchiveDataDTOData //组织机构
            {
                Code = "201",
            };
            transferhead.Memo = ".net测试"; //备注
            
            #region 表行
            //foreach (var invline in invLines)
            //{
            transferhead.TransferFormLine = new List<IC_TransferFormLDTOData>();

            IC_TransferFormLDTOData transferline = new IC_TransferFormLDTOData();
            transferline.OwnOrg = new CommonArchiveDataDTOData
            {
                Code = "201",
            };
            transferline.ItemInfo = new CBO.SCM.Item.ItemInfoData
            {
                //ItemCode = invline.Item,
                ItemCode = "301020001",
            };
            transferline.StoreUOMQty = 1; //数量
            //transferline.TransferType = 0; //转换类别            
            transferline.CostUOMQty = 1; //成本数量           
            transferline.StoreType = 4; //存储类型 4可用
            transferline.Project = new CommonArchiveDataDTOData
            {
                Code = "68012",
            };
            transferline.Wh = new CommonArchiveDataDTOData //存储地点
            {
                Code = "20101",
            };
            //line.WhMan = new CommonArchiveDataDTOData //库管员
            //{
            //    Code = "",
            //};
            //line.CostCurrency = new CommonArchiveDataDTOData //币种
            //{
            //    Code = "C001",
            //};
            //line.CostMoney = 50;  //成本金额
            //line.CostPrice = 50; //成本单价
            transferline.IsCostDependent = true; //成本联动
            //line.IsZeroCost //零成本
            //line.uom = new CommonArchiveDataDTOData //单位
            //{
            //    Code = "S001",
            //};
            transferline.Memo = ".net测试";//备注   
            transferline.SysState = 0;
            
            #region   子行
            transferline.TransferFormSubLine = new List<IC_TransferFormSLDTOData>();
            IC_TransferFormSLDTOData transferSLine = new IC_TransferFormSLDTOData();
            transferSLine.ItemInfo = new CBO.SCM.Item.ItemInfoData
            {
                ItemCode = "301020001",
            };
            transferSLine.CostUOMQty = 1;
            //SLine.CostPrice = 50;
            //SLine.CostMoney = 50;
            transferSLine.Project = new CommonArchiveDataDTOData
            {
                Code = "63047",
            };
            transferSLine.Wh = new CommonArchiveDataDTOData
            {
                Code = "20101",
            };
            transferSLine.StoreType = 4;
           // transferSLine.SysState = 0;
            #endregion           
            transferline.TransferFormSubLine.Add(transferSLine);
            transferhead.TransferFormLine.Add(transferline);
            #endregion
            #endregion
            transferhead.SysState = ObjectState.Inserted;
            return transferhead;
        }
    }

    #endregion


}