


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	/// <summary>
	/// LB编码修改DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class LaserLabBNChangeBPDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public LaserLabBNChangeBPDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// LB编码 (该属性可为空,且无默认值)
		/// LB编码修改DTO.Misc.LB编码
		/// </summary>
		/// <value></value>
		public List<System.String> LB
		{
			get	
			{	
				return (List<System.String>)base.GetValue("LB",typeof(List<System.String>));
			}

			 set	
			{
				base.SetValue("LB",value);
			}
		}
				/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// LB编码修改DTO.Misc.批次号
		/// </summary>
		/// <value></value>
		public List<System.String> BN
		{
			get	
			{	
				return (List<System.String>)base.GetValue("BN",typeof(List<System.String>));
			}

			 set	
			{
				base.SetValue("BN",value);
			}
		}
				/// <summary>
		/// 状态 (该属性可为空,且无默认值)
		/// LB编码修改DTO.Misc.状态
		/// </summary>
		/// <value></value>
		public List<System.String> CP
		{
			get	
			{	
				return (List<System.String>)base.GetValue("CP",typeof(List<System.String>));
			}

			 set	
			{
				base.SetValue("CP",value);
			}
		}
				/// <summary>
		/// 物料时间 (该属性可为空,且无默认值)
		/// LB编码修改DTO.Misc.物料时间
		/// </summary>
		/// <value></value>
		public List<System.DateTime> MasterDT
		{
			get	
			{	
				return (List<System.DateTime>)base.GetValue("MasterDT",typeof(List<System.DateTime>));
			}

			 set	
			{
				base.SetValue("MasterDT",value);
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
		/// LB编码修改DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// LB编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LB　{ get { return "";　}　}
		/// <summary>
		/// 批次号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BN　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CP　{ get { return "";　}　}
		/// <summary>
		/// 物料时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MasterDT　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(LaserLabBNChangeBPDTOData data)
		{
		




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(LaserLabBNChangeBPDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(LaserLabBNChangeBPDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.LB = data.LB;

			this.BN = data.BN;

			this.CP = data.CP;

			this.MasterDT = data.MasterDT;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public LaserLabBNChangeBPDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public LaserLabBNChangeBPDTOData ToEntityData(LaserLabBNChangeBPDTOData data, IDictionary dict){
			if (data == null)
				data = new LaserLabBNChangeBPDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (LaserLabBNChangeBPDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.LB = this.LB;

			data.BN = this.BN;

			data.CP = this.CP;

			data.MasterDT = this.MasterDT;

			return data ;
		}

		#endregion	
	}	
	
}