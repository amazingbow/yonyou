namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
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

            return pubResult;
        }
    }

    #endregion


}