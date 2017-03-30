/**************************************************************
 * Description:
 * HxRelationshipBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.HeXingRelationshipListUI.HxRelationshipBListUIModel
{
	public partial class HxRelationshipBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(HxRelationshipBListUIModelAction));
		//强类型化基类Model属性.
		public new HxRelationshipBListUIModelModel CurrentModel 
		{
			get {
				return (HxRelationshipBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public HxRelationshipBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public HxRelationshipBListUIModelAction(HxRelationshipBListUIModelModel model) : base(model)
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
		   
		     InitCaseModel();
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
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", "b831d336-4857-43f2-aba0-78974da27eab", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", "b831d336-4857-43f2-aba0-78974da27eab", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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
m49vwo/xR07DxFSTF0WrM/v3KbOQ7dLCBK1OfPpgdm86u/fQX6H6JlwYr/d8ekBLwmQ4yH7Bi925
T3TfR7D3cEJ+9YOD3QOrzb8J78VXHxQbzGaUSz7/FCr9HI4TFh4eZA8+fXjvYX6f3Ihv0nHxun4w
Of/04MEBZzAeIlIhbbp7P9u+T5mLCYW4lMTwl0e/CZ/Fl+xsRgZ05wExN/lJ+/emB+Qy35uQZM8+
zUl5HRzk/ox/E+6K1/s5WRNaAd6Bv0ZO66fkuU0+RWR/MMtn0/2de/mB1WRf21PxR3uwN6X+pvCH
sJZCTvLDTyltfr577yDPp/cpk/jwg50Uf27Ps0/3Hp7vwD+AV7Kfk7Wm8U3z2b1P7x18unPv3Frr
r++f+OqDzMLeDkVAn1KATXHYLvI8JM87+9n+vf1pRikgqza/AffAV9ikKKaUZtomM0FDpdB+e3JO
WvvBw4fZzoQyHOR3fpOeQdcX0L+RqdD0l8zAwaeY19n2p/fOyULukCf+8CFFJNN72c693f0ZeXI2
MnZ+QYjTIB7oRVJzT09fnzBetuPp+QNKtU2JoR/CU5rRei6pVkpAZBkp0v2D+7OZFev3TFW5bo+7
vVLa4f6nSDjsPvyU/JHJ/U8pDP6U2GH6gAxmRmsGEz8Aep/sUr9XMwdKczslnBi6+xPrvL6GbayW
lJU6+g1/jR89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+P
nh89P3p+9Pzo+dHzo+eH/Pyoux89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96
fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+f/+8//Aw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
