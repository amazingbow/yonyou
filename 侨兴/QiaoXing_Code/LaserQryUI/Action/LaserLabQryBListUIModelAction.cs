/**************************************************************
 * Description:
 * LaserLabQryBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.XMQX.LaserQryUI.LaserLabQryBListUIModel
{
	public partial class LaserLabQryBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabQryBListUIModelAction));
		//强类型化基类Model属性.
		public new LaserLabQryBListUIModelModel CurrentModel 
		{
			get {
				return (LaserLabQryBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public LaserLabQryBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public LaserLabQryBListUIModelAction(LaserLabQryBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab", "13037355-f941-4828-9745-7ffaa4aa22f4", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab", "13037355-f941-4828-9745-7ffaa4aa22f4", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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
Hz0/ev4/+vw/";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
