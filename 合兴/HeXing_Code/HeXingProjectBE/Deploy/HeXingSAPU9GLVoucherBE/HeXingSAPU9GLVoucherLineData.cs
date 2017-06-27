
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE
{
	/// <summary>
	/// SAP与U9凭证对接中间表行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class HeXingSAPU9GLVoucherLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public HeXingSAPU9GLVoucherLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     							SerialNo= 0; 			     			
	     			
	     			
	     							AccountedDr=0m; 
	     							AccountedCr=0m; 
	     							EnteredDr=0m; 
	     							EnteredCr=0m; 
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_heXingSAPU9GLVoucherHead_SKey ;
			/// <summary>
			/// SAP与U9凭证对接中间表头 序列化Key属性。（传递跨组织序列列字段）
			/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey HeXingSAPU9GLVoucherHead_SKey
			{
				get 
				{
					return m_heXingSAPU9GLVoucherHead_SKey ;					
				}
				set
				{
					m_heXingSAPU9GLVoucherHead_SKey = value ;	
				}
			}
		/// <summary>
		/// SAP与U9凭证对接中间表头
		/// SAP与U9凭证对接中间表行.Misc.SAP与U9凭证对接中间表头
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData m_heXingSAPU9GLVoucherHead;
		public UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData HeXingSAPU9GLVoucherHead
		{
			get	
			{	
				return m_heXingSAPU9GLVoucherHead ;
			}
			set	
			{	
				m_heXingSAPU9GLVoucherHead = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// SAP与U9凭证对接中间表行.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// SAP与U9凭证对接中间表行.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// SAP与U9凭证对接中间表行.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// SAP与U9凭证对接中间表行.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// SAP与U9凭证对接中间表行.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// SAP与U9凭证对接中间表行.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 行号
		/// SAP与U9凭证对接中间表行.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_serialNo ;
		public System.Int32 SerialNo
		{
			get	
			{	
				return m_serialNo  ;
			}
			set	
			{	
				m_serialNo = value ;	
			}
		}
		

				/// <summary>
		/// 科目编码
		/// SAP与U9凭证对接中间表行.Misc.科目编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_accountCode ;
		public System.String AccountCode
		{
			get	
			{	
				return m_accountCode  ;
			}
			set	
			{	
				m_accountCode = value ;	
			}
		}
		

				/// <summary>
		/// 科目描述
		/// SAP与U9凭证对接中间表行.Misc.科目描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_accountDescription ;
		public System.String AccountDescription
		{
			get	
			{	
				return m_accountDescription  ;
			}
			set	
			{	
				m_accountDescription = value ;	
			}
		}
		

				/// <summary>
		/// 摘要
		/// SAP与U9凭证对接中间表行.Misc.摘要
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_abstracts ;
		public System.String Abstracts
		{
			get	
			{	
				return m_abstracts  ;
			}
			set	
			{	
				m_abstracts = value ;	
			}
		}
		

				/// <summary>
		/// 借方金额（本币）
		/// SAP与U9凭证对接中间表行.Misc.借方金额（本币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedDr ;
		public System.Decimal AccountedDr
		{
			get	
			{	
				return m_accountedDr  ;
			}
			set	
			{	
				m_accountedDr = value ;	
			}
		}
		

				/// <summary>
		/// 贷方金额（本币）
		/// SAP与U9凭证对接中间表行.Misc.贷方金额（本币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedCr ;
		public System.Decimal AccountedCr
		{
			get	
			{	
				return m_accountedCr  ;
			}
			set	
			{	
				m_accountedCr = value ;	
			}
		}
		

				/// <summary>
		/// 借方金额（原币）
		/// SAP与U9凭证对接中间表行.Misc.借方金额（原币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_enteredDr ;
		public System.Decimal EnteredDr
		{
			get	
			{	
				return m_enteredDr  ;
			}
			set	
			{	
				m_enteredDr = value ;	
			}
		}
		

				/// <summary>
		/// 贷方金额（原币）
		/// SAP与U9凭证对接中间表行.Misc.贷方金额（原币）
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_enteredCr ;
		public System.Decimal EnteredCr
		{
			get	
			{	
				return m_enteredCr  ;
			}
			set	
			{	
				m_enteredCr = value ;	
			}
		}
		

				/// <summary>
		/// 现金流量项目编码
		/// SAP与U9凭证对接中间表行.Misc.现金流量项目编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cashFlowCode ;
		public System.String CashFlowCode
		{
			get	
			{	
				return m_cashFlowCode  ;
			}
			set	
			{	
				m_cashFlowCode = value ;	
			}
		}
		

				/// <summary>
		/// 现金流量项目描述
		/// SAP与U9凭证对接中间表行.Misc.现金流量项目描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cashFlowDescription ;
		public System.String CashFlowDescription
		{
			get	
			{	
				return m_cashFlowDescription  ;
			}
			set	
			{	
				m_cashFlowDescription = value ;	
			}
		}
		

				/// <summary>
		/// 费用类型编码
		/// SAP与U9凭证对接中间表行.Misc.费用类型编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_feeTypeEnumCode ;
		public System.String FeeTypeEnumCode
		{
			get	
			{	
				return m_feeTypeEnumCode  ;
			}
			set	
			{	
				m_feeTypeEnumCode = value ;	
			}
		}
		

				/// <summary>
		/// 费用类型描述
		/// SAP与U9凭证对接中间表行.Misc.费用类型描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_feeTypeEnumDescription ;
		public System.String FeeTypeEnumDescription
		{
			get	
			{	
				return m_feeTypeEnumDescription  ;
			}
			set	
			{	
				m_feeTypeEnumDescription = value ;	
			}
		}
		

				/// <summary>
		/// 开户行
		/// SAP与U9凭证对接中间表行.Misc.开户行
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_banks ;
		public System.String Banks
		{
			get	
			{	
				return m_banks  ;
			}
			set	
			{	
				m_banks = value ;	
			}
		}
		

				/// <summary>
		/// 银行账号
		/// SAP与U9凭证对接中间表行.Misc.银行账号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bankAccount ;
		public System.String BankAccount
		{
			get	
			{	
				return m_bankAccount  ;
			}
			set	
			{	
				m_bankAccount = value ;	
			}
		}
		

				/// <summary>
		/// 客户编码
		/// SAP与U9凭证对接中间表行.Misc.客户编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerCode ;
		public System.String CustomerCode
		{
			get	
			{	
				return m_customerCode  ;
			}
			set	
			{	
				m_customerCode = value ;	
			}
		}
		

				/// <summary>
		/// 客户名称
		/// SAP与U9凭证对接中间表行.Misc.客户名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerDescription ;
		public System.String CustomerDescription
		{
			get	
			{	
				return m_customerDescription  ;
			}
			set	
			{	
				m_customerDescription = value ;	
			}
		}
		

				/// <summary>
		/// 供应商编码
		/// SAP与U9凭证对接中间表行.Misc.供应商编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierCode ;
		public System.String SupplierCode
		{
			get	
			{	
				return m_supplierCode  ;
			}
			set	
			{	
				m_supplierCode = value ;	
			}
		}
		

				/// <summary>
		/// 供应商名称
		/// SAP与U9凭证对接中间表行.Misc.供应商名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierDescription ;
		public System.String SupplierDescription
		{
			get	
			{	
				return m_supplierDescription  ;
			}
			set	
			{	
				m_supplierDescription = value ;	
			}
		}
		

				/// <summary>
		/// 部门编码
		/// SAP与U9凭证对接中间表行.Misc.部门编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_departmentCode ;
		public System.String DepartmentCode
		{
			get	
			{	
				return m_departmentCode  ;
			}
			set	
			{	
				m_departmentCode = value ;	
			}
		}
		

				/// <summary>
		/// 部门名称
		/// SAP与U9凭证对接中间表行.Misc.部门名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_departmentName ;
		public System.String DepartmentName
		{
			get	
			{	
				return m_departmentName  ;
			}
			set	
			{	
				m_departmentName = value ;	
			}
		}
		

				/// <summary>
		/// 员工编码
		/// SAP与U9凭证对接中间表行.Misc.员工编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_employeeCode ;
		public System.String EmployeeCode
		{
			get	
			{	
				return m_employeeCode  ;
			}
			set	
			{	
				m_employeeCode = value ;	
			}
		}
		

				/// <summary>
		/// 员工名称
		/// SAP与U9凭证对接中间表行.Misc.员工名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_employeeName ;
		public System.String EmployeeName
		{
			get	
			{	
				return m_employeeName  ;
			}
			set	
			{	
				m_employeeName = value ;	
			}
		}
		

				/// <summary>
		/// 物料组编码
		/// SAP与U9凭证对接中间表行.Misc.物料组编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_materialGroupCode ;
		public System.String MaterialGroupCode
		{
			get	
			{	
				return m_materialGroupCode  ;
			}
			set	
			{	
				m_materialGroupCode = value ;	
			}
		}
		

				/// <summary>
		/// 物料组描述
		/// SAP与U9凭证对接中间表行.Misc.物料组描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_materialGroupDescription ;
		public System.String MaterialGroupDescription
		{
			get	
			{	
				return m_materialGroupDescription  ;
			}
			set	
			{	
				m_materialGroupDescription = value ;	
			}
		}
		

				/// <summary>
		/// 资产编号
		/// SAP与U9凭证对接中间表行.Misc.资产编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_assetsCode ;
		public System.String AssetsCode
		{
			get	
			{	
				return m_assetsCode  ;
			}
			set	
			{	
				m_assetsCode = value ;	
			}
		}
		

				/// <summary>
		/// 资产描述
		/// SAP与U9凭证对接中间表行.Misc.资产描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_assetsDescription ;
		public System.String AssetsDescription
		{
			get	
			{	
				return m_assetsDescription  ;
			}
			set	
			{	
				m_assetsDescription = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// SAP与U9凭证对接中间表行.Misc.实体扩展字段
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData m_descFlexField ;
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData DescFlexField
		{
			get	
			{	
				return m_descFlexField  ;
			}
			set	
			{	
				m_descFlexField = value ;	
			}
		}
		

				/// <summary>
		/// 关系企业代码
		/// SAP与U9凭证对接中间表行.Misc.关系企业代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relCompCode ;
		public System.String RelCompCode
		{
			get	
			{	
				return m_relCompCode  ;
			}
			set	
			{	
				m_relCompCode = value ;	
			}
		}
		

				/// <summary>
		/// 关系企业名称
		/// SAP与U9凭证对接中间表行.Misc.关系企业名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relCompName ;
		public System.String RelCompName
		{
			get	
			{	
				return m_relCompName  ;
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

