
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE
{
	/// <summary>
	/// 广告单据类型 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocTypeData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class SpecialApplyDocTypeData : UFIDA.U9.Base.Doc.DocTypeData
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
		public SpecialApplyDocTypeData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     							AdvDocEnum= 0; 		

			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 广告单据对象
		/// 广告单据类型.Misc.广告单据对象
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_advDocEnum;
		public System.Int32 AdvDocEnum
		{
			get	
			{	
				return m_advDocEnum ;
			}
			set	
			{	
				m_advDocEnum = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
				#endregion	

		#region Multi_Fields
	
		#endregion 		
	}	

}

