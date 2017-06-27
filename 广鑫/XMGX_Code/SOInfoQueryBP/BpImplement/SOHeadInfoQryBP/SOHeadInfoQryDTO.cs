


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP
{
	/// <summary>
	/// SOHeadInfoQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SOHeadInfoQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SOHeadInfoQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
		
		
		
		
		
		
					SO_TotalMoneyAC = 0m; 
		
		
		
					SumTotalMoney = 0m; 
					TotalShipMoney = 0m; 
					SumTotalShipMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SOHeadInfoQryDTO.Misc.ID
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
		/// 单号 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SO_DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SO_DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SO_DocNo",value);
			}
		}
				/// <summary>
		/// 单据日期 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.单据日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime SO_BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("SO_BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("SO_BusinessDate",value);
			}
		}
				/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_Code",value);
			}
		}
		 
		 
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SO_Seller
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("SO_Seller",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("SO_Seller",value);
			}
		}
				/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SO_Seller_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SO_Seller_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SO_Seller_Code",value);
			}
		}
		 
				/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.部门
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department.EntityKey SO_SaleDepartment
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department.EntityKey)base.GetValue("SO_SaleDepartment",typeof(UFIDA.U9.CBO.HR.Department.Department.EntityKey));
			}

			 set	
			{
				base.SetValue("SO_SaleDepartment",value);
			}
		}
				/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SO_SaleDepartment_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SO_SaleDepartment_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SO_SaleDepartment_Code",value);
			}
		}
		 
				/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SO_ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SO_ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SO_ID",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// SOHeadInfoQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SO_TotalMoneyAC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SO_TotalMoneyAC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SO_TotalMoneyAC",value);
			}
		}
				/// <summary>
		/// 电话 (该属性可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.电话
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact_Contact_DefaultPhoneNum
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact_Contact_DefaultPhoneNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact_DefaultPhoneNum",value);
			}
		}
				/// <summary>
		/// 手机 (该属性可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.手机
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact_Contact_DefaultMobilNum
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact_Contact_DefaultMobilNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact_DefaultMobilNum",value);
			}
		}
				/// <summary>
		/// 负责人 (该属性不可为空,且无默认值)
		/// SOHeadInfoQryDTO.Misc.负责人
		/// </summary>
		/// <value>UFIDA.U9.Base.Contact.Contact</value>
		public UFIDA.U9.Base.Contact.Contact.EntityKey CustomerContact_Contact
		{
			get	
			{	
				return (UFIDA.U9.Base.Contact.Contact.EntityKey)base.GetValue("CustomerContact_Contact",typeof(UFIDA.U9.Base.Contact.Contact.EntityKey));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact",value);
			}
		}
				/// <summary>
		/// 合计金额 (该属性可为空,但有默认值)
		/// SOHeadInfoQryDTO.Misc.合计金额
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
				/// <summary>
		/// 累计出货金额 (该属性可为空,但有默认值)
		/// SOHeadInfoQryDTO.Misc.累计出货金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalShipMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalShipMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalShipMoney",value);
			}
		}
				/// <summary>
		/// 标准出货 (该属性可为空,但有默认值)
		/// SOHeadInfoQryDTO.Misc.标准出货
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumTotalShipMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumTotalShipMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumTotalShipMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					 
		/// <summary>
		/// 名称
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		public string SO_Seller_Name
		{
			get
			{
				return base.GetMultiLangProp("SO_Seller_Name");
			}
			set
			{
				base.SetMultiLangProp("SO_Seller_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SO_Seller_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SO_Seller_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SO_Seller_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SO_Seller_Name",value);	
			}
		}
			 
		/// <summary>
		/// 名称
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		public string SO_SaleDepartment_Name
		{
			get
			{
				return base.GetMultiLangProp("SO_SaleDepartment_Name");
			}
			set
			{
				base.SetMultiLangProp("SO_SaleDepartment_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SO_SaleDepartment_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SO_SaleDepartment_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SO_SaleDepartment_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SO_SaleDepartment_Name",value);	
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
		/// SOHeadInfoQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_Name　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_Seller　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_Seller_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_Seller_Name　{ get { return "";　}　}
		/// <summary>
		/// 部门的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_SaleDepartment　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_SaleDepartment_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_SaleDepartment_Name　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_ID　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_TotalMoneyAC　{ get { return "";　}　}
		/// <summary>
		/// 电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_DefaultPhoneNum　{ get { return "";　}　}
		/// <summary>
		/// 手机的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_DefaultMobilNum　{ get { return "";　}　}
		/// <summary>
		/// 负责人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact　{ get { return "";　}　}
		/// <summary>
		/// 合计金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 累计出货金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalShipMoney　{ get { return "";　}　}
		/// <summary>
		/// 标准出货的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumTotalShipMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SOHeadInfoQryDTOData data)
		{
		






			if (data.SO_Seller == -1 && data.SO_Seller_SKey!=null)
				data.SO_Seller = data.SO_Seller_SKey.GetEntity().ID ;



			if (data.SO_SaleDepartment == -1 && data.SO_SaleDepartment_SKey!=null)
				data.SO_SaleDepartment = data.SO_SaleDepartment_SKey.GetEntity().ID ;







			if (data.CustomerContact_Contact == -1 && data.CustomerContact_Contact_SKey!=null)
				data.CustomerContact_Contact = data.CustomerContact_Contact_SKey.GetEntity().ID ;




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SOHeadInfoQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SOHeadInfoQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.SO_DocNo = data.SO_DocNo;

			this.SO_BusinessDate = data.SO_BusinessDate;

			this.Customer_Code = data.Customer_Code;

			this.Customer_Name = data.Customer_Name;
			this.Multi_Customer_Name = data.Multi_Customer_Name ;

			this.CustomerContact_Contact_Name = data.CustomerContact_Contact_Name;
			this.Multi_CustomerContact_Contact_Name = data.Multi_CustomerContact_Contact_Name ;

			{
				if (data.SO_Seller <= 0)
					this.SO_Seller = null ;
				else
					this.SO_Seller = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.SO_Seller);
			}

			this.SO_Seller_Code = data.SO_Seller_Code;

			this.SO_Seller_Name = data.SO_Seller_Name;
			this.Multi_SO_Seller_Name = data.Multi_SO_Seller_Name ;

			{
				if (data.SO_SaleDepartment <= 0)
					this.SO_SaleDepartment = null ;
				else
					this.SO_SaleDepartment = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(data.SO_SaleDepartment);
			}

			this.SO_SaleDepartment_Code = data.SO_SaleDepartment_Code;

			this.SO_SaleDepartment_Name = data.SO_SaleDepartment_Name;
			this.Multi_SO_SaleDepartment_Name = data.Multi_SO_SaleDepartment_Name ;

			this.SO_ID = data.SO_ID;

			this.SO_TotalMoneyAC = data.SO_TotalMoneyAC;

			this.CustomerContact_Contact_DefaultPhoneNum = data.CustomerContact_Contact_DefaultPhoneNum;

			this.CustomerContact_Contact_DefaultMobilNum = data.CustomerContact_Contact_DefaultMobilNum;

			{
				if (data.CustomerContact_Contact <= 0)
					this.CustomerContact_Contact = null ;
				else
					this.CustomerContact_Contact = new UFIDA.U9.Base.Contact.Contact.EntityKey(data.CustomerContact_Contact);
			}

			this.SumTotalMoney = data.SumTotalMoney;

			this.TotalShipMoney = data.TotalShipMoney;

			this.SumTotalShipMoney = data.SumTotalShipMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SOHeadInfoQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SOHeadInfoQryDTOData ToEntityData(SOHeadInfoQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SOHeadInfoQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SOHeadInfoQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.SO_DocNo = this.SO_DocNo;

			data.SO_BusinessDate = this.SO_BusinessDate;

			data.Customer_Code = this.Customer_Code;

			data.Customer_Name  = this.Customer_Name;
			data.Multi_Customer_Name  = this.Multi_Customer_Name;

			data.CustomerContact_Contact_Name  = this.CustomerContact_Contact_Name;
			data.Multi_CustomerContact_Contact_Name  = this.Multi_CustomerContact_Contact_Name;

			if (this.SO_Seller!=null)
			{
				data.SO_Seller = this.SO_Seller.ID;

			}

			data.SO_Seller_Code = this.SO_Seller_Code;

			data.SO_Seller_Name  = this.SO_Seller_Name;
			data.Multi_SO_Seller_Name  = this.Multi_SO_Seller_Name;

			if (this.SO_SaleDepartment!=null)
			{
				data.SO_SaleDepartment = this.SO_SaleDepartment.ID;

			}

			data.SO_SaleDepartment_Code = this.SO_SaleDepartment_Code;

			data.SO_SaleDepartment_Name  = this.SO_SaleDepartment_Name;
			data.Multi_SO_SaleDepartment_Name  = this.Multi_SO_SaleDepartment_Name;

			data.SO_ID = this.SO_ID;

			data.SO_TotalMoneyAC = this.SO_TotalMoneyAC;

			data.CustomerContact_Contact_DefaultPhoneNum = this.CustomerContact_Contact_DefaultPhoneNum;

			data.CustomerContact_Contact_DefaultMobilNum = this.CustomerContact_Contact_DefaultMobilNum;

			if (this.CustomerContact_Contact!=null)
			{
				data.CustomerContact_Contact = this.CustomerContact_Contact.ID;

			}

			data.SumTotalMoney = this.SumTotalMoney;

			data.TotalShipMoney = this.TotalShipMoney;

			data.SumTotalShipMoney = this.SumTotalShipMoney;

			return data ;
		}

		#endregion	
	}	
	
}