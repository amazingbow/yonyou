



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
	/// <summary>
	/// SAP与U9凭证对接中间表行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SAPU9GLVoucherLineDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
            knownTypes.Add(typeof(UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData));                                                                                                                                                                                                                                                                                                                                                                             
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SAPU9GLVoucherLineDTOData()
		{
			initData();
		}
		private void initData()
		{
		
					SerialNo= 0; 
				
		
		
					AccountedDr=0m; 
					AccountedCr=0m; 
					EnteredDr=0m; 
					EnteredCr=0m; 
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		

			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
		#region Do SerializeKey -ForDTODataType
		//只为处理集合型EntityKey。原因集合型EntityKey由于使用臫的集合对象，无法实现数据共享.-UBF专用.
		public void DoSerializeKeyList(IDictionary dict)
		{
			if (dict == null ) dict = new Hashtable() ;
			if (dict[this] != null)
				return ;
			dict[this] = this;
	        			if (this.SAPU9GLVoucherDTO != null) 
			{
				this.SAPU9GLVoucherDTO.DoSerializeKeyList(dict);
			}
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public SAPU9GLVoucherLineDTOData(  UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData sAPU9GLVoucherDTO  , System.Int32 serialNo  , System.String accountCode  , System.String accountDescription  , System.String abstracts  , System.Decimal accountedDr  , System.Decimal accountedCr  , System.Decimal enteredDr  , System.Decimal enteredCr  , System.String cashFlowCode  , System.String cashFlowDescription  , System.String feeTypeEnumCode  , System.String feeTypeEnumDescription  , System.String banks  , System.String bankAccount  , System.String customerCode  , System.String customerDescription  , System.String supplierCode  , System.String supplierDescription  , System.String departmentCode  , System.String departmentName  , System.String employeeCode  , System.String employeeName  , System.String materialGroupCode  , System.String materialGroupDescription  , System.String assetsCode  , System.String assetsDescription  , System.String relCompCode  , System.String relCompName  )
		{
			initData();
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
			this.RelCompCode = relCompCode;
			this.RelCompName = relCompName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// SAP与U9凭证对接中间表DTO
		/// SAP与U9凭证对接中间表行DTO.Misc.SAP与U9凭证对接中间表DTO
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData m_sAPU9GLVoucherDTO ;
		public UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData SAPU9GLVoucherDTO
		{
			get	
			{	
				return m_sAPU9GLVoucherDTO ;
			}
			set	
			{	
				m_sAPU9GLVoucherDTO = value ;	
			}
		}
			
		

		/// <summary>
		/// 行号
		/// SAP与U9凭证对接中间表行DTO.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_serialNo ;
		public System.Int32 SerialNo
		{
			get	
			{	
				return m_serialNo ;
			}
			set	
			{	
				m_serialNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 科目编码
		/// SAP与U9凭证对接中间表行DTO.Misc.科目编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_accountCode ;
		public System.String AccountCode
		{
			get	
			{	
				return m_accountCode ;
			}
			set	
			{	
				m_accountCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 科目描述
		/// SAP与U9凭证对接中间表行DTO.Misc.科目描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_accountDescription ;
		public System.String AccountDescription
		{
			get	
			{	
				return m_accountDescription ;
			}
			set	
			{	
				m_accountDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 摘要
		/// SAP与U9凭证对接中间表行DTO.Misc.摘要
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_abstracts ;
		public System.String Abstracts
		{
			get	
			{	
				return m_abstracts ;
			}
			set	
			{	
				m_abstracts = value ;	
			}
		}
			
		

		/// <summary>
		/// 借方金额（本币）
		/// SAP与U9凭证对接中间表行DTO.Misc.借方金额（本币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedDr ;
		public System.Decimal AccountedDr
		{
			get	
			{	
				return m_accountedDr ;
			}
			set	
			{	
				m_accountedDr = value ;	
			}
		}
			
		

		/// <summary>
		/// 贷方金额（本币）
		/// SAP与U9凭证对接中间表行DTO.Misc.贷方金额（本币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedCr ;
		public System.Decimal AccountedCr
		{
			get	
			{	
				return m_accountedCr ;
			}
			set	
			{	
				m_accountedCr = value ;	
			}
		}
			
		

		/// <summary>
		/// 借方金额（原币）
		/// SAP与U9凭证对接中间表行DTO.Misc.借方金额（原币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_enteredDr ;
		public System.Decimal EnteredDr
		{
			get	
			{	
				return m_enteredDr ;
			}
			set	
			{	
				m_enteredDr = value ;	
			}
		}
			
		

		/// <summary>
		/// 贷方金额（原币）
		/// SAP与U9凭证对接中间表行DTO.Misc.贷方金额（原币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_enteredCr ;
		public System.Decimal EnteredCr
		{
			get	
			{	
				return m_enteredCr ;
			}
			set	
			{	
				m_enteredCr = value ;	
			}
		}
			
		

		/// <summary>
		/// 现金流量项目编码
		/// SAP与U9凭证对接中间表行DTO.Misc.现金流量项目编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cashFlowCode ;
		public System.String CashFlowCode
		{
			get	
			{	
				return m_cashFlowCode ;
			}
			set	
			{	
				m_cashFlowCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 现金流量项目描述
		/// SAP与U9凭证对接中间表行DTO.Misc.现金流量项目描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cashFlowDescription ;
		public System.String CashFlowDescription
		{
			get	
			{	
				return m_cashFlowDescription ;
			}
			set	
			{	
				m_cashFlowDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 费用类型编码
		/// SAP与U9凭证对接中间表行DTO.Misc.费用类型编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_feeTypeEnumCode ;
		public System.String FeeTypeEnumCode
		{
			get	
			{	
				return m_feeTypeEnumCode ;
			}
			set	
			{	
				m_feeTypeEnumCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 费用类型描述
		/// SAP与U9凭证对接中间表行DTO.Misc.费用类型描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_feeTypeEnumDescription ;
		public System.String FeeTypeEnumDescription
		{
			get	
			{	
				return m_feeTypeEnumDescription ;
			}
			set	
			{	
				m_feeTypeEnumDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 开户行
		/// SAP与U9凭证对接中间表行DTO.Misc.开户行
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_banks ;
		public System.String Banks
		{
			get	
			{	
				return m_banks ;
			}
			set	
			{	
				m_banks = value ;	
			}
		}
			
		

		/// <summary>
		/// 银行账号
		/// SAP与U9凭证对接中间表行DTO.Misc.银行账号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bankAccount ;
		public System.String BankAccount
		{
			get	
			{	
				return m_bankAccount ;
			}
			set	
			{	
				m_bankAccount = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户编码
		/// SAP与U9凭证对接中间表行DTO.Misc.客户编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerCode ;
		public System.String CustomerCode
		{
			get	
			{	
				return m_customerCode ;
			}
			set	
			{	
				m_customerCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户名称
		/// SAP与U9凭证对接中间表行DTO.Misc.客户名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerDescription ;
		public System.String CustomerDescription
		{
			get	
			{	
				return m_customerDescription ;
			}
			set	
			{	
				m_customerDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商编码
		/// SAP与U9凭证对接中间表行DTO.Misc.供应商编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierCode ;
		public System.String SupplierCode
		{
			get	
			{	
				return m_supplierCode ;
			}
			set	
			{	
				m_supplierCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商名称
		/// SAP与U9凭证对接中间表行DTO.Misc.供应商名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierDescription ;
		public System.String SupplierDescription
		{
			get	
			{	
				return m_supplierDescription ;
			}
			set	
			{	
				m_supplierDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 部门编码
		/// SAP与U9凭证对接中间表行DTO.Misc.部门编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_departmentCode ;
		public System.String DepartmentCode
		{
			get	
			{	
				return m_departmentCode ;
			}
			set	
			{	
				m_departmentCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 部门名称
		/// SAP与U9凭证对接中间表行DTO.Misc.部门名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_departmentName ;
		public System.String DepartmentName
		{
			get	
			{	
				return m_departmentName ;
			}
			set	
			{	
				m_departmentName = value ;	
			}
		}
			
		

		/// <summary>
		/// 员工编码
		/// SAP与U9凭证对接中间表行DTO.Misc.员工编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_employeeCode ;
		public System.String EmployeeCode
		{
			get	
			{	
				return m_employeeCode ;
			}
			set	
			{	
				m_employeeCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 员工名称
		/// SAP与U9凭证对接中间表行DTO.Misc.员工名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_employeeName ;
		public System.String EmployeeName
		{
			get	
			{	
				return m_employeeName ;
			}
			set	
			{	
				m_employeeName = value ;	
			}
		}
			
		

		/// <summary>
		/// 物料组编码
		/// SAP与U9凭证对接中间表行DTO.Misc.物料组编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_materialGroupCode ;
		public System.String MaterialGroupCode
		{
			get	
			{	
				return m_materialGroupCode ;
			}
			set	
			{	
				m_materialGroupCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 物料组描述
		/// SAP与U9凭证对接中间表行DTO.Misc.物料组描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_materialGroupDescription ;
		public System.String MaterialGroupDescription
		{
			get	
			{	
				return m_materialGroupDescription ;
			}
			set	
			{	
				m_materialGroupDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 资产编号
		/// SAP与U9凭证对接中间表行DTO.Misc.资产编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_assetsCode ;
		public System.String AssetsCode
		{
			get	
			{	
				return m_assetsCode ;
			}
			set	
			{	
				m_assetsCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 资产描述
		/// SAP与U9凭证对接中间表行DTO.Misc.资产描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_assetsDescription ;
		public System.String AssetsDescription
		{
			get	
			{	
				return m_assetsDescription ;
			}
			set	
			{	
				m_assetsDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 关系企业代码
		/// SAP与U9凭证对接中间表行DTO.Misc.关系企业代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relCompCode ;
		public System.String RelCompCode
		{
			get	
			{	
				return m_relCompCode ;
			}
			set	
			{	
				m_relCompCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 关系企业名称
		/// SAP与U9凭证对接中间表行DTO.Misc.关系企业名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relCompName ;
		public System.String RelCompName
		{
			get	
			{	
				return m_relCompName ;
			}
			set	
			{	
				m_relCompName = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																																										
		#endregion 
	} 	
}

	
