


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP
{
	/// <summary>
	/// 费用分摊比例DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CostSharingRationDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CostSharingRationDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
					SysVersion = 0; 
					Ratio = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 费用分摊比例DTO.Misc.ID
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
		/// SysVersion (该属性可为空,但有默认值)
		/// 费用分摊比例DTO.Misc.SysVersion
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 总部与事业部费用分摊比例 (该属性可为空,但有默认值)
		/// 费用分摊比例DTO.Misc.总部与事业部费用分摊比例
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Ratio
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Ratio",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Ratio",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用分摊比例DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// SysVersion的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
		/// <summary>
		/// 总部与事业部费用分摊比例的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Ratio　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CostSharingRationDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CostSharingRationDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CostSharingRationDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.SysVersion = data.SysVersion;

			this.Ratio = data.Ratio;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CostSharingRationDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CostSharingRationDTOData ToEntityData(CostSharingRationDTOData data, IDictionary dict){
			if (data == null)
				data = new CostSharingRationDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CostSharingRationDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.SysVersion = this.SysVersion;

			data.Ratio = this.Ratio;

			return data ;
		}

		#endregion	
	}	
	
}