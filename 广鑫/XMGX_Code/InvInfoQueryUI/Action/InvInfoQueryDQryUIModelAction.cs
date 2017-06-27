/**************************************************************
 * Description:
 * InvInfoQueryDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel
{
	public partial class InvInfoQueryDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(InvInfoQueryDQryUIModelAction));
		//强类型化基类Model属性.
		public new InvInfoQueryDQryUIModelModel CurrentModel 
		{
			get {
				return (InvInfoQueryDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public InvInfoQueryDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public InvInfoQueryDQryUIModelAction(InvInfoQueryDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.InvInfoQueryQryDTO",
                "125fe688-7233-492a-aeff-a142dfafe751", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"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
n1IiZfJw+/6n5zDUO6QYHpAjRcZ6Sn5u9vDe7OY1uI2Z9f/8b/ij//M//K96L6QOHt77dO/ejBJn
D3fJik9JQzx8SDmebDoh6X24e7Czb9MTHlJdfz8quLd0+n1sds8p/pkcbJNVpSCfTAklS4jP8r2d
83My69NPc+vFmeBv2I36z8ik/j1/6i27vr9PJvzTg/vbsxze/nR2n/Tlgx1KNzzMHmLVdJJvzs4O
pbxUdf55f9V/8Uf/saTMf39flf7+/+Xf8g/853/PX6E/bonpwcPZPUqGUFy6m+8jSDwnIpH438v2
zveJke5Npx3Fess88m0w/a/+qD/+P//D/3Ka0f/8L/hjb4nv3v0HxFs797d37pFq2t8lWwjPcTvP
8/NP7+/N9ic7Nqi9MUv6NRH+z/+g27q1B7u7e/cme+RDnD+gkHNn5x5pU7Lhn2Y75NE93JlkD943
6dlF07doX4sDHt6fZvvn02wb0QWJCVwMpExms/PJHvnC98/3OhS9Oad4GyTfl5b7nz58sI90BiUv
yE7cf5BvP5wgiUTmaWc6o9hsf7IJz1vw6DCaN/Po3W48qX+/ruqW/sIP8fIfnmf3ZpQIIDVEinuG
dMiDezSWXcqEnz98mO/OYlmZSIwziA36krTe8euTADlFxuLKubu7P7HO6+uTarGqlmQcjn7DX+NH
z4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+fn6fOjYf/o
+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+dH
z4+eHz3/33/+Hw==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.InvInfoQueryQryDTO",
                "125fe688-7233-492a-aeff-a142dfafe751", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
