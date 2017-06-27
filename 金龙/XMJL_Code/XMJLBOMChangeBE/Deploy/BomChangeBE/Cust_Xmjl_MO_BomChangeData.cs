
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomChangeBE
{
	/// <summary>
	/// 缺件变更单 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomChangeData : UFIDA.U9.Base.Doc.DocData
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                            knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData>));
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData>));
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentTypeData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UserRole.UserData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomChangeData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     							ChangeStat=false; 
	     			
	     			


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
			get { return "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 缺件变更料号行
		/// 缺件变更单.Misc.缺件变更料号行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData> m_cust_Xmjl_MO_BomChangeItem;
		public List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData> Cust_Xmjl_MO_BomChangeItem
		{
			get	
			{	
				if (m_cust_Xmjl_MO_BomChangeItem == null)
				{
					List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData> m_list = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData>() ;
					m_cust_Xmjl_MO_BomChangeItem = m_list;
				}
				return m_cust_Xmjl_MO_BomChangeItem ;
			}
			set	
			{	
				m_cust_Xmjl_MO_BomChangeItem = value ;
			}
		}		

			        					/// <summary>
		/// 缺件变更车号行
		/// 缺件变更单.Misc.缺件变更车号行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData> m_cust_Xmjl_MO_BomChangeManufactureNo;
		public List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData> Cust_Xmjl_MO_BomChangeManufactureNo
		{
			get	
			{	
				if (m_cust_Xmjl_MO_BomChangeManufactureNo == null)
				{
					List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData> m_list = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData>() ;
					m_cust_Xmjl_MO_BomChangeManufactureNo = m_list;
				}
				return m_cust_Xmjl_MO_BomChangeManufactureNo ;
			}
			set	
			{	
				m_cust_Xmjl_MO_BomChangeManufactureNo = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// 变更原因
		/// 缺件变更单.Misc.变更原因
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_changeReason ;
		public System.String ChangeReason
		{
			get	
			{	
				return m_changeReason  ;
			}
			set	
			{	
				m_changeReason = value ;	
			}
		}
		

				/// <summary>
		/// 变更时间
		/// 缺件变更单.Misc.变更时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_changeDateTime ;
		public System.DateTime ChangeDateTime
		{
			get	
			{	
				return m_changeDateTime  ;
			}
			set	
			{	
				m_changeDateTime = value ;	
			}
		}
		

				/// <summary>
		/// 变更状态
		/// 缺件变更单.Misc.变更状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_changeStat ;
		public System.Boolean ChangeStat
		{
			get	
			{	
				return m_changeStat  ;
			}
			set	
			{	
				m_changeStat = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_changeDocType_SKey ;
		/// <summary>
		/// 变更单据类型 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件变更单.Misc.变更单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ChangeDocType_SKey
		{
			get 
			{
				return m_changeDocType_SKey ;					
			}
			set
			{
				 m_changeDocType_SKey = value ;	
			}
		}
		/// <summary>
		/// 变更单据类型
		/// 缺件变更单.Misc.变更单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ChangeDocType
		{
			get	
			{	
				if (ChangeDocType_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ChangeDocType_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ChangeDocType_SKey = null ;
				else
				{
					if (ChangeDocType_SKey == null )
						ChangeDocType_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType") ;
					else
						ChangeDocType_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_changePerson_SKey ;
		/// <summary>
		/// 变更人 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件变更单.Misc.变更人
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ChangePerson_SKey
		{
			get 
			{
				return m_changePerson_SKey ;					
			}
			set
			{
				 m_changePerson_SKey = value ;	
			}
		}
		/// <summary>
		/// 变更人
		/// 缺件变更单.Misc.变更人
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ChangePerson
		{
			get	
			{	
				if (ChangePerson_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ChangePerson_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ChangePerson_SKey = null ;
				else
				{
					if (ChangePerson_SKey == null )
						ChangePerson_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UserRole.User") ;
					else
						ChangePerson_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
							
		#endregion 		
	}	

}

