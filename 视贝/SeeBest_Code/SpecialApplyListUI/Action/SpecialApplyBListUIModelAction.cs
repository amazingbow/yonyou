/**************************************************************
 * Description:
 * SpecialApplyBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.SpecialApplyListUI.SpecialApplyBListUIModel
{
	public partial class SpecialApplyBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecialApplyBListUIModelAction));
		//强类型化基类Model属性.
		public new SpecialApplyBListUIModelModel CurrentModel 
		{
			get {
				return (SpecialApplyBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SpecialApplyBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SpecialApplyBListUIModelAction(SpecialApplyBListUIModelModel model) : base(model)
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
		   
		     InitCaseModel();
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
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", "a6e804b7-7d16-4c3b-aa42-ea8a40327629", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", "a6e804b7-7d16-4c3b-aa42-ea8a40327629", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
