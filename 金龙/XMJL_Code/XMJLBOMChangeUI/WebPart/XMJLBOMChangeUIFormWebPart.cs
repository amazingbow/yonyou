


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
 * Form ID:f8593747-907a-419b-84f5-fdd413d5d971 
 * Form Name:XMJLBOMChangeUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLBOMChangeUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI","UFIDA.U9.Cust.XMJL.XMJLBOMChangeUIModel.XMJLBOMChangeUIFormWebPart", "UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI.WebPart", "f8593747-907a-419b-84f5-fdd413d5d971","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI', 'UFIDA.U9.Cust.XMJL.XMJLBOMChangeUIModel.XMJLBOMChangeUIFormWebPart', 'UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI.WebPart', 'f8593747-907a-419b-84f5-fdd413d5d971')
	///<siteMapNode url="~/erp/simple.aspx?lnk=f8593747-907a-419b-84f5-fdd413d5d971" title="XMJLBOMChangeUIForm"/>
    public partial class XMJLBOMChangeUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBOMChangeUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new XMJLBOMChangeUIModelAction Action
		{
			get { return (XMJLBOMChangeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		XMJLBOMChangeUIModelModel _uimodel=null;
		public new XMJLBOMChangeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new XMJLBOMChangeUIModelModel();
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
                this.Model = value as XMJLBOMChangeUIModelModel;
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
        IUFButton BtnFind;
        IUFButton BtnApprove;
        IUFSeparator Separator2;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card3;
        IUFCard Card4;
        IUFLabel lblDocNo53;
        IUFFldTextBox DocNo53;
        IUFLabel lblChangeReason233;
        IUFFldTextBox ChangeReason233;
        IUFLabel lblChangeDateTime127;
        IUFFldDatePicker ChangeDateTime127;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblID55;
        IUFFldNumberControl ID55;
        IUFLabel lblSysVersion68;
        IUFFldNumberControl SysVersion68;
        IUFLabel lblChangeStat48;
        IUFFldCheckBox ChangeStat48;
        IUFTabControl TabControl1;
        IUFTabPage TabPage9;
        IUFDataGrid DataGrid9;
        IUFTabPage TabPage15;
        IUFDataGrid DataGrid7;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public XMJLBOMChangeUIFormWebPart()
        {
            FormID = "f8593747-907a-419b-84f5-fdd413d5d971";
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
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid9).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid9_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid9).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid9_GridCustomFilterHandler);
	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid7).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid7_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid7).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid7_GridCustomFilterHandler);

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
					this.Model = new XMJLBOMChangeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (XMJLBOMChangeUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new XMJLBOMChangeUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"XMJLBOMChangeUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(30,bool.Parse("True")),new GridRowDef(420,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "6");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "4");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "5");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "6",992, 30, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 30,"0", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","37aba4c2-bd79-4430-bc96-cefc048d6d37");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 30,"1", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","613d6d50-e014-43c6-94bd-dbe793979f6e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 30,"2", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","0e431a5f-57b6-4bd8-afa8-00aac7b82913");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 30,"3", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","ac8a094a-f4d8-4473-bae0-b2dd6767a0ec");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 30,"4", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","0f4c06d4-f7df-4420-a144-6ef5fb411bcb");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "False", 35, 30,"5", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","25a92737-c57c-4104-8333-571e9be662ac");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "";
	                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 30,"7", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","271ea4a5-969c-4f7d-b7db-597141397ffa");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "False", 60, 30,"6", "",true,false,"c92b634c-7c75-4165-9bff-e6e988cd39da","c92b634c-7c75-4165-9bff-e6e988cd39da","a9953e27-041c-4ca5-8b14-c8723cc0c94f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 30,"8", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","9a6eef72-855d-4c14-81a2-831212dae3ad");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 30,"9", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","4b510983-4d1d-451d-b2e0-cfc05215cf27");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 30,"10", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","abb1a450-7102-4326-8e91-190d25281e05");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 30,"11", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","6f2b6f0b-dab3-442c-8b76-30a0387cc083");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 30,"12", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","eccdfbf2-d465-47df-a9a6-02287210c5c4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "False", 35, 30,"13", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","69697736-12ea-4f3b-a547-ace31bb28be3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "False", 35, 30,"14", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","e8e2e666-402a-41cf-8a01-ce202eb93d75");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "False", 35, 30,"15", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","cba3d47e-3722-4645-a2f2-b9068a088e00");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "False", 35, 30,"16", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","e462ba12-9e73-4915-bff6-07731af5eb53");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "4","","eb5012cf-226e-415c-bc97-b49f51437644");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"47f511f5-ca22-4e6d-b88d-0e51fb6984a7","","47f511f5-ca22-4e6d-b88d-0e51fb6984a7");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "28");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, false, 80, 20, 0, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","beea6318-31c3-4e0c-a2d8-e72bce4c48de");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "29");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "5","","cf633458-cad7-4701-8ada-c83bc9b73ad1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 420, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(986,bool.Parse("True")),new GridColumnDef(2,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(100,bool.Parse("True")),new GridRowDef(272,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card4(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		


	
			_BuilderControl_TabControl1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl1, "1");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",true,"none", true, true, "2","e2b6eecb-855b-4fbf-b210-2739039dae9f","295fd1ea-01c0-46c6-9648-ba26fedb83f8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 986, 100, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 4, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.Cust_Xmjl_MO_BomChange, "Cust_Xmjl_MO_BomChange", "", null, 1, "缺件变更单");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(50,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(50,bool.Parse("True")),new GridColumnDef(139,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(139,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblDocNo53 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocNo53", "", "True", "True", "Right", 140, 20, 0, 0, 1, 1, "100","e2b6eecb-855b-4fbf-b210-2739039dae9f","2a636fb5-1ecd-4b38-b81e-fdfbaa78c161");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocNo53, "0");		


				this.DocNo53 = UIControlBuilder.BuilderTextBox(_UFCard, "DocNo53", "True", "True", "True", "False", "Left", 0, 60, 0, 140, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblDocNo53","","50","e2b6eecb-855b-4fbf-b210-2739039dae9f","e773ff14-47f0-4a8b-8208-81e8aff75723");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocNo53, "False", "DocNo", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldDocNo, "Cust_Xmjl_MO_BomChange");


		
			UIControlBuilder.BuilderUFControl(this.DocNo53, "1");		
		 

				this.lblChangeReason233 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblChangeReason233", "", "True", "True", "Right", 140, 20, 0, 1, 1, 1, "100","969a8dba-7941-4bc3-b9ba-a70635664526","d10f7034-bbe8-4f9c-8a3a-0720b76dc62e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblChangeReason233, "2");		


				this.ChangeReason233 = UIControlBuilder.BuilderTextBox(_UFCard, "ChangeReason233", "True", "True", "True", "True", "Left", 0, 60, 0, 480, 70, 2, 1, 5, 3, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblChangeReason233","","50","969a8dba-7941-4bc3-b9ba-a70635664526","f3d494b4-eded-4b7f-92c6-931b4c482ecf");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ChangeReason233, "False", "ChangeReason", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldChangeReason, "Cust_Xmjl_MO_BomChange");


		
			UIControlBuilder.BuilderUFControl(this.ChangeReason233, "3");		
		 

				this.lblChangeDateTime127 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblChangeDateTime127", "", "True", "True", "Right", 140, 20, 4, 0, 1, 1, "100","f2f5d828-8f64-4717-a3e0-fcf6efe905a6","c098df99-dc7b-49a1-a464-d0d78b08cdb9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblChangeDateTime127, "4");		


				this.ChangeDateTime127 = UIControlBuilder.BuilderDatePicker(_UFCard, "ChangeDateTime127", true, true, true, "DateTime","Left", 5, 60, 0, 140, 20, 6, 0, 1, 1, "100",true,false,"lblChangeDateTime127","f2f5d828-8f64-4717-a3e0-fcf6efe905a6","37930677-23b4-4a40-a525-3d6aa54c37a6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ChangeDateTime127, "False", "ChangeDateTime", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldChangeDateTime, "Cust_Xmjl_MO_BomChange");


		
			UIControlBuilder.BuilderUFControl(this.ChangeDateTime127, "5");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 139, 20, 8, 2, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","c427abfe-7218-4e53-b1d2-1da17f926e73");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "6");		
		 

				this.lblID55 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID55", "", "False", "True", "Right", 139, 20, 0, 0, 1, 1, "100","275a6a00-8e03-4ee4-8e27-7a32d6d815d0","309794aa-660e-4af9-a29f-af0a096ade28");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID55, "7");		


				this.ID55 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID55", "False", "False", "True", "Left", 7, 60, 0, 139, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID55","8.0","275a6a00-8e03-4ee4-8e27-7a32d6d815d0","b6fb1ebb-fc1c-4973-b387-9bf26ba5aad7",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID55, "False", "ID", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldID, "Cust_Xmjl_MO_BomChange");
	
		
			UIControlBuilder.BuilderUFControl(this.ID55, "8");		
		 

				this.lblSysVersion68 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion68", "", "False", "True", "Right", 139, 20, 0, 0, 1, 1, "100","1c79f00f-b57d-48ce-a102-bb134df5a5e8","2642832d-7231-41e6-9a24-f0b3ae866bb2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion68, "9");		


				this.SysVersion68 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion68", "True", "False", "True", "Left", 7, 60, 0, 139, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion68","8.0","1c79f00f-b57d-48ce-a102-bb134df5a5e8","c0f3348d-31a8-40ce-84e2-3a2daa48ecbc",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion68, "False", "SysVersion", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldSysVersion, "Cust_Xmjl_MO_BomChange");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion68, "10");		
		 

				this.lblChangeStat48 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblChangeStat48", "", "True", "True", "Right", 139, 20, 8, 0, 1, 1, "100","af0c8284-6abb-4e49-aa84-432d49d0cabc","51f8fa57-568c-4e65-b0e5-44d42b727d1e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblChangeStat48, "11");		


				this.ChangeStat48 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ChangeStat48", true, true, "Left", 60, 0, 139, 20, 10, 0, 1, 1, "100",false,"lblChangeStat48","af0c8284-6abb-4e49-aa84-432d49d0cabc","de8d6b6e-eefa-4db8-be6e-080b2aca1e97");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ChangeStat48, "False", "ChangeStat", this.Model.Cust_Xmjl_MO_BomChange, this.Model.Cust_Xmjl_MO_BomChange.FieldChangeStat, "Cust_Xmjl_MO_BomChange");
		

		
			UIControlBuilder.BuilderUFControl(this.ChangeStat48, "12");		
		 


													

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl1(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl1",true, true, "1",EventResponseType.Client,986, 283, 0, 1, 1, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage9(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage15(_UFTabControl));
            this.TabControl1 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage9(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage9",true, true, "0","31d64344-8058-411f-8ca1-969e88ba5a05","31d64344-8058-411f-8ca1-969e88ba5a05");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 2, 2, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(953,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(223,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid9(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid9, "0");		



	

            this.TabPage9 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid9(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid9", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 953, 229, 0, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem, "Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem", "", null, 20, "缺件变更单.Misc.缺件变更料号行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid9 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID56","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","b8313d09-55c1-4a23-880a-3b09fba8e384","b8313d09-55c1-4a23-880a-3b09fba8e384","657db899-59bb-4e02-b399-f51c42e89b85");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion69","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","be673746-d419-4920-b90a-d966bd1c948d","be673746-d419-4920-b90a-d966bd1c948d","18f5d7db-3e4c-4b78-9d49-b392adf4939a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Item2","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["Item"]/*Item*/,"Item", false, true, true, false, false, false, 7, 100, "19.0",true, false,"","ab49bb38-8d5f-41c8-8e4f-37ff076935d7","ab49bb38-8d5f-41c8-8e4f-37ff076935d7","6f53c356-2ef9-445f-ad36-59fb8c1351a3");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Code/*Item_Code*/, this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Code/*Item_Code*/, "220d5b81-a3b8-4124-af76-8faa43801268"
			,false,true,580,420);
            ((IUFFldReferenceColumn)column).CtrlId = "6f53c356-2ef9-445f-ad36-59fb8c1351a3";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							
									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("CurDate", "DateTime", "Context");
								
						
            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Item", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Item", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Item_Name", "Value"));
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Item_Name116","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["Item_Name"]/*Item_Name*/,"Item_Name", false, true, true, false, false, false, 0, 100, "255",true, false,"","3312a94d-fcb8-467d-a3c7-0b85992c9570","3312a94d-fcb8-467d-a3c7-0b85992c9570","fc44ec4d-d388-40aa-a78b-b8a11350806e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","255") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Supplier0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["Supplier"]/*Supplier*/,"Supplier", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","0cc6c2d3-c688-4f47-aab7-82826c96f515","0cc6c2d3-c688-4f47-aab7-82826c96f515","48d47f34-8d7a-4ede-b245-4242c1138781");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Code/*Supplier_Code*/, this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Name/*Supplier_Name*/, "b8ca6928-d125-48d5-b0c3-29c5d60e793c"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "48d47f34-8d7a-4ede-b245-4242c1138781";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Supplier", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Supplier", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Supplier", "Text"));
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"WorkPlace0","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["WorkPlace"]/*WorkPlace*/,"WorkPlace", false, true, true, false, false, true, 0, 100, "50",true, false,"","4a7f1e97-b884-4d03-8462-f235f63dc9df","4a7f1e97-b884-4d03-8462-f235f63dc9df","46aeeb7d-1544-42bb-b685-2add2acee93f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DistQty0","NumberColumnModel", "", 3,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Fields["DistQty"]/*DistQty*/,"DistQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","33db4024-f660-451a-881b-d61f5b71caac","33db4024-f660-451a-881b-d61f5b71caac","68fccf24-0f23-4342-806b-e3e15d4c23dd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }

	        private IUFTabPage _BuilderControl_TabPage15(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage15",true, true, "7","52889aae-5a6c-4ce9-9188-915981f1454a","52889aae-5a6c-4ce9-9188-915981f1454a");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 2, 2, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(953,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(223,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid7(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid7, "0");		



	

            this.TabPage15 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid7(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid7", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 953, 229, 0, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo, "Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo", "", null, 20, "缺件变更单.Misc.缺件变更车号行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid7 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID57","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","c0ca8e0a-85a4-49ba-b28c-a1eabc697dd9","c0ca8e0a-85a4-49ba-b28c-a1eabc697dd9","0c10b9f6-2408-4f83-8603-a071e16aa4e3");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion70","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","a5f74d26-5484-4230-be8a-6198d2760d8b","a5f74d26-5484-4230-be8a-6198d2760d8b","ab12ca82-6a8b-4981-8794-bafc2be56a64");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ManufactureNO0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.Fields["ManufactureNO"]/*ManufactureNO*/,"ManufactureNO", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","520a8465-f382-479b-95c7-534e084b7180","520a8465-f382-479b-95c7-534e084b7180","d3621e79-a740-4a8f-85d5-7ae23836cc52");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Code/*ManufactureNO_Code*/, this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Code/*ManufactureNO_Code*/, "c8ec4023-bc9a-4bf0-8415-6bc3ba55283c"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "d3621e79-a740-4a8f-85d5-7ae23836cc52";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "ManufactureNO", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "ManufactureNO", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "ManufactureNO", "Text"));
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractNo0","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.Fields["ContractNo"]/*ContractNo*/,"ContractNo", false, true, true, false, false, true, 0, 100, "50",true, false,"","c05e2afc-762c-4da8-8f17-77e75c06d0ec","c05e2afc-762c-4da8-8f17-77e75c06d0ec","2b1b1264-6a65-4552-b52b-3a55f467fb84");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CarType0","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.Fields["CarType"]/*CarType*/,"CarType", false, true, true, false, false, true, 0, 100, "50",true, false,"","78071efa-5804-411a-b3da-bdc06773feac","78071efa-5804-411a-b3da-bdc06773feac","23a462be-c27d-49f0-9762-43219e78cf6c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
