namespace UFIDA.U9.Cust.XMJL.VoucherSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.GL.Voucher;

    /// <summary>
    /// ApproveVoucherSV partial 
    /// </summary>	
    public partial class ApproveVoucherSV
    {
        internal BaseStrategy Select()
        {
            return new ApproveVoucherSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ApproveVoucherSVImpementStrategy : BaseStrategy
    {
        public ApproveVoucherSVImpementStrategy() { }

        public override object Do(object obj)
        {
            ApproveVoucherSV bpObj = (ApproveVoucherSV)obj;
            List<long> keys = bpObj.KeyList;
            List<Voucher.EntityKey> list = new List<Voucher.EntityKey>();
            foreach (long key in keys)
            {
                Voucher Voucher = Voucher.Finder.FindByID(key);
                Voucher.EntityKey entityKey = Voucher.Key;
                list.Add(entityKey);
            }
            if (list.Count > 0)
            {
                VoucherSubmit submitBP = new VoucherSubmit();
                submitBP.Voucher = list;
                submitBP.IsApproving = true;
                submitBP.IsMessage = false;
                submitBP.Do();

                //VoucherApproved bp = new VoucherApproved();
                //bp.Voucher = list;
                //bp.Do();
            }

            return "审核成功：共审核" + list.Count + "条凭证";
        }
    }

    #endregion


}