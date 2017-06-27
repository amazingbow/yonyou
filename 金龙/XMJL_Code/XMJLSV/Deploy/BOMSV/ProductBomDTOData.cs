



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	/// <summary>
	/// 车辆BomDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ProductBomDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                         
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData>)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public ProductBomDTOData()
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
	        	        			if (this.Bom!=null)
			{
				foreach(UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData objdata in this.Bom)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
			
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public ProductBomDTOData(  System.String manufactureNo  , List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData> bom  )
		{
			initData();
			this.ManufactureNo = manufactureNo;
			this.Bom = bom;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 车号
		/// 车辆BomDTO.Misc.车号
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
		/// BOM集合
		/// 车辆BomDTO.Misc.BOM集合
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData> m_bom ;
		public List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData> Bom
		{
			get	
			{	
				if (m_bom == null )
				{
					List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData> n_m_list = new List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData>() ;
					m_bom = n_m_list ;
				}
				return m_bom ;
			}
			set	
			{	
				m_bom = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
				
		#endregion 
	} 	
}

	
