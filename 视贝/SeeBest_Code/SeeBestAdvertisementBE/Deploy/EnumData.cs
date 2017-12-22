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

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	/// <summary>
	/// 枚举值: 广告申请单状态枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvApplyStatusEnumData
	{
		/// <summary>
		/// 开立
		/// </summary>
		OpenL = 0,
		/// <summary>
		/// 审核中
		/// </summary>
		Approving = 1,
		/// <summary>
		/// 审核
		/// </summary>
		Approved = 2,
		/// <summary>
		/// 关闭
		/// </summary>
		Closed = 3,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	/// <summary>
	/// 枚举值: 版面要求1 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvPageReq1EnumData
	{
		/// <summary>
		/// 客户内容与公司广告融合
		/// </summary>
		Content1 = 0,
		/// <summary>
		/// 客户内容与公司广告不融合
		/// </summary>
		Content2 = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	/// <summary>
	/// 枚举值: 版面要求2 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvPageReq2EnumData
	{
		/// <summary>
		/// 客户内容与公司广告上下分割
		/// </summary>
		UpContent = 0,
		/// <summary>
		/// 客户内容与公司广告左右分割
		/// </summary>
		LeftContent = 1,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	/// <summary>
	/// 枚举值: 专柜设计风格 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum SpecialDesignStyleEnumData
	{
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	/// <summary>
	/// 枚举值: 专柜申请单状态枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum SpecialApplyStatusEnumData
	{
		/// <summary>
		/// 开立
		/// </summary>
		OpenL = 0,
		/// <summary>
		/// 审核中
		/// </summary>
		Approving = 1,
		/// <summary>
		/// 审核
		/// </summary>
		Approved = 2,
		/// <summary>
		/// 关闭
		/// </summary>
		Closed = 3,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{
	/// <summary>
	/// 枚举值: 广告核销单状态枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvAppStatusEnumData
	{
		/// <summary>
		/// 开立
		/// </summary>
		OpenL = 0,
		/// <summary>
		/// 审核中
		/// </summary>
		Approving = 1,
		/// <summary>
		/// 审核
		/// </summary>
		Approved = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE
{
	/// <summary>
	/// 枚举值: 广告单据对象枚举 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum AdvDocEnumData
	{
		/// <summary>
		/// 专柜申请单单据
		/// </summary>
		SpecialDoc = 0,
		/// <summary>
		/// 广告申请单单据
		/// </summary>
		AdvApplyDoc = 1,
		/// <summary>
		/// 广告核销单单据
		/// </summary>
		AdvApproveDoc = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

