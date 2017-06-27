
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	/// <summary>
	/// 专柜申请单 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class SpecialApplyBEData : UFIDA.U9.Base.Doc.DocData
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Customer.CustomerData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData>));
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocTypeData));
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SpecialApplyBEData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							SpecialDesignStyle= 0; 			     			
	     			
	     							Status= 0; 			     							WFCurrentState= -1; 			     							WFOriginalState= -1; 		

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
			get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 专柜设计风格
		/// 专柜申请单.Misc.专柜设计风格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_specialDesignStyle;
		public System.Int32 SpecialDesignStyle
		{
			get	
			{	
				return m_specialDesignStyle ;
			}
			set	
			{	
				m_specialDesignStyle = value ;
			}
		}		

			        					/// <summary>
		/// 专柜尺寸
		/// 专柜申请单.Misc.专柜尺寸
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData> m_specialSizeBE;
		public List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData> SpecialSizeBE
		{
			get	
			{	
				if (m_specialSizeBE == null)
				{
					List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData> m_list = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData>() ;
					m_specialSizeBE = m_list;
				}
				return m_specialSizeBE ;
			}
			set	
			{	
				m_specialSizeBE = value ;
			}
		}		

			        					/// <summary>
		/// 状态
		/// 专柜申请单.Misc.状态
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

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// 编号
		/// 专柜申请单.Misc.编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advCode ;
		public System.String AdvCode
		{
			get	
			{	
				return m_advCode  ;
			}
			set	
			{	
				m_advCode = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_applyDept_SKey ;
		/// <summary>
		/// 办事处 序列化Key属性。（传递跨组织序列列字段）
		/// 专柜申请单.Misc.办事处
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ApplyDept_SKey
		{
			get 
			{
				return m_applyDept_SKey ;					
			}
			set
			{
				 m_applyDept_SKey = value ;	
			}
		}
		/// <summary>
		/// 办事处
		/// 专柜申请单.Misc.办事处
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ApplyDept
		{
			get	
			{	
				if (ApplyDept_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ApplyDept_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ApplyDept_SKey = null ;
				else
				{
					if (ApplyDept_SKey == null )
						ApplyDept_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.Customer") ;
					else
						ApplyDept_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 下单人
		/// 专柜申请单.Misc.下单人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_applier ;
		public System.String Applier
		{
			get	
			{	
				return m_applier  ;
			}
			set	
			{	
				m_applier = value ;	
			}
		}
		

				/// <summary>
		/// 下单日期
		/// 专柜申请单.Misc.下单日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_applyDate ;
		public System.DateTime ApplyDate
		{
			get	
			{	
				return m_applyDate  ;
			}
			set	
			{	
				m_applyDate = value ;	
			}
		}
		

				/// <summary>
		/// 联系电话
		/// 专柜申请单.Misc.联系电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_phone ;
		public System.String Phone
		{
			get	
			{	
				return m_phone  ;
			}
			set	
			{	
				m_phone = value ;	
			}
		}
		

				/// <summary>
		/// QQ
		/// 专柜申请单.Misc.QQ
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_qQ ;
		public System.String QQ
		{
			get	
			{	
				return m_qQ  ;
			}
			set	
			{	
				m_qQ = value ;	
			}
		}
		

				/// <summary>
		/// 客户店名
		/// 专柜申请单.Misc.客户店名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custConterName ;
		public System.String CustConterName
		{
			get	
			{	
				return m_custConterName  ;
			}
			set	
			{	
				m_custConterName = value ;	
			}
		}
		

				/// <summary>
		/// 客户名称
		/// 专柜申请单.Misc.客户名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custName ;
		public System.String CustName
		{
			get	
			{	
				return m_custName  ;
			}
			set	
			{	
				m_custName = value ;	
			}
		}
		

				/// <summary>
		/// 客户电话
		/// 专柜申请单.Misc.客户电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custPhone ;
		public System.String CustPhone
		{
			get	
			{	
				return m_custPhone  ;
			}
			set	
			{	
				m_custPhone = value ;	
			}
		}
		

				/// <summary>
		/// 客户地址
		/// 专柜申请单.Misc.客户地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custAddress ;
		public System.String CustAddress
		{
			get	
			{	
				return m_custAddress  ;
			}
			set	
			{	
				m_custAddress = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_specialApplyDocType_SKey ;
		/// <summary>
		/// 单据类型 序列化Key属性。（传递跨组织序列列字段）
		/// 专柜申请单.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SpecialApplyDocType_SKey
		{
			get 
			{
				return m_specialApplyDocType_SKey ;					
			}
			set
			{
				 m_specialApplyDocType_SKey = value ;	
			}
		}
		/// <summary>
		/// 单据类型
		/// 专柜申请单.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 SpecialApplyDocType
		{
			get	
			{	
				if (SpecialApplyDocType_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SpecialApplyDocType_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SpecialApplyDocType_SKey = null ;
				else
				{
					if (SpecialApplyDocType_SKey == null )
						SpecialApplyDocType_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType") ;
					else
						SpecialApplyDocType_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 当前状态
		/// 专柜申请单.StateMachine.当前状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_wFCurrentState ;
		public System.Int32 WFCurrentState
		{
			get	
			{	
				return m_wFCurrentState  ;
			}
			set	
			{	
				m_wFCurrentState = value ;	
			}
		}
		

				/// <summary>
		/// 之前状态
		/// 专柜申请单.StateMachine.之前状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_wFOriginalState ;
		public System.Int32 WFOriginalState
		{
			get	
			{	
				return m_wFOriginalState  ;
			}
			set	
			{	
				m_wFOriginalState = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																
		#endregion 		
	}	

}

