/**************************************************************
 * Description:
 * SOLineInfoDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SOLineInfoDQryUIModel
{
	public partial class SOLineInfoDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SOLineInfoDQryUIModelAction));
		//强类型化基类Model属性.
		public new SOLineInfoDQryUIModelModel CurrentModel 
		{
			get {
				return (SOLineInfoDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SOLineInfoDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SOLineInfoDQryUIModelAction(SOLineInfoDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTO",
                "908f1068-947e-4481-b608-e66b786c810b", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"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
/sj/4m/9q27Z5f7eXk4+xvn2p0jm7X96n7TPzqf0GwVuD3b2iD/3uubhxtXA//pP+4P+8z/tbxBZ
+P3/y7/lH/jP/56/Qn/cEimy1bTkSzK49ympY9LO5Mrm071tWuvepbV9cmZnXcV849JaDKn/6o/6
4//zP/wv/y//5r+X1NQtUXs4ezi9d/DwHnloDxHnwrLPdkiGiIMfPiAvbmen61vfvFo1jNt//gf9
fbdFbO8gv79zn+zYp0Bnj5a7J9N7u+RE7kzvPZwcTHc/tWsIG/Kz/+Xf9jf+V3/DX/yf/5F/z3/1
t/2V76VSJrRcd/CQFvpnOyTa+we7lHx8sPvpNuF1Tvp8f4+W8m+VfPQxeC/hnjzM9u9/ur+7Pdun
WJVyUlPSZw/OtylznU3O75/f38mzW6fv/qu/6Q/9L/70v+0//5P+hPdC4eH5w/v7U0JhukMGZT+f
QoDvzcixoSQQIbSb37fSdGOOzKJws3a92/Wu9G+40pqQYvweZPcpVwHuzYk/9ndns+2HZHG39+7l
9+7vUE5v90FX/713ZIjOJGd2/PokwE6xsciyT3/3J9Z5fX1SLVY0C8v26Df8NX70/Oj50fOj50fP
j54fPT96fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+dHz4+eHz0/ev4/8/w/";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTO",
                "908f1068-947e-4481-b608-e66b786c810b", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
