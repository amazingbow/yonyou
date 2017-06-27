/**************************************************************
 * Description:
 * RcvLineDQryUIModelAction.cs
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

namespace UIFIA.U9.Cust.FJGX.RcvLineDQryUIModel
{
	public partial class RcvLineDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(RcvLineDQryUIModelAction));
		//强类型化基类Model属性.
		public new RcvLineDQryUIModelModel CurrentModel 
		{
			get {
				return (RcvLineDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public RcvLineDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public RcvLineDQryUIModelAction(RcvLineDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO",
                "6f91448c-7e21-47bd-8994-e133e49161b4", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"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
N9jz6e7up/f2tnfBs0RfWuTao0X3LCO3Autb5/ftgoKGNJGxSsfvN1YKNx8+3L9PASaWWKd7e9sH
ezSxD2dTWuvf35t++tDGm8+rNqIc/os/+u++vTKa7k92iIAkJTswPg8Odrcnu3skr+f7n04e8LK8
TW5tDKswyL/3tr3ep0Xp/NMH9ykvTqE0BSOU39ihhRta/p/uPXj4YPJw/7bByH/9R/7J//Vf8uff
tt/Zg4P93fxg+/6DT0nX71ByZXKfNPGn90gFPniQZV4iKuYz/hd//F/yX/4Nf+Z/+Sf8kbfsb3dK
y+8zGufD6R71R4kbSh7sUC7hPi1WZQ/39u/ds5M54H79Z3/v30GMe8v+DrIHtH5DHUyy+9Rffn5O
wkqBCn28vzslV/DeuaXrB5lXr8+d/U9J2e3e387PD0DTffLDJ/d2t6cUou/RICeTPSspX+SLLkn/
87/sj/wv/ta/alNfd7vGW/9+XdUt/YUfgsgsy0nfzrbvPfyU9BMs7MH9h+TRHOw/oMD3fCeb2sEP
GfJBPNCL+JzHr08CtBQNiyU7m3d/Yp3X1yfVYlUtyTk++g1/jR89P3p+9Pzo+dHzo+dHz4+eHz0/
en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3fP/wM=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO",
                "6f91448c-7e21-47bd-8994-e133e49161b4", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UIFIA.U9.Cust.FJGX.RcvLineQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UIFIA.U9.Cust.FJGX.RcvLineQryBP.Proxy.QueryBPProxy proxy = new UIFIA.U9.Cust.FJGX.RcvLineQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
