


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
	/// <summary>
	/// 值集数据返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnValueSetDef  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnValueSetDef(){
			initData();
		}
		private void initData()
		{
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 编码 (该属性可为空,且无默认值)
		/// 值集数据返回对象.Misc.编码
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
		/// 值集数据返回对象.Misc.名称
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
		/// 简码描述 (该属性可为空,且无默认值)
		/// 值集数据返回对象.Misc.简码描述
		/// </summary>
		/// <value>System.String</value>
		public System.String Description
		{
			get	
			{	
				return (System.String)base.GetValue("Description",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Description",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 值集数据返回对象的显示名称资源--已经废弃，不使用.
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
		/// 简码描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Description　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnValueSetDefData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnValueSetDefData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnValueSetDefData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Code = data.Code;

			this.Name = data.Name;

			this.Description = data.Description;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnValueSetDefData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnValueSetDefData ToEntityData(ReturnValueSetDefData data, IDictionary dict){
			if (data == null)
				data = new ReturnValueSetDefData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnValueSetDefData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Code = this.Code;

			data.Name = this.Name;

			data.Description = this.Description;

			return data ;
		}

		#endregion	
	}	
	
}