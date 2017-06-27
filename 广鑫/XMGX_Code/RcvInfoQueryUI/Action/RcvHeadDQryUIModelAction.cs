/**************************************************************
 * Description:
 * RcvHeadDQryUIModelAction.cs
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

namespace UIFIA.U9.Cust.FJGX.RcvHeadDQryUIModel
{
	public partial class RcvHeadDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(RcvHeadDQryUIModelAction));
		//强类型化基类Model属性.
		public new RcvHeadDQryUIModelModel CurrentModel 
		{
			get {
				return (RcvHeadDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public RcvHeadDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public RcvHeadDQryUIModelAction(RcvHeadDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UIFIA.U9.Cust.FJGX.RcvHeadQryBP.RcvHeadQryDTO",
                "24bda083-7049-4d72-ab22-97a3c9da313e", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf+p3ffx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uez/YMH59PZ+fbD852D7f1703vbD3ene9u7D/fy3Xx/dy+/9+CjdJkt8s8+ejW9PFueVwzl
o3RWNKsyu34R+ypvpnWxahmZj9J5Xq7wk799c72i9k/ffKlt+cdXr84++2hvfzLLdg7ubT/Y2X+4
vT97sLedTfb2th8+yO5NH86ye7v3cm3/ulrX0/zZuiyl+6/Onp0dj796OD5ZN+342Xc+/73HhNG3
82z2E/X1k5feH9TxR+lXZz9Z5FdP6+xCsaHfvlp9lL7KzzGK51U2ky9Osuk8/+jo8ZOsKab4iml2
kB/cezjJHm7P9s/z7f3z+9n2wc69B9v3JnsHDx9M7j3YPdgzNOvQaZA21PWb6m3On72qqvYpNTup
lm3+rv3JrFzzq8+Kss3rN9nkJ4ummJT02Zt6TSQ5qcr1Ytn//HVVt/1PBcrpu1W2nD3PL/Pys4/u
GRjdTwGh+9ldIsdLpRST48H0/nR3P9/d/jQ7P9/ev783286mD2bbO5N8f+9g9979A0cOnYg+9+in
ceK8rKufzqft2VPvj5dZO8efT16etfkCX032Z9O92fnudv7g/s72fp7Ptifnnx4QO2UP7u9Pz7NJ
nqP9l6u8ztAFXtrb39s5yD6dbe9Nz2fb+3sZIb+zv7e99+DBwV5GE/3p/uSjlLiGe5g8mD789Hyy
fX/3YLq9/5CGO8nv726fkxTtTx58uvvp/hQ9HF+QeD0tyyHGtKJCrMlt7Us0uHfXN/MzNxsrCP6D
5+Wrs2Bedh7mk5396fbebOceifbOw+3JZG9neze/T1MzmxycP8jel003zcRXZ19Us7y00zG9t3dv
b3J/+9Pz2afb+7sHOREr29s+fzi9t39+MPs0ezjDS8+qemHeyfKHk4P9/AFNHOmB/eweEfj+/r3t
2fmDTz/NPyVtsD9zHaGTbHJvuvPwYPte9imJ4s7+zvbB9N7B9s7D/Qf5+fTBQZ7tMmmE65/m58Uy
b8I/mViT/Qf3iE2m2/ke8c3+7i4Ra+fBPdKD02k+u7+b3du3evDJugGU5mnW5h3Cdb4aIGJW01Qb
Sh+XRdZ03zxrnhXvcsLrWVY2/PdxWVZXT8ps+dYIckeuoTGeFXk5i6uNF0QyUWogNjWnfp4K6qoE
ueNXWdHkJ/NseZHPTi8JTQ+FJ+uinH13ntf567Y23Yo0VfXzoqG2p79onZWjF1Urv3xe5xlUFsEb
PafB8S/eh9LKfCN/Pcnbqzxf8qzd7UybaKnonzyL97PJ/QcP83z73u79ffBctv1wdv8+mbRP9+9P
zomfsh0zi2+qNiu/IEvYtWXBF+8xg/573fm77Vz9VF5XZ83pYtVe23d7MwXJy6cFbL188LolfUaa
58V6kdfFVG3XuiYkp4TMy6rAPO4xSXs0Iy2WZQ9ziNt98gDOSU4f7swm29Pd+w8OsgcPDw6mVk28
Xi8Gydb97j0o13n1/6XEOy6vsusGzgFwE1zAox2mpF+yddmeZE2ujoMwcRP8JaS/T4SeTqbb559O
drf3p5O97YPznQdkix6e700fTGbn+/uG9E+r6YuqQ/L/4k/7O/7zP/FP/s//+D/9v/jj/4b//E/8
OweJfjfS9afZQX5Oftb9/FOSlIOHs+2He/vn25+Sjft0P8uy2fnsFvpO+v4v/sy//L/48/7C9+l+
b7K3++nBzqfbDw9I5+7vfzrdzrIH2fa9h9nebv7p+f0HM+szvF6vVmWR1yekwTrd/2f/wJ/7n/89
f9p//qf/Ef/l3/dn/Jd/0R/8PhhMP6WB5vuz7Slpd+L9nT0yOuTJ3XtwnxzO/U8n2YN7XQzQ6RAG
//mf9Mf/l3/l3/Q+GDz4dO/+/gMyzbN7UxK8++SEZLvwJvYf7J7ns72He5k1OSesM2dPukL3n/9R
fwdNwX/29/w9mzq+G3KhYVBmW6tFRX/u7mekKB9u7+6dE1fs5zvbk08Pzrfvkb97f+8eGeTs/jfE
kF6vxIt7O5O9CTkqu9Trpw/JiJ/fy7Yn2XTvYLa/N8kOvkle9Hqm6ObhdI+kYEZ8qExATj15f+Qj
fTqb3b83tT1/M2zodb77MD+f7N8jt2XvnOZ/d+/+NnmRRGzydCiwOCAf2hqrb4YDvc7vHZxn5w/3
dylo+ZRU/052jzo/2N2eTie79ya7s4cPp7v9kS/bbNpuwuG/+oP/tP/yb/17b+BHfwImDyYU7t3b
3pnOHmzv5xkZ7HvTbPv8wc4s38keEl9YGRi0PP/1H/kn/9d/yZ9/yx4fTnYPPp2xG5yTW3pOs008
9nB7SgHvwcOD6fmnmR34B0mdL1bTvcnuPgn5dGdKkS05raT3KNKYTA6mM3Ja4aqaPr/IF12p+s//
sj/yv/hb/6qNEt6Vaf0b8Rv9hR+MyPmn+wf3H85I6z+Awbn3kPzr2ZT83YPs4f179/cPZgeW5TZI
2iAqHHGKN3n6+iRATVGxmLJ5vBtmJI5+w1/jR8+Pnh89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj5
0fP/AA==";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UIFIA.U9.Cust.FJGX.RcvHeadQryBP.RcvHeadQryDTO",
                "24bda083-7049-4d72-ab22-97a3c9da313e", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UIFIA.U9.Cust.FJGX.RcvHeadQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UIFIA.U9.Cust.FJGX.RcvHeadQryBP.Proxy.QueryBPProxy proxy = new UIFIA.U9.Cust.FJGX.RcvHeadQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
