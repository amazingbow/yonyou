/**************************************************************
 * Description:
 * CustomerDocListDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.CustomerDocListDQryUIModel
{
	public partial class CustomerDocListDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerDocListDQryUIModelAction));
		//强类型化基类Model属性.
		public new CustomerDocListDQryUIModelModel CurrentModel 
		{
			get {
				return (CustomerDocListDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CustomerDocListDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CustomerDocListDQryUIModelAction(CustomerDocListDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTO",
                "85a1401c-1e59-4b45-9470-2a1d96fa1581", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv270+Pd4tyjTy7xuimr52Ue7452P0nw5rWbF8uKzj9bt+fbBR7/H0eOfWOf19Um1WFXLfNmm
xeyzjw4OPj3fne3NtrPs/v3t/YPpw+3s4b18ezfPZnvZ/f172U7+UbrMFvlnH52sm7Za5PXTavq8
aFqG9lE6K5pVmV2/2NQkb6Z1sWoZuY/SeV6u8JO/fXO9oveevvlS2/KPr16dEWr3s939nd0p4XL/
4fb+ZP/+9sP9Bzvbe9nu7OGn59nu/YNdbf+6WtfT/Nm6LAWNr56dPT0ef/VwDHzGz77z+e897mJW
Xz95GfmQEPko/ersJ4v86mmdXSh29NtXq4/SV/n52fK8el5lM/niJJvO84+OHj/JmmKKr5ime7v7
B9mD2f72w+mD2fb+frZP1M0ebB883M/z+zuzhzuTc0PTDv0GaUVdv6ne5vzZq6pqn1Kzk2rZ5u/a
n8zKNb/6rCjbvH6TTX6yaIpJSZ+9qdc0eydVuV4s+5+/ruq2/6lAOX23ypaz5/llXn720T0Do/sp
IHQ/u0vkeKmUYnI8vJ/tn8+mD7Yn2c6D7f3dycPtyb1ssn1w73zn4YP9fG93dm+AxTZz1yCxXtbV
T+fT9uyp98fLrJ3jzycvz9p8ga8mu/dmB/sPJ9ufEu9v79/Ls+2Hk7297dn5p/fuTaf3aQoP0P7L
VV5n6AIvPdy/P7m3N/10+97+dLq9/+m9T7cnB3m+vT89uD/Z2T8gNiXZIy5C4/zhZGdnL7+/fb6f
7W7v5/cPtrMpSdh+dv/h7N5kZ3eW30MPxxckjk/LciPjMqMTz3Jj+xaN7t317Rmem48VFP/BE/bV
mT9h2eTB7mS6u7s9ndBA9yc0dSRv97fv7e492D9/8OlO9vDT9+XfTVPy1dkX1SwvzbzsPDjPchL8
bSIP0Wq2s7c9me4c0Lzs7u/NHuzM7j/M8NKzql6Yd+4/uDfbO5jubD+8d39ve//BbJfYa7q3ff4g
y7O9gwc79/c+dR3RC/eyB9nOfVJ0s/1PSUYP9g62J5P7+faUOti9n03zhw+El0UcnubnxTJvwj+Z
WJOHu9MHe9PZ9r0HO/tErAMCNN29t/3pvUk2PTjfOT9/OOty9wBbDxMvq2mqDYWPyyJr/LfOmmfF
u5xweZaVTY6/j8uyunpSZsu3Rqo7Qg718azIy1lch7wgMomGA4GpedbmTwVl+ZiUUFY0+ck8W17k
s9NLQs/r/sm6KGffned1/rqtTZciRlUNZiQAR4+J5ajFcip0vL+ztzfbpbm4t5fv0ITskLY/2NnZ
3iH1MH0wyfJ79/bfl+nA1DTXu9nB3v7+ven2zk42xRRNtycPiVd2891PD86znen+ZI8bs9n5KP29
8mumDX5nwuhfJ0SVj9I3RC79AN3jxXZdL/2GZ0+DT4VkRAqyxh+lz/Nz6Mw6b8RYu3kkDL5bzCAT
9w92+M9v58XFnKi1v3PAzHjXZ78IMz749P7Bw/s5SS5pJhKd+/dIcmfZ9n0a86c05gMyQ4aIZj6a
DjX9z9+DHb3X/v/Bj7vZp6Slod4nU1iH3e1JTkqJpubgwezTyXSaT78mP2a7uwfTbDbZJsYky7F3
fm97skMGcT+f7n76gCzSNMt+7vjRm8gPZ0gi4YP7u/fub0/3PqUB7n+6v31wMD3f3ps8zD7d25/t
H9ybGCo+WTfQsQ0mt0PRzlfvwZbhmz8HnCkdfyB3nv6idVaOXlSt/PJ5nWfw9Aje6DkNjn/xPpRW
5hv560neXuX5smfThNnzg5xclfPt3d1PyeLvfErOGund7d2dA7Kn5A0c7NhpMvoK9MimQy6a+/Y9
Jqv38s/BfH3wXPXlgtwGcZ+jf4qPvPcwu/cwI0/k/kPyeR58Sv5Lfr6zneX3758/zHcPdnIbMvwc
yMltafxTeV2dNaeLVXtt3x2QiJdVAcruMbl69Lh/8Ol+fk5u+S7cv/0D0r7kgn66DcW7c/8+acrp
gaHHm6rNyi8opO0Go8EX70EL/72fVUrAE86nBfSu0ckUaJBZebEmKSimGmSua5il65toNtl7MN2b
Ptzb/vTBlKKNg918e7JLkf1058HD++cHswcUlRqavV4vBsnW/e49KNd5dZB4hiA/R9Q7Lq+y6wZh
PJCTmYTQdqSUfsnWZXuSNbmG+CLVTfAX037/0529fXhaB7MJxZLn5DdkGQW69x/efzB7+PCAPrAx
LgVkL6oOzf/zP/5P/y/++L/hv/z7/oz//E/8OwdJfrff78OH0+z+7s6n2w/hT+xPdsi1pWhne3aw
N9mdksd3f3/vFnpDuv8v/sy//L/48/7CTd3fDalgCMRks2qNEdv5dG+6P31I/vvBA/JEd+if7Pzg
U/IDHu7v3N/Zv3/wIP8mCOJ1ube/c/5pNt3fnrIRm53vU0g3vbed7053H2b7B58SNb5BWng9f3p+
8CC7v7+zfQ+ZtP2dGTl0e/fPSWXtPKCQ9eAg39npms/fX5y1sOu/4S/5L/6ov/M//5P++P/yr/yb
btn17nR2QNkFEvopFCUcSmKCB9vnlL57sJuRX/nAevwd8/r7m58RTP6rP/hP+y//1r/3P/t7/p5b
opHtHhw8zIn1H+4dEP9Pd+9vEyrkRRzs7d1/8OkkP5hZ2lsHM9bxf/Z3/Tn/+R/zF//nf/KfdcuO
Z/sP71PuhYb+6YSSS+fnu9uUsaSExb17B/c+fTB5uL9rw+9Bjfdf/EF/73/9R/7J//Vf8udv5P0u
t+vfyIHRX/ghavjezs7BwYPp9r3z/QOaEVLIE3Jz6bds5x7N0u4k370FGw6iwlk7MaSnr08C1BQV
iykrrrth1vfoN/w1fvT86PnR86PnR8+Pnh89P3p+9Px/5fl/AA==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTO",
                "85a1401c-1e59-4b45-9470-2a1d96fa1581", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
