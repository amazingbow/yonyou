

namespace UFIDA.U9.Cust.XMJL.UpdateTransferInPlugBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    using UFIDA.U9.InvDoc.TransferIn;


    public partial class AfterValidate
    {

        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.InvDoc.TransferIn.TransferIn holder = key.GetEntity() as UFIDA.U9.InvDoc.TransferIn.TransferIn;
            if (holder == null)
                return;
            if (holder.TransInLines.Count > 0)
            {
                var temp = TransInSubLine.Finder.Find("TransInLine=" + holder.TransInLines[0].ID);
                if (temp != null && temp.TransOutWh != null)
                {
                    holder.DescFlexField.PrivateDescSeg2 = temp.TransOutWh.DescFlexField.PrivateDescSeg1;
                }
                foreach (var item in holder.TransInLines)
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
