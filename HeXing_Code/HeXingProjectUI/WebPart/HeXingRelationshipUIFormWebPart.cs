


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
 * Form ID:08a95d41-2b13-4475-a92e-2bedf77981b6 
 * Form Name:HeXingRelationshipUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.HeXingProjectUI.HeXingRelationshipUIModel
{
	[FormRegister("UFIDA.U9.Cust.HeXingProjectUI","UFIDA.U9.Cust.HeXingProjectUI.HeXingRelationshipUIModel.HeXingRelationshipUIFormWebPart", "UFIDA.U9.Cust.HeXingProjectUI.WebPart", "08a95d41-2b13-4475-a92e-2bedf77981b6","WebPart", "True", 810, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.HeXingProjectUI', 'UFIDA.U9.Cust.HeXingProjectUI.HeXingRelationshipUIModel.HeXingRelationshipUIFormWebPart', 'UFIDA.U9.Cust.HeXingProjectUI.WebPart', '08a95d41-2b13-4475-a92e-2bedf77981b6')
	///<siteMapNode url="~/erp/simple.aspx?lnk=08a95d41-2b13-4475-a92e-2bedf77981b6" title="HeXingRelationshipUIForm"/>
    public partial class HeXingRelationshipUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(HeXingRelationshipUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new HeXingRelationshipUIModelAction Action
		{
			get { return (HeXingRelationshipUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		HeXingRelationshipUIModelModel _uimodel=null;
		public new HeXingRelationshipUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new HeXingRelationshipUIModelModel();
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
                this.Model = value as HeXingRelationshipUIModelModel;
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
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFButton BtnExecute;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public HeXingRelationshipUIFormWebPart()
        {
            FormID = "08a95d41-2b13-4475-a92e-2bedf77981b6";
            IsAutoSize = bool.Parse("True");
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
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnUndoApprove.Click += new EventHandler(BtnUndoApprove_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnExecute.Click += new EventHandler(BtnExecute_Click);		
						

	
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
					this.Model = new HeXingRelationshipUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (HeXingRelationshipUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
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
            this.Action = new HeXingRelationshipUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"HeXingRelationshipUIForm",true,810,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(810,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",810, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","285ac26a-9916-4866-9630-2bcfb42ffd48");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","6fcba5fd-2d29-448e-9780-06851db815fc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","ac1927ca-c45d-4030-9a7c-b32eb7948bd4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","383f4dd7-e2bd-4d4e-a580-4fd55eca59bd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","2e3b09a5-f562-49e3-843a-fb1a3cd4dcd9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","6cc62133-2bf6-4a15-b62f-4aa83d5cd86a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","822d1b2d-f60d-4d61-ba2d-7e6714fc72b3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","e0c4e4f2-6705-47cc-b7f6-fbbe4bce7199");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "UndoApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","eb562856-8b56-4305-a85a-f73cae957bc9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","ee0a6563-a2e6-48f0-88a0-598fb9011536");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","3b68cc3e-2fb3-4bb3-abfc-e8a4b72fff89");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","9e8eb4d2-6e25-4625-b80e-e6e673cd0002");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","94e20d1c-5e03-43d6-8826-a422278161ca");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","b28d59f3-4b37-4b9d-96a0-468d5c239bad");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","bfa2197b-5d40-4802-9e57-979cdfe375b5");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 810, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 18, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(69,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnExecute = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnExecute", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"ExecuteClick",false,"0a785d3c-e96b-4e52-9cd5-230cc3c2f834","","0a785d3c-e96b-4e52-9cd5-230cc3c2f834");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnExecute, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","d789cd92-5167-4c3c-b371-745d29c0e4a1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 810, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(789,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, false,false,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 790, 421, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.HxRelationshipBE, "HxRelationshipBE", "", null, 20, "合兴关系对照表");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","ecaf13aa-2c77-4b87-9024-7704e1f5a4d8","ecaf13aa-2c77-4b87-9024-7704e1f5a4d8","77eb46ec-3188-4dc4-b199-10645fc4782f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion0","NumberColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","f1829c97-c313-4e62-89be-5dd7d786c95f","f1829c97-c313-4e62-89be-5dd7d786c95f","7edcfbd1-3e99-4965-9aa2-d05496ce1b2d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CreatedOn0","DatePickerColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["CreatedOn"]/*CreatedOn*/,"CreatedOn", false, false, false, false, false, true, 5, 70, "8",true, false,"","4ee8c152-70a7-4bd2-9598-cd189c218f11","4ee8c152-70a7-4bd2-9598-cd189c218f11","5ddd1118-a2e6-4e23-9a37-efcab876cf34");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefType0","DropDownListColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["RefType"]/*RefType*/,"RefType", false, true, false, false, false, true, 2, 100, "10.0",true, false,"0","bb87125b-7d19-479a-8563-e7b7fbee89c1","bb87125b-7d19-479a-8563-e7b7fbee89c1","6ef25b02-83b6-494f-b0ef-3186208f1eca");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapCode"]/*SapCode*/,"SapCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","137176ee-9aa4-4f3d-ba3b-8b95de86a4e4","137176ee-9aa4-4f3d-ba3b-8b95de86a4e4","c400a433-6944-4ffe-a9ca-db51cd59b78d");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapName"]/*SapName*/,"SapName", false, true, false, false, false, true, 0, 100, "50",true, false,"","8a2be990-b525-4a19-bcab-9a642baa2cf0","8a2be990-b525-4a19-bcab-9a642baa2cf0","433990c7-c60e-4a02-8386-62f4c5a58d67");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapCompCode"]/*SapCompCode*/,"SapCompCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","7299f575-d3a4-48c3-94cb-97fb30c995fe","7299f575-d3a4-48c3-94cb-97fb30c995fe","d5bd708c-d476-4154-aa32-607a22de6a1f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapCompName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapCompName"]/*SapCompName*/,"SapCompName", false, true, false, false, false, true, 0, 100, "50",true, false,"","a327770a-b819-4d9c-9749-753db06f40bd","a327770a-b819-4d9c-9749-753db06f40bd","8c62b99e-3077-4df7-ad62-14c59706ffc5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustomerCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["CustomerCode"]/*CustomerCode*/,"CustomerCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","c8e119b1-0cfb-445e-8387-16d76e8b62af","c8e119b1-0cfb-445e-8387-16d76e8b62af","afc58899-ba10-473c-9cbb-f9c8f1dc2769");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustomerName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["CustomerName"]/*CustomerName*/,"CustomerName", false, true, false, false, false, true, 0, 100, "50",true, false,"","9a496b18-ee3d-47a6-942c-70bd7599d3cf","9a496b18-ee3d-47a6-942c-70bd7599d3cf","c7e967de-4488-4a60-92f2-35f687c4bde7");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapMasterCode"]/*SapMasterCode*/,"SapMasterCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","d6162569-7196-4605-9c02-099ed5dbd1c3","d6162569-7196-4605-9c02-099ed5dbd1c3","175e62e2-f903-4146-ac80-8461b2975510");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapMasterName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapMasterName"]/*SapMasterName*/,"SapMasterName", false, true, false, false, false, true, 0, 100, "50",true, false,"","c361151e-0c86-4cd1-8792-1c8e23fe11ac","c361151e-0c86-4cd1-8792-1c8e23fe11ac","8a9f6d54-5b6f-494a-b29e-326f3faa859f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapAssetsCode"]/*SapAssetsCode*/,"SapAssetsCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","9d492307-7203-4d53-a680-f033380c7dcb","9d492307-7203-4d53-a680-f033380c7dcb","c7686d29-ba52-4de9-92b5-0d9f00fdb68d");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapAssetsName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapAssetsName"]/*SapAssetsName*/,"SapAssetsName", false, true, false, false, false, true, 0, 100, "50",true, false,"","2da922e8-ccd2-4f77-b723-cb64c2343e84","2da922e8-ccd2-4f77-b723-cb64c2343e84","89214fcb-83bd-47c9-9c85-abb87044531f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeCode0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapFeeCode"]/*SapFeeCode*/,"SapFeeCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","caced0ab-b24a-45fd-983e-15f67f841ef1","caced0ab-b24a-45fd-983e-15f67f841ef1","e8ea86f3-ea61-4715-9803-10a53fe61264");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SapFeeName0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["SapFeeName"]/*SapFeeName*/,"SapFeeName", false, true, false, false, false, true, 0, 100, "50",true, false,"","6972045c-86a3-48f0-a9d5-4d19560b4c44","6972045c-86a3-48f0-a9d5-4d19560b4c44","81fb6060-881a-4f6a-b029-d52acccc9111");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Code0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["U9Code"]/*U9Code*/,"U9Code", false, false, true, false, false, true, 0, 100, "50",true, false,"","cb604ff2-c28f-4f2d-86ef-6ac9b7bdae25","cb604ff2-c28f-4f2d-86ef-6ac9b7bdae25","87e94385-cd48-4d9a-a3b5-e31654307cfc");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9Name0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["U9Name"]/*U9Name*/,"U9Name", false, false, true, false, false, true, 0, 100, "50",true, false,"","b2aa358f-0865-4abe-be43-5340ccc67be1","b2aa358f-0865-4abe-be43-5340ccc67be1","bff7a14d-6dc2-4e27-a957-19f35108c329");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"U9EntityId0","ReferenceColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["U9EntityId"]/*U9EntityId*/,"U9EntityId", false, true, true, false, false, true, 7, 100, "19.0",true, false,"0","174540d5-3df7-4d36-8a83-04c33fbecddb","174540d5-3df7-4d36-8a83-04c33fbecddb","3b660753-2f07-4b5b-8a7b-2dd31c80bfbb");
            GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "RefID", "RefCode", "RefName", this.Model.HxRelationshipBE.FieldU9Code/*U9Code*/, this.Model.HxRelationshipBE.FieldU9Name/*U9Name*/, "27891913-4675-447f-b75e-edb4ef82b85c"
            , false, true, 632, 376);
            ((IUFFldReferenceColumn)column).CtrlId = "3b660753-2f07-4b5b-8a7b-2dd31c80bfbb";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							
									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime1", "DateTime", "Context");
								

									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime2", "DateTime", "Context");


            ((IUFFldReferenceColumn)column).AddReferenceInParameter("RefType", "RefType", "DataGrid1");


            ((IUFFldReferenceColumn)column).AddReferenceInParameter("SapCompCode", "SapCompCode", "DataGrid1");
								
						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo0","TextBoxColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["Memo"]/*Memo*/,"Memo", false, false, true, false, false, true, 0, 100, "50",true, false,"","3a709931-9052-459b-b87e-b3c6eaa692ef","3a709931-9052-459b-b87e-b3c6eaa692ef","36d7792b-f599-495b-a0ec-43cc7f92fb91");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RefStatus0","DropDownListColumnModel", "", 0,this.Model.HxRelationshipBE.Fields["RefStatus"]/*RefStatus*/,"RefStatus", false, true, false, false, false, true, 2, 100, "10.0",true, false,"0","7d50d23e-ee31-4bc6-9438-5e5391f65b5f","7d50d23e-ee31-4bc6-9438-5e5391f65b5f","17d8eafc-9f2c-47fd-b758-c09f5e5c43fc");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 
        }





		#endregion
		

	}
}
