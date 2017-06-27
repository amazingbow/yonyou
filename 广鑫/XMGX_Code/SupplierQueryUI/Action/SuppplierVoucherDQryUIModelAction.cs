/**************************************************************
 * Description:
 * SuppplierVoucherDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SuppplierVoucherDQryUIModel
{
	public partial class SuppplierVoucherDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SuppplierVoucherDQryUIModelAction));
		//强类型化基类Model属性.
		public new SuppplierVoucherDQryUIModelModel CurrentModel 
		{
			get {
				return (SuppplierVoucherDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SuppplierVoucherDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SuppplierVoucherDQryUIModelAction(SuppplierVoucherDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.SuppplierVoucherQryDTO",
                "84ee70f6-4958-46c2-87d4-a82585f62f87", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv+p3e/x7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf7e/eme1l+vj3NPt3d3j/fO9g+yHcfbt8/3/n0fnawk336YPJRuswW+WcfvV6vVquyyOuf
rNbTeV4zuI/SWdGsyuz6xcY2eTOti1XL6H2UzvNyhZ/87ZvrFb349M2X2pZ/fPXq7LOPDvbz/MHO
+afb+w/vH2zvfzrd2z54MNvfzg727h/cP/907/zggbZ/Xa3raf5sXZaCx1fPzp4ej796OD5ZN+34
2Xc+/73HPdTq6ycvY58SKh+lX539ZJFfPa2zC8WPfvtq9VH6Kj8/W55Xz6tsJl+cZPTaR0ePn2RN
McVXTNf79x7cz3cm+Xa292m2vT/Jd7cfTieT7dnBZGdycH93//7U0rVDwkFqUddvqrc5f/aqqtqn
1OykWrb5u/Yns3LNrz4ryjav32STnyyaYlLSZ2/qdf5RelKV68Wy//nrqm77nwqU03erbDl7nl/m
5Wcf3TMwup8CQvezu0SOl0opJsf55OGnuw8/3d/+dHeyv72/N51uP7y3k21Pdh7s3TvY3Znc23sw
xGY3cNgguV7W1U/n0/bsqffHy6yd488nL8/afIGv9s53dvOdfLL9cC+bbO8fHDzYnhxM6J8HO58+
eLiTZ9nsHO2/XOV1hi7w0u50ku3cn0xJYKYPiTvvTbeznYP72w92H+x/mj+cHZzvkwQSH6Hxwf70
4afTTz/dnk1IuvYf7Bxs0y/02+7e/vlOdjA7z6bo4fiChPJpWQ4yLwbNzE5sy43tWzS6d9fvwfTc
fqyw+A+es6/O/Dl7+OD+ZP9+vr/9YPrgwfb+vYcPtyf3zifbn97PHzzYnYGLz9+XhTfNyVdnX1Sz
vDQTc//Bg8l0f+/h9u7ehGh8b3Jv+yDbv7d9fk543dub3bsPsn119qyqF3Yy708/3d27v7edP8z2
6J38Hs0Lid7elGYxn07v3ZvsuI7ohf2d+w92pwefbuf7Wb5N/9/dPrh3sL99cLA3mx5kDx7M7u8y
aYT3n+bnxTJvwj+FwfdnswcPP51s35+QlO9/enBv++HDabY9vX+wdzC7f//BzsMdx+CLp/mkaL8g
NdzXn+F3A2TMapp1Q+vjssia3qtnzbPiXU6oPcvKhmTairj+De3xrMjLWVeF/FReV2fN6WLVXrvG
WZs/FTxF6xEOVbFsieTo/yq7bqAR0Z1okA7JhEYP9+7d3yPqPtjfI50+IUF4eJB9Svy182C6v5Nl
2fSeR6OTOp8NEin88v2oFLz7/z4yHewSB87IBn9KDUVfZJPsfPvBbJpNzif3z3fzzCPTAIG+Hmlu
Iopg/cOnyf55/uAh7MfB/Yfn2/uzB/n2w9lkZ/tgMptkByTZD/dmhiaDsvV1BetWUvUNUabOpwWc
OPngdUsmh7Tci/Uir4upOhzrmpCcXvt0jNHswXSW7dy7n2/v7dzbIXGbZNsPzw9ILT48/3R2QP7T
9MDa3GFZ+9qCdjsp+38f2T7NPt3ZOZgR2R5MyCPe3yHPbW+yt31/7+H9/b0DGJFdQ7YnWZktp3mM
bp2v3oNw4Zv/76Xc3Y5NpF+yddmeZE2u3rC4kU3wF9N49nD/3qfZbLJNQk22/T4JdnZO/zyYzO7n
n+7v7+cPPEsgDgyo1KHxf/6H/3X/+Z/4d/3nf9If/1/+lX/TII2BaYiNQZTRt8ZczfincMpm22SS
yE8lL34bPtD2znR3mt8/uPcpufVWz1TTF1UXoz/+T/8v/vi/4T//E//OTeh4/e1NduA4Trbz+7vk
NkwpuDnIJuQbTvdy4rOH53u7e15/mI8YHbjX//Jv/nv/87/gj71lx+QOzfIH5JROD/YoPtm7f488
3oMdmpB7n+59Orn/4CDLv8EZ8Hrevb/78CAnZ/kgJ99yP989387uT863J7OHn+YP9sjt29238rVu
wFsNGLfb8x/1d2DYf+Zf/l/8eX/hLXueUaxxfm/vPonyjIzIlJy9yaefHmzv7E93d3Ym0we7e1NP
IVKfsyddsZZu/7O/5++5ZZ+f5uT57053tskxpWmdzGbkW94nLzOf3r93f7aXfbr38EbD9Z//QX/h
f/Fn/N3/9R/5J//Xf8mff8t+d8h73snyh9v3HsxIi+3cJ8Z6QJN8P6Og+dMH2c7O1M7vsPL/r/62
v/N9O76/f+/BLkXp2/cf3tuDaN8nS51Nt2efUmC0s0++3v3JLdTnf/43/Yn/1d/wF9+yzyw7P7iX
P4TA3kc4RlHCwYQsXXZv7yFF3tn0/p5lqS/yRVdo/4s/+c/6r/6KP3ijAumqDP0bsS/9hR/C29l+
Nnmw92D74c75faL6lGxHTlP+4OGDeyTn9J2j+gbeHkSFo3VJR5y+PglQU1QspqyF74YZn6Pf8Nf4
0fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89/194/h8=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.SuppplierVoucherQryDTO",
                "84ee70f6-4958-46c2-87d4-a82585f62f87", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
