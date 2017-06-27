


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	/// <summary>
	/// 物料库存DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ItemStoreDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ItemStoreDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					StoreQty = 0m; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 件号 (该属性可为空,且无默认值)
		/// 物料库存DTO.Misc.件号
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
		/// 物料库存DTO.Misc.件名
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
		/// 物料库存DTO.Misc.单位编码
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
		/// 物料库存DTO.Misc.单位名称
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
		/// 物料库存DTO.Misc.单位简称
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
		/// 库存数量 (该属性可为空,但有默认值)
		/// 物料库存DTO.Misc.库存数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal StoreQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("StoreQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("StoreQty",value);
			}
		}
				/// <summary>
		/// 存储地点代码 (该属性可为空,且无默认值)
		/// 物料库存DTO.Misc.存储地点代码
		/// </summary>
		/// <value>System.String</value>
		public System.String WHCode
		{
			get	
			{	
				return (System.String)base.GetValue("WHCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WHCode",value);
			}
		}
				/// <summary>
		/// 存储地点名称 (该属性可为空,且无默认值)
		/// 物料库存DTO.Misc.存储地点名称
		/// </summary>
		/// <value>System.String</value>
		public System.String WHName
		{
			get	
			{	
				return (System.String)base.GetValue("WHName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WHName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 物料库存DTO的显示名称资源--已经废弃，不使用.
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
		/// 库存数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreQty　{ get { return "";　}　}
		/// <summary>
		/// 存储地点代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WHCode　{ get { return "";　}　}
		/// <summary>
		/// 存储地点名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WHName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ItemStoreDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ItemStoreDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ItemStoreDTOData data,IDictionary dict)
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

			this.StoreQty = data.StoreQty;

			this.WHCode = data.WHCode;

			this.WHName = data.WHName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ItemStoreDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ItemStoreDTOData ToEntityData(ItemStoreDTOData data, IDictionary dict){
			if (data == null)
				data = new ItemStoreDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ItemStoreDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.UomCode = this.UomCode;

			data.UomName = this.UomName;

			data.UomShortName = this.UomShortName;

			data.StoreQty = this.StoreQty;

			data.WHCode = this.WHCode;

			data.WHName = this.WHName;

			return data ;
		}

		#endregion	
	}	
	
}