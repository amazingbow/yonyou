/**************************************************************
 * Description:
 * CustomerDocLineListDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.CustomerDocLineListDQryUIModel
{
	public partial class CustomerDocLineListDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerDocLineListDQryUIModelAction));
		//强类型化基类Model属性.
		public new CustomerDocLineListDQryUIModelModel CurrentModel 
		{
			get {
				return (CustomerDocLineListDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CustomerDocLineListDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CustomerDocLineListDQryUIModelAction(CustomerDocLineListDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.CustomerDocLineListQryDTO",
                "8efe437c-c62d-4066-8c17-c8ef8ac54b28", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP/js8e/xblGml3ndFNXys492xzsfpflyWs2K5cVnH63b8+2Dj36Po8c/sc7r65NqsaqW+bJN
i9lnH92bzu7nu9OD7Qf39ne39w92d7cns8mn25Ps4NO9h/emO3uf5h+ly2yRf/bRybppq0VeP62m
z4tl/rxoWob4UTormlWZXb+4qVneTOti1TKSH6XzvFzhJ3/75npF7z5986W25R9fvTr77KOD/Dzf
v/dguj39dG+2vb/z6afbB9PdB9tT+uIgm97fn+wdaPvX1bqe5s/WZSmofPXs7Onx+KuHY+A0fvad
z3/vcQy7+vrJy4EvCKGP0q/OfrLIr57W2YViSb99tfoofZWfny3Pq+dVNpMvTrLpPP/o6PGTrCmm
+EpofLCfT/ZmB9v39vfube8/PNjZPjjYn23v7Uxm93b397L8/kND4w4tB2lGXb+p3ub82auqap9S
s5Nq2ebv2p/MyjW/+qwo27x+k01+smiKSUmfvanXNJsnVbleLPufv67qtv+pQDl9t8qWs+f5ZV7S
gAyM7qeA0P3sLpHjpVKKyXF/Nr03OZicb8/2Hk639z/NZ9uT6f172zufnueffnpv5/zew4MNLHcz
tw0S7WVd/XQ+bc+een+8zNo5/nzy8qzNF/hqmu09IHz2tw8+vX++vb93MKHp+nRve39/upvv3Tv4
9N69HbT/cpXXGbrAS5/e372f39t5uP3gfpbTHGf0+uzh/e29fPfeeTbdffjg0/2PUuImNN7dfTCj
L3a2d/N7xBBZnm8f7NO7k4Pp3sHuHjU+P0cPxxckpk/LciMjM+MT/3Jj+xaN7t31+wkAvzJWcPwH
T95XZ/7kfbq/u5vt7+bbWf4pjfPTfRrn+fl0+17+YDKZzHb39j/99H15edO0fHX2RTXLSzM3+/nB
zv7s/v3t/cku8c75bLqdfbp7f3ua5ZOdvTy/P929h5eeVfXCvLN7b+/+/Yf30Wj30+39+5/OtrMd
0h8PD+4/yB9mezv3Huy4jsAA+Wx/7/696fbBg72HxAD39rYf7n+6s/3pg/MH072H5+e7e+dMGhGN
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
fvT86PnR86PnR8+Pnh89P3p+9Lzn8/8A";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.CustomerDocLineListQryDTO",
                "8efe437c-c62d-4066-8c17-c8ef8ac54b28", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
