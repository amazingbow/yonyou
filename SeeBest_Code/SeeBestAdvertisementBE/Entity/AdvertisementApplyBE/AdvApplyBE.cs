using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace AdvertisementApplyBE
{
	
	/// <summary>
	/// 实体: 广告申请单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class AdvApplyBE : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public AdvApplyBE(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static AdvApplyBE Create() {
			AdvApplyBE entity = (AdvApplyBE)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																									 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected AdvApplyBE(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static AdvApplyBE CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static AdvApplyBE CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "AdvertisementApplyBE.AdvApplyBE"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("AdvertisementApplyBE.AdvApplyBE");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class AdvApplyBE EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "AdvertisementApplyBE.AdvApplyBE")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new AdvApplyBE GetEntity()
			{
				return (AdvApplyBE)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<AdvApplyBE> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<AdvApplyBE>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private AdvApplyBE ContainerEntity ;
		    public  new AdvApplyBE ContainerEntity 
		    {
				get { return  (AdvApplyBE)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(AdvApplyBE container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 广告申请单.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 广告申请单.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 广告申请单.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 广告申请单.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 广告申请单.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 广告申请单.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 编号 (该属性不可为空,且无默认值)
			/// 广告申请单.Misc.编号
			/// </summary>
			/// <value></value>
			public  System.String AdvCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 办事处 (该属性不可为空,且无默认值)
			/// 广告申请单.Misc.办事处
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer ApplyDept
			{
				get
				{
					if (ApplyDeptKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)ApplyDeptKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ApplyDeptKey ;
		/// <summary>
		/// EntityKey 属性
		/// 办事处 的Key (该属性不可为空,且无默认值)
		/// 广告申请单.Misc.办事处
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ApplyDeptKey
		{
			get 
			{
				object obj = base.GetValue("ApplyDept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ApplyDeptKey==null || m_ApplyDeptKey.ID != key )
					m_ApplyDeptKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ApplyDeptKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 下单人 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.下单人
			/// </summary>
			/// <value></value>
			public  System.String Applier
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Applier");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 下单日期 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.下单日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ApplyDate
			{
				get
				{
					object obj = base.GetValue("ApplyDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 联系电话 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.联系电话
			/// </summary>
			/// <value></value>
			public  System.String Phone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Phone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// QQ (该属性可为空,且无默认值)
			/// 广告申请单.Misc.QQ
			/// </summary>
			/// <value></value>
			public  System.String QQ
			{
				get
				{
					System.String value  = (System.String)base.GetValue("QQ");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户店名 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.客户店名
			/// </summary>
			/// <value></value>
			public  System.String CustConterName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustConterName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 区域 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.区域
			/// </summary>
			/// <value></value>
			public  System.String LocationQY
			{
				get
				{
					System.String value  = (System.String)base.GetValue("LocationQY");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 乡镇 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.乡镇
			/// </summary>
			/// <value></value>
			public  System.String LocationXZ
			{
				get
				{
					System.String value  = (System.String)base.GetValue("LocationXZ");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 联系人 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.联系人
			/// </summary>
			/// <value></value>
			public  System.String RelPeople
			{
				get
				{
					System.String value  = (System.String)base.GetValue("RelPeople");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户联系电话 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.客户联系电话
			/// </summary>
			/// <value></value>
			public  System.String CustPhone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustPhone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户地址 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.客户地址
			/// </summary>
			/// <value></value>
			public  System.String CustAddress
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustAddress");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 广告载体 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.广告载体
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster AdvItem
			{
				get
				{
					if (AdvItemKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)AdvItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_AdvItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 广告载体 的Key (该属性可为空,且无默认值)
		/// 广告申请单.Misc.广告载体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey AdvItemKey
		{
			get 
			{
				object obj = base.GetValue("AdvItem") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AdvItemKey==null || m_AdvItemKey.ID != key )
					m_AdvItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_AdvItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总面积 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.总面积
			/// </summary>
			/// <value></value>
			public  System.Decimal TotalArea
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TotalArea");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性不可为空,但有默认值)
			/// 广告申请单.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal Qty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面-宽 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.版面-宽
			/// </summary>
			/// <value></value>
			public  System.Decimal BMWidth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BMWidth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面-高 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.版面-高
			/// </summary>
			/// <value></value>
			public  System.Decimal BMHight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BMHight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面-厚 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.版面-厚
			/// </summary>
			/// <value></value>
			public  System.Decimal BMThick
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BMThick");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面-面积 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.版面-面积
			/// </summary>
			/// <value></value>
			public  System.Decimal BMArea
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BMArea");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 店招-宽 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.店招-宽
			/// </summary>
			/// <value></value>
			public  System.Decimal DZWidth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DZWidth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 店招-厚 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.店招-厚
			/// </summary>
			/// <value></value>
			public  System.Decimal DZThick
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DZThick");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 店招-面积 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.店招-面积
			/// </summary>
			/// <value></value>
			public  System.Decimal DZArea
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DZArea");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面类型 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.版面类型
			/// </summary>
			/// <value></value>
			public  AdvertisementApplyBE.AdvDisplayTypeEnum AdvDisplayType
			{
				get
				{

					AdvertisementApplyBE.AdvDisplayTypeEnum value  = AdvertisementApplyBE.AdvDisplayTypeEnum.GetFromValue(base.GetValue("AdvDisplayType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面要求1 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.版面要求1
			/// </summary>
			/// <value></value>
			public  System.String AdvDispInfo1
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvDispInfo1");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 版面要求2 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.版面要求2
			/// </summary>
			/// <value></value>
			public  System.String AdvDispInfo2
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvDispInfo2");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户排版文字信息 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.客户排版文字信息
			/// </summary>
			/// <value></value>
			public  System.String AdvMemo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvMemo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 核销数量 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.核销数量
			/// </summary>
			/// <value></value>
			public  System.Decimal ApproveQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ApproveQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 关闭 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.关闭
			/// </summary>
			/// <value></value>
			public  System.Boolean IsClose
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsClose");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<AdvertisementApplyBE.AdvAboutBE> m_AdvAboutBE  ;
			/// <summary>
			/// 广告体现项目子表 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.广告体现项目子表
			/// </summary>
			/// <value></value>
			public  List<AdvertisementApplyBE.AdvAboutBE> AdvAboutBE
			{
				get
				{
					if (m_AdvAboutBE == null)
						m_AdvAboutBE = new List<AdvertisementApplyBE.AdvAboutBE>();
					m_AdvAboutBE.Clear();	
					foreach (AdvertisementApplyBE.AdvAboutBE child in ContainerEntity.AdvAboutBE)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_AdvAboutBE.Add(child);
					}
					foreach (AdvertisementApplyBE.AdvAboutBE child in ContainerEntity.AdvAboutBE.DelLists)
					{
						m_AdvAboutBE.Add(child);
					}
					return m_AdvAboutBE;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 广告申请单.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 广告申请单.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 广告申请单.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 广告申请单.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 广告申请单.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 广告申请单.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 编号 (该属性不可为空,且无默认值)
		/// 广告申请单.Misc.编号
		/// </summary>
		/// <value></value>
			public  System.String AdvCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvCode");
				return value;
				}
				set
			{
				
								base.SetValue("AdvCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 办事处 (该属性不可为空,且无默认值)
		/// 广告申请单.Misc.办事处
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer ApplyDept
		{
			get
			{
				object  obj = this.GetRelation("ApplyDept");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customer.Customer value  = (UFIDA.U9.CBO.SCM.Customer.Customer)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ApplyDept", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ApplyDeptKey ;
		/// <summary>
		/// 办事处 的Key (该属性不可为空,且无默认值)
		/// 广告申请单.Misc.办事处
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ApplyDeptKey
		{
			get 
			{
				object obj = base.GetValue("ApplyDept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ApplyDeptKey==null || m_ApplyDeptKey.ID != key )
					m_ApplyDeptKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ApplyDeptKey ;
			}
			set
			{	
				if (ApplyDeptKey==value)
					return ;
				this.SetRelation("ApplyDept", null);
				m_ApplyDeptKey = value ;
				if (value != null) 
				{
					base.SetValue("ApplyDept",value.ID);
				}
				else
					base.SetValue("ApplyDept",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 下单人 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.下单人
		/// </summary>
		/// <value></value>
			public  System.String Applier
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Applier");
				return value;
				}
				set
			{
				
								base.SetValue("Applier", value);
						 
			}
		}
	



		
			/// <summary>
		/// 下单日期 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.下单日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ApplyDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ApplyDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ApplyDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 联系电话 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.联系电话
		/// </summary>
		/// <value></value>
			public  System.String Phone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Phone");
				return value;
				}
				set
			{
				
								base.SetValue("Phone", value);
						 
			}
		}
	



		
			/// <summary>
		/// QQ (该属性可为空,且无默认值)
		/// 广告申请单.Misc.QQ
		/// </summary>
		/// <value></value>
			public  System.String QQ
		{
			get
			{
				System.String value  = (System.String)base.GetValue("QQ");
				return value;
				}
				set
			{
				
								base.SetValue("QQ", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户店名 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.客户店名
		/// </summary>
		/// <value></value>
			public  System.String CustConterName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustConterName");
				return value;
				}
				set
			{
				
								base.SetValue("CustConterName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 区域 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.区域
		/// </summary>
		/// <value></value>
			public  System.String LocationQY
		{
			get
			{
				System.String value  = (System.String)base.GetValue("LocationQY");
				return value;
				}
				set
			{
				
								base.SetValue("LocationQY", value);
						 
			}
		}
	



		
			/// <summary>
		/// 乡镇 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.乡镇
		/// </summary>
		/// <value></value>
			public  System.String LocationXZ
		{
			get
			{
				System.String value  = (System.String)base.GetValue("LocationXZ");
				return value;
				}
				set
			{
				
								base.SetValue("LocationXZ", value);
						 
			}
		}
	



		
			/// <summary>
		/// 联系人 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.联系人
		/// </summary>
		/// <value></value>
			public  System.String RelPeople
		{
			get
			{
				System.String value  = (System.String)base.GetValue("RelPeople");
				return value;
				}
				set
			{
				
								base.SetValue("RelPeople", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户联系电话 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.客户联系电话
		/// </summary>
		/// <value></value>
			public  System.String CustPhone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustPhone");
				return value;
				}
				set
			{
				
								base.SetValue("CustPhone", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户地址 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.客户地址
		/// </summary>
		/// <value></value>
			public  System.String CustAddress
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustAddress");
				return value;
				}
				set
			{
				
								base.SetValue("CustAddress", value);
						 
			}
		}
	



		
			/// <summary>
		/// 广告载体 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.广告载体
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster AdvItem
		{
			get
			{
				object  obj = this.GetRelation("AdvItem");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("AdvItem", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_AdvItemKey ;
		/// <summary>
		/// 广告载体 的Key (该属性可为空,且无默认值)
		/// 广告申请单.Misc.广告载体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey AdvItemKey
		{
			get 
			{
				object obj = base.GetValue("AdvItem") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AdvItemKey==null || m_AdvItemKey.ID != key )
					m_AdvItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_AdvItemKey ;
			}
			set
			{	
				if (AdvItemKey==value)
					return ;
				this.SetRelation("AdvItem", null);
				m_AdvItemKey = value ;
				if (value != null) 
				{
					base.SetValue("AdvItem",value.ID);
				}
				else
					base.SetValue("AdvItem",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 总面积 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.总面积
		/// </summary>
		/// <value></value>
			public  System.Decimal TotalArea
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TotalArea");
				return value;
				}
				set
			{
				
								base.SetValue("TotalArea", value);
						 
			}
		}
	



		
			/// <summary>
		/// 数量 (该属性不可为空,但有默认值)
		/// 广告申请单.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal Qty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面-宽 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.版面-宽
		/// </summary>
		/// <value></value>
			public  System.Decimal BMWidth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BMWidth");
				return value;
				}
				set
			{
				
								base.SetValue("BMWidth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面-高 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.版面-高
		/// </summary>
		/// <value></value>
			public  System.Decimal BMHight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BMHight");
				return value;
				}
				set
			{
				
								base.SetValue("BMHight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面-厚 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.版面-厚
		/// </summary>
		/// <value></value>
			public  System.Decimal BMThick
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BMThick");
				return value;
				}
				set
			{
				
								base.SetValue("BMThick", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面-面积 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.版面-面积
		/// </summary>
		/// <value></value>
			public  System.Decimal BMArea
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BMArea");
				return value;
				}
				set
			{
				
								base.SetValue("BMArea", value);
						 
			}
		}
	



		
			/// <summary>
		/// 店招-宽 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.店招-宽
		/// </summary>
		/// <value></value>
			public  System.Decimal DZWidth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DZWidth");
				return value;
				}
				set
			{
				
								base.SetValue("DZWidth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 店招-厚 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.店招-厚
		/// </summary>
		/// <value></value>
			public  System.Decimal DZThick
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DZThick");
				return value;
				}
				set
			{
				
								base.SetValue("DZThick", value);
						 
			}
		}
	



		
			/// <summary>
		/// 店招-面积 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.店招-面积
		/// </summary>
		/// <value></value>
			public  System.Decimal DZArea
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DZArea");
				return value;
				}
				set
			{
				
								base.SetValue("DZArea", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面类型 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.版面类型
		/// </summary>
		/// <value></value>
			public  AdvertisementApplyBE.AdvDisplayTypeEnum AdvDisplayType
		{
			get
			{

				AdvertisementApplyBE.AdvDisplayTypeEnum value  = AdvertisementApplyBE.AdvDisplayTypeEnum.GetFromValue(base.GetValue("AdvDisplayType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("AdvDisplayType",AdvertisementApplyBE.AdvDisplayTypeEnum.Empty.Value);
				else
					base.SetValue("AdvDisplayType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 版面要求1 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.版面要求1
		/// </summary>
		/// <value></value>
			public  System.String AdvDispInfo1
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvDispInfo1");
				return value;
				}
				set
			{
				
								base.SetValue("AdvDispInfo1", value);
						 
			}
		}
	



		
			/// <summary>
		/// 版面要求2 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.版面要求2
		/// </summary>
		/// <value></value>
			public  System.String AdvDispInfo2
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvDispInfo2");
				return value;
				}
				set
			{
				
								base.SetValue("AdvDispInfo2", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户排版文字信息 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.客户排版文字信息
		/// </summary>
		/// <value></value>
			public  System.String AdvMemo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvMemo");
				return value;
				}
				set
			{
				
								base.SetValue("AdvMemo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 核销数量 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.核销数量
		/// </summary>
		/// <value></value>
			public  System.Decimal ApproveQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ApproveQty");
				return value;
				}
				set
			{
				
								base.SetValue("ApproveQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 关闭 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.关闭
		/// </summary>
		/// <value></value>
			public  System.Boolean IsClose
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsClose");
				return value;
				}
				set
			{
				
								base.SetValue("IsClose", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private AdvertisementApplyBE.AdvAboutBE.EntityList m_AdvAboutBE  ;
		/// <summary>
		/// 广告体现项目子表 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.广告体现项目子表
		/// </summary>
		/// <value></value>
		public  AdvertisementApplyBE.AdvAboutBE.EntityList AdvAboutBE
		{
			get
			{
				if (m_AdvAboutBE == null)
					m_AdvAboutBE = new AdvertisementApplyBE.AdvAboutBE.EntityList("AdvApplyBE",this,"AdvAboutBE",(IList)this.GetRelation("AdvAboutBE"));
				else
					m_AdvAboutBE.InnerList = (IList)this.GetRelation("AdvAboutBE");
				return m_AdvAboutBE;
			}
		}
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("AdvertisementApplyBE.AdvApplyBE")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvCode　{ get { return EntityRes.GetResource("AdvCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyDept")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyDept　{ get { return EntityRes.GetResource("ApplyDept");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Applier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Applier　{ get { return EntityRes.GetResource("Applier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyDate　{ get { return EntityRes.GetResource("ApplyDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Phone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Phone　{ get { return EntityRes.GetResource("Phone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("QQ")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_QQ　{ get { return EntityRes.GetResource("QQ");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustConterName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustConterName　{ get { return EntityRes.GetResource("CustConterName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LocationQY")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LocationQY　{ get { return EntityRes.GetResource("LocationQY");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LocationXZ")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LocationXZ　{ get { return EntityRes.GetResource("LocationXZ");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RelPeople")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RelPeople　{ get { return EntityRes.GetResource("RelPeople");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustPhone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustPhone　{ get { return EntityRes.GetResource("CustPhone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustAddress　{ get { return EntityRes.GetResource("CustAddress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvItem")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvItem　{ get { return EntityRes.GetResource("AdvItem");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalArea")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalArea　{ get { return EntityRes.GetResource("TotalArea");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BMWidth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BMWidth　{ get { return EntityRes.GetResource("BMWidth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BMHight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BMHight　{ get { return EntityRes.GetResource("BMHight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BMThick")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BMThick　{ get { return EntityRes.GetResource("BMThick");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BMArea")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BMArea　{ get { return EntityRes.GetResource("BMArea");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DZWidth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DZWidth　{ get { return EntityRes.GetResource("DZWidth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DZThick")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DZThick　{ get { return EntityRes.GetResource("DZThick");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DZArea")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DZArea　{ get { return EntityRes.GetResource("DZArea");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvDisplayType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvDisplayType　{ get { return EntityRes.GetResource("AdvDisplayType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvDispInfo1")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvDispInfo1　{ get { return EntityRes.GetResource("AdvDispInfo1");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvDispInfo2")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvDispInfo2　{ get { return EntityRes.GetResource("AdvDispInfo2");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvMemo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvMemo　{ get { return EntityRes.GetResource("AdvMemo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApproveQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApproveQty　{ get { return EntityRes.GetResource("ApproveQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvAboutBE")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvAboutBE　{ get { return EntityRes.GetResource("AdvAboutBE");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsClose")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsClose　{ get { return EntityRes.GetResource("IsClose");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "AdvApplyBE";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "AdvertisementApplyBE.AdvApplyBE";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 编号 的名称
			/// </summary>
			public static string AdvCode　{ get { return "AdvCode";　}　}
				
			/// <summary>
			/// 属性: 办事处 的名称
			/// </summary>
			public static string ApplyDept　{ get { return "ApplyDept";　}　}
				
			/// <summary>
			/// 属性: 下单人 的名称
			/// </summary>
			public static string Applier　{ get { return "Applier";　}　}
				
			/// <summary>
			/// 属性: 下单日期 的名称
			/// </summary>
			public static string ApplyDate　{ get { return "ApplyDate";　}　}
				
			/// <summary>
			/// 属性: 联系电话 的名称
			/// </summary>
			public static string Phone　{ get { return "Phone";　}　}
				
			/// <summary>
			/// 属性: QQ 的名称
			/// </summary>
			public static string QQ　{ get { return "QQ";　}　}
				
			/// <summary>
			/// 属性: 客户店名 的名称
			/// </summary>
			public static string CustConterName　{ get { return "CustConterName";　}　}
				
			/// <summary>
			/// 属性: 区域 的名称
			/// </summary>
			public static string LocationQY　{ get { return "LocationQY";　}　}
				
			/// <summary>
			/// 属性: 乡镇 的名称
			/// </summary>
			public static string LocationXZ　{ get { return "LocationXZ";　}　}
				
			/// <summary>
			/// 属性: 联系人 的名称
			/// </summary>
			public static string RelPeople　{ get { return "RelPeople";　}　}
				
			/// <summary>
			/// 属性: 客户联系电话 的名称
			/// </summary>
			public static string CustPhone　{ get { return "CustPhone";　}　}
				
			/// <summary>
			/// 属性: 客户地址 的名称
			/// </summary>
			public static string CustAddress　{ get { return "CustAddress";　}　}
				
			/// <summary>
			/// 属性: 广告载体 的名称
			/// </summary>
			public static string AdvItem　{ get { return "AdvItem";　}　}
				
			/// <summary>
			/// 属性: 总面积 的名称
			/// </summary>
			public static string TotalArea　{ get { return "TotalArea";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 版面-宽 的名称
			/// </summary>
			public static string BMWidth　{ get { return "BMWidth";　}　}
				
			/// <summary>
			/// 属性: 版面-高 的名称
			/// </summary>
			public static string BMHight　{ get { return "BMHight";　}　}
				
			/// <summary>
			/// 属性: 版面-厚 的名称
			/// </summary>
			public static string BMThick　{ get { return "BMThick";　}　}
				
			/// <summary>
			/// 属性: 版面-面积 的名称
			/// </summary>
			public static string BMArea　{ get { return "BMArea";　}　}
				
			/// <summary>
			/// 属性: 店招-宽 的名称
			/// </summary>
			public static string DZWidth　{ get { return "DZWidth";　}　}
				
			/// <summary>
			/// 属性: 店招-厚 的名称
			/// </summary>
			public static string DZThick　{ get { return "DZThick";　}　}
				
			/// <summary>
			/// 属性: 店招-面积 的名称
			/// </summary>
			public static string DZArea　{ get { return "DZArea";　}　}
				
			/// <summary>
			/// 属性: 版面类型 的名称
			/// </summary>
			public static string AdvDisplayType　{ get { return "AdvDisplayType";　}　}
				
			/// <summary>
			/// 属性: 版面要求1 的名称
			/// </summary>
			public static string AdvDispInfo1　{ get { return "AdvDispInfo1";　}　}
				
			/// <summary>
			/// 属性: 版面要求2 的名称
			/// </summary>
			public static string AdvDispInfo2　{ get { return "AdvDispInfo2";　}　}
				
			/// <summary>
			/// 属性: 客户排版文字信息 的名称
			/// </summary>
			public static string AdvMemo　{ get { return "AdvMemo";　}　}
				
			/// <summary>
			/// 属性: 核销数量 的名称
			/// </summary>
			public static string ApproveQty　{ get { return "ApproveQty";　}　}
				
			/// <summary>
			/// 属性: 广告体现项目子表 的名称
			/// </summary>
			public static string AdvAboutBE　{ get { return "AdvAboutBE";　}　}
				
			/// <summary>
			/// 属性: 关闭 的名称
			/// </summary>
			public static string IsClose　{ get { return "IsClose";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																																						
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("AdvCode","AdvCode");
			this.exdMultiLangAttrs.Add("ApplyDept","ApplyDept");
			this.exdMultiLangAttrs.Add("Applier","Applier");
			this.exdMultiLangAttrs.Add("ApplyDate","ApplyDate");
			this.exdMultiLangAttrs.Add("Phone","Phone");
			this.exdMultiLangAttrs.Add("QQ","QQ");
			this.exdMultiLangAttrs.Add("CustConterName","CustConterName");
			this.exdMultiLangAttrs.Add("LocationQY","LocationQY");
			this.exdMultiLangAttrs.Add("LocationXZ","LocationXZ");
			this.exdMultiLangAttrs.Add("RelPeople","RelPeople");
			this.exdMultiLangAttrs.Add("CustPhone","CustPhone");
			this.exdMultiLangAttrs.Add("CustAddress","CustAddress");
			this.exdMultiLangAttrs.Add("AdvItem","AdvItem");
			this.exdMultiLangAttrs.Add("TotalArea","TotalArea");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("BMWidth","BMWidth");
			this.exdMultiLangAttrs.Add("BMHight","BMHight");
			this.exdMultiLangAttrs.Add("BMThick","BMThick");
			this.exdMultiLangAttrs.Add("BMArea","BMArea");
			this.exdMultiLangAttrs.Add("DZWidth","DZWidth");
			this.exdMultiLangAttrs.Add("DZThick","DZThick");
			this.exdMultiLangAttrs.Add("DZArea","DZArea");
			this.exdMultiLangAttrs.Add("AdvDisplayType","AdvDisplayType");
			this.exdMultiLangAttrs.Add("AdvDispInfo1","AdvDispInfo1");
			this.exdMultiLangAttrs.Add("AdvDispInfo2","AdvDispInfo2");
			this.exdMultiLangAttrs.Add("AdvMemo","AdvMemo");
			this.exdMultiLangAttrs.Add("ApproveQty","ApproveQty");
			this.exdMultiLangAttrs.Add("IsClose","IsClose");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																																																						

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(AdvApplyBEData data)
		{
		
			

			

			

			

			

			

			

			if (data.ApplyDept == -1 && data.ApplyDept_SKey!=null)
				data.ApplyDept = data.ApplyDept_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			if (data.AdvItem == -1 && data.AdvItem_SKey!=null)
				data.AdvItem = data.AdvItem_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			AdvApplyBEData data = dto as AdvApplyBEData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(AdvApplyBEData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(AdvApplyBEData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("AdvCode",data.AdvCode);
		
								this.SetTypeValue("ApplyDept",data.ApplyDept);
		
								this.SetTypeValue("Applier",data.Applier);
		
								this.SetTypeValue("ApplyDate",data.ApplyDate);
		
								this.SetTypeValue("Phone",data.Phone);
		
								this.SetTypeValue("QQ",data.QQ);
		
								this.SetTypeValue("CustConterName",data.CustConterName);
		
								this.SetTypeValue("LocationQY",data.LocationQY);
		
								this.SetTypeValue("LocationXZ",data.LocationXZ);
		
								this.SetTypeValue("RelPeople",data.RelPeople);
		
								this.SetTypeValue("CustPhone",data.CustPhone);
		
								this.SetTypeValue("CustAddress",data.CustAddress);
		
								this.SetTypeValue("AdvItem",data.AdvItem);
		
								this.SetTypeValue("TotalArea",data.TotalArea);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("BMWidth",data.BMWidth);
		
								this.SetTypeValue("BMHight",data.BMHight);
		
								this.SetTypeValue("BMThick",data.BMThick);
		
								this.SetTypeValue("BMArea",data.BMArea);
		
								this.SetTypeValue("DZWidth",data.DZWidth);
		
								this.SetTypeValue("DZThick",data.DZThick);
		
								this.SetTypeValue("DZArea",data.DZArea);
		
								this.SetTypeValue("AdvDispInfo1",data.AdvDispInfo1);
		
								this.SetTypeValue("AdvDispInfo2",data.AdvDispInfo2);
		
								this.SetTypeValue("AdvMemo",data.AdvMemo);
		
								this.SetTypeValue("ApproveQty",data.ApproveQty);
		
								this.SetTypeValue("IsClose",data.IsClose);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("AdvDisplayType",data.AdvDisplayType);
	     

					if (data.AdvAboutBE != null)
			{	
				foreach(AdvertisementApplyBE.AdvAboutBEData obj in data.AdvAboutBE )
				{
					AdvertisementApplyBE.AdvAboutBE child = dict[obj] as AdvertisementApplyBE.AdvAboutBE;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (AdvertisementApplyBE.AdvAboutBE)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (AdvertisementApplyBE.AdvAboutBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (AdvertisementApplyBE.AdvAboutBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.AdvAboutBE.Remove(child);
						this.AdvAboutBE.DelLists.Add(child);
					}
					else
						this.AdvAboutBE.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public AdvApplyBEData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AdvApplyBEData ToEntityData(AdvApplyBEData data, IDictionary dict){
			if (data == null)
				data = new AdvApplyBEData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["AdvertisementApplyBE.AdvApplyBE"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvCode");
				if (obj != null)
					data.AdvCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyDept");
				if (obj != null)
					data.ApplyDept=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Applier");
				if (obj != null)
					data.Applier=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyDate");
				if (obj != null)
					data.ApplyDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Phone");
				if (obj != null)
					data.Phone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("QQ");
				if (obj != null)
					data.QQ=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustConterName");
				if (obj != null)
					data.CustConterName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("LocationQY");
				if (obj != null)
					data.LocationQY=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("LocationXZ");
				if (obj != null)
					data.LocationXZ=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RelPeople");
				if (obj != null)
					data.RelPeople=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustPhone");
				if (obj != null)
					data.CustPhone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustAddress");
				if (obj != null)
					data.CustAddress=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvItem");
				if (obj != null)
					data.AdvItem=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalArea");
				if (obj != null)
					data.TotalArea=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BMWidth");
				if (obj != null)
					data.BMWidth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BMHight");
				if (obj != null)
					data.BMHight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BMThick");
				if (obj != null)
					data.BMThick=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BMArea");
				if (obj != null)
					data.BMArea=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DZWidth");
				if (obj != null)
					data.DZWidth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DZThick");
				if (obj != null)
					data.DZThick=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DZArea");
				if (obj != null)
					data.DZArea=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvDispInfo1");
				if (obj != null)
					data.AdvDispInfo1=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvDispInfo2");
				if (obj != null)
					data.AdvDispInfo2=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvMemo");
				if (obj != null)
					data.AdvMemo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApproveQty");
				if (obj != null)
					data.ApproveQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsClose");
				if (obj != null)
					data.IsClose=(System.Boolean)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("AdvDisplayType");
				if (obj != null)
					data.AdvDisplayType=System.Int32.Parse(obj.ToString());
			}
	
			if (this.AdvAboutBE != null)
			{	
				List<AdvertisementApplyBE.AdvAboutBEData> listAdvAboutBE = new List<AdvertisementApplyBE.AdvAboutBEData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(AdvertisementApplyBE.AdvAboutBE obj in this.AdvAboutBE ){
					if (obj == null)
						continue;
					AdvertisementApplyBE.AdvAboutBEData old = dict["AdvertisementApplyBE.AdvAboutBE"+obj.ID.ToString()] as AdvertisementApplyBE.AdvAboutBEData;
					listAdvAboutBE.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.AdvAboutBE = listAdvAboutBE;
			}	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        



































			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (string.IsNullOrEmpty((string)base.GetValue("AdvCode"))){
				UFSoft.UBF.Business.AttributeInValidException AdvCode_Exception =new UFSoft.UBF.Business.AttributeInValidException("AdvertisementApplyBE.AdvApplyBE","AdvCode","1c849172-7572-4b06-aad1-26c6201b14b8");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					AdvCode_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(AdvCode_Exception);
			}

			if (Convert.ToInt64(base.GetValue("ApplyDept")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException ApplyDept_Exception = new UFSoft.UBF.Business.AttributeInValidException("AdvertisementApplyBE.AdvApplyBE","ApplyDept","712732a7-1c9b-4204-955d-3f28614ec0bb");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					ApplyDept_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(ApplyDept_Exception);
			}


			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}