namespace UFIDA.U9.Cust.XMJL.RecBillSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.AR.Receival;

    /// <summary>
    /// ApproveRecBillSV partial 
    /// </summary>	
    public partial class ApproveRecBillSV
    {
        internal BaseStrategy Select()
        {
            return new ApproveRecBillSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ApproveRecBillSVImpementStrategy : BaseStrategy
    {
        public ApproveRecBillSVImpementStrategy() { }

        public override object Do(object obj)
        {
            ApproveRecBillSV bpObj = (ApproveRecBillSV)obj;

            List<long> ids = bpObj.RecBillHeadKey;
            try
            {
                foreach (long id in ids)
                {
                    UFIDA.U9.AR.Receival.RecBillHead recBillHead = UFIDA.U9.AR.Receival.RecBillHead.Finder.FindByID(id);

                    RecBillApprovingBP bp = new RecBillApprovingBP();
                    bp.IsBatchProcess = true;
                    bp.RecBillHead = recBillHead.Key;
                    bp.CurrentSysVersion = recBillHead.SysVersion;
                    bp.Do();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return "审核成功";
        }
    }

    #endregion


}