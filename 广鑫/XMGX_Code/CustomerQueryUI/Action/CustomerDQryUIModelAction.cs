/**************************************************************
 * Description:
 * CustomerDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.CustomerDQryUIModel
{
	public partial class CustomerDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerDQryUIModelAction));
		//强类型化基类Model属性.
		public new CustomerDQryUIModelModel CurrentModel 
		{
			get {
				return (CustomerDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CustomerDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CustomerDQryUIModelAction(CustomerDQryUIModelModel model) : base(model)
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
		public void BtnShowCustomerDocLine(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.BtnShowCustomerDocLine_Extend);
		}
		private void BtnShowCustomerDocLine_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
		  	  
	 

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
		/// <summary>
		/// Help: 
		/// </summary>
		public void BtnOperatorsDaily(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.BtnOperatorsDaily_Extend);
		}
		private void BtnOperatorsDaily_DefaultImpl(object sender, UIActionEventArgs e)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerQryBP.CustomerQryDTO",
                "06962097-1967-412d-93ee-705453ccb0c9", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf+Ls8e/xblGml3ndFNXys492xzsfpflyWs2K5cVnH63b8+2Dj36Po8c/sc7r65NqsaqW+bJN
i9lnH+WfPtzLzmcPt+/vzw629z/d3d/OHuzPtj/d27u/8+n04N7e7u5H6TJb5J99dLJu2mqR1wzm
o3RWNKsyu34R/S5vpnWxahmdj9J5Xq7wk799c72iF56++VLb8o+vXp199tHOpw8/3dt5+GB79+Gn
D7b3d/dm2w/v5fn2g537+/fvTaeTnelDbf+6WtfT/Nm6LKX/r56dPT0ef/VwDETGz77z+e89tijV
109e+n9R1x+lX539ZJFfPa2zC8WHfvtq9VH6Kj8/W55Xz6tsJl+cZNN5/tHR4ydZU0zxFdNtf2/3
3r3ZZG/74e5evr1//8HBdrY7zbcf5vn++fn55OH+p/uGbh1SDVKHun5Tvc35s1dV1T6lZifVss3f
tT+ZlWt+9VlRtnn9Jpv8ZNEUk5I+e1Ov84/Sk6pcL5b9z19Xddv/VKCcvltly9nz/DIvP/vonoHR
/RQQup/dJXK8VEoxOaYPdh9Mz8/3t+nfbHv/wcG97Yc7IMfk/N7DyX2ayvN7XTYa4KBB8rysq5/O
p+3ZU++Pl1k7x59PXp61+QJfne/tz+7dP5ht7z2cTbf3d/Z2tifTCf15//4B/XWQn88maP/lKq8z
dIGXpg93D7L84OH2waf3HxLj7T6gl3ISip37e59O7h3QZB98lBLfoHE+zXc+PXgw3c73739KIvPw
YPvgfG93++DBQX6PABzkezvo4fiChOxpWW5mTjAzsSc3tm/R6N5d34Kpud1YYfAfPDdfnflzkz24
d0Ac+WD7YLIHqZp9SiJ+b7Kdf3p/N9s9P8juTR+8L6tumouvzr6oZnlpJiQ/35/t3dvd3f509pBY
I8+mJNSka6b3J/f2zh9mu5OD+3jpWVUvzDvTyaefHuztf7p97/5ssr2/vzvZpvmZbk8/zc4P8unD
+9n9HdcRXsju7e9m2f3tBw9n59v7D/dptLs7D7aJJaf3z/PJ+f2HwrbC+U/z82KZN+GfTKz7Dw9m
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
+d/zp/0Xf9rfcUtEJhRLkbNLi76zfULkYLZDOOQ72zPSaMQ8OfGvdedujFr/iz/vD/rP/6Q/4T/7
e/6y/+LP+lP/67/kthNDC0DEENP721Ms6+3v0zoU6XjSH7ukzR7s7T48R0LPoXBTsEdY/Ff/4J/8
n/1df9B/+deBEP/FX/cP/Nd/5J/8Hujsn+9SRmRv+94OJTv392f72xOsUJF/e3+S7eU72blNTTlN
Rt5c/obYoupOyZ/79/+Xf9Wf8J//iX/nLXvP9u5PdymDQGwJz47iYBKaye72/enB/oNPH96jpHZP
cTyhzN/xdFqtl21Mcf3nf98fRCr9v/5T/47/6i/+426JxcHDvYO9HCuXExJYkmOw56c7pL4+vXeQ
ffopLWjaKbE0eOogd72Av/Fv+y/+rD/h1n3nk2xCnU3Pp6Q2Hny6R0v92R4tde+d70xo2XHy0HJk
15LEVOitzInX/y4tj+U5GdTJPViy3X30/2Bvm1Jonx7sZvdn05u1aASNW3lCHhqkIif3abox8w+w
xEopkN19ckKz3dlOfr5DK7A3LyhFTcotLbyHy96nn+bTe+e0KpzvUTrmwT0KN+4/mG2TfzqhJUPy
h2d94/7l+XkxLbLyeTXNAD6Ky5/3N/3nf/4fdEsspvnO7N7uw4fb93fukU399PwhLayTH7a3t/Mw
OzigpZqpdcFuGfKFjPIP/sX/5Z/2V5Gi+M//nr9io+vRdTb079dV3dJf+MH4Psw/3SPuoQzgDvkc
+1PSJpPZ7gG5sRNSbVPKCR70hSgiv4O4oCcJhY5fnwSoKSoWU4537v7EOq+vT6rFipTmsj36DX+N
Hz0/en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+dHz4+eHz0/en4+
Pf8P";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerQryBP.CustomerQryDTO",
                "06962097-1967-412d-93ee-705453ccb0c9", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.CustomerQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.CustomerQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.CustomerQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
