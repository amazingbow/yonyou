namespace UFIDA.U9.Cust.XM.TGBP.TaecoUnBusiInterface
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using Base;
    using CBO.Pub.Controller;
    using ISV.GL.ISVGLImportSV;
    using ISV.GL.ISVGLImportSV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Sys.Database;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.Base.SOB;
    using UFIDA.U9.CBO.FI.VoucherCategory;
    using UFIDA.U9.CBO.FI.BankAccount;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.CBO.FI.IncExpItem;
    using UFIDA.U9.CBO.FI.SettlementMethod;
    using UFIDA.U9.Base.UOM;
    using UFIDA.U9.GL.Voucher;
    using XMIGC.XMIIC.Devlop.DataAccess;
    using System.Data.SqlClient;
    using XMIGC.XMIIC.Devlop.Utill;
    using UFIDA.U9.GL.EntryApply;
    using UFIDA.U9.GL.EntryApply.Proxy;
    using UFIDA.U9.CBO.FI.Account;
    using UFIDA.U9.Base.FlexField.KeyFlexField;
    using System.Xml.Serialization;
    using UFSoft.UBF.Business;
    using UFIDA.U9.GL.VoucherReverseScheme;

    /// <summary>
    /// CreateVoucherByTableBP partial 
    /// </summary>	

    public partial class CreateVoucherByTableBP
    {

        internal BaseStrategy Select()
        {
            return new CreateVoucherByTableBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateVoucherByTableBPImpementStrategy : BaseStrategy
    {
        #region Const String
        private const string SYMBOL = "|";
        private const string QUERY = @"select A.ID as HeaderID,VoucherCategoryCode,A.DescFlexField_PrivateDescSeg2,CreateDate,PostedPeriod,AttachmentCount,IsInternal,
VoucherID,B.ID As LineID,EntryID,SerialNo,Abstracts,Segment1,Segment2,Segment3,Segment4,Segment5,Segment6,Segment7,Segment8,Segment9,Segment10,CurrencyCode,
ExchangeRateTypes,OCToFCExchangeRate,AccountedDr,AccountedCr,EnteredDr,EnteredCr,AmountDr,AmountCr,BankAccountCode,IncomeExpendItemCode,A.ReversalPostPeriod,
SettlementMethodCode,UOMCode,InternalApAR,SupplierCode,CustomerCode,B.CustomerSection,B.CustomerBU,A.Segment,A.VoucherType,A.IsNeedReverse,A. ReverseMethod,
DescFlexField_PrivateDescSeg1,B.DescFlexField_PrivateDescSeg2,DescFlexField_PrivateDescSeg3,DescFlexField_PrivateDescSeg4,DescFlexField_PrivateDescSeg5,A.CreatedBy,A.ModifiedBy,
DescFlexField_PrivateDescSeg6,DescFlexField_PrivateDescSeg7,DescFlexField_PrivateDescSeg8,DescFlexField_PrivateDescSeg9,DescFlexField_PrivateDescSeg10,
DescFlexField_PrivateDescSeg11,DescFlexField_PrivateDescSeg12,DescFlexField_PrivateDescSeg13,DescFlexField_PrivateDescSeg14,DescFlexField_PrivateDescSeg15,
DescFlexField_PrivateDescSeg16,DescFlexField_PrivateDescSeg17,DescFlexField_PrivateDescSeg18,DescFlexField_PrivateDescSeg19,DescFlexField_PrivateDescSeg20,
DescFlexField_PrivateDescSeg21,DescFlexField_PrivateDescSeg22,DescFlexField_PrivateDescSeg23,DescFlexField_PrivateDescSeg24,DescFlexField_PrivateDescSeg25,
DescFlexField_PrivateDescSeg26,DescFlexField_PrivateDescSeg27,DescFlexField_PrivateDescSeg28,DescFlexField_PrivateDescSeg29,DescFlexField_PrivateDescSeg30,
DescFlexField_PubDescSeg1,DescFlexField_PubDescSeg2,DescFlexField_PubDescSeg3,DescFlexField_PubDescSeg4,DescFlexField_PubDescSeg5,
DescFlexField_PubDescSeg6,DescFlexField_PubDescSeg7,DescFlexField_PubDescSeg8,DescFlexField_PubDescSeg9,DescFlexField_PubDescSeg10,
DescFlexField_PubDescSeg11,DescFlexField_PubDescSeg12,DescFlexField_PubDescSeg13,DescFlexField_PubDescSeg14,DescFlexField_PubDescSeg15,
DescFlexField_PubDescSeg16,DescFlexField_PubDescSeg17,DescFlexField_PubDescSeg18,DescFlexField_PubDescSeg19,DescFlexField_PubDescSeg20,
DescFlexField_PubDescSeg21,DescFlexField_PubDescSeg22,DescFlexField_PubDescSeg23,DescFlexField_PubDescSeg24,DescFlexField_PubDescSeg25,
DescFlexField_PubDescSeg26,DescFlexField_PubDescSeg27,DescFlexField_PubDescSeg28,DescFlexField_PubDescSeg29,DescFlexField_PubDescSeg30,
DescFlexField_PubDescSeg31,DescFlexField_PubDescSeg32,DescFlexField_PubDescSeg33,DescFlexField_PubDescSeg34,DescFlexField_PubDescSeg35,
DescFlexField_PubDescSeg36,DescFlexField_PubDescSeg37,DescFlexField_PubDescSeg38,DescFlexField_PubDescSeg39,DescFlexField_PubDescSeg40,
DescFlexField_PubDescSeg41,DescFlexField_PubDescSeg42,DescFlexField_PubDescSeg43,DescFlexField_PubDescSeg44,DescFlexField_PubDescSeg45,
DescFlexField_PubDescSeg46,DescFlexField_PubDescSeg47,DescFlexField_PubDescSeg48,DescFlexField_PubDescSeg49,DescFlexField_PubDescSeg50
 from GL_Header A left join GL_Line B on A.ID=B.GL_Header_ID where A.IsGenesis='0' or A.IsGenesis is null";
        #endregion
        public CreateVoucherByTableBPImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateVoucherByTableBP bpObj = (CreateVoucherByTableBP)obj;
            //var TaecoConn = ConfigurationManager.ConnectionStrings["TaecoConn"];
            //Configuration
            var TaecoConn = SQLHelperByTAECO.GetInstance().ConnString;
            DataTable dtSetofBooks = SQLHelperByTAECO.GetInstance().ExecuteDataTable("select MailAddr from Pub_MailInfoTaeco where EntityName='SetofBooksForVoucher' ");
            if (dtSetofBooks == null || dtSetofBooks.Rows.Count == 0)
            {
                string errMsg = "";
                EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "Pub_MailInfoTaeco中未配置账簿数据SetofBooksForVoucher对应的账簿ID", out errMsg);
                throw new Exception("Pub_MailInfoTaeco中未配置账簿数据SetofBooksForVoucher对应的账簿ID");
            }
            string setofbookId = dtSetofBooks.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(setofbookId))
            {
                string errMsg = "";
                EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "Pub_MailInfoTaeco账簿数据SetofBooksForVoucher对应的账簿ID", out errMsg);
                throw new Exception("Pub_MailInfoTaeco中未配置账簿数据SetofBooksForVoucher对应的账簿ID");
            }
            if (TaecoConn == null)
            {
                string errMsg = "";
                EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "数据库配置出错", out errMsg);
                throw new Exception("数据库配置出错");
            }
            var conn = DatabaseManager.GetConnection(TaecoConn);
            DataSet data = null;
            DataAccessor.RunSQL(conn, QUERY, null, out data);
            if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
            {
                string errMsg = "";
                EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "没有凭证要导入", out errMsg);
                return false;
            }
            SetofBooks sob = SetofBooks.Finder.FindByID(setofbookId);
            if (sob == null)
            {
                string errMsg = "";
                EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "Pub_MailInfoTaeco配置账簿数据SetofBooksForVoucher对应的账簿ID：" + setofbookId + "配置错误！", out errMsg);
                throw new Exception("Pub_MailInfoTaeco配置账簿数据SetofBooksForVoucher对应的账簿ID：" + setofbookId + "配置错误！");
            }
            List<GLVoucher> glHeader = CovertToEntry(data.Tables[0]);
            string accountMatch = string.Empty;
            if (glHeader.FindAll(i => i.IsInternal).Count > 0)
            {
                DataTable internalBu = SQLHelperByTAECO.GetInstance().ExecuteDataTable("select MailAddr from Pub_MailInfoTaeco where EntityName='Internal-Business' ");
                if (internalBu == null || internalBu.Rows.Count == 0)
                {
                    string errMsg = "";
                    EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", "Pub_MailInfoTaeco中未配置科目对照关系", out errMsg);
                    return false;
                }
                accountMatch = internalBu.Rows[0][0].ToString();
            }
            StringBuilder resultEmail = new StringBuilder();
            foreach (GLVoucher voucher in glHeader)
            {
                ISVGLImportSVProxy proxy = new ISVGLImportSVProxy
                {
                    ImportVoucherDTOs = new List<ISVImportVoucherDTOData>(),
                    TargetOrgCode = Context.LoginOrg.Code,
                    TargetOrgName = Context.LoginOrg.Name
                };
                ISVImportVoucherDTOData dto = ConstructVoucher(voucher);
                dto.SOB.ID = sob.ID;
                dto.SOB.Code = sob.Code;
                dto.SOB.Name = sob.Name;
                if (voucher.IsInternal)
                {
                    ISVImportVoucherDTOData dto1 = ConstructVoucher(voucher);
                    dto1.SOB.ID = sob.ID;
                    dto1.SOB.Code = sob.Code;
                    dto1.SOB.Name = sob.Name;
                    //dto1.VoucherDisplayCode = voucher.ID + "-Reverse";
                    dto1.DescFlexField.PrivateDescSeg3 = voucher.ID + "-Reverse";
                    foreach (GLEntry entry in voucher.GLEntryList)
                    {
                        ISVImportEntryDTOData voucherItem = ConstructEntry(entry, voucher);
                        dto.Entries.Add(voucherItem);

                        ISVImportEntryDTOData voucherItem1 = GenerateNewEntry(entry, voucher, accountMatch);
                        dto1.Entries.Add(voucherItem1);
                    }
                    proxy.ImportVoucherDTOs.Add(dto);
                    proxy.ImportVoucherDTOs.Add(dto1);
                }
                else
                {
                    foreach (GLEntry entry in voucher.GLEntryList)
                    {
                        ISVImportEntryDTOData voucherItem = ConstructEntry(entry, voucher);
                        dto.Entries.Add(voucherItem);
                    }
                    proxy.ImportVoucherDTOs.Add(dto);
                }
                try
                {
                    //SendDataToMail(proxy.ImportVoucherDTOs);
                    if (proxy.ImportVoucherDTOs.Count == 0) continue;
                    List<ISVReturnVoucherDTOData> result = proxy.Do();
                    if (result == null) throw new Exception(voucher.ID + "：生成凭证失败");
                    if (result.Count == 0) throw new Exception(voucher.ID + "：生成凭证失败");
                    List<string> voucherId = new List<string>();
                    result.ForEach(i => voucherId.Add(i.VoucherID.ToString()));
                    var voucherLst = new Voucher.EntityList();
                    using (ISession session = Session.Open())
                    {
                        voucherLst = Voucher.Finder.FindAll("ID in (" + string.Join(",", voucherId.ToArray()) + ")");

                        foreach (var item in voucherLst)
                        {
                            if (voucher.IsNeedReverse)
                            {
                                item.IsNeedReverse = voucher.IsNeedReverse;
                                if (voucher.ReverseMethod == 1)
                                {
                                    item.ReverseMethod = ReverseMethod.ChangeSign;
                                }
                                else
                                {
                                    item.ReverseMethod = ReverseMethod.SwitchDrCr;
                                }
                                if (string.IsNullOrEmpty(voucher.ReversalPostPeriod))
                                {
                                    SOBAccountingPeriod period = SOBAccountingPeriod.Finder.Find("DisplayName='" + voucher.PostedPeriod + "'");
                                    item.ReversalPostPeriod = period.GetNextPeriod();
                                }
                                else
                                {
                                    SOBAccountingPeriod period = SOBAccountingPeriod.Finder.Find("DisplayName='" + voucher.ReversalPostPeriod + "'");
                                    item.ReversalPostPeriod = period;
                                }
                            }
                            item.CreatedBy = voucher.CreatedBy;
                            if (string.IsNullOrEmpty(voucher.ModifiedBy))
                            {
                                item.ModifiedBy = voucher.CreatedBy;
                            }
                        }
                        session.Commit();
                    }
                    string modifiedby = string.IsNullOrEmpty(voucher.ModifiedBy) ? voucher.CreatedBy : voucher.ModifiedBy;
                    string sql = "update GL_Voucher set CreatedBy='" + voucher.CreatedBy + "' ,ModifiedBy='" + modifiedby + "' where ID=" + voucherLst[0].ID;
                    DataSet data11 = null;
                    DataAccessor.RunSQL(DataAccessor.GetConn(), sql, null, out data11);
                  
                    ProcessResult(voucherLst, conn);
                    string voucherCode = string.Empty;
                    foreach (var d in result)
                    {
                        voucherCode += d.DocNo + ";";
                    }
                    resultEmail.AppendLine(voucher.VoucherType + ":" + voucher.ID + "，" + "导入凭证号成功，成功凭证号：" + voucherCode);
                    resultEmail.AppendLine("\r\n\r\n");
                    resultEmail.AppendLine("<br>");
                    #region 自动核销功能注释
                    //var internalH = glHeader.FindAll(i => i.IsInternal);
                    //if (internalH.Count == 0) return null;
                    //AutoApplyProxy aqProxy = new AutoApplyProxy();
                    //foreach (var item in internalH)
                    //{
                    //    #region 自动核销规则DTO:ApplyOptionDTO
                    //    var apOption = new ApplyOptionDTOData();
                    //    apOption.IsApplyByNMDocNo = false;//按票据号自动核销
                    //    apOption.ApplyType = 0;//0:自动核销，1：红蓝对冲
                    //    apOption.ApplyDate = DateTime.Now;
                    //    apOption.ApplyOrder = 10;
                    //    aqProxy.ApplyOptionDTO = apOption;
                    //    #endregion
                    //    #region 核销查询条件DTO:ApplyQueryDTO
                    //    var apQuery = new ApplyQueryDTOData();
                    //    apQuery.SOB = sob.ID;
                    //    apQuery.EntryDateFrom = DateTime.Now.AddDays(-1);
                    //    apQuery.EntryDateTo = DateTime.Now.AddDays(1);
                    //    apQuery.Direction = 2;//0:借方，1：贷方，2：双向
                    //    apQuery.Currency = item.GLEntryList[0].Currency;
                    //    apQuery.MoneyType = 1;//0：原币，1：本币
                    //    KeyFlexFieldStru stru = KeyFlexFieldStru.Finder.FindByID(17);// 关键性弹性域结构
                    //    var account = Account.FindByCode(stru, item.Segment);
                    //    apQuery.ApplyAccount = account.ID;//核销科目
                    //    aqProxy.ApplyQueryDTO = apQuery;
                    //    #endregion
                    //    aqProxy.Do();
                    //}
                    #endregion

                }
                catch (Exception ex)
                {
                    resultEmail.AppendLine(voucher.VoucherType + ":" + voucher.ID + "，" + ex.Message);
                    resultEmail.AppendLine("\r\n\r\n");
                    resultEmail.AppendLine("<br>");
                    continue;
                }
            }
            string err;
            EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", resultEmail.ToString(), out err);
            return true;
        }

        private void SendDataToMail(List<ISVImportVoucherDTOData> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(item.DescFlexField.PrivateDescSeg3);
                foreach (var line in item.Entries)
                {
                    sb.AppendLine(line.Account.Code + ":" + line.AccountedCr + "," + line.AccountedDr);
                }
            }
            string errMsg = "";
            EmailHelper.SendMail("Voucher", "Error Message for Create Voucher", sb.ToString(), out errMsg);
        }

        private ISVImportEntryDTOData GenerateNewEntry(GLEntry entry, GLVoucher voucher, string accountMatch)
        {
            GLEntry newEntry = new GLEntry();
            entry.CopyTo(newEntry);
            if (entry.Account1 != voucher.Segment)
            {
                var accountLst = accountMatch.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in accountLst)
                {
                    if (item.Contains(entry.Account1))
                    {
                        //newEntry.Account1 = item.Trim("=" + entry.Account1);
                        var tempAcc = item.Split('=');
                        if (tempAcc[0] == entry.Account1)
                        {
                            newEntry.Account1 = tempAcc[1];
                        }
                        else
                        {
                            newEntry.Account1 = tempAcc[0];
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(entry.CustomerSection))
            {
                newEntry.Account7 = entry.CustomerSection;
            }
            if (!string.IsNullOrEmpty(entry.CustomerBU))
            {
                newEntry.Account10 = entry.CustomerBU;
            }
            var temp = ConstructEntry(newEntry, voucher);
            decimal change = 0;
            change = temp.AccountedCr;
            temp.AccountedCr = temp.AccountedDr;
            temp.AccountedDr = change;

            change = temp.AmountCr;
            temp.AmountCr = temp.AmountDr;
            temp.AmountDr = change;

            change = temp.EnteredCr;
            temp.EnteredCr = temp.EnteredDr;
            temp.EnteredDr = change;
            return temp;
        }

        private void ProcessResult(Voucher.EntityList voucherLst, SqlConnection conn)
        {
            DataSet data; StringBuilder sqlUpdate = new StringBuilder();
            foreach (var item in voucherLst)
            {
                if (item.DescFlexField.PrivateDescSeg3.Contains("-Reverse"))
                {
                    sqlUpdate.AppendLine("update GL_Header set ReverseVoucherID=" + item.ID + " where ID='"
                        + item.DescFlexField.PrivateDescSeg3.Replace("-Reverse", "") + "';");
                }
                else
                {
                    sqlUpdate.AppendLine("update GL_Header set IsGenesis='1', VoucherID=" + item.ID + " where ID='"
                        + item.DescFlexField.PrivateDescSeg3 + "';");
                }
                //foreach (var entry in item.Entries)
                //{
                //    sqlUpdate.AppendLine("update GL_Line set EntryID=" + entry.ID + " where ID=" + item.DescFlexField.PrivateDescSeg30 + ";");
                //}
            }
            DataAccessor.RunSQL(conn, sqlUpdate.ToString(), null, out data);
            conn.Close();
        }
        private ISVImportEntryDTOData ConstructEntry(GLEntry entry, GLVoucher voucher)
        {
            ISVImportEntryDTOData VoucherItem = new ISVImportEntryDTOData();
            VoucherItem.Voucher = new ISVImportVoucherDTOData();
            VoucherItem.Voucher.VoucherID = voucher.VoucherID;
            VoucherItem.SerialNo = entry.SerialNo;
            //分录
            VoucherItem.Currency = new CommonArchiveDataDTOData();
            VoucherItem.EntryID = entry.EntryID;
            //摘要
            VoucherItem.Abstracts = entry.Abstracts;
            #region 科目 VoucherItem.Account.Code = stb.ToString();
            StringBuilder stb = new StringBuilder();
            //标准科目
            if (!string.IsNullOrEmpty(entry.Account1))
            {
                stb.Append(entry.Account1);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //客户
            if (!string.IsNullOrEmpty(entry.Account2))//不是核销的科目
            {
                stb.Append(entry.Account2);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //供应商
            if (!string.IsNullOrEmpty(entry.Account3))
            {
                stb.Append(entry.Account3);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //银行
            if (!string.IsNullOrEmpty(entry.Account4))
            {
                stb.Append(entry.Account4);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //银行账号
            if (!string.IsNullOrEmpty(entry.Account5))
            {
                stb.Append(entry.Account5);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //项目
            if (!string.IsNullOrEmpty(entry.Account6))
            {
                stb.Append(entry.Account6);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //部门
            if (!string.IsNullOrEmpty(entry.Account7))
            {
                stb.Append(entry.Account7);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //员工
            if (!string.IsNullOrEmpty(entry.Account8))
            {
                stb.Append(entry.Account8);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //关联类型
            if (!string.IsNullOrEmpty(entry.Account9))
            {
                stb.Append(entry.Account9);
            }
            else
            {
                stb.Append("0");
            }
            stb.Append(SYMBOL);
            //业务单元
            if (!string.IsNullOrEmpty(entry.Account10))
            {
                stb.Append(entry.Account10);
            }
            else
            {
                stb.Append("0");
            }
            VoucherItem.Account = new CommonArchiveDataDTOData();
            VoucherItem.Account.Code = stb.ToString();
            #endregion
            //币种
            VoucherItem.Currency = new CommonArchiveDataDTOData();

            var currency = Currency.FindByCode(entry.CurrencyCode);
            if (currency != null)
            {
                VoucherItem.Currency.ID = currency.ID;
                VoucherItem.Currency.Code = currency.Code;
                VoucherItem.Currency.Name = currency.Name;
                entry.Currency = VoucherItem.Currency.ID;
            }
            //汇率类型
            VoucherItem.ExchangeRateTypes = entry.ExchangeRateTypes;
            //对本币汇率
            VoucherItem.OCToFCExchangeRate = entry.OCToFCExchangeRate;
            //借方金额(本币)
            VoucherItem.AccountedDr = entry.AccountedDr;
            //贷方金额(本币)
            VoucherItem.AccountedCr = entry.AccountedCr;
            //借方金额(原币)
            VoucherItem.EnteredDr = entry.EnteredDr;
            //贷方金额(原币)
            VoucherItem.EnteredCr = entry.EnteredCr;
            //借方数量
            VoucherItem.AmountDr = entry.AmountDr;
            //贷方数量
            VoucherItem.AmountCr = entry.AmountCr;
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
            VoucherItem.Description.PrivateDescSeg1 = entry.DescFlexField_PrivateDescSeg1;
            VoucherItem.Description.PrivateDescSeg2 = entry.DescFlexField_PrivateDescSeg2;
            VoucherItem.Description.PrivateDescSeg3 = entry.DescFlexField_PrivateDescSeg3;
            VoucherItem.Description.PrivateDescSeg4 = entry.DescFlexField_PrivateDescSeg4;
            VoucherItem.Description.PrivateDescSeg5 = entry.DescFlexField_PrivateDescSeg5;
            VoucherItem.Description.PrivateDescSeg6 = entry.DescFlexField_PrivateDescSeg6;
            VoucherItem.Description.PrivateDescSeg7 = entry.DescFlexField_PrivateDescSeg7;
            VoucherItem.Description.PrivateDescSeg8 = entry.DescFlexField_PrivateDescSeg8;
            VoucherItem.Description.PrivateDescSeg9 = entry.DescFlexField_PrivateDescSeg9;
            VoucherItem.Description.PrivateDescSeg10 = entry.DescFlexField_PrivateDescSeg10;
            VoucherItem.Description.PrivateDescSeg11 = entry.DescFlexField_PrivateDescSeg11;
            VoucherItem.Description.PrivateDescSeg12 = entry.DescFlexField_PrivateDescSeg12;
            VoucherItem.Description.PrivateDescSeg13 = entry.DescFlexField_PrivateDescSeg13;
            VoucherItem.Description.PrivateDescSeg14 = entry.DescFlexField_PrivateDescSeg14;
            VoucherItem.Description.PrivateDescSeg15 = entry.DescFlexField_PrivateDescSeg15;
            VoucherItem.Description.PrivateDescSeg16 = entry.DescFlexField_PrivateDescSeg16;
            VoucherItem.Description.PrivateDescSeg17 = entry.DescFlexField_PrivateDescSeg17;
            VoucherItem.Description.PrivateDescSeg18 = entry.DescFlexField_PrivateDescSeg18;
            VoucherItem.Description.PrivateDescSeg19 = entry.DescFlexField_PrivateDescSeg19;
            VoucherItem.Description.PrivateDescSeg20 = entry.DescFlexField_PrivateDescSeg20;
            VoucherItem.Description.PrivateDescSeg21 = entry.DescFlexField_PrivateDescSeg21;
            VoucherItem.Description.PrivateDescSeg22 = entry.DescFlexField_PrivateDescSeg22;
            VoucherItem.Description.PrivateDescSeg23 = entry.DescFlexField_PrivateDescSeg23;
            VoucherItem.Description.PrivateDescSeg24 = entry.DescFlexField_PrivateDescSeg24;
            VoucherItem.Description.PrivateDescSeg25 = entry.DescFlexField_PrivateDescSeg25;
            VoucherItem.Description.PrivateDescSeg26 = entry.DescFlexField_PrivateDescSeg26;
            VoucherItem.Description.PrivateDescSeg27 = entry.DescFlexField_PrivateDescSeg27;
            VoucherItem.Description.PrivateDescSeg28 = entry.DescFlexField_PrivateDescSeg28;
            VoucherItem.Description.PrivateDescSeg29 = entry.DescFlexField_PrivateDescSeg29;
            VoucherItem.Description.PrivateDescSeg30 = entry.ID.ToString();//存导入EntryID 方便回写
            VoucherItem.Description.PubDescSeg1 = entry.DescFlexField_PubDescSeg1;
            VoucherItem.Description.PubDescSeg2 = entry.DescFlexField_PubDescSeg2;
            VoucherItem.Description.PubDescSeg3 = entry.DescFlexField_PubDescSeg3;
            VoucherItem.Description.PubDescSeg4 = entry.DescFlexField_PubDescSeg4;
            VoucherItem.Description.PubDescSeg5 = entry.DescFlexField_PubDescSeg5;
            VoucherItem.Description.PubDescSeg6 = entry.DescFlexField_PubDescSeg6;
            VoucherItem.Description.PubDescSeg7 = entry.DescFlexField_PubDescSeg7;
            VoucherItem.Description.PubDescSeg8 = entry.DescFlexField_PubDescSeg8;
            VoucherItem.Description.PubDescSeg9 = entry.DescFlexField_PubDescSeg9;
            VoucherItem.Description.PubDescSeg10 = entry.DescFlexField_PubDescSeg10;
            VoucherItem.Description.PubDescSeg11 = entry.DescFlexField_PubDescSeg11;
            VoucherItem.Description.PubDescSeg12 = entry.DescFlexField_PubDescSeg12;
            VoucherItem.Description.PubDescSeg13 = entry.DescFlexField_PubDescSeg13;
            VoucherItem.Description.PubDescSeg14 = entry.DescFlexField_PubDescSeg14;
            VoucherItem.Description.PubDescSeg15 = entry.DescFlexField_PubDescSeg15;
            VoucherItem.Description.PubDescSeg16 = entry.DescFlexField_PubDescSeg16;
            VoucherItem.Description.PubDescSeg17 = entry.DescFlexField_PubDescSeg17;
            VoucherItem.Description.PubDescSeg18 = entry.DescFlexField_PubDescSeg18;
            VoucherItem.Description.PubDescSeg19 = entry.DescFlexField_PubDescSeg19;
            VoucherItem.Description.PubDescSeg20 = entry.DescFlexField_PubDescSeg20;
            VoucherItem.Description.PubDescSeg21 = entry.DescFlexField_PubDescSeg21;
            VoucherItem.Description.PubDescSeg22 = entry.DescFlexField_PubDescSeg22;
            VoucherItem.Description.PubDescSeg23 = entry.DescFlexField_PubDescSeg23;
            VoucherItem.Description.PubDescSeg24 = entry.DescFlexField_PubDescSeg24;
            VoucherItem.Description.PubDescSeg25 = entry.DescFlexField_PubDescSeg25;
            VoucherItem.Description.PubDescSeg26 = entry.DescFlexField_PubDescSeg26;
            VoucherItem.Description.PubDescSeg27 = entry.DescFlexField_PubDescSeg27;
            VoucherItem.Description.PubDescSeg28 = entry.DescFlexField_PubDescSeg28;
            VoucherItem.Description.PubDescSeg29 = entry.DescFlexField_PubDescSeg29;
            VoucherItem.Description.PubDescSeg30 = entry.DescFlexField_PubDescSeg30;
            VoucherItem.Description.PubDescSeg31 = entry.DescFlexField_PubDescSeg31;
            VoucherItem.Description.PubDescSeg32 = entry.DescFlexField_PubDescSeg32;
            VoucherItem.Description.PubDescSeg33 = entry.DescFlexField_PubDescSeg33;
            VoucherItem.Description.PubDescSeg34 = entry.DescFlexField_PubDescSeg34;
            VoucherItem.Description.PubDescSeg35 = entry.DescFlexField_PubDescSeg35;
            VoucherItem.Description.PubDescSeg36 = entry.DescFlexField_PubDescSeg36;
            VoucherItem.Description.PubDescSeg37 = entry.DescFlexField_PubDescSeg37;
            VoucherItem.Description.PubDescSeg38 = entry.DescFlexField_PubDescSeg38;
            VoucherItem.Description.PubDescSeg39 = entry.DescFlexField_PubDescSeg39;
            VoucherItem.Description.PubDescSeg40 = entry.DescFlexField_PubDescSeg40;
            VoucherItem.Description.PubDescSeg41 = entry.DescFlexField_PubDescSeg41;
            VoucherItem.Description.PubDescSeg42 = entry.DescFlexField_PubDescSeg42;
            VoucherItem.Description.PubDescSeg43 = entry.DescFlexField_PubDescSeg43;
            VoucherItem.Description.PubDescSeg44 = entry.DescFlexField_PubDescSeg44;
            VoucherItem.Description.PubDescSeg45 = entry.DescFlexField_PubDescSeg45;
            VoucherItem.Description.PubDescSeg46 = entry.DescFlexField_PubDescSeg46;
            VoucherItem.Description.PubDescSeg47 = entry.DescFlexField_PubDescSeg47;
            VoucherItem.Description.PubDescSeg48 = entry.DescFlexField_PubDescSeg48;
            VoucherItem.Description.PubDescSeg49 = entry.DescFlexField_PubDescSeg49;
            VoucherItem.Description.PubDescSeg50 = entry.DescFlexField_PubDescSeg50;
            #endregion
            return VoucherItem;
        }
        private ISVImportVoucherDTOData ConstructVoucher(GLVoucher voucher)
        {
            ISVImportVoucherDTOData dto = new ISVImportVoucherDTOData();
            dto.Entries = new List<ISVImportEntryDTOData>();
            //账簿
            dto.SOB = new CommonArchiveDataDTOData();

            //凭证类型
            var voucherCategory = VoucherCategory.Finder.Find("Code=" + voucher.VoucherCategoryCode);
            dto.VoucherCategory = new CommonArchiveDataDTOData();
            if (voucherCategory != null)
            {
                dto.VoucherCategory.ID = voucherCategory.ID;
                dto.VoucherCategory.Code = voucherCategory.Code;
                dto.VoucherCategory.Name = voucherCategory.Name;
            }
            //dto.VoucherDisplayCode = voucher.DescFlexField_PrivateDescSeg2;
            //凭证号
            dto.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
            dto.DescFlexField.PrivateDescSeg2 = voucher.DescFlexField_PrivateDescSeg2;
            //私有字段3 用于存中间表的ID  方便后续查找到通过中间表生成的凭证
            dto.DescFlexField.PrivateDescSeg3 = voucher.ID;
            //制单日期--如果空就取当前日期
            dto.CreateDate = voucher.CreateDate == DateTime.MinValue ? DateTime.Now : voucher.CreateDate;
            //记账期间
            dto.PostedPeriod = voucher.PostedPeriod;
            //附单据数
            dto.AttachmentCount = voucher.AttachmentCount;
            //凭证ID
            dto.VoucherID = voucher.VoucherID;
            return dto;
        }
        private List<GLVoucher> CovertToEntry(DataTable dt)
        {
            List<GLVoucher> glHeaderLst = new List<GLVoucher>();
            foreach (DataRow row in dt.Rows)
            {
                string id = row["HeaderID"].ToString();
                var glHeadTmp = glHeaderLst.Find(i => i.ID == id);
                if (glHeadTmp != null) continue;
                GLVoucher glHeader = new GLVoucher
                {
                    ID = id,
                    VoucherCategoryCode = row["VoucherCategoryCode"].ToString(),
                    DescFlexField_PrivateDescSeg2 = row["DescFlexField_PrivateDescSeg2"].ToString(),
                    PostedPeriod = row["PostedPeriod"].ToString(),
                    VoucherType = row["VoucherType"].ToString(),
                    CreatedBy = row["CreatedBy"].ToString(),
                    ModifiedBy = row["ModifiedBy"].ToString()
                };
                if (!string.IsNullOrEmpty(row["Segment"].ToString()))
                {
                    glHeader.Segment = row["Segment"].ToString();
                }
                else
                {
                    glHeader.Segment = "850000";
                }
                if (!string.IsNullOrEmpty(row["AttachmentCount"].ToString()))
                {
                    glHeader.AttachmentCount = int.Parse(row["AttachmentCount"].ToString());
                }
                if (!string.IsNullOrEmpty(row["VoucherID"].ToString()))
                {
                    glHeader.VoucherID = long.Parse(row["VoucherID"].ToString());
                }
                if (!string.IsNullOrEmpty(row["CreateDate"].ToString()))
                {
                    glHeader.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }

                if (!string.IsNullOrEmpty(row["IsNeedReverse"].ToString()))
                {
                    glHeader.IsNeedReverse = bool.Parse(row["IsNeedReverse"].ToString());
                }
                if (row["ReverseMethod"] == null)
                {
                    glHeader.ReverseMethod = 1;//1 红冲，转换借贷方向  0  
                }
                else if (!string.IsNullOrEmpty(row["ReverseMethod"].ToString()))
                {
                    glHeader.ReverseMethod = int.Parse(row["ReverseMethod"].ToString());
                }
                else
                {
                    glHeader.ReverseMethod = 1;//1 红冲，转换借贷方向  0  
                }
                //ReversalPostPeriod int（转回凭证记账期间），如果为空或者Null，默认为PostedPeriod + 1，即为下一个期间；
                if (row["ReversalPostPeriod"] == null)
                {
                    glHeader.ReversalPostPeriod = "";
                }
                else if (!string.IsNullOrEmpty(row["ReversalPostPeriod"].ToString()))
                {
                    glHeader.ReversalPostPeriod = row["ReversalPostPeriod"].ToString();
                }
                else
                {
                    glHeader.ReversalPostPeriod = "";
                }

                bool isInternal = false;
                bool.TryParse(row["IsInternal"].ToString(), out  isInternal);
                glHeader.IsInternal = isInternal;
                glHeaderLst.Add(glHeader);
            }
            foreach (var header in glHeaderLst)
            {
                header.GLEntryList = new List<GLEntry>();
                var lineNo = 10; var lineNo1 = 10;
                foreach (DataRow row in dt.Rows)
                {
                    string id = row["HeaderID"].ToString();
                    if (id == header.ID)
                    {
                        if (string.IsNullOrEmpty(row["LineID"].ToString())) continue;
                        GLEntry glLine = new GLEntry
                        {
                            ID = long.Parse(row["LineID"].ToString()),
                            #region 弹性域
                            DescFlexField_PrivateDescSeg1 = row["DescFlexField_PrivateDescSeg1"].ToString(),
                            DescFlexField_PrivateDescSeg2 = row["DescFlexField_PrivateDescSeg2"].ToString(),
                            DescFlexField_PrivateDescSeg3 = row["DescFlexField_PrivateDescSeg3"].ToString(),
                            DescFlexField_PrivateDescSeg4 = row["DescFlexField_PrivateDescSeg4"].ToString(),
                            DescFlexField_PrivateDescSeg5 = row["DescFlexField_PrivateDescSeg5"].ToString(),
                            DescFlexField_PrivateDescSeg6 = row["DescFlexField_PrivateDescSeg6"].ToString(),
                            DescFlexField_PrivateDescSeg7 = row["DescFlexField_PrivateDescSeg7"].ToString(),
                            DescFlexField_PrivateDescSeg8 = row["DescFlexField_PrivateDescSeg8"].ToString(),
                            DescFlexField_PrivateDescSeg9 = row["DescFlexField_PrivateDescSeg9"].ToString(),
                            DescFlexField_PrivateDescSeg10 = row["DescFlexField_PrivateDescSeg10"].ToString(),
                            DescFlexField_PrivateDescSeg11 = row["DescFlexField_PrivateDescSeg11"].ToString(),
                            DescFlexField_PrivateDescSeg12 = row["DescFlexField_PrivateDescSeg12"].ToString(),
                            DescFlexField_PrivateDescSeg13 = row["DescFlexField_PrivateDescSeg13"].ToString(),
                            DescFlexField_PrivateDescSeg14 = row["DescFlexField_PrivateDescSeg14"].ToString(),
                            DescFlexField_PrivateDescSeg15 = row["DescFlexField_PrivateDescSeg15"].ToString(),
                            DescFlexField_PrivateDescSeg16 = row["DescFlexField_PrivateDescSeg16"].ToString(),
                            DescFlexField_PrivateDescSeg17 = row["DescFlexField_PrivateDescSeg17"].ToString(),
                            DescFlexField_PrivateDescSeg18 = row["DescFlexField_PrivateDescSeg18"].ToString(),
                            DescFlexField_PrivateDescSeg19 = row["DescFlexField_PrivateDescSeg19"].ToString(),
                            DescFlexField_PrivateDescSeg20 = row["DescFlexField_PrivateDescSeg20"].ToString(),
                            DescFlexField_PrivateDescSeg21 = row["DescFlexField_PrivateDescSeg21"].ToString(),
                            DescFlexField_PrivateDescSeg22 = row["DescFlexField_PrivateDescSeg22"].ToString(),
                            DescFlexField_PrivateDescSeg23 = row["DescFlexField_PrivateDescSeg23"].ToString(),
                            DescFlexField_PrivateDescSeg24 = row["DescFlexField_PrivateDescSeg24"].ToString(),
                            DescFlexField_PrivateDescSeg25 = row["DescFlexField_PrivateDescSeg25"].ToString(),
                            DescFlexField_PrivateDescSeg26 = row["DescFlexField_PrivateDescSeg26"].ToString(),
                            DescFlexField_PrivateDescSeg27 = row["DescFlexField_PrivateDescSeg27"].ToString(),
                            DescFlexField_PrivateDescSeg28 = row["DescFlexField_PrivateDescSeg28"].ToString(),
                            DescFlexField_PrivateDescSeg29 = row["DescFlexField_PrivateDescSeg29"].ToString(),
                            DescFlexField_PrivateDescSeg30 = row["DescFlexField_PrivateDescSeg30"].ToString(),
                            DescFlexField_PubDescSeg1 = row["DescFlexField_PubDescSeg1"].ToString(),
                            DescFlexField_PubDescSeg2 = row["DescFlexField_PubDescSeg2"].ToString(),
                            DescFlexField_PubDescSeg3 = row["DescFlexField_PubDescSeg3"].ToString(),
                            DescFlexField_PubDescSeg4 = row["DescFlexField_PubDescSeg4"].ToString(),
                            DescFlexField_PubDescSeg5 = row["DescFlexField_PubDescSeg5"].ToString(),
                            DescFlexField_PubDescSeg6 = row["DescFlexField_PubDescSeg6"].ToString(),
                            DescFlexField_PubDescSeg7 = row["DescFlexField_PubDescSeg7"].ToString(),
                            DescFlexField_PubDescSeg8 = row["DescFlexField_PubDescSeg8"].ToString(),
                            DescFlexField_PubDescSeg9 = row["DescFlexField_PubDescSeg9"].ToString(),
                            DescFlexField_PubDescSeg10 = row["DescFlexField_PubDescSeg10"].ToString(),
                            DescFlexField_PubDescSeg11 = row["DescFlexField_PubDescSeg11"].ToString(),
                            DescFlexField_PubDescSeg12 = row["DescFlexField_PubDescSeg12"].ToString(),
                            DescFlexField_PubDescSeg13 = row["DescFlexField_PubDescSeg13"].ToString(),
                            DescFlexField_PubDescSeg14 = row["DescFlexField_PubDescSeg14"].ToString(),
                            DescFlexField_PubDescSeg15 = row["DescFlexField_PubDescSeg15"].ToString(),
                            DescFlexField_PubDescSeg16 = row["DescFlexField_PubDescSeg16"].ToString(),
                            DescFlexField_PubDescSeg17 = row["DescFlexField_PubDescSeg17"].ToString(),
                            DescFlexField_PubDescSeg18 = row["DescFlexField_PubDescSeg18"].ToString(),
                            DescFlexField_PubDescSeg19 = row["DescFlexField_PubDescSeg19"].ToString(),
                            DescFlexField_PubDescSeg20 = row["DescFlexField_PubDescSeg20"].ToString(),
                            DescFlexField_PubDescSeg21 = row["DescFlexField_PubDescSeg21"].ToString(),
                            DescFlexField_PubDescSeg22 = row["DescFlexField_PubDescSeg22"].ToString(),
                            DescFlexField_PubDescSeg23 = row["DescFlexField_PubDescSeg23"].ToString(),
                            DescFlexField_PubDescSeg24 = row["DescFlexField_PubDescSeg24"].ToString(),
                            DescFlexField_PubDescSeg25 = row["DescFlexField_PubDescSeg25"].ToString(),
                            DescFlexField_PubDescSeg26 = row["DescFlexField_PubDescSeg26"].ToString(),
                            DescFlexField_PubDescSeg27 = row["DescFlexField_PubDescSeg27"].ToString(),
                            DescFlexField_PubDescSeg28 = row["DescFlexField_PubDescSeg28"].ToString(),
                            DescFlexField_PubDescSeg29 = row["DescFlexField_PubDescSeg29"].ToString(),
                            DescFlexField_PubDescSeg30 = row["DescFlexField_PubDescSeg30"].ToString(),
                            DescFlexField_PubDescSeg31 = row["DescFlexField_PubDescSeg31"].ToString(),
                            DescFlexField_PubDescSeg32 = row["DescFlexField_PubDescSeg32"].ToString(),
                            DescFlexField_PubDescSeg33 = row["DescFlexField_PubDescSeg33"].ToString(),
                            DescFlexField_PubDescSeg34 = row["DescFlexField_PubDescSeg34"].ToString(),
                            DescFlexField_PubDescSeg35 = row["DescFlexField_PubDescSeg35"].ToString(),
                            DescFlexField_PubDescSeg36 = row["DescFlexField_PubDescSeg36"].ToString(),
                            DescFlexField_PubDescSeg37 = row["DescFlexField_PubDescSeg37"].ToString(),
                            DescFlexField_PubDescSeg38 = row["DescFlexField_PubDescSeg38"].ToString(),
                            DescFlexField_PubDescSeg39 = row["DescFlexField_PubDescSeg39"].ToString(),
                            DescFlexField_PubDescSeg40 = row["DescFlexField_PubDescSeg40"].ToString(),
                            DescFlexField_PubDescSeg41 = row["DescFlexField_PubDescSeg41"].ToString(),
                            DescFlexField_PubDescSeg42 = row["DescFlexField_PubDescSeg42"].ToString(),
                            DescFlexField_PubDescSeg43 = row["DescFlexField_PubDescSeg43"].ToString(),
                            DescFlexField_PubDescSeg44 = row["DescFlexField_PubDescSeg44"].ToString(),
                            DescFlexField_PubDescSeg45 = row["DescFlexField_PubDescSeg45"].ToString(),
                            DescFlexField_PubDescSeg46 = row["DescFlexField_PubDescSeg46"].ToString(),
                            DescFlexField_PubDescSeg47 = row["DescFlexField_PubDescSeg47"].ToString(),
                            DescFlexField_PubDescSeg48 = row["DescFlexField_PubDescSeg48"].ToString(),
                            DescFlexField_PubDescSeg49 = row["DescFlexField_PubDescSeg49"].ToString(),
                            DescFlexField_PubDescSeg50 = row["DescFlexField_PubDescSeg50"].ToString(),
                            #endregion
                            Abstracts = row["Abstracts"].ToString(),
                            Account1 = row["Segment1"].ToString(),
                            Account2 = row["Segment2"].ToString(),
                            Account3 = row["Segment3"].ToString(),
                            Account4 = row["Segment4"].ToString(),
                            Account5 = row["Segment5"].ToString(),
                            Account6 = row["Segment6"].ToString(),
                            Account7 = row["Segment7"].ToString(),
                            Account8 = row["Segment8"].ToString(),
                            Account9 = row["Segment9"].ToString(),
                            Account10 = row["Segment10"].ToString(),
                            CurrencyCode = row["CurrencyCode"].ToString(),
                            BankAccountCode = row["BankAccountCode"].ToString(),
                            IncomeExpendItemCode = row["IncomeExpendItemCode"].ToString(),
                            SettlementMethodCode = row["SettlementMethodCode"].ToString(),
                            InternalApAR = row["InternalApAR"].ToString(),//用于内部核销标志
                            UOMCode = row["UOMCode"].ToString(),
                            Customer_Code = row["CustomerCode"].ToString(),//SupplierCode,CustomerCode,B.CustomerSection ,B.CustomerBU
                            CustomerBU = row["CustomerBU"].ToString(),
                            CustomerSection = row["CustomerSection"].ToString(),
                            Supplier_Code = row["SupplierCode"].ToString()
                        };
                        if (string.IsNullOrEmpty(glLine.CurrencyCode))
                        {
                            glLine.CurrencyCode = "RMB";
                        }
                        if (!string.IsNullOrEmpty(row["ExchangeRateTypes"].ToString()))
                        {
                            glLine.ExchangeRateTypes = int.Parse(row["ExchangeRateTypes"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["SerialNo"].ToString()))
                        {
                            glLine.SerialNo = int.Parse(row["SerialNo"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["OCToFCExchangeRate"].ToString()))
                        {
                            glLine.OCToFCExchangeRate = decimal.Parse(row["OCToFCExchangeRate"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["AccountedCr"].ToString()))
                        {
                            glLine.AccountedCr = decimal.Parse(row["AccountedCr"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["AccountedDr"].ToString()))
                        {
                            glLine.AccountedDr = decimal.Parse(row["AccountedDr"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["AmountCr"].ToString()))
                        {
                            glLine.AmountCr = decimal.Parse(row["AmountCr"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["AmountDr"].ToString()))
                        {
                            glLine.AmountDr = decimal.Parse(row["AmountDr"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["EnteredCr"].ToString()))
                        {
                            glLine.EnteredCr = decimal.Parse(row["EnteredCr"].ToString());
                        }
                        if (!string.IsNullOrEmpty(row["EnteredDr"].ToString()))
                        {
                            glLine.EnteredDr = decimal.Parse(row["EnteredDr"].ToString());
                        }
                        //行号 不输系统处理为10,20…

                        if (glLine.SerialNo == 0)
                        {
                            if (glLine.InternalApAR == "AP")
                            {
                                glLine.SerialNo = lineNo;
                                lineNo += 10;
                            }
                            else
                            {
                                glLine.SerialNo = lineNo1;
                                lineNo1 += 10;
                            }
                        }
                        header.GLEntryList.Add(glLine);
                    }
                }
            }
            return glHeaderLst;
        }
    }

    #endregion
}