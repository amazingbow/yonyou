



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件变更车信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeCarDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BomChangeCarDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
            knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData));                                                                  
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public BomChangeCarDTOData()
		{
			initData();
		}
		private void initData()
		{
		
					CarID= 0; 
				
		
		
		

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
	        			if (this.BomChangeDTO != null) 
			{
				this.BomChangeDTO.DoSerializeKeyList(dict);
			}
	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public BomChangeCarDTOData(  UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData bomChangeDTO  , System.Int64 carID  , System.String carType  , System.String contractNo  , System.String carCode  , System.String carName  )
		{
			initData();
			this.BomChangeDTO = bomChangeDTO;
			this.CarID = carID;
			this.CarType = carType;
			this.ContractNo = contractNo;
			this.CarCode = carCode;
			this.CarName = carName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 缺件变更头信息
		/// 缺件变更车信息.Misc.缺件变更头信息
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData m_bomChangeDTO ;
		public UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData BomChangeDTO
		{
			get	
			{	
				return m_bomChangeDTO ;
			}
			set	
			{	
				m_bomChangeDTO = value ;	
			}
		}
			
		

		/// <summary>
		/// 车号
		/// 缺件变更车信息.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_carID ;
		public System.Int64 CarID
		{
			get	
			{	
				return m_carID ;
			}
			set	
			{	
				m_carID = value ;	
			}
		}
			
		

		/// <summary>
		/// 车型
		/// 缺件变更车信息.Misc.车型
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
			
		

		/// <summary>
		/// 合同号
		/// 缺件变更车信息.Misc.合同号
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
		/// 车号Code
		/// 缺件变更车信息.Misc.车号Code
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carCode ;
		public System.String CarCode
		{
			get	
			{	
				return m_carCode ;
			}
			set	
			{	
				m_carCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 车号Name
		/// 缺件变更车信息.Misc.车号Name
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carName ;
		public System.String CarName
		{
			get	
			{	
				return m_carName ;
			}
			set	
			{	
				m_carName = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
