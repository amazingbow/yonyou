
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	/// <summary>
	/// 专柜尺寸 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class SpecialSizeBEData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.ValueSet.DefineValueData));
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBEData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SpecialSizeBEData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     							Width=0m; 
	     							Hight=0m; 
	     							Thick=0m; 
	     							Qty=0m; 
	     							Area=0m; 
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_specialApplyBE_SKey ;
			/// <summary>
			/// 专柜申请单 序列化Key属性。（传递跨组织序列列字段）
			/// 专柜尺寸.Misc.专柜申请单
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey SpecialApplyBE_SKey
			{
				get 
				{
					return m_specialApplyBE_SKey ;					
				}
				set
				{
					m_specialApplyBE_SKey = value ;	
				}
			}
		/// <summary>
		/// 专柜申请单
		/// 专柜尺寸.Misc.专柜申请单
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBEData m_specialApplyBE;
		public UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBEData SpecialApplyBE
		{
			get	
			{	
				return m_specialApplyBE ;
			}
			set	
			{	
				m_specialApplyBE = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 专柜尺寸.Key.ID
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
		/// 专柜尺寸.Sys.创建时间
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
		/// 专柜尺寸.Sys.创建人
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
		/// 专柜尺寸.Sys.修改时间
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
		/// 专柜尺寸.Sys.修改人
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
		/// 专柜尺寸.Sys.事务版本
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_displayProductType_SKey ;
		/// <summary>
		/// 展示产品类型 序列化Key属性。（传递跨组织序列列字段）
		/// 专柜尺寸.Misc.展示产品类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey DisplayProductType_SKey
		{
			get 
			{
				return m_displayProductType_SKey ;					
			}
			set
			{
				 m_displayProductType_SKey = value ;	
			}
		}
		/// <summary>
		/// 展示产品类型
		/// 专柜尺寸.Misc.展示产品类型
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 DisplayProductType
		{
			get	
			{	
				if (DisplayProductType_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return DisplayProductType_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					DisplayProductType_SKey = null ;
				else
				{
					if (DisplayProductType_SKey == null )
						DisplayProductType_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.FlexField.ValueSet.DefineValue") ;
					else
						DisplayProductType_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 宽
		/// 专柜尺寸.Misc.宽
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_width ;
		public System.Decimal Width
		{
			get	
			{	
				return m_width  ;
			}
			set	
			{	
				m_width = value ;	
			}
		}
		

				/// <summary>
		/// 高
		/// 专柜尺寸.Misc.高
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_hight ;
		public System.Decimal Hight
		{
			get	
			{	
				return m_hight  ;
			}
			set	
			{	
				m_hight = value ;	
			}
		}
		

				/// <summary>
		/// 厚
		/// 专柜尺寸.Misc.厚
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_thick ;
		public System.Decimal Thick
		{
			get	
			{	
				return m_thick  ;
			}
			set	
			{	
				m_thick = value ;	
			}
		}
		

				/// <summary>
		/// 数量
		/// 专柜尺寸.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qty ;
		public System.Decimal Qty
		{
			get	
			{	
				return m_qty  ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
		

				/// <summary>
		/// 面积
		/// 专柜尺寸.Misc.面积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_area ;
		public System.Decimal Area
		{
			get	
			{	
				return m_area  ;
			}
			set	
			{	
				m_area = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 专柜尺寸.Misc.备注
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
		

				/// <summary>
		/// 实体扩展字段
		/// 专柜尺寸.Misc.实体扩展字段
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_advCarrier_SKey ;
		/// <summary>
		/// 广告载体 序列化Key属性。（传递跨组织序列列字段）
		/// 专柜尺寸.Misc.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey AdvCarrier_SKey
		{
			get 
			{
				return m_advCarrier_SKey ;					
			}
			set
			{
				 m_advCarrier_SKey = value ;	
			}
		}
		/// <summary>
		/// 广告载体
		/// 专柜尺寸.Misc.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 AdvCarrier
		{
			get	
			{	
				if (AdvCarrier_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return AdvCarrier_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					AdvCarrier_SKey = null ;
				else
				{
					if (AdvCarrier_SKey == null )
						AdvCarrier_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemMaster") ;
					else
						AdvCarrier_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
																
		#endregion 		
	}	

}

