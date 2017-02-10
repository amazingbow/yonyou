


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV
{
	/// <summary>
	/// 通用返回结果对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CommonResultDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CommonResultDTO(){
			initData();
		}
		private void initData()
		{
					IsSuccess = false; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 是否成功 (该属性可为空,但有默认值)
		/// 通用返回结果对象.Misc.是否成功
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsSuccess
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsSuccess",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsSuccess",value);
			}
		}
				/// <summary>
		/// 消息 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.消息
		/// </summary>
		/// <value>System.String</value>
		public System.String Message
		{
			get	
			{	
				return (System.String)base.GetValue("Message",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Message",value);
			}
		}
				/// <summary>
		/// 返回对象 (该属性可为空,且无默认值)
		/// 通用返回结果对象.Misc.返回对象
		/// </summary>
		/// <value>System.Object</value>
		public System.Object ResultObj
		{
			get	
			{	
				return (System.Object)base.GetValue("ResultObj",typeof(System.Object));
			}

			 set	
			{
				base.SetValue("ResultObj",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 通用返回结果对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 是否成功的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsSuccess　{ get { return "";　}　}
		/// <summary>
		/// 消息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Message　{ get { return "";　}　}
		/// <summary>
		/// 返回对象的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ResultObj　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CommonResultDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CommonResultDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CommonResultDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.IsSuccess = data.IsSuccess;

			this.Message = data.Message;

			this.ResultObj = data.ResultObj;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CommonResultDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CommonResultDTOData ToEntityData(CommonResultDTOData data, IDictionary dict){
			if (data == null)
				data = new CommonResultDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CommonResultDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.IsSuccess = this.IsSuccess;

			data.Message = this.Message;

			data.ResultObj = this.ResultObj;

			return data ;
		}

		#endregion	
	}	
	
}