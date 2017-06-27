


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	/// <summary>
	/// BomDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
					Qty = 0m; 
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 件号 (该属性可为空,且无默认值)
		/// BomDTO.Misc.件号
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
		/// 件名 (该属性可为空,且无默认值)
		/// BomDTO.Misc.件名
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
		/// 供应商代码 (该属性可为空,且无默认值)
		/// BomDTO.Misc.供应商代码
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
		/// 供应商名称 (该属性可为空,且无默认值)
		/// BomDTO.Misc.供应商名称
		/// </summary>
		/// <value>System.String</value>
		public System.String VendorName
		{
			get	
			{	
				return (System.String)base.GetValue("VendorName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VendorName",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// BomDTO.Misc.数量
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
				/// <summary>
		/// Bom类型 (该属性可为空,且无默认值)
		/// BomDTO.Misc.Bom类型
		/// </summary>
		/// <value>System.String</value>
		public System.String BomType
		{
			get	
			{	
				return (System.String)base.GetValue("BomType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BomType",value);
			}
		}
				/// <summary>
		/// 车辆BomDTO (该属性可为空,且无默认值)
		/// BomDTO.Misc.车辆BomDTO
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO</value>
		public UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO ProductBomDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO)base.GetValue("ProductBomDTO",typeof(UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO));
			}

			 set	
			{
				base.SetValue("ProductBomDTO",value);
			}
		}
				/// <summary>
		/// 单位编码 (该属性可为空,且无默认值)
		/// BomDTO.Misc.单位编码
		/// </summary>
		/// <value>System.String</value>
		public System.String UomCode
		{
			get	
			{	
				return (System.String)base.GetValue("UomCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UomCode",value);
			}
		}
				/// <summary>
		/// 单位名称 (该属性可为空,且无默认值)
		/// BomDTO.Misc.单位名称
		/// </summary>
		/// <value>System.String</value>
		public System.String UomName
		{
			get	
			{	
				return (System.String)base.GetValue("UomName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UomName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
									
		#endregion 

		#region ModelResource
		/// <summary>
		/// BomDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 件号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 件名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 供应商代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorName　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// Bom类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomType　{ get { return "";　}　}
		/// <summary>
		/// 车辆BomDTO的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProductBomDTO　{ get { return "";　}　}
		/// <summary>
		/// 单位编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomCode　{ get { return "";　}　}
		/// <summary>
		/// 单位名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomDTOData data)
		{
		









		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.VendorCode = data.VendorCode;

			this.VendorName = data.VendorName;

			this.Qty = data.Qty;

			this.BomType = data.BomType;

			if (data.ProductBomDTO!=null)
			{
				UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO temp = dict[data.ProductBomDTO] as UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO();
					temp.FromEntityData(data.ProductBomDTO,dict);
				}
				this.ProductBomDTO = temp ;
			}
		

			this.UomCode = data.UomCode;

			this.UomName = data.UomName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomDTOData ToEntityData(BomDTOData data, IDictionary dict){
			if (data == null)
				data = new BomDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.VendorCode = this.VendorCode;

			data.VendorName = this.VendorName;

			data.Qty = this.Qty;

			data.BomType = this.BomType;

			if (this.ProductBomDTO!=null)
			{
				data.ProductBomDTO=this.ProductBomDTO.ToEntityData(null,dict);
			}
		

			data.UomCode = this.UomCode;

			data.UomName = this.UomName;

			return data ;
		}

		#endregion	
	}	
	
}