
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace AdvertisementApplyBE
{
	/// <summary>
	/// 广告申请单 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "AdvertisementApplyBE.AdvApplyBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class AdvApplyBEData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Customer.CustomerData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public AdvApplyBEData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							TotalArea=0m; 
	     							Qty=0m; 
	     							BMWidth=0m; 
	     							BMHight=0m; 
	     							BMThick=0m; 
	     							BMArea=0m; 
	     							DZWidth=0m; 
	     							DZThick=0m; 
	     							DZArea=0m; 
	     							AdvDisplayType= 0; 			     			
	     			
	     			
	     			


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
			get { return "AdvertisementApplyBE.AdvApplyBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 版面类型
		/// 广告申请单.Misc.版面类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_advDisplayType;
		public System.Int32 AdvDisplayType
		{
			get	
			{	
				return m_advDisplayType ;
			}
			set	
			{	
				m_advDisplayType = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 广告申请单.Key.ID
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
		/// 广告申请单.Sys.创建时间
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
		/// 广告申请单.Sys.创建人
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
		/// 广告申请单.Sys.修改时间
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
		/// 广告申请单.Sys.修改人
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
		/// 广告申请单.Sys.事务版本
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
		/// 编号
		/// 广告申请单.Misc.编号
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
		/// 广告申请单.Misc.办事处
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
		/// 广告申请单.Misc.办事处
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
		/// 广告申请单.Misc.下单人
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
		/// 广告申请单.Misc.下单日期
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
		/// 广告申请单.Misc.联系电话
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
		/// 广告申请单.Misc.QQ
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
		/// 广告申请单.Misc.客户店名
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
		/// 区域
		/// 广告申请单.Misc.区域
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_locationQY ;
		public System.String LocationQY
		{
			get	
			{	
				return m_locationQY  ;
			}
			set	
			{	
				m_locationQY = value ;	
			}
		}
		

				/// <summary>
		/// 乡镇
		/// 广告申请单.Misc.乡镇
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_locationXZ ;
		public System.String LocationXZ
		{
			get	
			{	
				return m_locationXZ  ;
			}
			set	
			{	
				m_locationXZ = value ;	
			}
		}
		

				/// <summary>
		/// 联系人
		/// 广告申请单.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relPeople ;
		public System.String RelPeople
		{
			get	
			{	
				return m_relPeople  ;
			}
			set	
			{	
				m_relPeople = value ;	
			}
		}
		

				/// <summary>
		/// 客户联系电话
		/// 广告申请单.Misc.客户联系电话
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
		/// 广告申请单.Misc.客户地址
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_advItem_SKey ;
		/// <summary>
		/// 广告载体 序列化Key属性。（传递跨组织序列列字段）
		/// 广告申请单.Misc.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey AdvItem_SKey
		{
			get 
			{
				return m_advItem_SKey ;					
			}
			set
			{
				 m_advItem_SKey = value ;	
			}
		}
		/// <summary>
		/// 广告载体
		/// 广告申请单.Misc.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 AdvItem
		{
			get	
			{	
				if (AdvItem_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return AdvItem_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					AdvItem_SKey = null ;
				else
				{
					if (AdvItem_SKey == null )
						AdvItem_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemMaster") ;
					else
						AdvItem_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 总面积
		/// 广告申请单.Misc.总面积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalArea ;
		public System.Decimal TotalArea
		{
			get	
			{	
				return m_totalArea  ;
			}
			set	
			{	
				m_totalArea = value ;	
			}
		}
		

				/// <summary>
		/// 数量
		/// 广告申请单.Misc.数量
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
		/// 版面-宽
		/// 广告申请单.Misc.版面-宽
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_bMWidth ;
		public System.Decimal BMWidth
		{
			get	
			{	
				return m_bMWidth  ;
			}
			set	
			{	
				m_bMWidth = value ;	
			}
		}
		

				/// <summary>
		/// 版面-高
		/// 广告申请单.Misc.版面-高
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_bMHight ;
		public System.Decimal BMHight
		{
			get	
			{	
				return m_bMHight  ;
			}
			set	
			{	
				m_bMHight = value ;	
			}
		}
		

				/// <summary>
		/// 版面-厚
		/// 广告申请单.Misc.版面-厚
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_bMThick ;
		public System.Decimal BMThick
		{
			get	
			{	
				return m_bMThick  ;
			}
			set	
			{	
				m_bMThick = value ;	
			}
		}
		

				/// <summary>
		/// 版面-面积
		/// 广告申请单.Misc.版面-面积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_bMArea ;
		public System.Decimal BMArea
		{
			get	
			{	
				return m_bMArea  ;
			}
			set	
			{	
				m_bMArea = value ;	
			}
		}
		

				/// <summary>
		/// 店招-宽
		/// 广告申请单.Misc.店招-宽
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_dZWidth ;
		public System.Decimal DZWidth
		{
			get	
			{	
				return m_dZWidth  ;
			}
			set	
			{	
				m_dZWidth = value ;	
			}
		}
		

				/// <summary>
		/// 店招-厚
		/// 广告申请单.Misc.店招-厚
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_dZThick ;
		public System.Decimal DZThick
		{
			get	
			{	
				return m_dZThick  ;
			}
			set	
			{	
				m_dZThick = value ;	
			}
		}
		

				/// <summary>
		/// 店招-面积
		/// 广告申请单.Misc.店招-面积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_dZArea ;
		public System.Decimal DZArea
		{
			get	
			{	
				return m_dZArea  ;
			}
			set	
			{	
				m_dZArea = value ;	
			}
		}
		

				/// <summary>
		/// 版面要求1
		/// 广告申请单.Misc.版面要求1
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advDispInfo1 ;
		public System.String AdvDispInfo1
		{
			get	
			{	
				return m_advDispInfo1  ;
			}
			set	
			{	
				m_advDispInfo1 = value ;	
			}
		}
		

				/// <summary>
		/// 版面要求2
		/// 广告申请单.Misc.版面要求2
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advDispInfo2 ;
		public System.String AdvDispInfo2
		{
			get	
			{	
				return m_advDispInfo2  ;
			}
			set	
			{	
				m_advDispInfo2 = value ;	
			}
		}
		

				/// <summary>
		/// 广告体现项目
		/// 广告申请单.Misc.广告体现项目
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advAbout ;
		public System.String AdvAbout
		{
			get	
			{	
				return m_advAbout  ;
			}
			set	
			{	
				m_advAbout = value ;	
			}
		}
		

				/// <summary>
		/// 客户排版文字信息
		/// 广告申请单.Misc.客户排版文字信息
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advMemo ;
		public System.String AdvMemo
		{
			get	
			{	
				return m_advMemo  ;
			}
			set	
			{	
				m_advMemo = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																																	
		#endregion 		
	}	

}

