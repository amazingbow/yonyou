using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
	/// <summary>
	/// 枚举值: 对照类型 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum RelationEnumData
	{
		/// <summary>
		/// 币种
		/// </summary>
		Currency = 1,
		/// <summary>
		/// 客户
		/// </summary>
		Customer = 2,
		/// <summary>
		/// 供应商
		/// </summary>
		Supplier = 3,
		/// <summary>
		/// 部门
		/// </summary>
		Dept = 4,
		/// <summary>
		/// 员工
		/// </summary>
		Staff = 5,
		/// <summary>
		/// 现金流
		/// </summary>
		Cash = 6,
		/// <summary>
		/// 组织
		/// </summary>
		Org = 7,
		/// <summary>
		/// 凭证类型
		/// </summary>
		VoucherCategory = 8,
		/// <summary>
		/// 项目
		/// </summary>
		Project = 9,
		/// <summary>
		/// 科目
		/// </summary>
		Account = 10,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

