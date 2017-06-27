/**************************************************************
 * Description:
 * XMJLBomChangeBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeListUI.XMJLBomChangeBListUIModel
{
	public partial class XMJLBomChangeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBomChangeBListUIModelAction));
		//强类型化基类Model属性.
		public new XMJLBomChangeBListUIModelModel CurrentModel 
		{
			get {
				return (XMJLBomChangeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public XMJLBomChangeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public XMJLBomChangeBListUIModelAction(XMJLBomChangeBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", "6106f73a-2539-40a4-a7ee-ce91b584b1e2", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", "6106f73a-2539-40a4-a7ee-ce91b584b1e2", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP+Pbj3+Pd4syvczrpqiWn320O975KM2X02pWLC8++2jdnm8ffPR7HD3+iXVeX59Ui1W1zJdt
Wsw++2j26cP9+wf3drc/vbc/3d6fTWfb2b0H2fb+7r3dyezT7NPd/XsfpctskX/20e/9xXeeP6kW
J/NseZH/RH39UTormlWZXb8Y+jpvpnWxahmpj9J5Xq7wk9F4c72id54XTasffPXq7LOPPt3d+fT8
wb1se+/+vYfb+zvZ/nb2IM+3p/nD3cn9g/3Jbr6n7V9X63qaP1uXpXT/1bOzp8fjrx6OT9ZNOw6Q
eXLKH/7+v/fip8vf/4svf3/7xUfpV2c/WeRXT+vsQhDCb0+rq+VH6av8/Gx5Xj2vspl8dZJN5/lH
R4+fZE0xxVdMwOns4OH9SUa0239AGJ/v39s+mJ3Ptveyhw8+3ZvuZg8e7hgCdgg2SCDq+k31NufP
XlVV+5SanVTLNn/X/mRWrvnVZ0XZ5vWbbPKTRVNMSvrsTb2mAZ1U5Xqx7H/+uqrb/qcC5fTdKlvO
nueXefnZR/cMjO6ngND97C6R46VSislxfn5/d+/TvZ3t2d7+p9v7n84Otg8mOREme7C3e57tPsyn
D96XHC/r6qfzaXv21PvjZdbO8eeTl2dtvpCvnrz8cpXXGV6XD56++dJ8c3xBHP+0LL2/CNK7a/xN
g/jqzB/EweR+Nssn97fvnZM87M/2SX6m+9n2/f17k72H0wfTvU+n3+Qgvjr7oprlpRnJ/V1iqN0H
e9sP9nfPiaUOdrYnDw4Oth/c39nbn+5+unPv3hQvPavqhXnn0908nzwgbO8d5Dvb+w/Od7Yf5uck
Rw8/ndz7dDKb3p/ccx3RC5N79z/Ns/3d7cnuDr1wLydJO9h9uL23M/300/x8unfv4S6TRljkaX5e
LPMm/FOIdT6bZvsPp9sPdvbybVAIIjvdJjzOd3anhFj2qSHW02r6oupQzHw2QLaspqkytD0ui6yx
r5w1z4p3OaHwLCubHH8fl2V19aTMlm8Ng3f4HZL0rMjLWVycXhB1RNhBV2qetflTQVY+JnnMiiYX
7TE7vSTcvO6frIty9t15Xuev29p0KTxZ1VB1ym09Gu7unU8+3Z0ebE9n5/e296c794l8NI/3s2w2
2b+/d49oaWgofQOzN8Ui7xCz9+V7ULX77s8BeV3nPytkvveQhPchCcnDe7PJ9v7D+/e3Hx48uLe9
m+3nk3MyfvkDq5ziBgN4jwX5kO43tr55IoZhuCkabPL7S7ufgzn7WZqrg8ne/s6nO59uTx+ck1r5
9Hx/+yFN0Pbs3v298729+w93p3u3nKvxCY3h/SbMvPIhs6Yzf7up+/2lw///zB+5jnsPD+4/2D44
hzt57/zT7Wxnh2zobH+yP9k7eDjdeXiL+Xu9Xq3KIq9vP33eGx8ye7eZONfV/3/mbX9/9/7+wWx/
e/dgj3yfT+/f257kk8n2/emD2d7BHjkmn042z9sX2XJ9nk3bdZ2/qMb+X1/eahY3v/915zSAesPk
Bm1//w4G/5+d6rsdT068/OifzAnkZu7dy/bIH5lM72/v7z3Mt8lpnGx/evAg2z+/t7vzYGZDw59d
x+625PypvK7OmtPFqr2270aI+bIqQMA9pkpv2A937t/fn2YH2+dkeSgOJu94cr67D9fs/Hxnlj28
d+CcBJ6RV3nWVMuoJ2a/eg8ihG/+nNLi4OEuRRK7JP339w6IBSiay/KHn5Jfurs73Z98ei+/Z1ng
58wv/UYp4rrZTJkH+eTeef6QKPMpWbb9bPZgewLPci+neG2X/nxwf/8W5k0E/hZK0W99M+0+zKxJ
u59VMt9E3r3dhzuT6d759r17Oeme+w8ebD/cf/Dp9qcZEZnciIf3P7VB5e18gVuS+P8V3sMPldQ7
u9nu5B7l2O5NJw/I4O8Rqc/vzbZ3Pz04mD3Y3bl/fv82jtp3q/rtyzKb9iT/dq/8bBPb6+vnlNr3
SaWe7+zsbe9NppQVOyDr8nDy4P72+YOHe/cO7k3yPLPpwg2koz7bn2i7GdhbvfCzTWnb088pnR/u
3t+jmPHh9n0KIrf3c0pBHsz2kJXKoLh39nankx+5sT9ns7O3c3AwvTfZ3ptOSAp2Pz3fpmnZ2/6U
Ml2fPtidUNL8/vvMDpCs6a+eD/reL//w58Xv/ud0Uqb7D3c+PdhF6v4euTT7OUV+0wllXO7n55Ns
516+d+8G1dSha1aj468zI/bNn4PpMH3/MOfibicWw1JL5A9ZYYGMZLv3ts8/nVBi5ZzWCTKsUGQP
Huw9nDw82Jneu12u+Fbk/ca9cIw2GB79kq3L9iRrcl1bkzi1Cf4SV+XhvQcUhOTb+X5Oodmnu59u
Tz4l1/De3jS7N7t/kD10OaVYRPqf//F/+n/xx/8N/+Xf92f853/i3zk4+rv9frOH59lkQosjMyzv
7VN8uP2QVkm383uULHlwD0scTl1tIvl//if+Wf/Fn/u3/Rd/5t/xX/+Zf9v7IDCd5ff2dvf3yGGg
5ZV9isu3JwefZtuz2Sy7/2CHkte7t3GHxYQHGP2Xf9/f85/9vX+H4vVn/NlEmP/qL/7jxvjtT/2D
3wfDg/M8p9hntv3pp/tkb89pBSM7P885bTA7P8jOaR3jlhjG0rWb0BzLB++D7fmns/v3dg8mFOMT
FffJGm1P9s8fUobygNZhHuYP7u3cxgsbCC/iyP5n/8Cf+5//PX/af/6n/xHvg+guFpd3z8+3H3w6
m23vfzrd2z7IyE3fI+386TktDN1/aFcib6HdNroxPtr/1d//Vyja8tsmnO+GQmvkmTWazSuJ/O6d
Z7QeSQube+cHWH/Jaf2FMi27swdE8/vnn2bT3W9Cfr0u9w4mk3v7D3e3H06zGdLQ2XaW3T+ndCat
Izyc7t3fmbnohgkWzeYIVf7zP+Ev/M//3L/olj1P7z/ce5Dl1On9Gfk4+Wy6ne2T5tg7uE/rF/u0
yJffLndyW6Xh9f2QshP3873729OHGfH3g3u0Cv8pZbPynf2Dg/PdWb63M7kFfw/FdHEG/8//zr/8
P/v7//hbYngvO5iezz6l5YEHBxTg59N79Nv93e0H97KHWb6/9+nO5DYaLR4HDeD3J/7J9Md/8af/
Tf/1H/knbuTnLgfr37Baao55CHl+fkCh24ySY+cIMe49JKVMQV0+uz8jG3w+Pd/rJArf1xCjK/EX
jl+fBLgpLhZVNp53f2Kd19cn1WJVLcmAH/2Gv8aPnh89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj5
0fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3r+3/v8Pw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
