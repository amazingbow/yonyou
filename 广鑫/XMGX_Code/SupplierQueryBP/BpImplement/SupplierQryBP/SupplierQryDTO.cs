


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierQryBP
{
	/// <summary>
	/// SupplierQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
		
		
					APTotalMoney = 0m; 
		
		
		
		
		
		
		
		
					SumAPTotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SupplierQryDTO.Misc.ID
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
		/// 编码 (该属性不可为空,且无默认值)
		/// SupplierQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Supplier_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Supplier_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Supplier_Code",value);
			}
		}
		 
				/// <summary>
		/// 联系人 (该属性不可为空,且无默认值)
		/// SupplierQryDTO.Misc.联系人
		/// </summary>
		/// <value>UFIDA.U9.Base.Contact.Contact</value>
		public UFIDA.U9.Base.Contact.Contact.EntityKey SupplierContact_Contact
		{
			get	
			{	
				return (UFIDA.U9.Base.Contact.Contact.EntityKey)base.GetValue("SupplierContact_Contact",typeof(UFIDA.U9.Base.Contact.Contact.EntityKey));
			}

			 set	
			{
				base.SetValue("SupplierContact_Contact",value);
			}
		}
		 
				/// <summary>
		/// 手机 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.手机
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierContact_Contact_DefaultMobilNum
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierContact_Contact_DefaultMobilNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierContact_Contact_DefaultMobilNum",value);
			}
		}
				/// <summary>
		/// 分类 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.分类
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Supplier.SupplierCategory</value>
		public UFIDA.U9.CBO.SCM.Supplier.SupplierCategory.EntityKey Supplier_Category
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Supplier.SupplierCategory.EntityKey)base.GetValue("Supplier_Category",typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierCategory.EntityKey));
			}

			 set	
			{
				base.SetValue("Supplier_Category",value);
			}
		}
		 
				/// <summary>
		/// 传真 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.传真
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierContact_Contact_DefaultFaxNum
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierContact_Contact_DefaultFaxNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierContact_Contact_DefaultFaxNum",value);
			}
		}
				/// <summary>
		/// 应付余额 (该属性可为空,但有默认值)
		/// SupplierQryDTO.Misc.应付余额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal APTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("APTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("APTotalMoney",value);
			}
		}
				/// <summary>
		/// 税号 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.税号
		/// </summary>
		/// <value>System.String</value>
		public System.String Supplier_StateTaxNo
		{
			get	
			{	
				return (System.String)base.GetValue("Supplier_StateTaxNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Supplier_StateTaxNo",value);
			}
		}
		 
		 
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Supplier_Purchaser
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("Supplier_Purchaser",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("Supplier_Purchaser",value);
			}
		}
		 
		 
				/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// SupplierQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Supplier_ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("Supplier_ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Supplier_ID",value);
			}
		}
				/// <summary>
		/// 电话 (该属性可为空,且无默认值)
		/// SupplierQryDTO.Misc.电话
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierContact_Contact_DefaultPhoneNum
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierContact_Contact_DefaultPhoneNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierContact_Contact_DefaultPhoneNum",value);
			}
		}
				/// <summary>
		/// 合计应付金额 (该属性可为空,但有默认值)
		/// SupplierQryDTO.Misc.合计应付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumAPTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumAPTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumAPTotalMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		public string Supplier_Name
		{
			get
			{
				return base.GetMultiLangProp("Supplier_Name");
			}
			set
			{
				base.SetMultiLangProp("Supplier_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Supplier_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Supplier_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Supplier_Name",value);	
			}
		}
		 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		public string SupplierContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangProp("SupplierContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangProp("SupplierContact_Contact_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SupplierContact_Contact_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SupplierContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SupplierContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SupplierContact_Contact_Name",value);	
			}
		}
			 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		public string Supplier_Category_Name
		{
			get
			{
				return base.GetMultiLangProp("Supplier_Category_Name");
			}
			set
			{
				base.SetMultiLangProp("Supplier_Category_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Supplier_Category_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Category_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Supplier_Category_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Supplier_Category_Name",value);	
			}
		}
				 
		/// <summary>
		/// 开户银行
		/// SupplierQryDTO.Misc.开户银行
		/// </summary>
		public string SupplierBankAccount_Name
		{
			get
			{
				return base.GetMultiLangProp("SupplierBankAccount_Name");
			}
			set
			{
				base.SetMultiLangProp("SupplierBankAccount_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SupplierBankAccount_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SupplierBankAccount_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SupplierBankAccount_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SupplierBankAccount_Name",value);	
			}
		}
	 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		public string Supplier_OfficialLocation_Name
		{
			get
			{
				return base.GetMultiLangProp("Supplier_OfficialLocation_Name");
			}
			set
			{
				base.SetMultiLangProp("Supplier_OfficialLocation_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Supplier_OfficialLocation_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_OfficialLocation_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Supplier_OfficialLocation_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Supplier_OfficialLocation_Name",value);	
			}
		}
		 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		public string Supplier_Purchaser_Name
		{
			get
			{
				return base.GetMultiLangProp("Supplier_Purchaser_Name");
			}
			set
			{
				base.SetMultiLangProp("Supplier_Purchaser_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Supplier_Purchaser_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Purchaser_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Supplier_Purchaser_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Supplier_Purchaser_Name",value);	
			}
		}
	 
		/// <summary>
		/// 描述
		/// SupplierQryDTO.Misc.描述
		/// </summary>
		public string Supplier_Description
		{
			get
			{
				return base.GetMultiLangProp("Supplier_Description");
			}
			set
			{
				base.SetMultiLangProp("Supplier_Description",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Supplier_Description ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Description
		{
			get
			{
				return base.GetMultiLangPropDict("Supplier_Description");
			}
			set
			{
				base.SetMultiLangPropDict("Supplier_Description",value);	
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
		/// SupplierQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Name　{ get { return "";　}　}
		/// <summary>
		/// 联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContact_Contact　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContact_Contact_Name　{ get { return "";　}　}
		/// <summary>
		/// 手机的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContact_Contact_DefaultMobilNum　{ get { return "";　}　}
		/// <summary>
		/// 分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Category　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Category_Name　{ get { return "";　}　}
		/// <summary>
		/// 传真的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContact_Contact_DefaultFaxNum　{ get { return "";　}　}
		/// <summary>
		/// 应付余额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_APTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 税号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_StateTaxNo　{ get { return "";　}　}
		/// <summary>
		/// 开户银行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierBankAccount_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_OfficialLocation_Name　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Purchaser　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Purchaser_Name　{ get { return "";　}　}
		/// <summary>
		/// 描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Description　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_ID　{ get { return "";　}　}
		/// <summary>
		/// 电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierContact_Contact_DefaultPhoneNum　{ get { return "";　}　}
		/// <summary>
		/// 合计应付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumAPTotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierQryDTOData data)
		{
		



			if (data.SupplierContact_Contact == -1 && data.SupplierContact_Contact_SKey!=null)
				data.SupplierContact_Contact = data.SupplierContact_Contact_SKey.GetEntity().ID ;



			if (data.Supplier_Category == -1 && data.Supplier_Category_SKey!=null)
				data.Supplier_Category = data.Supplier_Category_SKey.GetEntity().ID ;







			if (data.Supplier_Purchaser == -1 && data.Supplier_Purchaser_SKey!=null)
				data.Supplier_Purchaser = data.Supplier_Purchaser_SKey.GetEntity().ID ;






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.Supplier_Code = data.Supplier_Code;

			this.Supplier_Name = data.Supplier_Name;
			this.Multi_Supplier_Name = data.Multi_Supplier_Name ;

			{
				if (data.SupplierContact_Contact <= 0)
					this.SupplierContact_Contact = null ;
				else
					this.SupplierContact_Contact = new UFIDA.U9.Base.Contact.Contact.EntityKey(data.SupplierContact_Contact);
			}

			this.SupplierContact_Contact_Name = data.SupplierContact_Contact_Name;
			this.Multi_SupplierContact_Contact_Name = data.Multi_SupplierContact_Contact_Name ;

			this.SupplierContact_Contact_DefaultMobilNum = data.SupplierContact_Contact_DefaultMobilNum;

			{
				if (data.Supplier_Category <= 0)
					this.Supplier_Category = null ;
				else
					this.Supplier_Category = new UFIDA.U9.CBO.SCM.Supplier.SupplierCategory.EntityKey(data.Supplier_Category);
			}

			this.Supplier_Category_Name = data.Supplier_Category_Name;
			this.Multi_Supplier_Category_Name = data.Multi_Supplier_Category_Name ;

			this.SupplierContact_Contact_DefaultFaxNum = data.SupplierContact_Contact_DefaultFaxNum;

			this.APTotalMoney = data.APTotalMoney;

			this.Supplier_StateTaxNo = data.Supplier_StateTaxNo;

			this.SupplierBankAccount_Name = data.SupplierBankAccount_Name;
			this.Multi_SupplierBankAccount_Name = data.Multi_SupplierBankAccount_Name ;

			this.Supplier_OfficialLocation_Name = data.Supplier_OfficialLocation_Name;
			this.Multi_Supplier_OfficialLocation_Name = data.Multi_Supplier_OfficialLocation_Name ;

			{
				if (data.Supplier_Purchaser <= 0)
					this.Supplier_Purchaser = null ;
				else
					this.Supplier_Purchaser = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Supplier_Purchaser);
			}

			this.Supplier_Purchaser_Name = data.Supplier_Purchaser_Name;
			this.Multi_Supplier_Purchaser_Name = data.Multi_Supplier_Purchaser_Name ;

			this.Supplier_Description = data.Supplier_Description;
			this.Multi_Supplier_Description = data.Multi_Supplier_Description ;

			this.Supplier_ID = data.Supplier_ID;

			this.SupplierContact_Contact_DefaultPhoneNum = data.SupplierContact_Contact_DefaultPhoneNum;

			this.SumAPTotalMoney = data.SumAPTotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierQryDTOData ToEntityData(SupplierQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.Supplier_Code = this.Supplier_Code;

			data.Supplier_Name  = this.Supplier_Name;
			data.Multi_Supplier_Name  = this.Multi_Supplier_Name;

			if (this.SupplierContact_Contact!=null)
			{
				data.SupplierContact_Contact = this.SupplierContact_Contact.ID;

			}

			data.SupplierContact_Contact_Name  = this.SupplierContact_Contact_Name;
			data.Multi_SupplierContact_Contact_Name  = this.Multi_SupplierContact_Contact_Name;

			data.SupplierContact_Contact_DefaultMobilNum = this.SupplierContact_Contact_DefaultMobilNum;

			if (this.Supplier_Category!=null)
			{
				data.Supplier_Category = this.Supplier_Category.ID;

			}

			data.Supplier_Category_Name  = this.Supplier_Category_Name;
			data.Multi_Supplier_Category_Name  = this.Multi_Supplier_Category_Name;

			data.SupplierContact_Contact_DefaultFaxNum = this.SupplierContact_Contact_DefaultFaxNum;

			data.APTotalMoney = this.APTotalMoney;

			data.Supplier_StateTaxNo = this.Supplier_StateTaxNo;

			data.SupplierBankAccount_Name  = this.SupplierBankAccount_Name;
			data.Multi_SupplierBankAccount_Name  = this.Multi_SupplierBankAccount_Name;

			data.Supplier_OfficialLocation_Name  = this.Supplier_OfficialLocation_Name;
			data.Multi_Supplier_OfficialLocation_Name  = this.Multi_Supplier_OfficialLocation_Name;

			if (this.Supplier_Purchaser!=null)
			{
				data.Supplier_Purchaser = this.Supplier_Purchaser.ID;

			}

			data.Supplier_Purchaser_Name  = this.Supplier_Purchaser_Name;
			data.Multi_Supplier_Purchaser_Name  = this.Multi_Supplier_Purchaser_Name;

			data.Supplier_Description  = this.Supplier_Description;
			data.Multi_Supplier_Description  = this.Multi_Supplier_Description;

			data.Supplier_ID = this.Supplier_ID;

			data.SupplierContact_Contact_DefaultPhoneNum = this.SupplierContact_Contact_DefaultPhoneNum;

			data.SumAPTotalMoney = this.SumAPTotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}