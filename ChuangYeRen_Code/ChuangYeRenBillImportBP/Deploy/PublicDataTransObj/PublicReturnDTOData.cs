



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace PublicDataTransObj
{
	/// <summary>
	/// 返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "PublicDataTransObj.PublicReturnDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class PublicReturnDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public PublicReturnDTOData()
		{
			initData();
		}
		private void initData()
		{
					Flag=false; 
		
		
		

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
		public PublicReturnDTOData(  System.Boolean flag  , System.String message  , System.String docNo  , System.String docID  )
		{
			initData();
			this.Flag = flag;
			this.Message = message;
			this.DocNo = docNo;
			this.DocID = docID;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 返回标志
		/// 返回对象.Misc.返回标志
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_flag ;
		public System.Boolean Flag
		{
			get	
			{	
				return m_flag ;
			}
			set	
			{	
				m_flag = value ;	
			}
		}
			
		

		/// <summary>
		/// 返回信息
		/// 返回对象.Misc.返回信息
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
		/// 单号
		/// 返回对象.Misc.单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据ID
		/// 返回对象.Misc.单据ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docID ;
		public System.String DocID
		{
			get	
			{	
				return m_docID ;
			}
			set	
			{	
				m_docID = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
