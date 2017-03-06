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
67y+hp2olpSjOPoNf40fPT96fvT86PnR87P7/D8=";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
