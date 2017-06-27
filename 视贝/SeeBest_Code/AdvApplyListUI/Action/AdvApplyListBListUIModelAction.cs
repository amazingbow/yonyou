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
