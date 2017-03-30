


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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "1","","36b59d71-cdc9-46e5-a4d9-0585ee1236f0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(45,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(180,bool.Parse("False")),new GridColumnDef(15,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(60,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 45, 20, 0, 0, 1, 1, "100","9bf97f14-74b9-4a4f-b2fc-d5bfb9c95e3a","44eaaed7-7935-4f14-98f9-cb8ea28c855c");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "0");		


		        this.SelectList = UIControlBuilder.BuilderDropDownList(_UFCard, "SelectList", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"","","da3f1b00-07fe-4c05-b04a-14ba2eefa70d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SelectList, "False", "", null, null, "");
			EnumControlsMap.Add(this.SelectList, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.SelectList, "1");		
		 

	
			_BuilderControl_WizardControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.WizardControl0, "2");		


				this.lblContinueCheckBox = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContinueCheckBox", "", "False", "True", "Right", 80, 20, 6, 0, 1, 1, "100","0aead14b-b05a-4582-9aca-34da4f4bf7a0","07fb9fd5-3b7a-4552-a290-59db95145325");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContinueCheckBox, "3");		


				this.ContinueCheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ContinueCheckBox", false, true, "Left", 60, 0, 30, 20, 8, 0, 1, 1, "100",true,"lblContinueCheckBox","","9d015fb0-c1ae-4495-887e-73ce97567a6b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContinueCheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.ContinueCheckBox, "4");		
		 

				this.FindButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "FindButton", true, true, 60, 20, 10, 0, 1, 1, "100","R", this.Model.ElementID,"",false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","1f49ba05-5f54-4f46-a360-bc2306951917");
	

		
			UIControlBuilder.BuilderUFControl(this.FindButton, "4");		


				this.CheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "CheckBox", false, true, "Left", 60, 0, 30, 20, 0, 0, 1, 1, "100",false,"","","40c51dcf-406b-45ea-a4e6-fcf5a5d88da4");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"FunctionBar", true, true, "0","","4c04d0e2-b714-41d3-88f0-0b0cc28bf05d");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"CardForRefQueryCase",false,"none", true, true, "0","","15e7e750-0943-4103-b1ab-729bfbfcbfa7");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 360, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 6, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(150,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.CardForRefQueryCase = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.QryButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "QryButton", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"3664768b-36ca-44ab-9583-8d85fb432e43","3664768b-36ca-44ab-9583-8d85fb432e43","651c71ea-186e-465f-a993-0dc17e2cd46c");
	

		
			UIControlBuilder.BuilderUFControl(this.QryButton, "1");		


				this.lbCase = UIControlBuilder.BuilderUFLabel(_UFCard, "lbCase", "", "True", "True", "Right", 80, 20, 3, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","29131af7-2b0e-448f-99f4-533089425b4a");


								

		
			UIControlBuilder.BuilderUFControl(this.lbCase, "1");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 150, 20, 5, 0, 1, 1, "100",true,false,"","","50731aa8-47b3-4869-a05f-af310e01eac9");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","0758167c-ce4c-41f8-a9eb-d124ef7d677c");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 170, 20, 2, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.ConfirmButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "ConfirmButton", true, true, 80, 20, 0, 0, 1, 1, "100","O", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","e2af1b04-3f4e-4182-98fc-faee9077c2d5");
	

		
			UIControlBuilder.BuilderUFControl(this.ConfirmButton, "3");		


				this.CancelButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "CancelButton", true, true, 80, 20, 2, 0, 1, 1, "100","C", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","57a9b03f-0179-4b3e-abeb-876627e82e8c");
	

		
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
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.cRef.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, true, 7, 80, "19",true, false,"","2abff610-d21c-409e-8ce9-44bae92b88a2","2abff610-d21c-409e-8ce9-44bae92b88a2","567afbb0-49cc-46ca-9b2d-75be1a7bf1ab");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.FixedPoint, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
	
    if (this.UseQueryCase && UFIDA.UBF.Query.CommonService.RefQueryHelper.QueryCaseExist(this.Action, null))
    {
            return;
    }
	 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefType0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefType"]/*RefType*/,"RefType", false, true, true, false, false, true, 2, 80, "5",true, false,"","56abb7ba-b8ba-48b2-b202-cc1e99650eef","56abb7ba-b8ba-48b2-b202-cc1e99650eef","bf58f21d-67f5-4d4e-92f8-d0c7a52eba06");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCode"]/*SapCode*/,"SapCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","c504b793-da72-4c3f-b96a-a6a2bc2fff5f","c504b793-da72-4c3f-b96a-a6a2bc2fff5f","e5c5e416-c513-42f8-8aef-d75972102d65");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapName"]/*SapName*/,"SapName", false, true, true, false, false, true, 0, 80, "5",true, false,"","6ae0cebd-c03e-4100-9f50-ce9e2e092531","6ae0cebd-c03e-4100-9f50-ce9e2e092531","68f00e99-b435-4140-aafe-b1dc1477a9c7");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompCode"]/*SapCompCode*/,"SapCompCode", false, true, true, false, false, true, 0, 89, "5",true, false,"","44c5b583-e5d8-479a-b0e6-ac489a63a8e8","44c5b583-e5d8-479a-b0e6-ac489a63a8e8","bf556434-1a97-4819-aca9-d54bc3fc5b2f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompName"]/*SapCompName*/,"SapCompName", false, true, true, false, false, true, 0, 90, "5",true, false,"","21dcfee6-6e77-499a-a4b6-d37d209dd789","21dcfee6-6e77-499a-a4b6-d37d209dd789","1b922df6-4e25-4da5-bb5c-7dfded0f6f11");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustomerCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["CustomerCode"]/*CustomerCode*/,"CustomerCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","576feac1-2d7f-4d3d-a5ba-8fe4f5bf7d3e","576feac1-2d7f-4d3d-a5ba-8fe4f5bf7d3e","566530b4-a80c-4472-bc15-ab3338be67bd");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustomerName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["CustomerName"]/*CustomerName*/,"CustomerName", false, true, true, false, false, true, 0, 80, "5",true, false,"","2ac59e74-676a-4bc9-b711-afce8fddd57d","2ac59e74-676a-4bc9-b711-afce8fddd57d","9554d628-0ff1-4c2f-9e0c-4260245e799c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterCode"]/*SapMasterCode*/,"SapMasterCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","a3989eb4-be96-4afb-8683-f2cf8229e6c1","a3989eb4-be96-4afb-8683-f2cf8229e6c1","4bf07ff2-82f8-4579-92cb-f939af0d4349");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterName"]/*SapMasterName*/,"SapMasterName", false, true, true, false, false, true, 0, 80, "5",true, false,"","6dd9286f-3ff7-4faf-a438-a2e46da9d13b","6dd9286f-3ff7-4faf-a438-a2e46da9d13b","7152f0ab-47fd-49b1-a1ff-d84c2c31db41");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsCode"]/*SapAssetsCode*/,"SapAssetsCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","7dedb7c3-796d-4a2d-a9bc-5a26cb4c5e6a","7dedb7c3-796d-4a2d-a9bc-5a26cb4c5e6a","d6e9274c-e362-42cc-a29c-ef4f5d7549af");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsName"]/*SapAssetsName*/,"SapAssetsName", false, true, true, false, false, true, 0, 80, "5",true, false,"","ee7e92d9-07cd-4ef4-83b5-6388ed3902c3","ee7e92d9-07cd-4ef4-83b5-6388ed3902c3","5b42bc6b-7e76-49a0-a140-ebce5c4fd7e6");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeCode"]/*SapFeeCode*/,"SapFeeCode", false, true, true, false, false, true, 0, 88, "5",true, false,"","94542de0-291a-44d9-89f1-364987103093","94542de0-291a-44d9-89f1-364987103093","5f9f86c3-5f62-4a52-a67b-9af438ebfda9");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeName"]/*SapFeeName*/,"SapFeeName", false, true, true, false, false, true, 0, 90, "5",true, false,"","c1f50ca6-ec18-4e74-bf3f-1727b9eb4763","c1f50ca6-ec18-4e74-bf3f-1727b9eb4763","b79fa967-44a4-445b-9468-73b044992154");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Code0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Code"]/*U9Code*/,"U9Code", false, true, true, false, false, true, 0, 80, "5",true, false,"","c0642ed4-3884-485a-9c98-0ca8da8d3553","c0642ed4-3884-485a-9c98-0ca8da8d3553","190d58b6-ebd9-411f-95ef-3962412161f5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Name"]/*U9Name*/,"U9Name", false, true, true, false, false, true, 0, 80, "5",true, false,"","d160a23c-c265-4a0b-8b44-dfd05c5fca08","d160a23c-c265-4a0b-8b44-dfd05c5fca08","3cdb5667-1205-4b6f-a100-afd5ca407c5f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Memo"]/*Memo*/,"Memo", false, true, true, false, false, true, 0, 80, "5",true, false,"","47bce74f-a7fe-497f-a381-df2a88d69876","47bce74f-a7fe-497f-a381-df2a88d69876","4604aba9-3514-4138-9e82-1b2d02a5be34");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefStatus0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefStatus"]/*RefStatus*/,"RefStatus", false, true, true, false, false, true, 2, 80, "10",true, false,"","02840168-4759-4c5c-b24a-a1e1844f47eb","02840168-4759-4c5c-b24a-a1e1844f47eb","b9e85e87-bf34-42ea-b439-282b60ac5594");
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
            listItem = UIControlBuilder.BuildListItem(container,"0", true,false,"130bc338-9958-4133-9b7f-9c185bc2455a","65366375-5c9b-4f63-b994-8c06534d7a53");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"49790074-95af-497d-ae37-16bb697f3ce6","69473d82-9642-44b3-ae4b-3f9696902aa0");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,true,"517d6f15-ca0d-4e3b-aa58-3c85a5b2ae66","6ee1f92f-0e2e-4048-9995-26a4a86f7d55");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"ea7795fe-8961-4c3f-8ed1-b5128be2cd75","af92acce-e605-4972-914a-b98ac4171378");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}
