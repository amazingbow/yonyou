namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
    using System;
    using System.Collections.Generic;
    using UFSoft.UBF.AopFrame;
    using UFIDA.U9.PM.Rcv;
    using UFSoft.UBF.Business;

    /// <summary>
    /// ApproveRcvSV partial 
    /// </summary>	
    public partial class ApproveRcvSV
    {
        internal BaseStrategy Select()
        {
            return new ApproveRcvSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ApproveRcvSVImpementStrategy : BaseStrategy
    {
        public ApproveRcvSVImpementStrategy() { }

        public override object Do(object obj)
        {
            ApproveRcvSV bpObj = (ApproveRcvSV)obj;
            List<long> ids = bpObj.DocHeadIDs;
            List<Receivement.EntityKey> list = new List<Receivement.EntityKey>();
            foreach (long id in ids)
            {
                Receivement data = Receivement.Finder.FindByID(id);
                Receivement.EntityKey key = data.Key;
                list.Add(key);
            }
            if (list.Count > 0)
            {
                RcvBatchApprovedBP bp = new RcvBatchApprovedBP();
                bp.ActType = PM.Enums.ActivateTypeEnum.ApprovedAct;
                bp.DocHeadIDs = list;
                bp.Do();
            }
            return "审核成功";
        }
    }

    #endregion


}