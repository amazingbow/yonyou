



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SRMRcvDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                                           
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData>)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SRMRcvDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
					Type="正常";
		
					InType="普通采购";
		
		
		
		
		
		

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
	        	        	        	        	        	        	        	        	        	        	        	        			if (this.SrmRcvLine!=null)
			{
				foreach(UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData objdata in this.SrmRcvLine)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
			
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public SRMRcvDTOData(  System.Int64 iD  , System.String docNo  , System.String sTNO  , System.String type  , System.String status  , System.String inType  , System.String cPersonCode  , System.DateTime inDate  , System.String cMaker  , System.String wareHouser  , System.String vendorCode  , List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData> srmRcvLine  )
		{
			initData();
			this.ID = iD;
			this.DocNo = docNo;
			this.STNO = sTNO;
			this.Type = type;
			this.Status = status;
			this.InType = inType;
			this.CPersonCode = cPersonCode;
			this.InDate = inDate;
			this.CMaker = cMaker;
			this.WareHouser = wareHouser;
			this.VendorCode = vendorCode;
			this.SrmRcvLine = srmRcvLine;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// SRM入库单DTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
			
		

		/// <summary>
		/// 单号
		/// SRM入库单DTO.Misc.单号
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
		/// 送货单号
		/// SRM入库单DTO.Misc.送货单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sTNO ;
		public System.String STNO
		{
			get	
			{	
				return m_sTNO ;
			}
			set	
			{	
				m_sTNO = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据类型
		/// SRM入库单DTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_type ;
		public System.String Type
		{
			get	
			{	
				return m_type ;
			}
			set	
			{	
				m_type = value ;	
			}
		}
			
		

		/// <summary>
		/// 状态
		/// SRM入库单DTO.Misc.状态
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
			
		

		/// <summary>
		/// 入库类型
		/// SRM入库单DTO.Misc.入库类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_inType ;
		public System.String InType
		{
			get	
			{	
				return m_inType ;
			}
			set	
			{	
				m_inType = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购员
		/// SRM入库单DTO.Misc.采购员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cPersonCode ;
		public System.String CPersonCode
		{
			get	
			{	
				return m_cPersonCode ;
			}
			set	
			{	
				m_cPersonCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 入库日期
		/// SRM入库单DTO.Misc.入库日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_inDate ;
		public System.DateTime InDate
		{
			get	
			{	
				return m_inDate ;
			}
			set	
			{	
				m_inDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// SRM入库单DTO.Misc.制单人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cMaker ;
		public System.String CMaker
		{
			get	
			{	
				return m_cMaker ;
			}
			set	
			{	
				m_cMaker = value ;	
			}
		}
			
		

		/// <summary>
		/// 仓库
		/// SRM入库单DTO.Misc.仓库
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wareHouser ;
		public System.String WareHouser
		{
			get	
			{	
				return m_wareHouser ;
			}
			set	
			{	
				m_wareHouser = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商
		/// SRM入库单DTO.Misc.供应商
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_vendorCode ;
		public System.String VendorCode
		{
			get	
			{	
				return m_vendorCode ;
			}
			set	
			{	
				m_vendorCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 入库行
		/// SRM入库单DTO.Misc.入库行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData> m_srmRcvLine ;
		public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData> SrmRcvLine
		{
			get	
			{	
				if (m_srmRcvLine == null )
				{
					List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData> n_m_list = new List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData>() ;
					m_srmRcvLine = n_m_list ;
				}
				return m_srmRcvLine ;
			}
			set	
			{	
				m_srmRcvLine = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																								
		#endregion 
	} 	
}

	
