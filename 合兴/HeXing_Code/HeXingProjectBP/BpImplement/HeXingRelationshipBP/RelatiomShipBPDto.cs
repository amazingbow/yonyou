﻿


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	/// <summary>
	/// 对照信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class RelatiomShipBPDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public RelatiomShipBPDto(){
			initData();
		}
		private void initData()
		{
		
		
					FID = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 编码 (该属性可为空,且无默认值)
		/// 对照信息DTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String FCode
		{
			get	
			{	
				return (System.String)base.GetValue("FCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FCode",value);
			}
		}
				/// <summary>
		/// 名称 (该属性可为空,且无默认值)
		/// 对照信息DTO.Misc.名称
		/// </summary>
		/// <value>System.String</value>
		public System.String FName
		{
			get	
			{	
				return (System.String)base.GetValue("FName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("FName",value);
			}
		}
				/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 对照信息DTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 FID
		{
			get	
			{	
				return (System.Int64)base.GetValue("FID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("FID",value);
			}
		}
				/// <summary>
		/// 科目属性 (该属性可为空,且无默认值)
		/// 对照信息DTO.Misc.科目属性
		/// </summary>
		/// <value>System.String</value>
		public System.String AccountProperty
		{
			get	
			{	
				return (System.String)base.GetValue("AccountProperty",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AccountProperty",value);
			}
		}
				/// <summary>
		/// 余额方向 (该属性可为空,且无默认值)
		/// 对照信息DTO.Misc.余额方向
		/// </summary>
		/// <value>System.String</value>
		public System.String BalanceDirection
		{
			get	
			{	
				return (System.String)base.GetValue("BalanceDirection",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BalanceDirection",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 对照信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FCode　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FName　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FID　{ get { return "";　}　}
		/// <summary>
		/// 科目属性的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountProperty　{ get { return "";　}　}
		/// <summary>
		/// 余额方向的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BalanceDirection　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(RelatiomShipBPDtoData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(RelatiomShipBPDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(RelatiomShipBPDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.FCode = data.FCode;

			this.FName = data.FName;

			this.FID = data.FID;

			this.AccountProperty = data.AccountProperty;

			this.BalanceDirection = data.BalanceDirection;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public RelatiomShipBPDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public RelatiomShipBPDtoData ToEntityData(RelatiomShipBPDtoData data, IDictionary dict){
			if (data == null)
				data = new RelatiomShipBPDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (RelatiomShipBPDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.FCode = this.FCode;

			data.FName = this.FName;

			data.FID = this.FID;

			data.AccountProperty = this.AccountProperty;

			data.BalanceDirection = this.BalanceDirection;

			return data ;
		}

		#endregion	
	}	
	
}