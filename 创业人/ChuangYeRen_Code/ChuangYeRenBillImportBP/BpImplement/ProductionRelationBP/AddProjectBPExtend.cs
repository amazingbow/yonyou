namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
using UFIDA.U9.CBO.Pub.Controller.Proxy;
using UFSoft.UBF.Business;
using UFIDA.U9.ISV.Project;
using UFIDA.U9.CBO.SCM.ProjectTask;
using UFIDA.U9.ISV.Project.Proxy;
using PublicDataTransObj;

	/// <summary>
	/// AddProjectBP partial 
	/// </summary>	
	public partial class AddProjectBP 
	{	
		internal BaseStrategy Select()
		{
			return new AddProjectBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
    internal partial class AddProjectBPImpementStrategy : BaseStrategy
    {
        public AddProjectBPImpementStrategy() { }

        public override object Do(object obj)
        {
            AddProjectBP bpObj = (AddProjectBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            long ProjectID = 0;
            Project P = Project.FindByCode(bpObj.Code);
            if (P == null)
            {
                #region 项目创建

                BatchCreateProjectByDTOSRVProxy createProxy = new BatchCreateProjectByDTOSRVProxy();
                createProxy.ProjectDTOs = new List<ProjectDTOData>();
                ProjectDTOData pDto = GetMoInfo(bpObj.Code, bpObj.FromOrg, bpObj.StartDate, bpObj.EndDate);
                try
                {
                    createProxy.ProjectDTOs.Add(pDto);
                    var data = createProxy.Do();
                    if (data.Count == 0) return pub;
                    if (data[0].ID == 0)
                    {
                        pub.Flag = false;
                        pub.Message = "项目创建失败！";
                    }
                    pub.Flag = true;
                    ProjectID = data[0].ID;
                    pub.DocID = data[0].ID;
                    pub.DocNo = data[0].Code;
                    pub.Message = "项目创建成功！";
                }
                catch (Exception ex)
                {
                    pub.Flag = false;
                    pub.Message = "项目创建失败：" + ex.Message;
                    return pub;
                }
                #endregion
            }
            else
            {
                pub.Flag = true;
            }
            CyrLibH.DB.RunSQL("update SCPO set ProjectID=c.id from SCPO a inner join SCPOMain b on a.SCPOMain=b.id inner join CBO_Project C on a.Code=c.Code and b.OrgID=c.Org where a.code like '"
                + pub.DocNo + "' and ProjectID=0");
            if (bpObj.ToOrg != 0)
            {
                Project Ps = Project.Finder.Find("Code='" + bpObj.Code + "' and MasterOrg is null");
                if (Ps.Org.ID == bpObj.FromOrg)
                    ProjectXiaFa(Ps.ID, bpObj.FromOrg, bpObj.ToOrg);
                else if (Ps.Org.ID == bpObj.ToOrg)
                    ProjectXiaFa(Ps.ID, bpObj.ToOrg, bpObj.FromOrg);
                else
                {
                    ProjectXiaFa(Ps.ID, Ps.Org.ID, bpObj.FromOrg);
                    ProjectXiaFa(Ps.ID, Ps.Org.ID, bpObj.ToOrg);
                }
            }
            return pub;

        }
        private ProjectDTOData GetMoInfo(string Code, long OrgID, DateTime BD, DateTime ED)
        {
            ProjectDTOData moDto = new ProjectDTOData();
            moDto.Code = Code;//项目号 
            moDto.Name = Code;
            moDto.ProjectType = 0;
            moDto.Org = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData { ID = OrgID };
            moDto.PlanTotalHours = 240;//工作时数
            moDto.State = 2;//状态
            moDto.StartDate = BD; //开工日期 
            moDto.EndDate = ED;  // 
            moDto.Effective = new UFIDA.U9.Base.PropertyTypes.EffectiveData();
            moDto.Effective.IsEffective = true;
            moDto.Effective.EffectiveDate = ED;
            moDto.Effective.DisableDate = ED.AddYears(100);
            return moDto;
        }
        private void ProjectXiaFa(long ProjectID, long FromOrg, long ToOrg)
        {
            #region 项目下发
            List<long> list = new List<long>();
            list.Add(ToOrg);
            new OnlineSendObjProxy
            {
                EntitySent = new BusinessEntity.EntityKey(ProjectID, "UFIDA.U9.CBO.SCM.ProjectTask.Project"),
                FromOrg = FromOrg,
                ToOrgList = list
            }.Do();

            #endregion

        }
    }
	#endregion
	
	
}