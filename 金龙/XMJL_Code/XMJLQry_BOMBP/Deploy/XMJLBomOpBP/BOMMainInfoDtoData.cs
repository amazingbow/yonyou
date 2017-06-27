



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	/// <summary>
	/// 缺件主表信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BOMMainInfoDtoData : UFSoft.UBF.Business.DataTransObjectBase
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
		public BOMMainInfoDtoData()
		{
			initData();
		}
		private void initData()
		{
					ManufactureNo= 0; 
				
		
		
		
					No= 0; 
		
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
		public BOMMainInfoDtoData(  System.Int64 manufactureNo  , System.String contractNo  , System.String carType  , System.String manufactureNo_Code  , System.String manufactureNo_Name  , System.Int32 no  )
		{
			initData();
			this.ManufactureNo = manufactureNo;
			this.ContractNo = contractNo;
			this.CarType = carType;
			this.ManufactureNo_Code = manufactureNo_Code;
			this.ManufactureNo_Name = manufactureNo_Name;
			this.No = no;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 车号
		/// 缺件主表信息DTO.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_manufactureNo ;
		public System.Int64 ManufactureNo
		{
			get	
			{	
				return m_manufactureNo ;
			}
			set	
			{	
				m_manufactureNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 合同号
		/// 缺件主表信息DTO.Misc.合同号
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
		/// 车型
		/// 缺件主表信息DTO.Misc.车型
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
		/// 编码
		/// 缺件主表信息DTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_manufactureNo_Code ;
		public System.String ManufactureNo_Code
		{
			get	
			{	
				return m_manufactureNo_Code ;
			}
			set	
			{	
				m_manufactureNo_Code = value ;	
			}
		}
			
		

		/// <summary>
		/// 项目名称
		/// 缺件主表信息DTO.Misc.项目名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_manufactureNo_Name ;
		public System.String ManufactureNo_Name
		{
			get	
			{	
				return m_manufactureNo_Name ;
			}
			set	
			{	
				m_manufactureNo_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 序号
		/// 缺件主表信息DTO.Misc.序号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_no ;
		public System.Int32 No
		{
			get	
			{	
				return m_no ;
			}
			set	
			{	
				m_no = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
