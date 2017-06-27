


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.AchievementDetailQryBP
{
	/// <summary>
	/// AchievementDetailQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class AchievementDetailQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public AchievementDetailQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
					RecTotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// AchievementDetailQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 收款日期 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.收款日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime RecDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("RecDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("RecDate",value);
			}
		}
				/// <summary>
		/// 收款单号 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.收款单号
		/// </summary>
		/// <value>System.String</value>
		public System.String RecDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("RecDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("RecDocNo",value);
			}
		}
				/// <summary>
		/// 客户编码 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.客户编码
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerCode
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerCode",value);
			}
		}
				/// <summary>
		/// 客户名称 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.客户名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerName
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerName",value);
			}
		}
				/// <summary>
		/// 业务员编码 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.业务员编码
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorsCode
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorsCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorsCode",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// AchievementDetailQryDTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorsName
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorsName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorsName",value);
			}
		}
				/// <summary>
		/// 收款金额 (该属性可为空,但有默认值)
		/// AchievementDetailQryDTO.Misc.收款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal RecTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("RecTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("RecTotalMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// AchievementDetailQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 收款日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RecDate　{ get { return "";　}　}
		/// <summary>
		/// 收款单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RecDocNo　{ get { return "";　}　}
		/// <summary>
		/// 客户编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerCode　{ get { return "";　}　}
		/// <summary>
		/// 客户名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerName　{ get { return "";　}　}
		/// <summary>
		/// 业务员编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsCode　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsName　{ get { return "";　}　}
		/// <summary>
		/// 收款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RecTotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(AchievementDetailQryDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(AchievementDetailQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(AchievementDetailQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.RecDate = data.RecDate;

			this.RecDocNo = data.RecDocNo;

			this.CustomerCode = data.CustomerCode;

			this.CustomerName = data.CustomerName;

			this.OperatorsCode = data.OperatorsCode;

			this.OperatorsName = data.OperatorsName;

			this.RecTotalMoney = data.RecTotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public AchievementDetailQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AchievementDetailQryDTOData ToEntityData(AchievementDetailQryDTOData data, IDictionary dict){
			if (data == null)
				data = new AchievementDetailQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (AchievementDetailQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.RecDate = this.RecDate;

			data.RecDocNo = this.RecDocNo;

			data.CustomerCode = this.CustomerCode;

			data.CustomerName = this.CustomerName;

			data.OperatorsCode = this.OperatorsCode;

			data.OperatorsName = this.OperatorsName;

			data.RecTotalMoney = this.RecTotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}