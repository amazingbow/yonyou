/**************************************************************
 * Description:
 * CustomerQucikDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel
{
	public partial class CustomerQucikDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerQucikDQryUIModelAction));
		//强类型化基类Model属性.
		public new CustomerQucikDQryUIModelModel CurrentModel 
		{
			get {
				return (CustomerQucikDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CustomerQucikDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CustomerQucikDQryUIModelAction(CustomerQucikDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.CustomerQucikQryDTO",
                "8e1fef24-e19c-491f-a5a9-ef3ca530c5e0", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXPzN9/Hu8W5TpZV43RbX87KPd8c5Hab6cVrNiefHZR+v2fPvgo9/j6PFPrPP6+qRarKplvmzT
YvbZR59+evDpvdl5tv3gfOfT7f375+fbk8nu7vbs/s7k04cHeZbdI1jLbJF/9tFPrIvpW4bxUTor
mlWZXb/of5E307pYtYzIR+k8L1f4yd++uV5R66dvvtS2/OOrV2effXSQ757n53v72/nuw+n2/sPd
8+3sfvZwOz+/N83u39uZ3s93tP3ral1P82frspTOv3p29vR4/NXD8cm6acfPvvP5782/VYu8/on1
tHj7E/X1k5e9jwiJj9Kvzn6yyK+e1tmFYka/fbX6KH2Vn58tz6vnVTaTL06y6Tz/6Ojxk6wppviK
affw/uwgm+X59r1P7x1s708e7m8ffLp/vv1wOpvu7d3f29m9nxnadSg2SCfq+k31NufPXlVV+5Sa
nVTLNn/X/mRWrvnVZ0XZ5vWbbPKTRVNMSvrsTb3OP0pPqnK9WPY/f13Vbf9TgXL6bpUtZ8/zy7z8
7KN7Bkb3U0DofnaXyPFSKcXkmOR7+e79+9PtbHe2v71/8Omn2wcH+WR79+Fkcj/P7mUH+7khRzAd
Hdp0v4sT6mVd/XQ+bc+een+8zNo5/nzy8qzNF/jq3v39vb39yXT7wcPJg+392ad72weT6d72bDK5
t39wcH/n/NNztP9yldcZusBLNK/Zgx1ixr37JAn70/OD7Yf3s53th+cP7p0/nNzfm+7PPkqJg9D4
/NMH9PHs/vbD7AH18HA6wfzTqIkJsvNP7+9P9rmH4wsSuadlGWVYJ0DEqtzSvkJDe3d9Wy7nxmMF
xH/wPH11FszTwezBHkn9dr7/KbHtw/3p9sHOJN/+9OHD6fnD2Q6J/P77su2m2fjq7ItqlpdmSnKS
6IOcOr1HjEHdY0pmew+3Z3v3Zw8m0/ukfR7ipWdVvTDv7O/sPvw0n+5uT/fvPdzef/ApSdo0290+
f5DtZ/f3Zju7D2auI0zh/uzBvfwg2852iCH3Jwe72we793e384MH9+7dn53ffzCdMmme5ufZumxP
siZX8Ra5aIK/mG7EPUSr2XT7PMtJVU6zB4T4vfvEVcQv2Q4x/8ODLn///ieEUYeI/+Xf92f8l3/R
HzxIyrv9nh9kxHJEge3zyfkeGJJ4cUaKZu/e/u70wYOH2cOD3V7P6KzT83/+J/3x/+Vf+Te9T88H
k/zT/Xs00nvZQxKFB+eT7exgCuX84Pz+7jTf83o+JS1Vr+qiyZ/nF1n5kohYLTsY/Fd/21/4X/1t
f+l/9vf8Pe+FxPTB/fN7D/a3pw+mxLC7s4xm/8He9vTTyWTn/HxGfGsZ9otqUpT5i6rT73/xR/+x
/8Wf916d5p8+oLkmO/Tg/gHNMQkHcdD04faDg53ZvU9JhmZ7Vpu9nJNB7fX5X/5pf/t/9Tf++e/T
597DfLrzgAzg7s45adC9PdKlDyfZ9v3p7OH5/XyyPzk/783z66zMm7zuTvXf8Jf8F3/U3/n7/2d/
15/zn/8xf/F//if/We+DxvTep/v7eTbb3nuwQ5O+d36fGP3+/vbDB7N8tns/393Pp31G119Osja/
qHouguLzn/9Rf8R/+Tf/vZuQuRsKoZFPNkv0t/wi5nc/v//pZG93e2d3do8UCemQSf7ggFyXbPcg
v38+3c2s6/Jh8uh3+unuvU/zh9RLPiG2ONjd2SZbQfN0nk9n2aefnuc7978ZUfQ6PSe7tTchzfPg
/n2S/92HJP/3aMwPH+zv72akGvLJ3jcuhV7/Ow/zg/OHNMrpZH9G+ufePdIChM6n9/LZ/U/PP93d
mc4+WAB9Ih/cn5DKn23nEIb9bGdGAn9/Z3t6/zyD8r2XTy0Dfl3Z87ub7d578HDvYHvn4FMy4Qf7
BzSd2ac0xfnup/t7ExhL092z7F2nq//s7/uL/ss/7y+8ZVd5fu/ejJTJ9gTzt39/92B7MiNGun9w
cDC9R/2T7JmujqftOiuPX35BA+yL01/wX//Zf/h//vf8af/Fn/Z33LLrSbZ3QBosI+WCUe7f29+e
7O9T19O9ewe75w8JFycudT4r2ljH/9k/+Bf/l3/aX/Vf/yV//n/+9/wVt+x45/zeffLjH2zvTeCD
7d0j83E+y7fv7+zvTc8nD3azzKrv51nTvqmzZRPr+7/48/6g//xP+hP+s7/nL/sv/qw/lTC4ZfcP
98gRJ790e2/vnLTZZPopSezBw+3pzu7OAf358N6eVaro/lU+He6cyP1f/HX/wH/9R/7Jt+//YJI9
vJfvnG/fzylA2M8nu9vZvQnZ8k8n93fuTck53nlg+n+Tveuz8l/1J/znf+LfecvOZnsHD/N7RObp
7h58u3x/O9sjN+vh/gMa83Tn/uyhneQn2fJtTDP9fX8Qaer/+k/9O/6rv/iPu2Wv070pef4H+fbk
4R5meJpThzv5NoVBFMU92M/O7zn9kC+6I/yv/sa/7b/4s/6EW/Y126MxfvrwnJyB/JzISfr/YXaP
PPp7+cOHu/fPH+y7oOt4NqvzpukO8M/7m/7zP/8P2miDulZH/0YYRH/hh4x7ci+b7kyn2zs5SdP+
7oN75CPsk5d5/ukeqcv790jkbmOBBnHhyI0j0OPXJwFqiorFlP3Xu2GAf/Qb/ho/en70/Oj50fOj
50fPj54fPT96fvT86PnR86PnR8+Pnv/PPf8P";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.CustomerQucikQryDTO",
                "8e1fef24-e19c-491f-a5a9-ef3ca530c5e0", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
