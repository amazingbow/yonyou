


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.AchievementSumQryBP
{
	/// <summary>
	/// AchievementSumQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class AchievementSumQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public AchievementSumQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
					RecTotalMoney = 0m; 
					ARTotalMoney = 0m; 
					BackMoneyRatio = 0m; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// AchievementSumQryDTO.Misc.ID
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
		/// 业务员编码 (该属性可为空,且无默认值)
		/// AchievementSumQryDTO.Misc.业务员编码
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
		/// AchievementSumQryDTO.Misc.业务员
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
		/// AchievementSumQryDTO.Misc.收款金额
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
				/// <summary>
		/// 应收金额 (该属性可为空,但有默认值)
		/// AchievementSumQryDTO.Misc.应收金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ARTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ARTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ARTotalMoney",value);
			}
		}
				/// <summary>
		/// 回款率 (该属性可为空,但有默认值)
		/// AchievementSumQryDTO.Misc.回款率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal BackMoneyRatio
		{
			get	
			{	
				return (System.Decimal)base.GetValue("BackMoneyRatio",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("BackMoneyRatio",value);
			}
		}
				/// <summary>
		/// 回款总额 (该属性可为空,且无默认值)
		/// AchievementSumQryDTO.Misc.回款总额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumRecTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumRecTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumRecTotalMoney",value);
			}
		}
				/// <summary>
		/// 应收总额 (该属性可为空,且无默认值)
		/// AchievementSumQryDTO.Misc.应收总额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumARTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumARTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumARTotalMoney",value);
			}
		}
				/// <summary>
		/// 业务日期 (该属性可为空,且无默认值)
		/// AchievementSumQryDTO.Misc.业务日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusinessDate",value);
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
		/// AchievementSumQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
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
		/// <summary>
		/// 应收金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ARTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 回款率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BackMoneyRatio　{ get { return "";　}　}
		/// <summary>
		/// 回款总额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumRecTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 应收总额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumARTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 业务日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(AchievementSumQryDTOData data)
		{
		









		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(AchievementSumQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(AchievementSumQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.OperatorsCode = data.OperatorsCode;

			this.OperatorsName = data.OperatorsName;

			this.RecTotalMoney = data.RecTotalMoney;

			this.ARTotalMoney = data.ARTotalMoney;

			this.BackMoneyRatio = data.BackMoneyRatio;

			this.SumRecTotalMoney = data.SumRecTotalMoney;

			this.SumARTotalMoney = data.SumARTotalMoney;

			this.BusinessDate = data.BusinessDate;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public AchievementSumQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AchievementSumQryDTOData ToEntityData(AchievementSumQryDTOData data, IDictionary dict){
			if (data == null)
				data = new AchievementSumQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (AchievementSumQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.OperatorsCode = this.OperatorsCode;

			data.OperatorsName = this.OperatorsName;

			data.RecTotalMoney = this.RecTotalMoney;

			data.ARTotalMoney = this.ARTotalMoney;

			data.BackMoneyRatio = this.BackMoneyRatio;

			data.SumRecTotalMoney = this.SumRecTotalMoney;

			data.SumARTotalMoney = this.SumARTotalMoney;

			data.BusinessDate = this.BusinessDate;

			return data ;
		}

		#endregion	
	}	
	
}