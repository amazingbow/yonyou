


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
 * Form ID:874cc1b6-f844-486c-b3f5-f8cca21fe1e0 
 * Form Name:SpecialApplyCustomerRef
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace SpecialApplyCustomerRef
{
	[FormRegister("UFIDA.U9.Cust.SpecialApplyUI","SpecialApplyCustomerRef.SpecialApplyCustomerRefWebPart", "UFIDA.U9.Cust.SpecialApplyUI.WebPart", "874cc1b6-f844-486c-b3f5-f8cca21fe1e0","WebPart", "False", 580, 408)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.SpecialApplyUI', 'SpecialApplyCustomerRef.SpecialApplyCustomerRefWebPart', 'UFIDA.U9.Cust.SpecialApplyUI.WebPart', '874cc1b6-f844-486c-b3f5-f8cca21fe1e0')
	///<siteMapNode url="~/erp/simple.aspx?lnk=874cc1b6-f844-486c-b3f5-f8cca21fe1e0" title="SpecialApplyCustomerRef"/>
    public partial class SpecialApplyCustomerRefWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecialApplyCustomerRefWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SpecialApplyCustomerRefAction Action
		{
			get { return (SpecialApplyCustomerRefAction)base.Action; }
			set { base.Action = value; }
		}
		SpecialApplyCustomerRefModel _uimodel=null;
		public new SpecialApplyCustomerRefModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SpecialApplyCustomerRefModel();
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
                this.Model = value as SpecialApplyCustomerRefModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card4;
        IUFLabel Label0;
        IUFFldDropDownList SelectList;
        IUFWizardControl WizardControl0;
        IUFLabel lblContinueCheckBox;
        IUFFldCheckBox ContinueCheckBox;
        IUFButton FindButton;
        IUFFldCheckBox CheckBox;
        IUFCard Card6;
        IUFCard CardForRefQueryCase;
        IUFButton QryButton;
        IUFLabel lbCase;
        IUFFldDropDownList DDLCase;
        IUFCard Card1;
        IUFButton ConfirmButton;
        IUFButton CancelButton;
        IUFDataGrid DataGrid;
        IUFRadioBoxList MatchTypeRadioBoxList;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SpecialApplyCustomerRefWebPart()
        {
            FormID = "874cc1b6-f844-486c-b3f5-f8cca21fe1e0";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
	
	
	
	
			
			//G
			
	
            
	//获取档案版型结果: G

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.FindButton.Click += new EventHandler(FindButton_Click);		
						
				//Button控件事件
			this.QryButton.Click += new EventHandler(QryButton_Click);		
						
							
				//Button控件事件
			this.ConfirmButton.Click += new EventHandler(ConfirmButton_Click);		
						
				//Button控件事件
			this.CancelButton.Click += new EventHandler(CancelButton_Click);		
						
				//Grid控件事件
			
			((UFWebDataGridAdapter)this.DataGrid).RowDoubleClick += new GridRowDBClickedDelegate(DataGrid_GridRowDbClicked);
			//((UFWebDataGridAdapter)this.DataGrid).DBClickAutoPostBack = true;
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid_GridCustomFilterHandler);

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
					this.Model = new SpecialApplyCustomerRefModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				if(this.UseQueryCase){
					UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterOnLoad_Qry_DefaultImpl(this.Action);
				}
				//去除.已经移入到OnInit()中.
				//this.Model = (SpecialApplyCustomerRefModel)this.CurrentState[this.TaskId.ToString()];
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
										
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.LocateRecordFromFocusID(this, this.DataGrid);
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
			    if(this.UseQueryCase){
					UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterUIModelBinding_Qry_DefaultImpl(this.Action);
				}
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
            this.Action = new SpecialApplyCustomerRefAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
                DialogNoPersonalization = true;
		        if(!UseQueryCase){
		            CardForRefQueryCase.Visible=false;
		            UFGrid sortGrid = this.GetUFControlByName(this.TopLevelContainer, "DataGrid") as UFGrid;
                    if (sortGrid != null)
                        sortGrid.ShowCustomFilterToolBar = false;
		        }
		        else
                {
                    UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterCreateChildControls_Qry_DefaultImpl(this.Action);
                    UFIDA.U9.UI.PDHelper.PDFormMessage.ShowQryDialogForReference(this,this.QryButton);
                }
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SpecialApplyCustomerRef",true,580,408);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 4, 0, 5, 10, 5, 10, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(560,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(318,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "1");		


	
			_BuilderControl_Card6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card6, "0");		


	
			_BuilderControl_DataGrid(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid, "2");		


	
			_BuilderControl_MatchTypeRadioBoxList(_panel);

		
			UIControlBuilder.BuilderUFControl(this.MatchTypeRadioBoxList, "6");		



				
     
			
			
            EventBind();
            AfterCreateChildControls();
            
			((UFWebButtonAdapter)ConfirmButton).IsDefaultButton = true;
        }        







	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "1","","8b0a005f-f6e9-48a4-a075-2aa14aa835b8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(45,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(180,bool.Parse("False")),new GridColumnDef(15,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(60,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 45, 20, 0, 0, 1, 1, "100","9bf97f14-74b9-4a4f-b2fc-d5bfb9c95e3a","68d55751-6713-44b2-9c5d-a8b90af251b0");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "0");		


		        this.SelectList = UIControlBuilder.BuilderDropDownList(_UFCard, "SelectList", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"","","a99efedf-683f-4910-a0f9-6aa386fa5bd8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SelectList, "False", "", null, null, "");
			EnumControlsMap.Add(this.SelectList, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.SelectList, "1");		
		 

	
			_BuilderControl_WizardControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.WizardControl0, "2");		


				this.lblContinueCheckBox = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContinueCheckBox", "", "False", "True", "Right", 80, 20, 6, 0, 1, 1, "100","0aead14b-b05a-4582-9aca-34da4f4bf7a0","b8852feb-b21b-42a3-aec4-76cd98b52f62");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContinueCheckBox, "3");		


				this.ContinueCheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ContinueCheckBox", false, true, "Left", 60, 0, 30, 20, 8, 0, 1, 1, "100",true,"lblContinueCheckBox","","b648887b-73f3-4444-b331-4e20c1980ef9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContinueCheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.ContinueCheckBox, "4");		
		 

				this.FindButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "FindButton", true, true, 60, 20, 10, 0, 1, 1, "100","R", this.Model.ElementID,"",false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","09a0a1cf-160f-4591-8d05-ceb3c0719e5f");
	

		
			UIControlBuilder.BuilderUFControl(this.FindButton, "4");		


				this.CheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "CheckBox", false, true, "Left", 60, 0, 30, 20, 0, 0, 1, 1, "100",false,"","","5b27ad7d-b5d1-40b5-a056-53d1c8c3ea2a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.CheckBox, "5");		
		 


							

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

		    private void _BuilderControl_WizardControl0(IUFContainer container)
        {
            IUFWizardControl _UFWizard = new UFWebWizardControlAdapter();
            _UFWizard.ID = "WizardControl0";
			UIControlBuilder.BuilderUFControl(_UFWizard, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFWizard, 180, 20, 4, 0, 1, 1, "100");

            ///foreach _UFWizard下的所有控件，增加到此容器
            
            this.WizardControl0 = _UFWizard;
    		_UFWizard.SetWizardPageVisible(0);
            container.Controls.Add(_UFWizard);
        }

	                   
        private IUFCard _BuilderControl_Card6(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"FunctionBar", true, true, "0","","68f6b6f9-0d50-4595-97a6-100048aa2cea");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 3, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(360,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(170,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card6 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_CardForRefQueryCase(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.CardForRefQueryCase, "0");		


	
			_BuilderControl_Card1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "0");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_CardForRefQueryCase(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"CardForRefQueryCase",false,"none", true, true, "0","","dc182687-462e-46ba-8f0f-211c1364f5a6");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 360, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 6, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(150,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.CardForRefQueryCase = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.QryButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "QryButton", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"3664768b-36ca-44ab-9583-8d85fb432e43","3664768b-36ca-44ab-9583-8d85fb432e43","a392937e-5eec-4c01-970f-fc8692b3d2cb");
	

		
			UIControlBuilder.BuilderUFControl(this.QryButton, "1");		


				this.lbCase = UIControlBuilder.BuilderUFLabel(_UFCard, "lbCase", "", "True", "True", "Right", 80, 20, 3, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","17dff59b-1c95-4a4e-ab28-3bf0b53ac796");


								

		
			UIControlBuilder.BuilderUFControl(this.lbCase, "1");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 150, 20, 5, 0, 1, 1, "100",true,false,"","","3a454fc8-54a7-46ab-a087-7944dc10e26f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "2");		
		 


			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","2fdb97d8-1ba2-45c7-a84d-de65aeca68d7");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 170, 20, 2, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.ConfirmButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "ConfirmButton", true, true, 80, 20, 0, 0, 1, 1, "100","O", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","2f9a8c18-9eb5-4c30-8cf2-6fa5c7eb1b81");
	

		
			UIControlBuilder.BuilderUFControl(this.ConfirmButton, "3");		


				this.CancelButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "CancelButton", true, true, 80, 20, 2, 0, 1, 1, "100","C", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","38112174-17fb-4d2f-85b0-69014ad9429f");
	

		
			UIControlBuilder.BuilderUFControl(this.CancelButton, "4");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,13,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 560, 318, 0, 2, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.cRef, "cRef", "", null, 13, "客户");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.cRef.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, true, 7, 80, "8",true, false,"","0ea056c6-6b3c-4e6b-86b2-66be02d191a7","0ea056c6-6b3c-4e6b-86b2-66be02d191a7","a64c0f62-f2fc-4e95-935e-b0577c38b6ea");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.FixedPoint, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
	
    if (this.UseQueryCase && UFIDA.UBF.Query.CommonService.RefQueryHelper.QueryCaseExist(this.Action, null))
    {
            return;
    }
	 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Code0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Code"]/*Code*/,"Code", false, true, true, false, false, true, 0, 100, "5",true, false,"","76076d7e-5677-48c0-bda7-92b32255a9bb","76076d7e-5677-48c0-bda7-92b32255a9bb","7013277c-3fd9-4e3e-a595-402841decd02");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Name"]/*Name*/,"Name", false, true, true, false, false, true, 0, 150, "5",true, true,"","4b2cd224-4036-4fa4-97b1-b6e372c60513","4b2cd224-4036-4fa4-97b1-b6e372c60513","7ba28e5d-17b3-40f6-b194-eda681059ca2");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustomerCategory_Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["CustomerCategory_Name"]/*CustomerCategory_Name*/,"CustomerCategory_Name", false, false, true, false, false, true, 0, 120, "5",true, true,"","0668eb68-aa27-41f2-af48-2754bfe5442d","0668eb68-aa27-41f2-af48-2754bfe5442d","a7e070c4-36c7-463f-935a-68a8a78642c0");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Description0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Description"]/*Description*/,"Description", false, true, true, false, false, true, 0, 150, "5",true, true,"","9bc42768-5335-405a-b0b4-bd6292c28e13","9bc42768-5335-405a-b0b4-bd6292c28e13","b4d83224-68b5-4c01-b09d-18bfbabae9f0");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Org_Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Org_Name"]/*Org_Name*/,"Org_Name", false, false, true, false, false, true, 0, 120, "5",true, true,"","b0e87a4e-b4c2-4e0e-9497-28c41acee24c","b0e87a4e-b4c2-4e0e-9497-28c41acee24c","889f5d3f-8aac-4671-bb0a-aeb0bed62723");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DescFlexField_PrivateDescSeg140","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["DescFlexField_PrivateDescSeg14"]/*DescFlexField_PrivateDescSeg14*/,"DescFlexField_PrivateDescSeg14", false, false, true, false, false, true, 0, 120, "5",true, false,"","d48db892-f7f5-4ab4-b4d8-c25ae0526bf2","d48db892-f7f5-4ab4-b4d8-c25ae0526bf2","d5553007-0847-4f5a-b064-879b41dcf877");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DescFlexField_PrivateDescSeg110","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["DescFlexField_PrivateDescSeg11"]/*DescFlexField_PrivateDescSeg11*/,"DescFlexField_PrivateDescSeg11", false, false, true, false, false, true, 0, 120, "5",true, false,"","92c05269-1b5b-4bb7-8502-b68624fe3886","92c05269-1b5b-4bb7-8502-b68624fe3886","f7d4cf59-fb96-4b91-b570-f2147383f3ef");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 
        }

	        private void _BuilderControl_MatchTypeRadioBoxList(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"MatchTypeRadioBoxList",true,true,"6",0,4,UFSoft.UBF.UI.ControlModel.LineOrientation.Horizontal);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 560, 20, 0, 1, 1, 1, "100");
            this.MatchTypeRadioBoxList = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"0", true,false,"130bc338-9958-4133-9b7f-9c185bc2455a","69edc0d3-899e-4a51-a766-61358fd04316");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"49790074-95af-497d-ae37-16bb697f3ce6","5f92546b-1347-4cd7-809d-c08b1176cea8");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,true,"517d6f15-ca0d-4e3b-aa58-3c85a5b2ae66","589b1195-b10b-457f-9804-07d8070bb813");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"ea7795fe-8961-4c3f-8ed1-b5128be2cd75","521aedee-1ebf-4e3c-b16c-164327da2763");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}
