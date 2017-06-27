

namespace UFIDA.U9.Cust.XMJL.BOMMasterBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.Profile;
    using UFIDA.U9.Base.UOM;
    using UFIDA.U9.CBO.MFG.Enums;
    using UFIDA.U9.CBO.MFG.ItemProductionLine;
    using UFIDA.U9.CBO.MFG.ProductionLine;
    using UFIDA.U9.SM.SO;
    using UFIDA.UBF.MD.Business;
    using UFSoft.UBF.Business;


    public partial class AfterInserted
    {

        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.CBO.MFG.BOM.BOMMaster holder = key.GetEntity() as UFIDA.U9.CBO.MFG.BOM.BOMMaster;
            if (holder == null)
                return;
            //bom料号+生产目的 匹配 销售订单行上面的料号+生产目的=》
            //销售部门= 生产线下面的部门---然后生成料品生产线关系对应的几条。
            var ext = ExtEnumValue.Finder.Find("ExtEnumType.Code='UFIDA.U9.CBO.MFG.Enums.AlternateTypesEnum' and EValue=" + holder.AlternateType.Value);
            var soLine = SOLine.Finder.FindAll("ItemInfo.ItemID=" + holder.ItemMaster.ID
                + " and DescFlexField.PubDescSeg4='" + ext.Code + "'");
            using (ISession session = Session.Open())
            {
                foreach (SOLine item in soLine)
                {
                    if (item.SO.SaleDepartment == null) continue;
                    ProductionLine line = ProductionLine.Finder.Find("Department.ID=" + item.SO.SaleDepartment.ID);
                    ItemProdLineLink itemProd = ItemProdLineLink.Create();
                    itemProd.Org = Context.LoginOrg;
                    itemProd.MasterOrg = holder.ItemMaster.Org;
                    itemProd.BOMSubstituteType = holder.AlternateType;
                    itemProd.ItemMaster = holder.ItemMaster;
                    itemProd.RoutingSubstituteType = holder.AlternateType;
                    itemProd.OSSequence = ParallelLineRule.LinePriority;
                    itemProd.OSDirection = ScheduleTypeEnum.Both;
                    itemProd.AnchorDays = 0;
                    itemProd.ProductionLine = line;
                    itemProd.Priority = 100;
                    itemProd.Sequence = 10;
                    itemProd.LeadTime = 10;
                    itemProd.LeadTimeType = LeadTimeTypeEnum.FixedLeadTime;
                    itemProd.LeadTimeUOM = UOM.FindByCode("Day");
                    //itemProd.Bin = line.w
                    itemProd.EffectiveDate = DateTime.Now;
                    //itemProd.LowPlanedQty
                    itemProd.LowPlanedQtyType = LowPlanedQtyTypeEnum.UnallowedType;
                    //itemProd.OverPlanedQty
                    itemProd.OverPlanedQtyType = OverPlanedQtyTypeEnum.UnallowedType;
                    //itemProd.WareHouse
                    //itemProd.ProductivityChgLogs
                }
                session.Commit();
            }

            #endregion
        }
    }
}
