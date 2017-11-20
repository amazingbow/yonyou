using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{
	
	/// <summary>
	/// 实体: 广告核销单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class AdvApproveLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public AdvApproveLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static AdvApproveLine Create(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE parentEntity) {
			AdvApproveLine entity = (AdvApproveLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.AdvApproveBE = parentEntity ;
			parentEntity.AdvApproveLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected AdvApproveLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return false ;}
		}
		#endregion

		#region Create Default 
	    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
        [Obsolete("仅用于开发的测试用例时期.正式版返回NULL.不可使用.")]
		public  static AdvApproveLine CreateDefault(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE parentEntity) {
		#if Test		
			return CreateDefault_Extend(parentEntity);
		#else 
		    return null;
		#endif
		}
	
		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class AdvApproveLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new AdvApproveLine GetEntity()
			{
				return (AdvApproveLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<AdvApproveLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<AdvApproveLine>{
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
			    get { return false ;}
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
		    //private AdvApproveLine ContainerEntity ;
		    public  new AdvApproveLine ContainerEntity 
		    {
				get { return  (AdvApproveLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(AdvApproveLine container)
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
			/// 广告核销单行.Key.ID
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
			/// 广告核销单行.Sys.创建时间
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
			/// 广告核销单行.Sys.创建人
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
			/// 广告核销单行.Sys.修改时间
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
			/// 广告核销单行.Sys.修改人
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
			/// 广告核销单行.Sys.事务版本
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
			/// 广告核销单 (该属性可为空,且无默认值)
			/// 广告核销单行.Misc.广告核销单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE AdvApproveBE
			{
				get
				{
					if (AdvApproveBEKey == null)
						return null ;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE value =  (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE)AdvApproveBEKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey m_AdvApproveBEKey ;
		/// <summary>
		/// EntityKey 属性
		/// 广告核销单 的Key (该属性可为空,且无默认值)
		/// 广告核销单行.Misc.广告核销单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey AdvApproveBEKey
		{
			get 
			{
				object obj = base.GetValue("AdvApproveBE") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AdvApproveBEKey==null || m_AdvApproveBEKey.ID != key )
					m_AdvApproveBEKey = new UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey(key); 
				return m_AdvApproveBEKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 办事处名称 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.办事处名称
			/// </summary>
			/// <value></value>
			public  System.String AdvAppCustName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvAppCustName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 区/县 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.区/县
			/// </summary>
			/// <value></value>
			public  System.String Location
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Location");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 乡镇 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.乡镇
			/// </summary>
			/// <value></value>
			public  System.String Country
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Country");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户店名 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.客户店名
			/// </summary>
			/// <value></value>
			public  System.String CustCounterName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustCounterName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 联系人 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.联系人
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
			/// 联系电话 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.联系电话
			/// </summary>
			/// <value></value>
			public  System.String RelPhone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("RelPhone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户地址 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.客户地址
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
			/// 宽 (该属性可为空,但有默认值)
			/// 广告核销单行.ApplyInfo.宽
			/// </summary>
			/// <value></value>
			public  System.Decimal Width
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Width");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 厚 (该属性可为空,但有默认值)
			/// 广告核销单行.ApplyInfo.厚
			/// </summary>
			/// <value></value>
			public  System.Decimal Thick
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Thick");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 高 (该属性可为空,但有默认值)
			/// 广告核销单行.ApplyInfo.高
			/// </summary>
			/// <value></value>
			public  System.Decimal Height
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Height");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 面积 (该属性可为空,但有默认值)
			/// 广告核销单行.ApplyInfo.面积
			/// </summary>
			/// <value></value>
			public  System.Decimal Area
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Area");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 广告编号 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.广告编号
			/// </summary>
			/// <value></value>
			public  System.String ApplyAdvCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ApplyAdvCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 广告载体 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.广告载体
			/// </summary>
			/// <value></value>
			public  System.String AdvCarrier
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvCarrier");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 广告核销单行.ApproveInfo.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal ApplyQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ApplyQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 广告核销单行.ApproveInfo.单价
			/// </summary>
			/// <value></value>
			public  System.Decimal Price
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Price");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 金额 (该属性可为空,但有默认值)
			/// 广告核销单行.ApproveInfo.金额
			/// </summary>
			/// <value></value>
			public  System.Decimal TotalMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TotalMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收据编号 (该属性可为空,且无默认值)
			/// 广告核销单行.ApproveInfo.收据编号
			/// </summary>
			/// <value></value>
			public  System.String ReceiptNum
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ReceiptNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 广告核销单行.ApproveInfo.备注
			/// </summary>
			/// <value></value>
			public  System.String Momo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Momo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际核销数量 (该属性可为空,但有默认值)
			/// 广告核销单行.AuditInfo.实际核销数量
			/// </summary>
			/// <value></value>
			public  System.Decimal ActualApproveQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ActualApproveQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 核销单价 (该属性可为空,但有默认值)
			/// 广告核销单行.AuditInfo.核销单价
			/// </summary>
			/// <value></value>
			public  System.Decimal ActualPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ActualPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣率 (该属性可为空,但有默认值)
			/// 广告核销单行.AuditInfo.折扣率
			/// </summary>
			/// <value></value>
			public  System.Decimal Discount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Discount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 核销金额 (该属性可为空,但有默认值)
			/// 广告核销单行.AuditInfo.核销金额
			/// </summary>
			/// <value></value>
			public  System.Decimal ApproveMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ApproveMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 广告项目 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.广告项目
			/// </summary>
			/// <value></value>
			public  System.String AdvItem
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvItem");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 用于定位行 (该属性可为空,但有默认值)
			/// 广告核销单行.Misc.用于定位行
			/// </summary>
			/// <value></value>
			public  System.Int64 OtherInfo
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("OtherInfo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 核销异常说明 (该属性可为空,且无默认值)
			/// 广告核销单行.Misc.核销异常说明
			/// </summary>
			/// <value></value>
			public  System.String ApproveExDeclaration
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ApproveExDeclaration");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 下单日期 (该属性可为空,且无默认值)
			/// 广告核销单行.Misc.下单日期
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
			/// 广告载体编号 (该属性可为空,且无默认值)
			/// 广告核销单行.ApplyInfo.广告载体编号
			/// </summary>
			/// <value></value>
			public  System.String AdvCarrierCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("AdvCarrierCode");
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
		/// 广告核销单行.Key.ID
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
		/// 广告核销单行.Sys.创建时间
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
		/// 广告核销单行.Sys.创建人
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
		/// 广告核销单行.Sys.修改时间
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
		/// 广告核销单行.Sys.修改人
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
		/// 广告核销单行.Sys.事务版本
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
		/// 广告核销单 (该属性可为空,且无默认值)
		/// 广告核销单行.Misc.广告核销单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE AdvApproveBE
		{
			get
			{
				object  obj = this.GetRelation("AdvApproveBE");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE value  = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("AdvApproveBE", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey m_AdvApproveBEKey ;
		/// <summary>
		/// 广告核销单 的Key (该属性可为空,且无默认值)
		/// 广告核销单行.Misc.广告核销单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey AdvApproveBEKey
		{
			get 
			{
				object obj = base.GetValue("AdvApproveBE") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AdvApproveBEKey==null || m_AdvApproveBEKey.ID != key )
					m_AdvApproveBEKey = new UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE.EntityKey(key); 
				return m_AdvApproveBEKey ;
			}
			set
			{	
				if (AdvApproveBEKey==value)
					return ;
				this.SetRelation("AdvApproveBE", null);
				m_AdvApproveBEKey = value ;
				if (value != null) 
				{
					base.SetValue("AdvApproveBE",value.ID);
				}
				else
					base.SetValue("AdvApproveBE",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 办事处名称 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.办事处名称
		/// </summary>
		/// <value></value>
			public  System.String AdvAppCustName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvAppCustName");
				return value;
				}
				set
			{
				
								base.SetValue("AdvAppCustName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 区/县 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.区/县
		/// </summary>
		/// <value></value>
			public  System.String Location
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Location");
				return value;
				}
				set
			{
				
								base.SetValue("Location", value);
						 
			}
		}
	



		
			/// <summary>
		/// 乡镇 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.乡镇
		/// </summary>
		/// <value></value>
			public  System.String Country
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Country");
				return value;
				}
				set
			{
				
								base.SetValue("Country", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户店名 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.客户店名
		/// </summary>
		/// <value></value>
			public  System.String CustCounterName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustCounterName");
				return value;
				}
				set
			{
				
								base.SetValue("CustCounterName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 联系人 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.联系人
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
		/// 联系电话 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.联系电话
		/// </summary>
		/// <value></value>
			public  System.String RelPhone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("RelPhone");
				return value;
				}
				set
			{
				
								base.SetValue("RelPhone", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户地址 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.客户地址
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
		/// 宽 (该属性可为空,但有默认值)
		/// 广告核销单行.ApplyInfo.宽
		/// </summary>
		/// <value></value>
			public  System.Decimal Width
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Width");
				return value;
				}
				set
			{
				
								base.SetValue("Width", value);
						 
			}
		}
	



		
			/// <summary>
		/// 厚 (该属性可为空,但有默认值)
		/// 广告核销单行.ApplyInfo.厚
		/// </summary>
		/// <value></value>
			public  System.Decimal Thick
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Thick");
				return value;
				}
				set
			{
				
								base.SetValue("Thick", value);
						 
			}
		}
	



		
			/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 广告核销单行.ApplyInfo.高
		/// </summary>
		/// <value></value>
			public  System.Decimal Height
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Height");
				return value;
				}
				set
			{
				
								base.SetValue("Height", value);
						 
			}
		}
	



		
			/// <summary>
		/// 面积 (该属性可为空,但有默认值)
		/// 广告核销单行.ApplyInfo.面积
		/// </summary>
		/// <value></value>
			public  System.Decimal Area
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Area");
				return value;
				}
				set
			{
				
								base.SetValue("Area", value);
						 
			}
		}
	



		
			/// <summary>
		/// 广告编号 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.广告编号
		/// </summary>
		/// <value></value>
			public  System.String ApplyAdvCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ApplyAdvCode");
				return value;
				}
				set
			{
				
								base.SetValue("ApplyAdvCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 广告载体 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.广告载体
		/// </summary>
		/// <value></value>
			public  System.String AdvCarrier
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvCarrier");
				return value;
				}
				set
			{
				
								base.SetValue("AdvCarrier", value);
						 
			}
		}
	



		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 广告核销单行.ApproveInfo.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal ApplyQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ApplyQty");
				return value;
				}
				set
			{
				
								base.SetValue("ApplyQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 广告核销单行.ApproveInfo.单价
		/// </summary>
		/// <value></value>
			public  System.Decimal Price
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Price");
				return value;
				}
				set
			{
				
								base.SetValue("Price", value);
						 
			}
		}
	



		
			/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 广告核销单行.ApproveInfo.金额
		/// </summary>
		/// <value></value>
			public  System.Decimal TotalMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TotalMoney");
				return value;
				}
				set
			{
				
								base.SetValue("TotalMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收据编号 (该属性可为空,且无默认值)
		/// 广告核销单行.ApproveInfo.收据编号
		/// </summary>
		/// <value></value>
			public  System.String ReceiptNum
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ReceiptNum");
				return value;
				}
				set
			{
				
								base.SetValue("ReceiptNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 广告核销单行.ApproveInfo.备注
		/// </summary>
		/// <value></value>
			public  System.String Momo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Momo");
				return value;
				}
				set
			{
				
								base.SetValue("Momo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际核销数量 (该属性可为空,但有默认值)
		/// 广告核销单行.AuditInfo.实际核销数量
		/// </summary>
		/// <value></value>
			public  System.Decimal ActualApproveQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ActualApproveQty");
				return value;
				}
				set
			{
				
								base.SetValue("ActualApproveQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 核销单价 (该属性可为空,但有默认值)
		/// 广告核销单行.AuditInfo.核销单价
		/// </summary>
		/// <value></value>
			public  System.Decimal ActualPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ActualPrice");
				return value;
				}
				set
			{
				
								base.SetValue("ActualPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折扣率 (该属性可为空,但有默认值)
		/// 广告核销单行.AuditInfo.折扣率
		/// </summary>
		/// <value></value>
			public  System.Decimal Discount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Discount");
				return value;
				}
				set
			{
				
								base.SetValue("Discount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 核销金额 (该属性可为空,但有默认值)
		/// 广告核销单行.AuditInfo.核销金额
		/// </summary>
		/// <value></value>
			public  System.Decimal ApproveMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ApproveMoney");
				return value;
				}
				set
			{
				
								base.SetValue("ApproveMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 广告项目 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.广告项目
		/// </summary>
		/// <value></value>
			public  System.String AdvItem
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvItem");
				return value;
				}
				set
			{
				
								base.SetValue("AdvItem", value);
						 
			}
		}
	



		
			/// <summary>
		/// 用于定位行 (该属性可为空,但有默认值)
		/// 广告核销单行.Misc.用于定位行
		/// </summary>
		/// <value></value>
			public  System.Int64 OtherInfo
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("OtherInfo");
				return value;
				}
				set
			{
				
								base.SetValue("OtherInfo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 核销异常说明 (该属性可为空,且无默认值)
		/// 广告核销单行.Misc.核销异常说明
		/// </summary>
		/// <value></value>
			public  System.String ApproveExDeclaration
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ApproveExDeclaration");
				return value;
				}
				set
			{
				
								base.SetValue("ApproveExDeclaration", value);
						 
			}
		}
	



		
			/// <summary>
		/// 下单日期 (该属性可为空,且无默认值)
		/// 广告核销单行.Misc.下单日期
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
		/// 广告载体编号 (该属性可为空,且无默认值)
		/// 广告核销单行.ApplyInfo.广告载体编号
		/// </summary>
		/// <value></value>
			public  System.String AdvCarrierCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("AdvCarrierCode");
				return value;
				}
				set
			{
				
								base.SetValue("AdvCarrierCode", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvApproveBE")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvApproveBE　{ get { return EntityRes.GetResource("AdvApproveBE");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvAppCustName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvAppCustName　{ get { return EntityRes.GetResource("AdvAppCustName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Location")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Location　{ get { return EntityRes.GetResource("Location");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Country")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Country　{ get { return EntityRes.GetResource("Country");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustCounterName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustCounterName　{ get { return EntityRes.GetResource("CustCounterName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RelPeople")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RelPeople　{ get { return EntityRes.GetResource("RelPeople");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RelPhone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RelPhone　{ get { return EntityRes.GetResource("RelPhone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustAddress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustAddress　{ get { return EntityRes.GetResource("CustAddress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Width")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Width　{ get { return EntityRes.GetResource("Width");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Thick")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Thick　{ get { return EntityRes.GetResource("Thick");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Height")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Height　{ get { return EntityRes.GetResource("Height");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Area")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Area　{ get { return EntityRes.GetResource("Area");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyAdvCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyAdvCode　{ get { return EntityRes.GetResource("ApplyAdvCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvCarrier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvCarrier　{ get { return EntityRes.GetResource("AdvCarrier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyQty　{ get { return EntityRes.GetResource("ApplyQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Price")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Price　{ get { return EntityRes.GetResource("Price");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalMoney　{ get { return EntityRes.GetResource("TotalMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ReceiptNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ReceiptNum　{ get { return EntityRes.GetResource("ReceiptNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Momo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Momo　{ get { return EntityRes.GetResource("Momo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualApproveQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualApproveQty　{ get { return EntityRes.GetResource("ActualApproveQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualPrice　{ get { return EntityRes.GetResource("ActualPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Discount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Discount　{ get { return EntityRes.GetResource("Discount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApproveMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApproveMoney　{ get { return EntityRes.GetResource("ApproveMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvItem")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvItem　{ get { return EntityRes.GetResource("AdvItem");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OtherInfo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OtherInfo　{ get { return EntityRes.GetResource("OtherInfo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApproveExDeclaration")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApproveExDeclaration　{ get { return EntityRes.GetResource("ApproveExDeclaration");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyDate　{ get { return EntityRes.GetResource("ApplyDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdvCarrierCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdvCarrierCode　{ get { return EntityRes.GetResource("AdvCarrierCode");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "AdvApproveLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine";　}　}
		
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
			/// 属性: 广告核销单 的名称
			/// </summary>
			public static string AdvApproveBE　{ get { return "AdvApproveBE";　}　}
				
			/// <summary>
			/// 属性: 办事处名称 的名称
			/// </summary>
			public static string AdvAppCustName　{ get { return "AdvAppCustName";　}　}
				
			/// <summary>
			/// 属性: 区/县 的名称
			/// </summary>
			public static string Location　{ get { return "Location";　}　}
				
			/// <summary>
			/// 属性: 乡镇 的名称
			/// </summary>
			public static string Country　{ get { return "Country";　}　}
				
			/// <summary>
			/// 属性: 客户店名 的名称
			/// </summary>
			public static string CustCounterName　{ get { return "CustCounterName";　}　}
				
			/// <summary>
			/// 属性: 联系人 的名称
			/// </summary>
			public static string RelPeople　{ get { return "RelPeople";　}　}
				
			/// <summary>
			/// 属性: 联系电话 的名称
			/// </summary>
			public static string RelPhone　{ get { return "RelPhone";　}　}
				
			/// <summary>
			/// 属性: 客户地址 的名称
			/// </summary>
			public static string CustAddress　{ get { return "CustAddress";　}　}
				
			/// <summary>
			/// 属性: 宽 的名称
			/// </summary>
			public static string Width　{ get { return "Width";　}　}
				
			/// <summary>
			/// 属性: 厚 的名称
			/// </summary>
			public static string Thick　{ get { return "Thick";　}　}
				
			/// <summary>
			/// 属性: 高 的名称
			/// </summary>
			public static string Height　{ get { return "Height";　}　}
				
			/// <summary>
			/// 属性: 面积 的名称
			/// </summary>
			public static string Area　{ get { return "Area";　}　}
				
			/// <summary>
			/// 属性: 广告编号 的名称
			/// </summary>
			public static string ApplyAdvCode　{ get { return "ApplyAdvCode";　}　}
				
			/// <summary>
			/// 属性: 广告载体 的名称
			/// </summary>
			public static string AdvCarrier　{ get { return "AdvCarrier";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string ApplyQty　{ get { return "ApplyQty";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string Price　{ get { return "Price";　}　}
				
			/// <summary>
			/// 属性: 金额 的名称
			/// </summary>
			public static string TotalMoney　{ get { return "TotalMoney";　}　}
				
			/// <summary>
			/// 属性: 收据编号 的名称
			/// </summary>
			public static string ReceiptNum　{ get { return "ReceiptNum";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Momo　{ get { return "Momo";　}　}
				
			/// <summary>
			/// 属性: 实际核销数量 的名称
			/// </summary>
			public static string ActualApproveQty　{ get { return "ActualApproveQty";　}　}
				
			/// <summary>
			/// 属性: 核销单价 的名称
			/// </summary>
			public static string ActualPrice　{ get { return "ActualPrice";　}　}
				
			/// <summary>
			/// 属性: 折扣率 的名称
			/// </summary>
			public static string Discount　{ get { return "Discount";　}　}
				
			/// <summary>
			/// 属性: 核销金额 的名称
			/// </summary>
			public static string ApproveMoney　{ get { return "ApproveMoney";　}　}
				
			/// <summary>
			/// 属性: 广告项目 的名称
			/// </summary>
			public static string AdvItem　{ get { return "AdvItem";　}　}
				
			/// <summary>
			/// 属性: 用于定位行 的名称
			/// </summary>
			public static string OtherInfo　{ get { return "OtherInfo";　}　}
				
			/// <summary>
			/// 属性: 核销异常说明 的名称
			/// </summary>
			public static string ApproveExDeclaration　{ get { return "ApproveExDeclaration";　}　}
				
			/// <summary>
			/// 属性: 下单日期 的名称
			/// </summary>
			public static string ApplyDate　{ get { return "ApplyDate";　}　}
				
			/// <summary>
			/// 属性: 广告载体编号 的名称
			/// </summary>
			public static string AdvCarrierCode　{ get { return "AdvCarrierCode";　}　}
		
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
			this.exdMultiLangAttrs.Add("AdvApproveBE","AdvApproveBE");
			this.exdMultiLangAttrs.Add("AdvAppCustName","AdvAppCustName");
			this.exdMultiLangAttrs.Add("Location","Location");
			this.exdMultiLangAttrs.Add("Country","Country");
			this.exdMultiLangAttrs.Add("CustCounterName","CustCounterName");
			this.exdMultiLangAttrs.Add("RelPeople","RelPeople");
			this.exdMultiLangAttrs.Add("RelPhone","RelPhone");
			this.exdMultiLangAttrs.Add("CustAddress","CustAddress");
			this.exdMultiLangAttrs.Add("Width","Width");
			this.exdMultiLangAttrs.Add("Thick","Thick");
			this.exdMultiLangAttrs.Add("Height","Height");
			this.exdMultiLangAttrs.Add("Area","Area");
			this.exdMultiLangAttrs.Add("ApplyAdvCode","ApplyAdvCode");
			this.exdMultiLangAttrs.Add("AdvCarrier","AdvCarrier");
			this.exdMultiLangAttrs.Add("ApplyQty","ApplyQty");
			this.exdMultiLangAttrs.Add("Price","Price");
			this.exdMultiLangAttrs.Add("TotalMoney","TotalMoney");
			this.exdMultiLangAttrs.Add("ReceiptNum","ReceiptNum");
			this.exdMultiLangAttrs.Add("Momo","Momo");
			this.exdMultiLangAttrs.Add("ActualApproveQty","ActualApproveQty");
			this.exdMultiLangAttrs.Add("ActualPrice","ActualPrice");
			this.exdMultiLangAttrs.Add("Discount","Discount");
			this.exdMultiLangAttrs.Add("ApproveMoney","ApproveMoney");
			this.exdMultiLangAttrs.Add("AdvItem","AdvItem");
			this.exdMultiLangAttrs.Add("OtherInfo","OtherInfo");
			this.exdMultiLangAttrs.Add("ApproveExDeclaration","ApproveExDeclaration");
			this.exdMultiLangAttrs.Add("ApplyDate","ApplyDate");
			this.exdMultiLangAttrs.Add("AdvCarrierCode","AdvCarrierCode");
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
		private void DeSerializeKey(AdvApproveLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			AdvApproveLineData data = dto as AdvApproveLineData ;
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
		public void FromEntityData(AdvApproveLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(AdvApproveLineData data,IDictionary dict)
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
		
								this.SetTypeValue("AdvAppCustName",data.AdvAppCustName);
		
								this.SetTypeValue("Location",data.Location);
		
								this.SetTypeValue("Country",data.Country);
		
								this.SetTypeValue("CustCounterName",data.CustCounterName);
		
								this.SetTypeValue("RelPeople",data.RelPeople);
		
								this.SetTypeValue("RelPhone",data.RelPhone);
		
								this.SetTypeValue("CustAddress",data.CustAddress);
		
								this.SetTypeValue("Width",data.Width);
		
								this.SetTypeValue("Thick",data.Thick);
		
								this.SetTypeValue("Height",data.Height);
		
								this.SetTypeValue("Area",data.Area);
		
								this.SetTypeValue("ApplyAdvCode",data.ApplyAdvCode);
		
								this.SetTypeValue("AdvCarrier",data.AdvCarrier);
		
								this.SetTypeValue("ApplyQty",data.ApplyQty);
		
								this.SetTypeValue("Price",data.Price);
		
								this.SetTypeValue("TotalMoney",data.TotalMoney);
		
								this.SetTypeValue("ReceiptNum",data.ReceiptNum);
		
								this.SetTypeValue("Momo",data.Momo);
		
								this.SetTypeValue("ActualApproveQty",data.ActualApproveQty);
		
								this.SetTypeValue("ActualPrice",data.ActualPrice);
		
								this.SetTypeValue("Discount",data.Discount);
		
								this.SetTypeValue("ApproveMoney",data.ApproveMoney);
		
								this.SetTypeValue("AdvItem",data.AdvItem);
		
								this.SetTypeValue("OtherInfo",data.OtherInfo);
		
								this.SetTypeValue("ApproveExDeclaration",data.ApproveExDeclaration);
		
								this.SetTypeValue("ApplyDate",data.ApplyDate);
		
								this.SetTypeValue("AdvCarrierCode",data.AdvCarrierCode);
		
			#endregion 

			#region 组件内属性
	
					if (data.AdvApproveBE!=null)
			{
				UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE child = dict[data.AdvApproveBE] as UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE ;
				if (child == null)
				{
					if (data.AdvApproveBE.ID>0)
					{
						if (data.AdvApproveBE.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.AdvApproveBE.ID,data.AdvApproveBE.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.AdvApproveBE.SysEntityType,null,data.AdvApproveBE.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.AdvApproveBE.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.AdvApproveBE,dict);
				}
				this.AdvApproveBE = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public AdvApproveLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AdvApproveLineData ToEntityData(AdvApproveLineData data, IDictionary dict){
			if (data == null)
				data = new AdvApproveLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("AdvAppCustName");
				if (obj != null)
					data.AdvAppCustName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Location");
				if (obj != null)
					data.Location=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Country");
				if (obj != null)
					data.Country=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustCounterName");
				if (obj != null)
					data.CustCounterName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RelPeople");
				if (obj != null)
					data.RelPeople=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RelPhone");
				if (obj != null)
					data.RelPhone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustAddress");
				if (obj != null)
					data.CustAddress=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Width");
				if (obj != null)
					data.Width=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Thick");
				if (obj != null)
					data.Thick=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Height");
				if (obj != null)
					data.Height=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Area");
				if (obj != null)
					data.Area=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyAdvCode");
				if (obj != null)
					data.ApplyAdvCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvCarrier");
				if (obj != null)
					data.AdvCarrier=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyQty");
				if (obj != null)
					data.ApplyQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Price");
				if (obj != null)
					data.Price=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalMoney");
				if (obj != null)
					data.TotalMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ReceiptNum");
				if (obj != null)
					data.ReceiptNum=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Momo");
				if (obj != null)
					data.Momo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualApproveQty");
				if (obj != null)
					data.ActualApproveQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualPrice");
				if (obj != null)
					data.ActualPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Discount");
				if (obj != null)
					data.Discount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApproveMoney");
				if (obj != null)
					data.ApproveMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvItem");
				if (obj != null)
					data.AdvItem=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OtherInfo");
				if (obj != null)
					data.OtherInfo=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApproveExDeclaration");
				if (obj != null)
					data.ApproveExDeclaration=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyDate");
				if (obj != null)
					data.ApplyDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdvCarrierCode");
				if (obj != null)
					data.AdvCarrierCode=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("AdvApproveBE");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData _AdvApproveBE = dict["UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE"+oID.ToString()] as UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData;			
					data.AdvApproveBE = (_AdvApproveBE != null) ? _AdvApproveBE : (this.AdvApproveBE==null?null:this.AdvApproveBE.ToEntityData(null,dict));
				}
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