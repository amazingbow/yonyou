namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;
    using UFIDA.U9.ISV.GL.ISVGLImportSV;
    using UFIDA.U9.ISV.GL.ISVGLImportSV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// CreateVoucherfromSAP partial 
    /// </summary>	
    public partial class CreateVoucherfromSAP
    {
        internal BaseStrategy Select()
        {
            return new CreateVoucherfromSAPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateVoucherfromSAPImpementStrategy : BaseStrategy
    {
        public CreateVoucherfromSAPImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateVoucherfromSAP bpObj = (CreateVoucherfromSAP)obj;
            var glVoucherLst = HeXingSAPU9GLVoucherHead.Finder.FindAll("IsU9Successful='0'");
            if (glVoucherLst.Count == 0) return null;//表中没有要处理的数据。

            foreach (var item in glVoucherLst)
            {
                if (item.HeXingSAPU9GLVoucherLine.Count == 0) continue;
                HxRelationshipBE.Finder.FindAll("SapCode=" + item.CompanyCode + " and SapName=" + item.CompanyName);

                using (ISession session = Session.Open())
                {
                    try
                    {
                        //item.CompanyCode
                        ISVGLImportSVProxy proxy = new ISVGLImportSVProxy
                        {
                            ImportVoucherDTOs = new List<ISVImportVoucherDTOData>(),
                            TargetOrgCode = Context.LoginOrg.Code,//是否要用用户传输的公司和名称？
                            TargetOrgName = Context.LoginOrg.Name
                        };
                        item.IsU9Successful = "1";
                    }
                    catch (Exception ex)
                    {
                        item.U9ErrorResult = ex.Message;
                        item.IsU9Successful = "2";
                    }
                    session.Commit();
                }
            }
            return null;
        }
    }

    #endregion


}