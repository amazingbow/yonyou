


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	/// <summary>
	/// 缺件主表信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BOMMainInfoDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BOMMainInfoDto(){
			initData();
		}
		private void initData()
		{
					ManufactureNo = 0; 
		
		
		
		
					No = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 车号 (该属性可为空,但有默认值)
		/// 缺件主表信息DTO.Misc.车号
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ManufactureNo
		{
			get	
			{	
				return (System.Int64)base.GetValue("ManufactureNo",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ManufactureNo",value);
			}
		}
				/// <summary>
		/// 合同号 (该属性可为空,且无默认值)
		/// 缺件主表信息DTO.Misc.合同号
		/// </summary>
		/// <value>System.String</value>
		public System.String ContractNo
		{
			get	
			{	
				return (System.String)base.GetValue("ContractNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ContractNo",value);
			}
		}
				/// <summary>
		/// 车型 (该属性可为空,且无默认值)
		/// 缺件主表信息DTO.Misc.车型
		/// </summary>
		/// <value>System.String</value>
		public System.String CarType
		{
			get	
			{	
				return (System.String)base.GetValue("CarType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarType",value);
			}
		}
				/// <summary>
		/// 编码 (该属性可为空,且无默认值)
		/// 缺件主表信息DTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String ManufactureNo_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ManufactureNo_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ManufactureNo_Code",value);
			}
		}
				/// <summary>
		/// 项目名称 (该属性可为空,且无默认值)
		/// 缺件主表信息DTO.Misc.项目名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ManufactureNo_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ManufactureNo_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ManufactureNo_Name",value);
			}
		}
				/// <summary>
		/// 序号 (该属性可为空,但有默认值)
		/// 缺件主表信息DTO.Misc.序号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 No
		{
			get	
			{	
				return (System.Int32)base.GetValue("No",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("No",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件主表信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 车号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ManufactureNo　{ get { return "";　}　}
		/// <summary>
		/// 合同号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ContractNo　{ get { return "";　}　}
		/// <summary>
		/// 车型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarType　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ManufactureNo_Code　{ get { return "";　}　}
		/// <summary>
		/// 项目名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ManufactureNo_Name　{ get { return "";　}　}
		/// <summary>
		/// 序号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_No　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BOMMainInfoDtoData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BOMMainInfoDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BOMMainInfoDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ManufactureNo = data.ManufactureNo;

			this.ContractNo = data.ContractNo;

			this.CarType = data.CarType;

			this.ManufactureNo_Code = data.ManufactureNo_Code;

			this.ManufactureNo_Name = data.ManufactureNo_Name;

			this.No = data.No;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BOMMainInfoDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BOMMainInfoDtoData ToEntityData(BOMMainInfoDtoData data, IDictionary dict){
			if (data == null)
				data = new BOMMainInfoDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BOMMainInfoDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ManufactureNo = this.ManufactureNo;

			data.ContractNo = this.ContractNo;

			data.CarType = this.CarType;

			data.ManufactureNo_Code = this.ManufactureNo_Code;

			data.ManufactureNo_Name = this.ManufactureNo_Name;

			data.No = this.No;

			return data ;
		}

		#endregion	
	}	
	
}