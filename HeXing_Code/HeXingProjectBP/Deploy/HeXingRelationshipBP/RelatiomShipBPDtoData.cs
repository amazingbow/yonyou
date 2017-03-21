



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	/// <summary>
	/// 对照信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class RelatiomShipBPDtoData : UFSoft.UBF.Business.DataTransObjectBase
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
		public RelatiomShipBPDtoData()
		{
			initData();
		}
		private void initData()
		{
		
		
					FID= 0; 
				
		

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
		public RelatiomShipBPDtoData(  System.String fCode  , System.String fName  , System.Int64 fID  , System.String accountProperty  , System.String balanceDirection  )
		{
			initData();
			this.FCode = fCode;
			this.FName = fName;
			this.FID = fID;
			this.AccountProperty = accountProperty;
			this.BalanceDirection = balanceDirection;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 编码
		/// 对照信息DTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_fCode ;
		public System.String FCode
		{
			get	
			{	
				return m_fCode ;
			}
			set	
			{	
				m_fCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 名称
		/// 对照信息DTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_fName ;
		public System.String FName
		{
			get	
			{	
				return m_fName ;
			}
			set	
			{	
				m_fName = value ;	
			}
		}
			
		

		/// <summary>
		/// ID
		/// 对照信息DTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_fID ;
		public System.Int64 FID
		{
			get	
			{	
				return m_fID ;
			}
			set	
			{	
				m_fID = value ;	
			}
		}
			
		

		/// <summary>
		/// 科目属性
		/// 对照信息DTO.Misc.科目属性
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_accountProperty ;
		public System.String AccountProperty
		{
			get	
			{	
				return m_accountProperty ;
			}
			set	
			{	
				m_accountProperty = value ;	
			}
		}
			
		

		/// <summary>
		/// 余额方向
		/// 对照信息DTO.Misc.余额方向
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_balanceDirection ;
		public System.String BalanceDirection
		{
			get	
			{	
				return m_balanceDirection ;
			}
			set	
			{	
				m_balanceDirection = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
										
		#endregion 
	} 	
}

	
