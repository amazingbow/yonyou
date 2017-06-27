


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	/// <summary>
	/// 车辆BomDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ProductBomDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ProductBomDTO(){
			initData();
		}
		private void initData()
		{
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 车号 (该属性可为空,且无默认值)
		/// 车辆BomDTO.Misc.车号
		/// </summary>
		/// <value>System.String</value>
		public System.String ManufactureNo
		{
			get	
			{	
				return (System.String)base.GetValue("ManufactureNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ManufactureNo",value);
			}
		}
				/// <summary>
		/// BOM集合 (该属性可为空,且无默认值)
		/// 车辆BomDTO.Misc.BOM集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO> Bom
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO>)base.GetValue("Bom",typeof(List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO>));
			}

			 set	
			{
				base.SetValue("Bom",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 车辆BomDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 车号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ManufactureNo　{ get { return "";　}　}
		/// <summary>
		/// BOM集合的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Bom　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ProductBomDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ProductBomDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ProductBomDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ManufactureNo = data.ManufactureNo;

	
			if (data.Bom != null)
			{	
				List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO> listBom = new List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTO>();
				foreach(UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData obj in data.Bom ){

					UFIDA.U9.Cust.XMJL.BOMSV.BomDTO child = dict[obj] as UFIDA.U9.Cust.XMJL.BOMSV.BomDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.XMJL.BOMSV.BomDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listBom.Add(child);
				
				}
				this.Bom = listBom;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ProductBomDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ProductBomDTOData ToEntityData(ProductBomDTOData data, IDictionary dict){
			if (data == null)
				data = new ProductBomDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ProductBomDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ManufactureNo = this.ManufactureNo;

	
			if (this.Bom != null)
			{	
				List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData> listBom = new List<UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData>();
				foreach(UFIDA.U9.Cust.XMJL.BOMSV.BomDTO obj in this.Bom ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData old = dict[obj] as UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData;
					listBom.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.Bom = listBom;
			}

			return data ;
		}

		#endregion	
	}	
	
}