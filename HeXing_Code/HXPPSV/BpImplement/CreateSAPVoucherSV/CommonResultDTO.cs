


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
	/// <summary>
	/// 通用返回结果对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CommonResultDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CommonResultDTO(){
			initData();
		}
		private void initData()
		{
					IsSuccess = false; 
		
		
		
		
					MiddleId = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 是否成功 (该属性可为空,但有默认值)
		/// 通用返回结果对象.Misc.是否成功
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsSuccess
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsSuccess",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsSuccess",value);
			}
		}
				/// <summary>
		/// 消息 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.消息
		/// </summary>
		/// <value>System.String</value>
		public System.String Message
		{
			get	
			{	
				return (System.String)base.GetValue("Message",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Message",value);
			}
		}
				/// <summary>
		/// 公司名称 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.公司名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CompanyCode
		{
			get	
			{	
				return (System.String)base.GetValue("CompanyCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CompanyCode",value);
			}
		}
				/// <summary>
		/// SAP凭证号 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.SAP凭证号
		/// </summary>
		/// <value>System.String</value>
		public System.String SAPVoucherDisplayCode
		{
			get	
			{	
				return (System.String)base.GetValue("SAPVoucherDisplayCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SAPVoucherDisplayCode",value);
			}
		}
				/// <summary>
		/// 记账日期 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.记账日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime PostDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("PostDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("PostDate",value);
			}
		}
				/// <summary>
		/// 中间表ID (该属性可为空,但有默认值)
		/// 通用返回结果对象.Misc.中间表ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 MiddleId
		{
			get	
			{	
				return (System.Int64)base.GetValue("MiddleId",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("MiddleId",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 通用返回结果对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 是否成功的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsSuccess　{ get { return "";　}　}
		/// <summary>
		/// 消息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Message　{ get { return "";　}　}
		/// <summary>
		/// 公司名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompanyCode　{ get { return "";　}　}
		/// <summary>
		/// SAP凭证号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SAPVoucherDisplayCode　{ get { return "";　}　}
		/// <summary>
		/// 记账日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PostDate　{ get { return "";　}　}
		/// <summary>
		/// 中间表ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MiddleId　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CommonResultDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CommonResultDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CommonResultDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.IsSuccess = data.IsSuccess;

			this.Message = data.Message;

			this.CompanyCode = data.CompanyCode;

			this.SAPVoucherDisplayCode = data.SAPVoucherDisplayCode;

			this.PostDate = data.PostDate;

			this.MiddleId = data.MiddleId;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CommonResultDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CommonResultDTOData ToEntityData(CommonResultDTOData data, IDictionary dict){
			if (data == null)
				data = new CommonResultDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CommonResultDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.IsSuccess = this.IsSuccess;

			data.Message = this.Message;

			data.CompanyCode = this.CompanyCode;

			data.SAPVoucherDisplayCode = this.SAPVoucherDisplayCode;

			data.PostDate = this.PostDate;

			data.MiddleId = this.MiddleId;

			return data ;
		}

		#endregion	
	}	
	
}