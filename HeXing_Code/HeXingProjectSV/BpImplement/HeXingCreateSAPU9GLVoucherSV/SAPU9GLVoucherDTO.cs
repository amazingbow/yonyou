


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV
{
	/// <summary>
	/// SAP与U9凭证对接中间表DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SAPU9GLVoucherDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SAPU9GLVoucherDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
					PostedPeriod = 0; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 公司代码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.公司代码
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
		/// 公司名称 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.公司名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CompanyName
		{
			get	
			{	
				return (System.String)base.GetValue("CompanyName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CompanyName",value);
			}
		}
				/// <summary>
		/// SAP凭证号 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.SAP凭证号
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
		/// 凭证类型编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.凭证类型编码
		/// </summary>
		/// <value>System.String</value>
		public System.String VoucherCategoryCode
		{
			get	
			{	
				return (System.String)base.GetValue("VoucherCategoryCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VoucherCategoryCode",value);
			}
		}
				/// <summary>
		/// 凭证类型描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.凭证类型描述
		/// </summary>
		/// <value>System.String</value>
		public System.String VoucherCategoryDescription
		{
			get	
			{	
				return (System.String)base.GetValue("VoucherCategoryDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VoucherCategoryDescription",value);
			}
		}
				/// <summary>
		/// 记账日期 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.记账日期
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
		/// 记账期间 (该属性可为空,但有默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.记账期间
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 PostedPeriod
		{
			get	
			{	
				return (System.Int64)base.GetValue("PostedPeriod",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("PostedPeriod",value);
			}
		}
				/// <summary>
		/// 币种编码 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.币种编码
		/// </summary>
		/// <value>System.String</value>
		public System.String CurrencyCode
		{
			get	
			{	
				return (System.String)base.GetValue("CurrencyCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CurrencyCode",value);
			}
		}
				/// <summary>
		/// 货币描述 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.货币描述
		/// </summary>
		/// <value>System.String</value>
		public System.String CurrencyDescription
		{
			get	
			{	
				return (System.String)base.GetValue("CurrencyDescription",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CurrencyDescription",value);
			}
		}
				/// <summary>
		/// SAP与U9凭证对接中间表行列表 (该属性可为空,且无默认值)
		/// SAP与U9凭证对接中间表DTO.Misc.SAP与U9凭证对接中间表行列表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO> SAPU9GLVoucherLineDTOS
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO>)base.GetValue("SAPU9GLVoucherLineDTOS",typeof(List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO>));
			}

			 set	
			{
				base.SetValue("SAPU9GLVoucherLineDTOS",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
										
		#endregion 

		#region ModelResource
		/// <summary>
		/// SAP与U9凭证对接中间表DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 公司代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompanyCode　{ get { return "";　}　}
		/// <summary>
		/// 公司名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompanyName　{ get { return "";　}　}
		/// <summary>
		/// SAP凭证号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SAPVoucherDisplayCode　{ get { return "";　}　}
		/// <summary>
		/// 凭证类型编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VoucherCategoryCode　{ get { return "";　}　}
		/// <summary>
		/// 凭证类型描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VoucherCategoryDescription　{ get { return "";　}　}
		/// <summary>
		/// 记账日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PostDate　{ get { return "";　}　}
		/// <summary>
		/// 记账期间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PostedPeriod　{ get { return "";　}　}
		/// <summary>
		/// 币种编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyCode　{ get { return "";　}　}
		/// <summary>
		/// 货币描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyDescription　{ get { return "";　}　}
		/// <summary>
		/// SAP与U9凭证对接中间表行列表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SAPU9GLVoucherLineDTOS　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SAPU9GLVoucherDTOData data)
		{
		










		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SAPU9GLVoucherDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SAPU9GLVoucherDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.CompanyCode = data.CompanyCode;

			this.CompanyName = data.CompanyName;

			this.SAPVoucherDisplayCode = data.SAPVoucherDisplayCode;

			this.VoucherCategoryCode = data.VoucherCategoryCode;

			this.VoucherCategoryDescription = data.VoucherCategoryDescription;

			this.PostDate = data.PostDate;

			this.PostedPeriod = data.PostedPeriod;

			this.CurrencyCode = data.CurrencyCode;

			this.CurrencyDescription = data.CurrencyDescription;

	
			if (data.SAPU9GLVoucherLineDTOS != null)
			{	
				List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO> listSAPU9GLVoucherLineDTOS = new List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO>();
				foreach(UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTOData obj in data.SAPU9GLVoucherLineDTOS ){

					UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO child = dict[obj] as UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listSAPU9GLVoucherLineDTOS.Add(child);
				
				}
				this.SAPU9GLVoucherLineDTOS = listSAPU9GLVoucherLineDTOS;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SAPU9GLVoucherDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SAPU9GLVoucherDTOData ToEntityData(SAPU9GLVoucherDTOData data, IDictionary dict){
			if (data == null)
				data = new SAPU9GLVoucherDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SAPU9GLVoucherDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.CompanyCode = this.CompanyCode;

			data.CompanyName = this.CompanyName;

			data.SAPVoucherDisplayCode = this.SAPVoucherDisplayCode;

			data.VoucherCategoryCode = this.VoucherCategoryCode;

			data.VoucherCategoryDescription = this.VoucherCategoryDescription;

			data.PostDate = this.PostDate;

			data.PostedPeriod = this.PostedPeriod;

			data.CurrencyCode = this.CurrencyCode;

			data.CurrencyDescription = this.CurrencyDescription;

	
			if (this.SAPU9GLVoucherLineDTOS != null)
			{	
				List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTOData> listSAPU9GLVoucherLineDTOS = new List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTOData>();
				foreach(UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTO obj in this.SAPU9GLVoucherLineDTOS ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTOData old = dict[obj] as UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherLineDTOData;
					listSAPU9GLVoucherLineDTOS.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.SAPU9GLVoucherLineDTOS = listSAPU9GLVoucherLineDTOS;
			}

			return data ;
		}

		#endregion	
	}	
	
}