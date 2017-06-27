/**************************************************************
 * Description:
 * SupplierDocLineListDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SupplierDocLineListDQryUIModel
{
	public partial class SupplierDocLineListDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SupplierDocLineListDQryUIModelAction));
		//强类型化基类Model属性.
		public new SupplierDocLineListDQryUIModelModel CurrentModel 
		{
			get {
				return (SupplierDocLineListDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SupplierDocLineListDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SupplierDocLineListDQryUIModelAction(SupplierDocLineListDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.SupplierDocLineListQryDTO",
                "599b2adb-e20c-4f3c-9fad-715a96c3fad0", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX//re49/j3aJML/O6KarlZx/tjnc+SvPltJoVy4vPPlq359sHH/0eR49/Yp3X1yfVYlUt82Wb
FrPPPjrY2Tn4dG823b53MMm29z99eH978nB2sL0z3T2/v7e3+3Dn/v5H6TJb5J999Hq9WpVFXj+t
ps+LZf68aFqG+FE6K5pVmV2/uKlZ3kzrYtUykh+l87xc4Sd/++Z6Re8+ffOltuUfX706++yj+w8f
Tvay2WQ739uZbu+f35tuPzzPZtsPdu9nDz+d3qPfd7T962pdT/Nn67IUVL56dvb0ePzVw/HJumnH
z77z+e89jmFXXz95OfAFIfRR+tXZTxb51dM6u1As6bevVh+lr/Lzs+V59bzKZvLFSTad5x8dPX6S
NcUUXzGNd+9l9+59unu+PX04Ixo/PJ9uH5zPzrcf5Huf7k4f7tIIHhoad2g5SDPq+k31NufPXlVV
+5SanVTLNn/X/mRWrvnVZ0XZ5vWbbPKTRVNMSvrsTb3OP0pPqnK9WPY/f13Vbf9TgXL6bpUtZ8/z
y7z87KN7Bkb3U0DofnaXyPFSKcXk2NvZ28+n0z0a/3RG8/kw257sfPpw+/7D/enevd18f+8g28By
N3PbINFe1tVP59P27Kn3x8usnePPJy/P2nyBr6aTg0/v5ef5dvbgYb69f7DzYPtgdp/+ye7fu7e7
t/PwYPIQ7b9c5XWGLvDSJJud35/ce7g92dt7sL2/k9Pr+eT+9r1ZPtnff7B/f2c6+SglbkLj8/zT
h/uf3jvfPr+3c04UyPe2Dw52d7fv37s/mezcm5zv7M3Qw/EFienTstzIyMz4xL/c2L5Fo3t3/X4C
wK+MFRz/wZP31Zk/edPp/Qf3Z/sPt/fyBw+39/fv04j39/e292b5/fP9e9NPz/PJ+/Lypmn56uyL
apaXdm7u5Z/u5aDX/qcH2/uzvX1SV7v5dn7v/nRyb/fep5OdDC89q+qFeeecFFk+yQ+2Zw8fkv64
R4KY3ZtOtg8m+fn9T+/v3t8/33Ud0Qv79x8Qg2Y723sH+S5ND16Y7ZHQ7k0mD+7v57v37j9g0oho
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
z8Pn/wE=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.SupplierDocLineListQryDTO",
                "599b2adb-e20c-4f3c-9fad-715a96c3fad0", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
