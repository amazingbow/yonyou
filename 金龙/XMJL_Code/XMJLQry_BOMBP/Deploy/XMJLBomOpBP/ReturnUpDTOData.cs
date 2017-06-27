



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	/// <summary>
	/// 返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ReturnUpDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ReturnUpDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		

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
		public ReturnUpDTOData(  System.String msg  , System.String status  )
		{
			initData();
			this.Msg = msg;
			this.Status = status;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 返回消息
		/// 返回对象.Misc.返回消息
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_msg ;
		public System.String Msg
		{
			get	
			{	
				return m_msg ;
			}
			set	
			{	
				m_msg = value ;	
			}
		}
			
		

		/// <summary>
		/// 状态
		/// 返回对象.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_status ;
		public System.String Status
		{
			get	
			{	
				return m_status ;
			}
			set	
			{	
				m_status = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
				
		#endregion 
	} 	
}

	
