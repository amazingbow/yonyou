namespace UFIDA.U9.Cust.XMJL.SupplierSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.SCM.Supplier;


    /// <summary>
    /// QueryAllVerifiedSupply partial 
    /// </summary>	
    public partial class QueryAllVerifiedSupply
    {
        internal BaseStrategy Select()
        {
            return new QueryAllVerifiedSupplyImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class QueryAllVerifiedSupplyImpementStrategy : BaseStrategy
    {
        public QueryAllVerifiedSupplyImpementStrategy() { }

        public override object Do(object obj)
        {
            QueryAllVerifiedSupply bpObj = (QueryAllVerifiedSupply)obj;

            OqlParam[] oqlParameters = new OqlParam[]
            {
                new OqlParam(SupplierStateEnum.Verified.Value)
                {
                    ParamName = "state",
                    Value = SupplierStateEnum.Verified.Value,
                    Type = DbType.Int32,
                },
                new OqlParam(bpObj.SynDateTime)
                {
                    ParamName = "modifiedon",
                    Value = bpObj.SynDateTime,
                    Type = DbType.DateTime,
                },
                 new OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID)
            };

            //定义OQL
            //1. 状态为已核准 2. 最后更改时间大于同步时间
            string oql = string.Format(" state = @state and Org=@Org and modifiedon > @modifiedon");

            //获取供应商数据
            Supplier.EntityList supplierList = Supplier.Finder.FindAll(oql, oqlParameters);

            List<SupplierDTO> result = new List<SupplierDTO>();
            foreach (var supplier in supplierList)
            {
                SupplierDTO dto = new SupplierDTO();//初始化供应商DTO

                //给DTO各字段赋值
                dto.Code = supplier.Code;//供应商代码
                dto.Name = supplier.Name;//供应商名称
                dto.TaxNo = supplier.DistrictTaxNo;//税号

                //判断办公地址是否有值
                if (supplier.OfficialLocation != null)
                {
                    dto.Address = supplier.OfficialLocation.FormatAddress;//地址
                }

                //判断联系人是否存在
                if (supplier.SupplierContacts != null && supplier.SupplierContacts.Count > 0)
                {
                    dto.Contacts = supplier.SupplierContacts[0].Contact;//联系人
                }

                //判断银行信息是否存在
                if (supplier.SupplierBankAccount != null && supplier.SupplierBankAccount.Count > 0)
                {
                    //取第一个银行信息
                    var bankAccount = supplier.SupplierBankAccount[0];

                    dto.BankAccount = bankAccount.Code;//银行账号

                    if (bankAccount.Bank != null)
                    {
                        dto.BankLineNo = bankAccount.Bank.UnionBankCode;//联行号
                        dto.BankName = bankAccount.Bank.Name;//银行名称
                    }
                }
                dto.TaxNo = supplier.DistrictTaxNo;//地税号

                result.Add(dto);
            }

            return result;
        }
    }

    #endregion


}