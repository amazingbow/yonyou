


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件变更料品信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomChangeItemDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomChangeItemDTO(){
			initData();
		}
		private void initData()
		{
		
					Item = 0; 
					Supplier = 0; 
		
					DistQty = 0m; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 缺件变更头信息 (该属性可为空,且无默认值)
		/// 缺件变更料品信息.Misc.缺件变更头信息
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO</value>
		public UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO BomChangeDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO)base.GetValue("BomChangeDTO",typeof(UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO));
			}

			 set	
			{
				base.SetValue("BomChangeDTO",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,但有默认值)
		/// 缺件变更料品信息.Misc.料品
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
		/// 供应商 (该属性可为空,但有默认值)
		/// 缺件变更料品信息.Misc.供应商
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
		/// 工位 (该属性可为空,且无默认值)
		/// 缺件变更料品信息.Misc.工位
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
		/// 发料数量 (该属性可为空,但有默认值)
		/// 缺件变更料品信息.Misc.发料数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DistQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DistQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DistQty",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 缺件变更料品信息.Misc.料品
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
		/// 品名 (该属性可为空,且无默认值)
		/// 缺件变更料品信息.Misc.品名
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
		
		#endregion	
		#region Multi_Fields
							
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件变更料品信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 缺件变更头信息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomChangeDTO　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 工位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WorkPlace　{ get { return "";　}　}
		/// <summary>
		/// 发料数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DistQty　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomChangeItemDTOData data)
		{
		







		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomChangeItemDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomChangeItemDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			if (data.BomChangeDTO!=null)
			{
				UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO temp = dict[data.BomChangeDTO] as UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO();
					temp.FromEntityData(data.BomChangeDTO,dict);
				}
				this.BomChangeDTO = temp ;
			}
		

			this.Item = data.Item;

			this.Supplier = data.Supplier;

			this.WorkPlace = data.WorkPlace;

			this.DistQty = data.DistQty;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomChangeItemDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomChangeItemDTOData ToEntityData(BomChangeItemDTOData data, IDictionary dict){
			if (data == null)
				data = new BomChangeItemDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomChangeItemDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.BomChangeDTO!=null)
			{
				data.BomChangeDTO=this.BomChangeDTO.ToEntityData(null,dict);
			}
		

			data.Item = this.Item;

			data.Supplier = this.Supplier;

			data.WorkPlace = this.WorkPlace;

			data.DistQty = this.DistQty;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			return data ;
		}

		#endregion	
	}	
	
}