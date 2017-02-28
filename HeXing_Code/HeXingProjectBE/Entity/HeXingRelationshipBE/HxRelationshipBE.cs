using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
	
	/// <summary>
	/// 实体: 合兴关系对照表
	/// 
	/// </summary>
	[Serializable]	
	public  partial class HxRelationshipBE : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public HxRelationshipBE(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static HxRelationshipBE Create() {
			HxRelationshipBE entity = (HxRelationshipBE)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																					 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected HxRelationshipBE(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static HxRelationshipBE CreateDefault() {
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
		public static HxRelationshipBE CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class HxRelationshipBE EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new HxRelationshipBE GetEntity()
			{
				return (HxRelationshipBE)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<HxRelationshipBE> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<HxRelationshipBE>{
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
		    //private HxRelationshipBE ContainerEntity ;
		    public  new HxRelationshipBE ContainerEntity 
		    {
				get { return  (HxRelationshipBE)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(HxRelationshipBE container)
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
			/// 合兴关系对照表.Key.ID
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
			/// 合兴关系对照表.Sys.创建时间
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
			/// 合兴关系对照表.Sys.创建人
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
			/// 合兴关系对照表.Sys.修改时间
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
			/// 合兴关系对照表.Sys.修改人
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
			/// 合兴关系对照表.Sys.事务版本
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
			/// 对照类型 (该属性可为空,但有默认值)
			/// 合兴关系对照表.Misc.对照类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum RefType
			{
				get
				{

					UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum value  = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum.GetFromValue(base.GetValue("RefType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SAP编码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.SAP编码
			/// </summary>
			/// <value></value>
			public  System.String SapCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SAP名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.SAP名称
			/// </summary>
			/// <value></value>
			public  System.String SapName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SAP公司代码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.SAP公司代码
			/// </summary>
			/// <value></value>
			public  System.String SapCompCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapCompCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SAP公司名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.SAP公司名称
			/// </summary>
			/// <value></value>
			public  System.String SapCompName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapCompName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料组编码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.物料组编码
			/// </summary>
			/// <value></value>
			public  System.String SapMasterCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapMasterCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料组名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.物料组名称
			/// </summary>
			/// <value></value>
			public  System.String SapMasterName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapMasterName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 资产编码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.资产编码
			/// </summary>
			/// <value></value>
			public  System.String SapAssetsCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapAssetsCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 资产名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.资产名称
			/// </summary>
			/// <value></value>
			public  System.String SapAssetsName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapAssetsName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用类型编码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.费用类型编码
			/// </summary>
			/// <value></value>
			public  System.String SapFeeCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapFeeCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用类型名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.费用类型名称
			/// </summary>
			/// <value></value>
			public  System.String SapFeeName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SapFeeName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// U9编码 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.U9编码
			/// </summary>
			/// <value></value>
			public  System.String U9Code
			{
				get
				{
					System.String value  = (System.String)base.GetValue("U9Code");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// U9名称 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.U9名称
			/// </summary>
			/// <value></value>
			public  System.String U9Name
			{
				get
				{
					System.String value  = (System.String)base.GetValue("U9Name");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// U9实体ID (该属性可为空,但有默认值)
			/// 合兴关系对照表.Misc.U9实体ID
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency U9EntityId
			{
				get
				{
					if (U9EntityIdKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)U9EntityIdKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_U9EntityIdKey ;
		/// <summary>
		/// EntityKey 属性
		/// U9实体ID 的Key (该属性可为空,但有默认值)
		/// 合兴关系对照表.Misc.U9实体ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey U9EntityIdKey
		{
			get 
			{
				object obj = base.GetValue("U9EntityId") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_U9EntityIdKey==null || m_U9EntityIdKey.ID != key )
					m_U9EntityIdKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_U9EntityIdKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 合兴关系对照表.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Memo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Memo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 合兴关系对照表.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum RefStatus
			{
				get
				{

					UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum value  = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum.GetFromValue(base.GetValue("RefStatus"));
					return value;
				}
			}
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 合兴关系对照表.Key.ID
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
		/// 合兴关系对照表.Sys.创建时间
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
		/// 合兴关系对照表.Sys.创建人
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
		/// 合兴关系对照表.Sys.修改时间
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
		/// 合兴关系对照表.Sys.修改人
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
		/// 合兴关系对照表.Sys.事务版本
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
		/// 对照类型 (该属性可为空,但有默认值)
		/// 合兴关系对照表.Misc.对照类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum RefType
		{
			get
			{

				UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum value  = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum.GetFromValue(base.GetValue("RefType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("RefType",UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum.Empty.Value);
				else
					base.SetValue("RefType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// SAP编码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.SAP编码
		/// </summary>
		/// <value></value>
			public  System.String SapCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapCode");
				return value;
				}
				set
			{
				
								base.SetValue("SapCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// SAP名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.SAP名称
		/// </summary>
		/// <value></value>
			public  System.String SapName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapName");
				return value;
				}
				set
			{
				
								base.SetValue("SapName", value);
						 
			}
		}
	



		
			/// <summary>
		/// SAP公司代码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.SAP公司代码
		/// </summary>
		/// <value></value>
			public  System.String SapCompCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapCompCode");
				return value;
				}
				set
			{
				
								base.SetValue("SapCompCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// SAP公司名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.SAP公司名称
		/// </summary>
		/// <value></value>
			public  System.String SapCompName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapCompName");
				return value;
				}
				set
			{
				
								base.SetValue("SapCompName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料组编码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.物料组编码
		/// </summary>
		/// <value></value>
			public  System.String SapMasterCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapMasterCode");
				return value;
				}
				set
			{
				
								base.SetValue("SapMasterCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料组名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.物料组名称
		/// </summary>
		/// <value></value>
			public  System.String SapMasterName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapMasterName");
				return value;
				}
				set
			{
				
								base.SetValue("SapMasterName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 资产编码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.资产编码
		/// </summary>
		/// <value></value>
			public  System.String SapAssetsCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapAssetsCode");
				return value;
				}
				set
			{
				
								base.SetValue("SapAssetsCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 资产名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.资产名称
		/// </summary>
		/// <value></value>
			public  System.String SapAssetsName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapAssetsName");
				return value;
				}
				set
			{
				
								base.SetValue("SapAssetsName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用类型编码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.费用类型编码
		/// </summary>
		/// <value></value>
			public  System.String SapFeeCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapFeeCode");
				return value;
				}
				set
			{
				
								base.SetValue("SapFeeCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用类型名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.费用类型名称
		/// </summary>
		/// <value></value>
			public  System.String SapFeeName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SapFeeName");
				return value;
				}
				set
			{
				
								base.SetValue("SapFeeName", value);
						 
			}
		}
	



		
			/// <summary>
		/// U9编码 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.U9编码
		/// </summary>
		/// <value></value>
			public  System.String U9Code
		{
			get
			{
				System.String value  = (System.String)base.GetValue("U9Code");
				return value;
				}
				set
			{
				
								base.SetValue("U9Code", value);
						 
			}
		}
	



		
			/// <summary>
		/// U9名称 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.U9名称
		/// </summary>
		/// <value></value>
			public  System.String U9Name
		{
			get
			{
				System.String value  = (System.String)base.GetValue("U9Name");
				return value;
				}
				set
			{
				
								base.SetValue("U9Name", value);
						 
			}
		}
	



		
			/// <summary>
		/// U9实体ID (该属性可为空,但有默认值)
		/// 合兴关系对照表.Misc.U9实体ID
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency U9EntityId
		{
			get
			{
				object  obj = this.GetRelation("U9EntityId");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Currency.Currency value  = (UFIDA.U9.Base.Currency.Currency)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("U9EntityId", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_U9EntityIdKey ;
		/// <summary>
		/// U9实体ID 的Key (该属性可为空,但有默认值)
		/// 合兴关系对照表.Misc.U9实体ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey U9EntityIdKey
		{
			get 
			{
				object obj = base.GetValue("U9EntityId") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_U9EntityIdKey==null || m_U9EntityIdKey.ID != key )
					m_U9EntityIdKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_U9EntityIdKey ;
			}
			set
			{	
				if (U9EntityIdKey==value)
					return ;
				this.SetRelation("U9EntityId", null);
				m_U9EntityIdKey = value ;
				if (value != null) 
				{
					base.SetValue("U9EntityId",value.ID);
				}
				else
					base.SetValue("U9EntityId",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 合兴关系对照表.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Memo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Memo");
				return value;
				}
				set
			{
				
								base.SetValue("Memo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 合兴关系对照表.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum RefStatus
		{
			get
			{

				UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum value  = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum.GetFromValue(base.GetValue("RefStatus"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("RefStatus",UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum.Empty.Value);
				else
					base.SetValue("RefStatus",value.Value);
					 
			}
		}
	



	

		#endregion

		#region List member						
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RefType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RefType　{ get { return EntityRes.GetResource("RefType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapCode　{ get { return EntityRes.GetResource("SapCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapName　{ get { return EntityRes.GetResource("SapName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapCompCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapCompCode　{ get { return EntityRes.GetResource("SapCompCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapCompName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapCompName　{ get { return EntityRes.GetResource("SapCompName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapMasterCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapMasterCode　{ get { return EntityRes.GetResource("SapMasterCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapMasterName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapMasterName　{ get { return EntityRes.GetResource("SapMasterName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapAssetsCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapAssetsCode　{ get { return EntityRes.GetResource("SapAssetsCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapAssetsName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapAssetsName　{ get { return EntityRes.GetResource("SapAssetsName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapFeeCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapFeeCode　{ get { return EntityRes.GetResource("SapFeeCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SapFeeName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SapFeeName　{ get { return EntityRes.GetResource("SapFeeName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("U9Code")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_U9Code　{ get { return EntityRes.GetResource("U9Code");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("U9Name")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_U9Name　{ get { return EntityRes.GetResource("U9Name");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("U9EntityId")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_U9EntityId　{ get { return EntityRes.GetResource("U9EntityId");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RefStatus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RefStatus　{ get { return EntityRes.GetResource("RefStatus");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "HxRelationshipBE";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE";　}　}
		
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
			/// 属性: 对照类型 的名称
			/// </summary>
			public static string RefType　{ get { return "RefType";　}　}
				
			/// <summary>
			/// 属性: SAP编码 的名称
			/// </summary>
			public static string SapCode　{ get { return "SapCode";　}　}
				
			/// <summary>
			/// 属性: SAP名称 的名称
			/// </summary>
			public static string SapName　{ get { return "SapName";　}　}
				
			/// <summary>
			/// 属性: SAP公司代码 的名称
			/// </summary>
			public static string SapCompCode　{ get { return "SapCompCode";　}　}
				
			/// <summary>
			/// 属性: SAP公司名称 的名称
			/// </summary>
			public static string SapCompName　{ get { return "SapCompName";　}　}
				
			/// <summary>
			/// 属性: 物料组编码 的名称
			/// </summary>
			public static string SapMasterCode　{ get { return "SapMasterCode";　}　}
				
			/// <summary>
			/// 属性: 物料组名称 的名称
			/// </summary>
			public static string SapMasterName　{ get { return "SapMasterName";　}　}
				
			/// <summary>
			/// 属性: 资产编码 的名称
			/// </summary>
			public static string SapAssetsCode　{ get { return "SapAssetsCode";　}　}
				
			/// <summary>
			/// 属性: 资产名称 的名称
			/// </summary>
			public static string SapAssetsName　{ get { return "SapAssetsName";　}　}
				
			/// <summary>
			/// 属性: 费用类型编码 的名称
			/// </summary>
			public static string SapFeeCode　{ get { return "SapFeeCode";　}　}
				
			/// <summary>
			/// 属性: 费用类型名称 的名称
			/// </summary>
			public static string SapFeeName　{ get { return "SapFeeName";　}　}
				
			/// <summary>
			/// 属性: U9编码 的名称
			/// </summary>
			public static string U9Code　{ get { return "U9Code";　}　}
				
			/// <summary>
			/// 属性: U9名称 的名称
			/// </summary>
			public static string U9Name　{ get { return "U9Name";　}　}
				
			/// <summary>
			/// 属性: U9实体ID 的名称
			/// </summary>
			public static string U9EntityId　{ get { return "U9EntityId";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string RefStatus　{ get { return "RefStatus";　}　}
		
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
			this.exdMultiLangAttrs.Add("RefType","RefType");
			this.exdMultiLangAttrs.Add("SapCode","SapCode");
			this.exdMultiLangAttrs.Add("SapName","SapName");
			this.exdMultiLangAttrs.Add("SapCompCode","SapCompCode");
			this.exdMultiLangAttrs.Add("SapCompName","SapCompName");
			this.exdMultiLangAttrs.Add("SapMasterCode","SapMasterCode");
			this.exdMultiLangAttrs.Add("SapMasterName","SapMasterName");
			this.exdMultiLangAttrs.Add("SapAssetsCode","SapAssetsCode");
			this.exdMultiLangAttrs.Add("SapAssetsName","SapAssetsName");
			this.exdMultiLangAttrs.Add("SapFeeCode","SapFeeCode");
			this.exdMultiLangAttrs.Add("SapFeeName","SapFeeName");
			this.exdMultiLangAttrs.Add("U9Code","U9Code");
			this.exdMultiLangAttrs.Add("U9Name","U9Name");
			this.exdMultiLangAttrs.Add("U9EntityId","U9EntityId");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("RefStatus","RefStatus");
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
		private void DeSerializeKey(HxRelationshipBEData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.U9EntityId == -1 && data.U9EntityId_SKey!=null)
				data.U9EntityId = data.U9EntityId_SKey.GetEntity().ID ;
	

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			HxRelationshipBEData data = dto as HxRelationshipBEData ;
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
		public void FromEntityData(HxRelationshipBEData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(HxRelationshipBEData data,IDictionary dict)
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
		
								this.SetTypeValue("SapCode",data.SapCode);
		
								this.SetTypeValue("SapName",data.SapName);
		
								this.SetTypeValue("SapCompCode",data.SapCompCode);
		
								this.SetTypeValue("SapCompName",data.SapCompName);
		
								this.SetTypeValue("SapMasterCode",data.SapMasterCode);
		
								this.SetTypeValue("SapMasterName",data.SapMasterName);
		
								this.SetTypeValue("SapAssetsCode",data.SapAssetsCode);
		
								this.SetTypeValue("SapAssetsName",data.SapAssetsName);
		
								this.SetTypeValue("SapFeeCode",data.SapFeeCode);
		
								this.SetTypeValue("SapFeeName",data.SapFeeName);
		
								this.SetTypeValue("U9Code",data.U9Code);
		
								this.SetTypeValue("U9Name",data.U9Name);
		
								this.SetTypeValue("U9EntityId",data.U9EntityId);
		
								this.SetTypeValue("Memo",data.Memo);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("RefType",data.RefType);
	     

					this.SetTypeValue("RefStatus",data.RefStatus);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public HxRelationshipBEData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public HxRelationshipBEData ToEntityData(HxRelationshipBEData data, IDictionary dict){
			if (data == null)
				data = new HxRelationshipBEData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("SapCode");
				if (obj != null)
					data.SapCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapName");
				if (obj != null)
					data.SapName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapCompCode");
				if (obj != null)
					data.SapCompCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapCompName");
				if (obj != null)
					data.SapCompName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapMasterCode");
				if (obj != null)
					data.SapMasterCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapMasterName");
				if (obj != null)
					data.SapMasterName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapAssetsCode");
				if (obj != null)
					data.SapAssetsCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapAssetsName");
				if (obj != null)
					data.SapAssetsName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapFeeCode");
				if (obj != null)
					data.SapFeeCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SapFeeName");
				if (obj != null)
					data.SapFeeName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("U9Code");
				if (obj != null)
					data.U9Code=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("U9Name");
				if (obj != null)
					data.U9Name=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("U9EntityId");
				if (obj != null)
					data.U9EntityId=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("RefType");
				if (obj != null)
					data.RefType=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("RefStatus");
				if (obj != null)
					data.RefStatus=System.Int32.Parse(obj.ToString());
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
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}