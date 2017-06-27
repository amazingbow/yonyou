namespace UFIDA.U9.Cust.XMJL.ARBillSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.AR.ARBill;

    /// <summary>
    /// ApproveARBillSV partial 
    /// </summary>	
    public partial class ApproveARBillSV
    {
        internal BaseStrategy Select()
        {
            return new ApproveARBillSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ApproveARBillSVImpementStrategy : BaseStrategy
    {
        public ApproveARBillSVImpementStrategy() { }

        public override object Do(object obj)
        {
            ApproveARBillSV bpObj = (ApproveARBillSV)obj;

            List<long> ids = bpObj.ArBillHeadKey;
            try
            {
                foreach (long id in ids)
                {
                    UFIDA.U9.AR.ARBill.ARBillHead arBillHead = UFIDA.U9.AR.ARBill.ARBillHead.Finder.FindByID(id);
                    if (arBillHead == null)
                    {
                        throw new NullReferenceException("没有找到对应ID的单据");
                    }
                    ARBillSubmitBP aRBillSubmitBP = new ARBillSubmitBP();
                    aRBillSubmitBP.ARBillHeadKey = arBillHead.Key;
                    aRBillSubmitBP.CurrentSysVersion = arBillHead.SysVersion;
                    aRBillSubmitBP.Do();

                    ARBillApproveBP aRBillApproveBP = new ARBillApproveBP();
                    aRBillApproveBP.ARBillHeadKey = arBillHead.Key;
                    aRBillApproveBP.CurrentSysVersion = arBillHead.SysVersion;
                    aRBillApproveBP.Do();
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