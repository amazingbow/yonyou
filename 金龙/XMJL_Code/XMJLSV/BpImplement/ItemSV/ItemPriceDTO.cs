


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	/// <summary>
	/// 物料价格DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ItemPriceDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ItemPriceDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					Price = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 件号 (该属性可为空,且无默认值)
		/// 物料价格DTO.Misc.件号
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
		/// 物料价格DTO.Misc.件名
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
		/// 单位编码 (该属性可为空,且无默认值)
		/// 物料价格DTO.Misc.单位编码
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
		/// 物料价格DTO.Misc.单位名称
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
				/// <summary>
		/// 单位简称 (该属性可为空,且无默认值)
		/// 物料价格DTO.Misc.单位简称
		/// </summary>
		/// <value>System.String</value>
		public System.String UomShortName
		{
			get	
			{	
				return (System.String)base.GetValue("UomShortName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UomShortName",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 物料价格DTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Price
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Price",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Price",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 物料价格DTO的显示名称资源--已经废弃，不使用.
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
		/// 单位编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomCode　{ get { return "";　}　}
		/// <summary>
		/// 单位名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomName　{ get { return "";　}　}
		/// <summary>
		/// 单位简称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomShortName　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Price　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ItemPriceDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ItemPriceDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ItemPriceDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.UomCode = data.UomCode;

			this.UomName = data.UomName;

			this.UomShortName = data.UomShortName;

			this.Price = data.Price;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ItemPriceDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ItemPriceDTOData ToEntityData(ItemPriceDTOData data, IDictionary dict){
			if (data == null)
				data = new ItemPriceDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ItemPriceDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.UomCode = this.UomCode;

			data.UomName = this.UomName;

			data.UomShortName = this.UomShortName;

			data.Price = this.Price;

			return data ;
		}

		#endregion	
	}	
	
}