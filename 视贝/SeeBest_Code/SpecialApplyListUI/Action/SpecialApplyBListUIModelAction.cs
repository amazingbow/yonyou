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
