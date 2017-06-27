


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOSecondQryBP
{
	/// <summary>
	/// SOSecondQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SOSecondQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SOSecondQryDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
					TotalMoney = 0m; 
					ID = 0; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据编号 (该属性可为空,且无默认值)
		/// SOSecondQryDTO.Misc.单据编号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
				/// <summary>
		/// 客户名称 (该属性可为空,且无默认值)
		/// SOSecondQryDTO.Misc.客户名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerName
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerName",value);
			}
		}
				/// <summary>
		/// 负责人 (该属性可为空,且无默认值)
		/// SOSecondQryDTO.Misc.负责人
		/// </summary>
		/// <value>System.String</value>
		public System.String EnterpriseLegalPerson
		{
			get	
			{	
				return (System.String)base.GetValue("EnterpriseLegalPerson",typeof(System.String));
			}

			 set	
			{
				base.SetValue("EnterpriseLegalPerson",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// SOSecondQryDTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleserName
		{
			get	
			{	
				return (System.String)base.GetValue("SaleserName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleserName",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// SOSecondQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
				/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SOSecondQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 业务日期 (该属性可为空,且无默认值)
		/// SOSecondQryDTO.Misc.业务日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusinessDate",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
							
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// SOSecondQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据编号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 客户名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerName　{ get { return "";　}　}
		/// <summary>
		/// 负责人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EnterpriseLegalPerson　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleserName　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 业务日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SOSecondQryDTOData data)
		{
		







		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SOSecondQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SOSecondQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.DocNo = data.DocNo;

			this.CustomerName = data.CustomerName;

			this.EnterpriseLegalPerson = data.EnterpriseLegalPerson;

			this.SaleserName = data.SaleserName;

			this.TotalMoney = data.TotalMoney;

			this.ID = data.ID;

			this.BusinessDate = data.BusinessDate;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SOSecondQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SOSecondQryDTOData ToEntityData(SOSecondQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SOSecondQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SOSecondQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.DocNo = this.DocNo;

			data.CustomerName = this.CustomerName;

			data.EnterpriseLegalPerson = this.EnterpriseLegalPerson;

			data.SaleserName = this.SaleserName;

			data.TotalMoney = this.TotalMoney;

			data.ID = this.ID;

			data.BusinessDate = this.BusinessDate;

			return data ;
		}

		#endregion	
	}	
	
}