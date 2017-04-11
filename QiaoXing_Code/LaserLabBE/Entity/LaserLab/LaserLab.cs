using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab
{
	
	/// <summary>
	/// 实体: 镭射标表
	/// 
	/// </summary>
	[Serializable]	
	public  partial class LaserLab : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public LaserLab(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static LaserLab Create() {
			LaserLab entity = (LaserLab)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																									 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected LaserLab(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static LaserLab CreateDefault() {
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
		public static LaserLab CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class LaserLab EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new LaserLab GetEntity()
			{
				return (LaserLab)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<LaserLab> 
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
				private System.String m_LB ;
				public  System.String LB
				{
					get { return m_LB ;}
					set { m_LB = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public LaserLab FindByBusinessKey(  System.String lB  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.LB = lB ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public LaserLab FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("LB = @LB");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("LB",parameter.LB));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_XMQX_LaserLabBE_LaserLab_LaserLab_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private System.String m_LB ;
				public  System.String LB
				{
					get { return m_LB ;}
					set { m_LB = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_XMQX_LaserLabBE_LaserLab_LaserLab_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public LaserLab FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("LB = @LB");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("LB",parameter.LB));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<LaserLab>{
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
		    //private LaserLab ContainerEntity ;
		    public  new LaserLab ContainerEntity 
		    {
				get { return  (LaserLab)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(LaserLab container)
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
			/// 镭射标表.Key.ID
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
			/// 镭射标表.Sys.创建时间
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
			/// 镭射标表.Sys.创建人
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
			/// 镭射标表.Sys.修改时间
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
			/// 镭射标表.Sys.修改人
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
			/// 镭射标表.Sys.事务版本
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
			/// 批次号 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.批次号
			/// </summary>
			/// <value></value>
			public  System.String BN
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BN");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货批次号 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.出货批次号
			/// </summary>
			/// <value></value>
			public  System.String ShipBN
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ShipBN");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 镭射标表.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum Cp
			{
				get
				{

					UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum value  = UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum.GetFromValue(base.GetValue("Cp"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 镭射标 (该属性不可为空,且无默认值)
			/// 镭射标表.Misc.镭射标
			/// </summary>
			/// <value></value>
			public  System.String LB
			{
				get
				{
					System.String value  = (System.String)base.GetValue("LB");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 型号 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.型号
			/// </summary>
			/// <value></value>
			public  System.String Type
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Type");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.客户
			/// </summary>
			/// <value></value>
			public  System.String Customer
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Customer");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料时间 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.物料时间
			/// </summary>
			/// <value></value>
			public  System.DateTime MasterDT
			{
				get
				{
					object obj = base.GetValue("MasterDT");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 金油时间 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.金油时间
			/// </summary>
			/// <value></value>
			public  System.DateTime GoldOilDT
			{
				get
				{
					object obj = base.GetValue("GoldOilDT");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 包装时间 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.包装时间
			/// </summary>
			/// <value></value>
			public  System.DateTime PackDT
			{
				get
				{
					object obj = base.GetValue("PackDT");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货时间 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.出货时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ShipDT
			{
				get
				{
					object obj = base.GetValue("ShipDT");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报废时间 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.报废时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ScarpDT
			{
				get
				{
					object obj = base.GetValue("ScarpDT");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扫描日期 (该属性可为空,且无默认值)
			/// 镭射标表.Misc.扫描日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ScanDate
			{
				get
				{
					object obj = base.GetValue("ScanDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
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
		/// 镭射标表.Key.ID
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
		/// 镭射标表.Sys.创建时间
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
		/// 镭射标表.Sys.创建人
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
		/// 镭射标表.Sys.修改时间
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
		/// 镭射标表.Sys.修改人
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
		/// 镭射标表.Sys.事务版本
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
		/// 批次号 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.批次号
		/// </summary>
		/// <value></value>
			public  System.String BN
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BN");
				return value;
				}
				set
			{
				
								base.SetValue("BN", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出货批次号 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.出货批次号
		/// </summary>
		/// <value></value>
			public  System.String ShipBN
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ShipBN");
				return value;
				}
				set
			{
				
								base.SetValue("ShipBN", value);
						 
			}
		}
	



		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 镭射标表.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum Cp
		{
			get
			{

				UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum value  = UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum.GetFromValue(base.GetValue("Cp"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Cp",UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum.Empty.Value);
				else
					base.SetValue("Cp",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 镭射标 (该属性不可为空,且无默认值)
		/// 镭射标表.Misc.镭射标
		/// </summary>
		/// <value></value>
			public  System.String LB
		{
			get
			{
				System.String value  = (System.String)base.GetValue("LB");
				return value;
				}
				set
			{
				
								base.SetValue("LB", value);
						 
			}
		}
	



		
			/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.型号
		/// </summary>
		/// <value></value>
			public  System.String Type
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Type");
				return value;
				}
				set
			{
				
								base.SetValue("Type", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.客户
		/// </summary>
		/// <value></value>
			public  System.String Customer
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Customer");
				return value;
				}
				set
			{
				
								base.SetValue("Customer", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料时间 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.物料时间
		/// </summary>
		/// <value></value>
			public  System.DateTime MasterDT
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("MasterDT");
				return value;
				}
				set
			{
				
								base.SetValue("MasterDT", value);
						 
			}
		}
	



		
			/// <summary>
		/// 金油时间 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.金油时间
		/// </summary>
		/// <value></value>
			public  System.DateTime GoldOilDT
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("GoldOilDT");
				return value;
				}
				set
			{
				
								base.SetValue("GoldOilDT", value);
						 
			}
		}
	



		
			/// <summary>
		/// 包装时间 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.包装时间
		/// </summary>
		/// <value></value>
			public  System.DateTime PackDT
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("PackDT");
				return value;
				}
				set
			{
				
								base.SetValue("PackDT", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出货时间 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.出货时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ShipDT
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ShipDT");
				return value;
				}
				set
			{
				
								base.SetValue("ShipDT", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报废时间 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.报废时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ScarpDT
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ScarpDT");
				return value;
				}
				set
			{
				
								base.SetValue("ScarpDT", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扫描日期 (该属性可为空,且无默认值)
		/// 镭射标表.Misc.扫描日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ScanDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ScanDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ScanDate", value.Date);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BN")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BN　{ get { return EntityRes.GetResource("BN");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipBN")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipBN　{ get { return EntityRes.GetResource("ShipBN");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Cp")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Cp　{ get { return EntityRes.GetResource("Cp");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LB")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LB　{ get { return EntityRes.GetResource("LB");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Type")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Type　{ get { return EntityRes.GetResource("Type");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Customer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Customer　{ get { return EntityRes.GetResource("Customer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MasterDT")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MasterDT　{ get { return EntityRes.GetResource("MasterDT");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GoldOilDT")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GoldOilDT　{ get { return EntityRes.GetResource("GoldOilDT");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PackDT")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PackDT　{ get { return EntityRes.GetResource("PackDT");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipDT")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipDT　{ get { return EntityRes.GetResource("ShipDT");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ScarpDT")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ScarpDT　{ get { return EntityRes.GetResource("ScarpDT");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ScanDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ScanDate　{ get { return EntityRes.GetResource("ScanDate");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "LaserLab";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab";　}　}
		
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
			/// 属性: 批次号 的名称
			/// </summary>
			public static string BN　{ get { return "BN";　}　}
				
			/// <summary>
			/// 属性: 出货批次号 的名称
			/// </summary>
			public static string ShipBN　{ get { return "ShipBN";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Cp　{ get { return "Cp";　}　}
				
			/// <summary>
			/// 属性: 镭射标 的名称
			/// </summary>
			public static string LB　{ get { return "LB";　}　}
				
			/// <summary>
			/// 属性: 型号 的名称
			/// </summary>
			public static string Type　{ get { return "Type";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Customer　{ get { return "Customer";　}　}
				
			/// <summary>
			/// 属性: 物料时间 的名称
			/// </summary>
			public static string MasterDT　{ get { return "MasterDT";　}　}
				
			/// <summary>
			/// 属性: 金油时间 的名称
			/// </summary>
			public static string GoldOilDT　{ get { return "GoldOilDT";　}　}
				
			/// <summary>
			/// 属性: 包装时间 的名称
			/// </summary>
			public static string PackDT　{ get { return "PackDT";　}　}
				
			/// <summary>
			/// 属性: 出货时间 的名称
			/// </summary>
			public static string ShipDT　{ get { return "ShipDT";　}　}
				
			/// <summary>
			/// 属性: 报废时间 的名称
			/// </summary>
			public static string ScarpDT　{ get { return "ScarpDT";　}　}
				
			/// <summary>
			/// 属性: 扫描日期 的名称
			/// </summary>
			public static string ScanDate　{ get { return "ScanDate";　}　}
		
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
			this.exdMultiLangAttrs.Add("BN","BN");
			this.exdMultiLangAttrs.Add("ShipBN","ShipBN");
			this.exdMultiLangAttrs.Add("Cp","Cp");
			this.exdMultiLangAttrs.Add("LB","LB");
			this.exdMultiLangAttrs.Add("Type","Type");
			this.exdMultiLangAttrs.Add("Customer","Customer");
			this.exdMultiLangAttrs.Add("MasterDT","MasterDT");
			this.exdMultiLangAttrs.Add("GoldOilDT","GoldOilDT");
			this.exdMultiLangAttrs.Add("PackDT","PackDT");
			this.exdMultiLangAttrs.Add("ShipDT","ShipDT");
			this.exdMultiLangAttrs.Add("ScarpDT","ScarpDT");
			this.exdMultiLangAttrs.Add("ScanDate","ScanDate");
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
		private void DeSerializeKey(LaserLabData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			LaserLabData data = dto as LaserLabData ;
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
		public void FromEntityData(LaserLabData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LaserLabData data,IDictionary dict)
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
		
								this.SetTypeValue("BN",data.BN);
		
								this.SetTypeValue("ShipBN",data.ShipBN);
		
								this.SetTypeValue("LB",data.LB);
		
								this.SetTypeValue("Type",data.Type);
		
								this.SetTypeValue("Customer",data.Customer);
		
								this.SetTypeValue("MasterDT",data.MasterDT);
		
								this.SetTypeValue("GoldOilDT",data.GoldOilDT);
		
								this.SetTypeValue("PackDT",data.PackDT);
		
								this.SetTypeValue("ShipDT",data.ShipDT);
		
								this.SetTypeValue("ScarpDT",data.ScarpDT);
		
								this.SetTypeValue("ScanDate",data.ScanDate);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("Cp",data.Cp);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LaserLabData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LaserLabData ToEntityData(LaserLabData data, IDictionary dict){
			if (data == null)
				data = new LaserLabData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BN");
				if (obj != null)
					data.BN=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipBN");
				if (obj != null)
					data.ShipBN=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("LB");
				if (obj != null)
					data.LB=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Type");
				if (obj != null)
					data.Type=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Customer");
				if (obj != null)
					data.Customer=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MasterDT");
				if (obj != null)
					data.MasterDT=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GoldOilDT");
				if (obj != null)
					data.GoldOilDT=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PackDT");
				if (obj != null)
					data.PackDT=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipDT");
				if (obj != null)
					data.ShipDT=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ScarpDT");
				if (obj != null)
					data.ScarpDT=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ScanDate");
				if (obj != null)
					data.ScanDate=(System.DateTime)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("Cp");
				if (obj != null)
					data.Cp=System.Int32.Parse(obj.ToString());
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
		
			if (string.IsNullOrEmpty((string)base.GetValue("LB"))){
				UFSoft.UBF.Business.AttributeInValidException LB_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab","LB","0dd778bd-55ac-44e5-9116-016282a623b2");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					LB_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(LB_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}