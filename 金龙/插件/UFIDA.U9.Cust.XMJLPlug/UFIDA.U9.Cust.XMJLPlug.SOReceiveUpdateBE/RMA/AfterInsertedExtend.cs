

namespace UFIDA.U9.Cust.XMJLPlug.SOReceiveUpdateBE
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.PM.Rcv;
    using UFIDA.U9.SM.RMA;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.Cust.XMJLPlug.SOReceiveUpdateBE;
    using UFSoft.UBF.Sys.Database;
    using UFIDA.U9.SM.RMA.Proxy;


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
            UFIDA.U9.SM.RMA.RMA rma = key.GetEntity() as UFIDA.U9.SM.RMA.RMA;
            if (rma == null)
                return;
            //RMAOneBizColseBPProxy proxy = new RMAOneBizColseBPProxy();
            //proxy.RMA = new U9.SM.RMA.RMAUIVerDTOData { RMAKey = rma.ID };
            //proxy.RMALine = new RMALineUIVerDTOData { RMALineKey = rma.RMALines };
            if (rma.SrcDocType != RMASrcDocTypeEnum.Rcv) return;
            DataSet data = null;
            DataAccessor.RunSQL(DataAccessor.GetConn(), "update SM_RMALine set Status=4 , IsRevaluated=1 where RMA=" + rma.ID, null, out data);
            var i = 1;
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            foreach (var item in rma.RMALines)
            {
                if (item.RMAInstalmentBillings.Count > 0) continue;

                var billi = RMAInstalmentBilling.Create(item);
                #region 退回处理分期立账子表
                var billDate = rma.BusinessDate.ToString("yyyy-MM-dd HH:mm:ss");
                string insert = string.Format(@"insert into SM_RMAInstalmentBilling (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,DocLineNo,AccrueTermLine,BillingDate,MaturityDate,InstalmentMoney ,
                                InstalmentPercent ,ReturnQtyTU ,ReturnQtyPU ,InstMoneyAC ,InstTaxAC,InstMoneyACNet,InstPriceAC ,RMALine,BillingStatus) 
                                values({0},'{1}','{2}','{1}','{2}'," + i + "," + i + ",'{3}','{3}',{4},1.00,{5},{6},{7},{8},{9},{10},{11},0);" +
                                @"insert into SM_RMAInstalmentBilling_Trl(ID,SysMLFlag,DescFlexField_CombineName) values({0},'zh-CN','')",
                                billi.ID, time, Context.LoginUser, billDate, item.RtnMoneyAC, item.RtnQtyTU1, item.RtnQtyPU, item.RtnMoneyAC, item.TotalTaxAC,
                                item.RtnMoneyAC - item.TotalTaxAC, item.RtnPice, item.ID);
                DataAccessor.RunSQL(DataAccessor.GetConn(), insert, null, out data);
                #endregion
                #region 退回处理分期收款子表
                var rcv = RMAInstalmentReceive.Create(billi);
                //                string insertRcv = string.Format(@"insert into SM_RMAInstalmentReceive (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,DocLineNo,AccrueTermLine,MaturityDate,
                //                                InstalmentMoney ,InstalmentPercent, ConfirmBase ,ReceiveQtyTU  ,ReceiveQtyPU ,InstTaxAC,InstMoneyACNet,InstMoneyAC,
                //                                TotalBillingQtyTU,TotalBillingQtyPU,TotalReceiveQtyTU,TotalReceiveQtyPU,TotalBillingMoneyAC,TotalReceiveMoneyAC,RMAInstalmentBilling,
                //                                MaturityDateType) values({0},'{1}','{2}','{1}','{2}'," + i + "," + i + ",'{3}',{4},1.00,0,{5},{6},{7},{8},{4},{5},{6},{5},{6},{4},{4},{9},0)",
                //                               rcv.ID, time, Context.LoginUser, billDate, item.RtnMoneyAC, item.RtnQtyTU1, item.RtnQtyPU, item.TotalTaxAC,
                //                               item.RtnMoneyAC - item.TotalTaxAC, billi.ID, item.ID);
                string insertRcv = string.Format(@"insert into SM_RMAInstalmentReceive (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,DocLineNo,AccrueTermLine,MaturityDate,
                                InstalmentMoney ,InstalmentPercent, ConfirmBase ,ReceiveQtyTU  ,ReceiveQtyPU ,InstTaxAC,InstMoneyACNet,InstMoneyAC,
                                TotalBillingQtyTU,TotalBillingQtyPU,TotalReceiveQtyTU,TotalReceiveQtyPU,TotalBillingMoneyAC,TotalReceiveMoneyAC,RMAInstalmentBilling,
                                MaturityDateType) values({0},'{1}','{2}','{1}','{2}'," + i + "," + i + ",'{3}',{4},1.00,0,{5},{6},{7},{8},{4},0,0,0,0,0,0,{9},0)",
                           rcv.ID, time, Context.LoginUser, billDate, item.RtnMoneyAC, item.RtnQtyTU1, item.RtnQtyPU, item.TotalTaxAC,
                           item.RtnMoneyAC - item.TotalTaxAC, billi.ID, item.ID);//TotalBillingQtyTU 16
                DataAccessor.RunSQL(DataAccessor.GetConn(), insertRcv, null, out data);
                #endregion
                #region 保存税子表
                if (item.TaxSchedule != null)
                {
                    foreach (var tax in item.TaxSchedule.TaxScheduleTaxs)
                    {
                        if (tax.Tax != null)
                        {
                            if (item.LineTaxs.Count == 0)
                            {
                                var line = LineTax.Create(item);
                                //var totalTax = (item.RtnMoneyAC / (1 + tax.Tax.TaxRate)) * tax.Tax.TaxRate;
                                string insertLine = string.Format(@"insert into SM_LineTax (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,SysVersion,Org,TaxType,TaxRate,TotalTaxTC ,TotalTaxAC,TotalTaxFC ,
                                    TotalAccountTaxTC ,TotalAccountTaxAC ,RMALine ,RMAInstalmentBilling) values({0},'{1}','{2}','{1}','{2}',0,{3},{4},{5},{6},{7},{8},0,0,{9},{10})",
                                    line.ID, time, Context.LoginUser, Context.LoginOrg.ID, tax.Tax.ID, tax.Tax.TaxRate, item.TotalTaxTC, item.TotalTaxAC, item.TotalTaxFC, item.ID, billi.ID);
                                DataAccessor.RunSQL(DataAccessor.GetConn(), insertLine, null, out data);
                            }
                        }
                    }
                }
                #endregion
                i++;
            }
            #endregion
        }
    }
}
