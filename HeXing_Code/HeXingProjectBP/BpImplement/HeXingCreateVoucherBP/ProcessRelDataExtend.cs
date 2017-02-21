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
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful=0");//0 代表数据没有执行过，1代表成功导入U9，2代表导入U9失败
            if (glVoucherLst.Count == 0)
            {
                throw new Exception("没有需要做关系对照的数据！");
            }
            List<string> returnVoucher = new List<string>();
            using (ISession session = Session.Open())
            {
                foreach (var item in glVoucherLst)
                {
                    var notRefFlag = false;
                    HxRelationshipBE shipOrg = HxRelationshipBE.Finder.Find("RefType=7 and SapCode='" + item.CompanyCode + "' and SapName='" + item.CompanyName + "'");
                    if (shipOrg == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Org;
                        relationship.SapCode = item.CompanyCode;
                        relationship.SapName = item.CompanyName;
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        notRefFlag = true;
                    }
                    HxRelationshipBE shipCategory = HxRelationshipBE.Finder.Find("RefType=8 and SapCode='"
                        + item.VoucherCategoryCode + "' and SapName='" + item.VoucherCategoryDescription + "'");
                    if (shipCategory == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.VoucherCategory;
                        relationship.SapCode = item.VoucherCategoryCode;
                        relationship.SapName = item.VoucherCategoryDescription;
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        notRefFlag = true;
                    }
                    HxRelationshipBE shipCurrency = HxRelationshipBE.Finder.Find("RefType=1 and SapCode='"
                        + item.CurrencyCode + "' and SapName='" + item.CurrencyDescription + "'");
                    if (shipCurrency == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Currency;
                        relationship.SapCode = item.CurrencyCode;
                        relationship.SapName = item.CurrencyDescription;
                        relationship.RefStatus = RefStatusEnum.Oraginal;
                        notRefFlag = true;
                    }
                    foreach (var line in item.HeXingSAPU9GLVoucherLine)
                    {
                        HxRelationshipBE shipAccount = HxRelationshipBE.Finder.Find("RefType=10 and SapCode='"
                            + line.AccountCode + "' and SapName='" + line.AccountDescription + "'");
                        if (shipAccount == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Account;
                            relationship.SapCode = line.AccountCode;
                            relationship.SapName = line.AccountDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipCashFlowCode = HxRelationshipBE.Finder.Find("RefType=6 and SapCode='"
                            + line.CashFlowCode + "' and SapName='" + line.CashFlowDescription + "'");
                        if (shipCashFlowCode == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Cash;
                            relationship.SapCode = line.CashFlowCode;
                            relationship.SapName = line.CashFlowDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipFeeType = HxRelationshipBE.Finder.Find("RefType=11 and SapCode='"
                           + line.FeeTypeEnumCode + "' and SapName='" + line.FeeTypeEnumDescription + "'");
                        if (shipFeeType == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.FeeType;
                            relationship.SapCode = line.FeeTypeEnumCode;
                            relationship.SapName = line.FeeTypeEnumDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipCust = HxRelationshipBE.Finder.Find("RefType=2 and SapCode='"
                         + line.CustomerCode + "' and SapName='" + line.CustomerDescription + "'");
                        if (shipCust == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Customer;
                            relationship.SapCode = line.CustomerCode;
                            relationship.SapName = line.CustomerDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipSupplier = HxRelationshipBE.Finder.Find("RefType=3 and SapCode='"
                         + line.SupplierCode + "' and SapName='" + line.SupplierDescription + "'");
                        if (shipSupplier == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Supplier;
                            relationship.SapCode = line.SupplierCode;
                            relationship.SapName = line.SupplierDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipDepartment = HxRelationshipBE.Finder.Find("RefType=4 and SapCode='"
                        + line.DepartmentCode + "' and SapName='" + line.DepartmentName + "'");
                        if (shipDepartment == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Dept;
                            relationship.SapCode = line.DepartmentCode;
                            relationship.SapName = line.DepartmentName;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipMeterial = HxRelationshipBE.Finder.Find("RefType=12 and SapCode='"
                            + line.DepartmentCode + "' and SapName='" + line.DepartmentName + "'");
                        if (shipMeterial == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.MaterialGroup;
                            relationship.SapCode = line.MaterialGroupCode;
                            relationship.SapName = line.MaterialGroupDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                        HxRelationshipBE shipAsset = HxRelationshipBE.Finder.Find("RefType=13 and SapCode='"
                            + line.AssetsCode + "' and SapName='" + line.AssetsDescription + "'");
                        if (shipMeterial == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Asset;
                            relationship.SapCode = line.AssetsCode;
                            relationship.SapName = line.AssetsDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                            notRefFlag = true;
                        }
                    }
                    if (notRefFlag)
                    {
                        returnVoucher.Add(item.SAPVoucherDisplayCode);
                    }
                }
                session.Commit();
            }

            return returnVoucher;
        }
    }

    #endregion


}