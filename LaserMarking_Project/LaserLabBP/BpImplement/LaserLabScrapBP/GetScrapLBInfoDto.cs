


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	/// <summary>
	/// 报废操作获取LB信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class GetScrapLBInfoDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public GetScrapLBInfoDto(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.批次号
		/// </summary>
		/// <value>System.String</value>
		public System.String BN
		{
			get	
			{	
				return (System.String)base.GetValue("BN",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BN",value);
			}
		}
				/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.型号
		/// </summary>
		/// <value>System.String</value>
		public System.String Type
		{
			get	
			{	
				return (System.String)base.GetValue("Type",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Type",value);
			}
		}
				/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime Date
		{
			get	
			{	
				return (System.DateTime)base.GetValue("Date",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("Date",value);
			}
		}
				/// <summary>
		/// 时间 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime Time
		{
			get	
			{	
				return (System.DateTime)base.GetValue("Time",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("Time",value);
			}
		}
				/// <summary>
		/// 状态 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.状态
		/// </summary>
		/// <value>System.String</value>
		public System.String CP
		{
			get	
			{	
				return (System.String)base.GetValue("CP",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CP",value);
			}
		}
				/// <summary>
		/// LB编码 (该属性可为空,且无默认值)
		/// 报废操作获取LB信息DTO.Misc.LB编码
		/// </summary>
		/// <value>System.String</value>
		public System.String LB
		{
			get	
			{	
				return (System.String)base.GetValue("LB",typeof(System.String));
			}

			 set	
			{
				base.SetValue("LB",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 报废操作获取LB信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 批次号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BN　{ get { return "";　}　}
		/// <summary>
		/// 型号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Type　{ get { return "";　}　}
		/// <summary>
		/// 日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Date　{ get { return "";　}　}
		/// <summary>
		/// 时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Time　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CP　{ get { return "";　}　}
		/// <summary>
		/// LB编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LB　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(GetScrapLBInfoDtoData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(GetScrapLBInfoDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(GetScrapLBInfoDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BN = data.BN;

			this.Type = data.Type;

			this.Date = data.Date;

			this.Time = data.Time;

			this.CP = data.CP;

			this.LB = data.LB;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public GetScrapLBInfoDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public GetScrapLBInfoDtoData ToEntityData(GetScrapLBInfoDtoData data, IDictionary dict){
			if (data == null)
				data = new GetScrapLBInfoDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (GetScrapLBInfoDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BN = this.BN;

			data.Type = this.Type;

			data.Date = this.Date;

			data.Time = this.Time;

			data.CP = this.CP;

			data.LB = this.LB;

			return data ;
		}

		#endregion	
	}	
	
}