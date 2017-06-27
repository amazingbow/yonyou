using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMJL.BommBE
{
	/// <summary>
	/// 枚举值: 缺件发料主表状态 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum BomMainStatusEnumData
	{
		/// <summary>
		/// 未发料
		/// </summary>
		UnDisburse = 1,
		/// <summary>
		/// 已发料
		/// </summary>
		Disbursed = 2,
		/// <summary>
		/// 已报告
		/// </summary>
		Report = 3,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.XMJL.BommBE
{
	/// <summary>
	/// 枚举值: 缺件发料主表发料类型 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum BomMainTypeData
	{
		/// <summary>
		/// 批量发料
		/// </summary>
		Batch = 1,
		/// <summary>
		/// 退库发料
		/// </summary>
		Rtn = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.XMJL.BommBE
{
	/// <summary>
	/// 枚举值: 缺件发料单状态 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum BomHeadStatusData
	{
		/// <summary>
		/// 部分发料
		/// </summary>
		PartDisburse = 1,
		/// <summary>
		/// 已发料
		/// </summary>
		Disbursed = 2,
		/// <summary>
		/// 已关闭
		/// </summary>
		Closed = 3,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

