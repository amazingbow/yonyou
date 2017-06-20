namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// CloseAdvApply partial 
    /// </summary>	
    public partial class CloseAdvApply
    {
        internal BaseStrategy Select()
        {
            return new CloseAdvApplyImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CloseAdvApplyImpementStrategy : BaseStrategy
    {
        public CloseAdvApplyImpementStrategy() { }

        public override object Do(object obj)
        {
            CloseAdvApply bpObj = (CloseAdvApply)obj;
            bool result = false;


            using (ISession session = Session.Open())
            {
                AdvApplyBE advApply = AdvApplyBE.Finder.FindByID(bpObj.ID);
                if (advApply != null)
                {
                    advApply.IsClose = true;
                    result = true;
                }
                else
                {
                    result = false;
                }
                session.Commit();
            }
            return result;
        }
    }

    #endregion


}