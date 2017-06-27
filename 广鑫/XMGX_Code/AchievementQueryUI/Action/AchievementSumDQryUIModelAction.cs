/**************************************************************
 * Description:
 * AchievementSumDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.AchievementSumDQryUIModel
{
	public partial class AchievementSumDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AchievementSumDQryUIModelAction));
		//强类型化基类Model属性.
		public new AchievementSumDQryUIModelModel CurrentModel 
		{
			get {
				return (AchievementSumDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AchievementSumDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AchievementSumDQryUIModelAction(AchievementSumDQryUIModelModel model) : base(model)
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
	  
		  
		      DTOQueryPrintOut(sender, e);
	  
	 
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
	  
		      DTOQueryPrintOut(sender, e);
		  	  
	 
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
		/// <summary>
		/// Help: 
		/// </summary>
		public void btnSaveCurrentQueryCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.btnSaveCurrentQueryCase_Extend);
		}
		private void btnSaveCurrentQueryCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 

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
         
        #region DTO查询自动产生的代码
        public void InitCaseModel()
        {
            QryService.ClearSession((BaseWebForm)this.CurrentPart);
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.AchievementSumQryBP.AchievementSumQryDTO",
                "ad67c24b-c274-4cc2-b4f8-4954741d3961", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP+x3f/x7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf5wfn9+59ODrYf3t95sL1/79Pp9sHBw0+3Z/ez2c7B/vn9/YP9j9Jltsg/++h4Oi/yy3xB
7zKkj9JZ0azK7PrF0Nd5M62LVctIfZTO83KFn/ztm+sVvfP0zZfaln989erss4+y2acPpnv7k+3p
3oP97f3pdG97sn9+sL3/8P7+g/3d2b2Hn+5q+9fVup7mz9ZlKSh89ezs6fH4q4fjk3XTjp995/Pf
e+xh9Xq9+In6+snL/meExkfpV2c/WeRXT+vsQnGj375afZS+ys/PlufV8yqbyRcn2XSef3T0+EnW
FFN8xZTc33+YzWaz3e3793cI7U9n+XaWTbLtfHKene/f2zkn3A0lO5QbpBR1/aZ6m/Nnr6qqfUrN
Tqplm79rfzIr1/zqs6Js8/pNNvnJoikmJX32pl7nH6UnVbleLPufv67qtv+pQDl9t8qWs+dEm/Kz
j+4ZGN1PAaH72V0ix0ullDDW5P7O9GCWbU93z+9t7+/sfrp9cO/Bp9t7s4dZvr9772B3lkcYi+Zj
mK3kyzipXtbVT+fT9uyp98fLrJ3jzycvz9p8ga9m9/L9+7MH2XY2zYijPt3b336YT/LtfLZ/f3pv
Op3m98/R/stVXmfoAi/d+3R373x2nm/vnp/vEUPuf7qdfXr+cPvewezh+fn5p/cePCAKEA+h8afn
GY3zwQ5N/kPqYXdntp2d757Tuw/uzSazbO/++QF6OL6gAT0ty5uYlvkcPIv29kUa4LvrW/M7tx4r
JP6DJ+yrM3/CJnuf7jw42H+wfe/h3sPt/f0s257sYP7272cPc/r/7t578++mSfnq7ItqlpdmZj6d
nT94MJk+2N4536Xus0+p+938If0z25s+nE12PgW/fHX2rKoX5p2De+fnB/TS9v7efaL1hJTEwYMH
B6Q4dnemO5/S75/uu47ohQc7BG1/Otk+P9ilt/Ynu9s0JfdIv0yms73ZZDKBaiHSiDg8zc+LZd6E
fwqxZueTh/cODraz3fvn2/v3zz/dfrhHKM/2Ht7by2f3z/fPdwyxnqwbQGmeZm3eIVznqwEiZjVN
pqH0cVlkTffNs+ZZ8S4nvJ5lZcN/H5dldfWkzJZvjYR3BB6q5FmRl7O4PnlBJBNtB2JTc+rnqaCu
2pE7fpUVTX4yz5YX+ez0ktD0UHiyLsrZd+d5nb9ua9OtCFZVPy8aanv6i9ZZOXpRtfLL53WeQZcR
vNFzGhz/4n0orcw38teTvL3K8yXP2t3OtIn6iv7Js7g7292d7h/Mts/z3fs0i/t72wd79Nu9+3u7
9+5/ur+7//BTM4uv8umbqs3KL8h2di1f97v3mMfOq92JvO2k/VReV2fN6WLVXtt3e1MGEcynBXwE
+eB1Szpu+lH6Yr3I62Kq1m1dE55TQuZlVWBC95i2PeLtZPlktneQbT/49FPSiucPHm5n97OdbRKD
XZLc/fPdB1ZfHL8apF3nq/cgXfjm/5cod3CfDESebx/sZuRz7c0ebGcz+o1Y7+FsZ/Zg72GWWeWR
Td/yCF/BHHXVR/fL96Be993/F9DvZU7OHIyckm8/Tr7Zwd7sHtmn7d0HD/ZAvt1t8lgfktafPfj0
wf17+eTAMh6ZwE2CG/n6PUjYf3uQiIYwPwQqxrjwuLzKrht4sEBOZjRG2vzg/qcPd4m0e2QWt/cf
fEqBw/nePWLPT+9/+unD+3v7n0480m4Q6/6370fYWwr3/zvperdjeOiXbF22J1mTa9QghqoJ/uIZ
OJjkCCPy7b3plNygh3v3yTmhoCx/uLe/R+7MbOJmwNjS5qSCbxTQ/z/7u/6c//yP+Yv/8z/5z/ov
/74/47/8i/7gQfrf7aNwfj7N9rOHNPU5dbyfne9sT7LZHun5A/KqptPz6f6DHgrodQiF9+n83u7e
wacPJxT8zcjDZqvy8OHB+fbswcG9h/v3J3vn927jWEnf/8Wf+Zf/F3/eX7ip+7vhbJiJ4umzHoNo
nXufZvl0Z387ezjNKVCmGPlgtksO56dEl08fPsgf7M++4Ynxeifn8sF0nyRxdnCAaOrh/vbkwTkZ
j9neTr7zYP/B3j2r8z54Trx+J7OH5GDv7ZLDTG7y/qf3Pt2enH96n8KnT7Od7GBn8nCS38ZD+i/+
tL/jv/jr/oH/+o/8k//rv+TPv2XXs0/JOk4y4oQpORn7k4w44V4OXrw/yye7k4cPJ5YNNyii//zv
+dOo8/fq+T6Na7Z/sEta8FMa9IPd3e2H0+kuhXDZeX6wuz+hNMSt7PN//uf+BTTq//JP+CM3smCX
6fRvRNn0F34wVp9Od3cfkG+1ne/OKORAbHRwj1R1vvdwZ//hLH94cG96GwYcxIUTA6zqjl+fBKgp
KhZT1mN3w2zS0W/4a/zo+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj55v6vl/AA==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.AchievementSumQryBP.AchievementSumQryDTO",
                "ad67c24b-c274-4cc2-b4f8-4954741d3961", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.AchievementSumQryBP.Proxy.QueryBPProxy(), "QryInParameter");
            action.FilterOpath = CustomFilterOpath_Extend();
            UIGrid.UIView.Clear();
            action.LoadFirstPage();

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
        }


	private void DTOQueryPrintOut(object sender, UIActionEventArgs e)
        {
            string FilterOpath = CustomFilterOpath_Extend();
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
            UFIDA.U9.Cust.FJGX.AchievementSumQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.AchievementSumQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
