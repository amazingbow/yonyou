


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
 * Form ID:1fcb4da9-d87f-43e8-baf3-ce8a6da7577f 
 * Form Name:HeXingRelationshipFindRef
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace HeXingRelationshipFindRef
{
	[FormRegister("UFIDA.U9.Cust.HeXingProjectUI","HeXingRelationshipFindRef.HeXingRelationshipFindRefWebPart", "UFIDA.U9.Cust.HeXingProjectUI.WebPart", "1fcb4da9-d87f-43e8-baf3-ce8a6da7577f","WebPart", "False", 580, 408)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.HeXingProjectUI', 'HeXingRelationshipFindRef.HeXingRelationshipFindRefWebPart', 'UFIDA.U9.Cust.HeXingProjectUI.WebPart', '1fcb4da9-d87f-43e8-baf3-ce8a6da7577f')
	///<siteMapNode url="~/erp/simple.aspx?lnk=1fcb4da9-d87f-43e8-baf3-ce8a6da7577f" title="HeXingRelationshipFindRef"/>
    public partial class HeXingRelationshipFindRefWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(HeXingRelationshipFindRefWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new HeXingRelationshipFindRefAction Action
		{
			get { return (HeXingRelationshipFindRefAction)base.Action; }
			set { base.Action = value; }
		}
		HeXingRelationshipFindRefModel _uimodel=null;
		public new HeXingRelationshipFindRefModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new HeXingRelationshipFindRefModel();
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
                this.Model = value as HeXingRelationshipFindRefModel;
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
        public HeXingRelationshipFindRefWebPart()
        {
            FormID = "1fcb4da9-d87f-43e8-baf3-ce8a6da7577f";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

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
					this.Model = new HeXingRelationshipFindRefModel();
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
				//this.Model = (HeXingRelationshipFindRefModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new HeXingRelationshipFindRefAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"HeXingRelationshipFindRef",true,580,408);
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "1","","5188a993-c95f-4644-9ee7-2d306cd273e8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(45,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(180,bool.Parse("False")),new GridColumnDef(15,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(60,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 45, 20, 0, 0, 1, 1, "100","9bf97f14-74b9-4a4f-b2fc-d5bfb9c95e3a","7f232f08-01dd-4219-bbb7-ee7a705d469b");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "0");		


		        this.SelectList = UIControlBuilder.BuilderDropDownList(_UFCard, "SelectList", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"","","6885b694-3680-498c-9b62-8acbb4c24093");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SelectList, "False", "", null, null, "");
			EnumControlsMap.Add(this.SelectList, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.SelectList, "1");		
		 

	
			_BuilderControl_WizardControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.WizardControl0, "2");		


				this.lblContinueCheckBox = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContinueCheckBox", "", "False", "True", "Right", 80, 20, 6, 0, 1, 1, "100","0aead14b-b05a-4582-9aca-34da4f4bf7a0","6c1b5ff3-9db6-4ad8-b6ee-1722d33609d7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContinueCheckBox, "3");		


				this.ContinueCheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ContinueCheckBox", false, true, "Left", 60, 0, 30, 20, 8, 0, 1, 1, "100",true,"lblContinueCheckBox","","4429026c-6f35-4037-a48b-e78432d125ec");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContinueCheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.ContinueCheckBox, "4");		
		 

				this.FindButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "FindButton", true, true, 60, 20, 10, 0, 1, 1, "100","R", this.Model.ElementID,"",false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","62435e75-84e8-461e-94f2-40aa912d9ae9");
	

		
			UIControlBuilder.BuilderUFControl(this.FindButton, "4");		


				this.CheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "CheckBox", false, true, "Left", 60, 0, 30, 20, 0, 0, 1, 1, "100",false,"","","bdf96649-ae6a-4d0a-b6bd-d1cad955cd39");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"FunctionBar", true, true, "0","","a9401376-272d-42e7-aa03-7bbd73a0b60e");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"CardForRefQueryCase",false,"none", true, true, "0","","1a940943-5c30-4000-ac54-8cfd81255859");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 360, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 6, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(150,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.CardForRefQueryCase = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.QryButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "QryButton", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"3664768b-36ca-44ab-9583-8d85fb432e43","3664768b-36ca-44ab-9583-8d85fb432e43","1a9b5caa-d390-41e2-816a-d3f03d23b8e5");
	

		
			UIControlBuilder.BuilderUFControl(this.QryButton, "1");		


				this.lbCase = UIControlBuilder.BuilderUFLabel(_UFCard, "lbCase", "", "True", "True", "Right", 80, 20, 3, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","0eb1d780-a373-4c28-b70e-f7e0f5be9e9a");


								

		
			UIControlBuilder.BuilderUFControl(this.lbCase, "1");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 150, 20, 5, 0, 1, 1, "100",true,false,"","","4b0a9718-c8d3-48ed-af65-1cdf45aa0267");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","210d947d-27a5-4359-8398-cc4587fec22f");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 170, 20, 2, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.ConfirmButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "ConfirmButton", true, true, 80, 20, 0, 0, 1, 1, "100","O", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","27fed640-4637-4d7e-a8c2-59b8ba3cd30c");
	

		
			UIControlBuilder.BuilderUFControl(this.ConfirmButton, "3");		


				this.CancelButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "CancelButton", true, true, 80, 20, 2, 0, 1, 1, "100","C", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","f39c2510-09d2-4b43-a22f-d8c4e15b3924");
	

		
			UIControlBuilder.BuilderUFControl(this.CancelButton, "4");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,13,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 560, 318, 0, 2, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.cRef, "cRef", "", null, 13, "合兴关系对照表");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.cRef.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, true, 7, 80, "19",true, false,"","eda13f1f-690f-405d-8ea5-43acbcdabb0f","eda13f1f-690f-405d-8ea5-43acbcdabb0f","1def9a90-4633-40aa-9f23-2b6b30927682");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.FixedPoint, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
	
    if (this.UseQueryCase && UFIDA.UBF.Query.CommonService.RefQueryHelper.QueryCaseExist(this.Action, null))
    {
            return;
    }
	 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CreatedOn0","DatePickerColumnModel", "", 0,this.Model.cRef.Fields["CreatedOn"]/*CreatedOn*/,"CreatedOn", false, false, true, false, false, true, 5, 80, "0",true, false,"","4fa4a25f-f9f7-4ac1-a30b-fadd03387143","4fa4a25f-f9f7-4ac1-a30b-fadd03387143","1ff84809-2fd2-49e9-838a-71a36224b229");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefType0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefType"]/*RefType*/,"RefType", false, true, true, false, false, true, 2, 80, "5",true, false,"","4f12f488-583a-44a3-816b-95cfddabfba3","4f12f488-583a-44a3-816b-95cfddabfba3","90fb79d0-94df-4612-9669-d3aae51aa40c");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCode"]/*SapCode*/,"SapCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","682bc6bb-aec3-4c5b-89fb-5c05b56c9204","682bc6bb-aec3-4c5b-89fb-5c05b56c9204","d154d17f-e810-4fc5-94ff-1f13db70b2b1");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapName"]/*SapName*/,"SapName", false, true, true, false, false, true, 0, 80, "5",true, false,"","46186b1e-0245-4f17-abc0-81499d52525d","46186b1e-0245-4f17-abc0-81499d52525d","27ad4bf9-fe16-4784-9a3f-f6883677e11c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompCode"]/*SapCompCode*/,"SapCompCode", false, true, true, false, false, true, 0, 85, "5",true, false,"","de48b916-2c0f-420f-aba5-65c521929ea3","de48b916-2c0f-420f-aba5-65c521929ea3","3c106b7a-82c2-44e4-b052-2d35ecf0910c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompName"]/*SapCompName*/,"SapCompName", false, true, true, false, false, true, 0, 88, "5",true, false,"","3e0c05e4-3d26-4568-916e-743b4dd57b2c","3e0c05e4-3d26-4568-916e-743b4dd57b2c","1d199951-4dd6-4d6c-9b7f-64e621fde45b");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterCode"]/*SapMasterCode*/,"SapMasterCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","af5a2caf-4a57-44dc-92fd-b174b0f893f4","af5a2caf-4a57-44dc-92fd-b174b0f893f4","1f00e122-a081-4613-bfd2-f7bcd95b2171");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterName"]/*SapMasterName*/,"SapMasterName", false, true, true, false, false, true, 0, 80, "5",true, false,"","7282596a-266e-4b98-be1b-41e846d96dc7","7282596a-266e-4b98-be1b-41e846d96dc7","6fa5fb17-6884-4385-ba7e-b56ad97493be");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsCode"]/*SapAssetsCode*/,"SapAssetsCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","5233a63f-d776-4f8a-8fba-9f40a98ad2a9","5233a63f-d776-4f8a-8fba-9f40a98ad2a9","2fa8a698-c9a4-443b-8171-99592f3c1683");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsName"]/*SapAssetsName*/,"SapAssetsName", false, true, true, false, false, true, 0, 80, "5",true, false,"","946c2772-b463-41b4-b233-be0cfb6ff7ea","946c2772-b463-41b4-b233-be0cfb6ff7ea","2e387740-5b6c-4aa6-9168-eb2689ddd4a6");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeCode"]/*SapFeeCode*/,"SapFeeCode", false, true, true, false, false, true, 0, 90, "5",true, false,"","b52a8d1d-d164-41dc-8284-0911159c6e29","b52a8d1d-d164-41dc-8284-0911159c6e29","6b302bf2-a568-4f0d-8e0f-42c796f1db04");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeName"]/*SapFeeName*/,"SapFeeName", false, true, true, false, false, true, 0, 90, "5",true, false,"","b944b6a6-7b07-450f-9b7f-545a42176b4a","b944b6a6-7b07-450f-9b7f-545a42176b4a","a3617395-4d69-4e81-b1f7-62928a2832c5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Code0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Code"]/*U9Code*/,"U9Code", false, true, true, false, false, true, 0, 80, "5",true, false,"","10d9196d-2d9d-4dc5-ac77-549d11c35e6b","10d9196d-2d9d-4dc5-ac77-549d11c35e6b","47949dc8-e1ab-4584-a7ad-c8a51860fe36");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Name"]/*U9Name*/,"U9Name", false, true, true, false, false, true, 0, 80, "5",true, false,"","c18d96d3-b490-4bf2-b0c1-c45d67ef9f1f","c18d96d3-b490-4bf2-b0c1-c45d67ef9f1f","8c0f8b8e-8d43-4c25-969f-80e31e43d706");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefStatus0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefStatus"]/*RefStatus*/,"RefStatus", false, true, true, false, false, true, 2, 80, "10",true, false,"","994a7d4f-cc8b-44d6-9417-2759746fc3b2","994a7d4f-cc8b-44d6-9417-2759746fc3b2","9416d924-8d0c-4898-b61b-869ebc6dd647");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 
        }

	        private void _BuilderControl_MatchTypeRadioBoxList(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"MatchTypeRadioBoxList",true,true,"6",0,4,UFSoft.UBF.UI.ControlModel.LineOrientation.Horizontal);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 560, 20, 0, 1, 1, 1, "100");
            this.MatchTypeRadioBoxList = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"0", true,false,"130bc338-9958-4133-9b7f-9c185bc2455a","ffcc03be-bade-49ee-aca7-4ba29e8aaa71");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"49790074-95af-497d-ae37-16bb697f3ce6","82f51ef9-d621-4f6d-b2d5-57b491c2021c");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,true,"517d6f15-ca0d-4e3b-aa58-3c85a5b2ae66","5f37ac87-e3d1-4cf9-bc38-9de736b33b51");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"ea7795fe-8961-4c3f-8ed1-b5128be2cd75","505c1f6b-1ee7-4fcb-ba40-14edb2fdb456");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}
