namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.ISV.MO;
    using UFIDA.U9.ISV.MO.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// RejProductionIssueProcessBP partial 
    /// </summary>	
    public partial class RejProductionIssueProcessBP
    {
        internal BaseStrategy Select()
        {
            return new RejProductionIssueProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class RejProductionIssueProcessBPImpementStrategy : BaseStrategy
    {
        public RejProductionIssueProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            RejProductionIssueProcessBP bpObj = (RejProductionIssueProcessBP)obj;
            PublicReturnDTO pubResult = new PublicReturnDTO();
            CreatRecedeIssueDocSVProxy proxy = new CreatRecedeIssueDocSVProxy();
            proxy.RecedeItemAndSnDTOList = new List<RecedeItemAndSnDTOData>();
            proxy.IsAutoIssued = true;
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationId);
            if (invStock == null)
            {
                pubResult.Flag = false;
                pubResult.Message = "所传ID找不到对应数据！";
                return pubResult;
            }
            foreach (var item in invStock.InvStocks)
            {
                RecedeItemAndSnDTOData dto = new RecedeItemAndSnDTOData
                {
                    ItemCode = item.ItemID.Code,
                    ItemName = item.ItemID.Name,
                    RecedeQty = item.InQty,
                    WhCode = item.StockID.Code,
                    WhName = item.StockID.Name,
                    //SnCode = "",
                    //NewSnCode = "",
                    //PickID = 0,
                    //RecedeReason = 0
                };
                proxy.RecedeItemAndSnDTOList.Add(dto);
            }
            try
            {
                var result = proxy.Do();

            }
            catch (Exception ex)
            {
                pubResult.Message = ex.Message;
                pubResult.Flag = false;
            }
            return pubResult;
        }
    }

    #endregion


}