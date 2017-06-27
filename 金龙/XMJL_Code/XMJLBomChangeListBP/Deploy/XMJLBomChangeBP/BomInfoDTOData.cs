



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件车辆信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BomInfoDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public BomInfoDTOData()
		{
			initData();
		}
		private void initData()
		{
					CarNoId= 0; 
				
		
		
		

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
		public BomInfoDTOData(  System.Int64 carNoId  , System.String carNoCode  , System.String carNoName  , System.String contractNo  , System.String carType  )
		{
			initData();
			this.CarNoId = carNoId;
			this.CarNoCode = carNoCode;
			this.CarNoName = carNoName;
			this.ContractNo = contractNo;
			this.CarType = carType;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 车号
		/// 缺件车辆信息.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_carNoId ;
		public System.Int64 CarNoId
		{
			get	
			{	
				return m_carNoId ;
			}
			set	
			{	
				m_carNoId = value ;	
			}
		}
			
		

		/// <summary>
		/// 车号Code
		/// 缺件车辆信息.Misc.车号Code
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carNoCode ;
		public System.String CarNoCode
		{
			get	
			{	
				return m_carNoCode ;
			}
			set	
			{	
				m_carNoCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 车号Name
		/// 缺件车辆信息.Misc.车号Name
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carNoName ;
		public System.String CarNoName
		{
			get	
			{	
				return m_carNoName ;
			}
			set	
			{	
				m_carNoName = value ;	
			}
		}
			
		

		/// <summary>
		/// 合同号
		/// 缺件车辆信息.Misc.合同号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_contractNo ;
		public System.String ContractNo
		{
			get	
			{	
				return m_contractNo ;
			}
			set	
			{	
				m_contractNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 属性
		/// 缺件车辆信息.Misc.属性
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carType ;
		public System.String CarType
		{
			get	
			{	
				return m_carType ;
			}
			set	
			{	
				m_carType = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
										
		#endregion 
	} 	
}

	
