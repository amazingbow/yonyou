
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{
	/// <summary>
	/// 广告核销单行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class AdvApproveLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public AdvApproveLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							Width=0m; 
	     							Thick=0m; 
	     							Height=0m; 
	     							Area=0m; 
	     			
	     			
	     							ApplyQty=0m; 
	     							Price=0m; 
	     							TotalMoney=0m; 
	     			
	     			
	     							ActualApproveQty=0m; 
	     							ActualPrice=0m; 
	     							Discount=0m; 
	     							ApproveMoney=0m; 


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
			get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_advApproveBE_SKey ;
			/// <summary>
			/// 广告核销单 序列化Key属性。（传递跨组织序列列字段）
			/// 广告核销单行.Misc.广告核销单
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey AdvApproveBE_SKey
			{
				get 
				{
					return m_advApproveBE_SKey ;					
				}
				set
				{
					m_advApproveBE_SKey = value ;	
				}
			}
		/// <summary>
		/// 广告核销单
		/// 广告核销单行.Misc.广告核销单
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData m_advApproveBE;
		public UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData AdvApproveBE
		{
			get	
			{	
				return m_advApproveBE ;
			}
			set	
			{	
				m_advApproveBE = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 广告核销单行.Key.ID
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
		/// 广告核销单行.Sys.创建时间
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
		/// 广告核销单行.Sys.创建人
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
		/// 广告核销单行.Sys.修改时间
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
		/// 广告核销单行.Sys.修改人
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
		/// 广告核销单行.Sys.事务版本
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
		/// 办事处名称
		/// 广告核销单行.ApplyInfo.办事处名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advAppCustName ;
		public System.String AdvAppCustName
		{
			get	
			{	
				return m_advAppCustName  ;
			}
			set	
			{	
				m_advAppCustName = value ;	
			}
		}
		

				/// <summary>
		/// 区/县
		/// 广告核销单行.ApplyInfo.区/县
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_location ;
		public System.String Location
		{
			get	
			{	
				return m_location  ;
			}
			set	
			{	
				m_location = value ;	
			}
		}
		

				/// <summary>
		/// 乡镇
		/// 广告核销单行.ApplyInfo.乡镇
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_country ;
		public System.String Country
		{
			get	
			{	
				return m_country  ;
			}
			set	
			{	
				m_country = value ;	
			}
		}
		

				/// <summary>
		/// 客户店名
		/// 广告核销单行.ApplyInfo.客户店名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custCounterName ;
		public System.String CustCounterName
		{
			get	
			{	
				return m_custCounterName  ;
			}
			set	
			{	
				m_custCounterName = value ;	
			}
		}
		

				/// <summary>
		/// 联系人
		/// 广告核销单行.ApplyInfo.联系人
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
		/// 联系电话
		/// 广告核销单行.ApplyInfo.联系电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relPhone ;
		public System.String RelPhone
		{
			get	
			{	
				return m_relPhone  ;
			}
			set	
			{	
				m_relPhone = value ;	
			}
		}
		

				/// <summary>
		/// 客户地址
		/// 广告核销单行.ApplyInfo.客户地址
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
		

				/// <summary>
		/// 宽
		/// 广告核销单行.ApplyInfo.宽
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
		/// 厚
		/// 广告核销单行.ApplyInfo.厚
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
		/// 高
		/// 广告核销单行.ApplyInfo.高
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_height ;
		public System.Decimal Height
		{
			get	
			{	
				return m_height  ;
			}
			set	
			{	
				m_height = value ;	
			}
		}
		

				/// <summary>
		/// 面积
		/// 广告核销单行.ApplyInfo.面积
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
		/// 广告编号
		/// 广告核销单行.ApplyInfo.广告编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_applyAdvCode ;
		public System.String ApplyAdvCode
		{
			get	
			{	
				return m_applyAdvCode  ;
			}
			set	
			{	
				m_applyAdvCode = value ;	
			}
		}
		

				/// <summary>
		/// 广告载体
		/// 广告核销单行.ApplyInfo.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advItemName ;
		public System.String AdvItemName
		{
			get	
			{	
				return m_advItemName  ;
			}
			set	
			{	
				m_advItemName = value ;	
			}
		}
		

				/// <summary>
		/// 数量
		/// 广告核销单行.ApproveInfo.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_applyQty ;
		public System.Decimal ApplyQty
		{
			get	
			{	
				return m_applyQty  ;
			}
			set	
			{	
				m_applyQty = value ;	
			}
		}
		

				/// <summary>
		/// 单价
		/// 广告核销单行.ApproveInfo.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_price ;
		public System.Decimal Price
		{
			get	
			{	
				return m_price  ;
			}
			set	
			{	
				m_price = value ;	
			}
		}
		

				/// <summary>
		/// 金额
		/// 广告核销单行.ApproveInfo.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalMoney ;
		public System.Decimal TotalMoney
		{
			get	
			{	
				return m_totalMoney  ;
			}
			set	
			{	
				m_totalMoney = value ;	
			}
		}
		

				/// <summary>
		/// 收据编号
		/// 广告核销单行.ApproveInfo.收据编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_receiptNum ;
		public System.String ReceiptNum
		{
			get	
			{	
				return m_receiptNum  ;
			}
			set	
			{	
				m_receiptNum = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 广告核销单行.ApproveInfo.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_momo ;
		public System.String Momo
		{
			get	
			{	
				return m_momo  ;
			}
			set	
			{	
				m_momo = value ;	
			}
		}
		

				/// <summary>
		/// 实际核销数量
		/// 广告核销单行.AuditInfo.实际核销数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_actualApproveQty ;
		public System.Decimal ActualApproveQty
		{
			get	
			{	
				return m_actualApproveQty  ;
			}
			set	
			{	
				m_actualApproveQty = value ;	
			}
		}
		

				/// <summary>
		/// 核销单价
		/// 广告核销单行.AuditInfo.核销单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_actualPrice ;
		public System.Decimal ActualPrice
		{
			get	
			{	
				return m_actualPrice  ;
			}
			set	
			{	
				m_actualPrice = value ;	
			}
		}
		

				/// <summary>
		/// 折扣率
		/// 广告核销单行.AuditInfo.折扣率
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_discount ;
		public System.Decimal Discount
		{
			get	
			{	
				return m_discount  ;
			}
			set	
			{	
				m_discount = value ;	
			}
		}
		

				/// <summary>
		/// 核销金额
		/// 广告核销单行.AuditInfo.核销金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_approveMoney ;
		public System.Decimal ApproveMoney
		{
			get	
			{	
				return m_approveMoney  ;
			}
			set	
			{	
				m_approveMoney = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																													
		#endregion 		
	}	

}

