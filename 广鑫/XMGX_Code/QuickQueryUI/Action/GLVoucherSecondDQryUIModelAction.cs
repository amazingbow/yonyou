/**************************************************************
 * Description:
 * GLVoucherSecondDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.GLVoucherSecondDQryUIModel
{
	public partial class GLVoucherSecondDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(GLVoucherSecondDQryUIModelAction));
		//强类型化基类Model属性.
		public new GLVoucherSecondDQryUIModelModel CurrentModel 
		{
			get {
				return (GLVoucherSecondDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public GLVoucherSecondDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public GLVoucherSecondDQryUIModelAction(GLVoucherSecondDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.GLVoucherSecondQryDTO",
                "f73410e7-a3b1-41a6-9197-ae597d5e9c76", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX/+q3fvx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22UcP9u+f70zuf7r94OG9fHt/796n25PZbr59/+H5zoOd+zsPZ/sHH6XLbJF/9tHnz3+yWk/n
ef06n1bLGUP7KJ0VzarMrl9sapI307pYtYzcR+k8L1f4yd++uV7Re0/ffKlt+cdXr84+++j8wb39
3Z38wXZ2b7K7vb+bfbr9cPch/Znff/hgdj9/OH3wqbZ/Xa3raf5sXZaCxlfPzp4ej796OD5ZN+34
2Xc+/73HXczq6ycvIx8SIh+lX539ZJFfPa2zC8WOfvtq9VH6Kj8/W55Xz6tsJl+cZPTyR0ePn2RN
McVXTNP7s3w6I1Ju3z/Y3dneP/802z6Yzg62s/OdfH+6M8v3JjND0w79BmlFXb+p3ub82auqap9S
s5Nq2ebv2p/MyjW/+qwo27x+k01+smiKSUmfvanX+UfpSVWuF8v+56+ruu1/KlBO362y5ex5fpmX
n310z8DofgoI3c/uEjleKqWUHPf2Pp3Opts7B7O97f3Z/mR78ml2f3v6cPdgd3fv/P69A0uOzoRs
5q5BYr2sq5/Op+3ZU++Pl1k7x59PXp61+QJfne/tzPb28vvbu5/uTjBNOU3TNN/efbiXPdyb3n8w
vT9B+y9XeZ2hC7w0fbizc5BTq9mn92huCQDJS5Zt7z+49+n+p9N7D+mXj1LiIjTe/3Tv3vTep/e2
d/IDavLwXradTfOD7d187/zg/v7sfPYp93B8QeL4tCyjjPsT62L6lrmcGJZb2ldoaO+ub8/t3Hys
oPgPnq2vzvzZ2p8dfLrz4NPZ9qcP9mmA+w+y7cl9+i3f+/TewYPJp/vT92feTfPx1dkX1SwvzaQ8
nO1N9tHfzt5DYpb75w+3s/s7+9vTg/Pd+/v37+9m+zleelbVC/PO7kF+AOpvP5gS3vvTg3ybZunB
9vTBzoPpbn7vYQ4GMx3RC5/u38t27u892D4/zw5Isxzc3z54QDzwcP/84MHs072Hk+l9Js3T/Dxb
l+1J1uQq5CIdTfAX021Cb+3tZ5Pt+xPSofvnWb6dHeyfb9/L7s/Od7J7Dw4e7hu6QQVnS6Zah4T/
+R/+1/3nf+Lf9Z//SX/8f/lX/k2D5Lzb733n4FNi2HyyvfPp3v72/sH+g+2D+wf7NGsPDnYfnpOW
f/jA9H786mk1fVF1e/57/rT/4k/7O/7zP/5P/y/++L/hvXo+/3S2u/OQxp3dIy29t/OQpPvTT7fP
dzPMyWT68N6OHXedZ23+lP7f7fyP4p7/zL/8v/jz/sL36XyXJOn+HumST/d3p9T5wafbB5P9e9u7
k11SOdODBw93Hoadz550TZb0/Z/9PX/Ppo7vhpNv+IKVIv0tvzBKe3v39rOMULq3S+K+v/vw/na2
OyO8aBJmxMoPpg92vzk+8DrOcur6wfm97dn5/QNopt3th9mDT0mOH+w+2N0l/bZnafFhLOB3ujvZ
2Z1k59uTvV0SvRmZuofT2c72p/m9T3dJg55P9s+/sdn3+t0/f/jpvfvnk+1PPyWPYP88f0gSvE+d
7+zfJ1nIdvem976Riff6/PTg/oP9B8Ta9x/s3aeZvTfbPnh4QMw225tmBzsHe9N9y+nH02m1Jus8
e1p3e/2D/sL/4s/4u//rP/JP/q//kj//lh0/yKaT/QfE4A/JXBKRd8iA3t872P703r39g0/vP7h/
kE17HZ90O/6v/ra/8307nnw6/RRdb98nrby9f29/n7TKvXvb090JGT4a9eyBZanX60V/rH/Tn/hf
/Q1/8Ua56kqS/YBV7t3QYz36DX+NHz0/en70/Oj5+fn8Pw==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.GLVoucherSecondQryDTO",
                "f73410e7-a3b1-41a6-9197-ae597d5e9c76", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
