


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SRMRcvDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SRMRcvDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
					Type  ="正常";
		
					InType  ="普通采购";
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SRM入库单DTO.Misc.ID
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
		/// 单号 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.单号
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
		/// 送货单号 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.送货单号
		/// </summary>
		/// <value>System.String</value>
		public System.String STNO
		{
			get	
			{	
				return (System.String)base.GetValue("STNO",typeof(System.String));
			}

			 set	
			{
				base.SetValue("STNO",value);
			}
		}
				/// <summary>
		/// 单据类型 (该属性可为空,但有默认值)
		/// SRM入库单DTO.Misc.单据类型
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
		/// 状态 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.状态
		/// </summary>
		/// <value>System.String</value>
		public System.String Status
		{
			get	
			{	
				return (System.String)base.GetValue("Status",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Status",value);
			}
		}
				/// <summary>
		/// 入库类型 (该属性可为空,但有默认值)
		/// SRM入库单DTO.Misc.入库类型
		/// </summary>
		/// <value>System.String</value>
		public System.String InType
		{
			get	
			{	
				return (System.String)base.GetValue("InType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("InType",value);
			}
		}
				/// <summary>
		/// 采购员 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.采购员
		/// </summary>
		/// <value>System.String</value>
		public System.String CPersonCode
		{
			get	
			{	
				return (System.String)base.GetValue("CPersonCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CPersonCode",value);
			}
		}
				/// <summary>
		/// 入库日期 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.入库日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime InDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("InDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("InDate",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.制单人
		/// </summary>
		/// <value>System.String</value>
		public System.String CMaker
		{
			get	
			{	
				return (System.String)base.GetValue("CMaker",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CMaker",value);
			}
		}
				/// <summary>
		/// 仓库 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.仓库
		/// </summary>
		/// <value>System.String</value>
		public System.String WareHouser
		{
			get	
			{	
				return (System.String)base.GetValue("WareHouser",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WareHouser",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.供应商
		/// </summary>
		/// <value>System.String</value>
		public System.String VendorCode
		{
			get	
			{	
				return (System.String)base.GetValue("VendorCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VendorCode",value);
			}
		}
				/// <summary>
		/// 入库行 (该属性可为空,且无默认值)
		/// SRM入库单DTO.Misc.入库行
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO> SrmRcvLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO>)base.GetValue("SrmRcvLine",typeof(List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO>));
			}

			 set	
			{
				base.SetValue("SrmRcvLine",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
												
		#endregion 

		#region ModelResource
		/// <summary>
		/// SRM入库单DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 送货单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_STNO　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Type　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Status　{ get { return "";　}　}
		/// <summary>
		/// 入库类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InType　{ get { return "";　}　}
		/// <summary>
		/// 采购员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CPersonCode　{ get { return "";　}　}
		/// <summary>
		/// 入库日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InDate　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CMaker　{ get { return "";　}　}
		/// <summary>
		/// 仓库的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WareHouser　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 入库行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrmRcvLine　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SRMRcvDTOData data)
		{
		












		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SRMRcvDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SRMRcvDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.DocNo = data.DocNo;

			this.STNO = data.STNO;

			this.Type = data.Type;

			this.Status = data.Status;

			this.InType = data.InType;

			this.CPersonCode = data.CPersonCode;

			this.InDate = data.InDate;

			this.CMaker = data.CMaker;

			this.WareHouser = data.WareHouser;

			this.VendorCode = data.VendorCode;

	
			if (data.SrmRcvLine != null)
			{	
				List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO> listSrmRcvLine = new List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO>();
				foreach(UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData obj in data.SrmRcvLine ){

					UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO child = dict[obj] as UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listSrmRcvLine.Add(child);
				
				}
				this.SrmRcvLine = listSrmRcvLine;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SRMRcvDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SRMRcvDTOData ToEntityData(SRMRcvDTOData data, IDictionary dict){
			if (data == null)
				data = new SRMRcvDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SRMRcvDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.STNO = this.STNO;

			data.Type = this.Type;

			data.Status = this.Status;

			data.InType = this.InType;

			data.CPersonCode = this.CPersonCode;

			data.InDate = this.InDate;

			data.CMaker = this.CMaker;

			data.WareHouser = this.WareHouser;

			data.VendorCode = this.VendorCode;

	
			if (this.SrmRcvLine != null)
			{	
				List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData> listSrmRcvLine = new List<UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData>();
				foreach(UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTO obj in this.SrmRcvLine ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData old = dict[obj] as UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData;
					listSrmRcvLine.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.SrmRcvLine = listSrmRcvLine;
			}

			return data ;
		}

		#endregion	
	}	
	
}