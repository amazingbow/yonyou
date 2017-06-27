/**************************************************************
 * Description:
 * ShipSecondBQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.ShipSecondBQryUIModel
{
	public partial class ShipSecondBQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(ShipSecondBQryUIModelAction));
		//强类型化基类Model属性.
		public new ShipSecondBQryUIModelModel CurrentModel 
		{
			get {
				return (ShipSecondBQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public ShipSecondBQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public ShipSecondBQryUIModelAction(ShipSecondBQryUIModelModel model) : base(model)
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
         
            
        #region BE查询自动产生的代码
        
        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.SM.Ship.ShipLine", "c073f263-ff01-479a-b603-df48dc9bb7b0", UIGrid.UIView, UIGrid, 1);

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
            BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.SM.Ship.ShipLine", "c073f263-ff01-479a-b603-df48dc9bb7b0", UIGrid.UIView, UIGrid, 1);
            beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf+w3e/x7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf797LJ7u6Dyfbuzn62vf8ge7D98NPsYPv+5MFsev/e/b29nGAts0X+2Uev58XqdT6tljMG
9FE6K5pVmV2/GPg2b6Z1sWoZpY/SeV6u8JO/fXO9oleenGpT/vHVq7PPPpruPLh3vvfpve3z851d
wudhtj35dOfe9ux8/2A2fTiZPJjsaPvX1bqe5s/WZSkIfPXs7Onx+KuH49dfjIEM//O8WOYfpV+d
/WSRXz2tswvpGL89ra6WH6Wv8vOz5Xn1vMpm8tVJNp3nHx09fpI1xRRfMZny/U+nD6Y759t72eTT
7f2d2e72wcH92fbs/sNsL3v46XQnOzBk6tBlkBDU9Zvqbc6fvaqq9ik1O6mWbf6u/cmsXPOrz4qy
zes32eQni6aYlPTZm3pNAzqpyvVi2f/8dVW3/U8Fyum7VbacPc8v8/Kzj+4ZGN1PAaH72V0ix0ul
FJPj0/zT+w/vT4kcD/Z3tvfP7326PXnwKf2zd383zybT/Xxmuea25HhZVz+dT9uzp94fL7N2jj+f
vDxr84V89eTll6u8zvC6fPD0zZfmm+ML4uunZen9RZDeXeNvGsRXZ/4g9u7v707vHUy29z+d7ROr
HexuP5xO7m9Pd/cn+w92Zg92ptk3OYivzr6oZnlpRjL9dGf//sE+cfpkb297f29nsn2wTzjk2YN7
n2b392d7s1289KyqF+adbPdgur+zO9me7X2aExvu5duTyXm+nc8enH86ezCZPNw7dx3RC/d3sgf5
Xn5v+/79yb3t/cn5ve2De/cebM92snv5wUMac54xaZ7m59m6bE+yJlfeF6Zpgr+Ybvez6XQGESVM
iXjT+9Ptye7ePdIb04N8cv/h/mTnvqEbI04EH8sIOmT8L/6MP/s//1P/4LH8GKTp3T4Ku5/uPNzZ
PTjY3rt372B7f3/v4XaWT3e3iaSzh9Ns+umnn+a+1ho/WTekCJrmadbmHST+8z/y7/mv/ra/8j//
4//08X/2d/05//kf8xf/F3/mX/5f/Hl/4ftgc2+SHzx4MHmwPd3LSYcezA62Dx5kUyJyThrr3v4s
m30aYPNlPcvrJ10F6hD5r/6GvwS//Q1/yX/xR/2dmxC5G06UmUOWa/pbfhFevzd5OJtOicUm++fE
60Q14oPz7U8P7h0czLLd2b0sRPFpNX1RDSJI///P/8SNqHl9785oas6JKOfT3Qfb+/k5+p483P6U
lMXewX52735+/v6TdfM0eSicUx+f7h6cb0/zfRL16TnxSzadbU9m57ufHnz6YLbrZihg2RMSpGGm
vTUJHpznD0lh7m/v7O1R/+cPsu1sb/fe9qeTSfZw9+H92f7Emo+gf3QZ75/+/5//SX/8Ru7o8oP9
gIX8bugNHP2Gv8aPnh89P3p+9Pzo+dHzo+f/jc//Aw==";
            
            BeforeGetQryModel_Extend(beQryStrategyImpl);
            
            CaseModel caseModel = beQryStrategyImpl.GetQryModel();
            
            AfterGetQueryModel_Extend(caseModel);
            
            QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
        }
        
        
        #endregion
         


	}
}
