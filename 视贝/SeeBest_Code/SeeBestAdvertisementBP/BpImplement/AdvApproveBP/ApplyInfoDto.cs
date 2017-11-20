


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
	/// <summary>
	/// 申请单信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ApplyInfoDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ApplyInfoDto(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					Width = 0m; 
					Thick = 0m; 
					Height = 0m; 
		
		
		
					ApplyId = 0; 
					Area = 0m; 
					ApplyQty = 0m; 
		
					ActualPrice = 0m; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 区县 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.区县
		/// </summary>
		/// <value>System.String</value>
		public System.String Location
		{
			get	
			{	
				return (System.String)base.GetValue("Location",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Location",value);
			}
		}
				/// <summary>
		/// 办事处 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.办事处
		/// </summary>
		/// <value>System.String</value>
		public System.String AdvAppCustName
		{
			get	
			{	
				return (System.String)base.GetValue("AdvAppCustName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AdvAppCustName",value);
			}
		}
				/// <summary>
		/// 乡镇 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.乡镇
		/// </summary>
		/// <value>System.String</value>
		public System.String Country
		{
			get	
			{	
				return (System.String)base.GetValue("Country",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Country",value);
			}
		}
				/// <summary>
		/// 客户店名 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.客户店名
		/// </summary>
		/// <value>System.String</value>
		public System.String CustCounterName
		{
			get	
			{	
				return (System.String)base.GetValue("CustCounterName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustCounterName",value);
			}
		}
				/// <summary>
		/// 联系人 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.联系人
		/// </summary>
		/// <value>System.String</value>
		public System.String RelPeople
		{
			get	
			{	
				return (System.String)base.GetValue("RelPeople",typeof(System.String));
			}

			 set	
			{
				base.SetValue("RelPeople",value);
			}
		}
				/// <summary>
		/// 联系电话 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.联系电话
		/// </summary>
		/// <value>System.String</value>
		public System.String RelPhone
		{
			get	
			{	
				return (System.String)base.GetValue("RelPhone",typeof(System.String));
			}

			 set	
			{
				base.SetValue("RelPhone",value);
			}
		}
				/// <summary>
		/// 客户地址 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.客户地址
		/// </summary>
		/// <value>System.String</value>
		public System.String CustAddress
		{
			get	
			{	
				return (System.String)base.GetValue("CustAddress",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustAddress",value);
			}
		}
				/// <summary>
		/// 宽 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.宽
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Width
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Width",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Width",value);
			}
		}
				/// <summary>
		/// 厚 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.厚
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Thick
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Thick",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Thick",value);
			}
		}
				/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.高
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Height
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Height",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Height",value);
			}
		}
				/// <summary>
		/// 广告编码 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.广告编码
		/// </summary>
		/// <value>System.String</value>
		public System.String ApplyAdvCode
		{
			get	
			{	
				return (System.String)base.GetValue("ApplyAdvCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ApplyAdvCode",value);
			}
		}
				/// <summary>
		/// 广告载体 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.广告载体
		/// </summary>
		/// <value>System.String</value>
		public System.String AdvCarrier
		{
			get	
			{	
				return (System.String)base.GetValue("AdvCarrier",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AdvCarrier",value);
			}
		}
				/// <summary>
		/// 广告项目 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.广告项目
		/// </summary>
		/// <value>System.String</value>
		public System.String AdvItem
		{
			get	
			{	
				return (System.String)base.GetValue("AdvItem",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AdvItem",value);
			}
		}
				/// <summary>
		/// 申请单ID (该属性可为空,但有默认值)
		/// 申请单信息.Misc.申请单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ApplyId
		{
			get	
			{	
				return (System.Int64)base.GetValue("ApplyId",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ApplyId",value);
			}
		}
				/// <summary>
		/// 面积 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.面积
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Area
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Area",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Area",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ApplyQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ApplyQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ApplyQty",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
				/// <summary>
		/// 核销单价 (该属性可为空,但有默认值)
		/// 申请单信息.Misc.核销单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ActualPrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ActualPrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ActualPrice",value);
			}
		}
				/// <summary>
		/// 下单日期 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.下单日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ApplyDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ApplyDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ApplyDate",value);
			}
		}
				/// <summary>
		/// 广告载体编号 (该属性可为空,且无默认值)
		/// 申请单信息.Misc.广告载体编号
		/// </summary>
		/// <value>System.String</value>
		public System.String AdvCarrierCode
		{
			get	
			{	
				return (System.String)base.GetValue("AdvCarrierCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AdvCarrierCode",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																				
		#endregion 

		#region ModelResource
		/// <summary>
		/// 申请单信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 区县的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Location　{ get { return "";　}　}
		/// <summary>
		/// 办事处的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AdvAppCustName　{ get { return "";　}　}
		/// <summary>
		/// 乡镇的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Country　{ get { return "";　}　}
		/// <summary>
		/// 客户店名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustCounterName　{ get { return "";　}　}
		/// <summary>
		/// 联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RelPeople　{ get { return "";　}　}
		/// <summary>
		/// 联系电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RelPhone　{ get { return "";　}　}
		/// <summary>
		/// 客户地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustAddress　{ get { return "";　}　}
		/// <summary>
		/// 宽的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Width　{ get { return "";　}　}
		/// <summary>
		/// 厚的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Thick　{ get { return "";　}　}
		/// <summary>
		/// 高的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Height　{ get { return "";　}　}
		/// <summary>
		/// 广告编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ApplyAdvCode　{ get { return "";　}　}
		/// <summary>
		/// 广告载体的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AdvCarrier　{ get { return "";　}　}
		/// <summary>
		/// 广告项目的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AdvItem　{ get { return "";　}　}
		/// <summary>
		/// 申请单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ApplyId　{ get { return "";　}　}
		/// <summary>
		/// 面积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Area　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ApplyQty　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 核销单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ActualPrice　{ get { return "";　}　}
		/// <summary>
		/// 下单日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ApplyDate　{ get { return "";　}　}
		/// <summary>
		/// 广告载体编号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AdvCarrierCode　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ApplyInfoDtoData data)
		{
		




















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ApplyInfoDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ApplyInfoDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Location = data.Location;

			this.AdvAppCustName = data.AdvAppCustName;

			this.Country = data.Country;

			this.CustCounterName = data.CustCounterName;

			this.RelPeople = data.RelPeople;

			this.RelPhone = data.RelPhone;

			this.CustAddress = data.CustAddress;

			this.Width = data.Width;

			this.Thick = data.Thick;

			this.Height = data.Height;

			this.ApplyAdvCode = data.ApplyAdvCode;

			this.AdvCarrier = data.AdvCarrier;

			this.AdvItem = data.AdvItem;

			this.ApplyId = data.ApplyId;

			this.Area = data.Area;

			this.ApplyQty = data.ApplyQty;

			this.Memo = data.Memo;

			this.ActualPrice = data.ActualPrice;

			this.ApplyDate = data.ApplyDate;

			this.AdvCarrierCode = data.AdvCarrierCode;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ApplyInfoDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ApplyInfoDtoData ToEntityData(ApplyInfoDtoData data, IDictionary dict){
			if (data == null)
				data = new ApplyInfoDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ApplyInfoDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Location = this.Location;

			data.AdvAppCustName = this.AdvAppCustName;

			data.Country = this.Country;

			data.CustCounterName = this.CustCounterName;

			data.RelPeople = this.RelPeople;

			data.RelPhone = this.RelPhone;

			data.CustAddress = this.CustAddress;

			data.Width = this.Width;

			data.Thick = this.Thick;

			data.Height = this.Height;

			data.ApplyAdvCode = this.ApplyAdvCode;

			data.AdvCarrier = this.AdvCarrier;

			data.AdvItem = this.AdvItem;

			data.ApplyId = this.ApplyId;

			data.Area = this.Area;

			data.ApplyQty = this.ApplyQty;

			data.Memo = this.Memo;

			data.ActualPrice = this.ActualPrice;

			data.ApplyDate = this.ApplyDate;

			data.AdvCarrierCode = this.AdvCarrierCode;

			return data ;
		}

		#endregion	
	}	
	
}