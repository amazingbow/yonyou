using System;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.CBO.SCM.ProjectTask;
using UFIDA.U9.ISV.Project;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.Business;
using UFSoft.UBF.Util.Context;

namespace UFIDA.U9.Cust.FJGX.SM.PlugBE.Common
{
    /// <summary>
    /// 项目实体相关的通用方法
    /// </summary>
    public static class ProjectHelper
    {
        #region 创建项目号

        /// <summary>
        /// 创建项目号（调用标准ISV）
        /// </summary>
        /// <param name="project_Code">项目编码</param>
        /// <returns></returns>
        public static Project CreateProject(string project_Code)
        {
            UFIDA.U9.ISV.Project.Proxy.BatchCreateProjectByDTOSRVProxy proxy = new UFIDA.U9.ISV.Project.Proxy.BatchCreateProjectByDTOSRVProxy();
            List<ProjectDTOData> projDtoList = new List<ProjectDTOData>();
            ProjectDTOData projectDto = new ProjectDTOData();
            projectDto.Code = project_Code;
            projectDto.Name = project_Code;
            projDtoList.Add(projectDto);
            proxy.ProjectDTOs = projDtoList;
            //组织
            proxy.TargetOrgCode = PlatformContext.Current.OrgCode;
            proxy.TargetOrgName = PlatformContext.Current.OrgName;

            List<UFIDA.U9.CBO.SCM.ProjectTask.ProjectData> projList = proxy.Do();
            if (projList == null || projList.Count < 1)
            {
                throw new Exception("创建项目失败!");
            }

            Project project = Project.Finder.FindByID(projList[0].ID);
            return project;
        }


        /// <summary>
        /// 获取现有的项目号档案
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Project GetProjectByCode(string code)
        {
            Project project = Project.Finder.FindByBusinessKey(code,Base.Context.LoginOrg);
            return project;
        }
    
        /// <summary>
        /// 获取项目编码
        /// 规则：
        /// 1、docLineCount= -1作为主件直接返回销售订单号
        /// 2、其他为配件的按顺序号取销售订单号+标识符号
        /// </summary>
        /// <param name="docNo">销售订单号</param>
        /// <param name="docLineCount">单据行数，从-1开始，8结束</param>
        /// <returns></returns>
        public static string GetProjectCode(string docNo, int docLineCount)
        {
            //定义字符数组：整单最多10行，因此配件标识符最大到I，超过的报错
            string[] s = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            //string[] s = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            if (docLineCount > 8 || docLineCount < -1)
            {
                throw new Exception("获取项目号编码出错：销售订单行不能超过10行");
            }

            if (docLineCount == -1)
            {
                return docNo;
            }
            else
            {
                return docNo + s[docLineCount];
            }
        }


        #endregion

        #region 删除项目档

        public static void DeleteProject(UFIDA.U9.SM.SO.SO holder)
        {
            UFIDA.U9.ISV.Project.Proxy.BatchDelProjectByDTOSRVProxy proxy = new UFIDA.U9.ISV.Project.Proxy.BatchDelProjectByDTOSRVProxy();

            List<UFIDA.U9.ISV.Project.QueryProjectDTOData> projDtoList = new List<UFIDA.U9.ISV.Project.QueryProjectDTOData>();

            //当前销售订单对应的项目档
            UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityList productList = Project.Finder.FindAll("Code like '" + holder.DocNo + "%'");
            if (productList == null) return;

            foreach (Project proj in productList)
            {
                UFIDA.U9.ISV.Project.QueryProjectDTOData projDot = new UFIDA.U9.ISV.Project.QueryProjectDTOData();
                projDot.ID = proj.ID;
                projDot.Code = proj.Code;

                projDtoList.Add(projDot);
            }

            proxy.ProjectDTOs = projDtoList;

            //组织
            proxy.TargetOrgCode = PlatformContext.Current.OrgCode;
            proxy.TargetOrgName = PlatformContext.Current.OrgName;

            proxy.Do();

        }

        #endregion
    }
}
