


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
 * Form ID:6d3f628b-34ba-4bd4-9536-bbc3abdf64b0 
 * Form Name:OperatorsDailyUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.FJGX.OperatorsDailyUIModel
{
	[FormRegister("UFIDA.U9.Cust.FJGX.OperatorsDailyUI","UFIDA.U9.Cust.FJGX.OperatorsDailyUIModel.OperatorsDailyUIFormWebPart", "UFIDA.U9.Cust.FJGX.OperatorsDailyUI.WebPart", "6d3f628b-34ba-4bd4-9536-bbc3abdf64b0","WebPart", "False", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.FJGX.OperatorsDailyUI', 'UFIDA.U9.Cust.FJGX.OperatorsDailyUIModel.OperatorsDailyUIFormWebPart', 'UFIDA.U9.Cust.FJGX.OperatorsDailyUI.WebPart', '6d3f628b-34ba-4bd4-9536-bbc3abdf64b0')
	///<siteMapNode url="~/erp/simple.aspx?lnk=6d3f628b-34ba-4bd4-9536-bbc3abdf64b0" title="OperatorsDailyUIForm"/>
    public partial class OperatorsDailyUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(OperatorsDailyUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new OperatorsDailyUIModelAction Action
		{
			get { return (OperatorsDailyUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		OperatorsDailyUIModelModel _uimodel=null;
		public new OperatorsDailyUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new OperatorsDailyUIModelModel();
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
                this.Model = value as OperatorsDailyUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card3;
        IUFTabControl TabControl0;
        IUFTabPage TabPage0;
        IUFLabel lblID72;
        IUFFldNumberControl ID72;
        IUFLabel lblSysVersion51;
        IUFFldNumberControl SysVersion51;
        IUFLabel lblDailyDate78;
        IUFFldDatePicker DailyDate78;
        IUFLabel lblCreatedBy44;
        IUFFldTextBox CreatedBy44;
        IUFLine Line0;
        IUFLabel lblCustomer58;
        IUFFldReference Customer58;
        IUFFldTextBox DailyContent127;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public OperatorsDailyUIFormWebPart()
        {
            FormID = "6d3f628b-34ba-4bd4-9536-bbc3abdf64b0";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Grid控件事件
			((UFWebDataGridAdapter)this.DataGrid1).GridRowClickedHandler += new GridRowClickedDelegate(DataGrid1_GridRowClicked);
			//((UFWebDataGridAdapter)this.DataGrid1).ClickAutoPostBack = true;
									

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid1_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid1).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid1_GridCustomFilterHandler);

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
					this.Model = new OperatorsDailyUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (OperatorsDailyUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new OperatorsDailyUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"OperatorsDailyUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","84de934c-249d-4157-97d3-5b2dcb76a98f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","01ad8860-a4c3-4247-b67a-261a52b041e6");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","83ee61c7-9265-4486-9ad8-d38f2371ca39");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","823f003b-1e5e-456b-94bd-0bbc061a0518");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","59d77502-526a-4c5f-80f0-01f0afb91a86");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","9d69e2bc-5d9a-4c80-b3d1-f1338c1dfd16");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","9d219986-a772-4224-91eb-634eebef401c");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","c53f1808-be6b-4003-810e-721fa555ebce");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 4, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(493,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(468,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl0, "2");		


	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "3");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl0(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl0",true, true, "2",EventResponseType.Client,468, 421, 2, 0, 1, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            this.TabControl0 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "1","f92de224-5a41-403b-95fe-c20ea6ebf8e6","f92de224-5a41-403b-95fe-c20ea6ebf8e6");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 3, 16, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.OperatorsDaily, "OperatorsDaily", "", null, 1, "业务员日志");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(300,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblID72 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblID72", "", "False", "True", "Right", 140, 20, 0, 0, 1, 1, "100","30073064-f10f-492e-8885-57feb39bace0","b5516b39-5b10-4edc-a68d-3c85c0ff1600");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID72, "0");		


				this.ID72 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ID72", "False", "False", "True", "Left", 7, 60, 0, 300, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID72","19.0","30073064-f10f-492e-8885-57feb39bace0","08c4b98e-2e07-4399-a99a-d038f0eb6dcb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID72, "False", "ID", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldID, "OperatorsDaily");
	
		
			UIControlBuilder.BuilderUFControl(this.ID72, "1");		
		 

				this.lblSysVersion51 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSysVersion51", "", "False", "True", "Right", 140, 20, 0, 0, 1, 1, "100","b2e38c4b-9abb-4b4b-aeb4-5957c86aa173","4bf64dea-13f9-457b-9e19-24c4197011bc");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion51, "2");		


				this.SysVersion51 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "SysVersion51", "True", "False", "True", "Left", 7, 60, 0, 300, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion51","19.0","b2e38c4b-9abb-4b4b-aeb4-5957c86aa173","33e94ba8-0f10-497b-b9d1-c5aab369c6e8",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion51, "False", "SysVersion", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldSysVersion, "OperatorsDaily");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion51, "3");		
		 

				this.lblDailyDate78 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDailyDate78", "", "True", "True", "Right", 140, 20, 0, 1, 1, 1, "100","cd8f98fb-d51a-4982-b7e1-cf71dae0b52c","9c2859d1-0515-45f8-9dbd-7b5a01d67240");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDailyDate78, "4");		


				this.DailyDate78 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "DailyDate78", false, true, true, "DateTime","Left", 5, 60, 0, 300, 20, 2, 1, 1, 1, "100",true,true,"lblDailyDate78","cd8f98fb-d51a-4982-b7e1-cf71dae0b52c","eb702465-872f-4e8e-843b-f8656f7b2ea8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DailyDate78, "False", "DailyDate", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldDailyDate, "OperatorsDaily");


		
			UIControlBuilder.BuilderUFControl(this.DailyDate78, "5");		
		 

				this.lblCreatedBy44 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCreatedBy44", "", "True", "True", "Right", 140, 20, 0, 2, 1, 1, "100","ef766d27-7ae8-471f-9367-1a95d284510f","971d785d-8cb8-4713-afe0-d2e7f1c14b34");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreatedBy44, "8");		


				this.CreatedBy44 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CreatedBy44", "True", "True", "True", "False", "Left", 0, 60, 0, 300, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblCreatedBy44","","50","ef766d27-7ae8-471f-9367-1a95d284510f","72239d0c-a0f5-472b-884c-bc889b3018df");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreatedBy44, "False", "CreatedBy", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldCreatedBy, "OperatorsDaily");


		
			UIControlBuilder.BuilderUFControl(this.CreatedBy44, "9");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 450, "Horizontal", "True", 450, 20, 0, 3, 3, 1, "100","ff8441d0-10a8-48c8-905d-3ac54ff6bd87","ff8441d0-10a8-48c8-905d-3ac54ff6bd87");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "10");		


				this.lblCustomer58 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustomer58", "", "True", "True", "Right", 140, 20, 0, 0, 1, 1, "100","02f6b920-e898-4142-8e18-4a43d81c7c61","4d19fd48-d83b-4c32-84af-738cea8228bf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustomer58, "11");		


				this.Customer58 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"Customer58",false,true, true,300, 20, 2, 0, 1, 1, "100","12",true,false,true,"lblCustomer58","02f6b920-e898-4142-8e18-4a43d81c7c61","7ccd856d-53ca-48be-a4c2-20576a713678");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Customer58, "False", "Customer", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldCustomer, "OperatorsDaily");
			UIControlBuilder.SetReferenceControlRefInfo(this.Customer58,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", this.Model.OperatorsDaily.FieldCustomer_Code,this.Model.OperatorsDaily.FieldCustomer_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Customer58,"Customer58",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Customer58, "12");		
		 

				this.DailyContent127 = UIControlBuilder.BuilderTextBox(_UFTabPage, "DailyContent127", "False", "True", "True", "True", "Left", 0, 60, 0, 450, 270, 0, 4, 3, 11, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"","","5000","79508d21-4f6e-4650-9eef-61f1f6c0689e","02ca70d8-00a5-4d28-a831-1a2fe2bec406");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DailyContent127, "False", "DailyContent", this.Model.OperatorsDaily, this.Model.OperatorsDaily.FieldDailyContent, "OperatorsDaily");


		
			UIControlBuilder.BuilderUFControl(this.DailyContent127, "14");		
		 


											
			this.Customer58.IsMultiOrg  = false ;
			this.lblCustomer58.SetMultiOrgInfo(this.Customer58,false);
			
	

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

				

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "3");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 493, 415, 0, 0, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.ListView, "ListView", "", null, 20, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID73","NumberColumnModel", "", 0,this.Model.ListView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","5bbc6267-f2c0-4adf-b14c-ea4cc3a852c5","5bbc6267-f2c0-4adf-b14c-ea4cc3a852c5","8e5b0ec7-0559-4cc3-b5c5-33b0c38c9589");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion52","NumberColumnModel", "", 0,this.Model.ListView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","1fbef44c-6e4e-4735-8653-97fae356eb59","1fbef44c-6e4e-4735-8653-97fae356eb59","10dec444-ad94-47a1-bbe5-91981352d28e");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DailyDate79","DatePickerColumnModel", "", 0,this.Model.ListView.Fields["DailyDate"]/*DailyDate*/,"DailyDate", false, true, true, false, false, true, 5, 120, "17",true, false,"","b1fc1453-87ba-4650-8ddd-89906ba96e2d","b1fc1453-87ba-4650-8ddd-89906ba96e2d","d498f0d4-03dd-4c9f-87f3-578ea2bde33f");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CreatedBy65","TextBoxColumnModel", "", 0,this.Model.ListView.Fields["CreatedBy"]/*CreatedBy*/,"CreatedBy", false, true, true, false, false, false, 0, 100, "",true, false,"","0dc6132c-aecb-4db5-8ccf-be2b70c63c19","0dc6132c-aecb-4db5-8ccf-be2b70c63c19","13f2bbf3-2da1-470c-8323-79c02464cdc4");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DailyContent88","TextBoxColumnModel", "", 0,this.Model.ListView.Fields["DailyContent"]/*DailyContent*/,"DailyContent", false, true, true, false, false, true, 0, 260, "500",true, false,"","5f2c4324-245e-4cc7-aee7-c4201f503962","5f2c4324-245e-4cc7-aee7-c4201f503962","01a4b2f3-fbb2-4003-a56c-21c35b387c3b");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","500") ;          
	  
		 
        }





		#endregion
		

	}
}
