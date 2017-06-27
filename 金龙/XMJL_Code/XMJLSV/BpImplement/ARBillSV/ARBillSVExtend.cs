namespace ARBillSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;

    /// <summary>
    /// ARBillSV partial 
    /// </summary>	
    public partial class ARBillSV
    {
        internal BaseStrategy Select()
        {
            return new ARBillSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ARBillSVImpementStrategy : BaseStrategy
    {
        public ARBillSVImpementStrategy() { }

        public override object Do(object obj)
        {
            ARBillSV bpObj = (ARBillSV)obj;
            List<long> ids = bpObj.ArBillHeadKey;

            try
            {
                foreach (long id in ids)
                {
                    UFIDA.U9.AR.ARBill.ARBillHead arBillHead = UFIDA.U9.AR.ARBill.ARBillHead.Finder.FindByID(id);
                    using (Session session = Session.Open())
                    {
                        arBillHead.DocStatus = UFIDA.U9.CBO.FI.Enums.BillStatusEnum.Approving;
                        session.Commit();
                    }
                    using (Session session = Session.Open())
                    {
                        arBillHead.DocStatus = UFIDA.U9.CBO.FI.Enums.BillStatusEnum.Approved;
                        session.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return "ok";
        }
    }

    #endregion


}