using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	
	/// <summary>
	/// 实体: 广告申请单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class AdvApplyBE : UFIDA.U9.Base.Doc.Doc
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
            get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class AdvApplyBE EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE")
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
			public AdvApplyBE FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
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
			public AdvApplyBE FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public AdvApplyBE FindByBusinessKey(BusinessKeyParameter parameter)
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
			/// UFIDA_U9_Cust_SeeBestAdvertisementBE_AdvertisementApplyBE_AdvApplyBE_BusinessKey_Index索引查询参数类型
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
			/// 通过索引UFIDA_U9_Cust_SeeBestAdvertisementBE_AdvertisementApplyBE_AdvApplyBE_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public AdvApplyBE FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<AdvApplyBE>{
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
		    //private AdvApplyBE ContainerEntity ;
		    public  new AdvApplyBE ContainerEntity 
		    {
				get { return  (AdvApplyBE)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(AdvApplyBE container):base(container)
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
			/// 办事处 (该属性可为空,且无默认值)
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
		/// 办事处 的Key (该属性可为空,且无默认值)
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
			/// 数量 (该属性可为空,但有默认值)
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
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum AdvDisplayType
			{
				get
				{

					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum.GetFromValue(base.GetValue("AdvDisplayType"));
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
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 编号的4位流水 (该属性可为空,但有默认值)
			/// 广告申请单.Misc.编号的4位流水
			/// </summary>
			/// <value></value>
			public  System.Int32 Flow4Bit
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("Flow4Bit");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 广告申请单.StateMachine.当前状态
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
			/// 广告申请单.StateMachine.之前状态
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
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE> m_AdvAboutBE  ;
			/// <summary>
			/// 广告体现项目子表 (该属性可为空,且无默认值)
			/// 广告申请单.Misc.广告体现项目子表
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE> AdvAboutBE
			{
				get
				{
					if (m_AdvAboutBE == null)
						m_AdvAboutBE = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE>();
					m_AdvAboutBE.Clear();	
					foreach (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE child in ContainerEntity.AdvAboutBE)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_AdvAboutBE.Add(child);
					}
					foreach (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE child in ContainerEntity.AdvAboutBE.DelLists)
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
		/// 编号 (该属性可为空,且无默认值)
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
		/// 办事处 (该属性可为空,且无默认值)
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
		/// 办事处 的Key (该属性可为空,且无默认值)
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
		/// 数量 (该属性可为空,但有默认值)
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
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum AdvDisplayType
		{
			get
			{

				UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum value  = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum.GetFromValue(base.GetValue("AdvDisplayType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("AdvDisplayType",UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum.Empty.Value);
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
	



		
			/// <summary>
		/// 编号的4位流水 (该属性可为空,但有默认值)
		/// 广告申请单.Misc.编号的4位流水
		/// </summary>
		/// <value></value>
			public  System.Int32 Flow4Bit
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("Flow4Bit");
				return value;
				}
				set
			{
				
								base.SetValue("Flow4Bit", value);
						 
			}
		}
	



		
			/// <summary>
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 广告申请单.StateMachine.当前状态
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
		/// 广告申请单.StateMachine.之前状态
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
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE.EntityList m_AdvAboutBE  ;
		/// <summary>
		/// 广告体现项目子表 (该属性可为空,且无默认值)
		/// 广告申请单.Misc.广告体现项目子表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE.EntityList AdvAboutBE
		{
			get
			{
				if (m_AdvAboutBE == null)
					m_AdvAboutBE = new UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE.EntityList("AdvApplyBE",this,"AdvAboutBE",(IList)this.GetRelation("AdvAboutBE"));
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
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE")  ;}	}
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
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Flow4Bit")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Flow4Bit　{ get { return EntityRes.GetResource("Flow4Bit");　}　}
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
			public static string BE_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE";　}　}
		
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
			/// 属性: 编号的4位流水 的名称
			/// </summary>
			public static string Flow4Bit　{ get { return "Flow4Bit";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
		
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
			this.exdMultiLangAttrs.Add("Flow4Bit","Flow4Bit");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
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
		
								this.SetTypeValue("Flow4Bit",data.Flow4Bit);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("AdvDisplayType",data.AdvDisplayType);
	     

					if (data.AdvAboutBE != null)
			{	
				foreach(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBEData obj in data.AdvAboutBE )
				{
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE child = dict[obj] as UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
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
		public new AdvApplyBEData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AdvApplyBEData ToEntityData(AdvApplyBEData data, IDictionary dict){
			if (data == null)
				data = new AdvApplyBEData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE"+this.ID.ToString()] = data;
		
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
	     
	    
			{
				object obj =this.GetValue("Flow4Bit");
				if (obj != null)
					data.Flow4Bit=(System.Int32)obj;
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
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("AdvDisplayType");
				if (obj != null)
					data.AdvDisplayType=System.Int32.Parse(obj.ToString());
			}
	
			if (this.AdvAboutBE != null)
			{	
				List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBEData> listAdvAboutBE = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBEData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE obj in this.AdvAboutBE ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBEData old = dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE"+obj.ID.ToString()] as UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBEData;
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