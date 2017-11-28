/**************************************************************
 * Description:
 * AdvApproveBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.AdvApproveBListUIModel
{
	public partial class AdvApproveBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApproveBListUIModelAction));
		//强类型化基类Model属性.
		public new AdvApproveBListUIModelModel CurrentModel 
		{
			get {
				return (AdvApproveBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AdvApproveBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AdvApproveBListUIModelAction(AdvApproveBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", "5e7ff1a5-d073-45f0-a5ef-9b9f89c5531a", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", "5e7ff1a5-d073-45f0-a5ef-9b9f89c5531a", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP+0P/jUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mH320fTBdO/Tnd372/v3z8+392f72fbkfOfT7Xu7nz78dO/B+d7D8/sfpctskX/20fHs8ni1
qqvL/Cfq64/SWdGsyuz6RfS7vJnWxapldD5K53m5wk9G4M31il54XjStfvDVq7PPPrqfPzg/383u
b892HtwDNjvb2f38fPvh5OH5wcPp/fv3djNt/7pa19P82bospe+vnp09PR5/9XB8sm7a8es8f5I3
LSGU123R5Asa6pPTcfC3oiof2z8+Sr86+8kiv3paZxeCJH57Wl0tP0pf5edny/PqeZXN5KuTbDrP
Pzp6/CRriim+YnI+yO7tzvbu728fTPb2tvenDz7dfrg/2due3Xt4vvMge3jv03szQ84OBQeJRl2/
qd7m/NmrqmqfUrOTatnm79qfzMo1v/qsKNu8fpNNfrJoiklJn72p1/lH6UlVrhfL/uevq7rtfypQ
Tt+tsuXseX6Zl599dM/A6H4KCN3P7hI5XiqlhByTnfv5JL+/Pdn99MH2fvZwbzu7N93b3t072J9m
e+eTe/vT9yXHy7r66Xzanj31/niZtXP8+eTlWZsv5KsnL79c5XWG1+WDp2++NN8cXxATPC1L7y+C
9O4af9MgvjrzB/Hp/Xv3pw/v7W9ns08PwJn3tw+yTyfb9w+mswf5+d4ku599k4P46uyLapaXZiTn
2eTg4eTBbPv84acZJHR/++GD/YPt7GD3fHf/Qb57L9vFS8+qemHf2dnZO793sLud7U9Iqvf27m8/
zLIH27v3SJQePLg/2X1w33VEL+x+mt2bTPYm29N7M3rh/oTG+OBgZ3tn8uBhdnB+8CDLcyaNsMjT
/LxY5k34p+iT6e4Otd3bfjg9J2I9nBKiO7PJ9sN7k+x89+Esm+1ZYonsldcQ26g6sV8NEDGraeIM
pY/LImu6b541z4p3OeH1LCubHH8fl2V19aTMlm8N13eEAOL1rMjLWVzGXhDJRAOA2NQ8a/Ongrp8
TEKakZo5mWfLi3x2ekkoet0/WRfl7LvzvM5ft7XpUhi1qqETCcDRY2I/arGcCk13798/p+n7dPvB
7qekGrPzKc3mvZ3t2f3ZvXv7s8nDvYcP35cBweA07wcP9mnGJp9unx8QX+0ffDrdntwjBj8/mJJ8
7p7nu/kON2Yd/VH6e+XXTBv8zoTRv06IKh+lb4hc+gG6x4vtul72G3qfC9GIGGSqPkqf5+fQKnXe
iCXzZ3Ns3j3/bjGDqNw/ENy+nRcXcyLc/s4B8+hdnysjPErS++l07z4ZuU+JM/fPdz/dPrif3dt+
mE8/3f/0053zh7tWSb9us7rFHHcI63/+HtzpvfZzwJrS8YeyZ1cNiNzv78+yvdnedr5L7Lk/2yF1
+WA63d7LoeNn0/1793b6fsTTagrMBn0J9/170Djy+s8BrX+W6HzvYO98f7qbbZ9neznpV3KYHh5M
PyWK7+U7OblOk9xaVBo+8Vu7bjr09T9/D7p6r/3/h57n98/JPwO3Huw/JEu5Sx7n+e50+5zU6mz/
fGdK3xl6ni5nEU3gPn0PWtqXfg4o+bOoBchIPbz/kJQqmad78Dsy0qwHk+29B7NJ9vD8Xraf3fO4
80XV50z+7D0oqa/8HNDxm6FhYKzIoxJvO/onk3hy8OnDnb0HpAAOELB9ev7p9mR68HD73v39nYcP
yRs4f5j/HDpYt6XxT+V1ddacLlbttX03QuGXVQGq7jGperTYu3fv3t6DfLK9Q1YHnvlse5Ldu0cu
zL2D7P79fJeEuG90ntPr4+fVlEODQdPTbfXeFDJAfn8H5OeUWDufZrvZg4fk8Ewm9M+nB/e3yQ/K
t6cPzrN7Dz8ln2ffymaHDCfVetluCPk7jb4+qSyMn1NKnZ/Pdg4e3Dvfzib7ZFmzvYPtg+ne+fbu
/Ww6yw8mO5OHg5QioeBBkP7I4AFvpFiv8QdQrgvr55SCk/uz3fsHD+9vfzojDtvfmebbD++Tw00Z
nml+kFM8Mxui4Ku8fJlXq/IG2vnNvj7VPCg/p/Q62Ht4f3JA2a7Z3jmljfIJxfiTe9Pt+/co8Kac
HKl569VFCDGnfN7N5NJWH0YtAfJzSqwHe59OKSGyt703QabwwcN72wfnn+5sU3pkJ/v04CGFw3sb
xPN4NkN4ebNouoZfn2QBnJ9Tqj188GC2N9mdbM8me7sUOByQUru3M9ve2ckn5/n5zuzhg08HqMbh
9mZ6mSZfn1IK4WebRnU+LZBaMGkHsswkWS/Wi7wupvIh/THBXzfz4fmnlBbc336wv0u5k4czcjwe
3HtICd/8/vTT6c6n55NOqsuS6828mL7dTFHT5OtTVCH8f4iin97fzfcP9ve2yXcjs/Ep5bgms4yS
kg92d2afTnf3ZwdD/pzkgDaT1Lb5+jQ1IP4/RNTp/jTP8h1KxdzboQiXwjOKzijW3Zsd3J/tTx/u
ULZ3gKjHdZ5tJqm2+PoEFQD/HyLng9nOwx3KodMKzw5J/TncxNnDfUoYPMg+Pc+n2f1YokuIhbCJ
PpM85kayhi0/gLwBoJ9tMm8kHEUc57OHezNaGcgg3BTCTnayne3zvXv79yhJOMk+HfJxMICsrou8
voFsfrsPIJoH5ueUZPks2znP4BY++HRGq4lkuCefzkgpUkyyM5l+und/0GbzxP9Ee0PM5rX6AHJZ
ID/bxPoGxTi/l3862Zne257OZgfInu7Soh4ygDsHE1pxvvdwku8OkPYlgb9Bfk2Tr09UhRBS9P/V
FJ3k+Q6t9+2Iidmf5eQJPSQLfu/T6TQ/v/9gf7I7FPO9qdqs/IIiixvYNWj39Wnrg/n/EIGz/f3d
nSnl+nce7hGV751Ptg9mD/Pte9n9851PH0wf7D0csjyv8mlOtKKebgoTvXZfn8A+mJ9tAm8Oeiht
QwvPlI8+h4t+QOFPdv/TvW2yQzsPdibnB7ScMkCyL6pFNzsdb/H1ySQAfk4JdH9v/9PZbHJve2+X
HJn9HH4NSTEMTk5sdbDz6cN8yMJM23VW6ic3W5p+669PuD6wn20ifoNivDu7t7NDTiT545RT3N9/
cE7ZxZ2d7U8PZvm9g9mDh3k2FDbKuG9hf8KGH0ro/+/Zok/JuJ/v3L8HBUn5tB0y8dnB/d3t8/s7
+f0JOVLne3aFv0M6wmqKPOpmAnutvj51HZD/D5F2N6Og8V6+t01rBxkt8X36cJuWpHMK1O99uvvw
4f29+7OhGF1/v4Wh77T8+iQOAf1/iMyT+/f29mfkTe3s55Tk/HSHVmsmk+k2fFZa3ZrcO7835E3R
n2e8YnlDqKSNPoC4BsbPNl03r2uRQZ/OKGO+u78HG79Psn4+28dK4N7effLnZ7sRfUrLxgA/SCT3
/deij33955Q093f38/ODGa1h7R1gfXQnp0z5g53t/NOD6XQne/iAzLu3HA+GXXcT4/7n70EK77Wf
UxLsHdwnO0Ae4IQW9Wix4D7S3rNse48oQ//d2znIfRK86Pp85rP3G/qLH7Jfd9cfd3P0+HVVt5E/
mCIUN3Dsuz09f0ALAQcz0iwZeSKTB5RUOJ+QWv/U2sYYRX6oxMDYgsHQL9m6bE+yJj96/CRrCnqv
pEXPJvhLLNWD84e0qLa3fXA/IydgdwdLRA+n259SfP/w4XTv3v2H+6FiKK+xXtMZ73/+x/wF/9nf
88f+53/ZHzY48Lv9vs8PHpC6JqV0cG+XJO+AlqcmD/PpdrY7Pc/OyVLen1q2IzmhAdIMdzv++/6g
//yv/GP/iz/zL/8v/ry/8H36/nR3ei97sDfdnmGNf5+Guv2QZnh7cm+yc+/hzsEehYq3VYj/+R//
p/8Xf/zf8F/+zX/vf/4X/LHvgwNllvOHn36abc9mM0r23T9/QJaLpmJCKD3Yf7C3u+OU8pDm0b7/
mL/jv/iD/uD36fvgYPJgJ5uQSzKhlft9Co+3aT360+37u7Msy6a0YrNnE42ny1mE8v/l3/un/hd/
/l/4/pTfm54f5A/ICu1SR6A85esOaEF3tnNA8dSn073Z9HyTaOmI/74/4z//E//OTf3eDRnfyATr
gMYoQcFob0bq7+HB9oyYbnt/nyK9h+cHD7dpfWV2cG+aP6T4Y8CNeF5NM/TdxfHv/gf/8z/5j/kv
/qK/67/+0/4gwve/+ov/uPF//sf9PXf/8z/hH9yEsYcS6eNPz8+n5EBODyaUJ9rNKPO2N9kmkTg4
n8ymu5860eigdAJvue76jhGM/rO/+y/+r//0P/KWCD2YHOzuZveRs6J0Ff1DielzQu0hzeVs78FD
WjwZRIjUBSOV18DlZsT+87/hL/kv/qi/8z//e/7M//xP+uNvid7uLnFvTonyh/dyJNcOMlq/uUcK
bUKrYff3kMIYylRiwT6vVuUtEPuv/uA/7b/8W//e/+zv+XtuiVU+3d99eDC9T9r00weUms4ocbA3
fUizuDvZe3Bv99NscBaB1Zwc8tsi9V/+aX/7f/U3/vm3xGvn/uTeg737xOufIkk22d/ZPqBc73Y+
me1SfL0zy/YPNkymW/O/3UT+eX/Tf/7n/0G3RG2XVjloIkkR3SedsD/L7pFL/ymp6Um2k9MEPzjf
H1oAia3AR5H6+2+JS7Z7MM33s4Pt6QERh6I4WhTcIac5I0X18N6DT+9le0MrC7G16xguf8Kfc0tc
Hpzv7t7/9NP7tMz76adYR6e85sGnk+372WR3Np3ee/jp+VCwHl31jSDzX/+1f9YtkZnl57RKRVxz
/945IZPRetXBZEr6c5ITnvvn9/JsMLztr5bGUPnz/5L/8q/8G2+Jzd4DWry9R6lLogJN0wNC5OD8
/v52nt/PHxJHT/fyyfsvNsZmiz+62fL4krY/e/jpbP/e9mxKzuT+3vnB9sMHpNYPyOx/ms/2KL21
977reYOY/Vd//9//n/39f+otMcsOdh4S6+xsZ/vkd+zne/dJd06npAj27ufETA+nD60ZjlGtn8yM
4PVf/Ol/03/9R/6Jt8VoMjm4d/88o8iLYvj93YwC+Yxwm073Jg+m+cHD6d5Qzi+W7YuR6Y//0/+z
v/e2U7d7jxa99vL97dnePvkps31i8oOD3e37D3bu7+7cpwTkp/n7LtXEWP2P/JP/67/ktop7/+He
/Wy6+2B7N98lVs/hMT94SIyV7z/YpZTd7mxwrXNwdSM2bX/a33ErF8vH7Pzh+ZREbfvhZJ/0NuXF
tx/ukHu9/4BWYx5k2YP9+0P6KbKIEJu7v+yP/C/+1r/qltgc7O1RYignH+UemZL9+2TlJtnDh9s7
Dw7OSfR271O+4+tl7KMG5S/4r//sP1w+ei+Gv7f3ILu/S1bl4cEBUYrWVEkYd5GUebi/R+y/S87D
eye5Y9Np/rg985OdneX7B6TSZ59iEvcn4rnMpjNCM98hDX///XLDMbz+mD/rv/ij/9L/8k+4rQ+6
M82IXrv3kLWiJNbs/t52NqVAYvrgXvZwer77kIKH98+qDhLsvSRzlu+e5xNy8CbZPhEsn5K2uHdO
qaQH+zl5pg/vf3p/KIawGcIbGY0/+q//4r/7v/xz/4ZbopVPd3fynQf3CZkcoQ25DQ8fzna3yfDc
z3ISjnzHkuxDQ0yv2/P9B9nOATkIFNlS+EJ52u1sj+SPgu2M1mR3Z/d3N6ZPbh3jdaO6p/k5/kY2
RJM6jM/DB5Qpzihwyc8p3KRkMdk5CveJfT4lLbGfTUmBfq10DnqQZNPT09cnAU6Kg0WRkzF3f2Kd
19cn1WJFnLhsj37DX+NHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR86PnR8+Pnh89P3p+
9Pzo+dHzo+dHz4+eHz0/en70/Oj50RN5fvTRj54fPT96fvT86PnR86PnR8+Pnh89P3p+9Pzo+dHz
o+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR8//95/8B";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
