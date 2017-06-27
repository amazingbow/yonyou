



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 收货行信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class RCVLineInfoDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public RCVLineInfoDTOData()
		{
			initData();
		}
		private void initData()
		{
					RCVLine= 0; 
							Amount=0m; 
					TotalMoney=0m; 
					Tax=0m; 

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
		public RCVLineInfoDTOData(  System.Int64 rCVLine  , System.Decimal amount  , System.Decimal totalMoney  , System.Decimal tax  )
		{
			initData();
			this.RCVLine = rCVLine;
			this.Amount = amount;
			this.TotalMoney = totalMoney;
			this.Tax = tax;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 收货退货行ID
		/// 收货行信息DTO.Misc.收货退货行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_rCVLine ;
		public System.Int64 RCVLine
		{
			get	
			{	
				return m_rCVLine ;
			}
			set	
			{	
				m_rCVLine = value ;	
			}
		}
			
		

		/// <summary>
		/// 收货行立账数量
		/// 收货行信息DTO.Misc.收货行立账数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_amount ;
		public System.Decimal Amount
		{
			get	
			{	
				return m_amount ;
			}
			set	
			{	
				m_amount = value ;	
			}
		}
			
		

		/// <summary>
		/// 收货行总价
		/// 收货行信息DTO.Misc.收货行总价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalMoney ;
		public System.Decimal TotalMoney
		{
			get	
			{	
				return m_totalMoney ;
			}
			set	
			{	
				m_totalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 税额
		/// 收货行信息DTO.Misc.税额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_tax ;
		public System.Decimal Tax
		{
			get	
			{	
				return m_tax ;
			}
			set	
			{	
				m_tax = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
