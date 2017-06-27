



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 拆分车号数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SplitCarDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SplitCarDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
					Sequence= 0; 
		
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
		public SplitCarDTOData(  System.String plsID  , System.String manufactureNo  , System.Int32 sequence  )
		{
			initData();
			this.PlsID = plsID;
			this.ManufactureNo = manufactureNo;
			this.Sequence = sequence;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 生产线料品日计划ID
		/// 拆分车号数据传输对象.Misc.生产线料品日计划ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_plsID ;
		public System.String PlsID
		{
			get	
			{	
				return m_plsID ;
			}
			set	
			{	
				m_plsID = value ;	
			}
		}
			
		

		/// <summary>
		/// 车号
		/// 拆分车号数据传输对象.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_manufactureNo ;
		public System.String ManufactureNo
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
		/// 车序
		/// 拆分车号数据传输对象.Misc.车序
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sequence ;
		public System.Int32 Sequence
		{
			get	
			{	
				return m_sequence ;
			}
			set	
			{	
				m_sequence = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						
		#endregion 
	} 	
}

	
