namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base.FlexField.ValueSet;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetValueSetInfo partial 
	/// </summary>	
	public partial class GetValueSetInfo 
	{	
		internal BaseStrategy Select()
		{
			return new GetValueSetInfoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetValueSetInfoImpementStrategy : BaseStrategy
	{
		public GetValueSetInfoImpementStrategy() { }

		public override object Do(object obj)
		{
            GetValueSetInfo bpObj = (GetValueSetInfo)obj;
            List<ReturnValueSetDef> returnList = new List<ReturnValueSetDef>();
            ValueSetDef value = ValueSetDef.FindByCode(bpObj.ValueCode);
            DefineValue.EntityList define = DefineValue.Finder.FindAll("ValueSetDef=" + value.ID);
            foreach (var item in define)
            {
                ReturnValueSetDef returnValue = new ReturnValueSetDef { Code = item.Code, Name = item.Name, Description = item.Description };
                returnList.Add(returnValue);
            }
            return returnList;
		}		
	}

	#endregion
	
	
}