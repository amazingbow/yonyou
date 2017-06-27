/**************************************************************
 * Description:
 * AchievementDetailDQryUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.ExportService;

namespace UFIDA.U9.Cust.FJGX.AchievementDetailDQryUIModel
{
	public partial class AchievementDetailDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AchievementDetailDQryUIModelAction));
		//强类型化基类Model属性.
		public new AchievementDetailDQryUIModelModel CurrentModel 
		{
			get {
				return (AchievementDetailDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AchievementDetailDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AchievementDetailDQryUIModelAction(AchievementDetailDQryUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnLookCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnLookCase_Extend);
		}
		private void OnLookCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:QryClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnCaseChanged(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnCaseChanged_Extend);
		}
		private void OnCaseChanged_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	        QryService.OnCaseChangedDefault("DDLCase", this.CurrentPart);
		QueryAdjust();
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOutPut(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOutPut_Extend);
		}
		private void OnOutPut_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  
		      DTOQueryPrintOut(sender, e);
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnOutPut
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnOutPut",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnGridRowDbClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnGridRowDbClick_Extend);
		}
		private void OnGridRowDbClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnNew(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnNew_Extend);
		}
		private void OnNew_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrint(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrint_Extend);
		}
		private void OnPrint_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		      DTOQueryPrintOut(sender, e);
		  	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnPrint
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnDelete(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnDelete_Extend);
		}
		private void OnDelete_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListDeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListDeleteClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void btnSaveCurrentQueryCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.btnSaveCurrentQueryCase_Extend);
		}
		private void btnSaveCurrentQueryCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 

		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{
		   				}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion
         
        #region DTO查询自动产生的代码
        public void InitCaseModel()
        {
            QryService.ClearSession((BaseWebForm)this.CurrentPart);
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.AchievementDetailQryDTO",
                "8721a8f8-d2e9-4bde-a572-3bcb69e4c700", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"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
fvT86PnR86Pn/23P/wM=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.AchievementDetailQryDTO",
                "8721a8f8-d2e9-4bde-a572-3bcb69e4c700", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.Proxy.QueryBPProxy(), "QryInParameter");
            action.FilterOpath = CustomFilterOpath_Extend();
            UIGrid.UIView.Clear();
            action.LoadFirstPage();

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
        }


	private void DTOQueryPrintOut(object sender, UIActionEventArgs e)
        {
            string FilterOpath = CustomFilterOpath_Extend();
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
            UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
