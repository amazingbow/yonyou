


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件部分信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomPartInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomPartInfoDTO(){
			initData();
		}
		private void initData()
		{
					Item = 0; 
		
		
					Supplier = 0; 
		
		
		
					Qty = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 料品 (该属性可为空,但有默认值)
		/// 缺件部分信息.Misc.料品
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Item
		{
			get	
			{	
				return (System.Int64)base.GetValue("Item",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Item",value);
			}
		}
				/// <summary>
		/// 料品代码 (该属性可为空,且无默认值)
		/// 缺件部分信息.Misc.料品代码
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// 料品名称 (该属性可为空,且无默认值)
		/// 缺件部分信息.Misc.料品名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,但有默认值)
		/// 缺件部分信息.Misc.供应商
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Supplier
		{
			get	
			{	
				return (System.Int64)base.GetValue("Supplier",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Supplier",value);
			}
		}
				/// <summary>
		/// 供应商代码 (该属性可为空,且无默认值)
		/// 缺件部分信息.Misc.供应商代码
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
		/// 缺件部分信息.Misc.供应商名称
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
		/// 工位 (该属性可为空,且无默认值)
		/// 缺件部分信息.Misc.工位
		/// </summary>
		/// <value>System.String</value>
		public System.String WorkPlace
		{
			get	
			{	
				return (System.String)base.GetValue("WorkPlace",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WorkPlace",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 缺件部分信息.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Qty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Qty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件部分信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item　{ get { return "";　}　}
		/// <summary>
		/// 料品代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 料品名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 供应商代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierName　{ get { return "";　}　}
		/// <summary>
		/// 工位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WorkPlace　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomPartInfoDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomPartInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomPartInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Item = data.Item;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.Supplier = data.Supplier;

			this.SupplierCode = data.SupplierCode;

			this.SupplierName = data.SupplierName;

			this.WorkPlace = data.WorkPlace;

			this.Qty = data.Qty;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomPartInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomPartInfoDTOData ToEntityData(BomPartInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new BomPartInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomPartInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Item = this.Item;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.Supplier = this.Supplier;

			data.SupplierCode = this.SupplierCode;

			data.SupplierName = this.SupplierName;

			data.WorkPlace = this.WorkPlace;

			data.Qty = this.Qty;

			return data ;
		}

		#endregion	
	}	
	
}