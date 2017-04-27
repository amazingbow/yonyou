namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using InvStockBE;
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.ISV.MO;
    using UFIDA.U9.ISV.MO.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// RcvProductionIssueProcessBP partial 
    /// </summary>	
    public partial class RcvProductionIssueProcessBP
    {
        internal BaseStrategy Select()
        {
            return new RcvProductionIssueProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class RcvProductionIssueProcessBPImpementStrategy : BaseStrategy
    {
        public RcvProductionIssueProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            RcvProductionIssueProcessBP bpObj = (RcvProductionIssueProcessBP)obj;
            PublicReturnDTO pubResult = new PublicReturnDTO();
            CreateIssue4ExternalProxy createIssue = new CreateIssue4ExternalProxy();
            try
            {
                createIssue.IssueDTOs = GetIssueDoc(bpObj.RelationId);
                createIssue.Do();
            }
            catch (Exception ex)
            {

                throw;
            }
            return pubResult;
        }

        private List<IssueDTOData> GetIssueDoc(long id)
        {
            List<IssueDTOData> issueLst = new List<IssueDTOData>();
            InvStock invStock = InvStock.Finder.FindByID(id);
            IssueDTOData issueDto = new IssueDTOData
            {
                BusinessCreatedOn = DateTime.Now,
                BusinessDate = DateTime.Now,
                BusinessType = 0,
                Dept = new CommonArchiveDataDTOData
                {
                    Code = invStock.DeptID.Code,
                    Name = invStock.DeptID.Name
                },
                DocNo = invStock.BillNO,
                DocType = new CommonArchiveDataDTOData
                {
                    Code = "",
                    Name = ""
                },
                Employee = new CommonArchiveDataDTOData
                {
                    Code = "",
                    Name = ""
                },//发料人
                //IsSpecialIssuek
                IssueOrg = new CommonArchiveDataDTOData
                {
                    Code = "",
                    Name = ""
                },
                //IssueType=0
                Memo = ""
            };
            issueDto.MOs = new List<CommonArchiveDataDTOData>();
            CommonArchiveDataDTOData mo = new CommonArchiveDataDTOData
            {
                ID = 0
            };
            issueDto.MOs.Add(mo);
            issueDto.PickListDTOs = new List<PickListDTOData>();
            issueLst.Add(issueDto);
            foreach (var item in invStock.InvStocks)
            {
                PickListDTOData pickDto = new PickListDTOData();
                pickDto.Item = new CommonArchiveDataDTOData
                {
                    Code = item.ItemID.Code
                };
                pickDto.IssueWh = new CommonArchiveDataDTOData
                {
                    Code = item.StockID.Code
                };
                pickDto.IssueQty = item.OutQty;
                pickDto.Project = new CommonArchiveDataDTOData
                {
                    Code = item.SCPO.Code
                };
                pickDto.IssueUOM = new CommonArchiveDataDTOData
                {
                    Code = item.ItemID.UOM.Code
                };
                pickDto.OwnerOrg = new CommonArchiveDataDTOData
                {
                    Code = Context.LoginOrg.Code
                };
            }
            return issueLst;
        }
    }

    #endregion


}