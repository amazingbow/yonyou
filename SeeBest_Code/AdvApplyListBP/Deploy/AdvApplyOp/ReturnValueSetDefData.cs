



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp
{
	/// <summary>
	/// 值集数据返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ReturnValueSetDefData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ReturnValueSetDefData()
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
		public ReturnValueSetDefData(  System.String code  , System.String name  , System.String description  )
		{
			initData();
			this.Code = code;
			this.Name = name;
			this.Description = description;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 编码
		/// 值集数据返回对象.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
			
		

		/// <summary>
		/// 名称
		/// 值集数据返回对象.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_name ;
		public System.String Name
		{
			get	
			{	
				return m_name ;
			}
			set	
			{	
				m_name = value ;	
			}
		}
			
		

		/// <summary>
		/// 简码描述
		/// 值集数据返回对象.Misc.简码描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_description ;
		public System.String Description
		{
			get	
			{	
				return m_description ;
			}
			set	
			{	
				m_description = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						
		#endregion 
	} 	
}

	
