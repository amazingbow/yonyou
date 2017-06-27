
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BommBE
{
	/// <summary>
	/// 缺件发料主表 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMainData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomMainData : UFIDA.U9.Base.Doc.DocData
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                            knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentTypeData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.ProjectTask.ProjectData));
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.HR.Operator.OperatorsData));
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.MO.MO.MOData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.HR.Department.DepartmentData));
                        
                        
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHeadData>));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomMainData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     							Sequence= 0; 			     			
	     			
	     			
	     			
	     			
	     							Status= 1; 			     							DisburseType= 1; 			     			
	     			


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
			get { return "UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 状态
		/// 缺件发料主表.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_status;
		public System.Int32 Status
		{
			get	
			{	
				return m_status ;
			}
			set	
			{	
				m_status = value ;
			}
		}		

			        					/// <summary>
		/// 发料类型
		/// 缺件发料主表.Misc.发料类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_disburseType;
		public System.Int32 DisburseType
		{
			get	
			{	
				return m_disburseType ;
			}
			set	
			{	
				m_disburseType = value ;
			}
		}		

			        					/// <summary>
		/// 缺件发料单
		/// 缺件发料主表.Misc.缺件发料单
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHeadData> m_cust_Xmjl_MO_BomHead;
		public List<UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHeadData> Cust_Xmjl_MO_BomHead
		{
			get	
			{	
				if (m_cust_Xmjl_MO_BomHead == null)
				{
					List<UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHeadData> m_list = new List<UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHeadData>() ;
					m_cust_Xmjl_MO_BomHead = m_list;
				}
				return m_cust_Xmjl_MO_BomHead ;
			}
			set	
			{	
				m_cust_Xmjl_MO_BomHead = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_documentType_SKey ;
		/// <summary>
		/// 单据类型 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料主表.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey DocumentType_SKey
		{
			get 
			{
				return m_documentType_SKey ;					
			}
			set
			{
				 m_documentType_SKey = value ;	
			}
		}
		/// <summary>
		/// 单据类型
		/// 缺件发料主表.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 DocumentType
		{
			get	
			{	
				if (DocumentType_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return DocumentType_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					DocumentType_SKey = null ;
				else
				{
					if (DocumentType_SKey == null )
						DocumentType_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType") ;
					else
						DocumentType_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_manufactureNo_SKey ;
		/// <summary>
		/// 车号 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料主表.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ManufactureNo_SKey
		{
			get 
			{
				return m_manufactureNo_SKey ;					
			}
			set
			{
				 m_manufactureNo_SKey = value ;	
			}
		}
		/// <summary>
		/// 车号
		/// 缺件发料主表.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ManufactureNo
		{
			get	
			{	
				if (ManufactureNo_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ManufactureNo_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ManufactureNo_SKey = null ;
				else
				{
					if (ManufactureNo_SKey == null )
						ManufactureNo_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.ProjectTask.Project") ;
					else
						ManufactureNo_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 合同号
		/// 缺件发料主表.Misc.合同号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_contractNo ;
		public System.String ContractNo
		{
			get	
			{	
				return m_contractNo  ;
			}
			set	
			{	
				m_contractNo = value ;	
			}
		}
		

				/// <summary>
		/// 车序
		/// 缺件发料主表.Misc.车序
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sequence ;
		public System.Int32 Sequence
		{
			get	
			{	
				return m_sequence  ;
			}
			set	
			{	
				m_sequence = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_disburseBY_SKey ;
		/// <summary>
		/// 发料人 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料主表.Misc.发料人
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey DisburseBY_SKey
		{
			get 
			{
				return m_disburseBY_SKey ;					
			}
			set
			{
				 m_disburseBY_SKey = value ;	
			}
		}
		/// <summary>
		/// 发料人
		/// 缺件发料主表.Misc.发料人
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 DisburseBY
		{
			get	
			{	
				if (DisburseBY_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return DisburseBY_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					DisburseBY_SKey = null ;
				else
				{
					if (DisburseBY_SKey == null )
						DisburseBY_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						DisburseBY_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 发料日期
		/// 缺件发料主表.Misc.发料日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_disburseOn ;
		public System.DateTime DisburseOn
		{
			get	
			{	
				return m_disburseOn  ;
			}
			set	
			{	
				m_disburseOn = value ;	
			}
		}
		

				/// <summary>
		/// 车型
		/// 缺件发料主表.Misc.车型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carType ;
		public System.String CarType
		{
			get	
			{	
				return m_carType  ;
			}
			set	
			{	
				m_carType = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_mo_SKey ;
		/// <summary>
		/// 生产订单工单号 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料主表.Misc.生产订单工单号
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Mo_SKey
		{
			get 
			{
				return m_mo_SKey ;					
			}
			set
			{
				 m_mo_SKey = value ;	
			}
		}
		/// <summary>
		/// 生产订单工单号
		/// 缺件发料主表.Misc.生产订单工单号
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Mo
		{
			get	
			{	
				if (Mo_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Mo_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Mo_SKey = null ;
				else
				{
					if (Mo_SKey == null )
						Mo_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.MO.MO.MO") ;
					else
						Mo_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_department_SKey ;
		/// <summary>
		/// 工厂 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料主表.Misc.工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Department_SKey
		{
			get 
			{
				return m_department_SKey ;					
			}
			set
			{
				 m_department_SKey = value ;	
			}
		}
		/// <summary>
		/// 工厂
		/// 缺件发料主表.Misc.工厂
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Department
		{
			get	
			{	
				if (Department_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Department_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Department_SKey = null ;
				else
				{
					if (Department_SKey == null )
						Department_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Department.Department") ;
					else
						Department_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 备注
		/// 缺件发料主表.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo  ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
													
		#endregion 		
	}	

}

