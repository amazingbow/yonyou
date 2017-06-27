


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 料品供应商 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ItemSupplyDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ItemSupplyDTO(){
			initData();
		}
		private void initData()
		{
					ItemId = 0; 
					Supply = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 料品ID (该属性可为空,但有默认值)
		/// 料品供应商.Misc.料品ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ItemId
		{
			get	
			{	
				return (System.Int64)base.GetValue("ItemId",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ItemId",value);
			}
		}
				/// <summary>
		/// 供应商ID (该属性可为空,但有默认值)
		/// 料品供应商.Misc.供应商ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Supply
		{
			get	
			{	
				return (System.Int64)base.GetValue("Supply",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Supply",value);
			}
		}
				/// <summary>
		/// 供应商Code (该属性可为空,且无默认值)
		/// 料品供应商.Misc.供应商Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplyCode
		{
			get	
			{	
				return (System.String)base.GetValue("SupplyCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplyCode",value);
			}
		}
				/// <summary>
		/// 供应商Name (该属性可为空,且无默认值)
		/// 料品供应商.Misc.供应商Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplyName
		{
			get	
			{	
				return (System.String)base.GetValue("SupplyName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplyName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
				
		#endregion 

		#region ModelResource
		/// <summary>
		/// 料品供应商的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 料品ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemId　{ get { return "";　}　}
		/// <summary>
		/// 供应商ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supply　{ get { return "";　}　}
		/// <summary>
		/// 供应商Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplyCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplyName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ItemSupplyDTOData data)
		{
		




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ItemSupplyDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ItemSupplyDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemId = data.ItemId;

			this.Supply = data.Supply;

			this.SupplyCode = data.SupplyCode;

			this.SupplyName = data.SupplyName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ItemSupplyDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ItemSupplyDTOData ToEntityData(ItemSupplyDTOData data, IDictionary dict){
			if (data == null)
				data = new ItemSupplyDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ItemSupplyDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemId = this.ItemId;

			data.Supply = this.Supply;

			data.SupplyCode = this.SupplyCode;

			data.SupplyName = this.SupplyName;

			return data ;
		}

		#endregion	
	}	
	
}