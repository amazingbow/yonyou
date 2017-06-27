


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	/// <summary>
	/// 返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnUpDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnUpDTO(){
			initData();
		}
		private void initData()
		{
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 返回消息 (该属性可为空,且无默认值)
		/// 返回对象.Misc.返回消息
		/// </summary>
		/// <value>System.String</value>
		public System.String Msg
		{
			get	
			{	
				return (System.String)base.GetValue("Msg",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Msg",value);
			}
		}
				/// <summary>
		/// 状态 (该属性可为空,且无默认值)
		/// 返回对象.Misc.状态
		/// </summary>
		/// <value>System.String</value>
		public System.String Status
		{
			get	
			{	
				return (System.String)base.GetValue("Status",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Status",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 返回对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 返回消息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Msg　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Status　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnUpDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnUpDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnUpDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Msg = data.Msg;

			this.Status = data.Status;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnUpDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnUpDTOData ToEntityData(ReturnUpDTOData data, IDictionary dict){
			if (data == null)
				data = new ReturnUpDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnUpDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Msg = this.Msg;

			data.Status = this.Status;

			return data ;
		}

		#endregion	
	}	
	
}