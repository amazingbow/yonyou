


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库单查询条件DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SRMRcvQueryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SRMRcvQueryDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 供应商代码 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.供应商代码
		/// </summary>
		/// <value>System.String</value>
		public System.String VendorCode
		{
			get	
			{	
				return (System.String)base.GetValue("VendorCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VendorCode",value);
			}
		}
				/// <summary>
		/// 采购员代码 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.采购员代码
		/// </summary>
		/// <value>System.String</value>
		public System.String CPersonCode
		{
			get	
			{	
				return (System.String)base.GetValue("CPersonCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CPersonCode",value);
			}
		}
				/// <summary>
		/// 入库单号 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.入库单号
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
		/// 单据类型 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String Type
		{
			get	
			{	
				return (System.String)base.GetValue("Type",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Type",value);
			}
		}
				/// <summary>
		/// 起始入库日期 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.起始入库日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime InDateFrom
		{
			get	
			{	
				return (System.DateTime)base.GetValue("InDateFrom",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("InDateFrom",value);
			}
		}
				/// <summary>
		/// 截止入库日期 (该属性可为空,且无默认值)
		/// SRM入库单查询条件DTO.Misc.截止入库日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime InDateTo
		{
			get	
			{	
				return (System.DateTime)base.GetValue("InDateTo",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("InDateTo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// SRM入库单查询条件DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 供应商代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 采购员代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CPersonCode　{ get { return "";　}　}
		/// <summary>
		/// 入库单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Type　{ get { return "";　}　}
		/// <summary>
		/// 起始入库日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InDateFrom　{ get { return "";　}　}
		/// <summary>
		/// 截止入库日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InDateTo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SRMRcvQueryDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SRMRcvQueryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SRMRcvQueryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.VendorCode = data.VendorCode;

			this.CPersonCode = data.CPersonCode;

			this.DocNo = data.DocNo;

			this.Type = data.Type;

			this.InDateFrom = data.InDateFrom;

			this.InDateTo = data.InDateTo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SRMRcvQueryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SRMRcvQueryDTOData ToEntityData(SRMRcvQueryDTOData data, IDictionary dict){
			if (data == null)
				data = new SRMRcvQueryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SRMRcvQueryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.VendorCode = this.VendorCode;

			data.CPersonCode = this.CPersonCode;

			data.DocNo = this.DocNo;

			data.Type = this.Type;

			data.InDateFrom = this.InDateFrom;

			data.InDateTo = this.InDateTo;

			return data ;
		}

		#endregion	
	}	
	
}