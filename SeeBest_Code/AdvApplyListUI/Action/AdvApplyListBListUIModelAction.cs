/**************************************************************
 * Description:
 * AdvApplyListBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.AdvApplyListBListUIModel
{
	public partial class AdvApplyListBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApplyListBListUIModelAction));
		//强类型化基类Model属性.
		public new AdvApplyListBListUIModelModel CurrentModel 
		{
			get {
				return (AdvApplyListBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AdvApplyListBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AdvApplyListBListUIModelAction(AdvApplyListBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "d522e6ec-cdcc-44f5-a4b4-d17807dbba4d", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "d522e6ec-cdcc-44f5-a4b4-d17807dbba4d", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
