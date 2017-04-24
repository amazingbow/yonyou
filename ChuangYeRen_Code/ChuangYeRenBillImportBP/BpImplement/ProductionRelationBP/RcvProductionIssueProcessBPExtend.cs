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
    /// RcvProductionIssueProcessBP partial 
    /// </summary>	
    public partial class RcvProductionIssueProcessBP
    {
        internal BaseStrategy Select()
        {
            return new RcvProductionIssueProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class RcvProductionIssueProcessBPImpementStrategy : BaseStrategy
    {
        public RcvProductionIssueProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            RcvProductionIssueProcessBP bpObj = (RcvProductionIssueProcessBP)obj;
            PublicReturnDTO pubResult = new PublicReturnDTO();
            CreateIssue4ExternalProxy createIssue = new CreateIssue4ExternalProxy();
            try
            {
                createIssue.IssueDTOs = GetIssueDoc(bpObj.RelationId);
                createIssue.Do();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return pubResult;
        }

        private List<IssueDTOData> GetIssueDoc(long id)
        {
            List<IssueDTOData> issueLst = new List<IssueDTOData>();
            InvStock invStock = InvStock.Finder.FindByID(id);

            return issueLst;
        }
    }

    #endregion


}