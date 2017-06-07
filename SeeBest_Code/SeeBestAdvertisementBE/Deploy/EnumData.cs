using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	/// <summary>
	/// 枚举值: 版面类型 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvDisplayTypeEnumData
	{
		/// <summary>
		/// 横版版面
		/// </summary>
		H = 1,
		/// <summary>
		/// 竖版版面
		/// </summary>
		V = 2,
		/// <summary>
		/// 方形版面
		/// </summary>
		S = 3,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

