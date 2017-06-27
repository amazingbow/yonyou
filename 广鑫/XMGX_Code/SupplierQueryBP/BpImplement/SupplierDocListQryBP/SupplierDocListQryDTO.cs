


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierDocListQryBP
{
	/// <summary>
	/// SupplierDocListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierDocListQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierDocListQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
					SumUnPayedMnyTC = 0m; 
		
		
					SumTotalUnPayedMnyTC = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SupplierDocListQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// SupplierDocListQryDTO.Misc.单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
				/// <summary>
		/// 入库时间 (该属性可为空,且无默认值)
		/// SupplierDocListQryDTO.Misc.入库时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusinessDate",value);
			}
		}
				/// <summary>
		/// 应付余额 (该属性可为空,但有默认值)
		/// SupplierDocListQryDTO.Misc.应付余额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumUnPayedMnyTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumUnPayedMnyTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumUnPayedMnyTC",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// SupplierDocListQryDTO.Misc.制单人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// SupplierDocListQryDTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorsName
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorsName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorsName",value);
			}
		}
				/// <summary>
		/// 合计应付余额 (该属性可为空,但有默认值)
		/// SupplierDocListQryDTO.Misc.合计应付余额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumTotalUnPayedMnyTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumTotalUnPayedMnyTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumTotalUnPayedMnyTC",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
							
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// SupplierDocListQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 入库时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 应付余额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumUnPayedMnyTC　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsName　{ get { return "";　}　}
		/// <summary>
		/// 合计应付余额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumTotalUnPayedMnyTC　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierDocListQryDTOData data)
		{
		







		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierDocListQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierDocListQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.DocNo = data.DocNo;

			this.BusinessDate = data.BusinessDate;

			this.SumUnPayedMnyTC = data.SumUnPayedMnyTC;

			this.CreatedBy = data.CreatedBy;

			this.OperatorsName = data.OperatorsName;

			this.SumTotalUnPayedMnyTC = data.SumTotalUnPayedMnyTC;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierDocListQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierDocListQryDTOData ToEntityData(SupplierDocListQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierDocListQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierDocListQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.BusinessDate = this.BusinessDate;

			data.SumUnPayedMnyTC = this.SumUnPayedMnyTC;

			data.CreatedBy = this.CreatedBy;

			data.OperatorsName = this.OperatorsName;

			data.SumTotalUnPayedMnyTC = this.SumTotalUnPayedMnyTC;

			return data ;
		}

		#endregion	
	}	
	
}