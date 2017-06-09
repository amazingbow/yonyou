


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
 * Form ID:50e4e7ec-2c5f-4059-af07-d546f82715e5 
 * Form Name:SpecialApplyUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel
{
	[FormRegister("UFIDA.U9.Cust.SpecialApplyUI","UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel.SpecialApplyUIFormWebPart", "UFIDA.U9.Cust.SpecialApplyUI.WebPart", "50e4e7ec-2c5f-4059-af07-d546f82715e5","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.SpecialApplyUI', 'UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel.SpecialApplyUIFormWebPart', 'UFIDA.U9.Cust.SpecialApplyUI.WebPart', '50e4e7ec-2c5f-4059-af07-d546f82715e5')
	///<siteMapNode url="~/erp/simple.aspx?lnk=50e4e7ec-2c5f-4059-af07-d546f82715e5" title="SpecialApplyUIForm"/>
    public partial class SpecialApplyUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecialApplyUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SpecialApplyUIModelAction Action
		{
			get { return (SpecialApplyUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		SpecialApplyUIModelModel _uimodel=null;
		public new SpecialApplyUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SpecialApplyUIModelModel();
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
                this.Model = value as SpecialApplyUIModelModel;
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
        IUFSeparator Separator2;
        IUFButton BtnFind;
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
        IUFCard Card5;
        IUFTabControl TabControl4;
        IUFTabPage TabPage31;
        IUFLine Line0;
        IUFLine Line1;
        IUFLabel lblApplyDept71;
        IUFFldReference ApplyDept71;
        IUFLabel lblApplier86;
        IUFFldTextBox Applier86;
        IUFLabel lblPhone155;
        IUFFldTextBox Phone155;
        IUFLabel lblQQ149;
        IUFFldTextBox QQ149;
        IUFLabel lblApplyDate131;
        IUFFldDatePicker ApplyDate131;
        IUFLabel lblCustName104;
        IUFFldTextBox CustName104;
        IUFLabel lblCustPhone77;
        IUFFldTextBox CustPhone77;
        IUFLabel lblCustConterName149;
        IUFFldTextBox CustConterName149;
        IUFLabel lblCustAddress121;
        IUFFldTextBox CustAddress121;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFTabPage TabPage32;
        IUFLabel lblSpecialDesignStyle119;
        IUFFldDropDownList SpecialDesignStyle119;
        IUFLabel Label2737;
        IUFLabel Label2738;
        IUFLabel Label2739;
        IUFLabel Label2740;
        IUFImage Image0;
        IUFImage Image1;
        IUFTabControl TabControl5;
        IUFTabPage TabPage36;
        IUFDataGrid DataGrid14;
        IUFCard Card7;
        IUFLabel Label2741;
        IUFLabel Label2742;
        IUFCard Card6;
        IUFLabel lblID60;
        IUFFldNumberControl ID60;
        IUFLabel lblSysVersion56;
        IUFFldNumberControl SysVersion56;
        IUFLabel lblAdvCode72;
        IUFFldTextBox AdvCode72;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SpecialApplyUIFormWebPart()
        {
            FormID = "50e4e7ec-2c5f-4059-af07-d546f82715e5";
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
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						

			
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid14).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid14_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid14).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid14_GridCustomFilterHandler);
	
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
					this.Model = new SpecialApplyUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (SpecialApplyUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new SpecialApplyUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SpecialApplyUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card5(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card5, "2");		


	
			_BuilderControl_Card6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card6, "0");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","e7252edf-3eb1-42d7-95fa-18ce84d522f7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","12514d7d-eadb-4a17-a008-0b30ee96713c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","3eb41e72-66bc-413b-aad8-93b17424b77b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","a86172ab-8c55-4182-907a-a5a7a91bed2d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","db03c9f3-ad17-4629-9fdb-2c5f8dee8255");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","a34738a4-4716-416c-ad10-27b1a501980d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","ed2da758-617c-46fb-8f75-eb19e683200d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","2ec71df4-a157-449c-8aa3-7be4c62dde33");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","4cffd97c-dd38-42e1-ba99-eae14e320f51");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","67ef2c71-33dc-4327-8d72-0c18b8253198");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","772607fc-9c64-453c-aacb-17581bccda9a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","6a8a0c79-f01b-4a2a-8424-f728b03e277b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","c9390609-fdcd-4765-9ccf-035d74ab994f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","6c6ce977-2a03-4e53-bd06-8f1967f9169d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","10189d9f-c51e-4049-af51-5e446a4c082f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card5(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card5",false,"none", true, true, "2","","187eb1f3-4582-4a1a-8d19-07a77903d8ed");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(190,bool.Parse("True")),new GridRowDef(205,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card5 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl4(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl4, "1");		


	
			_BuilderControl_TabControl5(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl5, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl4(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl4",true, true, "1",EventResponseType.Client,972, 190, 0, 0, 2, 1, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage31(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage32(_UFTabControl));
            this.TabControl4 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage31(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage31",true, true, "1","e6931b0d-dd0c-48b9-b491-fa2b4dbe9089","e6931b0d-dd0c-48b9-b491-fa2b4dbe9089");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 12, 6, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.SpecialApplyBE, "SpecialApplyBE", "", null, 1, "专柜申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 953, "Horizontal", "True", 953, 20, 0, 0, 11, 1, "100","e23f05fe-d7ec-480a-9ec0-d61c01dd4f78","e23f05fe-d7ec-480a-9ec0-d61c01dd4f78");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.Line1 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line1", 953, "Horizontal", "True", 953, 20, 0, 3, 11, 1, "100","959517c7-2327-4b8b-ad6c-d984c3d0fa92","959517c7-2327-4b8b-ad6c-d984c3d0fa92");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "1");		


				this.lblApplyDept71 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDept71", "", "True", "True", "Right", 150, 20, 0, 1, 1, 1, "100","5cf29749-aacc-456e-8ea0-6d0a4b87ed55","eb66ac58-58c4-4aed-be40-9b97bfe6abc8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDept71, "2");		


				this.ApplyDept71 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"ApplyDept71",false,true, true,150, 20, 2, 1, 1, 1, "100","3",false,false,true,"lblApplyDept71","5cf29749-aacc-456e-8ea0-6d0a4b87ed55","8c287a9b-33dc-4617-9e25-98668b73cecb");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDept71, "False", "ApplyDept", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldApplyDept, "SpecialApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.ApplyDept71,"874cc1b6-f844-486c-b3f5-f8cca21fe1e0", 580,408, "Name","Code","ID", this.Model.SpecialApplyBE.FieldApplyDept_Code,this.Model.SpecialApplyBE.FieldApplyDept_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ApplyDept71,"ApplyDept71",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","Org_Name",""),new ReferenceOutputParam("","DescFlexField_PrivateDescSeg14",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ApplyDept71, "3");		
		 

				this.lblApplier86 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplier86", "", "True", "True", "Right", 150, 20, 0, 2, 1, 1, "100","5efaa630-1e81-4af4-971c-d629e1ca4e56","875c8d40-f3f9-47ae-8689-64b405ed71f3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplier86, "4");		


				this.Applier86 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Applier86", "True", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblApplier86","","50","5efaa630-1e81-4af4-971c-d629e1ca4e56","1820f940-a4bc-4820-97c7-6e8c5ab4972b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Applier86, "False", "Applier", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldApplier, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Applier86, "5");		
		 

				this.lblPhone155 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPhone155", "", "True", "True", "Right", 150, 20, 4, 1, 1, 1, "100","8bd8d5c2-ce03-45b4-9b5f-f904c2b9c5ef","c38effda-89b6-4f9c-b3fb-ccb668111135");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPhone155, "6");		


				this.Phone155 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Phone155", "True", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 6, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblPhone155","","50","8bd8d5c2-ce03-45b4-9b5f-f904c2b9c5ef","bd2951ea-cb25-4fc3-8d4c-e267e0729e2b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Phone155, "False", "Phone", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldPhone, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Phone155, "7");		
		 

				this.lblQQ149 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQQ149", "", "True", "True", "Right", 150, 20, 4, 2, 1, 1, "100","f0ba3c1d-9c5b-459d-adca-a882cf16c827","6c637d31-a537-457b-8e99-81626dd8a207");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQQ149, "8");		


				this.QQ149 = UIControlBuilder.BuilderTextBox(_UFTabPage, "QQ149", "True", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 6, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblQQ149","","50","f0ba3c1d-9c5b-459d-adca-a882cf16c827","dbf8ca64-ea30-44a9-aa34-d1b696997322");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.QQ149, "False", "QQ", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldQQ, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.QQ149, "9");		
		 

				this.lblApplyDate131 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDate131", "", "True", "True", "Right", 149, 20, 8, 1, 1, 1, "100","49c1650a-603e-49eb-bcba-bfa153d185e7","a20c8342-8532-4d5d-9d6e-6b6613aa7edf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDate131, "10");		


				this.ApplyDate131 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ApplyDate131", true, true, true, "Date","Left", 3, 60, 0, 149, 20, 10, 1, 1, 1, "100",true,false,"lblApplyDate131","49c1650a-603e-49eb-bcba-bfa153d185e7","95aa52bc-fcc0-4192-9cdb-595fe46b4aca");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDate131, "False", "ApplyDate", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldApplyDate, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.ApplyDate131, "11");		
		 

				this.lblCustName104 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustName104", "", "True", "True", "Right", 150, 20, 0, 4, 1, 1, "100","f5d3e494-a29c-4a2c-aa2e-3e3cda78bdbd","daecc4f6-0f9b-4a28-99b1-a538aeb12a39");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustName104, "12");		


				this.CustName104 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustName104", "False", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustName104","","100","f5d3e494-a29c-4a2c-aa2e-3e3cda78bdbd","5d4ac7fe-6c53-4ce3-aef2-ccbff742cc40");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustName104, "False", "CustName", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldCustName, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustName104, "13");		
		 

				this.lblCustPhone77 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustPhone77", "", "True", "True", "Right", 150, 20, 0, 5, 1, 1, "100","af55c1e1-e153-4c38-91e4-249a1b6b9e2d","f5362e60-bc9b-4a45-a1b3-f0681c075c73");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustPhone77, "14");		


				this.CustPhone77 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustPhone77", "False", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustPhone77","","50","af55c1e1-e153-4c38-91e4-249a1b6b9e2d","b91002a1-47f4-4879-ad62-0d91571d1aac");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustPhone77, "False", "CustPhone", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldCustPhone, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustPhone77, "15");		
		 

				this.lblCustConterName149 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustConterName149", "", "True", "True", "Right", 150, 20, 4, 4, 1, 1, "100","595c37ff-5e89-49bd-9872-59b63279bdcf","b73bd394-4ac9-4be6-9720-769cb9286b2a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustConterName149, "16");		


				this.CustConterName149 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustConterName149", "False", "True", "True", "False", "Left", 0, 60, 0, 474, 20, 6, 4, 6, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustConterName149","","500","595c37ff-5e89-49bd-9872-59b63279bdcf","4d02af1a-1f77-4d0c-a9fd-2960220f6743");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustConterName149, "False", "CustConterName", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldCustConterName, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustConterName149, "17");		
		 

				this.lblCustAddress121 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustAddress121", "", "True", "True", "Right", 150, 20, 4, 5, 1, 1, "100","fa2bcdbb-bfde-47c7-9a5b-f97d5a28c8a6","48a01baf-40a7-4457-8989-927e779b8d65");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustAddress121, "18");		


				this.CustAddress121 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustAddress121", "False", "True", "True", "False", "Left", 0, 60, 0, 474, 20, 6, 5, 6, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustAddress121","","500","fa2bcdbb-bfde-47c7-9a5b-f97d5a28c8a6","69d8eb4a-e84a-4b0d-9d35-bc8e1a5c9f6e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustAddress121, "False", "CustAddress", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldCustAddress, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustAddress121, "19");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFTabPage, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 149, 20, 8, 2, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","11f6d96c-bc3a-4fff-b55c-92d537dad9b0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "20");		
		 


				
			this.ApplyDept71.IsMultiOrg  = false ;
			this.lblApplyDept71.SetMultiOrgInfo(this.ApplyDept71,false);
			
																	

            this.TabPage31 = _UFTabPage;
            return _UFTabPage;
        }

				

	        private IUFTabPage _BuilderControl_TabPage32(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage32",true, true, "2","b755828e-e8e0-47c2-b6d6-3eb2a6f77d38","b755828e-e8e0-47c2-b6d6-3eb2a6f77d38");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 12, 6, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.SpecialApplyBE, "SpecialApplyBE", "", null, 1, "专柜申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(75,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(70,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblSpecialDesignStyle119 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSpecialDesignStyle119", "", "True", "True", "Right", 120, 20, 0, 0, 1, 1, "100","c675c8f7-9c56-40e8-8797-224776233f3e","89da71fb-b754-460a-ad4f-ff79ad2e82f1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSpecialDesignStyle119, "0");		


		        this.SpecialDesignStyle119 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "SpecialDesignStyle119", "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum", false,  true, true, "Left", 2, 60, 0, 150, 20, 2, 0, 1, 1, "100",true,false,"lblSpecialDesignStyle119","c675c8f7-9c56-40e8-8797-224776233f3e","7c3b95f9-d6c4-4a53-a23e-bc924c08d20c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SpecialDesignStyle119, "False", "SpecialDesignStyle", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldSpecialDesignStyle, "SpecialApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum");
			EnumControlsMap.Add(this.SpecialDesignStyle119, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.SpecialDesignStyle119, "1");		
		 

				this.Label2737 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2737", "", "True", "True", "Right", 120, 20, 4, 1, 1, 1, "100","b5b36797-b89c-463b-875e-d96c2112d7a8","b5b36797-b89c-463b-875e-d96c2112d7a8");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2737, "2");		


				this.Label2738 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2738", "", "True", "True", "Right", 120, 20, 4, 2, 1, 1, "100","1bbc5f71-b128-4ec1-9f7c-37b3f3f49463","1bbc5f71-b128-4ec1-9f7c-37b3f3f49463");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2738, "3");		


				this.Label2739 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2739", "", "True", "True", "Right", 120, 20, 8, 1, 1, 1, "100","59690b2c-f828-4d9a-86e0-93c101bef85d","59690b2c-f828-4d9a-86e0-93c101bef85d");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2739, "4");		


				this.Label2740 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2740", "", "True", "True", "Right", 120, 20, 8, 2, 1, 1, "100","2bda3cf9-1aff-454b-9ec3-5d8909d5b506","2bda3cf9-1aff-454b-9ec3-5d8909d5b506");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2740, "5");		


	
			_BuilderControl_Image0(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image0, "6");		


	
			_BuilderControl_Image1(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image1, "7");		



								

            this.TabPage32 = _UFTabPage;
            return _UFTabPage;
        }

	        private void _BuilderControl_Image0(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image0",true, true, "6");
			_Image.ImageUrl = @"~\/images/SeeBestBlueSpecial.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 75, 145, 6, 0, 1, 6, "100");
            this.Image0 = _Image;
        }

	        private void _BuilderControl_Image1(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image1",true, true, "7");
			_Image.ImageUrl = @"~\/images/SeeBestWhiteSpecial.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 70, 145, 10, 0, 1, 6, "100");
            this.Image1 = _Image;
        }

	         private void _BuilderControl_TabControl5(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl5",true, true, "2",EventResponseType.Client,971, 211, 0, 1, 1, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage36(_UFTabControl));
            this.TabControl5 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage36(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage36",true, true, "1","3f530af6-59d4-42ca-a633-12e3e1103cda","3f530af6-59d4-42ca-a633-12e3e1103cda");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 2, 3, 0, 5, 5, 5, 3, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(953,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(100,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),new GridRowDef(50,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid14(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid14, "1");		


	
			_BuilderControl_Card7(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Card7, "0");		



		

            this.TabPage36 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid14(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid14", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,5,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 953, 106, 0, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.SpecialApplyBE_SpecialSizeBE, "SpecialApplyBE_SpecialSizeBE", "", null, 5, "专柜申请单");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid14 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID61","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","5d43dab0-d67e-42a6-980c-d8cbcf65fcab","5d43dab0-d67e-42a6-980c-d8cbcf65fcab","a094e128-8bcd-461d-9fd0-36db189d3687");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion57","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","655a9e25-fa07-4b51-bc62-97917a0a4e1f","655a9e25-fa07-4b51-bc62-97917a0a4e1f","c42d1d27-dd47-4efa-a26b-87c16b106961");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DisplayProductType0","TextBoxColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["DisplayProductType"]/*DisplayProductType*/,"DisplayProductType", false, true, true, false, false, false, 0, 150, "100",true, false,"","741bc932-1bb4-477a-8759-2c7e5d175c13","741bc932-1bb4-477a-8759-2c7e5d175c13","4849cb34-3c61-4e24-b34c-eaa1affcbd23");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","100") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Width0","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Width"]/*Width*/,"Width", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","3ce03126-0912-4492-9fbf-0701d4ba5f31","3ce03126-0912-4492-9fbf-0701d4ba5f31","8841e903-93d2-4b6f-a216-0f5dfa27be8f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Hight0","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Hight"]/*Hight*/,"Hight", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","14fe6f02-0761-4213-a3f1-0a40a576bfcf","14fe6f02-0761-4213-a3f1-0a40a576bfcf","80b26c22-3b4c-410c-b205-4a50662afaff");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Thick0","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Thick"]/*Thick*/,"Thick", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","918ec36d-4d3e-472c-8c0d-169b1ebf1970","918ec36d-4d3e-472c-8c0d-169b1ebf1970","0f9f0597-c9b4-48c3-bd8b-738029084bdf");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Qty0","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Qty"]/*Qty*/,"Qty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","5019383f-1764-4204-8ce1-dd62722a127a","5019383f-1764-4204-8ce1-dd62722a127a","7c6adb56-4333-483f-960b-e123a49e775f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Area0","NumberColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Area"]/*Area*/,"Area", false, true, false, false, false, true, 8, 100, "24.9",true, false,"0","3d84e584-9b4f-4ba3-913a-eab83e8666a7","3d84e584-9b4f-4ba3-913a-eab83e8666a7","a6131913-df8f-4a02-88b6-812f33bb86e7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"Width*Hight*Qty",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo0","TextBoxColumnModel", "", 0,this.Model.SpecialApplyBE_SpecialSizeBE.Fields["Memo"]/*Memo*/,"Memo", false, true, true, false, false, true, 0, 150, "500",true, false,"","631cfbc8-e966-4e11-bd48-3aa8fdf20b7d","631cfbc8-e966-4e11-bd48-3aa8fdf20b7d","9ecf2eb5-d3b9-47aa-8875-d9a48a973324");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","500") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"TextBoxColumn2","TextBoxColumnModel", "", 0,null,"", false, true, true, false, false, true, 0, 100, "",true, false,"","","","54bf15dd-292a-431a-b2ae-12a7254013c2");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","") ;          
	  
		 
        }

	                   
        private IUFCard _BuilderControl_Card7(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card7",false,"none", true, true, "0","","4aac3994-673b-47f3-8804-0b07150ed52d");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 953, 50, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 1, 2, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(900,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card7 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label2741 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label2741", "", "True", "True", "Left", 900, 20, 0, 0, 1, 1, "100","d8344260-c921-48d1-98ae-718d43a8bd55","d8344260-c921-48d1-98ae-718d43a8bd55");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2741, "0");		


				this.Label2742 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label2742", "", "True", "True", "Left", 900, 20, 0, 1, 1, 1, "100","1b0e0edc-97f4-4ded-8030-807dff300fb4","1b0e0edc-97f4-4ded-8030-807dff300fb4");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2742, "1");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card6(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"none", true, true, "0","06368069-4511-4f9d-bd40-8f222da3586f","a3190c20-bb42-462c-8229-7a79f6c28965");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  this.Model.SpecialApplyBE, "SpecialApplyBE", "", null, 1, "专柜申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card6 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID60 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID60", "", "False", "True", "Right", 150, 20, 0, 0, 1, 1, "100","06368069-4511-4f9d-bd40-8f222da3586f","7e428d43-8491-4ab8-8a86-20bdbf2df4c6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID60, "0");		


				this.ID60 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID60", "False", "False", "True", "Left", 7, 60, 0, 150, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID60","19.0","06368069-4511-4f9d-bd40-8f222da3586f","f1987493-9e0b-436e-b4aa-e1e489c1adeb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID60, "False", "ID", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldID, "SpecialApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.ID60, "1");		
		 

				this.lblSysVersion56 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion56", "", "False", "True", "Right", 150, 20, 0, 0, 1, 1, "100","c53373e9-6c60-4cf8-9766-ea8d302cf10b","3929b1dc-1afb-4210-bb82-9d5ca50f148e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion56, "2");		


				this.SysVersion56 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion56", "True", "False", "True", "Left", 7, 60, 0, 150, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion56","19.0","c53373e9-6c60-4cf8-9766-ea8d302cf10b","864b6e86-869a-4927-a1b6-16e04b75d96b",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion56, "False", "SysVersion", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldSysVersion, "SpecialApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion56, "3");		
		 

				this.lblAdvCode72 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvCode72", "", "True", "True", "Right", 150, 20, 0, 0, 1, 1, "100","66114ed7-b79b-4834-86e9-455f5bacc91b","88cbbce9-6055-4115-8797-b0c957feffe9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvCode72, "4");		


				this.AdvCode72 = UIControlBuilder.BuilderTextBox(_UFCard, "AdvCode72", "False", "True", "False", "False", "Left", 0, 60, 0, 150, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblAdvCode72","","50","66114ed7-b79b-4834-86e9-455f5bacc91b","4a78e514-b96c-4bc5-9759-a4ce6a259357");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvCode72, "False", "AdvCode", this.Model.SpecialApplyBE, this.Model.SpecialApplyBE.FieldAdvCode, "SpecialApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvCode72, "5");		
		 


						

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
