/**************************************************************
 * Description:
 * XMJLBOMBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel
{
	public partial class XMJLBOMBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBOMBListUIModelAction));
		//强类型化基类Model属性.
		public new XMJLBOMBListUIModelModel CurrentModel 
		{
			get {
				return (XMJLBOMBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public XMJLBOMBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public XMJLBOMBListUIModelAction(XMJLBOMBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", "c486b4dd-b98d-4647-b5ac-3a4c55c61bce", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", "c486b4dd-b98d-4647-b5ac-3a4c55c61bce", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv3n38e/xblGml3ndFNXys492xzsfpflyWs2K5cVnH63b8+2Dj36Po8c/sc7r65NqsaqW+bJN
i9lnHz3YuTfLdg/Ot/c+fXCwvf/g/sH2wb29h/Tbp9leNtndOfh08lG6zBb5Zx/93l985/lP1Ne/
/5Mvv/gonRXNqsyuX0S+yZtpXaxaRuWjdJ6XK/zkzt9cr6j586Jp9YOvXp199tF0n3rZn822Jw8P
Ztv7n+4/2J7cz6bb97L96f370093J9Nc27+u1vU0f7YuS+n5q2dnT4/HXz0cn6ybdgw8xk+qxeLJ
KX/w+//ei58uf/8vvvz96bMvsmL5UfrV2U8W+dXTOrsQVPDb0+qKvnmVn58tz6vnVTaTr06y6Tz/
6Ojxk6wppviKCXbv/vRg995kfzt7eO/B9n72YG97Msvubc8+3b1/MMnPZ/cmmSFYh0qDpKGu31Rv
c/7sVVW1T6nZSbVs83ftT2blml99VpRtXr/JJj9ZNMWkpM/e1GuiyklVrhfL/uevq7rtfypQTt+t
suXseX6ZlzQgA6P7KSB0P7tL5HiplGJyZPsH2e696afbs/PJdHt/P7u/fbAzebB9Psn37306mT3Y
/XTvfcnxsq5+Op+2Z0+9P15m7Rx/Pnl51uYL+erJyy9XeZ3hdfng6ZsvzTfHF8ThT8vS+4sgvbvG
3zSIr878QZx/evBgcm9yvr1/b3qf+O/+dDs7v7e7/emD7N79g/N8dvDw4Tc5iK/OvqhmeWlGMtu/
P5vt79zfPp/tEQ755P52dn/6cPtg72GW7+ztnOcPP8VLz6p6Yd7Z+TSf7Z4TyvemOxNCeZJvPzx4
uL/96cP8wb3d6fT+g08fuo7ohf3J7sH9/ZxemD24t73/MNvdnhxA5PLdye7sIJ89nOwxaYQZnubn
xTJvwj9lxnfPD/bPd+9t35vcJ2Hd2b+3fXDw6XR7ej97MCO4+/vnVgCeVtMXVYdi5rMBsmU1TZWh
7XFZZI195ax5VrzLCYVnWdkQM3d4G1LzrMjLWVd0fiqvq7PmdLFqr+27T7M2fypoibRT11WxbD/7
qE8FkXsaN5Ep296dZvvb+3sPZ9sPJ1PikXv44P7+g4ODB2bYX2TL9Xk2bdd13ht+97v3IEPn1Z9T
ckym96fZg918e/fBDsn93s7D7exTMiMP750/3CNeyrOZ5QIgUBPePVoEX7wHIfz3fk6pkN3Pd2cP
d++TCZiSUBELbD/c3X2wffDppw/yg+l07352bmWhaCbrusmf/D5dgfC/eA8q+O/9nFLhYX5//9Pp
5OF2fj87gA79lPTXp6Qgsvuz3cn5AUyj5YWsBtAuI9hP32P89qWf08HnDx7m052dT2n2H9I/98hs
PCRNsX3/Xj6ZfrqTTe9Nd61e6CmD92T8L36uGf7e7qefkpyTuc+yHTL3O2RF7j/c2T4/n05mk538
YT6xo32ar7K6XdAougzvf/Eeo/ff+zmlwmSyv38PBJjd3z2HLSWDnR/k22RIz+9/mu3vPsgsFV63
WbtuOhSwH77H6M07P7cjv7ezm+/eJz3/8NMHCBLy7YP7OWm9g92d6cGDB/em96yoG/0UkffOV+9B
hfDNn1Na3H+Y3cv3yAQ+OCChp0iFaLFzsLM9JY9g596Dg93JXo8WT36f8Ql5ZIMWwHz7NSjy5Pf5
/eXln1OikBe483D/4WR773wGX5aE5ODTnF3p/YcPJg/Pp/ufOnU4jjmI3sfvQYYvqt///w1u4oMp
RTz37u1t379/nzyCnYPp9kG+Q6py78GnxCb3HpJF6CvIKFP0vn0PariX/9/AFPcmk73d3Xv725Od
GZEiy/YoybD76fbuAVmNnd1Pp7sPJxGiYEzDRNFvvx5R5OUfJlHuduIqRNeRP8SnuHf+4MHBA3Ku
9/ahZSd72yQ7n27f24enkR08zB86KxuRoPcky4eJzd0e+g/unZPfS0kAilv3tvdn98g8fpofbOfT
3X1yHx58upvbUOnJugEJGpDvg0YRAvrmBrMz3c322bl9+IByA9O9/e2HlBDYPt8hV+/ebOfBp/tW
yw8GOu83lG8ivAHHBSxGv2Trsj3Jmtz9wSxpg3wZ72RGGYQHD7Y/PaA0yP7De59uT0hIt0l9zSb3
snzv092NvPef//F/+n/xx/8N/+Xf92f853/i3zk4bKskpMsHO5Q7uL+zfS/fR2hNuYWDexRf7+3e
n2QU8B7s3L+ZxP/5n/RH/ed/0h93+07Pd/aynZ2D/e2dTx/QOB9QZiSb5DOyVuTD3/8UrJpvDlr+
q7//r/jP/4I/9pbd7c32Hj6c7j/c3jtA+oWyrtvZwXRv+8H5QUaf3783ye0Yoy7jf/nH/B3/xR/0
B9+yt/NsN5vu7E237x9MKUczpfTMw3vZ+fbswez+zn2K2A92bUJrg5v2n/+Jf/J/8Wf82f/l3/z3
vsc4Hz58uHc/J355QJJCNLy3/XBGiEwoRUSJ3P2DBw8PbucUSef/2d/z94z/q7/tr7j9vD7ceXiw
swOLO9vLoXwoMUEpyu29yd7e3qeTh9PZ1CYmBhyQ//JP+wv/s7/nr/yv/oa/hHj5P/87/3L8+yf+
nWP5cUss9u7dm+6dT3a2d+4/pGT6AaHyMNu7t51PJpQwOt/dm0wsd212A4DAn/CHjEmg/su/6LbT
P3twTmkJovre+T55pjuf7pITckA0mE4eIH138HDPOmGb7a32/p//SX/8f/lX/k2ber/bVSn2A1Y4
d8Olh6Pf8Nf40fOj50fPj54fPT96fvTc8vl/AA==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
