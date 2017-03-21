namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base.Currency;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// HeXingRelatiomShipBP partial 
    /// </summary>	
    public partial class HeXingRelatiomShipBP
    {
        internal BaseStrategy Select()
        {
            return new HeXingRelatiomShipBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class HeXingRelatiomShipBPImpementStrategy : BaseStrategy
    {
        public HeXingRelatiomShipBPImpementStrategy() { }

        public override object Do(object obj)
        {
            HeXingRelatiomShipBP bpObj = (HeXingRelatiomShipBP)obj;

            List<RelatiomShipBPDto> RelatiomList = new List<RelatiomShipBPDto>();
            switch (bpObj.HColumn)
            {
                case "编码":
                    switch (bpObj.HRefType)
                    {
                        case "币种":
                            UFIDA.U9.Base.Currency.Currency.EntityList CurrencyList = UFIDA.U9.Base.Currency.Currency.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (CurrencyList.Count > 0)
                            {
                                foreach (var Currency in CurrencyList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Currency.ID;
                                    Relatiom.FCode = Currency.Code;
                                    Relatiom.FName = Currency.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "客户":
                            UFIDA.U9.CBO.SCM.Customer.Customer.EntityList CustomerList = UFIDA.U9.CBO.SCM.Customer.Customer.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (CustomerList.Count > 0)
                            {
                                foreach (var Customer in CustomerList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Customer.ID;
                                    Relatiom.FCode = Customer.Code;
                                    Relatiom.FName = Customer.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "供应商":
                            UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityList SupplierList = UFIDA.U9.CBO.SCM.Supplier.Supplier.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (SupplierList.Count > 0)
                            {
                                foreach (var Supplier in SupplierList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Supplier.ID;
                                    Relatiom.FCode = Supplier.Code;
                                    Relatiom.FName = Supplier.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "部门":
                            UFIDA.U9.CBO.HR.Department.Department.EntityList DepartmentList = UFIDA.U9.CBO.HR.Department.Department.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (DepartmentList.Count > 0)
                            {
                                foreach (var Department in DepartmentList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Department.ID;
                                    Relatiom.FCode = Department.Code;
                                    Relatiom.FName = Department.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "员工":
                            UFIDA.U9.CBO.HR.Operator.Operators.EntityList OperatorList = UFIDA.U9.CBO.HR.Operator.Operators.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (OperatorList.Count > 0)
                            {
                                foreach (var Operator in OperatorList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Operator.ID;
                                    Relatiom.FCode = Operator.Code;
                                    Relatiom.FName = Operator.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "现金流":
                            UFIDA.U9.CBO.FI.CashFlow.CashFlowItem.EntityList CashFlowItemList = UFIDA.U9.CBO.FI.CashFlow.CashFlowItem.Finder.FindAll("Code like @Code and IsSystemPre=0", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (CashFlowItemList.Count > 0)
                            {
                                foreach (var CashFlowItem in CashFlowItemList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = CashFlowItem.ID;
                                    Relatiom.FCode = CashFlowItem.Code;
                                    Relatiom.FName = CashFlowItem.UseName;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "组织":
                            UFIDA.U9.Base.Organization.Organization.EntityList OrganizationList = UFIDA.U9.Base.Organization.Organization.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (OrganizationList.Count > 0)
                            {
                                foreach (var Organization in OrganizationList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Organization.ID;
                                    Relatiom.FCode = Organization.Code;
                                    Relatiom.FName = Organization.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "凭证类型":
                            UFIDA.U9.CBO.FI.VoucherCategory.VoucherCategory.EntityList VoucherCategoryList = UFIDA.U9.CBO.FI.VoucherCategory.VoucherCategory.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (VoucherCategoryList.Count > 0)
                            {
                                foreach (var VoucherCategory in VoucherCategoryList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = VoucherCategory.ID;
                                    Relatiom.FCode = VoucherCategory.Code;
                                    Relatiom.FName = VoucherCategory.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "项目":
                            UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityList ProjectList = UFIDA.U9.Base.FlexField.ValueSet.DefineValue.Finder.FindAll("Code like @Code and Effective.IsEffective=1 and ValueSetDef.Code='2012'", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (ProjectList.Count > 0)
                            {
                                foreach (var Project in ProjectList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Project.ID;
                                    Relatiom.FCode = Project.Code;
                                    Relatiom.FName = Project.TreeDisplayName;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "科目":
                            UFIDA.U9.CBO.FI.NaturalAccount.NaturalAccount.EntityList AccountList = UFIDA.U9.CBO.FI.NaturalAccount.NaturalAccount.Finder.FindAll("Code like @Code and IsSystem=0 and IsLeaf=1", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (AccountList.Count > 0)
                            {
                                foreach (var Account in AccountList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Account.ID;
                                    Relatiom.FCode = Account.Code;
                                    Relatiom.FName = Account.Name;
                                    Relatiom.AccountProperty = Account.AccountProperty.Name;
                                    string strBalanceDirection = "";
                                    if (Account.BalanceDirection.Value == 0)
                                    {
                                        strBalanceDirection = "借方余额";
                                    }
                                    else if (Account.BalanceDirection.Value == 1)
                                    {
                                        strBalanceDirection = "贷方余额";
                                    }
                                    else if (Account.BalanceDirection.Value == 2)
                                    {
                                        strBalanceDirection = "双向";
                                    }
                                    Relatiom.BalanceDirection = strBalanceDirection;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "费用类型":
                            UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityList ExpenseItemList = UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (ExpenseItemList.Count > 0)
                            {
                                foreach (var ExpenseItem in ExpenseItemList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = ExpenseItem.ID;
                                    Relatiom.FCode = ExpenseItem.Code;
                                    Relatiom.FName = ExpenseItem.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "银行":
                            UFIDA.U9.CBO.FI.BankAccount.Bank.EntityList BankList = UFIDA.U9.CBO.FI.BankAccount.Bank.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (BankList.Count > 0)
                            {
                                foreach (var Bank in BankList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Bank.ID;
                                    Relatiom.FCode = Bank.Code;
                                    Relatiom.FName = Bank.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                    }
                    break;
                case "名称":
                    switch (bpObj.HRefType)
                    {
                        case "币种":
                            UFIDA.U9.Base.Currency.Currency.EntityList CurrencyList = UFIDA.U9.Base.Currency.Currency.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (CurrencyList.Count > 0)
                            {
                                foreach (var Currency in CurrencyList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Currency.ID;
                                    Relatiom.FCode = Currency.Code;
                                    Relatiom.FName = Currency.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "客户":
                            UFIDA.U9.CBO.SCM.Customer.Customer.EntityList CustomerList = UFIDA.U9.CBO.SCM.Customer.Customer.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (CustomerList.Count > 0)
                            {
                                foreach (var Customer in CustomerList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Customer.ID;
                                    Relatiom.FCode = Customer.Code;
                                    Relatiom.FName = Customer.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "供应商":
                            UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityList SupplierList = UFIDA.U9.CBO.SCM.Supplier.Supplier.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (SupplierList.Count > 0)
                            {
                                foreach (var Supplier in SupplierList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Supplier.ID;
                                    Relatiom.FCode = Supplier.Code;
                                    Relatiom.FName = Supplier.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "部门":
                            UFIDA.U9.CBO.HR.Department.Department.EntityList DepartmentList = UFIDA.U9.CBO.HR.Department.Department.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (DepartmentList.Count > 0)
                            {
                                foreach (var Department in DepartmentList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Department.ID;
                                    Relatiom.FCode = Department.Code;
                                    Relatiom.FName = Department.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "员工":
                            UFIDA.U9.CBO.HR.Operator.Operators.EntityList OperatorList = UFIDA.U9.CBO.HR.Operator.Operators.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (OperatorList.Count > 0)
                            {
                                foreach (var Operator in OperatorList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Operator.ID;
                                    Relatiom.FCode = Operator.Code;
                                    Relatiom.FName = Operator.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "现金流":
                            UFIDA.U9.CBO.FI.CashFlow.CashFlowItem.EntityList CashFlowItemList = UFIDA.U9.CBO.FI.CashFlow.CashFlowItem.Finder.FindAll("UseName like @Name and IsSystemPre=0", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (CashFlowItemList.Count > 0)
                            {
                                foreach (var CashFlowItem in CashFlowItemList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = CashFlowItem.ID;
                                    Relatiom.FCode = CashFlowItem.Code;
                                    Relatiom.FName = CashFlowItem.UseName;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "组织":
                            UFIDA.U9.Base.Organization.Organization.EntityList OrganizationList = UFIDA.U9.Base.Organization.Organization.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (OrganizationList.Count > 0)
                            {
                                foreach (var Organization in OrganizationList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Organization.ID;
                                    Relatiom.FCode = Organization.Code;
                                    Relatiom.FName = Organization.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "凭证类型":
                            UFIDA.U9.CBO.FI.VoucherCategory.VoucherCategory.EntityList VoucherCategoryList = UFIDA.U9.CBO.FI.VoucherCategory.VoucherCategory.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (VoucherCategoryList.Count > 0)
                            {
                                foreach (var VoucherCategory in VoucherCategoryList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = VoucherCategory.ID;
                                    Relatiom.FCode = VoucherCategory.Code;
                                    Relatiom.FName = VoucherCategory.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "项目":
                            UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityList ProjectList = UFIDA.U9.Base.FlexField.ValueSet.DefineValue.Finder.FindAll("TreeDisplayName like @Name and Effective.IsEffective=1 and ValueSetDef.Code='2012'", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (ProjectList.Count > 0)
                            {
                                foreach (var Project in ProjectList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Project.ID;
                                    Relatiom.FCode = Project.Code;
                                    Relatiom.FName = Project.TreeDisplayName;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "科目":
                            UFIDA.U9.CBO.FI.NaturalAccount.NaturalAccount.EntityList AccountList = UFIDA.U9.CBO.FI.NaturalAccount.NaturalAccount.Finder.FindAll("Name like @Name and IsSystem=0 and IsLeaf=1", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (AccountList.Count > 0)
                            {
                                foreach (var Account in AccountList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Account.ID;
                                    Relatiom.FCode = Account.Code;
                                    Relatiom.FName = Account.Name;
                                    Relatiom.AccountProperty = Account.AccountProperty.Name;
                                    string strBalanceDirection = "";
                                    if (Account.BalanceDirection.Value == 0)
                                    {
                                        strBalanceDirection = "借方余额";
                                    }
                                    else if (Account.BalanceDirection.Value == 1)
                                    {
                                        strBalanceDirection = "贷方余额";
                                    }
                                    else if (Account.BalanceDirection.Value == 2)
                                    {
                                        strBalanceDirection = "双向";
                                    }
                                    Relatiom.BalanceDirection = strBalanceDirection;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "费用类型":
                            UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityList ExpenseItemList = UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (ExpenseItemList.Count > 0)
                            {
                                foreach (var ExpenseItem in ExpenseItemList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = ExpenseItem.ID;
                                    Relatiom.FCode = ExpenseItem.Code;
                                    Relatiom.FName = ExpenseItem.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "银行":
                            UFIDA.U9.CBO.FI.BankAccount.Bank.EntityList BankList = UFIDA.U9.CBO.FI.BankAccount.Bank.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%") });
                            if (BankList.Count > 0)
                            {
                                foreach (var Bank in BankList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FID = Bank.ID;
                                    Relatiom.FCode = Bank.Code;
                                    Relatiom.FName = Bank.Name;
                                    Relatiom.AccountProperty = "";
                                    Relatiom.BalanceDirection = "";
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                    }
                    break;
            }


            return RelatiomList;
        }
    }

    #endregion


}