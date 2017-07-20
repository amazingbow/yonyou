


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
{
	/// <summary>
	/// 特定物料DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SpeciFicItemInfoDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SpeciFicItemInfoDto(){
			initData();
		}
		private void initData()
		{
					ItemMaster = 0; 
		
		
					Wh = 0; 
		
		
					ReqPRQty = 0m; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 料品 (该属性可为空,但有默认值)
		/// 特定物料DTO.Misc.料品
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ItemMaster
		{
			get	
			{	
				return (System.Int64)base.GetValue("ItemMaster",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ItemMaster",value);
			}
		}
				/// <summary>
		/// 料品_编码 (该属性可为空,且无默认值)
		/// 特定物料DTO.Misc.料品_编码
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Code",value);
			}
		}
				/// <summary>
		/// 料品_名称 (该属性可为空,且无默认值)
		/// 特定物料DTO.Misc.料品_名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Name",value);
			}
		}
				/// <summary>
		/// 存储地点 (该属性可为空,但有默认值)
		/// 特定物料DTO.Misc.存储地点
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Wh
		{
			get	
			{	
				return (System.Int64)base.GetValue("Wh",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Wh",value);
			}
		}
				/// <summary>
		/// 存储地点_编码 (该属性可为空,且无默认值)
		/// 特定物料DTO.Misc.存储地点_编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Wh_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Wh_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Wh_Code",value);
			}
		}
				/// <summary>
		/// 存储地点_名称 (该属性可为空,且无默认值)
		/// 特定物料DTO.Misc.存储地点_名称
		/// </summary>
		/// <value>System.String</value>
		public System.String Wh_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Wh_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Wh_Name",value);
			}
		}
				/// <summary>
		/// 请购数量 (该属性可为空,但有默认值)
		/// 特定物料DTO.Misc.请购数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ReqPRQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ReqPRQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ReqPRQty",value);
			}
		}
				/// <summary>
		/// 交期 (该属性可为空,且无默认值)
		/// 特定物料DTO.Misc.交期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ReqDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ReqDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ReqDate",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 特定物料DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster　{ get { return "";　}　}
		/// <summary>
		/// 料品_编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Code　{ get { return "";　}　}
		/// <summary>
		/// 料品_名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Name　{ get { return "";　}　}
		/// <summary>
		/// 存储地点的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh　{ get { return "";　}　}
		/// <summary>
		/// 存储地点_编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh_Code　{ get { return "";　}　}
		/// <summary>
		/// 存储地点_名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh_Name　{ get { return "";　}　}
		/// <summary>
		/// 请购数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ReqPRQty　{ get { return "";　}　}
		/// <summary>
		/// 交期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ReqDate　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SpeciFicItemInfoDtoData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SpeciFicItemInfoDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SpeciFicItemInfoDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemMaster = data.ItemMaster;

			this.ItemMaster_Code = data.ItemMaster_Code;

			this.ItemMaster_Name = data.ItemMaster_Name;

			this.Wh = data.Wh;

			this.Wh_Code = data.Wh_Code;

			this.Wh_Name = data.Wh_Name;

			this.ReqPRQty = data.ReqPRQty;

			this.ReqDate = data.ReqDate;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SpeciFicItemInfoDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SpeciFicItemInfoDtoData ToEntityData(SpeciFicItemInfoDtoData data, IDictionary dict){
			if (data == null)
				data = new SpeciFicItemInfoDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SpeciFicItemInfoDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemMaster = this.ItemMaster;

			data.ItemMaster_Code = this.ItemMaster_Code;

			data.ItemMaster_Name = this.ItemMaster_Name;

			data.Wh = this.Wh;

			data.Wh_Code = this.Wh_Code;

			data.Wh_Name = this.Wh_Name;

			data.ReqPRQty = this.ReqPRQty;

			data.ReqDate = this.ReqDate;

			return data ;
		}

		#endregion	
	}	
	
}