


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件变更车信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomChangeCarDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomChangeCarDTO(){
			initData();
		}
		private void initData()
		{
		
					CarID = 0; 
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 缺件变更头信息 (该属性可为空,且无默认值)
		/// 缺件变更车信息.Misc.缺件变更头信息
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO</value>
		public UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO BomChangeDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO)base.GetValue("BomChangeDTO",typeof(UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO));
			}

			 set	
			{
				base.SetValue("BomChangeDTO",value);
			}
		}
				/// <summary>
		/// 车号 (该属性可为空,但有默认值)
		/// 缺件变更车信息.Misc.车号
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CarID
		{
			get	
			{	
				return (System.Int64)base.GetValue("CarID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("CarID",value);
			}
		}
				/// <summary>
		/// 车型 (该属性可为空,且无默认值)
		/// 缺件变更车信息.Misc.车型
		/// </summary>
		/// <value>System.String</value>
		public System.String CarType
		{
			get	
			{	
				return (System.String)base.GetValue("CarType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarType",value);
			}
		}
				/// <summary>
		/// 合同号 (该属性可为空,且无默认值)
		/// 缺件变更车信息.Misc.合同号
		/// </summary>
		/// <value>System.String</value>
		public System.String ContractNo
		{
			get	
			{	
				return (System.String)base.GetValue("ContractNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ContractNo",value);
			}
		}
				/// <summary>
		/// 车号Code (该属性可为空,且无默认值)
		/// 缺件变更车信息.Misc.车号Code
		/// </summary>
		/// <value>System.String</value>
		public System.String CarCode
		{
			get	
			{	
				return (System.String)base.GetValue("CarCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarCode",value);
			}
		}
				/// <summary>
		/// 车号Name (该属性可为空,且无默认值)
		/// 缺件变更车信息.Misc.车号Name
		/// </summary>
		/// <value>System.String</value>
		public System.String CarName
		{
			get	
			{	
				return (System.String)base.GetValue("CarName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CarName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件变更车信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 缺件变更头信息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomChangeDTO　{ get { return "";　}　}
		/// <summary>
		/// 车号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarID　{ get { return "";　}　}
		/// <summary>
		/// 车型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarType　{ get { return "";　}　}
		/// <summary>
		/// 合同号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ContractNo　{ get { return "";　}　}
		/// <summary>
		/// 车号Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarCode　{ get { return "";　}　}
		/// <summary>
		/// 车号Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CarName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomChangeCarDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomChangeCarDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomChangeCarDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			if (data.BomChangeDTO!=null)
			{
				UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO temp = dict[data.BomChangeDTO] as UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTO();
					temp.FromEntityData(data.BomChangeDTO,dict);
				}
				this.BomChangeDTO = temp ;
			}
		

			this.CarID = data.CarID;

			this.CarType = data.CarType;

			this.ContractNo = data.ContractNo;

			this.CarCode = data.CarCode;

			this.CarName = data.CarName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomChangeCarDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomChangeCarDTOData ToEntityData(BomChangeCarDTOData data, IDictionary dict){
			if (data == null)
				data = new BomChangeCarDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomChangeCarDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.BomChangeDTO!=null)
			{
				data.BomChangeDTO=this.BomChangeDTO.ToEntityData(null,dict);
			}
		

			data.CarID = this.CarID;

			data.CarType = this.CarType;

			data.ContractNo = this.ContractNo;

			data.CarCode = this.CarCode;

			data.CarName = this.CarName;

			return data ;
		}

		#endregion	
	}	
	
}