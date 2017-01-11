


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	/// <summary>
	/// 查看报废信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class LookScrapInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public LookScrapInfoDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// LB编码 (该属性可为空,且无默认值)
		/// 查看报废信息DTO.Misc.LB编码
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
				/// <summary>
		/// 状态 (该属性可为空,且无默认值)
		/// 查看报废信息DTO.Misc.状态
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
		/// 批次号 (该属性可为空,且无默认值)
		/// 查看报废信息DTO.Misc.批次号
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
		/// 查看报废信息DTO.Misc.型号
		/// </summary>
		/// <value>System.String</value>
		public System.String TYPE
		{
			get	
			{	
				return (System.String)base.GetValue("TYPE",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TYPE",value);
			}
		}
				/// <summary>
		/// 报废时间 (该属性可为空,且无默认值)
		/// 查看报废信息DTO.Misc.报废时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ScrapDT
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ScrapDT",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ScrapDT",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 查看报废信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// LB编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LB　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CP　{ get { return "";　}　}
		/// <summary>
		/// 批次号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BN　{ get { return "";　}　}
		/// <summary>
		/// 型号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TYPE　{ get { return "";　}　}
		/// <summary>
		/// 报废时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ScrapDT　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(LookScrapInfoDTOData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(LookScrapInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LookScrapInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.LB = data.LB;

			this.CP = data.CP;

			this.BN = data.BN;

			this.TYPE = data.TYPE;

			this.ScrapDT = data.ScrapDT;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LookScrapInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LookScrapInfoDTOData ToEntityData(LookScrapInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new LookScrapInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (LookScrapInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.LB = this.LB;

			data.CP = this.CP;

			data.BN = this.BN;

			data.TYPE = this.TYPE;

			data.ScrapDT = this.ScrapDT;

			return data ;
		}

		#endregion	
	}	
	
}