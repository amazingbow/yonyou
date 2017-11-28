using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	
	/// <summary>
	/// 实体: 专柜申请单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class SpecialApplyBE : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public SpecialApplyBE(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static SpecialApplyBE Create() {
			SpecialApplyBE entity = (SpecialApplyBE)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																									 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected SpecialApplyBE(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static SpecialApplyBE CreateDefault() {
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
		public static SpecialApplyBE CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class SpecialApplyBE EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new SpecialApplyBE GetEntity()
			{
				return (SpecialApplyBE)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<SpecialApplyBE> 
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
			public SpecialApplyBE FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
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
			public SpecialApplyBE FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public SpecialApplyBE FindByBusinessKey(BusinessKeyParameter parameter)
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
			/// UFIDA_U9_Cust_SeeBestAdvertisementBE_SpecialApplyBE_SpecialApplyBE_BusinessKey_Index索引查询参数类型
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
			/// 通过索引UFIDA_U9_Cust_SeeBestAdvertisementBE_SpecialApplyBE_SpecialApplyBE_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public SpecialApplyBE FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<SpecialApplyBE>{
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
		    //private SpecialApplyBE ContainerEntity ;
		    public  new SpecialApplyBE ContainerEntity 
		    {
				get { return  (SpecialApplyBE)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(SpecialApplyBE container):base(container)
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
			/// 编号 (该属性可为空,且无默认值)
			/// 专柜申请单.Misc.编号
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
			/// 专柜申请单.Misc.办事处
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
		/// 专柜申请单.Misc.办事处
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
			/// 下单人 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.下单人
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
			/// 专柜申请单.Misc.下单日期
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
			/// 联系电话 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.联系电话
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
			/// QQ (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.QQ
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
			/// 客户店名 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.客户店名
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
			/// 联系人 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.联系人
			/// </summary>
			/// <value></value>
			public  System.String CustName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户联系电话 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.客户联系电话
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
			/// 客户地址 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.客户地址
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
			/// 专柜设计风格 (该属性不可为空,但有默认值)
			/// 专柜申请单.Misc.专柜设计风格
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum SpecialDesignStyle
			{
				get
				{

					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum.GetFromValue(base.GetValue("SpecialDesignStyle"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据类型 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType SpecialApplyDocType
			{
				get
				{
					if (SpecialApplyDocTypeKey == null)
						return null ;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType value =  (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType)SpecialApplyDocTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey m_SpecialApplyDocTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey SpecialApplyDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("SpecialApplyDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SpecialApplyDocTypeKey==null || m_SpecialApplyDocTypeKey.ID != key )
					m_SpecialApplyDocTypeKey = new UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey(key); 
				return m_SpecialApplyDocTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 专柜申请单.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum Status
			{
				get
				{

					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum.GetFromValue(base.GetValue("Status"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 专柜申请单.StateMachine.当前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFCurrentState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 之前状态 (该属性不可为空,但有默认值)
			/// 专柜申请单.StateMachine.之前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFOriginalState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 关闭 (该属性可为空,但有默认值)
			/// 专柜申请单.Misc.关闭
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
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 区域 (该属性可为空,且无默认值)
			/// 专柜申请单.Misc.区域
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
			/// 专柜申请单.Misc.乡镇
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
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE> m_SpecialSizeBE  ;
			/// <summary>
			/// 专柜尺寸 (该属性不可为空,且无默认值)
			/// 专柜申请单.Misc.专柜尺寸
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE> SpecialSizeBE
			{
				get
				{
					if (m_SpecialSizeBE == null)
						m_SpecialSizeBE = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE>();
					m_SpecialSizeBE.Clear();	
					foreach (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE child in ContainerEntity.SpecialSizeBE)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_SpecialSizeBE.Add(child);
					}
					foreach (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE child in ContainerEntity.SpecialSizeBE.DelLists)
					{
						m_SpecialSizeBE.Add(child);
					}
					return m_SpecialSizeBE;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 编号 (该属性可为空,且无默认值)
		/// 专柜申请单.Misc.编号
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
		/// 专柜申请单.Misc.办事处
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
		/// 专柜申请单.Misc.办事处
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
		/// 下单人 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.下单人
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
		/// 专柜申请单.Misc.下单日期
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
		/// 联系电话 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.联系电话
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
		/// QQ (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.QQ
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
		/// 客户店名 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.客户店名
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
		/// 联系人 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.联系人
		/// </summary>
		/// <value></value>
			public  System.String CustName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustName");
				return value;
				}
				set
			{
				
								base.SetValue("CustName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户联系电话 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.客户联系电话
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
		/// 客户地址 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.客户地址
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
		/// 专柜设计风格 (该属性不可为空,但有默认值)
		/// 专柜申请单.Misc.专柜设计风格
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum SpecialDesignStyle
		{
			get
			{

				UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum.GetFromValue(base.GetValue("SpecialDesignStyle"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SpecialDesignStyle",UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum.Empty.Value);
				else
					base.SetValue("SpecialDesignStyle",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 单据类型 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType SpecialApplyDocType
		{
			get
			{
				object  obj = this.GetRelation("SpecialApplyDocType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType value  = (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SpecialApplyDocType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey m_SpecialApplyDocTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey SpecialApplyDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("SpecialApplyDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SpecialApplyDocTypeKey==null || m_SpecialApplyDocTypeKey.ID != key )
					m_SpecialApplyDocTypeKey = new UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.EntityKey(key); 
				return m_SpecialApplyDocTypeKey ;
			}
			set
			{	
				if (SpecialApplyDocTypeKey==value)
					return ;
				this.SetRelation("SpecialApplyDocType", null);
				m_SpecialApplyDocTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("SpecialApplyDocType",value.ID);
				}
				else
					base.SetValue("SpecialApplyDocType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 专柜申请单.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum Status
		{
			get
			{

				UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum.GetFromValue(base.GetValue("Status"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Status",UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum.Empty.Value);
				else
					base.SetValue("Status",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 专柜申请单.StateMachine.当前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFCurrentState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
				return value;
				}
				set
			{
				
								base.SetValue("WFCurrentState", value);
						 
			}
		}
	



		
			/// <summary>
		/// 之前状态 (该属性不可为空,但有默认值)
		/// 专柜申请单.StateMachine.之前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFOriginalState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
				return value;
				}
				set
			{
				
								base.SetValue("WFOriginalState", value);
						 
			}
		}
	



		
			/// <summary>
		/// 关闭 (该属性可为空,但有默认值)
		/// 专柜申请单.Misc.关闭
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
	



		
			/// <summary>
		/// 区域 (该属性可为空,且无默认值)
		/// 专柜申请单.Misc.区域
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
		/// 专柜申请单.Misc.乡镇
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
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE.EntityList m_SpecialSizeBE  ;
		/// <summary>
		/// 专柜尺寸 (该属性不可为空,且无默认值)
		/// 专柜申请单.Misc.专柜尺寸
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE.EntityList SpecialSizeBE
		{
			get
			{
				if (m_SpecialSizeBE == null)
					m_SpecialSizeBE = new UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE.EntityList("SpecialApplyBE",this,"SpecialSizeBE",(IList)this.GetRelation("SpecialSizeBE"));
				else
					m_SpecialSizeBE.InnerList = (IList)this.GetRelation("SpecialSizeBE");
				return m_SpecialSizeBE;
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
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustName　{ get { return EntityRes.GetResource("CustName");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpecialDesignStyle")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpecialDesignStyle　{ get { return EntityRes.GetResource("SpecialDesignStyle");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpecialSizeBE")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpecialSizeBE　{ get { return EntityRes.GetResource("SpecialSizeBE");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpecialApplyDocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpecialApplyDocType　{ get { return EntityRes.GetResource("SpecialApplyDocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFCurrentState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFCurrentState　{ get { return EntityRes.GetResource("WFCurrentState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFOriginalState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFOriginalState　{ get { return EntityRes.GetResource("WFOriginalState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsClose")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsClose　{ get { return EntityRes.GetResource("IsClose");　}　}
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
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "SpecialApplyBE";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE";　}　}
		
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
			/// 属性: 联系人 的名称
			/// </summary>
			public static string CustName　{ get { return "CustName";　}　}
				
			/// <summary>
			/// 属性: 客户联系电话 的名称
			/// </summary>
			public static string CustPhone　{ get { return "CustPhone";　}　}
				
			/// <summary>
			/// 属性: 客户地址 的名称
			/// </summary>
			public static string CustAddress　{ get { return "CustAddress";　}　}
				
			/// <summary>
			/// 属性: 专柜设计风格 的名称
			/// </summary>
			public static string SpecialDesignStyle　{ get { return "SpecialDesignStyle";　}　}
				
			/// <summary>
			/// 属性: 专柜尺寸 的名称
			/// </summary>
			public static string SpecialSizeBE　{ get { return "SpecialSizeBE";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string SpecialApplyDocType　{ get { return "SpecialApplyDocType";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
				
			/// <summary>
			/// 属性: 关闭 的名称
			/// </summary>
			public static string IsClose　{ get { return "IsClose";　}　}
				
			/// <summary>
			/// 属性: 区域 的名称
			/// </summary>
			public static string LocationQY　{ get { return "LocationQY";　}　}
				
			/// <summary>
			/// 属性: 乡镇 的名称
			/// </summary>
			public static string LocationXZ　{ get { return "LocationXZ";　}　}
		
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
			this.exdMultiLangAttrs.Add("AdvCode","AdvCode");
			this.exdMultiLangAttrs.Add("ApplyDept","ApplyDept");
			this.exdMultiLangAttrs.Add("Applier","Applier");
			this.exdMultiLangAttrs.Add("ApplyDate","ApplyDate");
			this.exdMultiLangAttrs.Add("Phone","Phone");
			this.exdMultiLangAttrs.Add("QQ","QQ");
			this.exdMultiLangAttrs.Add("CustConterName","CustConterName");
			this.exdMultiLangAttrs.Add("CustName","CustName");
			this.exdMultiLangAttrs.Add("CustPhone","CustPhone");
			this.exdMultiLangAttrs.Add("CustAddress","CustAddress");
			this.exdMultiLangAttrs.Add("SpecialDesignStyle","SpecialDesignStyle");
			this.exdMultiLangAttrs.Add("SpecialApplyDocType","SpecialApplyDocType");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
			this.exdMultiLangAttrs.Add("IsClose","IsClose");
			this.exdMultiLangAttrs.Add("LocationQY","LocationQY");
			this.exdMultiLangAttrs.Add("LocationXZ","LocationXZ");
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
		private void DeSerializeKey(SpecialApplyBEData data)
		{
		
			

			if (data.ApplyDept == -1 && data.ApplyDept_SKey!=null)
				data.ApplyDept = data.ApplyDept_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			if (data.SpecialApplyDocType == -1 && data.SpecialApplyDocType_SKey!=null)
				data.SpecialApplyDocType = data.SpecialApplyDocType_SKey.GetEntity().ID ;
	

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			SpecialApplyBEData data = dto as SpecialApplyBEData ;
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
		public void FromEntityData(SpecialApplyBEData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SpecialApplyBEData data,IDictionary dict)
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
								this.SetTypeValue("AdvCode",data.AdvCode);
		
								this.SetTypeValue("ApplyDept",data.ApplyDept);
		
								this.SetTypeValue("Applier",data.Applier);
		
								this.SetTypeValue("ApplyDate",data.ApplyDate);
		
								this.SetTypeValue("Phone",data.Phone);
		
								this.SetTypeValue("QQ",data.QQ);
		
								this.SetTypeValue("CustConterName",data.CustConterName);
		
								this.SetTypeValue("CustName",data.CustName);
		
								this.SetTypeValue("CustPhone",data.CustPhone);
		
								this.SetTypeValue("CustAddress",data.CustAddress);
		
								this.SetTypeValue("SpecialApplyDocType",data.SpecialApplyDocType);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
								this.SetTypeValue("IsClose",data.IsClose);
		
								this.SetTypeValue("LocationQY",data.LocationQY);
		
								this.SetTypeValue("LocationXZ",data.LocationXZ);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("SpecialDesignStyle",data.SpecialDesignStyle);
	     

					if (data.SpecialSizeBE != null)
			{	
				foreach(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData obj in data.SpecialSizeBE )
				{
					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE child = dict[obj] as UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.SpecialSizeBE.Remove(child);
						this.SpecialSizeBE.DelLists.Add(child);
					}
					else
						this.SpecialSizeBE.Add(child);
				}
			}
	     

					this.SetTypeValue("Status",data.Status);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new SpecialApplyBEData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SpecialApplyBEData ToEntityData(SpecialApplyBEData data, IDictionary dict){
			if (data == null)
				data = new SpecialApplyBEData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
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
				object obj =this.GetValue("CustName");
				if (obj != null)
					data.CustName=(System.String)obj;
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
				object obj =this.GetValue("SpecialApplyDocType");
				if (obj != null)
					data.SpecialApplyDocType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFCurrentState");
				if (obj != null)
					data.WFCurrentState=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFOriginalState");
				if (obj != null)
					data.WFOriginalState=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsClose");
				if (obj != null)
					data.IsClose=(System.Boolean)obj;
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
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("SpecialDesignStyle");
				if (obj != null)
					data.SpecialDesignStyle=System.Int32.Parse(obj.ToString());
			}
	
			if (this.SpecialSizeBE != null)
			{	
				List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData> listSpecialSizeBE = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE obj in this.SpecialSizeBE ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData old = dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE"+obj.ID.ToString()] as UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBEData;
					listSpecialSizeBE.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.SpecialSizeBE = listSpecialSizeBE;
			}	
			{
				object obj =this.GetValue("Status");
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
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
		
			if (Convert.ToInt64(base.GetValue("ApplyDept")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException ApplyDept_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","ApplyDept","cc079e83-6a70-4413-b966-85eea8fb4762");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					ApplyDept_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(ApplyDept_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("Applier"))){
				UFSoft.UBF.Business.AttributeInValidException Applier_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","Applier","4d7ad8a8-0cd8-451b-9742-6d3d39f68ede");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Applier_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Applier_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("Phone"))){
				UFSoft.UBF.Business.AttributeInValidException Phone_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","Phone","2487e091-85cb-425b-bd71-e70593992aea");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Phone_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Phone_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("QQ"))){
				UFSoft.UBF.Business.AttributeInValidException QQ_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","QQ","62b31dc3-8a0b-4f32-8ee4-fe9ad2836c9a");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					QQ_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(QQ_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("CustConterName"))){
				UFSoft.UBF.Business.AttributeInValidException CustConterName_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","CustConterName","5f244084-84a3-44ab-9bf0-5801ee21d7ed");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					CustConterName_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(CustConterName_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("CustName"))){
				UFSoft.UBF.Business.AttributeInValidException CustName_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","CustName","1c7705e4-d41e-4069-bb53-3c078c72f593");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					CustName_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(CustName_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("CustPhone"))){
				UFSoft.UBF.Business.AttributeInValidException CustPhone_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","CustPhone","a8c4b27b-9f0d-4ca9-a77f-b24b1931eb9c");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					CustPhone_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(CustPhone_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("CustAddress"))){
				UFSoft.UBF.Business.AttributeInValidException CustAddress_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","CustAddress","c790f8f1-3896-4c37-bee5-24b103a08f4e");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					CustAddress_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(CustAddress_Exception);
			}

			if (Convert.ToInt32(base.GetValue("SpecialDesignStyle")) == UFSoft.UBF.PL.Tool.Constant.Enum_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException SpecialDesignStyle_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","SpecialDesignStyle","f3f6f00c-4e0a-4b1b-adbc-1312c4501756");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					SpecialDesignStyle_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(SpecialDesignStyle_Exception);
			}


			if (Convert.ToInt64(base.GetValue("SpecialApplyDocType")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException SpecialApplyDocType_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE","SpecialApplyDocType","fd4f67d9-ff72-4998-a424-442d6794090b");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					SpecialApplyDocType_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(SpecialApplyDocType_Exception);
			}



			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}