

namespace UFIDA.U9.Cust.HX
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE;
    using UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE;

    public partial class AfterDeleted
    {

        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.GL.Voucher.Voucher holder = key.GetEntity() as UFIDA.U9.GL.Voucher.Voucher;
            if (holder == null)
                return;
            using (ISession session=Session.Open())
            {
                HeXingSAPU9GLVoucherHead voucher = HeXingSAPU9GLVoucherHead.Finder.Find("U9VoucherID=" + holder.ID);
                var refBe = RefVoucherInfoBE.Finder.FindAll("VoucherID=" + holder.ID);//关系对照表中被U9凭证引用的
                if (voucher != null)
                {
                    voucher.IsU9Successful = ImportFlagEnum.NotProcess;//未导入的状态
                    voucher.U9ErrorResult = "导入出错，删掉凭证重新导入";
                }
                if (refBe != null)
                {
                    foreach (var item in refBe)
                    {
                        item.Remove();
                    }
                }
                session.Commit();
            }
           
            #endregion

        }
    }
}
