namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.Base.UOM;
    using UFIDA.U9.CBO.FI.VoucherCategory;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;
    using UFIDA.U9.ISV.GL.ISVGLImportSV;
    using UFIDA.U9.ISV.GL.ISVGLImportSV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// CreateVoucherfromSAP partial 
    /// </summary>	
    public partial class CreateVoucherfromSAP
    {
        internal BaseStrategy Select()
        {
            return new CreateVoucherfromSAPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateVoucherfromSAPImpementStrategy : BaseStrategy
    {
        public CreateVoucherfromSAPImpementStrategy() { }
        private const string SYMBOL = "|";

        public override object Do(object obj)
        {
            CreateVoucherfromSAP bpObj = (CreateVoucherfromSAP)obj;
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful=0");
            if (glVoucherLst.Count == 0) return null;//表中没有要处理的数据。
            ProcessRelData processData = new ProcessRelData();
            List<string> returnData = processData.Do();
            foreach (var item in glVoucherLst)
            {
                if (item.HeXingSAPU9GLVoucherLine.Count == 0) continue;
                if (returnData.Contains(item.SAPVoucherDisplayCode))
                {
                    item.U9ErrorResult = item.SAPVoucherDisplayCode + "有关系对照没有维护，请到关系对照表中维护！";
                    item.IsU9Successful = 2;
                    continue;
                }
                using (ISession session = Session.Open())
                {
                    try
                    {
                        //item.CompanyCode
                        ISVGLImportSVProxy proxy = new ISVGLImportSVProxy
                        {
                            ImportVoucherDTOs = new List<ISVImportVoucherDTOData>(),
                            TargetOrgCode = Context.LoginOrg.Code,//是否要用用户传输的公司和名称？
                            TargetOrgName = Context.LoginOrg.Name
                        };
                        HxRelationshipBE shipCurrency = HxRelationshipBE.Finder.Find("RefType=1 and SapCode='"
                                  + item.CurrencyCode + "' and SapName='" + item.CurrencyDescription + "'");
                        var currency = Currency.FindByCode(shipCurrency.U9Code);
                        item.IsU9Successful = 1;
                    }
                    catch (Exception ex)
                    {
                        item.U9ErrorResult = ex.Message;
                        item.IsU9Successful = 2;
                    }
                    session.Commit();
                }
            }
            return null;
        }
        private ISVImportVoucherDTOData ConstructVoucher(HeXingSAPU9GLVoucherHead voucher)
        {
            ISVImportVoucherDTOData dto = new ISVImportVoucherDTOData();
            dto.Entries = new List<ISVImportEntryDTOData>();
            //账簿
            dto.SOB = new CommonArchiveDataDTOData();

            //凭证类型
            string category = string.Empty;
            HxRelationshipBE shipCategory = HxRelationshipBE.Finder.Find("RefType=8 and SapCode='"
                      + voucher.VoucherCategoryCode + "' and SapName='" + voucher.VoucherCategoryDescription + "'");
            var voucherCategory = VoucherCategory.Finder.Find("Code=" + shipCategory.U9Code);

            dto.VoucherCategory = new CommonArchiveDataDTOData();
            if (voucherCategory != null)
            {
                dto.VoucherCategory.ID = voucherCategory.ID;
                dto.VoucherCategory.Code = voucherCategory.Code;
                dto.VoucherCategory.Name = voucherCategory.Name;
            }
            dto.VoucherDisplayCode = voucher.SAPVoucherDisplayCode;
            //凭证号
            dto.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
            //私有字段3 用于存中间表的ID  方便后续查找到通过中间表生成的凭证
            //制单日期
            dto.CreateDate = voucher.PostDate;
            //记账期间
            dto.PostedPeriod = voucher.PostedPeriod.ToString();
            //附单据数
            dto.AttachmentCount = 0;
            return dto;
        }

        private ISVImportEntryDTOData ConstructEntry(HeXingSAPU9GLVoucherLine entry, HeXingSAPU9GLVoucherHead voucher,Currency currency)
        {
            ISVImportEntryDTOData VoucherItem = new ISVImportEntryDTOData();
            VoucherItem.Voucher = new ISVImportVoucherDTOData();
            VoucherItem.SerialNo = (int)entry.SerialNo;
            //币种
            VoucherItem.Currency = new CommonArchiveDataDTOData();
            if (currency != null)
            {
                VoucherItem.Currency.ID = currency.ID;
                VoucherItem.Currency.Code = currency.Code;
                VoucherItem.Currency.Name = currency.Name;
            }
            //摘要
            VoucherItem.Abstracts = entry.Abstracts;
            #region 科目 VoucherItem.Account.Code = stb.ToString();
            //StringBuilder stb = new StringBuilder();
            ////标准科目
            //if (!string.IsNullOrEmpty(entry.Account1))
            //{
            //    stb.Append(entry.Account1);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////客户
            //if (!string.IsNullOrEmpty(entry.Account2))//不是核销的科目
            //{
            //    stb.Append(entry.Account2);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////供应商
            //if (!string.IsNullOrEmpty(entry.Account3))
            //{
            //    stb.Append(entry.Account3);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////银行
            //if (!string.IsNullOrEmpty(entry.Account4))
            //{
            //    stb.Append(entry.Account4);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////银行账号
            //if (!string.IsNullOrEmpty(entry.Account5))
            //{
            //    stb.Append(entry.Account5);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////项目
            //if (!string.IsNullOrEmpty(entry.Account6))
            //{
            //    stb.Append(entry.Account6);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////部门
            //if (!string.IsNullOrEmpty(entry.Account7))
            //{
            //    stb.Append(entry.Account7);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////员工
            //if (!string.IsNullOrEmpty(entry.Account8))
            //{
            //    stb.Append(entry.Account8);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////关联类型
            //if (!string.IsNullOrEmpty(entry.Account9))
            //{
            //    stb.Append(entry.Account9);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            //stb.Append(SYMBOL);
            ////业务单元
            //if (!string.IsNullOrEmpty(entry.Account10))
            //{
            //    stb.Append(entry.Account10);
            //}
            //else
            //{
            //    stb.Append("0");
            //}
            VoucherItem.Account = new CommonArchiveDataDTOData();
            VoucherItem.Account.Code = stb.ToString();
            #endregion

            ////汇率类型
            //VoucherItem.ExchangeRateTypes = 0;
            ////对本币汇率
            //VoucherItem.OCToFCExchangeRate = 1;
            //借方金额(本币)
            VoucherItem.AccountedDr = entry.AccountedDr;
            //贷方金额(本币)
            VoucherItem.AccountedCr = entry.AccountedCr;
            //借方金额(原币)
            VoucherItem.EnteredDr = entry.EnteredDr;
            //贷方金额(原币)
            VoucherItem.EnteredCr = entry.EnteredCr;
            //借方数量
            //VoucherItem.AmountDr = 0;
            ////贷方数量
            //VoucherItem.AmountCr = 0;
            //银行账号
            VoucherItem.BankAccount = new CommonArchiveDataDTOData();
            var bankAccount = BankAccount.FindByCode(entry.BankAccountCode);
            if (bankAccount != null)
            {
                VoucherItem.BankAccount.ID = bankAccount.ID;
                VoucherItem.BankAccount.Name = bankAccount.Name;
                VoucherItem.BankAccount.Code = bankAccount.Code;
            }

            //收支项目
            VoucherItem.IncomeExpendItem = new CommonArchiveDataDTOData();
            var incExpItem = IncExpItem.FindByCode(entry.IncomeExpendItemCode);
            if (incExpItem != null)
            {
                VoucherItem.IncomeExpendItem.ID = incExpItem.ID;
                VoucherItem.IncomeExpendItem.Code = incExpItem.Code;
                VoucherItem.IncomeExpendItem.Name = incExpItem.Name;
            }
            //任务编号
            //VoucherItem.TaskCode = new CommonArchiveDataDTOData();
            //VoucherItem.TaskCode.ID= entry
            //结算方式
            VoucherItem.SettlementMethod = new CommonArchiveDataDTOData();
            var settlementMethod = SettlementMethod.FindByCode(entry.SettlementMethodCode);
            if (settlementMethod != null)
            {
                VoucherItem.SettlementMethod.ID = settlementMethod.ID;
                VoucherItem.SettlementMethod.Code = settlementMethod.Code;
                VoucherItem.SettlementMethod.Name = settlementMethod.Name;
            }

            //计量单位
            VoucherItem.UOM = new Base.UOM.UOMData();
            var uom = UOM.FindByCode(entry.UOMCode);
            if (uom != null)
            {
                VoucherItem.UOM.ID = uom.ID;
                VoucherItem.UOM.Code = uom.Code;
                VoucherItem.UOM.Name = uom.Name;
            }
            //VoucherItem.EntryMemoBooks = new List<ISVImportEntryMemoBookDTOData>();
            //VoucherItem.Voucher = new ISVImportVoucherDTOData();
            //VoucherItem.Voucher.
            //VoucherItem.VoucherEntry = new ISVImportEntryDTOData();
            #region 实体扩展字段集合
            VoucherItem.Description = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
            VoucherItem.Description.PrivateDescSeg1 = entry.DescFlexField.PrivateDescSeg1;
            VoucherItem.Description.PrivateDescSeg2 = entry.DescFlexField.PrivateDescSeg2;
            VoucherItem.Description.PrivateDescSeg3 = entry.DescFlexField.PrivateDescSeg3;
            VoucherItem.Description.PrivateDescSeg4 = entry.DescFlexField.PrivateDescSeg4;
            VoucherItem.Description.PrivateDescSeg5 = entry.DescFlexField.PrivateDescSeg5;
            VoucherItem.Description.PrivateDescSeg6 = entry.DescFlexField.PrivateDescSeg6;
            VoucherItem.Description.PrivateDescSeg7 = entry.DescFlexField.PrivateDescSeg7;
            VoucherItem.Description.PrivateDescSeg8 = entry.DescFlexField.PrivateDescSeg8;
            VoucherItem.Description.PrivateDescSeg9 = entry.DescFlexField.PrivateDescSeg9;
            VoucherItem.Description.PrivateDescSeg10 = entry.DescFlexField.PrivateDescSeg10;
            VoucherItem.Description.PrivateDescSeg11 = entry.DescFlexField.PrivateDescSeg11;
            VoucherItem.Description.PrivateDescSeg12 = entry.DescFlexField.PrivateDescSeg12;
            VoucherItem.Description.PrivateDescSeg13 = entry.DescFlexField.PrivateDescSeg13;
            VoucherItem.Description.PrivateDescSeg14 = entry.DescFlexField.PrivateDescSeg14;
            VoucherItem.Description.PrivateDescSeg15 = entry.DescFlexField.PrivateDescSeg15;
            VoucherItem.Description.PrivateDescSeg16 = entry.DescFlexField.PrivateDescSeg16;
            VoucherItem.Description.PrivateDescSeg17 = entry.DescFlexField.PrivateDescSeg17;
            VoucherItem.Description.PrivateDescSeg18 = entry.DescFlexField.PrivateDescSeg18;
            VoucherItem.Description.PrivateDescSeg19 = entry.DescFlexField.PrivateDescSeg19;
            VoucherItem.Description.PrivateDescSeg20 = entry.DescFlexField.PrivateDescSeg20;
            VoucherItem.Description.PrivateDescSeg21 = entry.DescFlexField.PrivateDescSeg21;
            VoucherItem.Description.PrivateDescSeg22 = entry.DescFlexField.PrivateDescSeg22;
            VoucherItem.Description.PrivateDescSeg23 = entry.DescFlexField.PrivateDescSeg23;
            VoucherItem.Description.PrivateDescSeg24 = entry.DescFlexField.PrivateDescSeg24;
            VoucherItem.Description.PrivateDescSeg25 = entry.DescFlexField.PrivateDescSeg25;
            VoucherItem.Description.PrivateDescSeg26 = entry.DescFlexField.PrivateDescSeg26;
            VoucherItem.Description.PrivateDescSeg27 = entry.DescFlexField.PrivateDescSeg27;
            VoucherItem.Description.PrivateDescSeg28 = entry.DescFlexField.PrivateDescSeg28;
            VoucherItem.Description.PrivateDescSeg29 = entry.DescFlexField.PrivateDescSeg29;
            VoucherItem.Description.PrivateDescSeg30 = entry.DescFlexField.PrivateDescSeg30;
            VoucherItem.Description.PubDescSeg1 = entry.DescFlexField.PubDescSeg1;
            VoucherItem.Description.PubDescSeg2 = entry.DescFlexField.PubDescSeg2;
            VoucherItem.Description.PubDescSeg3 = entry.DescFlexField.PubDescSeg3;
            VoucherItem.Description.PubDescSeg4 = entry.DescFlexField.PubDescSeg4;
            VoucherItem.Description.PubDescSeg5 = entry.DescFlexField.PubDescSeg5;
            VoucherItem.Description.PubDescSeg6 = entry.DescFlexField.PubDescSeg6;
            VoucherItem.Description.PubDescSeg7 = entry.DescFlexField.PubDescSeg7;
            VoucherItem.Description.PubDescSeg8 = entry.DescFlexField.PubDescSeg8;
            VoucherItem.Description.PubDescSeg9 = entry.DescFlexField.PubDescSeg9;
            VoucherItem.Description.PubDescSeg10 = entry.DescFlexField.PubDescSeg10;
            VoucherItem.Description.PubDescSeg11 = entry.DescFlexField.PubDescSeg11;
            VoucherItem.Description.PubDescSeg12 = entry.DescFlexField.PubDescSeg12;
            VoucherItem.Description.PubDescSeg13 = entry.DescFlexField.PubDescSeg13;
            VoucherItem.Description.PubDescSeg14 = entry.DescFlexField.PubDescSeg14;
            VoucherItem.Description.PubDescSeg15 = entry.DescFlexField.PubDescSeg15;
            VoucherItem.Description.PubDescSeg16 = entry.DescFlexField.PubDescSeg16;
            VoucherItem.Description.PubDescSeg17 = entry.DescFlexField.PubDescSeg17;
            VoucherItem.Description.PubDescSeg18 = entry.DescFlexField.PubDescSeg18;
            VoucherItem.Description.PubDescSeg19 = entry.DescFlexField.PubDescSeg19;
            VoucherItem.Description.PubDescSeg20 = entry.DescFlexField.PubDescSeg20;
            VoucherItem.Description.PubDescSeg21 = entry.DescFlexField.PubDescSeg21;
            VoucherItem.Description.PubDescSeg22 = entry.DescFlexField.PubDescSeg22;
            VoucherItem.Description.PubDescSeg23 = entry.DescFlexField.PubDescSeg23;
            VoucherItem.Description.PubDescSeg24 = entry.DescFlexField.PubDescSeg24;
            VoucherItem.Description.PubDescSeg25 = entry.DescFlexField.PubDescSeg25;
            VoucherItem.Description.PubDescSeg26 = entry.DescFlexField.PubDescSeg26;
            VoucherItem.Description.PubDescSeg27 = entry.DescFlexField.PubDescSeg27;
            VoucherItem.Description.PubDescSeg28 = entry.DescFlexField.PubDescSeg28;
            VoucherItem.Description.PubDescSeg29 = entry.DescFlexField.PubDescSeg29;
            VoucherItem.Description.PubDescSeg30 = entry.DescFlexField.PubDescSeg30;
            VoucherItem.Description.PubDescSeg31 = entry.DescFlexField.PubDescSeg31;
            VoucherItem.Description.PubDescSeg32 = entry.DescFlexField.PubDescSeg32;
            VoucherItem.Description.PubDescSeg33 = entry.DescFlexField.PubDescSeg33;
            VoucherItem.Description.PubDescSeg34 = entry.DescFlexField.PubDescSeg34;
            VoucherItem.Description.PubDescSeg35 = entry.DescFlexField.PubDescSeg35;
            VoucherItem.Description.PubDescSeg36 = entry.DescFlexField.PubDescSeg36;
            VoucherItem.Description.PubDescSeg37 = entry.DescFlexField.PubDescSeg37;
            VoucherItem.Description.PubDescSeg38 = entry.DescFlexField.PubDescSeg38;
            VoucherItem.Description.PubDescSeg39 = entry.DescFlexField.PubDescSeg39;
            VoucherItem.Description.PubDescSeg40 = entry.DescFlexField.PubDescSeg40;
            VoucherItem.Description.PubDescSeg41 = entry.DescFlexField.PubDescSeg41;
            VoucherItem.Description.PubDescSeg42 = entry.DescFlexField.PubDescSeg42;
            VoucherItem.Description.PubDescSeg43 = entry.DescFlexField.PubDescSeg43;
            VoucherItem.Description.PubDescSeg44 = entry.DescFlexField.PubDescSeg44;
            VoucherItem.Description.PubDescSeg45 = entry.DescFlexField.PubDescSeg45;
            VoucherItem.Description.PubDescSeg46 = entry.DescFlexField.PubDescSeg46;
            VoucherItem.Description.PubDescSeg47 = entry.DescFlexField.PubDescSeg47;
            VoucherItem.Description.PubDescSeg48 = entry.DescFlexField.PubDescSeg48;
            VoucherItem.Description.PubDescSeg49 = entry.DescFlexField.PubDescSeg49;
            VoucherItem.Description.PubDescSeg50 = entry.DescFlexField.PubDescSeg50;
            #endregion
            return VoucherItem;
        }
    }

    #endregion


}