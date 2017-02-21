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
                                    Relatiom.FCode = Currency.Code;
                                    Relatiom.FName = Currency.Name;
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
                                    Relatiom.FCode = Customer.Code;
                                    Relatiom.FName = Customer.Name;
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
                                    Relatiom.FCode = Supplier.Code;
                                    Relatiom.FName = Supplier.Name;
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
                                    Relatiom.FCode = Department.Code;
                                    Relatiom.FName = Department.Name;
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
                                    Relatiom.FCode = Operator.Code;
                                    Relatiom.FName = Operator.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "现金流":
                            UFIDA.U9.CBO.FI.CashFlow.CashFlowItemMain.EntityList CashFlowItemMainList = UFIDA.U9.CBO.FI.CashFlow.CashFlowItemMain.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%")});
                            if (CashFlowItemMainList.Count > 0)
                            {
                                foreach (var CashFlowItemMain in CashFlowItemMainList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = CashFlowItemMain.Code;
                                    Relatiom.FName = CashFlowItemMain.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "组织":
                            UFIDA.U9.Base.Organization.Organization.EntityList OrganizationList = UFIDA.U9.Base.Organization.Organization.Finder.FindAll("Code like @Code", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%")});
                            if (OrganizationList.Count > 0)
                            {
                                foreach (var Organization in OrganizationList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Organization.Code;
                                    Relatiom.FName = Organization.Name;
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
                                    Relatiom.FCode = VoucherCategory.Code;
                                    Relatiom.FName = VoucherCategory.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "项目":
                            UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityList ProjectList = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (ProjectList.Count > 0)
                            {
                                foreach (var Project in ProjectList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Project.Code;
                                    Relatiom.FName = Project.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                            case "科目":
                            UFIDA.U9.CBO.FI.Account.Account.EntityList AccountList = UFIDA.U9.CBO.FI.Account.Account.Finder.FindAll("Code like @Code and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (AccountList.Count > 0)
                            {
                                foreach (var Account in AccountList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Account.Code;
                                    Relatiom.FName = Account.Name;
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
                                    Relatiom.FCode = Currency.Code;
                                    Relatiom.FName = Currency.Name;
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
                                    Relatiom.FCode = Customer.Code;
                                    Relatiom.FName = Customer.Name;
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
                                    Relatiom.FCode = Supplier.Code;
                                    Relatiom.FName = Supplier.Name;
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
                                    Relatiom.FCode = Department.Code;
                                    Relatiom.FName = Department.Name;
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
                                    Relatiom.FCode = Operator.Code;
                                    Relatiom.FName = Operator.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "现金流":
                            UFIDA.U9.CBO.FI.CashFlow.CashFlowItemMain.EntityList CashFlowItemMainList = UFIDA.U9.CBO.FI.CashFlow.CashFlowItemMain.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%")});
                            if (CashFlowItemMainList.Count > 0)
                            {
                                foreach (var CashFlowItemMain in CashFlowItemMainList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = CashFlowItemMain.Code;
                                    Relatiom.FName = CashFlowItemMain.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "组织":
                            UFIDA.U9.Base.Organization.Organization.EntityList OrganizationList = UFIDA.U9.Base.Organization.Organization.Finder.FindAll("Name like @Name", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%")});
                            if (OrganizationList.Count > 0)
                            {
                                foreach (var Organization in OrganizationList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Organization.Code;
                                    Relatiom.FName = Organization.Name;
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
                                    Relatiom.FCode = VoucherCategory.Code;
                                    Relatiom.FName = VoucherCategory.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                        case "项目":
                            UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityList ProjectList = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (ProjectList.Count > 0)
                            {
                                foreach (var Project in ProjectList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Project.Code;
                                    Relatiom.FName = Project.Name;
                                    RelatiomList.Add(Relatiom);
                                }
                            }
                            break;
                            case "科目":
                            UFIDA.U9.CBO.FI.Account.Account.EntityList AccountList = UFIDA.U9.CBO.FI.Account.Account.Finder.FindAll("Name like @Name and Org=@Org", new OqlParam[] { new OqlParam("%" + bpObj.HStr + "%"), new OqlParam(bpObj.HOrg) });
                            if (AccountList.Count > 0)
                            {
                                foreach (var Account in AccountList)
                                {
                                    RelatiomShipBPDto Relatiom = new RelatiomShipBPDto();
                                    Relatiom.FCode = Account.Code;
                                    Relatiom.FName = Account.Name;
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