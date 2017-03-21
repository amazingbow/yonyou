namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.Base.SOB;
    using UFIDA.U9.Base.UOM;
    using UFIDA.U9.CBO.FI.BankAccount;
    using UFIDA.U9.CBO.FI.IncExpItem;
    using UFIDA.U9.CBO.FI.NaturalAccount;
    using UFIDA.U9.CBO.FI.SettlementMethod;
    using UFIDA.U9.CBO.FI.VoucherCategory;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;
    using UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE;
    using UFIDA.U9.GL.Voucher.Proxy;
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
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful=0 or IsU9Successful=2");
            if (glVoucherLst.Count == 0) return null;//表中没有要处理的数据。
            ProcessRelData processData = new ProcessRelData();
            List<string> returnData = processData.Do();

            foreach (var item in glVoucherLst)
            {
                if (item.HeXingSAPU9GLVoucherLine.Count == 0) continue;
                item.U9ErrorResult = item.SAPVoucherDisplayCode;
                item.IsU9Successful = ImportFlagEnum.NotProcess;
                foreach (var res in returnData)
                {
                    if (res.Contains(item.SAPVoucherDisplayCode))
                    {
                        item.U9ErrorResult += res.Replace(item.SAPVoucherDisplayCode, ",");
                        item.IsU9Successful = ImportFlagEnum.ImportFailed;
                    }
                }
                if (item.IsU9Successful == ImportFlagEnum.ImportFailed)
                {
                    continue;
                }
                item.U9ErrorResult = "";
                // UFIDA.U9.ISV.GL.ISVGLImportSV.ISVGLImportSV生成凭证服务不生成现金流量：
                //1.importVoucherDTO.ImportType = CBO.FI.Enums.VoucherImportTypeEnum.VoucherAll； 
                //这句必须有，没有的话现金流量项目无法导入。
                //2.账簿上必须设置现金流量表
                using (ISession session = Session.Open())
                {
                    List<RefVoucherInfoBE> refList = new List<RefVoucherInfoBE>();
                    try
                    {
                        //item.CompanyCode
                        HxRelationshipBE shipOrg = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=7 and SapCode='" + item.CompanyCode + "' and SapName='"
                            + item.CompanyName + "'");
                        if (shipOrg == null)
                        {
                            throw new Exception("公司信息没有传值，或者关系对照表中没有维护且审核");
                        }
                        ISVGLImportSVProxy proxy = new ISVGLImportSVProxy
                        {
                            ImportVoucherDTOs = new List<ISVImportVoucherDTOData>(),
                            TargetOrgCode = shipOrg.U9Code,
                            TargetOrgName = shipOrg.U9Name
                        };
                        HxRelationshipBE shipCurrency = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=1 and SapCode='"
                                  + item.CurrencyCode + "' and SapName='" + item.CurrencyDescription + "'");
                        if (shipCurrency == null)
                        {
                            throw new Exception("币种信息没有传值，或者关系对照没有维护且审核");
                        }
                        var currency = Currency.FindByCode(shipCurrency.U9Code);
                        RefVoucherInfoBE refBe = RefVoucherInfoBE.Create();
                        refBe.HxRelationshipID = shipCurrency.ID;
                        refList.Add(refBe);
                        #region   根据组织查询主账簿
                        Organization org = Organization.FindByCode(shipOrg.U9Code);
                        if (org == null)
                        {
                            throw new Exception(shipOrg.SapCode + "维护的U9组织代码" + shipOrg.U9Code + "错误，请检查");
                        }
                        SetofBooks sob = SetofBooks.Finder.Find("SOBType=0 and Org=" + org.ID);
                        if (sob == null)
                        {
                            throw new Exception(shipOrg.SapCode + "维护的U9组织代码" + shipOrg.U9Code + "没有维护主账簿，请检查");
                        }
                        ISVImportVoucherDTOData dto = ConstructVoucher(item, refList, sob);
                        dto.SOB = new CommonArchiveDataDTOData();
                        dto.SOB.ID = sob.ID;
                        dto.SOB.Code = sob.Code;
                        dto.SOB.Name = sob.Name;
                        #endregion
                        foreach (var entry in item.HeXingSAPU9GLVoucherLine)
                        {
                            ISVImportEntryDTOData voucherItem = ConstructEntry(entry, item, currency, refList, shipOrg, sob);
                            voucherItem.Voucher = dto;
                            dto.Entries.Add(voucherItem);
                        }
                        proxy.ImportVoucherDTOs.Add(dto);
                        List<ISVReturnVoucherDTOData> result = proxy.Do();
                        if (result == null || result.Count == 0) throw new Exception(item.SAPVoucherDisplayCode + "：生成凭证失败");
                        foreach (var refInfo in refList)
                        {
                            refInfo.VoucherID = result[0].VoucherID;
                            refInfo.VoucherDisplayCode = result[0].DocNo;
                        }
                        item.U9VoucherID = result[0].VoucherID;
                        item.CompleteU9Date = DateTime.Now;
                        item.IsU9Successful = ImportFlagEnum.ImportSuccess;
                        try
                        {
                            VoucherApprovedProxy voucherApproveProxy = new VoucherApprovedProxy();
                            voucherApproveProxy.Voucher = new List<long>();
                            voucherApproveProxy.Voucher.Add(item.U9VoucherID);
                            UFIDA.U9.GL.VoucherRelData.UIVoucherBPDTOData data = voucherApproveProxy.Do();
                            if (!data.ReturnFlags)
                            {
                                item.U9ErrorResult = "导入成功，但是审核失败！U9凭证号：" + result[0].DocNo + "失败信息：" + data.FailReason;
                            }
                            item.U9ErrorResult = "导入成功，审核成功！U9凭证号：" + result[0].DocNo;
                        }
                        catch (Exception ex)
                        {
                            item.U9ErrorResult = "导入成功，但是审核失败！U9凭证号：" + result[0].DocNo + "失败信息：" + ex.Message;
                        }
                    }
                    catch (Exception ex)
                    {
                        item.U9ErrorResult = ex.Message;
                        item.IsU9Successful = ImportFlagEnum.ImportFailed;
                        item.CompleteU9Date = DateTime.Now;
                        if (refList.Count > 0)
                        {
                            foreach (var refinfo in refList)
                            {
                                refinfo.Remove();
                            }
                        }
                    }
                    session.Commit();
                }
            }
            return null;
        }

        private ISVImportVoucherDTOData ConstructVoucher(HeXingSAPU9GLVoucherHead voucher, List<RefVoucherInfoBE> refList, SetofBooks sob)
        {
            ISVImportVoucherDTOData dto = new ISVImportVoucherDTOData();
            dto.Entries = new List<ISVImportEntryDTOData>();

            //dto.ImportType = CBO.FI.Enums.VoucherImportTypeEnum.VoucherAll.Value;
            //凭证类型
            string category = string.Empty;
            HxRelationshipBE shipCategory = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=8 and SapCode='"
                      + voucher.VoucherCategoryCode + "' and SapName='" + voucher.VoucherCategoryDescription + "'");
            if (shipCategory == null)
            {
                throw new Exception("凭证类型没有传值，或关系对照没有维护且审核");
            }
            RefVoucherInfoBE refBe = RefVoucherInfoBE.Create();
            refBe.HxRelationshipID = shipCategory.ID;
            refList.Add(refBe);
            var voucherCategory = VoucherCategory.Finder.Find("Org=" + sob.Org.ID + " and Code='" + shipCategory.U9Code + "'");
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
            dto.DescFlexField.PrivateDescSeg1 = voucher.SAPVoucherDisplayCode;
            //制单日期
            dto.CreateDate = voucher.PostDate;
            //记账期间  接口里面处理记账期间是通过-来实现的，如果没有会报数组越界错误
            dto.PostedPeriod = voucher.PostedPeriod.ToString().Insert(4, "-");
            //附单据数
            dto.AttachmentCount = 0;
            return dto;
        }
        private ISVImportEntryDTOData ConstructEntry(HeXingSAPU9GLVoucherLine entry,
            HeXingSAPU9GLVoucherHead voucher, Currency currency, List<RefVoucherInfoBE> refList, HxRelationshipBE shipOrg, SetofBooks sob)
        {
            ISVImportEntryDTOData VoucherItem = new ISVImportEntryDTOData();
            VoucherItem.Voucher = new ISVImportVoucherDTOData();
            VoucherItem.SerialNo = (int)entry.SerialNo;
            //币种
            VoucherItem.Currency = new CommonArchiveDataDTOData();
            //不输入币种的话 会报 未将对象实例引用到对象上
            if (currency != null)
            {
                VoucherItem.Currency.ID = currency.ID;
                VoucherItem.Currency.Code = currency.Code;
                VoucherItem.Currency.Name = currency.Name;
            }
            //摘要
            VoucherItem.Abstracts = entry.Abstracts;
            ////汇率类型  如果是本位币，可不输
            //VoucherItem.ExchangeRateTypes = 0;
            ////对本币汇率  如果是本位币，可不输
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
            //银行账号  银行类科目必输
            VoucherItem.BankAccount = new CommonArchiveDataDTOData();
            var bankAccount = BankAccount.FindByCode(entry.BankAccount);
            if (bankAccount != null)
            {
                VoucherItem.BankAccount.ID = bankAccount.ID;
                VoucherItem.BankAccount.Name = bankAccount.Name;
                VoucherItem.BankAccount.Code = bankAccount.Code;
            }
            //收支项目 银行、现金类的科目必输，维护对应的现金流量项目
            HxRelationshipBE cashFlowRef = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=6 and SapCode='"
                            + entry.CashFlowCode + "' and SapName='" + entry.CashFlowDescription + "'");
            if (cashFlowRef != null)
            {
                RefVoucherInfoBE ref0 = RefVoucherInfoBE.Create();
                ref0.HxRelationshipID = cashFlowRef.ID;
                refList.Add(ref0);
                VoucherItem.IncomeExpendItem = new CommonArchiveDataDTOData();
                var incExpItem = IncExpItem.FindByCode(cashFlowRef.U9Code);
                if (incExpItem != null)
                {
                    VoucherItem.IncomeExpendItem.ID = incExpItem.ID;
                    VoucherItem.IncomeExpendItem.Code = incExpItem.Code;
                    VoucherItem.IncomeExpendItem.Name = incExpItem.Name;
                }
            }
            //结算方式  --银行、现金类的科目必须要录入结算方式
            //银行类的科目：业务属性为“银行业务”的结算方式
            //现金类的科目：业务属性为“现金业务”的结算方式
            VoucherItem.SettlementMethod = new CommonArchiveDataDTOData();
            var settlementCode = "";
            if (entry.AccountCode.StartsWith("1001") && entry.AccountDescription.Contains("库存现金"))
            {
                settlementCode = "001";//现金业务
            }
            else if (entry.AccountCode.StartsWith("1002") && entry.AccountDescription.Contains("银行"))
            {
                settlementCode = "002";//银行业务
            }
            var settlementMethod = SettlementMethod.FindByCode(settlementCode);
            if (settlementMethod != null)
            {
                VoucherItem.SettlementMethod.ID = settlementMethod.ID;
                VoucherItem.SettlementMethod.Code = settlementMethod.Code;
                VoucherItem.SettlementMethod.Name = settlementMethod.Name;
            }
            #region others
            //任务编号
            //VoucherItem.TaskCode = new CommonArchiveDataDTOData();
            //VoucherItem.TaskCode.ID= entry

            ////计量单位
            //VoucherItem.UOM = new Base.UOM.UOMData();
            //var uom = UOM.FindByCode(entry.UOMCode);
            //if (uom != null)
            //{
            //    VoucherItem.UOM.ID = uom.ID;
            //    VoucherItem.UOM.Code = uom.Code;
            //    VoucherItem.UOM.Name = uom.Name;
            //}
            //VoucherItem.EntryMemoBooks = new List<ISVImportEntryMemoBookDTOData>();
            //VoucherItem.Voucher = new ISVImportVoucherDTOData();
            //VoucherItem.Voucher.
            //VoucherItem.VoucherEntry = new ISVImportEntryDTOData();
            #endregion
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
            VoucherItem.Account = new CommonArchiveDataDTOData();
            #region 1. 标准科目 2.组织    3.客户    4.供应商   5.银行    6.银行账号  7.部门    8.员工    9.费用项目  10.工程项目
            StringBuilder stb = new StringBuilder();
            #region 1. 标准科目
            HxRelationshipBE account = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=10 and SapCode='"
                           + entry.AccountCode + "' and SapMasterCode='" + entry.MaterialGroupCode + "' and SapAssetsCode='"
                           + entry.AssetsCode + "' and SapFeeCode='" + entry.FeeTypeEnumCode + "'");
            if (account == null)
            {
                throw new Exception("科目没有传值，或关系对照表没有维护且审核");
            }
            RefVoucherInfoBE ref1 = RefVoucherInfoBE.Create();
            ref1.HxRelationshipID = account.ID;
            refList.Add(ref1);
            stb.Append(account.U9Code + SYMBOL);
            #endregion
            NaturalAccount na = NaturalAccount.Finder.Find("IsSystem=0 and Code='" + account.U9Code + "'");
            NaturalAccountSOBProperty np = NaturalAccountSOBProperty.Finder.Find("SOB=" + sob.ID + " and NaturalAccount=" + na.ID);
            if (np == null)
            {
                throw new Exception("维护的标准科目所对应的账簿科目为空，请检查是否维护错误");
            }
            if (np.NaturalAccountSOBSegmentUseRoles.Count == 0)
            {
                VoucherItem.Account.Code = account.U9Code + "|0|0|0|0|0|0|0|0|0";
                return VoucherItem;
            }
            #region 2. 组织
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment2)//如果段2是必填的
            {
                RefVoucherInfoBE ref2 = RefVoucherInfoBE.Create();
                ref2.HxRelationshipID = shipOrg.ID;
                refList.Add(ref2);
                stb.Append(shipOrg.U9Code + SYMBOL);
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 3. 客户
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment3)
            {
                HxRelationshipBE shipCust = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=2 and SapCode='"
                    + entry.CustomerCode + "' and SapName='" + entry.CustomerDescription + "'");

                if (shipCust != null)
                {
                    stb.Append(shipCust.U9Code + SYMBOL);
                    RefVoucherInfoBE ref3 = RefVoucherInfoBE.Create();
                    ref3.HxRelationshipID = shipCust.ID;
                    refList.Add(ref3);
                }
                else
                {
                    throw new Exception("SAP凭证号" + voucher.SAPVoucherDisplayCode + "下面的" + entry.AccountCode + "客户段是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 4. 供应商
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment4)
            {
                HxRelationshipBE shipSupplier = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=3 and SapCode='"
                    + entry.SupplierCode + "' and SapName='" + entry.SupplierDescription + "'");
                if (shipSupplier != null)
                {
                    stb.Append(shipSupplier.U9Code + SYMBOL);
                    RefVoucherInfoBE ref4 = RefVoucherInfoBE.Create();
                    ref4.HxRelationshipID = shipSupplier.ID;
                    refList.Add(ref4);
                }
                else
                {
                    throw new Exception("SAP凭证号" + voucher.SAPVoucherDisplayCode + "下面的" + entry.AccountCode + "供应商是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 5. 银行
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment5)
            {
                HxRelationshipBE shipBank = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=12 and SapCode='" + entry.Banks + "'");
                if (shipBank != null)
                {
                    stb.Append(shipBank.U9Code + SYMBOL);
                }
                else
                {
                    throw new Exception("SAP凭证号" + voucher.SAPVoucherDisplayCode + "下面的" + entry.AccountCode + "银行是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }

            #endregion
            #region 6. 银行账号
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment6)
            {
                if (!string.IsNullOrEmpty(entry.BankAccount))
                {
                    stb.Append(entry.BankAccount + SYMBOL);
                }
                else
                {
                    throw new Exception("SAP凭证号" + voucher.SAPVoucherDisplayCode + "下面的" + entry.AccountCode + "银行账号是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 7. 部门
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment7)
            {
                HxRelationshipBE shipDepartment = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=4 and SapCode='"
                        + entry.DepartmentCode + "' and SapCompCode='" + voucher.CompanyCode + "'");
                if (shipDepartment != null)
                {
                    stb.Append(shipDepartment.U9Code + SYMBOL);
                    RefVoucherInfoBE ref7 = RefVoucherInfoBE.Create();
                    ref7.HxRelationshipID = shipDepartment.ID;
                    refList.Add(ref7);
                }
                else
                {
                    throw new Exception(entry.AccountCode + "部门是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 8. 员工
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment8)
            {
                HxRelationshipBE shipWork = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=5 and SapCode='"
                        + entry.EmployeeCode + "' and SapName='" + entry.EmployeeName + "'");

                if (shipWork != null)
                {
                    stb.Append(shipWork.U9Code + SYMBOL);
                    RefVoucherInfoBE ref8 = RefVoucherInfoBE.Create();
                    ref8.HxRelationshipID = shipWork.ID;
                    refList.Add(ref8);
                }
                else
                {
                    throw new Exception(entry.AccountCode + "员工是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 9. 费用项目
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment9)
            {
                HxRelationshipBE shipFee = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=11 and SapCode='"
                             + entry.FeeTypeEnumCode + "' and SapName='" + entry.FeeTypeEnumDescription + "'");
                if (shipFee != null)
                {
                    stb.Append(shipFee.U9Code + SYMBOL);
                    RefVoucherInfoBE ref9 = RefVoucherInfoBE.Create();
                    ref9.HxRelationshipID = shipFee.ID;
                    refList.Add(ref9);
                }
                else
                {
                    throw new Exception(entry.AccountCode + "费用项目是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0" + SYMBOL);
            }
            #endregion
            #region 10. 工程项目
            if (np.NaturalAccountSOBSegmentUseRoles[0].Segment10)
            {
                HxRelationshipBE shipProjec = HxRelationshipBE.Finder.Find("RefStatus=2 and RefType=9 and SapCode='"
                      + entry.CustomerCode + "' and SapName='" + entry.CustomerDescription + "'");
                if (shipProjec != null)
                {
                    stb.Append(shipProjec.U9Code);
                    RefVoucherInfoBE ref10 = RefVoucherInfoBE.Create();
                    ref10.HxRelationshipID = shipProjec.ID;
                    refList.Add(ref10);
                }
                else
                {
                    throw new Exception("SAP凭证号" + voucher.SAPVoucherDisplayCode + "下面的" + entry.AccountCode + "工程项目是必输的，但是并没有传值或维护对应关系");
                }
            }
            else
            {
                stb.Append("0");
            }
            #endregion
            #endregion
            VoucherItem.Account.Code = stb.ToString();
            return VoucherItem;
        }
    }

    #endregion


}