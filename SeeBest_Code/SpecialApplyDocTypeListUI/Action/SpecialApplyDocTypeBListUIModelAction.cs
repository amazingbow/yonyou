/**************************************************************
 * Description:
 * SpecialApplyDocTypeBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.SpecialApplyDocTypeListUI.SpecialApplyDocTypeBListUIModel
{
	public partial class SpecialApplyDocTypeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecialApplyDocTypeBListUIModelAction));
		//强类型化基类Model属性.
		public new SpecialApplyDocTypeBListUIModelModel CurrentModel 
		{
			get {
				return (SpecialApplyDocTypeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public SpecialApplyDocTypeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public SpecialApplyDocTypeBListUIModelAction(SpecialApplyDocTypeBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "8ad1006c-5d85-49e5-8fef-491e52a4883e", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "8ad1006c-5d85-49e5-8fef-491e52a4883e", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP+L48e/xblGml3ndFNXys492xzsfpflyWs2K5cVnH63b8+2Dj36Po8c/sc7r65NqsaqW+bJN
i9lnHz3cy+7tfbp7b/vg4MFke39y78F2dr5/b3sv29uf7NzbOd/N9j9Kl9ki/+yj16t8WmTl8WpV
Xj+tpm+uV/lP1NcfpbOiWZXZ9YvNjfJmWherlhH8KJ3n5Qo/GSU0+uyj50XT6gdfvTr77KODbLa7
s/PpdPv+7OD+9v7D/P72wXl+Tr/t5vf3sv2Dg3u5tn9dretp/mxdloLEV8/Onh6Pv3o4Plk37fh1
nj/Jm/Z4RgRqiyZf0OCfnI4jmMY//Sj96uwni/zqaZ1dCKr47avVR+mr/PxseV49r7KZfHGSTef5
R0ePn2RNMcVXTOSdyafn+weT3e1PH9Ag9me72fbk4P797Xvn9x7uTnYnn+49zAyRO+QcJBx1/aZ6
m/Nnr6qqfUrNTqplm79rfzIr1/zqs6Js8/pNNvnJoikmJX32pl7TcE6qcr1Y9j9/XdVt/1OBcvpu
lS1nz/PLvPzso3sGRvdTQOh+dpfI8VIpxeTIpzuf7mUHu9s7B9OD7f3d/U+3J9Ps/van9x9mDx7s
zj59sDN5X3K8rKufzqft2VPvj5dZO8efT16etflCvnry8stVXmd4XT54+uZL883xBTHG07L0/iJI
767xNw3iqzN/EPfPswcHO/uT7b3Z/Xvb+/nOw+2DnU8n2zvEtdnOzvTeZHfvmxzEV2dfVLO8NCM5
f3jwcLafT7Y/Pb//kLp/uLM9uZfvbef7e/ns4YOD2eTeDC89q+qFeWdvZ3JwgJb3J7N8e/8BidbD
T/cOtnfuf5pPPr334NPsXuY6ohdm2c50//xgtj19eH8HEri7/XB3en97dye/P82m9+/fP/+USSMs
8jQ/L5Z5E/4pArCzn+/dP9jfzie7AHRO2J7vTren07179z99eO/TzM04iSnJ3elyveiQLfhigIBZ
TZNmqHxcFlkTvnfWPCve5YTRs6xscvx9XJbV1ZMyW741/N5hfwjWsyIvZ3HpekHEEtkHmal51uZP
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
R8+Pnh89P3p+9Pzo+dHzo+dHz4+eHz03P/8P";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
