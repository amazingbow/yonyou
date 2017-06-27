


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLApBillTestBP
{
	/// <summary>
	/// 收货行信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class RCVLineInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public RCVLineInfoDTO(){
			initData();
		}
		private void initData()
		{
					RCVLine = 0; 
					Amount = 0m; 
					TotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 收货退货行ID (该属性可为空,但有默认值)
		/// 收货行信息.Misc.收货退货行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 RCVLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("RCVLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("RCVLine",value);
			}
		}
				/// <summary>
		/// 收货行立账数量 (该属性可为空,但有默认值)
		/// 收货行信息.Misc.收货行立账数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Amount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Amount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Amount",value);
			}
		}
				/// <summary>
		/// 收货行总价 (该属性可为空,但有默认值)
		/// 收货行信息.Misc.收货行总价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 收货行信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 收货退货行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RCVLine　{ get { return "";　}　}
		/// <summary>
		/// 收货行立账数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Amount　{ get { return "";　}　}
		/// <summary>
		/// 收货行总价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(RCVLineInfoDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(RCVLineInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(RCVLineInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.RCVLine = data.RCVLine;

			this.Amount = data.Amount;

			this.TotalMoney = data.TotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public RCVLineInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public RCVLineInfoDTOData ToEntityData(RCVLineInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new RCVLineInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (RCVLineInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.RCVLine = this.RCVLine;

			data.Amount = this.Amount;

			data.TotalMoney = this.TotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}