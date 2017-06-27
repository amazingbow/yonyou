/**************************************************************
 * Description:
 * CustomerVoucherDQryUIModelAction.cs
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

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherDQryUIModel
{
	public partial class CustomerVoucherDQryUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerVoucherDQryUIModelAction));
		//强类型化基类Model属性.
		public new CustomerVoucherDQryUIModelModel CurrentModel 
		{
			get {
				return (CustomerVoucherDQryUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CustomerVoucherDQryUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CustomerVoucherDQryUIModelAction(CustomerVoucherDQryUIModelModel model) : base(model)
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

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.CustomerVoucherQryDTO",
                "6de4cc91-9677-4aae-9880-bd1282141a4a", UIGrid.UIView, UIGrid);
                
            dtoQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP3z8+Pd4tyjTy7xuimr52Ue7452P0nw5rWbF8uKzj9bt+fbBR7/H0eOfWOf19Um1WFXLfNmm
xeyzj+4dPPx07+G9ne2dKf2zv3f/3vbBwb2H25PZ/b08n2Wz6eT+R+kyW+SffXSybtpqkdc/Wa2n
87xmaB+ls6JZldn1i01N8mZaF6uWkfsoneflCj/52zfXK3rv6ZsvtS3/+OrV2WcffTrL96fTh7vb
Dz998GB7P8vy7YcHBzuE2u7ewd7u/m62n2n719W6nubP1mUpaHz17Ozp8firh2PgM372nc9/73EX
s/r6ycvIh4TIR+lXZz9Z5FdP6+xCsaPfvlp9lL7Kz8+W59XzKpvJFycZvfbR0eMnWVNM8RXTdP/8
/v3JdOdg+2A3O9/e35892J7ce3CwTZ8+PM+y8/2Hk3uGph36DdKKun5Tvc35s1dV1T6lZifVss3f
tT+ZlWt+9VlRtnn9Jpv8ZNEUk5I+e1Ov84/Sk6pcL5b9z19Xddv/VKCcvltly9nz/DIviUkMjO6n
gND97C6R46VSismR3Z/sTM7zbHt3dn9KLLaXbWfnk3vb2f3p/QcH9+59uvvp/gCLbeauQWK9rKuf
zqft2VPvj5dZO8efT16etfkCX32a35/sPsgfbM/yB8T6uw8m2wfTycPtvYd7s+z+Q8Ju9xztv1zl
dYYu8NK9e5ODew+m+9v7D/Y+pcEcTLYnu9lsO/v0/jTbOX94bzI5+CglLkLjvXvnn052HuxuZ9lO
To0fgnk/nW3fn+5MDnZ3z+/NznP0cHxB4vi0LDcyLjM68Sw3tm/R6N5d357huflYQfEfPGFfnfkT
Nv00239wnt3fnp5/eo/QvkcDmJBO2N3Lzx/ce7C7c7Aze1/+3TQlX519Uc3y0s4Lic69h/u7259O
84fb+/fznLo/n2zf+/ThQf6QhH+2k+GlZ1W9MO/szia796YP72/fm2Iu88kBsde9yTbR/eGD+7P7
9OKe64hemM7u75yfT3a3H8we0NScP3y4nT2kmbp3cDCdPbi/fz/b22HSiDg8zc+LZd6EfzKx7lMH
xAF72/f2Wdj3z7cfPrx/sL0/zWZgsIPZw90udw+w9TDxspqm2lD4uCyyxn/rrHlWvMsJl2dZ2eT4
+7gsq6snZbZ8a6S6I+RQH8+KvJzFdcgLIpNoOBCYmmdt/lRQlo9JCWVFk5/Ms+VFPju9JPS87p+s
i3L2XWK6/HVbmy5FjKr6edFQW1KaxHLUYjkVOpJcENtNiemyfRKs6T5NHnHB9qf3J3n2kET0/v1P
35fpwNRgjuxgb3//3nR7ZycjBTQ5mG5PHk53tnfz3U8PzrMd6muPG7PZ+Sj9vfJrpg1+Z8LoXydE
lY/SN0Qu/QDd48V2XS/9hmdPg0+FZEQKssYfpc/zc+jMOm/EWLt5JAy+W8wgE/cPdvjPb+fFxZyo
tb9zwMx412e/CDPOHu5NHu49nGzvzXZ3SXLPSTHlu/e27+/tTvYePpjOzmfWmj9ZN2DpBnPbIWjn
q/dgyvDNnwPGlI4/kDlPf9E6K0cvqlZ++bzOMxhWgjd6ToPjX7wPpZX5Rv56krdXeb7szxrpELGl
0T95Fif792b3Hpzn2w8e7pIC3L33gHwysjYPdme7+w9IGvYfPjSz+DSfFO0X5M91PbHgi/eYQf+9
7vzddq5+Kq+rs+Z0sWqv7bsRFfKyzqcFhMAICFnZ6UfpizVJQzFVD2tdQ0cQMi+rAvO4xyTt0eze
w93JLinb7Xy2S2r43sE5GQDi/NnsfH8v25ve+/SepdlJnc/iRAu/eQ+qBS/+f4hspBTIVb1PFjab
ks0iOm0/zD/Ntmdka+/t7x5MDnasb/Z6vRjktu5370G6zquDxDME+VDqWXocl1fZdQNnHt3J3MRo
9ClJ4cN7+f3t7ODT++QqTLPth/cyWJNzcoYmO+fZpw88Gg1zV+/L96PS7Xjs54xMuwf3s3xv+nB7
5yHctvzg4TZFO7vbJI8UEH16bzb59Nwj0wCBvh5p/l9LlDyj+Po+RTz3P53MyKvZ2dvOyIHePn+4
t7tD3nW+l1v5epKRXZzmMcJ0vnoP4oRv/r9UMw1Q827HUNIv2bpsT7Im15BbDGsT/CWO0P1PH8wo
GCO6w5s8uHd/e0IxOBH/IWm76b0D+sea0Gr6ouoQ/D//e/60/+JP+zv+8z/+T/8v/vi/YZDgd/v9
UtpkcrA3nW1Pp59OKBogSTi4d76z/emDAwpB9s8n2a0csP/s7/pz/vM/5i/+L/7Mv/y/+PP+wk3d
3w2pYAjEZLOehRBkj0Lbh9mn2zvnO4TY/RnFdHuUUaEQa3o/m9yn+OmgG6b8/uLfhoT5w/+6//xP
/Lv+8z/pj/8v/8q/aRNmXtf39ydwtynspYwOnNI9irPvZdufZjn53hRsEmbfxFx4XZ6f57sHO2TH
zimQI5V9nm0f7O/tb9+fnZM22sunk8wGZdQlODM2Vu7yv/yb/97//C/4Y2/Z8TTPd+7lJOoHFEFv
739KYf9ksr+3TdHmfQosDyaf7tqxfgPz7/U8uf/gfDabkX7JoH6ze+QA7Wf02ySf7dzf3dnP7u95
DhD1OXvSVTP/+R8FMv9nf8/fc8s+p7PdWb5LApZNHpCU3d/b2T7YobzBzoRi4r0H0wfnbrSDrsN/
/gf9hf/Fn/F3/9d/5J/8X/8lf/4t+509ePjgYH93b3tn9in1m50TBvvkupB/TKF3drAzPchvdvb+
q7/t73zfjim2Ik4mqh7s7oG0lDA4OD9/QEJFOQbi6ez+gQ1SN6jz//Lv/VP/87/+z7plnzmBPp9N
wMuIXqeTfXI/Hky38/P70/29Bw/y6SwzfX6RL7rS81/8yX/Wf/VX/MEblUhXbejfSO7RX/jBiOw8
zO59Sl9tf3rvPvH2DgWXDydInhAbTHd2d/OJSxVv4O1BVDgdKUHc6euTADVFxWLKFuBumM4++g1/
jR89P3p+9Pzo+dHzo+dHz4+e/989/w8=";

            BeforeGetQryModel_Extend(dtoQryStrategyImpl);

            CaseModel caseModel = dtoQryStrategyImpl.GetQryModel();

            AfterGetQueryModel_Extend(caseModel);

            QryService.SetCaseModelToSession((BaseWebForm)this.CurrentPart, caseModel);
        }

        public void QueryAdjust()
        {
            IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

            DTOQueryStrategyImpl dtoQryStrategyImpl = new DTOQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.CustomerVoucherQryDTO",
                "6de4cc91-9677-4aae-9880-bd1282141a4a", UIGrid.UIView, UIGrid);
            dtoQryStrategyImpl.Adjust();

            AfterQryAdjust_Extend(UIGrid);

            GridNavigateAction action = new GridNavigateAction(UIGrid, new UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.Proxy.QueryBPProxy(), "QryInParameter");
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
            UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.Proxy.QueryBPProxy proxy = new UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.Proxy.QueryBPProxy();
            QryBPExportService qryExportservice = new QryBPExportService(UIGrid, proxy, "QryInParameter", FilterOpath);

            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintData = qryExportservice.GetResultSet();
            e.Tag = settings;
        }
        
        #endregion
         



	}
}
