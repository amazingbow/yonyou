

namespace UFIDA.U9.Cust.XMJL.UpdateRcvPrice
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.SCMBE;
    using UFIDA.U9.CBO.SCM.Enums;
    using UFIDA.U9.CBO.FI_SCM.DTOs;
    using UFIDA.U9.PM.Rcv;
    using UFIDA.U9.CBO.FI.Tax;
    using UFIDA.U9.PM.Enums;
    using UFIDA.U9.Base.Doc;
    using UFIDA.U9.CBO.SCM.AccrueBy;
    using UFIDA.U9.CBO.FI.MatchLayerSet;
    using UFSoft.UBF.Util.DataAccess;
    using System.Data;


    public partial class BeforeValidate
    {

        private void Do_Notify(object[] args)
        {
            #region 从事件参数中取得当前业务实体

            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.PM.Rcv.RcvLine holder = key.GetEntity() as UFIDA.U9.PM.Rcv.RcvLine;
            if (holder == null)
                return;
            if (holder.FinallyPriceAC > 0 && holder.FinallyPriceTC > 0) return;
            if (holder.IsPresent) return;//如果是赠品的话忽略此逻辑

            var itemMasterId = holder.ItemInfo.ItemID.ID;
            ItemMaster itemMaster = ItemMaster.Finder.Find("ID=@ID", new OqlParam(itemMasterId));
            decimal PubDescSeg1 = 0;
            decimal.TryParse(itemMaster.DescFlexField.PubDescSeg1, out PubDescSeg1);
            decimal price = itemMaster.RefrenceCost == 0 ? PubDescSeg1 : itemMaster.RefrenceCost;
            holder.FinallyPriceAC = price;
            holder.FinallyPriceTC = price;

            if (holder.TaxRate == 0 && holder.TaxSchedule != null)
            {
                decimal rate = 0M;
                foreach (var item in holder.TaxSchedule.TaxScheduleTaxs)
                {
                    rate += item.Tax.TaxRate;
                }
                holder.TaxRate = rate;
            }
            Tax taxType = new Tax();
            if (holder.TaxSchedule != null && holder.TaxSchedule.TaxScheduleTaxs.Count > 0)
            {
                taxType = holder.TaxSchedule.TaxScheduleTaxs[0].Tax;
            }
            else
            {
                taxType = Tax.FindByCode("TP01");//17%进项税
            }
            if (holder.Receivement.ReceivementType.Value == ReceivementTypeEnum.RCV.Value)
            {
                holder.ArriveTotalNetMnyTC = Math.Round(holder.FinallyPriceTC * holder.ArriveQtyPU, 2, MidpointRounding.AwayFromZero);
                holder.ArriveTotalNetMnyAC = holder.ArriveTotalNetMnyTC;
                holder.ArriveTotalNetMnyFC = holder.ArriveTotalNetMnyTC;

                holder.TotalNetMnyTC = Math.Round(holder.FinallyPriceTC * holder.CanAPConfirmQtyPU, 2, MidpointRounding.AwayFromZero);
                holder.TotalNetMnyFC = holder.TotalNetMnyTC;
                holder.TotalNetMnyAC = holder.TotalNetMnyTC;

                holder.ArriveTotalTaxTC = Math.Round(holder.ArriveTotalNetMnyTC * holder.TaxRate, 2, MidpointRounding.AwayFromZero);
                holder.ArriveTotalTaxFC = holder.ArriveTotalTaxTC;
                holder.ArriveTotalTaxAC = holder.ArriveTotalTaxTC;

                holder.TotalTaxTC = Math.Round(holder.TotalNetMnyTC * holder.TaxRate, 2, MidpointRounding.AwayFromZero);
                holder.TotalTaxAC = holder.TotalTaxTC;
                holder.TotalTaxFC = holder.TotalTaxTC;

                holder.ArriveTotalMnyTC = holder.ArriveTotalNetMnyTC + holder.ArriveTotalTaxTC;
                holder.ArriveTotalMnyFC = holder.ArriveTotalMnyTC;
                holder.ArriveTotalMnyAC = holder.ArriveTotalMnyTC;

                holder.TotalMnyTC = holder.TotalNetMnyTC + holder.TotalTaxTC;
                holder.TotalMnyFC = holder.TotalMnyTC;
                holder.TotalMnyAC = holder.TotalMnyTC;

                if (holder.RcvTaxs.Count == 0)
                {
                    RcvTax tax = RcvTax.Create(holder);
                    tax.TaxMnyTC = holder.ArriveTotalTaxTC;
                    tax.TaxMnyFC = holder.ArriveTotalTaxTC;
                    tax.TaxMnyAC = holder.ArriveTotalTaxTC;
                    tax.TaxRate = holder.TaxRate;
                    tax.TaxType = taxType;
                    tax.TaxMnyType = TaxMnyTypeEnum.ArriveTax;
                }
                else
                {
                    foreach (var tax in holder.RcvTaxs)
                    {
                        tax.TaxMnyTC = holder.ArriveTotalTaxTC;
                        tax.TaxMnyFC = holder.ArriveTotalTaxTC;
                        tax.TaxMnyAC = holder.ArriveTotalTaxTC;
                        //tax.TotalConfirmTaxMnyTC = holder.ArriveTotalTaxTC;
                        //tax.TotalConfirmTaxMnyAC = holder.ArriveTotalTaxTC;
                        //tax.TotalConfirmTaxMnyFC = holder.ArriveTotalTaxTC;
                        //tax.TotalMatchTaxMnyTC = holder.ArriveTotalTaxTC;
                        //tax.TotalMatchTaxMnyAC = holder.ArriveTotalTaxTC;
                        //tax.TotalMatchTaxMnyFC = holder.ArriveTotalTaxTC;
                    }
                }
            }

            if (holder.Receivement.ReceivementType.Value == ReceivementTypeEnum.PurReturn.Value)
            {
                holder.RejectNetMnyTC = Math.Round(holder.FinallyPriceTC * holder.RejectQtyPU, 2, MidpointRounding.AwayFromZero);
                holder.RejectNetMnyFC = holder.RejectNetMnyTC;
                holder.RejectNetMnyAC = holder.RejectNetMnyTC;

                holder.RtnDeductNetMnyTC = Math.Round(holder.FinallyPriceTC * holder.RtnDeductQtyPU, 2, MidpointRounding.AwayFromZero);
                holder.RtnDeductNetMnyFC = holder.RtnDeductNetMnyTC;
                holder.RtnDeductNetMnyAC = holder.RtnDeductNetMnyTC;

                holder.RejectTaxMnyTC = Math.Round(holder.RejectNetMnyTC * holder.TaxRate, 2, MidpointRounding.AwayFromZero);
                holder.RejectTaxMnyAC = holder.RejectTaxMnyTC;
                holder.RejectTaxMnyFC = holder.RejectTaxMnyTC;

                holder.RtnDeductTaxTC = Math.Round(holder.RtnDeductNetMnyTC * holder.TaxRate, 2, MidpointRounding.AwayFromZero);
                holder.RtnDeductTaxAC = holder.RtnDeductTaxTC;
                holder.RtnDeductTaxFC = holder.RtnDeductTaxTC;

                holder.RejectMnyTC = holder.RejectNetMnyTC + holder.RejectTaxMnyTC;
                holder.RejectMnyFC = holder.RejectMnyTC;
                holder.RejectMnyAC = holder.RejectMnyTC;

                holder.RtnDeductMnyTC = holder.RtnDeductNetMnyTC + holder.RtnDeductTaxTC;
                holder.RtnDeductMnyFC = holder.RtnDeductMnyTC;
                holder.RtnDeductMnyAC = holder.RtnDeductMnyTC;

                if (holder.RcvTaxs.Count == 0)
                {
                    SaveRcvTaxs(holder, taxType);
                }
                else
                {
                    foreach (var tax in holder.RcvTaxs)
                    {
                        tax.TaxMnyTC = holder.RejectTaxMnyTC;
                        tax.TaxMnyFC = holder.RejectTaxMnyTC;
                        tax.TaxMnyAC = holder.RejectTaxMnyTC;
                    }
                }
            }

            holder.SysPriceAC = price;
            holder.SysPriceTC = price;
            holder.OrderPriceAC = price;
            holder.OrderPriceTC = price;

            #endregion
            SetLineDefaultValuesFromMathchLayer(holder);
        }
        /// <summary>
        /// 立账依据 匹配层级相关属性 一般情况根据匹配层级设定表
        /// </summary>
        /// <param name="line"></param>
        public void SetLineDefaultValuesFromMathchLayer(RcvLine line)
        {
            //特殊处理期初收货单的立账依据、条件、匹配层级
            if (line.Receivement.IsInitEvaluation && !line.Receivement.IsSaleReturn())
            {
                setInitRCVLineConfirmAttr(line);
                if (line.Receivement.IsPurReturn())
                {
                    if (line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value
                    && line.RejectMode.Value == RejectModeEnum.FillDocTrace.Value
                    && line.RtnFillQtyPU > 0 && line.RtnDeductQtyPU == 0)
                    {
                        line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way0;
                        line.ConfirmAccording = null;
                        line.ConfirmTermKey = null;
                        line.ConfirmMode = UFIDA.U9.CBO.SCM.Enums.AccrueModeEnum.Empty;
                        return;
                    }
                }
                return;
            }
            else
            {
                if (((line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value || line.ActivateType == ActivateTypeEnum.OBAUpdate)
                    &&
                    //line.Receivement.BizType.Value != BusinessTypeEnum.PM085.Value) ||
                    !line.Receivement.IsPurReturn()) ||
                    line.SrcDocType.Value == RcvSrcDocTypeEnum.PC.Value
                    )
                {
                    CBO.FI.MatchLayerSet.MatchLayerSet matchLayerSet = line.GetMatchLayerSet();
                    if (matchLayerSet != null)
                    {
                        line.MatchLayer = matchLayerSet.MatchLayer;//从《匹配层级设定表》中取
                        line.ConfirmAccordingKey = matchLayerSet.ConfrimBaseKey;
                    }
                }

                #region
                if (line.Receivement.IsSaleReturn()//销售退回收货不立账
                || line.IsPresent//赠品不立账
                || line.Receivement.BizType.Value == BusinessTypeEnum.PM030.Value//vmi需求补货不立账
                    //||(line.SrcDocType.Value==RcvSrcDocTypeEnum.PO.Value&&line.KITRcvMode.Value==KITShipModeEnum.UnKit.Value)//kit件非成套不立账
                || ((line.SrcDocType.Value == RcvSrcDocTypeEnum.PO.Value
                 || line.SrcDocType.Value == RcvSrcDocTypeEnum.Rcv.Value
                 || line.SrcDocType.Value == RcvSrcDocTypeEnum.PurReturn.Value) && line.Receivement.RcvDocType.IsFillRcv
                && line.SrcDocInfoInvRtn.SrcDoc != null && line.SrcDocInfoInvRtn.SrcDoc.EntityType.Equals(Receivement.EntityRes.BE_FullName))//来源补货po的补货rcv不立账
                    )
                {
                    line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way0;
                    line.ConfirmAccording = null;
                    line.ConfirmTermKey = null;
                    line.ConfirmMode = UFIDA.U9.CBO.SCM.Enums.AccrueModeEnum.Empty;

                }
                #region 2.1 事后调价 若价格为0需立账=false，则对于价格为0的行，立账条件=不立账。匹配层级=0way
                else if (!line.Receivement.IsPurReturn())
                {
                    object PriceMayBeZeroflag = line.GetParameterV(UFIDA.U9.PM.PM_Util.PMParameter.PriceMayBeZero);
                    object OSPF_APflag = null;
                    if (line.SrcDocType == RcvSrcDocTypeEnum.PO)
                    {
                        OSPF_APflag = line.GetParameterV(UFIDA.U9.PM.PM_Util.PMParameter.OutSourcingProcessFees_AP);
                    }
                    else
                    {
                        OSPF_APflag = line.Receivement.GetParameterV(UFIDA.U9.PM.PM_Util.PMParameter.OutSourcingProcessFees_AP_RCV);
                    }



                    if (line.SrcDocType == RcvSrcDocTypeEnum.VMI)
                    {
                        line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way4;
                        line.ConfirmAccording = AccrueBy.FindByCode(PM.Consts.AccrueByConst.AccrueByReceivedQty);
                    }
                    else
                    {
                        if ((line.FinallyPriceTC > decimal.Zero
                            || (line.FinallyPriceTC == Decimal.Zero && (OSPF_APflag != null && Convert.ToBoolean(OSPF_APflag)))
                            )
                            )
                        {
                            line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way4;
                            line.ConfirmAccording = AccrueBy.FindByCode(PM.Consts.AccrueByConst.AccrueByReceivedQty);
                        }
                        else
                        {
                            line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way0;
                            line.ConfirmAccording = null;
                        }
                    }
                }
                #endregion
                //20071016做了较大调整，采退等这样的生单由上游单据生单控制，等
                //if (line.Receivement.BizType == BusinessTypeEnum.PM085)//采退或进退,也是写死的部分
                else if (line.Receivement.IsPurReturn())//采退或进退,也是写死的部分
                {
                    #region 2.5 退货单事后调价 若价格为0需立账=false，则对于价格为0的行，立账条件=不立账。匹配层级=0way

                    object PriceMayBeZeroflag = line.GetParameterV(UFIDA.U9.PM.PM_Util.PMParameter.PriceMayBeZero);
                    object OSPF_APflag = line.Receivement.GetParameterV(UFIDA.U9.PM.PM_Util.PMParameter.OutSourcingProcessFees_AP_RCV);

                    #endregion

                    //if（异动类别.[VMI标志]=“true”）=“0way”,= 不立帐
                    if ((line.Receivement.RcvDocType.IsVMI
                        && line.Receivement.BizType.Value == (int)BusinessTypeEnum.PM030.Value)
                        //额外加的，chenxin设计文档中没有指明
                        || (line.Receivement.RcvDocType.RtnType == UFIDA.U9.PM.Enums.RtnTypeEnum.RevRTN ||
                        line.Receivement.RcvDocType.RtnType == UFIDA.U9.PM.Enums.RtnTypeEnum.IQCRTN)
                        //处理客户问题，zb给的方案
                        //手工创建的补货补的退货单，只有退补数量情况下，不立账。
                        || ((line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value
                       || line.SrcDocType.Value == RcvSrcDocTypeEnum.Rcv.Value)
                       && line.RejectMode.Value == RejectModeEnum.FillDocTrace.Value
                       && line.RtnFillQtyPU > 0 && line.RtnDeductQtyPU == 0)
                        )
                    {
                        line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way0;
                        line.ConfirmAccording = null;
                        line.ConfirmTermKey = null;
                        line.ConfirmMode = UFIDA.U9.CBO.SCM.Enums.AccrueModeEnum.Empty;

                    }
                    else if (line.Receivement.RcvDocType.RtnType == UFIDA.U9.PM.Enums.RtnTypeEnum.INVRTN)
                    {
                        if ((line.FinallyPriceTC > decimal.Zero
                            || (line.FinallyPriceTC == Decimal.Zero && (OSPF_APflag != null && Convert.ToBoolean(OSPF_APflag)))
                            ))
                        {
                            line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way4;
                            line.ConfirmAccording = AccrueBy.FindByCode(PM.Consts.AccrueByConst.AccrueByReceivedQty);
                        }
                        else
                        {
                            line.MatchLayer = CBO.FI.MatchLayerSet.MatchGradeEnum.Way0;
                            line.ConfirmAccording = null;
                        }
                    }

                }

                #endregion
            }

            //立帐条件 if（立账依据＝“不立账”）=null            
            if (line.ConfirmAccordingKey == null)
            {
                line.ConfirmTermKey = null;
            }
            else
            {
                if (line.ConfirmTermKey == null)
                {
                    if (line.Receivement.ConfirmTermKey != null &&
                        (line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value
                        || line.ActivateType.Value == ActivateTypeEnum.OBAUpdate.Value))
                    {
                        line.ConfirmTermKey = line.Receivement.ConfirmTermKey;
                    }
                    //从[供应商]中取
                    //else if ((line.IsInserting()
                    //    || (line.OriginalData != null && line.OriginalData.MatchLayer != line.MatchLayer
                    //     && line.MatchLayer == CBO.FI.MatchLayerSet.MatchGradeEnum.Way4))//0金额不可立账，从0调有价后要立账
                    //    && (line.SrcDocType.Value == RcvSrcDocTypeEnum.Rtn.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.PC.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.SOReturn.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.VMI.Value
                    //    || (line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value && line.Receivement.ConfirmTermKey == null)))
                    else  //修改为有立账依据就取立账条件
                    {
                        if (line.Receivement.Supplier.SupplierKey != null)
                        {
                            line.ConfirmTermKey = line.Receivement.Supplier.Supplier.APConfirmTermKey;
                        }
                    }
                }
            }

            //立帐条件 if（立账依据＝“不立账”）=null            
            if (line.ConfirmAccordingKey == null)
            {
                line.PaymentTermKey = null;
            }
            else
            {
                if (line.PaymentTermKey == null)
                {
                    if (line.Receivement.PaymentTermKey != null
                        && line.SrcDocType.Value == RcvSrcDocTypeEnum.CreateManual.Value)
                    {
                        line.PaymentTermKey = line.Receivement.PaymentTermKey;
                    }
                    //从[供应商]中取
                    //else if ((line.IsInserting()
                    //    || (line.OriginalData != null && line.OriginalData.MatchLayer != line.MatchLayer
                    //     && line.MatchLayer == CBO.FI.MatchLayerSet.MatchGradeEnum.Way4))//0金额不可立账，从0调有价后要立账
                    //    && (line.SrcDocType.Value == RcvSrcDocTypeEnum.Rtn.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.PC.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.SOReturn.Value
                    //    || line.SrcDocType.Value == RcvSrcDocTypeEnum.VMI.Value))
                    else
                    {
                        //付款供应商site 、付款供应商、供应商
                        if (line.PaymentTermKey == null && line.Receivement.PayerSite.SupplierSiteKey != null)
                        {
                            line.PaymentTermKey = line.Receivement.PayerSite.SupplierSite.PaymentTermKey;
                        }
                        if (line.PaymentTermKey == null && line.Receivement.Payer.SupplierKey != null)
                        {
                            line.PaymentTermKey = line.Receivement.Payer.Supplier.PaymentTermKey;
                        }
                        if (line.PaymentTermKey == null && line.Receivement.Supplier.SupplierKey != null)
                        {
                            line.PaymentTermKey = line.Receivement.Supplier.Supplier.PaymentTermKey;
                        }
                    }
                }
            }

            //立帐方式 if（立账依据＝“不立账”）=null
            if (line.ConfirmAccordingKey == null)
            {
                line.ConfirmMode = CBO.SCM.Enums.AccrueModeEnum.Empty;
            }
            else
            {
                //line.ConfirmMode = line.Receivement.RcvDocType.ConfirmMode;
                if (line.Receivement.RcvDocTypeKey != null
                    && (line.ConfirmMode.Value == CBO.SCM.Enums.AccrueModeEnum.Empty.Value
                    ))
                {
                    line.ConfirmMode = line.Receivement.RcvDocType.ConfirmMode;//立账方式若为空=异动类别.[立账方式]
                }

                if (line.Receivement.IsWithoutOrderRcv()
                    && line.Receivement.OriginalData != null && line.Receivement.OriginalData.RcvDocTypeKey != null
                    && line.Receivement.RcvDocTypeKey != null
                    && line.Receivement.OriginalData.RcvDocTypeKey.ID != line.Receivement.RcvDocTypeKey.ID)
                {
                    line.ConfirmMode = line.Receivement.RcvDocType.ConfirmMode;
                }
            }
        }
        private void setInitRCVLineConfirmAttr(RcvLine line)
        {
            //if (line.Receivement.BizType.Value == BusinessTypeEnum.PM005.Value ||
            //line.Receivement.BizType.Value == BusinessTypeEnum.PM010.Value ||
            //line.Receivement.BizType.Value == BusinessTypeEnum.PM020.Value)
            //if (line.Receivement.BizType.Value == BusinessTypeEnum.PM005.Value ||
            if (line.IsFeeItemPur() || line.IsAssetsPur())
            {
                line.ConfirmMode = AccrueModeEnum.BillConfirm;
            }
            //if (line.Receivement.BizType.Value == BusinessTypeEnum.PM080.Value)
            if (line.Receivement.IsWithoutOrderRcv() || line.Receivement.IsInitPurReturn()) //是否无订单收货 2.0 Modify
            {
                line.ConfirmMode = line.Receivement.RcvDocType.ConfirmMode;
            }

            MatchLayerSet matchLayerSet = null;
            string oPath = "Supplier=@supplier and Org=@accountOrg and BusinessType=@bizType and isnull(ConfrimBase,0)>0";
            string oPathNoSupplier = "Org=@accountOrg and BusinessType=@bizType and isnull(ConfrimBase,0)>0";
            if (line.Receivement.Supplier != null
                && line.Receivement.Supplier.SupplierKey != null
                && line.AccountOrgKey != null)
            {
                matchLayerSet = MatchLayerSet.Finder.Find(oPath,
                                 new OqlParam(line.Receivement.Supplier.SupplierKey.ID),
                                 new OqlParam(line.AccountOrgKey.ID),
                                  new OqlParam(line.Receivement.BizType.Value));
            }

            if (matchLayerSet == null)
            {
                matchLayerSet = MatchLayerSet.Finder.Find(oPathNoSupplier,
                               new OqlParam(line.AccountOrgKey.ID),
                               new OqlParam(line.Receivement.BizType.Value));
            }

            if (matchLayerSet != null)
            {
                line.ConfirmAccording = matchLayerSet.ConfrimBase;
                line.MatchLayer = matchLayerSet.MatchLayer;
            }
        }
        private void SaveRcvTaxs(RcvLine holder, Tax taxType)
        {
            DataSet data = null;
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            RcvTax tax = RcvTax.Create(holder);
            tax.TaxMnyTC = holder.RejectTaxMnyTC;
            tax.TaxMnyFC = holder.RejectTaxMnyTC;
            tax.TaxMnyAC = holder.RejectTaxMnyTC;
            tax.TaxRate = holder.TaxRate;
            tax.TaxMnyType = TaxMnyTypeEnum.RejectTax;
            tax.TaxType = taxType;
            RcvTax tax1 = RcvTax.Create(holder);
            tax1.TaxMnyTC = holder.RtnDeductTaxTC;
            tax1.TaxMnyFC = holder.RtnDeductTaxTC;
            tax1.TaxMnyAC = holder.RtnDeductTaxTC;
            tax1.TaxRate = holder.TaxRate;
            tax1.TaxType = taxType;
            tax1.TaxMnyType = TaxMnyTypeEnum.RtnDeductTax;
            //PM_RcvTax
            string RejectTax = string.Format(@"insert into PM_RcvTax (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,SysVersion,CurrentOrg,
                TaxMnyTC,TaxMnyFC,TaxMnyAC,TaxRate,TaxMnyType,TaxType,RcvLine)
                values({0},'{1}','{2}','{1}','{2}',0,{3},{4},{4},{4},{5},{6},{7},{8});",
                tax.ID, time, Context.LoginUser, Context.LoginOrg.ID, holder.RejectTaxMnyTC, holder.TaxRate, TaxMnyTypeEnum.RejectTax.Value, taxType.ID, holder.ID);
            string RtnDeductTax = string.Format(@"insert into PM_RcvTax (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,SysVersion,CurrentOrg,
                TaxMnyTC,TaxMnyFC,TaxMnyAC,TaxRate,TaxMnyType,TaxType,RcvLine)
                values({0},'{1}','{2}','{1}','{2}',0,{3},{4},{4},{4},{5},{6},{7},{8});",
               tax1.ID, time, Context.LoginUser, Context.LoginOrg.ID, holder.RtnDeductTaxTC, holder.TaxRate, TaxMnyTypeEnum.RtnDeductTax.Value, taxType.ID, holder.ID);
            DataAccessor.RunSQL(DataAccessor.GetConn(), RejectTax + RtnDeductTax, null, out data);
        }
    }
}
