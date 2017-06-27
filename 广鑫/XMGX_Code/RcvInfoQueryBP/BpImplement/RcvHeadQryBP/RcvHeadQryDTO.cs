


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UIFIA.U9.Cust.FJGX.RcvHeadQryBP
{
	/// <summary>
	/// RcvHeadQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class RcvHeadQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public RcvHeadQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
		
		
					SumTotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// RcvHeadQryDTO.Misc.ID
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
		/// 收发单据号 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.收发单据号
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
		/// 单据日期 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.单据日期
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
		/// 供应商编码 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.供应商编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierCode
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierCode",value);
			}
		}
				/// <summary>
		/// 供应商名称 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.供应商名称
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierName
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierName",value);
			}
		}
				/// <summary>
		/// 供应商联系人 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.供应商联系人
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierContactName
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierContactName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierContactName",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.制单人
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
		/// 备注 (该属性可为空,且无默认值)
		/// RcvHeadQryDTO.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
				/// <summary>
		/// 合计金额 (该属性可为空,但有默认值)
		/// RcvHeadQryDTO.Misc.合计金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumTotalMoney",value);
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
		/// RcvHeadQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 收发单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 供应商编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierName　{ get { return "";　}　}
		/// <summary>
		/// 供应商联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContactName　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 合计金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumTotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(RcvHeadQryDTOData data)
		{
		










		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(RcvHeadQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(RcvHeadQryDTOData data,IDictionary dict)
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

			this.SupplierCode = data.SupplierCode;

			this.SupplierName = data.SupplierName;

			this.SupplierContactName = data.SupplierContactName;

			this.TotalMoney = data.TotalMoney;

			this.CreatedBy = data.CreatedBy;

			this.Memo = data.Memo;

			this.SumTotalMoney = data.SumTotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public RcvHeadQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public RcvHeadQryDTOData ToEntityData(RcvHeadQryDTOData data, IDictionary dict){
			if (data == null)
				data = new RcvHeadQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (RcvHeadQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.BusinessDate = this.BusinessDate;

			data.SupplierCode = this.SupplierCode;

			data.SupplierName = this.SupplierName;

			data.SupplierContactName = this.SupplierContactName;

			data.TotalMoney = this.TotalMoney;

			data.CreatedBy = this.CreatedBy;

			data.Memo = this.Memo;

			data.SumTotalMoney = this.SumTotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}