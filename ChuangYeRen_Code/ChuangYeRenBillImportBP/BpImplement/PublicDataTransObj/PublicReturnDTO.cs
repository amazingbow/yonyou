


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace PublicDataTransObj
{
	/// <summary>
	/// 返回对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PublicReturnDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PublicReturnDTO(){
			initData();
		}
		private void initData()
		{
					Flag = false; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 返回标志 (该属性可为空,但有默认值)
		/// 返回对象.Misc.返回标志
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean Flag
		{
			get	
			{	
				return (System.Boolean)base.GetValue("Flag",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("Flag",value);
			}
		}
				/// <summary>
		/// 返回信息 (该属性可为空,且无默认值)
		/// 返回对象.Misc.返回信息
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
		/// 单号 (该属性可为空,且无默认值)
		/// 返回对象.Misc.单号
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
		/// 单据ID (该属性可为空,且无默认值)
		/// 返回对象.Misc.单据ID
		/// </summary>
		/// <value>System.String</value>
		public System.String DocID
		{
			get	
			{	
				return (System.String)base.GetValue("DocID",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocID",value);
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
		/// 返回标志的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Flag　{ get { return "";　}　}
		/// <summary>
		/// 返回信息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Message　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PublicReturnDTOData data)
		{
		




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PublicReturnDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PublicReturnDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.Flag = data.Flag;

			this.Message = data.Message;

			this.DocNo = data.DocNo;

			this.DocID = data.DocID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PublicReturnDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PublicReturnDTOData ToEntityData(PublicReturnDTOData data, IDictionary dict){
			if (data == null)
				data = new PublicReturnDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PublicReturnDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.Flag = this.Flag;

			data.Message = this.Message;

			data.DocNo = this.DocNo;

			data.DocID = this.DocID;

			return data ;
		}

		#endregion	
	}	
	
}