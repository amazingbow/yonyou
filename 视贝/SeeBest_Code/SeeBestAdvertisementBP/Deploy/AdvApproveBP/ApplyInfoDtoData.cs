



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
	/// <summary>
	/// 申请单信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ApplyInfoDtoData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                                                                                                                                                    
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public ApplyInfoDtoData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					Width=0m; 
					Thick=0m; 
					Height=0m; 
		
		
		
					ApplyId= 0; 
							Area=0m; 
					ApplyQty=0m; 
		
					ActualPrice=0m; 
		
		

			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
		#region Do SerializeKey -ForDTODataType
		//只为处理集合型EntityKey。原因集合型EntityKey由于使用臫的集合对象，无法实现数据共享.-UBF专用.
		public void DoSerializeKeyList(IDictionary dict)
		{
			if (dict == null ) dict = new Hashtable() ;
			if (dict[this] != null)
				return ;
			dict[this] = this;
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public ApplyInfoDtoData(  System.String location  , System.String advAppCustName  , System.String country  , System.String custCounterName  , System.String relPeople  , System.String relPhone  , System.String custAddress  , System.Decimal width  , System.Decimal thick  , System.Decimal height  , System.String applyAdvCode  , System.String advCarrier  , System.String advItem  , System.Int64 applyId  , System.Decimal area  , System.Decimal applyQty  , System.String memo  , System.Decimal actualPrice  , System.DateTime applyDate  , System.String advCarrierCode  )
		{
			initData();
			this.Location = location;
			this.AdvAppCustName = advAppCustName;
			this.Country = country;
			this.CustCounterName = custCounterName;
			this.RelPeople = relPeople;
			this.RelPhone = relPhone;
			this.CustAddress = custAddress;
			this.Width = width;
			this.Thick = thick;
			this.Height = height;
			this.ApplyAdvCode = applyAdvCode;
			this.AdvCarrier = advCarrier;
			this.AdvItem = advItem;
			this.ApplyId = applyId;
			this.Area = area;
			this.ApplyQty = applyQty;
			this.Memo = memo;
			this.ActualPrice = actualPrice;
			this.ApplyDate = applyDate;
			this.AdvCarrierCode = advCarrierCode;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 区县
		/// 申请单信息.Misc.区县
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_location ;
		public System.String Location
		{
			get	
			{	
				return m_location ;
			}
			set	
			{	
				m_location = value ;	
			}
		}
			
		

		/// <summary>
		/// 办事处
		/// 申请单信息.Misc.办事处
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advAppCustName ;
		public System.String AdvAppCustName
		{
			get	
			{	
				return m_advAppCustName ;
			}
			set	
			{	
				m_advAppCustName = value ;	
			}
		}
			
		

		/// <summary>
		/// 乡镇
		/// 申请单信息.Misc.乡镇
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_country ;
		public System.String Country
		{
			get	
			{	
				return m_country ;
			}
			set	
			{	
				m_country = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户店名
		/// 申请单信息.Misc.客户店名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custCounterName ;
		public System.String CustCounterName
		{
			get	
			{	
				return m_custCounterName ;
			}
			set	
			{	
				m_custCounterName = value ;	
			}
		}
			
		

		/// <summary>
		/// 联系人
		/// 申请单信息.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relPeople ;
		public System.String RelPeople
		{
			get	
			{	
				return m_relPeople ;
			}
			set	
			{	
				m_relPeople = value ;	
			}
		}
			
		

		/// <summary>
		/// 联系电话
		/// 申请单信息.Misc.联系电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_relPhone ;
		public System.String RelPhone
		{
			get	
			{	
				return m_relPhone ;
			}
			set	
			{	
				m_relPhone = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户地址
		/// 申请单信息.Misc.客户地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_custAddress ;
		public System.String CustAddress
		{
			get	
			{	
				return m_custAddress ;
			}
			set	
			{	
				m_custAddress = value ;	
			}
		}
			
		

		/// <summary>
		/// 宽
		/// 申请单信息.Misc.宽
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_width ;
		public System.Decimal Width
		{
			get	
			{	
				return m_width ;
			}
			set	
			{	
				m_width = value ;	
			}
		}
			
		

		/// <summary>
		/// 厚
		/// 申请单信息.Misc.厚
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_thick ;
		public System.Decimal Thick
		{
			get	
			{	
				return m_thick ;
			}
			set	
			{	
				m_thick = value ;	
			}
		}
			
		

		/// <summary>
		/// 高
		/// 申请单信息.Misc.高
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_height ;
		public System.Decimal Height
		{
			get	
			{	
				return m_height ;
			}
			set	
			{	
				m_height = value ;	
			}
		}
			
		

		/// <summary>
		/// 广告编码
		/// 申请单信息.Misc.广告编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_applyAdvCode ;
		public System.String ApplyAdvCode
		{
			get	
			{	
				return m_applyAdvCode ;
			}
			set	
			{	
				m_applyAdvCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 广告载体
		/// 申请单信息.Misc.广告载体
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advCarrier ;
		public System.String AdvCarrier
		{
			get	
			{	
				return m_advCarrier ;
			}
			set	
			{	
				m_advCarrier = value ;	
			}
		}
			
		

		/// <summary>
		/// 广告项目
		/// 申请单信息.Misc.广告项目
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advItem ;
		public System.String AdvItem
		{
			get	
			{	
				return m_advItem ;
			}
			set	
			{	
				m_advItem = value ;	
			}
		}
			
		

		/// <summary>
		/// 申请单ID
		/// 申请单信息.Misc.申请单ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_applyId ;
		public System.Int64 ApplyId
		{
			get	
			{	
				return m_applyId ;
			}
			set	
			{	
				m_applyId = value ;	
			}
		}
			
		

		/// <summary>
		/// 面积
		/// 申请单信息.Misc.面积
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_area ;
		public System.Decimal Area
		{
			get	
			{	
				return m_area ;
			}
			set	
			{	
				m_area = value ;	
			}
		}
			
		

		/// <summary>
		/// 数量
		/// 申请单信息.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_applyQty ;
		public System.Decimal ApplyQty
		{
			get	
			{	
				return m_applyQty ;
			}
			set	
			{	
				m_applyQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// 申请单信息.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
			
		

		/// <summary>
		/// 核销单价
		/// 申请单信息.Misc.核销单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_actualPrice ;
		public System.Decimal ActualPrice
		{
			get	
			{	
				return m_actualPrice ;
			}
			set	
			{	
				m_actualPrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 下单日期
		/// 申请单信息.Misc.下单日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_applyDate ;
		public System.DateTime ApplyDate
		{
			get	
			{	
				return m_applyDate ;
			}
			set	
			{	
				m_applyDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 广告载体编号
		/// 申请单信息.Misc.广告载体编号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_advCarrierCode ;
		public System.String AdvCarrierCode
		{
			get	
			{	
				return m_advCarrierCode ;
			}
			set	
			{	
				m_advCarrierCode = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																								
		#endregion 
	} 	
}

	
