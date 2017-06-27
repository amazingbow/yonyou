/**************************************************************
 * Description:
 * SupplierDocListDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SupplierDocListDQryUIModel
{
	public partial class SupplierDocListDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SupplierDocListDQryUIModelAction));
		//强类型化基类Model属性.
		public new SupplierDocListDQryUIModelModel CurrentModel 
		{
			get {
				return (SupplierDocListDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SupplierDocListDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SupplierDocListDQryUIModelAction(SupplierDocListDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.SupplierDocListQryDTO",
                "35d1fcae-9379-4d03-b0ea-3f47d02895b9", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv+R3fvx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Ud7O5/OZvuzT7d3700n2/vZ+XR7MrlH/3z66cOd6e7B/d2dex+ly2yRf/bR6/VqVRZ5/bSa
Pi+alqF9lM6KZlVm1y82NcmbaV2sWkbuo3Selyv85G/fXK/ovadvvtS2/OOrV2effXTv/mz3fJrl
2w/vPXi4vT/bubc92cmz7Xvn+w9mO3sHD+9PHmr719W6nubP1mUpaHz17Ozp8firh+OTddOOn33n
89973MWsvn7yMvIhIfJR+tXZTxb51dM6u1Ds6LevVh+lr/Lzs+V59bzKZvLFSTad5x8dPX6SNcUU
XzFNZ9Ppp5ODh+fb0/2D/e39ew+I/OcHn24/zHby+9Pdnf3dh/cNTTv0G6QVdf2mepvzZ6+qqn1K
zU6qZZu/a38yK9f86rOibPP6TTb5yaIpJiV99qZe5x+lJ1W5Xiz7n7+u6rb/qUA5fbfKlrPn+WVe
0kwYGN1PAaH72V0ix0ulFJNjJz8/3zn4NNueZPvEYg/3drYnu0Sdg91PJ1k+efjwwe6DARbbzF2D
xHpZVz+dT9uzp94fL7N2jj+fvDxr8wW+epgTg9/PJ9uT2fne9v7ubH87m52D3Wb5Xr6Tf/rpvQO0
/3KV1xm6wEt7+fnewfTBbPsgy3a393ce0LQefPpge+feefYgP5juTx7ufpQSF6Hx7jSb5dn+/van
e5MH2/vnM+LgjN7NswfTvcm9bHrvAfdwfEHi+LQsNzIuMzrxLDe2b9Ho3l3fnuG5+VhB8R88YV+d
+RN2kO99ej8nSdt98HAGnXBOhCHtsHf/3mx6vruXzx7k78u/m6bkq7Mvqllemnm5t0+SvXOwu703
meTb+/cJkYPd3Xz7wfnD7GF+8CC/f57hpWdVvTDvPPj04f7Bzv7B9qf5LlF6undOamxnf3tKk0xT
c28/2z93HdELk4O9CamRe9s7E5LM/Ye7O9sPH+wdbO99mu3MchLQnWyXSSPi8DQ/L5Z5E/4pwn6+
s5fNDna2d3c/vYc5PiBs8+n29CDbzc8fECPdtwr0yboBlOZp1uYdwnW+GiBiVtOUG0ofl0XWdN88
a54V73LC61lWNvz3cVlWV0/KbPnWSHhH4KFKnhV5OYvrkxdEMtF2IDY1p36eCuqqHbnjV1nR5Cfz
bHmRz04vCU0PhSfropx9d57X+eu2Nt2KWFU1mPOzj05/0TorRy+qVn75vM4z6DKCN3pOg+NfvA+l
lflG/nqSt1d5vuRZu9uZNlFf0T95Fvc/ne7kDycPt+9/+pBmcffB3na2/2BKUzn9NCelcHC+99Dp
qMVXy5fZdT77Ynn95qSno7rfvsdc9l7uTudtp+6n8ro6a04Xq/bavtubOAhiPi3gM8gHr1vSc9OP
0hfrRV4XU7Vx65ownZKieFkVmNY9pnCPhHk2ze99Srpi71Mi3P59Mn3Zfk7EvL9/f+fBNLs3Obda
g8b5pmqzcjMdY03ej5gRCIMUNVT6OSLpcXmVXTdwLYCcTC8YucO59Eu2LtuTrMnV7RBOb4K/eEIe
PJxOp5N797d3Pn1Ipmrv/h7pxN2H2zv37x/c38uyTz+F9ZEJISPxourMwH/+x//p//mf+HcO0vxu
v8fJvf2dT3fvH2yfTw5IC2cPSXNP7+1vT8guHny6t3f//MH0FrrwP//D//L//O/5U/+LP/Pv+K//
zL9tU/d3w/Eb0jDBrJCLl7uXZ7PZ9OH27iw7J8T2yH7vEHYP98/3J7PZvb3JQ8ubX48UXmcHewef
HkwekL8zgyB8en9n+yCnvmfnDx4+PNib7c2yb5IKXs+7e/cnn57vkC063yXDvTMhK/jgARmkTyez
6afTT7OZG+ZmLfaf/z1/2n/29/5Z/9nf/2f/13/Jn3/Lzvfu7U+z/fvT7Sy7l8Odosn/9OFkmxTr
ASGWP5hN903nJ6zJZ0+64cN//kf9HUTq/+zv+Xtu2ee9fH+azyZk9g8eEIvvnj/cfviQLPD0IWmi
vQfkXE6ta2nsTYOuOv3+Z3/Xn/Of/zF/8X/+J/9ZG9mty2D6N5xg+gs/RBE+2LuX0T/bDyc7FLcc
wIyA43YfPMgmOw/uH+xM7SxsmP9BVNhtF8t7+vqEUbN9H0wPDmZ7O3vb08l98rVnD+6TO0tYUAR1
/97eg/v5w3s29Igx+vt0auih47fkYdV0N4w1j37DX+NHz4c//w8=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.SupplierDocListQryDTO",
                "35d1fcae-9379-4d03-b0ea-3f47d02895b9", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
