



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 汇总立账生单行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.APBillSV.APBillLineDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class APBillLineDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                 
            knownTypes.Add(typeof(UFIDA.U9.PM.Rcv.ReceivementData)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public APBillLineDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
					Qty= 0; 
							UnitPrice= 0; 
							TotalMoney= 0; 
							IsIncludeTax=true; 
		
		
		

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
		public APBillLineDTOData(  System.String deptCode  , System.String itemCode  , System.String itemName  , System.Double qty  , System.Double unitPrice  , System.Double totalMoney  , System.Boolean isIncludeTax  , System.String transactorCode  , System.String taxCode  , UFIDA.U9.PM.Rcv.ReceivementData receivement  )
		{
			initData();
			this.DeptCode = deptCode;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Qty = qty;
			this.UnitPrice = unitPrice;
			this.TotalMoney = totalMoney;
			this.IsIncludeTax = isIncludeTax;
			this.TransactorCode = transactorCode;
			this.TaxCode = taxCode;
			this.Receivement = receivement;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 部门代码
		/// 汇总立账生单行DTO.Misc.部门代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_deptCode ;
		public System.String DeptCode
		{
			get	
			{	
				return m_deptCode ;
			}
			set	
			{	
				m_deptCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品代码
		/// 汇总立账生单行DTO.Misc.料品代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemCode ;
		public System.String ItemCode
		{
			get	
			{	
				return m_itemCode ;
			}
			set	
			{	
				m_itemCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品名称
		/// 汇总立账生单行DTO.Misc.料品名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemName ;
		public System.String ItemName
		{
			get	
			{	
				return m_itemName ;
			}
			set	
			{	
				m_itemName = value ;	
			}
		}
			
		

		/// <summary>
		/// 数量
		/// 汇总立账生单行DTO.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_qty ;
		public System.Double Qty
		{
			get	
			{	
				return m_qty ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// 汇总立账生单行DTO.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_unitPrice ;
		public System.Double UnitPrice
		{
			get	
			{	
				return m_unitPrice ;
			}
			set	
			{	
				m_unitPrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 总额
		/// 汇总立账生单行DTO.Misc.总额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_totalMoney ;
		public System.Double TotalMoney
		{
			get	
			{	
				return m_totalMoney ;
			}
			set	
			{	
				m_totalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 是否含税
		/// 汇总立账生单行DTO.Misc.是否含税
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_isIncludeTax ;
		public System.Boolean IsIncludeTax
		{
			get	
			{	
				return m_isIncludeTax ;
			}
			set	
			{	
				m_isIncludeTax = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员代码
		/// 汇总立账生单行DTO.Misc.业务员代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_transactorCode ;
		public System.String TransactorCode
		{
			get	
			{	
				return m_transactorCode ;
			}
			set	
			{	
				m_transactorCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 税组合代码
		/// 汇总立账生单行DTO.Misc.税组合代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_taxCode ;
		public System.String TaxCode
		{
			get	
			{	
				return m_taxCode ;
			}
			set	
			{	
				m_taxCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 收货单
		/// 汇总立账生单行DTO.Misc.收货单
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.PM.Rcv.ReceivementData m_receivement ;
		public UFIDA.U9.PM.Rcv.ReceivementData Receivement
		{
			get	
			{	
				return m_receivement ;
			}
			set	
			{	
				m_receivement = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																				
		#endregion 
	} 	
}

	
