using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab
{
	/// <summary>
	/// 枚举值: 镭射标状态 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum LBEnumData
	{
		/// <summary>
		/// 物料
		/// </summary>
		Master = 0,
		/// <summary>
		/// 金油
		/// </summary>
		GoldOil = 1,
		/// <summary>
		/// 包装
		/// </summary>
		Packing = 2,
		/// <summary>
		/// 出货
		/// </summary>
		Shipment = 3,
		/// <summary>
		/// 报废
		/// </summary>
		Scrap = 4,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

