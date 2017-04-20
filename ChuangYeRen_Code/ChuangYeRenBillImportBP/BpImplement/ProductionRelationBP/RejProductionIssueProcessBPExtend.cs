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
            InvStock invStock = InvStock.Finder.FindByID(bpObj.RelationId);
            if (invStock == null)
            {

            }
            RecedeItemAndSnDTOData dto = new RecedeItemAndSnDTOData
            {

            };
            return pubResult;
        }
    }

    #endregion


}