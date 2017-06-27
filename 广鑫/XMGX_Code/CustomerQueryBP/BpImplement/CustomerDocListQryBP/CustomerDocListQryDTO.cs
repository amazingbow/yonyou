


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerDocListQryBP
{
	/// <summary>
	/// CustomerDocListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerDocListQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerDocListQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
		
		
					TotalMoney = 0m; 
					DocType = 0; 
					SumTotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// CustomerDocListQryDTO.Misc.ID
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
		/// 单据编号 (该属性可为空,且无默认值)
		/// CustomerDocListQryDTO.Misc.单据编号
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
		/// 单据日期 (该属性可为空,且无默认值)
		/// CustomerDocListQryDTO.Misc.单据日期
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
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// CustomerDocListQryDTO.Misc.客户
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Customer
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("Customer",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
		 
				/// <summary>
		/// 联系人 (该属性可为空,且无默认值)
		/// CustomerDocListQryDTO.Misc.联系人
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.CustomerContact</value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerContact.EntityKey CustomerContact
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.CustomerContact.EntityKey)base.GetValue("CustomerContact",typeof(UFIDA.U9.CBO.SCM.Customer.CustomerContact.EntityKey));
			}

			 set	
			{
				base.SetValue("CustomerContact",value);
			}
		}
		 
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// CustomerDocListQryDTO.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Operators
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("Operators",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("Operators",value);
			}
		}
		 
				/// <summary>
		/// 总金额 (该属性可为空,但有默认值)
		/// CustomerDocListQryDTO.Misc.总金额
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
		/// 单据种类 (该属性可为空,但有默认值)
		/// CustomerDocListQryDTO.Misc.单据种类
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DocType
		{
			get	
			{	
				return (System.Int32)base.GetValue("DocType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("DocType",value);
			}
		}
				/// <summary>
		/// 合计总金额 (该属性可为空,但有默认值)
		/// CustomerDocListQryDTO.Misc.合计总金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumTotalMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					 
		/// <summary>
		/// 名称
		/// CustomerDocListQryDTO.Misc.名称
		/// </summary>
		public string Customer_Name
		{
			get
			{
				return base.GetMultiLangProp("Customer_Name");
			}
			set
			{
				base.SetMultiLangProp("Customer_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_Name",value);	
			}
		}
		 
		/// <summary>
		/// 名称
		/// CustomerDocListQryDTO.Misc.名称
		/// </summary>
		public string CustomerContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangProp("CustomerContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangProp("CustomerContact_Contact_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_CustomerContact_Contact_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_CustomerContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangPropDict("CustomerContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangPropDict("CustomerContact_Contact_Name",value);	
			}
		}
		 
		/// <summary>
		/// 名称
		/// CustomerDocListQryDTO.Misc.名称
		/// </summary>
		public string Operators_Name
		{
			get
			{
				return base.GetMultiLangProp("Operators_Name");
			}
			set
			{
				base.SetMultiLangProp("Operators_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Operators_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Operators_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Operators_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Operators_Name",value);	
			}
		}
			
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
		/// CustomerDocListQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单据编号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_Name　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Operators　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Operators_Name　{ get { return "";　}　}
		/// <summary>
		/// 总金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 单据种类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocType　{ get { return "";　}　}
		/// <summary>
		/// 合计总金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumTotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerDocListQryDTOData data)
		{
		



			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;


			if (data.CustomerContact == -1 && data.CustomerContact_SKey!=null)
				data.CustomerContact = data.CustomerContact_SKey.GetEntity().ID ;


			if (data.Operators == -1 && data.Operators_SKey!=null)
				data.Operators = data.Operators_SKey.GetEntity().ID ;





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerDocListQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerDocListQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.DocNo = data.DocNo;

			this.BusinessDate = data.BusinessDate;

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			this.Customer_Name = data.Customer_Name;
			this.Multi_Customer_Name = data.Multi_Customer_Name ;

			{
				if (data.CustomerContact <= 0)
					this.CustomerContact = null ;
				else
					this.CustomerContact = new UFIDA.U9.CBO.SCM.Customer.CustomerContact.EntityKey(data.CustomerContact);
			}

			this.CustomerContact_Contact_Name = data.CustomerContact_Contact_Name;
			this.Multi_CustomerContact_Contact_Name = data.Multi_CustomerContact_Contact_Name ;

			{
				if (data.Operators <= 0)
					this.Operators = null ;
				else
					this.Operators = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Operators);
			}

			this.Operators_Name = data.Operators_Name;
			this.Multi_Operators_Name = data.Multi_Operators_Name ;

			this.TotalMoney = data.TotalMoney;

			this.DocType = data.DocType;

			this.SumTotalMoney = data.SumTotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerDocListQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerDocListQryDTOData ToEntityData(CustomerDocListQryDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerDocListQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerDocListQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.BusinessDate = this.BusinessDate;

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			data.Customer_Name  = this.Customer_Name;
			data.Multi_Customer_Name  = this.Multi_Customer_Name;

			if (this.CustomerContact!=null)
			{
				data.CustomerContact = this.CustomerContact.ID;

			}

			data.CustomerContact_Contact_Name  = this.CustomerContact_Contact_Name;
			data.Multi_CustomerContact_Contact_Name  = this.Multi_CustomerContact_Contact_Name;

			if (this.Operators!=null)
			{
				data.Operators = this.Operators.ID;

			}

			data.Operators_Name  = this.Operators_Name;
			data.Multi_Operators_Name  = this.Multi_Operators_Name;

			data.TotalMoney = this.TotalMoney;

			data.DocType = this.DocType;

			data.SumTotalMoney = this.SumTotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}