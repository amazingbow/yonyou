﻿


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:94469911-71d3-4bf9-b9e9-7a108e459150 
 * Form Name:CostSharingRatioUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.CostSharingRatioUIModel
{
	[FormRegister("CostSharingRatioUI","UFIDA.U9.Cust.CostSharingRatioUIModel.CostSharingRatioUIFormWebPart", "CostSharingRatioUI.WebPart", "94469911-71d3-4bf9-b9e9-7a108e459150","WebPart", "False", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'CostSharingRatioUI', 'UFIDA.U9.Cust.CostSharingRatioUIModel.CostSharingRatioUIFormWebPart', 'CostSharingRatioUI.WebPart', '94469911-71d3-4bf9-b9e9-7a108e459150')
	///<siteMapNode url="~/erp/simple.aspx?lnk=94469911-71d3-4bf9-b9e9-7a108e459150" title="CostSharingRatioUIForm"/>
    public partial class CostSharingRatioUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CostSharingRatioUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CostSharingRatioUIModelAction Action
		{
			get { return (CostSharingRatioUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CostSharingRatioUIModelModel _uimodel=null;
		public new CostSharingRatioUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CostSharingRatioUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as CostSharingRatioUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFSeparator Separator1;
        IUFSeparator Separator2;
        IUFSeparator Separator3;
        IUFSeparator Separator4;
        IUFSeparator Separator5;
        IUFCard Card2;
        IUFLabel lblRatio214;
        IUFFldNumberControl Ratio214;
        IUFLabel lblID148;
        IUFFldNumberControl ID148;
        IUFLabel lblSysVersion160;
        IUFFldNumberControl SysVersion160;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CostSharingRatioUIFormWebPart()
        {
            FormID = "94469911-71d3-4bf9-b9e9-7a108e459150";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板

	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new CostSharingRatioUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CostSharingRatioUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new CostSharingRatioUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CostSharingRatioUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","7798c2ee-d7c1-45c7-b56d-6807df5e98d1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","bde9d4ad-e63a-40ac-8f1b-4ca6eedb93cb");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","649433e1-65b7-45c2-bd8f-89aceed8080b","52d99dd3-6a99-4233-b4bf-b3271c07d216");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.CostSharingRatioBE, "CostSharingRatioBE", "", null, 1, "费用分摊比例档案");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblRatio214 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRatio214", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","649433e1-65b7-45c2-bd8f-89aceed8080b","b7cbfa8c-06e0-433b-a2b3-45476904a5c6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRatio214, "0");		


				this.Ratio214 = UIControlBuilder.BuilderNumberControl(_UFCard, "Ratio214", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblRatio214","24.9","649433e1-65b7-45c2-bd8f-89aceed8080b","76a91c5a-bcba-4063-8764-962bf7735921",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Ratio214, "False", "Ratio", this.Model.CostSharingRatioBE, this.Model.CostSharingRatioBE.FieldRatio, "CostSharingRatioBE");
	
		
			UIControlBuilder.BuilderUFControl(this.Ratio214, "1");		
		 

				this.lblID148 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID148", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","085365d7-e926-4d66-bb5d-9bacbf34036b","27176df9-1c5c-4895-aec7-a8a0de921ab0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID148, "2");		


				this.ID148 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID148", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID148","19.0","085365d7-e926-4d66-bb5d-9bacbf34036b","3b58f7f0-502a-4a7b-8486-cb5d182ce507",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID148, "False", "ID", this.Model.CostSharingRatioBE, this.Model.CostSharingRatioBE.FieldID, "CostSharingRatioBE");
	
		
			UIControlBuilder.BuilderUFControl(this.ID148, "3");		
		 

				this.lblSysVersion160 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion160", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","24b2e0b7-89a9-48c4-a1e7-228c44f272ed","dc9f2775-e029-48ed-bf85-d2a3c3d9da67");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion160, "4");		


				this.SysVersion160 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion160", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion160","19.0","24b2e0b7-89a9-48c4-a1e7-228c44f272ed","4371e435-267b-48bc-b9db-342dbd316a51",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion160, "False", "SysVersion", this.Model.CostSharingRatioBE, this.Model.CostSharingRatioBE.FieldSysVersion, "CostSharingRatioBE");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion160, "5");		
		 


						

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
