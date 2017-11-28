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
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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
+dHzo+dHz4+eHz3/33z+Hw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
