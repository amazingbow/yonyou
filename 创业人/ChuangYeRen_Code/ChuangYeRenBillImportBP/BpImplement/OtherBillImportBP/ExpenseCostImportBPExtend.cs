namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.OtherBillImportBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CA.CalculateCost;
    using UFIDA.U9.CA.CalculateCost.Proxy;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.PL.Engine;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ExpenseCostImportBP partial 
	/// </summary>	
	public partial class ExpenseCostImportBP 
	{	
		internal BaseStrategy Select()
		{
			return new ExpenseCostImportBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ExpenseCostImportBPImpementStrategy : BaseStrategy
	{
		public ExpenseCostImportBPImpementStrategy() { }

		public override object Do(object obj)
		{			
			ExpenseCostImportBP bpObj = (ExpenseCostImportBP)obj;
            CreateExpenseCostSVProxy createProxy = new CreateExpenseCostSVProxy();           
            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";
            createProxy.CreateExpenseCostDTOList = new List<CreateExpenseCostDTOData>();          
            try
            {
                CreateExpenseCostDTOData headDto = getInfo(bpObj.ID);
                createProxy.CreateExpenseCostDTOList.Add(headDto);
                var data = createProxy.Do();
                //if (data.Count == 0) return pub;
                //pub.DocID = data[0].ID;
                //pub.DocNo = data[0].DocNo;

            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = ex.Message;
                throw new Exception(ex.Message);
            }

            return pub;
		}
        private CreateExpenseCostDTOData getInfo(long stockID)
        {
            CreateExpenseCostDTOData headDto = new CreateExpenseCostDTOData();
            headDto.Cost = new CBO.MFG.CO.CostData //成本费用数据导入
            {
                CurrentCost = 123123,
                PriorCost = 1,
            };
            headDto.SOB_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey();  //账套公司
            headDto.SOB_SKey.ID = 1001505040001428;
            headDto.EAG_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey();  //费用分配组
            headDto.EAG_SKey.ID = 1001509300033642;
            headDto.ItemMaster_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(); //料品
            headDto.ItemMaster_SKey.ID = 0L;
            headDto.ItemMasterQty = 0; //数量
            headDto.SOBPeriod_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(); //期间
            headDto.SOBPeriod_SKey.ID = 1001508190001335;
        
            headDto.CostField_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey //成本域
            {
                ID = 1001505200080894,
            };
            headDto.CostType_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey //成本类型
            {
                ID = 1001506240003277,
            };
            headDto.Department_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey  //部门
            {
                ID = 1001506250000065,
            };
            headDto.Memo = "测试"; //备注
            headDto.PLS = 0L;
            headDto.SysState = ObjectState.Inserted;
            return headDto;
        }
	}

	#endregion
	
	
}