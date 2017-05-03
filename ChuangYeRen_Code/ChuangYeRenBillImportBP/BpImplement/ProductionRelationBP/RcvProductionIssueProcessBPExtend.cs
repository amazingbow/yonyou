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
    using UFIDA.U9.MO.Issue.Proxy;
    using UFIDA.U9.MO.MO;
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
            pubResult.Flag = false;
            CreateIssue4ExternalProxy createIssue = new CreateIssue4ExternalProxy();
            #region 创建领料单
            try
            {
                createIssue.IssueDTOs = GetIssueDoc(bpObj.RelationId, bpObj.ProductionId);
                var data = createIssue.Do();
                if (data.Count == 0) return pubResult;
                pubResult.DocID = data[0].ID;
                pubResult.DocNo = data[0].DocNo;
                pubResult.Message = "创建领料单成功！";
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message = "创建领料单失败：" + ex.Message;
                return pubResult;
            }
            #endregion
            #region 领料单提交
            try
            {
                BatchSubmitIssueTXNProxy submitIssue = new BatchSubmitIssueTXNProxy();
                submitIssue.IssueTXNs = new List<BatchOperationDTOData>();
                BatchOperationDTOData submintDto = new BatchOperationDTOData
                {
                    ID = pubResult.DocID,
                    DocNo = pubResult.DocNo
                };
                submitIssue.Do();
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message += "提交领料单失败：" + ex.Message;
                return pubResult;
            }
            #endregion
            #region 领料单审核
            try
            {
                ApproveIssueDoc4ExternalSrvProxy approveProxy = new ApproveIssueDoc4ExternalSrvProxy();
                approveProxy.DocNoList = new List<ApproveIssueDoc4ExternalDTOData>();
                ApproveIssueDoc4ExternalDTOData dto = new ApproveIssueDoc4ExternalDTOData
                {
                    DocNo = pubResult.DocNo
                };
                approveProxy.DocNoList.Add(dto);
                approveProxy.Do();
            }
            catch (Exception ex)
            {
                pubResult.Flag = false;
                pubResult.Message += "审核领料单失败：" + ex.Message;
                return pubResult;
            }


            #endregion
            return pubResult;
        }

        private List<IssueDTOData> GetIssueDoc(long relId, long productId)
        {
            List<IssueDTOData> issueLst = new List<IssueDTOData>();
            InvStock invStock = InvStock.Finder.FindByID(relId);
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
                ID = productId
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
                pickDto.IsNoPickLine = true;
                pickDto.IssueBin = new CommonArchiveDataDTOData
                {
                    Code = item.FLocator.Code
                };
                issueDto.PickListDTOs.Add(pickDto);
            }
            return issueLst;
        }
    }

    #endregion


}