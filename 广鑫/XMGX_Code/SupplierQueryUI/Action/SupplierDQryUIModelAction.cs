/**************************************************************
 * Description:
 * SupplierDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SupplierDQryUIModel
{
	public partial class SupplierDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SupplierDQryUIModelAction));
		//强类型化基类Model属性.
		public new SupplierDQryUIModelModel CurrentModel 
		{
			get {
				return (SupplierDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SupplierDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SupplierDQryUIModelAction(SupplierDQryUIModelModel model) : base(model)
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
		/// <summary>
		/// Help: 
		/// </summary>
		public void BtnShowSupplierDocLine(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.BtnShowSupplierDocLine_Extend);
		}
		private void BtnShowSupplierDocLine_DefaultImpl(object sender, UIActionEventArgs e)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierQryBP.SupplierQryDTO",
                "792096f9-2995-4223-8fe9-5fba15b80ae6", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"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
KXvKd8N1xaPf8Nf40fOj50fPN//8Pw==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierQryBP.SupplierQryDTO",
                "792096f9-2995-4223-8fe9-5fba15b80ae6", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SupplierQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SupplierQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SupplierQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
