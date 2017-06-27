


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SrmRcvLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SrmRcvLineDTO(){
			initData();
		}
		private void initData()
		{
		
					ID = 0; 
					LineNum = 0; 
		
					InQty = 0m; 
					Price = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// SRM入库单DTO (该属性可为空,且无默认值)
		/// SRM入库行DTO.Misc.SRM入库单DTO
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO</value>
		public UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO SRMRcvDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO)base.GetValue("SRMRcvDTO",typeof(UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO));
			}

			 set	
			{
				base.SetValue("SRMRcvDTO",value);
			}
		}
				/// <summary>
		/// 行ID (该属性可为空,但有默认值)
		/// SRM入库行DTO.Misc.行ID
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
		/// 行号 (该属性可为空,但有默认值)
		/// SRM入库行DTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 LineNum
		{
			get	
			{	
				return (System.Int32)base.GetValue("LineNum",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("LineNum",value);
			}
		}
				/// <summary>
		/// 件号 (该属性可为空,且无默认值)
		/// SRM入库行DTO.Misc.件号
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
		/// 入库数量 (该属性可为空,但有默认值)
		/// SRM入库行DTO.Misc.入库数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal InQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("InQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("InQty",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// SRM入库行DTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Price
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Price",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Price",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// SRM入库行DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// SRM入库单DTO的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SRMRcvDTO　{ get { return "";　}　}
		/// <summary>
		/// 行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LineNum　{ get { return "";　}　}
		/// <summary>
		/// 件号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 入库数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InQty　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Price　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SrmRcvLineDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SrmRcvLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SrmRcvLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			if (data.SRMRcvDTO!=null)
			{
				UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO temp = dict[data.SRMRcvDTO] as UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO();
					temp.FromEntityData(data.SRMRcvDTO,dict);
				}
				this.SRMRcvDTO = temp ;
			}
		

			this.ID = data.ID;

			this.LineNum = data.LineNum;

			this.ItemCode = data.ItemCode;

			this.InQty = data.InQty;

			this.Price = data.Price;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SrmRcvLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SrmRcvLineDTOData ToEntityData(SrmRcvLineDTOData data, IDictionary dict){
			if (data == null)
				data = new SrmRcvLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SrmRcvLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SRMRcvDTO!=null)
			{
				data.SRMRcvDTO=this.SRMRcvDTO.ToEntityData(null,dict);
			}
		

			data.ID = this.ID;

			data.LineNum = this.LineNum;

			data.ItemCode = this.ItemCode;

			data.InQty = this.InQty;

			data.Price = this.Price;

			return data ;
		}

		#endregion	
	}	
	
}