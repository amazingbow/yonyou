namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// ProcessRelData partial 
    /// </summary>	
    public partial class ProcessRelData
    {
        internal BaseStrategy Select()
        {
            return new ProcessRelDataImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ProcessRelDataImpementStrategy : BaseStrategy
    {
        public ProcessRelDataImpementStrategy() { }

        public override object Do(object obj)
        {
            ProcessRelData bpObj = (ProcessRelData)obj;
            List<string> returnVoucher = new List<string>();
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful=0 or IsU9Successful=2");//0 代表数据没有执行过，1代表成功导入U9，2代表导入U9失败
            if (glVoucherLst.Count == 0)
            {
                return returnVoucher;
            }

            Dictionary<int, Dictionary<string, string>> codeNamePair = new Dictionary<int, Dictionary<string, string>>();
            codeNamePair.Add(1, new Dictionary<string, string>());//币种
            codeNamePair.Add(2, new Dictionary<string, string>());//客户
            codeNamePair.Add(3, new Dictionary<string, string>());//供应商
            codeNamePair.Add(4, new Dictionary<string, string>());//部门
            codeNamePair.Add(5, new Dictionary<string, string>());//员工
            codeNamePair.Add(6, new Dictionary<string, string>());//现金流
            codeNamePair.Add(7, new Dictionary<string, string>());//组织
            codeNamePair.Add(8, new Dictionary<string, string>());//凭证类型
            codeNamePair.Add(9, new Dictionary<string, string>()); //项目
            codeNamePair.Add(10, new Dictionary<string, string>());//科目
            codeNamePair.Add(11, new Dictionary<string, string>());//费用项目
            codeNamePair.Add(12, new Dictionary<string, string>());//银行
            codeNamePair.Add(13, new Dictionary<string, string>());//特殊：供应商对照到客户
            #region 构造要存储的数据
            foreach (var item in glVoucherLst)
            {
                if (!string.IsNullOrEmpty(item.CurrencyCode))
                {
                    if (!codeNamePair[1].ContainsKey(item.CurrencyCode))//币种
                    {
                        codeNamePair[1].Add(item.CurrencyCode, item.CurrencyDescription + "@" + item.SAPVoucherDisplayCode);
                    }
                }
                if (!string.IsNullOrEmpty(item.CompanyCode))
                {
                    if (!codeNamePair[7].ContainsKey(item.CompanyCode))//组织
                    {
                        codeNamePair[7].Add(item.CompanyCode, item.CompanyName + "@" + item.SAPVoucherDisplayCode);
                    }
                }
                if (!string.IsNullOrEmpty(item.VoucherCategoryCode))
                {
                    if (!codeNamePair[8].ContainsKey(item.VoucherCategoryCode))//凭证类型
                    {
                        codeNamePair[8].Add(item.VoucherCategoryCode, item.VoucherCategoryDescription + "@" + item.SAPVoucherDisplayCode);
                    }
                }
                foreach (var line in item.HeXingSAPU9GLVoucherLine)
                {
                    if (!string.IsNullOrEmpty(line.CustomerCode))
                    {
                        if (!codeNamePair[2].ContainsKey(line.CustomerCode))//客户
                        {
                            codeNamePair[2].Add(line.CustomerCode, line.CustomerDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    //应付股利U9按客户核算，SAP按供应商核算
                    //需要将凭证对应的供应商，参照到U9客户，对照类型为"供应商对客户"，以便与之前的对照关系区别开来
                    //SAP应付股利：应付股利-发起人股 2232020000
                    if (!string.IsNullOrEmpty(line.SupplierCode))
                    {
                        if (line.AccountCode == "2232020000")
                        {
                            if (!codeNamePair[13].ContainsKey(line.SupplierCode))//供应商对客户
                            {
                                codeNamePair[13].Add(line.SupplierCode, line.SupplierDescription + "@" + item.SAPVoucherDisplayCode);
                            }
                        }
                        else
                        {
                            if (!codeNamePair[3].ContainsKey(line.SupplierCode))//供应商
                            {
                                codeNamePair[3].Add(line.SupplierCode, line.SupplierDescription + "@" + item.SAPVoucherDisplayCode);
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(line.DepartmentCode))
                    {
                        var deptCode = line.DepartmentCode + ";" + item.CompanyCode;
                        if (!codeNamePair[4].ContainsKey(deptCode))//部门
                        {
                            codeNamePair[4].Add(deptCode, line.DepartmentName + ";" + item.CompanyName + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    if (!string.IsNullOrEmpty(line.EmployeeCode))
                    {
                        if (!codeNamePair[5].ContainsKey(line.EmployeeCode))//员工
                        {
                            codeNamePair[5].Add(line.EmployeeCode, line.EmployeeName + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    if (!string.IsNullOrEmpty(line.CashFlowCode))
                    {
                        if (!codeNamePair[6].ContainsKey(line.CashFlowCode))//现金流
                        {
                            codeNamePair[6].Add(line.CashFlowCode, line.CashFlowDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    if (!string.IsNullOrEmpty(line.AssetsCode))
                    {
                        if (!codeNamePair[9].ContainsKey(line.AssetsCode))//项目==资产编码
                        {
                            codeNamePair[9].Add(line.AssetsCode, line.AssetsDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    //实收资本U9将客户直接放在二级科目，SAP为客户核算；处理方案如下：
                    //①SAP与U9档案基础维护，针对实收资本的SAP科目(SAP科目编码为4001010000)，在维护对找关系时，还需要加上一个客户编码、客户名称列，
                    //以便用户选择U9的实收资本科目。
                    //②在生成U9凭证时，还需要考虑这个维度的关系，以便转换成U9的实收资本科目。
                    if (line.AccountCode == "4001010000")
                    {
                        var accountCode = line.AccountCode + ";" + line.CustomerCode;
                        if (!codeNamePair[10].ContainsKey(accountCode))//科目
                        {
                            codeNamePair[10].Add(accountCode, line.AccountDescription + ";" + line.CustomerDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    else
                    {
                        var accountCode = line.AccountCode + ";" + line.MaterialGroupCode + ";" + line.AssetsCode + ";" + line.FeeTypeEnumCode;
                        if (!codeNamePair[10].ContainsKey(accountCode))//科目
                        {
                            codeNamePair[10].Add(accountCode, line.AccountDescription + ";" + line.MaterialGroupDescription + ";"
                                + line.AssetsDescription + ";" + line.FeeTypeEnumDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }

                    if (!string.IsNullOrEmpty(line.FeeTypeEnumCode))
                    {
                        if (!codeNamePair[11].ContainsKey(line.FeeTypeEnumCode))//费用项目
                        {
                            codeNamePair[11].Add(line.FeeTypeEnumCode, line.FeeTypeEnumDescription + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                    if (!string.IsNullOrEmpty(line.Banks))
                    {
                        if (!codeNamePair[12].ContainsKey(line.Banks))//银行
                        {
                            codeNamePair[12].Add(line.Banks, line.Banks + "@" + item.SAPVoucherDisplayCode);
                        }
                    }
                }
            }
            #endregion
            using (ISession session = Session.Open())
            {
                #region  币种
                foreach (var item in codeNamePair[1])
                {
                    HxRelationshipBE shipCurrency = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=1 and SapCode='" + item.Key + "'"); //"' and SapName='" + item.Value 
                    if (shipCurrency == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Currency;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "币种没有维护对照关系");
                    }
                }
                #endregion
                #region 客户
                foreach (var item in codeNamePair[2])
                {
                    HxRelationshipBE shipCust = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=2 and SapCode='" + item.Key + "'");
                    if (shipCust == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Customer;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "客户没有维护对照关系");
                    }
                }
                #endregion
                #region 供应商
                foreach (var item in codeNamePair[3])
                {
                    HxRelationshipBE shipSupplier = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=3 and SapCode='" + item.Key + "'");
                    if (shipSupplier == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Supplier;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "供应商没有维护对照关系");
                    }
                }
                #endregion
                #region//部门
                foreach (var item in codeNamePair[4])
                {
                    var tempArray = item.Key.Split(';');
                    var deptCode = tempArray[0];
                    var compCode = tempArray[1];
                    HxRelationshipBE shipDept = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=4 and SapCode='" + deptCode + "' and SapCompCode='"
                        + compCode + "'");
                    if (shipDept == null)
                    {
                        var valueArray = item.Value.Split('@')[0].Split(';');
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Dept;
                        relationship.SapCode = deptCode;
                        relationship.SapName = valueArray[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        relationship.SapCompCode = compCode;
                        relationship.SapCompName = valueArray[1];
                        returnVoucher.Add(item.Value.Split('@')[1] + "部门没有维护对照关系");
                    }
                }
                #endregion
                #region //员工
                foreach (var item in codeNamePair[5])
                {
                    HxRelationshipBE shipEmp = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=5 and SapCode='" + item.Key + "'");
                    if (shipEmp == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Staff;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "员工没有维护对照关系");
                    }
                }
                #endregion
                #region//现金流
                foreach (var item in codeNamePair[6])
                {
                    HxRelationshipBE shipCashFlowCode = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=6 and SapCode='" + item.Key + "'");
                    if (shipCashFlowCode == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Cash;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "现金流项目没有维护对照关系");
                    }
                }
                #endregion
                #region //组织
                foreach (var item in codeNamePair[7])
                {
                    HxRelationshipBE shipOrg = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=7 and SapCode='" + item.Key + "'");
                    if (shipOrg == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Org;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "组织没有维护对照关系");
                    }
                }
                #endregion
                #region//凭证类型
                foreach (var item in codeNamePair[8])
                {
                    HxRelationshipBE shipCategory = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=8 and SapCode='" + item.Key + "'");
                    if (shipCategory == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.VoucherCategory;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "凭证类型没有维护对照关系");
                    }
                }
                #endregion
                #region //项目
                foreach (var item in codeNamePair[9])
                {
                    HxRelationshipBE shipDepartment = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=9 and SapCode='" + item.Key + "'");
                    if (shipDepartment == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Project;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "资产所对应的U9项目没有维护对照关系");
                    }
                }
                #endregion
                #region//科目
                foreach (var item in codeNamePair[10])
                {
                    //var accountCode = line.AccountCode + ";" + line.MaterialGroupCode + ";" + line.AssetsCode + ";" + line.FeeTypeEnumCode;
                    //codeNamePair[10].Add(accountCode, line.AccountDescription + ";" + line.MaterialGroupDescription + ";"
                    //       + line.AssetsDescription + ";" + line.FeeTypeEnumDescription + "@" + item.SAPVoucherDisplayCode);
                    var tempArray = item.Key.Split(';');
                    var AccountCode = tempArray[0];
                    if (AccountCode == "4001010000")
                    {
                        var CustomerCode = tempArray[1];
                        HxRelationshipBE shipAccount = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=10 and SapCode='" + AccountCode
                            + "' and CustomerCode='" + CustomerCode + "'");
                        if (shipAccount == null)
                        {
                            var valueArray = item.Value.Split('@')[0].Split(';');
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Account;
                            relationship.SapCode = AccountCode;
                            relationship.SapName = valueArray[0];
                            relationship.CustomerCode = CustomerCode;
                            relationship.CustomerName = valueArray[1];
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            returnVoucher.Add(item.Value.Split('@')[1] + "科目没有维护对照关系");
                        }
                    }
                    else
                    {
                        var MaterialGroupCode = tempArray[1];
                        var AssetsCode = tempArray[2];
                        var FeeTypeEnumCode = tempArray[3];
                        HxRelationshipBE shipAccount = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=10 and SapCode='" + AccountCode +
                            "' and SapMasterCode='" + MaterialGroupCode + "' and SapAssetsCode='" + AssetsCode + "' and SapFeeCode='" + FeeTypeEnumCode + "'");
                        if (shipAccount == null)
                        {
                            var valueArray = item.Value.Split('@')[0].Split(';');
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Account;
                            relationship.SapCode = AccountCode;
                            relationship.SapName = valueArray[0];
                            relationship.SapMasterCode = MaterialGroupCode;
                            relationship.SapMasterName = valueArray[1];
                            relationship.SapAssetsCode = AssetsCode;
                            relationship.SapAssetsName = valueArray[2];
                            relationship.SapFeeCode = FeeTypeEnumCode;
                            relationship.SapFeeName = valueArray[3];
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            returnVoucher.Add(item.Value.Split('@')[1] + "科目没有维护对照关系");
                        }
                    }
                }
                #endregion
                #region //费用项目
                foreach (var item in codeNamePair[11])
                {
                    HxRelationshipBE shipFeeType = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=11 and SapCode='" + item.Key + "'");
                    if (shipFeeType == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.FeeType;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "费用项目没有维护对照关系");
                    }
                }
                #endregion
                #region //银行
                foreach (var item in codeNamePair[12])
                {
                    HxRelationshipBE shipBank = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=12 and SapCode='" + item.Key + "'");
                    if (shipBank == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Bank;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "银行没有维护对照关系");
                    }
                }
                #endregion
                #region 供应商对客户
                foreach (var item in codeNamePair[13])
                {
                    HxRelationshipBE shipSupplier = HxRelationshipBE.Finder.Find("RefStatus!=0 and RefType=13 and SapCode='" + item.Key + "'");
                    if (shipSupplier == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.SupplierCust;
                        relationship.SapCode = item.Key;
                        relationship.SapName = item.Value.Split('@')[0];
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        returnVoucher.Add(item.Value.Split('@')[1] + "供应商对客户没有维护对照关系");
                    }
                }
                #endregion
                session.Commit();
            }
            return returnVoucher;
        }
    }

    #endregion


}