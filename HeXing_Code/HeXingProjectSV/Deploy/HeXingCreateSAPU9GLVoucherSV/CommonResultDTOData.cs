



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV
{
	/// <summary>
	/// 通用返回结果对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CommonResultDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CommonResultDTOData()
		{
			initData();
		}
		private void initData()
		{
					IsSuccess=false; 
		
		

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
		public CommonResultDTOData(  System.Boolean isSuccess  , System.String message  , System.Object resultObj  )
		{
			initData();
			this.IsSuccess = isSuccess;
			this.Message = message;
			this.ResultObj = resultObj;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 是否成功
		/// 通用返回结果对象.Misc.是否成功
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_isSuccess ;
		public System.Boolean IsSuccess
		{
			get	
			{	
				return m_isSuccess ;
			}
			set	
			{	
				m_isSuccess = value ;	
			}
		}
			
		

		/// <summary>
		/// 消息
		/// 通用返回结果对象.Misc.消息
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_message ;
		public System.String Message
		{
			get	
			{	
				return m_message ;
			}
			set	
			{	
				m_message = value ;	
			}
		}
			
		

		/// <summary>
		/// 返回对象
		/// 通用返回结果对象.Misc.返回对象
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Object m_resultObj ;
		public System.Object ResultObj
		{
			get	
			{	
				return m_resultObj ;
			}
			set	
			{	
				m_resultObj = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						
		#endregion 
	} 	
}

	
