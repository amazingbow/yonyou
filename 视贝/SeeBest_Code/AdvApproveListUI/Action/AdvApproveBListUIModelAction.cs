/**************************************************************
 * Description:
 * AdvApproveBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.AdvApproveBListUIModel
{
	public partial class AdvApproveBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApproveBListUIModelAction));
		//强类型化基类Model属性.
		public new AdvApproveBListUIModelModel CurrentModel 
		{
			get {
				return (AdvApproveBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AdvApproveBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AdvApproveBListUIModelAction(AdvApproveBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", "5e7ff1a5-d073-45f0-a5ef-9b9f89c5531a", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", "5e7ff1a5-d073-45f0-a5ef-9b9f89c5531a", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
