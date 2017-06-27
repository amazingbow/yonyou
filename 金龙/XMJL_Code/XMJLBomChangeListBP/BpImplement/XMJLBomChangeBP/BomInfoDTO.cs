


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件车辆信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomInfoDTO(){
			initData();
		}
		private void initData()
		{
					CarNoId = 0; 
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 车号 (该属性可为空,但有默认值)
		/// 缺件车辆信息.Misc.车号
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CarNoId
		{
			get	
			{	
				return (System.Int64)base.GetValue("CarNoId",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("CarNoId",value);
			}
		}
				/// <summary>
		/// 车号Code (该属性可为空,且无默认值)
		/// 缺件车辆信息.Misc.车号Code
		/// </summary>
		/// <value>System.String</value>
		public System.String CarNoCode
		{
			get	
			{	
				return (System.String)base.GetValue("CarNoCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarNoCode",value);
			}
		}
				/// <summary>
		/// 车号Name (该属性可为空,且无默认值)
		/// 缺件车辆信息.Misc.车号Name
		/// </summary>
		/// <value>System.String</value>
		public System.String CarNoName
		{
			get	
			{	
				return (System.String)base.GetValue("CarNoName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarNoName",value);
			}
		}
				/// <summary>
		/// 合同号 (该属性可为空,且无默认值)
		/// 缺件车辆信息.Misc.合同号
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
		/// 属性 (该属性可为空,且无默认值)
		/// 缺件车辆信息.Misc.属性
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
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件车辆信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 车号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarNoId　{ get { return "";　}　}
		/// <summary>
		/// 车号Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarNoCode　{ get { return "";　}　}
		/// <summary>
		/// 车号Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarNoName　{ get { return "";　}　}
		/// <summary>
		/// 合同号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ContractNo　{ get { return "";　}　}
		/// <summary>
		/// 属性的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarType　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomInfoDTOData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.CarNoId = data.CarNoId;

			this.CarNoCode = data.CarNoCode;

			this.CarNoName = data.CarNoName;

			this.ContractNo = data.ContractNo;

			this.CarType = data.CarType;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomInfoDTOData ToEntityData(BomInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new BomInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.CarNoId = this.CarNoId;

			data.CarNoCode = this.CarNoCode;

			data.CarNoName = this.CarNoName;

			data.ContractNo = this.ContractNo;

			data.CarType = this.CarType;

			return data ;
		}

		#endregion	
	}	
	
}