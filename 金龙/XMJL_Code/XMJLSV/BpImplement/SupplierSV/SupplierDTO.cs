


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.SupplierSV
{
	/// <summary>
	/// 供应商DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 编码 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Code
		{
			get	
			{	
				return (System.String)base.GetValue("Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Code",value);
			}
		}
				/// <summary>
		/// 名称 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.名称
		/// </summary>
		/// <value>System.String</value>
		public System.String Name
		{
			get	
			{	
				return (System.String)base.GetValue("Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Name",value);
			}
		}
				/// <summary>
		/// 办公地址 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.办公地址
		/// </summary>
		/// <value>System.String</value>
		public System.String Address
		{
			get	
			{	
				return (System.String)base.GetValue("Address",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Address",value);
			}
		}
				/// <summary>
		/// 联系人 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.联系人
		/// </summary>
		/// <value>UFIDA.U9.Base.Contact.Contact</value>
		public UFIDA.U9.Base.Contact.Contact Contacts
		{
			get	
			{	
				return (UFIDA.U9.Base.Contact.Contact)base.GetValue("Contacts",typeof(UFIDA.U9.Base.Contact.Contact));
			}

			 set	
			{
				base.SetValue("Contacts",value);
			}
		}
				/// <summary>
		/// 银行名称 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.银行名称
		/// </summary>
		/// <value>System.String</value>
		public System.String BankName
		{
			get	
			{	
				return (System.String)base.GetValue("BankName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BankName",value);
			}
		}
				/// <summary>
		/// 银行账号 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.银行账号
		/// </summary>
		/// <value>System.String</value>
		public System.String BankAccount
		{
			get	
			{	
				return (System.String)base.GetValue("BankAccount",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BankAccount",value);
			}
		}
				/// <summary>
		/// 银行联行号 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.银行联行号
		/// </summary>
		/// <value>System.String</value>
		public System.String BankLineNo
		{
			get	
			{	
				return (System.String)base.GetValue("BankLineNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BankLineNo",value);
			}
		}
				/// <summary>
		/// 地税号 (该属性可为空,且无默认值)
		/// 供应商DTO.Misc.地税号
		/// </summary>
		/// <value>System.String</value>
		public System.String TaxNo
		{
			get	
			{	
				return (System.String)base.GetValue("TaxNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TaxNo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 供应商DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Name　{ get { return "";　}　}
		/// <summary>
		/// 办公地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Address　{ get { return "";　}　}
		/// <summary>
		/// 联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Contacts　{ get { return "";　}　}
		/// <summary>
		/// 银行名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankName　{ get { return "";　}　}
		/// <summary>
		/// 银行账号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankAccount　{ get { return "";　}　}
		/// <summary>
		/// 银行联行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankLineNo　{ get { return "";　}　}
		/// <summary>
		/// 地税号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TaxNo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Code = data.Code;

			this.Name = data.Name;

			this.Address = data.Address;

			{
			if (data.Contacts!=null)
			{
				UFIDA.U9.Base.Contact.Contact child = dict[data.Contacts] as UFIDA.U9.Base.Contact.Contact ;
				if (child == null)
				{
					if (data.Contacts.ID>0)
					{
						if (data.Contacts.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Contact.Contact)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Contacts.ID,data.Contacts.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Contact.Contact)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Contacts.SysEntityType,null,data.Contacts.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Contact.Contact)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Contacts.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Contacts, dict);
				}
				this.Contacts = child ;
			}
			else
				this.Contacts = null ;
			}

			this.BankName = data.BankName;

			this.BankAccount = data.BankAccount;

			this.BankLineNo = data.BankLineNo;

			this.TaxNo = data.TaxNo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierDTOData ToEntityData(SupplierDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Code = this.Code;

			data.Name = this.Name;

			data.Address = this.Address;

			if (this.Contacts!=null)
			{
				data.Contacts=this.Contacts.ToEntityData(null,dict);
			}

			data.BankName = this.BankName;

			data.BankAccount = this.BankAccount;

			data.BankLineNo = this.BankLineNo;

			data.TaxNo = this.TaxNo;

			return data ;
		}

		#endregion	
	}	
	
}