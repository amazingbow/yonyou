


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
{
	/// <summary>
	/// 镭射标DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class LbAddDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public LbAddDto(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// 镭射标DTO.Misc.批次号
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
		/// 镭射标 (该属性可为空,且无默认值)
		/// 镭射标DTO.Misc.镭射标
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
		/// 型号 (该属性可为空,且无默认值)
		/// 镭射标DTO.Misc.型号
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
		/// 物料时间 (该属性可为空,且无默认值)
		/// 镭射标DTO.Misc.物料时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime MasterDT
		{
			get	
			{	
				return (System.DateTime)base.GetValue("MasterDT",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("MasterDT",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 镭射标DTO.Misc.客户
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer
		{
			get	
			{	
				return (System.String)base.GetValue("Customer",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 镭射标DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 批次号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BN　{ get { return "";　}　}
		/// <summary>
		/// 镭射标的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LB　{ get { return "";　}　}
		/// <summary>
		/// 型号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Type　{ get { return "";　}　}
		/// <summary>
		/// 物料时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MasterDT　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(LbAddDtoData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(LbAddDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LbAddDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BN = data.BN;

			this.LB = data.LB;

			this.Type = data.Type;

			this.MasterDT = data.MasterDT;

			this.Customer = data.Customer;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LbAddDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LbAddDtoData ToEntityData(LbAddDtoData data, IDictionary dict){
			if (data == null)
				data = new LbAddDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (LbAddDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BN = this.BN;

			data.LB = this.LB;

			data.Type = this.Type;

			data.MasterDT = this.MasterDT;

			data.Customer = this.Customer;

			return data ;
		}

		#endregion	
	}	
	
}