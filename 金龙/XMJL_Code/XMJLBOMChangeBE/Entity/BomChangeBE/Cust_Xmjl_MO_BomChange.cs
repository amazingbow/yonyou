using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomChangeBE
{
	
	/// <summary>
	/// 实体: 缺件变更单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class Cust_Xmjl_MO_BomChange : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomChange(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static Cust_Xmjl_MO_BomChange Create() {
			Cust_Xmjl_MO_BomChange entity = (Cust_Xmjl_MO_BomChange)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																		 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected Cust_Xmjl_MO_BomChange(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static Cust_Xmjl_MO_BomChange CreateDefault() {
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
		public static Cust_Xmjl_MO_BomChange CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class Cust_Xmjl_MO_BomChange EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new Cust_Xmjl_MO_BomChange GetEntity()
			{
				return (Cust_Xmjl_MO_BomChange)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<Cust_Xmjl_MO_BomChange> 
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









			/// <summary>
			/// 业务主键查询参数类型
			/// </summary>
			public class BusinessKeyParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public Cust_Xmjl_MO_BomChange FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public Cust_Xmjl_MO_BomChange FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public Cust_Xmjl_MO_BomChange FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_XMJLBomChangeBE_Cust_Xmjl_MO_BomChange_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_XMJLBomChangeBE_Cust_Xmjl_MO_BomChange_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public Cust_Xmjl_MO_BomChange FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<Cust_Xmjl_MO_BomChange>{
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
		
		public new partial class EntityOriginal:  UFIDA.U9.Base.Doc.Doc.EntityOriginal
		{
		    //private Cust_Xmjl_MO_BomChange ContainerEntity ;
		    public  new Cust_Xmjl_MO_BomChange ContainerEntity 
		    {
				get { return  (Cust_Xmjl_MO_BomChange)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(Cust_Xmjl_MO_BomChange container):base(container)
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
			/// 变更原因 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.变更原因
			/// </summary>
			/// <value></value>
			public  System.String ChangeReason
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ChangeReason");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 变更时间 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.变更时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ChangeDateTime
			{
				get
				{
					object obj = base.GetValue("ChangeDateTime");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 变更状态 (该属性可为空,但有默认值)
			/// 缺件变更单.Misc.变更状态
			/// </summary>
			/// <value></value>
			public  System.Boolean ChangeStat
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("ChangeStat");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 变更单据类型 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.变更单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType ChangeDocType
			{
				get
				{
					if (ChangeDocTypeKey == null)
						return null ;
					UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType value =  (UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType)ChangeDocTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey m_ChangeDocTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 变更单据类型 的Key (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey ChangeDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("ChangeDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChangeDocTypeKey==null || m_ChangeDocTypeKey.ID != key )
					m_ChangeDocTypeKey = new UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey(key); 
				return m_ChangeDocTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 变更人 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.变更人
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UserRole.User ChangePerson
			{
				get
				{
					if (ChangePersonKey == null)
						return null ;
					UFIDA.U9.Base.UserRole.User value =  (UFIDA.U9.Base.UserRole.User)ChangePersonKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UserRole.User.EntityKey m_ChangePersonKey ;
		/// <summary>
		/// EntityKey 属性
		/// 变更人 的Key (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UserRole.User.EntityKey ChangePersonKey
		{
			get 
			{
				object obj = base.GetValue("ChangePerson") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChangePersonKey==null || m_ChangePersonKey.ID != key )
					m_ChangePersonKey = new UFIDA.U9.Base.UserRole.User.EntityKey(key); 
				return m_ChangePersonKey ;
			}
		}

		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem> m_Cust_Xmjl_MO_BomChangeItem  ;
			/// <summary>
			/// 缺件变更料号行 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.缺件变更料号行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem> Cust_Xmjl_MO_BomChangeItem
			{
				get
				{
					if (m_Cust_Xmjl_MO_BomChangeItem == null)
						m_Cust_Xmjl_MO_BomChangeItem = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem>();
					m_Cust_Xmjl_MO_BomChangeItem.Clear();	
					foreach (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem child in ContainerEntity.Cust_Xmjl_MO_BomChangeItem)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_Cust_Xmjl_MO_BomChangeItem.Add(child);
					}
					foreach (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem child in ContainerEntity.Cust_Xmjl_MO_BomChangeItem.DelLists)
					{
						m_Cust_Xmjl_MO_BomChangeItem.Add(child);
					}
					return m_Cust_Xmjl_MO_BomChangeItem;
				}
			}
		
			
			private List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo> m_Cust_Xmjl_MO_BomChangeManufactureNo  ;
			/// <summary>
			/// 缺件变更车号行 (该属性可为空,且无默认值)
			/// 缺件变更单.Misc.缺件变更车号行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo> Cust_Xmjl_MO_BomChangeManufactureNo
			{
				get
				{
					if (m_Cust_Xmjl_MO_BomChangeManufactureNo == null)
						m_Cust_Xmjl_MO_BomChangeManufactureNo = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo>();
					m_Cust_Xmjl_MO_BomChangeManufactureNo.Clear();	
					foreach (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo child in ContainerEntity.Cust_Xmjl_MO_BomChangeManufactureNo)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_Cust_Xmjl_MO_BomChangeManufactureNo.Add(child);
					}
					foreach (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo child in ContainerEntity.Cust_Xmjl_MO_BomChangeManufactureNo.DelLists)
					{
						m_Cust_Xmjl_MO_BomChangeManufactureNo.Add(child);
					}
					return m_Cust_Xmjl_MO_BomChangeManufactureNo;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 变更原因 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更原因
		/// </summary>
		/// <value></value>
			public  System.String ChangeReason
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ChangeReason");
				return value;
				}
				set
			{
				
								base.SetValue("ChangeReason", value);
						 
			}
		}
	



		
			/// <summary>
		/// 变更时间 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ChangeDateTime
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ChangeDateTime");
				return value;
				}
				set
			{
				
								base.SetValue("ChangeDateTime", value);
						 
			}
		}
	



		
			/// <summary>
		/// 变更状态 (该属性可为空,但有默认值)
		/// 缺件变更单.Misc.变更状态
		/// </summary>
		/// <value></value>
			public  System.Boolean ChangeStat
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("ChangeStat");
				return value;
				}
				set
			{
				
								base.SetValue("ChangeStat", value);
						 
			}
		}
	



		
			/// <summary>
		/// 变更单据类型 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType ChangeDocType
		{
			get
			{
				object  obj = this.GetRelation("ChangeDocType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType value  = (UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ChangeDocType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey m_ChangeDocTypeKey ;
		/// <summary>
		/// 变更单据类型 的Key (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey ChangeDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("ChangeDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChangeDocTypeKey==null || m_ChangeDocTypeKey.ID != key )
					m_ChangeDocTypeKey = new UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType.EntityKey(key); 
				return m_ChangeDocTypeKey ;
			}
			set
			{	
				if (ChangeDocTypeKey==value)
					return ;
				this.SetRelation("ChangeDocType", null);
				m_ChangeDocTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("ChangeDocType",value.ID);
				}
				else
					base.SetValue("ChangeDocType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 变更人 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更人
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UserRole.User ChangePerson
		{
			get
			{
				object  obj = this.GetRelation("ChangePerson");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.UserRole.User value  = (UFIDA.U9.Base.UserRole.User)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ChangePerson", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UserRole.User.EntityKey m_ChangePersonKey ;
		/// <summary>
		/// 变更人 的Key (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.变更人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UserRole.User.EntityKey ChangePersonKey
		{
			get 
			{
				object obj = base.GetValue("ChangePerson") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ChangePersonKey==null || m_ChangePersonKey.ID != key )
					m_ChangePersonKey = new UFIDA.U9.Base.UserRole.User.EntityKey(key); 
				return m_ChangePersonKey ;
			}
			set
			{	
				if (ChangePersonKey==value)
					return ;
				this.SetRelation("ChangePerson", null);
				m_ChangePersonKey = value ;
				if (value != null) 
				{
					base.SetValue("ChangePerson",value.ID);
				}
				else
					base.SetValue("ChangePerson",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem.EntityList m_Cust_Xmjl_MO_BomChangeItem  ;
		/// <summary>
		/// 缺件变更料号行 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.缺件变更料号行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem.EntityList Cust_Xmjl_MO_BomChangeItem
		{
			get
			{
				if (m_Cust_Xmjl_MO_BomChangeItem == null)
					m_Cust_Xmjl_MO_BomChangeItem = new UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem.EntityList("Cust_Xmjl_MO_BomChange",this,"Cust_Xmjl_MO_BomChangeItem",(IList)this.GetRelation("Cust_Xmjl_MO_BomChangeItem"));
				else
					m_Cust_Xmjl_MO_BomChangeItem.InnerList = (IList)this.GetRelation("Cust_Xmjl_MO_BomChangeItem");
				return m_Cust_Xmjl_MO_BomChangeItem;
			}
		}
	
		
		private UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo.EntityList m_Cust_Xmjl_MO_BomChangeManufactureNo  ;
		/// <summary>
		/// 缺件变更车号行 (该属性可为空,且无默认值)
		/// 缺件变更单.Misc.缺件变更车号行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo.EntityList Cust_Xmjl_MO_BomChangeManufactureNo
		{
			get
			{
				if (m_Cust_Xmjl_MO_BomChangeManufactureNo == null)
					m_Cust_Xmjl_MO_BomChangeManufactureNo = new UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo.EntityList("Cust_Xmjl_MO_BomChange",this,"Cust_Xmjl_MO_BomChangeManufactureNo",(IList)this.GetRelation("Cust_Xmjl_MO_BomChangeManufactureNo"));
				else
					m_Cust_Xmjl_MO_BomChangeManufactureNo.InnerList = (IList)this.GetRelation("Cust_Xmjl_MO_BomChangeManufactureNo");
				return m_Cust_Xmjl_MO_BomChangeManufactureNo;
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
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Cust_Xmjl_MO_BomChangeItem")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Cust_Xmjl_MO_BomChangeItem　{ get { return EntityRes.GetResource("Cust_Xmjl_MO_BomChangeItem");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Cust_Xmjl_MO_BomChangeManufactureNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Cust_Xmjl_MO_BomChangeManufactureNo　{ get { return EntityRes.GetResource("Cust_Xmjl_MO_BomChangeManufactureNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangeReason")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangeReason　{ get { return EntityRes.GetResource("ChangeReason");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangeDateTime")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangeDateTime　{ get { return EntityRes.GetResource("ChangeDateTime");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangeStat")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangeStat　{ get { return EntityRes.GetResource("ChangeStat");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangeDocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangeDocType　{ get { return EntityRes.GetResource("ChangeDocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangePerson")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangePerson　{ get { return EntityRes.GetResource("ChangePerson");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "Cust_Xmjl_MO_BomChange";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange";　}　}
		
			/// <summary>
			/// 属性: 缺件变更料号行 的名称
			/// </summary>
			public static string Cust_Xmjl_MO_BomChangeItem　{ get { return "Cust_Xmjl_MO_BomChangeItem";　}　}
				
			/// <summary>
			/// 属性: 缺件变更车号行 的名称
			/// </summary>
			public static string Cust_Xmjl_MO_BomChangeManufactureNo　{ get { return "Cust_Xmjl_MO_BomChangeManufactureNo";　}　}
				
			/// <summary>
			/// 属性: 变更原因 的名称
			/// </summary>
			public static string ChangeReason　{ get { return "ChangeReason";　}　}
				
			/// <summary>
			/// 属性: 变更时间 的名称
			/// </summary>
			public static string ChangeDateTime　{ get { return "ChangeDateTime";　}　}
				
			/// <summary>
			/// 属性: 变更状态 的名称
			/// </summary>
			public static string ChangeStat　{ get { return "ChangeStat";　}　}
				
			/// <summary>
			/// 属性: 变更单据类型 的名称
			/// </summary>
			public static string ChangeDocType　{ get { return "ChangeDocType";　}　}
				
			/// <summary>
			/// 属性: 变更人 的名称
			/// </summary>
			public static string ChangePerson　{ get { return "ChangePerson";　}　}
		
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
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("DocNo","DocNo");
			this.exdMultiLangAttrs.Add("BusinessDate","BusinessDate");
			this.exdMultiLangAttrs.Add("Version","Version");
			this.exdMultiLangAttrs.Add("PrintAmount","PrintAmount");
			this.exdMultiLangAttrs.Add("LatestPrintedDate","LatestPrintedDate");
			this.exdMultiLangAttrs.Add("Cancel.Canceled","Cancel_Canceled");
			this.exdMultiLangAttrs.Add("Cancel.CancelDate","Cancel_CancelDate");
			this.exdMultiLangAttrs.Add("Cancel.CancelReason","Cancel_CancelReason");
			this.exdMultiLangAttrs.Add("Cancel.CancelUser","Cancel_CancelUser");
			this.exdMultiLangAttrs.Add("WorkFlowID","WorkFlowID");
			this.exdMultiLangAttrs.Add("StateMachineID","StateMachineID");
			this.exdMultiLangAttrs.Add("HoldReason","HoldReason");
			this.exdMultiLangAttrs.Add("HoldUser","HoldUser");
			this.exdMultiLangAttrs.Add("HoldDate","HoldDate");
			this.exdMultiLangAttrs.Add("ReleaseReason","ReleaseReason");
			this.exdMultiLangAttrs.Add("ReleaseUser","ReleaseUser");
			this.exdMultiLangAttrs.Add("ReleaseDate","ReleaseDate");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg1","DescFlexField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg2","DescFlexField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg3","DescFlexField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg4","DescFlexField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg5","DescFlexField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg6","DescFlexField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg7","DescFlexField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg8","DescFlexField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg9","DescFlexField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg10","DescFlexField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg11","DescFlexField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg12","DescFlexField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg13","DescFlexField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg14","DescFlexField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg15","DescFlexField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg16","DescFlexField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg17","DescFlexField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg18","DescFlexField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg19","DescFlexField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg20","DescFlexField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg21","DescFlexField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg22","DescFlexField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg23","DescFlexField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg24","DescFlexField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg25","DescFlexField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg26","DescFlexField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg27","DescFlexField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg28","DescFlexField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg29","DescFlexField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg30","DescFlexField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg31","DescFlexField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg32","DescFlexField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg33","DescFlexField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg34","DescFlexField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg35","DescFlexField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg36","DescFlexField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg37","DescFlexField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg38","DescFlexField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg39","DescFlexField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg40","DescFlexField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg41","DescFlexField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg42","DescFlexField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg43","DescFlexField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg44","DescFlexField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg45","DescFlexField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg46","DescFlexField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg47","DescFlexField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg48","DescFlexField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg49","DescFlexField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg50","DescFlexField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexField.ContextValue","DescFlexField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg1","DescFlexField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg2","DescFlexField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg3","DescFlexField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg4","DescFlexField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg5","DescFlexField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg6","DescFlexField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg7","DescFlexField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg8","DescFlexField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg9","DescFlexField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg10","DescFlexField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg11","DescFlexField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg12","DescFlexField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg13","DescFlexField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg14","DescFlexField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg15","DescFlexField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg16","DescFlexField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg17","DescFlexField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg18","DescFlexField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg19","DescFlexField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg20","DescFlexField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg21","DescFlexField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg22","DescFlexField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg23","DescFlexField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg24","DescFlexField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg25","DescFlexField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg26","DescFlexField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg27","DescFlexField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg28","DescFlexField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg29","DescFlexField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg30","DescFlexField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexField.CombineName","DescFlexField_CombineName");
			this.exdMultiLangAttrs.Add("FlowInstance","FlowInstance");
			this.exdMultiLangAttrs.Add("ChangeReason","ChangeReason");
			this.exdMultiLangAttrs.Add("ChangeDateTime","ChangeDateTime");
			this.exdMultiLangAttrs.Add("ChangeStat","ChangeStat");
			this.exdMultiLangAttrs.Add("ChangeDocType","ChangeDocType");
			this.exdMultiLangAttrs.Add("ChangePerson","ChangePerson");
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
		private void DeSerializeKey(Cust_Xmjl_MO_BomChangeData data)
		{
		
			

			

			

			if (data.ChangeDocType == -1 && data.ChangeDocType_SKey!=null)
				data.ChangeDocType = data.ChangeDocType_SKey.GetEntity().ID ;
	

			if (data.ChangePerson == -1 && data.ChangePerson_SKey!=null)
				data.ChangePerson = data.ChangePerson_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			Cust_Xmjl_MO_BomChangeData data = dto as Cust_Xmjl_MO_BomChangeData ;
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
		public void FromEntityData(Cust_Xmjl_MO_BomChangeData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(Cust_Xmjl_MO_BomChangeData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
		
			base.FromEntityData(data,dict) ;
		
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
								this.SetTypeValue("ChangeReason",data.ChangeReason);
		
								this.SetTypeValue("ChangeDateTime",data.ChangeDateTime);
		
								this.SetTypeValue("ChangeStat",data.ChangeStat);
		
								this.SetTypeValue("ChangeDocType",data.ChangeDocType);
		
								this.SetTypeValue("ChangePerson",data.ChangePerson);
		
			#endregion 

			#region 组件内属性
	
					if (data.Cust_Xmjl_MO_BomChangeItem != null)
			{	
				foreach(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData obj in data.Cust_Xmjl_MO_BomChangeItem )
				{
					UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem child = dict[obj] as UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.Cust_Xmjl_MO_BomChangeItem.Remove(child);
						this.Cust_Xmjl_MO_BomChangeItem.DelLists.Add(child);
					}
					else
						this.Cust_Xmjl_MO_BomChangeItem.Add(child);
				}
			}
	     

					if (data.Cust_Xmjl_MO_BomChangeManufactureNo != null)
			{	
				foreach(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData obj in data.Cust_Xmjl_MO_BomChangeManufactureNo )
				{
					UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo child = dict[obj] as UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.Cust_Xmjl_MO_BomChangeManufactureNo.Remove(child);
						this.Cust_Xmjl_MO_BomChangeManufactureNo.DelLists.Add(child);
					}
					else
						this.Cust_Xmjl_MO_BomChangeManufactureNo.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new Cust_Xmjl_MO_BomChangeData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public Cust_Xmjl_MO_BomChangeData ToEntityData(Cust_Xmjl_MO_BomChangeData data, IDictionary dict){
			if (data == null)
				data = new Cust_Xmjl_MO_BomChangeData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ChangeReason");
				if (obj != null)
					data.ChangeReason=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChangeDateTime");
				if (obj != null)
					data.ChangeDateTime=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChangeStat");
				if (obj != null)
					data.ChangeStat=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChangeDocType");
				if (obj != null)
					data.ChangeDocType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChangePerson");
				if (obj != null)
					data.ChangePerson=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.Cust_Xmjl_MO_BomChangeItem != null)
			{	
				List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData> listCust_Xmjl_MO_BomChangeItem = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem obj in this.Cust_Xmjl_MO_BomChangeItem ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData old = dict["UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem"+obj.ID.ToString()] as UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData;
					listCust_Xmjl_MO_BomChangeItem.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.Cust_Xmjl_MO_BomChangeItem = listCust_Xmjl_MO_BomChangeItem;
			}	
			if (this.Cust_Xmjl_MO_BomChangeManufactureNo != null)
			{	
				List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData> listCust_Xmjl_MO_BomChangeManufactureNo = new List<UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo obj in this.Cust_Xmjl_MO_BomChangeManufactureNo ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData old = dict["UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo"+obj.ID.ToString()] as UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData;
					listCust_Xmjl_MO_BomChangeManufactureNo.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.Cust_Xmjl_MO_BomChangeManufactureNo = listCust_Xmjl_MO_BomChangeManufactureNo;
			}	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
		//L类档案的组织相关检查.
		UFIDA.U9.Base.Util.LTypeOrgAttributeValidator.Validate(this);
        







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