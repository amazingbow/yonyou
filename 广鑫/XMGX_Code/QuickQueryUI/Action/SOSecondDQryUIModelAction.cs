/**************************************************************
 * Description:
 * SOSecondDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SOSecondDQryUIModel
{
	public partial class SOSecondDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SOSecondDQryUIModelAction));
		//强类型化基类Model属性.
		public new SOSecondDQryUIModelModel CurrentModel 
		{
			get {
				return (SOSecondDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SOSecondDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SOSecondDQryUIModelAction(SOSecondDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOSecondQryBP.SOSecondQryDTO",
                "6d13a5df-8739-4009-80a9-77bbc729f625", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf+O3ePx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf3H+zduz+7P9me3N+bbO8/eHBv++HOg4Pte9lePt379MFudv/hR+kyW+SfffT6y9f5tFrO
GMxH6axoVmV2/SL6Xd5M62LVMjofpfO8XOEnf/vmekUvPH3zpbblH1+9Ovvso09nu/ey+zPC9sG9
h9v7OzsPtw92sofbDx5MJtMHew/PP927r+1fV+t6mj9bl6X0/9Wzs6fH468ejk/WTTt+9p3Pf++x
Ram+fvLS/4u6/ij96uwni/zqaZ1dKD7021erj9JX+fnZ8rx6XmUz+eIkm87zj44eP8maYoqvmG47
+f7O+cM8297LH3y6vT+lfx5O79M/+7t7D/dme9nevV1Dtw6pBqlDXb+p3ub82auqap9Ss5Nq2ebv
2p/MyjW/+qwo27x+k01+smiKSUmfvanX+UfpSVWuF8v+56+ruu1/KlBO362y5ex5fpmXn310z8Do
fgoI3c/uEjleKqWYHNPzTw+mD/em2/sP873t/U/PiRL38/Pt6d69vcnOvQf5g4klh5mJAQ4aJM/L
uvrpfNqePfX+eJm1c/z55OVZmy/w1YOHe/c+3f/0YHu6+2B/e39vmm1nD3Ym258+PNg537+3P5ud
T9H+y1VeZ+gCL00f7nx6b5/m8PzhNN/ez6YH25PZfr798NPp7v75vf3zHOgT36DxzmyH5jff336w
d76zvX//0wmN9fx8+970008PJp/ef7C/t4Meji9IyJ6WZZQ5f2JdTN8yJxNvckv7Cg3t3fUtOJrb
jRUG/8ET89WZPzGzyf370/3759v392dEjp2DyfbB7MGD7Z2dvdn+/dmns/2D/H35dNNEfHX2RTXL
SzMb+/f29mbZHnHDeXaPxOQeZPt8RojkB9mD6f75XvYpXnpW1QvzzqfZg+zTew9n2w8nB8RQk3u7
29nB/nR7Z/Lw/t4+TdR0uuc6ohdmD6afPnzwYLad7+/tkg6b7tPsfZpvzx7s7dyb7eUPz3d3mDRP
8/NsXbYnWZOrPIsgNMFfwtB75/d2Jrt72zu79wndnFRRdr57b/vg/N79yWx6b/bg/o6h29Nq+qLq
EO8//+P/9P/ij/8b/su/78/4z//Ev3OQkHf7/e5lu9mDh59+un1/5+H59v7B7mz7INudEg/fyx7s
754Tc903/T5ZN8Uyb5qnWZt3uv/P/q4/5z//Y/7i/+LP/Mv/iz/vL9zU/d2QCoZArAjob/lFDMXB
we6n55P72/d2Dx4Q15PJeLhzcG/7/vmn072dByTjn34jBPG6nM4Ostk9Ytvzc5IxGny2Pbl3nm8/
2MnO7+/lRJBPH5guISTVIq/RWbfnv+Ev+S/+qL/zP/+T/vj/8q/8m27Z8z2yg7P8/s723hQsSGgQ
2+7sb987n9y793D3/uTTh5np+ZQUdL2qiyZ/nl9k5UsiZLXsoPBf/W1/4X/1t/2l/9nf8/fcsv9P
z+/nnx4Qz+3vT0hqp5N725NJvrt9n1h5/x4xIplsq06zMm+iAxcm+M//5D/rlr0+nO0+yPLd/e29
bEpKfLpPcrQ/pV4Pprs5Mf/Dnf0D0+ubqs3KL8iP6DoC//Uf+Sf/13/Jn3/LHs8fzqb3J6Rtiekz
0rsHeyRlO7PtvXuTBzukismaWjp/E9ze5W/7AWuEu6F/dPQb/ho/en70/Oj50fOj50fP/xue/wc=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOSecondQryBP.SOSecondQryDTO",
                "6d13a5df-8739-4009-80a9-77bbc729f625", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SOSecondQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SOSecondQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SOSecondQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
