

namespace UFIDA.U9.Cust.UpdateMiscRcvTransPricePlugBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.Item;


    public partial class BeforeDefaultValue
    {

        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.InvDoc.MiscRcv.MiscRcvTrans holder = key.GetEntity() as UFIDA.U9.InvDoc.MiscRcv.MiscRcvTrans;
            if (holder == null)
                return;
            if (holder.MiscRcvTransLs != null && holder.MiscRcvTransLs.Count > 0)
            {
                foreach (var item in holder.MiscRcvTransLs)
                {
                    if (item.CostPrice == 0)
                    {
                        if (item.ItemInfo != null && item.ItemInfo.ItemID != null)
                        {
                            item.CostPrice = item.ItemInfo.ItemID.RefrenceCost == 0 ? Decimal.Parse(item.ItemInfo.ItemID.DescFlexField.PubDescSeg1) : item.ItemInfo.ItemID.RefrenceCost;
                        }
                    }
                }
            }
            #endregion

        }
    }
}
