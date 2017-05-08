/**************************************************************
 * Description:
 * HxRelationshipBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.HeXingRelationshipListUI.HxRelationshipBListUIModel
{
	public partial class HxRelationshipBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(HxRelationshipBListUIModelAction));
		//强类型化基类Model属性.
		public new HxRelationshipBListUIModelModel CurrentModel 
		{
			get {
				return (HxRelationshipBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public HxRelationshipBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public HxRelationshipBListUIModelAction(HxRelationshipBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", "b831d336-4857-43f2-aba0-78974da27eab", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", "b831d336-4857-43f2-aba0-78974da27eab", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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
en70/Oj50fOj50fP//ef/wc=";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
