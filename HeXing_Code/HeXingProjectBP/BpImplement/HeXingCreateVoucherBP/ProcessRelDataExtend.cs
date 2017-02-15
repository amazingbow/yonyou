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
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful='0'");//0 代表数据没有执行过，1代表成功导入U9，2代表导入U9失败
            if (glVoucherLst.Count == 0)
            {
                throw new Exception("没有需要做关系对照的数据！");
            }
            using (ISession session = Session.Open())
            {
                foreach (var item in glVoucherLst)
                {
                    HxRelationshipBE shipOrg = HxRelationshipBE.Finder.Find("RefType=7 and SapCode='" + item.CompanyCode + "' and SapName='" + item.CompanyName + "'");
                    if (shipOrg == null)
                    {
                        var relationship = HxRelationshipBE.Create();
                        relationship.RefType = RelationEnum.Org;
                        relationship.SapCode = item.CompanyCode;
                        relationship.SapName = item.CompanyName;
                        relationship.RefStatus = RefStatusEnum.Oraginal;
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
                    }
                    foreach (var line in item.HeXingSAPU9GLVoucherLine)
                    {
                        HxRelationshipBE shipAccount = HxRelationshipBE.Finder.Find("RefType=1 and SapCode='"
                            + line.AccountCode + "' and SapName='" + line.AccountDescription + "'");
                        if (shipAccount == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Account;
                            relationship.SapCode = line.AccountCode;
                            relationship.SapName = line.AccountDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                        }
                        HxRelationshipBE shipCashFlowCode = HxRelationshipBE.Finder.Find("RefType=1 and SapCode='"
                            + line.AccountCode + "' and SapName='" + line.AccountDescription + "'");
                        if (shipAccount == null)
                        {
                            var relationship = HxRelationshipBE.Create();
                            relationship.RefType = RelationEnum.Account;
                            relationship.SapCode = line.AccountCode;
                            relationship.SapName = line.AccountDescription;
                            relationship.RefStatus = RefStatusEnum.Oraginal;
                        }
                    }
                }
                session.Commit();
            }

            return null;
        }
    }

    #endregion


}