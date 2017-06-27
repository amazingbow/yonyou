


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP
{
	/// <summary>
	/// GLVoucherSecondQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class GLVoucherSecondQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public GLVoucherSecondQryDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					AccountedDr = 0m; 
					AccountedCr = 0m; 
					ID = 0; 
					SumDr = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 公司名称 (该属性可为空,且无默认值)
		/// GLVoucherSecondQryDTO.Misc.公司名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CompanyName
		{
			get	
			{	
				return (System.String)base.GetValue("CompanyName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CompanyName",value);
			}
		}
				/// <summary>
		/// 应收单据 (该属性可为空,且无默认值)
		/// GLVoucherSecondQryDTO.Misc.应收单据
		/// </summary>
		/// <value>System.String</value>
		public System.String ARDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("ARDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ARDocNo",value);
			}
		}
				/// <summary>
		/// 制单日期 (该属性可为空,且无默认值)
		/// GLVoucherSecondQryDTO.Misc.制单日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreateDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreateDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreateDate",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// GLVoucherSecondQryDTO.Misc.制单人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// GLVoucherSecondQryDTO.Misc.摘要
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
				/// <summary>
		/// 借方金额 (该属性可为空,但有默认值)
		/// GLVoucherSecondQryDTO.Misc.借方金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AccountedDr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AccountedDr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AccountedDr",value);
			}
		}
				/// <summary>
		/// 贷方金额 (该属性可为空,但有默认值)
		/// GLVoucherSecondQryDTO.Misc.贷方金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AccountedCr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AccountedCr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AccountedCr",value);
			}
		}
				/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// GLVoucherSecondQryDTO.Misc.ID
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
		/// 小计 (该属性可为空,但有默认值)
		/// GLVoucherSecondQryDTO.Misc.小计
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumDr
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumDr",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumDr",value);
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
		/// GLVoucherSecondQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 公司名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompanyName　{ get { return "";　}　}
		/// <summary>
		/// 应收单据的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ARDocNo　{ get { return "";　}　}
		/// <summary>
		/// 制单日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreateDate　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 摘要的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 借方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountedDr　{ get { return "";　}　}
		/// <summary>
		/// 贷方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccountedCr　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 小计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumDr　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(GLVoucherSecondQryDTOData data)
		{
		









		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(GLVoucherSecondQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(GLVoucherSecondQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.CompanyName = data.CompanyName;

			this.ARDocNo = data.ARDocNo;

			this.CreateDate = data.CreateDate;

			this.CreatedBy = data.CreatedBy;

			this.Memo = data.Memo;

			this.AccountedDr = data.AccountedDr;

			this.AccountedCr = data.AccountedCr;

			this.ID = data.ID;

			this.SumDr = data.SumDr;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public GLVoucherSecondQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public GLVoucherSecondQryDTOData ToEntityData(GLVoucherSecondQryDTOData data, IDictionary dict){
			if (data == null)
				data = new GLVoucherSecondQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (GLVoucherSecondQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.CompanyName = this.CompanyName;

			data.ARDocNo = this.ARDocNo;

			data.CreateDate = this.CreateDate;

			data.CreatedBy = this.CreatedBy;

			data.Memo = this.Memo;

			data.AccountedDr = this.AccountedDr;

			data.AccountedCr = this.AccountedCr;

			data.ID = this.ID;

			data.SumDr = this.SumDr;

			return data ;
		}

		#endregion	
	}	
	
}