


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 拆分车号数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SplitCarDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SplitCarDTO(){
			initData();
		}
		private void initData()
		{
		
		
					Sequence = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 生产线料品日计划ID (该属性可为空,且无默认值)
		/// 拆分车号数据传输对象.Misc.生产线料品日计划ID
		/// </summary>
		/// <value>System.String</value>
		public System.String PlsID
		{
			get	
			{	
				return (System.String)base.GetValue("PlsID",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PlsID",value);
			}
		}
				/// <summary>
		/// 车号 (该属性可为空,且无默认值)
		/// 拆分车号数据传输对象.Misc.车号
		/// </summary>
		/// <value>System.String</value>
		public System.String ManufactureNo
		{
			get	
			{	
				return (System.String)base.GetValue("ManufactureNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ManufactureNo",value);
			}
		}
				/// <summary>
		/// 车序 (该属性可为空,但有默认值)
		/// 拆分车号数据传输对象.Misc.车序
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Sequence
		{
			get	
			{	
				return (System.Int32)base.GetValue("Sequence",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Sequence",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 拆分车号数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 生产线料品日计划ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PlsID　{ get { return "";　}　}
		/// <summary>
		/// 车号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ManufactureNo　{ get { return "";　}　}
		/// <summary>
		/// 车序的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Sequence　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SplitCarDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SplitCarDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SplitCarDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.PlsID = data.PlsID;

			this.ManufactureNo = data.ManufactureNo;

			this.Sequence = data.Sequence;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SplitCarDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SplitCarDTOData ToEntityData(SplitCarDTOData data, IDictionary dict){
			if (data == null)
				data = new SplitCarDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SplitCarDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.PlsID = this.PlsID;

			data.ManufactureNo = this.ManufactureNo;

			data.Sequence = this.Sequence;

			return data ;
		}

		#endregion	
	}	
	
}