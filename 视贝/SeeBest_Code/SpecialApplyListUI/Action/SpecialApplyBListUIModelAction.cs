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
/LxY5k34JxMre3h+b7JPApAf7E+39+/PJtvZ7OB8e5rf2915eG96PpncM8Qi4TwhBDo0c58OkC6r
aboMfY/LImu8l86aZ8W7nBB5lpUN/31cltXVkzJbvjVs3uF6yNOzIi9ncaF6QXBF5EFdap61+VNB
WD4mqcxIw5zMs+VFPju9JOy87p+si3L23Xle56/b2nQpnFnVUH/Kcz1KkqaYzvaz3e17OaZk596n
JDvns+175/dnDz89+JSEybIdK7Cn+art0tL7/H2o6V77/yQ9jx6T/FKL5VRI+els7/zeg/wBKeSM
RCg72NmeHBApSUpmO3ufPvyUyPm+EgwNQYJDsjGd7k4+3T4/2KdZOviUDCfNEP05nWZ7u+f5br7D
jdm8fZT+Xvk10wa/M2H0L+HeN0Qu/QDd48V2XS/7Db3PhWhEDLL0H6XP83Oo5TpvxBGwUzk2L55/
t5hB0dw/EMS+nRcXc6La/s4BM+JdnxNjfDl5SBr9wc72NJuR0/Bg+pDU4b2H259mu3vTvZ296fnu
rs+XRV5HuFI+fU+e5Jf+P8mRUQk/OP90J3swe7D9cG9KbLk/zbcfPth7sL07+/TT/GFOOvrA6Uqe
R0IsKuHy+XtSU1/7OaAnPnhTMH//bNA1//Tg3oPZ9P72w4fZ/e39T+/tkUe7e7B9TmZsd+fB7OHu
fUvXl3PyhDs0NZ+9Bz31lZ8DWv4s0XAn29/dJ1Hfnt1/SHptSiZo8mn2YPvTT7OHu5Pz3ezep9b6
/MRPdAjIH7wH9dD+/z+km2Xn94nTpttkWcjpvUduFCnIbPvg00/vTfbu7X669+meIR1iFca+Fn0f
kLH35XuQtPvu/3/ISw7mg/39+7tkwskl2t/Z39t+OJvuE7V392GA8vvnNl4FFQYI+/VI+v83Yj7Y
JY9o99Od7U8n98k9erA3IzYlWb93ns3uzWbn00/PrWeE8cfUpf/5e5Lz/3dqMzuY3HtAwf72g919
kv3Zpw+3yWfPtx9k2afZ/U8PHk5nOz49j2czuGoRirpv3pOm9sX//1B1dv4pRa/wr3NSq/ufTne3
Dx4+JL9pcv98f3Iwm+S7k06KikZSXCxft9dll12jDd6DxrH3//9D6nuzbErEvk92/x75TjkphCzP
6c/ZJHs4uzf59OC+ywa2Wbvu8q798H1Iqu/8/4eMD/O9bJrtkgs6Oac8YH6+u509ONjfzrLp7t7e
fWLae5aMZ81JWaG/gI7u0/cgpH3p/z+U3D9/QLk3ykw92N19AEoebD+ckkt18DCbkBK4v0fp4Y7s
vy5+kFNyV7Gj7NpsPW2BZFwTbGr+HrQPoP3+MWj/n5yUbi7l/OH5zpQ83O3dXYT/+wcUtO5R/uPT
+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
+dHzo+dHz//3n/8H";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
