


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.CustomerSV
{
	/// <summary>
	/// 客户额度DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerBalanceDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerBalanceDTO(){
			initData();
		}
		private void initData()
		{
		
		
					Balance = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 客户代码 (该属性可为空,且无默认值)
		/// 客户额度DTO.Misc.客户代码
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
		/// 客户名称 (该属性可为空,且无默认值)
		/// 客户额度DTO.Misc.客户名称
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
		/// 额度 (该属性可为空,但有默认值)
		/// 客户额度DTO.Misc.额度
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Balance
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Balance",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Balance",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 客户额度DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 客户代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Code　{ get { return "";　}　}
		/// <summary>
		/// 客户名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Name　{ get { return "";　}　}
		/// <summary>
		/// 额度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Balance　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerBalanceDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerBalanceDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerBalanceDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Code = data.Code;

			this.Name = data.Name;

			this.Balance = data.Balance;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerBalanceDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerBalanceDTOData ToEntityData(CustomerBalanceDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerBalanceDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerBalanceDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Code = this.Code;

			data.Name = this.Name;

			data.Balance = this.Balance;

			return data ;
		}

		#endregion	
	}	
	
}