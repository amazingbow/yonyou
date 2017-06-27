


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	/// <summary>
	/// 物料DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ItemDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ItemDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					RefrenceCost = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 件号 (该属性可为空,且无默认值)
		/// 物料DTO.Misc.件号
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
		/// 物料DTO.Misc.件名
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
		/// 物料DTO.Misc.单位编码
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
		/// 物料DTO.Misc.单位名称
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
		/// 物料DTO.Misc.单位简称
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
		/// 生效日期 (该属性可为空,且无默认值)
		/// 物料DTO.Misc.生效日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime EffectiveDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("EffectiveDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("EffectiveDate",value);
			}
		}
				/// <summary>
		/// 失效日期 (该属性可为空,且无默认值)
		/// 物料DTO.Misc.失效日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime DisableDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("DisableDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("DisableDate",value);
			}
		}
				/// <summary>
		/// 参考成本 (该属性可为空,但有默认值)
		/// 物料DTO.Misc.参考成本
		/// </summary>
		/// <value>System.Double</value>
		public System.Double RefrenceCost
		{
			get	
			{	
				return (System.Double)base.GetValue("RefrenceCost",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("RefrenceCost",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 物料DTO的显示名称资源--已经废弃，不使用.
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
		/// 生效日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EffectiveDate　{ get { return "";　}　}
		/// <summary>
		/// 失效日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DisableDate　{ get { return "";　}　}
		/// <summary>
		/// 参考成本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RefrenceCost　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ItemDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ItemDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ItemDTOData data,IDictionary dict)
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

			this.EffectiveDate = data.EffectiveDate;

			this.DisableDate = data.DisableDate;

			this.RefrenceCost = data.RefrenceCost;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ItemDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ItemDTOData ToEntityData(ItemDTOData data, IDictionary dict){
			if (data == null)
				data = new ItemDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ItemDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.UomCode = this.UomCode;

			data.UomName = this.UomName;

			data.UomShortName = this.UomShortName;

			data.EffectiveDate = this.EffectiveDate;

			data.DisableDate = this.DisableDate;

			data.RefrenceCost = this.RefrenceCost;

			return data ;
		}

		#endregion	
	}	
	
}