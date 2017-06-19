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
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf/L3ePx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22UfT/fsHDx5+erA9mzz8dHv/wf372wf38/vb+7OdyWw3P5hNs/2P0mW2yD/76Hh2ebxaldc/
UV9/lM6KZlVm1y8i3+TNtC5WLaPyUTrPyxV+cudvrlfU/HnRtPrBV6/OPvtodn9vL/80n25PZ9Pp
9v7++f3tbH+yvz3bfXCw82A2mWT7M23/ulrX0/zZuiyl56+enT09Hn/1cHyybtrx6zx/kjctoZPX
bdHkCxrmk9Nx8DcjKh/qrx+lX539ZJFfPa2zC0EQvz2trpYfpa/y87PlefW8ymby1Uk2necfHT1+
kjXFFF8JGSd7s0/vHexv35vOciLjpzvbDw/2drfv3//04W5+78HkwfnMkLFDu0GCUddvqrc5f/aq
qtqn1OykWrb5u/Yns3LNrz4ryjav32STnyyaYlLSZ2/qdf5RelKV68Wy//nrqm77nwqU03erbDl7
nl/m5Wcf3TMwup8CQvezu0SOl0opJsfDT3fuZQ93d7an+eTh9n62M9vOJnm2vfvgwc7DbC9/mE/2
3pccL+vqp/Npe/bU++Nl1s7x55OXZ22+kK+evPxyldcZXpcPnr750nxzfEEM8LQsvb8I0rtr/E2D
+OrMH8T93dn9/f392fbDh9MHJBCze/Tb/b3te/cmWbY7y+m7T7/JQXx19kU1y0szkv2DbHpwPpls
57s7RMP9SbZ9cE4sdf7g0/OD/Wz3/vn9HC89q+qFeWdvbzaZQpAm2UG2vX//0wdE9/sH2/nOfZqD
T6f7u9kD1xG9QNOTTXb2aHj39+kFjHayt3uwfW92/97edLJzj2aKSSMs8jQ/L5Z5E/7JxHqwcz8/
yLP97Z1sjwDt7Z1vTyYPJtu7B/cI0KckBg8eenrkhBDo6xD9dIB0WU3TZeh7XBZZ47101jwr3uWE
yLOsbPjv47Ksrp6U2fKtYfMO10OenhV5OYsL1QuCKyIP6lLzrM2fCsLyMUllRjrlZJ4tL/LZ6SVh
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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
