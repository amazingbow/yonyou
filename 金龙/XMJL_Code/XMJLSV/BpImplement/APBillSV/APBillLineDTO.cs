


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 汇总立账生单行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class APBillLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public APBillLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
					Qty = 0; 
					UnitPrice = 0; 
					TotalMoney = 0; 
					IsIncludeTax = true; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 部门代码 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.部门代码
		/// </summary>
		/// <value>System.String</value>
		public System.String DeptCode
		{
			get	
			{	
				return (System.String)base.GetValue("DeptCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DeptCode",value);
			}
		}
				/// <summary>
		/// 料品代码 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.料品代码
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// 料品名称 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.料品名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 汇总立账生单行DTO.Misc.数量
		/// </summary>
		/// <value>System.Double</value>
		public System.Double Qty
		{
			get	
			{	
				return (System.Double)base.GetValue("Qty",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 汇总立账生单行DTO.Misc.单价
		/// </summary>
		/// <value>System.Double</value>
		public System.Double UnitPrice
		{
			get	
			{	
				return (System.Double)base.GetValue("UnitPrice",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("UnitPrice",value);
			}
		}
				/// <summary>
		/// 总额 (该属性可为空,但有默认值)
		/// 汇总立账生单行DTO.Misc.总额
		/// </summary>
		/// <value>System.Double</value>
		public System.Double TotalMoney
		{
			get	
			{	
				return (System.Double)base.GetValue("TotalMoney",typeof(System.Double));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
				/// <summary>
		/// 是否含税 (该属性可为空,但有默认值)
		/// 汇总立账生单行DTO.Misc.是否含税
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsIncludeTax
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsIncludeTax",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsIncludeTax",value);
			}
		}
				/// <summary>
		/// 业务员代码 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.业务员代码
		/// </summary>
		/// <value>System.String</value>
		public System.String TransactorCode
		{
			get	
			{	
				return (System.String)base.GetValue("TransactorCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TransactorCode",value);
			}
		}
				/// <summary>
		/// 税组合代码 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.税组合代码
		/// </summary>
		/// <value>System.String</value>
		public System.String TaxCode
		{
			get	
			{	
				return (System.String)base.GetValue("TaxCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TaxCode",value);
			}
		}
				/// <summary>
		/// 收货单 (该属性可为空,且无默认值)
		/// 汇总立账生单行DTO.Misc.收货单
		/// </summary>
		/// <value>UFIDA.U9.PM.Rcv.Receivement</value>
		public UFIDA.U9.PM.Rcv.Receivement Receivement
		{
			get	
			{	
				return (UFIDA.U9.PM.Rcv.Receivement)base.GetValue("Receivement",typeof(UFIDA.U9.PM.Rcv.Receivement));
			}

			 set	
			{
				base.SetValue("Receivement",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 汇总立账生单行DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 部门代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeptCode　{ get { return "";　}　}
		/// <summary>
		/// 料品代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 料品名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UnitPrice　{ get { return "";　}　}
		/// <summary>
		/// 总额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 是否含税的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsIncludeTax　{ get { return "";　}　}
		/// <summary>
		/// 业务员代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TransactorCode　{ get { return "";　}　}
		/// <summary>
		/// 税组合代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TaxCode　{ get { return "";　}　}
		/// <summary>
		/// 收货单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Receivement　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(APBillLineDTOData data)
		{
		










		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(APBillLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(APBillLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.DeptCode = data.DeptCode;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.Qty = data.Qty;

			this.UnitPrice = data.UnitPrice;

			this.TotalMoney = data.TotalMoney;

			this.IsIncludeTax = data.IsIncludeTax;

			this.TransactorCode = data.TransactorCode;

			this.TaxCode = data.TaxCode;

			{
			if (data.Receivement!=null)
			{
				UFIDA.U9.PM.Rcv.Receivement child = dict[data.Receivement] as UFIDA.U9.PM.Rcv.Receivement ;
				if (child == null)
				{
					if (data.Receivement.ID>0)
					{
						if (data.Receivement.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.PM.Rcv.Receivement)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Receivement.ID,data.Receivement.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.PM.Rcv.Receivement)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Receivement.SysEntityType,null,data.Receivement.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.PM.Rcv.Receivement)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Receivement.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Receivement, dict);
				}
				this.Receivement = child ;
			}
			else
				this.Receivement = null ;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public APBillLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public APBillLineDTOData ToEntityData(APBillLineDTOData data, IDictionary dict){
			if (data == null)
				data = new APBillLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (APBillLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.DeptCode = this.DeptCode;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.Qty = this.Qty;

			data.UnitPrice = this.UnitPrice;

			data.TotalMoney = this.TotalMoney;

			data.IsIncludeTax = this.IsIncludeTax;

			data.TransactorCode = this.TransactorCode;

			data.TaxCode = this.TaxCode;

			if (this.Receivement!=null)
			{
				data.Receivement=this.Receivement.ToEntityData(null,dict);
			}

			return data ;
		}

		#endregion	
	}	
	
}