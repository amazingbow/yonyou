


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV
{
	/// <summary>
	/// SAP与U9凭证对接中间表行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SAPU9GLVoucherLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SAPU9GLVoucherLineDTO(){
			initData();
		}
		private void initData()
		{
		
					SerialNo = 0; 
		
		
		
					AccountedDr = 0m; 
					AccountedCr = 0m; 
					EnteredDr = 0m; 
					EnteredCr = 0m; 
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// SAP与U9凭证对接中间表DTO (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.SAP与U9凭证对接中间表DTO
		/// </summary>
		/// <value>UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO</value>
		public UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO SAPU9GLVoucherDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO)base.GetValue("SAPU9GLVoucherDTO",typeof(UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO));
			}

			 set	
			{
				base.SetValue("SAPU9GLVoucherDTO",value);
			}
		}
				/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.行号
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SerialNo
		{
			get	
			{	
				return (System.Int64)base.GetValue("SerialNo",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SerialNo",value);
			}
		}
				/// <summary>
		/// 科目编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.科目编码
		/// </summary>
		/// <value>System.String</value>
		public System.String AccountCode
		{
			get	
			{	
				return (System.String)base.GetValue("AccountCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AccountCode",value);
			}
		}
				/// <summary>
		/// 科目描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.科目描述
		/// </summary>
		/// <value>System.String</value>
		public System.String AccountDescription
		{
			get	
			{	
				return (System.String)base.GetValue("AccountDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AccountDescription",value);
			}
		}
				/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.摘要
		/// </summary>
		/// <value>System.String</value>
		public System.String Abstracts
		{
			get	
			{	
				return (System.String)base.GetValue("Abstracts",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Abstracts",value);
			}
		}
				/// <summary>
		/// 借方金额（本币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.借方金额（本币）
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AccountedDr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AccountedDr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AccountedDr",value);
			}
		}
				/// <summary>
		/// 贷方金额（本币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.贷方金额（本币）
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AccountedCr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AccountedCr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AccountedCr",value);
			}
		}
				/// <summary>
		/// 借方金额（原币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.借方金额（原币）
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal EnteredDr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("EnteredDr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("EnteredDr",value);
			}
		}
				/// <summary>
		/// 贷方金额（原币） (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.贷方金额（原币）
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal EnteredCr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("EnteredCr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("EnteredCr",value);
			}
		}
				/// <summary>
		/// 现金流量项目编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.现金流量项目编码
		/// </summary>
		/// <value>System.String</value>
		public System.String CashFlowCode
		{
			get	
			{	
				return (System.String)base.GetValue("CashFlowCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CashFlowCode",value);
			}
		}
				/// <summary>
		/// 现金流量项目描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.现金流量项目描述
		/// </summary>
		/// <value>System.String</value>
		public System.String CashFlowDescription
		{
			get	
			{	
				return (System.String)base.GetValue("CashFlowDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CashFlowDescription",value);
			}
		}
				/// <summary>
		/// 费用类型编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.费用类型编码
		/// </summary>
		/// <value>System.String</value>
		public System.String FeeTypeEnumCode
		{
			get	
			{	
				return (System.String)base.GetValue("FeeTypeEnumCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FeeTypeEnumCode",value);
			}
		}
				/// <summary>
		/// 费用类型描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.费用类型描述
		/// </summary>
		/// <value>System.String</value>
		public System.String FeeTypeEnumDescription
		{
			get	
			{	
				return (System.String)base.GetValue("FeeTypeEnumDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FeeTypeEnumDescription",value);
			}
		}
				/// <summary>
		/// 开户行 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.开户行
		/// </summary>
		/// <value>System.String</value>
		public System.String Banks
		{
			get	
			{	
				return (System.String)base.GetValue("Banks",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Banks",value);
			}
		}
				/// <summary>
		/// 银行账号 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.银行账号
		/// </summary>
		/// <value>System.String</value>
		public System.String BankAccount
		{
			get	
			{	
				return (System.String)base.GetValue("BankAccount",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BankAccount",value);
			}
		}
				/// <summary>
		/// 客户编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.客户编码
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerCode
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerCode",value);
			}
		}
				/// <summary>
		/// 客户名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.客户名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerDescription
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerDescription",value);
			}
		}
				/// <summary>
		/// 供应商编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.供应商编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierCode
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierCode",value);
			}
		}
				/// <summary>
		/// 供应商名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.供应商名称
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierDescription
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierDescription",value);
			}
		}
				/// <summary>
		/// 部门编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.部门编码
		/// </summary>
		/// <value>System.String</value>
		public System.String DepartmentCode
		{
			get	
			{	
				return (System.String)base.GetValue("DepartmentCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DepartmentCode",value);
			}
		}
				/// <summary>
		/// 部门名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.部门名称
		/// </summary>
		/// <value>System.String</value>
		public System.String DepartmentName
		{
			get	
			{	
				return (System.String)base.GetValue("DepartmentName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DepartmentName",value);
			}
		}
				/// <summary>
		/// 员工编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.员工编码
		/// </summary>
		/// <value>System.String</value>
		public System.String EmployeeCode
		{
			get	
			{	
				return (System.String)base.GetValue("EmployeeCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("EmployeeCode",value);
			}
		}
				/// <summary>
		/// 员工名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.员工名称
		/// </summary>
		/// <value>System.String</value>
		public System.String EmployeeName
		{
			get	
			{	
				return (System.String)base.GetValue("EmployeeName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("EmployeeName",value);
			}
		}
				/// <summary>
		/// 物料组编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.物料组编码
		/// </summary>
		/// <value>System.String</value>
		public System.String MaterialGroupCode
		{
			get	
			{	
				return (System.String)base.GetValue("MaterialGroupCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("MaterialGroupCode",value);
			}
		}
				/// <summary>
		/// 物料组描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.物料组描述
		/// </summary>
		/// <value>System.String</value>
		public System.String MaterialGroupDescription
		{
			get	
			{	
				return (System.String)base.GetValue("MaterialGroupDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("MaterialGroupDescription",value);
			}
		}
				/// <summary>
		/// 资产编号 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.资产编号
		/// </summary>
		/// <value>System.String</value>
		public System.String AssetsCode
		{
			get	
			{	
				return (System.String)base.GetValue("AssetsCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AssetsCode",value);
			}
		}
				/// <summary>
		/// 资产描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表行DTO.Misc.资产描述
		/// </summary>
		/// <value>System.String</value>
		public System.String AssetsDescription
		{
			get	
			{	
				return (System.String)base.GetValue("AssetsDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AssetsDescription",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																											
		#endregion 

		#region ModelResource
		/// <summary>
		/// SAP与U9凭证对接中间表行DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// SAP与U9凭证对接中间表DTO的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SAPU9GLVoucherDTO　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SerialNo　{ get { return "";　}　}
		/// <summary>
		/// 科目编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountCode　{ get { return "";　}　}
		/// <summary>
		/// 科目描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountDescription　{ get { return "";　}　}
		/// <summary>
		/// 摘要的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Abstracts　{ get { return "";　}　}
		/// <summary>
		/// 借方金额（本币）的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountedDr　{ get { return "";　}　}
		/// <summary>
		/// 贷方金额（本币）的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountedCr　{ get { return "";　}　}
		/// <summary>
		/// 借方金额（原币）的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EnteredDr　{ get { return "";　}　}
		/// <summary>
		/// 贷方金额（原币）的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EnteredCr　{ get { return "";　}　}
		/// <summary>
		/// 现金流量项目编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CashFlowCode　{ get { return "";　}　}
		/// <summary>
		/// 现金流量项目描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CashFlowDescription　{ get { return "";　}　}
		/// <summary>
		/// 费用类型编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FeeTypeEnumCode　{ get { return "";　}　}
		/// <summary>
		/// 费用类型描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FeeTypeEnumDescription　{ get { return "";　}　}
		/// <summary>
		/// 开户行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Banks　{ get { return "";　}　}
		/// <summary>
		/// 银行账号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankAccount　{ get { return "";　}　}
		/// <summary>
		/// 客户编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerCode　{ get { return "";　}　}
		/// <summary>
		/// 客户名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerDescription　{ get { return "";　}　}
		/// <summary>
		/// 供应商编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierDescription　{ get { return "";　}　}
		/// <summary>
		/// 部门编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DepartmentCode　{ get { return "";　}　}
		/// <summary>
		/// 部门名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DepartmentName　{ get { return "";　}　}
		/// <summary>
		/// 员工编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EmployeeCode　{ get { return "";　}　}
		/// <summary>
		/// 员工名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EmployeeName　{ get { return "";　}　}
		/// <summary>
		/// 物料组编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MaterialGroupCode　{ get { return "";　}　}
		/// <summary>
		/// 物料组描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MaterialGroupDescription　{ get { return "";　}　}
		/// <summary>
		/// 资产编号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AssetsCode　{ get { return "";　}　}
		/// <summary>
		/// 资产描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AssetsDescription　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SAPU9GLVoucherLineDTOData data)
		{
		



























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SAPU9GLVoucherLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SAPU9GLVoucherLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			if (data.SAPU9GLVoucherDTO!=null)
			{
				UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO temp = dict[data.SAPU9GLVoucherDTO] as UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTO();
					temp.FromEntityData(data.SAPU9GLVoucherDTO,dict);
				}
				this.SAPU9GLVoucherDTO = temp ;
			}
		

			this.SerialNo = data.SerialNo;

			this.AccountCode = data.AccountCode;

			this.AccountDescription = data.AccountDescription;

			this.Abstracts = data.Abstracts;

			this.AccountedDr = data.AccountedDr;

			this.AccountedCr = data.AccountedCr;

			this.EnteredDr = data.EnteredDr;

			this.EnteredCr = data.EnteredCr;

			this.CashFlowCode = data.CashFlowCode;

			this.CashFlowDescription = data.CashFlowDescription;

			this.FeeTypeEnumCode = data.FeeTypeEnumCode;

			this.FeeTypeEnumDescription = data.FeeTypeEnumDescription;

			this.Banks = data.Banks;

			this.BankAccount = data.BankAccount;

			this.CustomerCode = data.CustomerCode;

			this.CustomerDescription = data.CustomerDescription;

			this.SupplierCode = data.SupplierCode;

			this.SupplierDescription = data.SupplierDescription;

			this.DepartmentCode = data.DepartmentCode;

			this.DepartmentName = data.DepartmentName;

			this.EmployeeCode = data.EmployeeCode;

			this.EmployeeName = data.EmployeeName;

			this.MaterialGroupCode = data.MaterialGroupCode;

			this.MaterialGroupDescription = data.MaterialGroupDescription;

			this.AssetsCode = data.AssetsCode;

			this.AssetsDescription = data.AssetsDescription;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SAPU9GLVoucherLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SAPU9GLVoucherLineDTOData ToEntityData(SAPU9GLVoucherLineDTOData data, IDictionary dict){
			if (data == null)
				data = new SAPU9GLVoucherLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SAPU9GLVoucherLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SAPU9GLVoucherDTO!=null)
			{
				data.SAPU9GLVoucherDTO=this.SAPU9GLVoucherDTO.ToEntityData(null,dict);
			}
		

			data.SerialNo = this.SerialNo;

			data.AccountCode = this.AccountCode;

			data.AccountDescription = this.AccountDescription;

			data.Abstracts = this.Abstracts;

			data.AccountedDr = this.AccountedDr;

			data.AccountedCr = this.AccountedCr;

			data.EnteredDr = this.EnteredDr;

			data.EnteredCr = this.EnteredCr;

			data.CashFlowCode = this.CashFlowCode;

			data.CashFlowDescription = this.CashFlowDescription;

			data.FeeTypeEnumCode = this.FeeTypeEnumCode;

			data.FeeTypeEnumDescription = this.FeeTypeEnumDescription;

			data.Banks = this.Banks;

			data.BankAccount = this.BankAccount;

			data.CustomerCode = this.CustomerCode;

			data.CustomerDescription = this.CustomerDescription;

			data.SupplierCode = this.SupplierCode;

			data.SupplierDescription = this.SupplierDescription;

			data.DepartmentCode = this.DepartmentCode;

			data.DepartmentName = this.DepartmentName;

			data.EmployeeCode = this.EmployeeCode;

			data.EmployeeName = this.EmployeeName;

			data.MaterialGroupCode = this.MaterialGroupCode;

			data.MaterialGroupDescription = this.MaterialGroupDescription;

			data.AssetsCode = this.AssetsCode;

			data.AssetsDescription = this.AssetsDescription;

			return data ;
		}

		#endregion	
	}	
	
}