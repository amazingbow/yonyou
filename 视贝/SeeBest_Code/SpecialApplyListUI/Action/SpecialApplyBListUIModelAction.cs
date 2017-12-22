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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", "0db980b2-3d58-473b-b7e8-40e32dee79a3", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", "0db980b2-3d58-473b-b7e8-40e32dee79a3", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv/iP+TUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mH320af3H9x/eJ7tbO9PHxxs78/uTbcPzh9Otyez+7t7O9Ppg52HBx+ly2yRf/bR61U+LbLy
eLUqr3+ivv4onRXNqsyuXwx8mzfTuli1jNJH6TwvV/jJSLy5XtErz4um1Q++enX22Uc7s8nDg53J
3va92X1C5sG9yfbkQU6/7eT39mZ5/uBhdk/bv67W9TR/ti5L6f2rZ2dPj8dfPRyfrJt2/DrPn+RN
ezwjkrRFky9ouE9Oxz6KvT8/Sr86+8kiv3paZxeCHn57Wl0tP0pf5edny/PqeZXN5KuTbDrPPzp6
/CRriim+YmJO8geTe9lstj2b7OTb+wcH97ezg+l0+8H+g0n+6eTe5OG9B4aYHeoNkou6flO9zfmz
V1XVPqVmJ9Wyzd+1P5mVa371WVG2ef0mm/xk0RSTkj57U6/zj9KTqlwvlv3PX1d12/9UoJy+W2XL
2fP8Mi8/++iegdH9FBC6n90lcrxUSjE57t/PD86n2WQ73909397PaWKzyb1725/uPPh0/97B7v7k
/uR9yfGyrn46n7ZnT70/XmbtHH8+eXnW5gv56snLL1d5neF1+eDpmy/NN8cXxA5Py9L7iyC9u8bf
NIivzvxBTB9Ozu89fDjZnu5m+9v75+f72w+zbG97sjs7uJ9NZwcP9x5+k4P46uyLapaXZiT37u89
PDh48IBE4h7k82B/++Dg0/vb0+nD6b18b5LfO7iPl55V9cK8c396/97ep4Tjp/mne9v79z7Nt7P9
T2fb070Hu/n5w537985z1xG9MJ3MsgcP9va3d/d2aYy70wfbWf4w276/+/DTBwcP9vcIASaNsMjT
/LxY5k34JxMrv7+7/+lePgGM+yTA5/eJWPnD7QfZw4MHs92H93Ye7BpikXCeEAIdmrlPB0iX1TRd
hr7HZZE13ktnzbPiXU6IPMvKhv8+Lsvq6kmZLd8aNu9wPeTpWZGXs7hQvSC4IvKgLjXP2vypICwf
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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
