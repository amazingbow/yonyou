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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "1","","7ccaea68-530e-4f3a-894f-1060c1bda841");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(45,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(180,bool.Parse("False")),new GridColumnDef(15,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(60,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 45, 20, 0, 0, 1, 1, "100","9bf97f14-74b9-4a4f-b2fc-d5bfb9c95e3a","f693a83e-e93d-49e6-97ca-2c110da36d22");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "0");		


		        this.SelectList = UIControlBuilder.BuilderDropDownList(_UFCard, "SelectList", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"","","31efd45f-8f90-48f8-a17b-df4bec7751fc");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SelectList, "False", "", null, null, "");
			EnumControlsMap.Add(this.SelectList, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.SelectList, "1");		
		 

	
			_BuilderControl_WizardControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.WizardControl0, "2");		


				this.lblContinueCheckBox = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContinueCheckBox", "", "False", "True", "Right", 80, 20, 6, 0, 1, 1, "100","0aead14b-b05a-4582-9aca-34da4f4bf7a0","7b281b5b-3f61-48da-97b2-9ede2930a53d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContinueCheckBox, "3");		


				this.ContinueCheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ContinueCheckBox", false, true, "Left", 60, 0, 30, 20, 8, 0, 1, 1, "100",true,"lblContinueCheckBox","","5d49465e-dc8c-4de6-830a-0e7f2fe302aa");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContinueCheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.ContinueCheckBox, "4");		
		 

				this.FindButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "FindButton", true, true, 60, 20, 10, 0, 1, 1, "100","R", this.Model.ElementID,"",false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","b8751281-d45c-4c59-a7b0-07709d30235d");
	

		
			UIControlBuilder.BuilderUFControl(this.FindButton, "4");		


				this.CheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "CheckBox", false, true, "Left", 60, 0, 30, 20, 0, 0, 1, 1, "100",false,"","","ed56e345-9a53-4455-bae7-48bdab7a09d3");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"FunctionBar", true, true, "0","","11f2b207-079d-451e-90ea-d4656a481e32");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"CardForRefQueryCase",false,"none", true, true, "0","","43d38d5a-b388-45c2-8e7c-a7910a570388");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 360, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 6, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(150,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.CardForRefQueryCase = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.QryButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "QryButton", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"3664768b-36ca-44ab-9583-8d85fb432e43","3664768b-36ca-44ab-9583-8d85fb432e43","b0ad0ae3-5e97-4e56-b394-e4e0d9a8714d");
	

		
			UIControlBuilder.BuilderUFControl(this.QryButton, "1");		


				this.lbCase = UIControlBuilder.BuilderUFLabel(_UFCard, "lbCase", "", "True", "True", "Right", 80, 20, 3, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","f16a8067-1c29-4e2e-9677-7b7add76df3d");


								

		
			UIControlBuilder.BuilderUFControl(this.lbCase, "1");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 150, 20, 5, 0, 1, 1, "100",true,false,"","","ee58c89e-1c06-47d7-84cd-00959ac41742");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","51780f33-70f4-45a4-bbdb-89e7a20b966f");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 170, 20, 2, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.ConfirmButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "ConfirmButton", true, true, 80, 20, 0, 0, 1, 1, "100","O", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","acfd7731-06ed-4b8c-858b-139735c0863e");
	

		
			UIControlBuilder.BuilderUFControl(this.ConfirmButton, "3");		


				this.CancelButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "CancelButton", true, true, 80, 20, 2, 0, 1, 1, "100","C", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","fb40bdb9-3019-492a-b0fe-809f513a610e");
	

		
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
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.cRef.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, true, 7, 80, "19",true, false,"","75e48d90-aef3-49b2-bff0-2573deefcd4c","75e48d90-aef3-49b2-bff0-2573deefcd4c","36067444-abbc-4c3f-bbf0-bbc07c592359");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.FixedPoint, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
	
    if (this.UseQueryCase && UFIDA.UBF.Query.CommonService.RefQueryHelper.QueryCaseExist(this.Action, null))
    {
            return;
    }
	 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefType0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefType"]/*RefType*/,"RefType", false, true, true, false, false, true, 2, 80, "5",true, false,"","518ace3d-1b79-4b34-b079-440d03bdd270","518ace3d-1b79-4b34-b079-440d03bdd270","aa22fdf1-56cb-4e99-8884-0a2d349105c6");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCode"]/*SapCode*/,"SapCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","89343fe6-bea5-463c-818d-4ca683353fca","89343fe6-bea5-463c-818d-4ca683353fca","671cd528-1cf1-471b-8c2a-31a96cd90acb");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapName"]/*SapName*/,"SapName", false, true, true, false, false, true, 0, 80, "5",true, false,"","cbcfdf4c-8ef6-4a07-aca8-4bff5406b699","cbcfdf4c-8ef6-4a07-aca8-4bff5406b699","3ccf5673-b019-4590-bd61-1992ebd9aeb8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompCode"]/*SapCompCode*/,"SapCompCode", false, true, true, false, false, true, 0, 90, "5",true, false,"","e10f2cb8-a404-4112-9e2e-882c9a0c9630","e10f2cb8-a404-4112-9e2e-882c9a0c9630","7953080f-4133-474a-ae11-029b29908dac");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapCompName"]/*SapCompName*/,"SapCompName", false, true, true, false, false, true, 0, 90, "5",true, false,"","0b041899-a394-4f7d-8caf-e1a128942281","0b041899-a394-4f7d-8caf-e1a128942281","a914d942-8c93-4d11-8cb4-d5a730203cfc");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SupplierCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SupplierCode"]/*SupplierCode*/,"SupplierCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","d8f621dc-3faf-42ac-a44a-5859130bca57","d8f621dc-3faf-42ac-a44a-5859130bca57","e546136e-b5d7-42ba-9ecd-de74a1bf9309");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SupplierName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SupplierName"]/*SupplierName*/,"SupplierName", false, true, true, false, false, true, 0, 80, "5",true, false,"","9af6985f-f74b-4a4a-a9a1-900f481ae543","9af6985f-f74b-4a4a-a9a1-900f481ae543","b0ce493c-aaf0-49fc-b67e-b85d0f5f8252");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterCode"]/*SapMasterCode*/,"SapMasterCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","20786810-bdfb-4d4c-8405-58384b3f37b2","20786810-bdfb-4d4c-8405-58384b3f37b2","3dc38672-f2fe-4eef-9861-d905e7161f23");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapMasterName"]/*SapMasterName*/,"SapMasterName", false, true, true, false, false, true, 0, 80, "5",true, false,"","26aa2d14-dda8-4f70-811a-8adb1da54cd6","26aa2d14-dda8-4f70-811a-8adb1da54cd6","86f5a038-6624-42ef-8039-d4da01e64355");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsCode"]/*SapAssetsCode*/,"SapAssetsCode", false, true, true, false, false, true, 0, 80, "5",true, false,"","2fa225ee-2cae-4b87-9b86-0774bf376240","2fa225ee-2cae-4b87-9b86-0774bf376240","c9c48237-f958-4450-8163-f6285c9a87a1");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapAssetsName"]/*SapAssetsName*/,"SapAssetsName", false, true, true, false, false, true, 0, 80, "5",true, false,"","216dc6cf-fdff-4718-a3c3-17a05a2f3b91","216dc6cf-fdff-4718-a3c3-17a05a2f3b91","210e3a8b-aea7-4114-855d-8e7adb55a66e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeCode0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeCode"]/*SapFeeCode*/,"SapFeeCode", false, true, true, false, false, true, 0, 90, "5",true, false,"","f6622fe3-8422-4a1c-b3df-ef036ef6129a","f6622fe3-8422-4a1c-b3df-ef036ef6129a","aac938f8-344d-47f4-aaab-f410ed060e9a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeName0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["SapFeeName"]/*SapFeeName*/,"SapFeeName", false, true, true, false, false, true, 0, 90, "5",true, false,"","2d4c44a3-ab9f-4183-900e-2ff207cab02a","2d4c44a3-ab9f-4183-900e-2ff207cab02a","e14c925d-d9fc-4053-903e-b63d785937bd");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Code0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Code"]/*U9Code*/,"U9Code", false, true, true, false, false, true, 0, 80, "5",true, false,"","9c6c641a-7fe4-4034-8eaf-ce359397b236","9c6c641a-7fe4-4034-8eaf-ce359397b236","8d51d5b2-2cab-448a-a715-1d36e976e75e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["U9Name"]/*U9Name*/,"U9Name", false, true, true, false, false, true, 0, 80, "5",true, false,"","8f8afd37-4082-4d4f-ac16-199af494fdb0","8f8afd37-4082-4d4f-ac16-199af494fdb0","1ad747c2-62dd-40ec-be00-a946c5008e9a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefStatus0","DropDownListColumnModel", "", 0,this.Model.cRef.Fields["RefStatus"]/*RefStatus*/,"RefStatus", false, true, true, false, false, true, 2, 80, "10",true, false,"","be869a9e-36d6-457c-af7a-bf876a0614a2","be869a9e-36d6-457c-af7a-bf876a0614a2","34f88337-4abf-446d-984b-a33e7a6331ed");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Memo"]/*Memo*/,"Memo", false, true, true, false, false, true, 0, 80, "5",true, false,"","da921d49-8010-40e8-bf19-7e06b68f4e94","da921d49-8010-40e8-bf19-7e06b68f4e94","2b3f4da1-8671-4190-a786-c1e3503fbd2c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 
        }

	        private void _BuilderControl_MatchTypeRadioBoxList(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"MatchTypeRadioBoxList",true,true,"6",0,4,UFSoft.UBF.UI.ControlModel.LineOrientation.Horizontal);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 560, 20, 0, 1, 1, 1, "100");
            this.MatchTypeRadioBoxList = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"0", true,false,"130bc338-9958-4133-9b7f-9c185bc2455a","da3b351a-d0fa-4fbd-8b26-748cbf4ecf78");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"49790074-95af-497d-ae37-16bb697f3ce6","61f59fb2-ebc6-4a63-92a1-09d2d470f746");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,true,"517d6f15-ca0d-4e3b-aa58-3c85a5b2ae66","f718af48-ec0e-4ba8-8b63-73fc939c5744");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"ea7795fe-8961-4c3f-8ed1-b5128be2cd75","8dea8392-00b7-4cdb-9ca7-7a41ee7c07ee");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}
