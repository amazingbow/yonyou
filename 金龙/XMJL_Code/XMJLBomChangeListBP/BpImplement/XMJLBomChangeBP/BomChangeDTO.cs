


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件变更头信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BomChangeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BomChangeDTO(){
			initData();
		}
		private void initData()
		{
					BomChangeId = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 更改表头 (该属性可为空,但有默认值)
		/// 缺件变更头信息.Misc.更改表头
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 BomChangeId
		{
			get	
			{	
				return (System.Int64)base.GetValue("BomChangeId",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("BomChangeId",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
	
		#endregion 

		#region ModelResource
		/// <summary>
		/// 缺件变更头信息的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 更改表头的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomChangeId　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BomChangeDTOData data)
		{
		

		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BomChangeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BomChangeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BomChangeId = data.BomChangeId;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BomChangeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BomChangeDTOData ToEntityData(BomChangeDTOData data, IDictionary dict){
			if (data == null)
				data = new BomChangeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BomChangeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BomChangeId = this.BomChangeId;

			return data ;
		}

		#endregion	
	}	
	
}