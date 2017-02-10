



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV {

	public partial class SAPU9GLVoucherLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SAPU9GLVoucherLineDTO(  UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO sAPU9GLVoucherDTO  , System.Int64 serialNo  , System.String accountCode  , System.String accountDescription  , System.String abstracts  , System.Decimal accountedDr  , System.Decimal accountedCr  , System.Decimal enteredDr  , System.Decimal enteredCr  , System.String cashFlowCode  , System.String cashFlowDescription  , System.String feeTypeEnumCode  , System.String feeTypeEnumDescription  , System.String banks  , System.String bankAccount  , System.String customerCode  , System.String customerDescription  , System.String supplierCode  , System.String supplierDescription  , System.String departmentCode  , System.String departmentName  , System.String employeeCode  , System.String employeeName  , System.String materialGroupCode  , System.String materialGroupDescription  , System.String assetsCode  , System.String assetsDescription  )
		{
			this.SAPU9GLVoucherDTO = sAPU9GLVoucherDTO;
			this.SerialNo = serialNo;
			this.AccountCode = accountCode;
			this.AccountDescription = accountDescription;
			this.Abstracts = abstracts;
			this.AccountedDr = accountedDr;
			this.AccountedCr = accountedCr;
			this.EnteredDr = enteredDr;
			this.EnteredCr = enteredCr;
			this.CashFlowCode = cashFlowCode;
			this.CashFlowDescription = cashFlowDescription;
			this.FeeTypeEnumCode = feeTypeEnumCode;
			this.FeeTypeEnumDescription = feeTypeEnumDescription;
			this.Banks = banks;
			this.BankAccount = bankAccount;
			this.CustomerCode = customerCode;
			this.CustomerDescription = customerDescription;
			this.SupplierCode = supplierCode;
			this.SupplierDescription = supplierDescription;
			this.DepartmentCode = departmentCode;
			this.DepartmentName = departmentName;
			this.EmployeeCode = employeeCode;
			this.EmployeeName = employeeName;
			this.MaterialGroupCode = materialGroupCode;
			this.MaterialGroupDescription = materialGroupDescription;
			this.AssetsCode = assetsCode;
			this.AssetsDescription = assetsDescription;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
