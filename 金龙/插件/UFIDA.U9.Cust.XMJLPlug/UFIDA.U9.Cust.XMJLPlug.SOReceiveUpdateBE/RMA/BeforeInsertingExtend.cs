

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


    public partial class BeforeInserting
    {

        private void Do_Notify(object[] args)
        {

            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.SM.RMA.RMA holder = key.GetEntity() as UFIDA.U9.SM.RMA.RMA;
            if (holder == null)
                return;
            if (holder.SrcDocType != RMASrcDocTypeEnum.Rcv) return;
            holder.Status = RMAStatusEnum.Posted;
            holder.IsBizClosed = true;
            holder.ApprovedBy = Context.LoginUser;
            holder.ApprovedOn = DateTime.Now;
            foreach (var item in holder.RMALines)
            {
                if (item.SrcDocLine == null) continue;
                var rcvLine = RcvLine.Finder.FindByID(item.SrcDocLine.ID);
                if (rcvLine != null)
                {
                    item.OrderPrice = rcvLine.FinallyPriceTC;
                    item.ApplyPrice = rcvLine.FinallyPriceTC;
                    item.RtnPice = rcvLine.FinallyPriceTC;
                    item.RtnMoneyTC = rcvLine.TotalMnyTC;
                    item.RtnMoneyFC = rcvLine.TotalMnyTC;
                    item.RtnMoneyAC = rcvLine.TotalMnyTC;
                    item.ApplyMoneyTC = rcvLine.TotalMnyTC;

                    var rate = 0M;
                    if (item.TaxSchedule != null)
                    {
                        foreach (var tax in item.TaxSchedule.TaxScheduleTaxs)
                        {
                            if (tax.Tax != null)
                            {
                                rate += tax.Tax.TaxRate;
                                //if (item.LineTaxs.Count == 0)
                                //{
                                //    var line = LineTax.Create(item);
                                //    line.TaxType = tax.Tax;
                                //    line.TaxRate = tax.Tax.TaxRate;
                                //    line.TotalTaxAC = (item.RtnMoneyAC / (1 + line.TaxRate)) * line.TaxRate;
                                //    line.TotalTaxFC = line.TotalTaxAC;
                                //    line.TotalTaxTC = line.TotalTaxTC;
                                //    item.LineTaxs.Add(line);
                                //}
                            }
                        }
                    }
                    item.TaxRate = rate;
                    //item.TotalTaxTC = Math.Round(item.RtnMoneyTC * item.TaxRate / (1 + item.TaxRate), 2);
                    item.TotalTaxTC = rcvLine.TotalTaxTC;
                    item.TotalTaxAC = rcvLine.TotalTaxAC;
                    item.TotalTaxFC = rcvLine.TotalTaxFC;
                    item.CanInvoiceQtyPU = item.RtnQtyPU;
                    item.CanInvoiceTaxTotalAC = item.TotalTaxAC;
                    //item.IsRevaluated = true;
                    //item.RevaluateDate = DateTime.Now;
                    item.AccountDate = holder.BusinessDate;
                    item.MaturityDate = holder.BusinessDate;
                    item.ApprovedBy = Context.LoginUser;
                    item.ApprovedOn = DateTime.Now;
                    item.CloseDate = DateTime.Now;
                    item.Status = RMAStatusEnum.Posted;
                }
            }

            #endregion

        }
    }
}
