namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE;
    using UFIDA.U9.ISV.AR.Proxy;
    using UFIDA.U9.ISV.AR;
    using UFSoft.UBF.Business;

	/// <summary>
	/// ARBillDeleteBP partial 
	/// </summary>	
	public partial class ARBillDeleteBP 
	{	
		internal BaseStrategy Select()
		{
			return new ARBillDeleteBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ARBillDeleteBPImpementStrategy : BaseStrategy
	{
		public ARBillDeleteBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ARBillDeleteBP bpObj = (ARBillDeleteBP)obj;

            ARBillReturnDTO pub = new ARBillReturnDTO();
            pub.Flag = false;
            pub.Message = "";

            try
            {
                AdvApproveBE advApprove = AdvApproveBE.Finder.FindByID(bpObj.RelationId);
                if (advApprove != null)
                {
                    if (string.IsNullOrEmpty(advApprove.DescFlexField.PrivateDescSeg1) || string.IsNullOrEmpty(advApprove.DescFlexField.PrivateDescSeg2))
                    {
                        pub.Flag = true;
                        pub.Message = "没有生成对应的应收单，所以不需要删除！";
                    }
                    else
                    {
                        DeleteImportARBillSVProxy deleteProxy = new DeleteImportARBillSVProxy();
                        deleteProxy.ImportARBillQueryConditionDTOs = new List<ImportARBillQueryConditionDTOData>();
                        ImportARBillQueryConditionDTOData arBillDTO = new ImportARBillQueryConditionDTOData();
                        arBillDTO.DocNO = advApprove.DescFlexField.PrivateDescSeg2;
                        deleteProxy.ImportARBillQueryConditionDTOs.Add(arBillDTO);
                        deleteProxy.Do();
                        pub.Flag = true;
                        pub.Message = "删除对应应收单成功！";
                        //using (ISession session = Session.Open())
                        //{
                        //    advApprove.DescFlexField.PrivateDescSeg1 = "";
                        //    advApprove.DescFlexField.PrivateDescSeg2 = "";
                        //    session.Commit();
                        //}
                    }
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "删除对应应收单失败！失败信息：在广告核销单没有找到对应的单据：ID：" + bpObj.RelationId + "！";
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = "删除对应应收单失败！失败信息：" + ex.Message;
            }

            return pub;
		}		
	}

	#endregion
	
	
}