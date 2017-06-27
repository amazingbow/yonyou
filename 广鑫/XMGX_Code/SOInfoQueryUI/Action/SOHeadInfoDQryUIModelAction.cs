/**************************************************************
 * Description:
 * SOHeadInfoDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.SOHeadInfoDQryUIModel
{
	public partial class SOHeadInfoDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SOHeadInfoDQryUIModelAction));
		//强类型化基类Model属性.
		public new SOHeadInfoDQryUIModelModel CurrentModel 
		{
			get {
				return (SOHeadInfoDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SOHeadInfoDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SOHeadInfoDQryUIModelAction(SOHeadInfoDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTO",
                "69af66ff-1a05-4032-a01a-b412a5d2c147", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX//LN49/j3aJML/O6KarlZx/tjnc+SvPltJoVy4vPPlq359sHH/0eR49/Yp3X1yfVYlUt82Wb
FrPPPro328nOs93p9r292cPt/cn98+3JvfNPt6f7ef7pvXz28Hz3wUfpMlvkn330+suz5XnFQD5K
Z0WzKrPrF5Fv8mZaF6uWUfkoneflCj/52zfXK2r+9M2X2pZ/fPXq7LOPPn2YnX/66fn59m62c397
f+fe3na2s5ttT/Z397L7s73p7v4Dbf+6WtfT/Nm6LKX3r56dPT0ef/VwfLJu2vGz73z+e49ff/nt
PJsxUvX1k5fh39T9R+lXZz9Z5FdP6+xCcaLfvlp9lL7Kz9HseZXN5IuTbDrPPzp6/CRriim+YrrN
HtyfTCfT8+1smk9Bt2z7IN+bbh9Ms918596n+b3Z1NCtQ6xBClHXb6q3OX/2qqrap9TspFq2+bv2
J7Nyza8+K8o2r99kk58smmJS0mdv6nX+UXpSlevFsv/566pu+58KlNN3q2w5e55f5iUxgoHR/RQQ
up/dJXK8VEoxOe4fHBzsPTi/tz27n4EcB0SOg51s+9OH+cHsfr5/f3o/c2xk5qLHRd4XcRK9rKuf
zqft2VPvj5dZO8efT16etfkCX92jOZjde0D8PCMO2icepsmZfbqdPZwezA4+Pcg+fbCP9l+u8jpD
F3jpfOfh3u5Ovru9e3DvHjHgzmw7mz3cJUnYp5Hc35/NHkw+Sol30Di7f+/Bzr2dve29+w92t/f3
Pt3dfniQP9yezfL7D+7nO/f3Pt1BD8cXJGhPy3KASa3UEItyU/sOje3d9a1Ym1uOFQr/wfPz1Zk/
P7uTg92D2d7e9r3ZgwfbNKD97Yf3pw+37+3s7s4e0p8PPr33vuy6aS6+OvuimuWlmZCDbD8/+HQ6
2/50ukcTMt29T8J9nm8/yPP79/Z27uX5eY6XnlX1wryztzs72Nt5MNnOs/ycUJ6QZjqf3tt+ONnf
J646v7f78Nx1hDk5uP8gn2X59v18Ntne388m29l5Ptt+sPtwsrd7np+fP/iUSSPc/zQ/L5Z5E/7J
xNrPHu6f58TH0517pIomOw+2SQPl25O9nb3peX7w4NP7Dx0z//5P1g0ANU+zNu9xdPfbAVJmNc25
ofdxWWRN5OWz5lnxLicEn2Vlw38fl2V19aTMlm+NZHcEHSrkWZGXs7geeUG0Ey0HqlNz6uepDEC1
Inf8Kiua/GSeLS/y2eklYeqh8GRdlLPvzvM6f93WplsRrKp+XjTU9vQXrbNy9KJq5ZfP6zyDDiN4
o+c0OP7F+1BamW/kryd5e5Xny9708Xzt5fv3pqSCtw9mOTE3zdH2wb2HkM1PH+7s7Z0//HR335uv
13lZ5nV/puzn7zdH5rWfg9n54Jkhs0Zaglosp0LKT/eIvbOH90hyMiLlvfOD7Wx/trd9fv/T2Wz3
fIe++jpmjcVzd5eMI0nmbnaQ0yyRsZjskIzu59Nd0scPJ9Ms48bsDnyU/l75NdMGvzNh9K8TospH
6Rsil36A7vFiu66XfsOzp8GnQjIiBflEH6XP83NYtZq4jNH1JpJQ+G4xgx67f7DDf347Ly7mRK79
nQPmwLs+C0YYcufeND+ffXpve2fnPlmHnemn25MHew+3H8yy2XSS35scHNz3GTIr86f5KqvbBZuA
HmN2v39PBu28/v8LRr13f2fngIzv9jkZXyj7KbHs/v3t6Wwyuz+7/2A2ya3MvyejHuTne5OHBw9I
39+HrXxA0nBvJ9/OD3ZhF84f5Hv3f24ZtTOhH86ws8nu7nT34f3tTw92yH17wH737D7x787u/sGn
9+/NZgeGmvBEqkVegxWyafv7688OkYdbvQfzDgL5/wULT8hm7VCEtZ19OlVXdUJRF/25f29vuvMp
6dy9r8nCOxSBnJMXvL2XfXpAGpYc2of75EpRMHeP9Oze3l7+6c8dCw9O64cz8vl+tr9Lpmr7fEJO
//7ubEoD3z/f/vTBQf7pJJ9SLDK7gZF/fxnjbbjZNP1wllZI/5/k6968kE8toWT0T56n7NOdh9n+
lNTrLoWK+xnp8MnOzqcUNN4n/2NvZ/fB7sSzkGCvrlXkz96D8vpKl8SWnPr3ID1/Kq+rs+Z0sWqv
XeM+NV9WBSi4h36vsusGiQR0J6S7G6HFweThg/P9exloQY7ROVEle/CQ/tnbJX0w2T3f2/dSML//
m6rNyi8og3N9fNKnSufb96NP+PIgpW5gvNsSqs6nBRSCURYUiZNv+WJN0lFMNfeyrqEvr32yRkl4
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
6PnR86PnR8+Pnp+V5/8B";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTO",
                "69af66ff-1a05-4032-a01a-b412a5d2c147", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
