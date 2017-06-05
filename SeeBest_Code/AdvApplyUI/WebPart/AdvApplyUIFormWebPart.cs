


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
 * Form ID:e64f3280-ab80-447f-83b3-41dfdbad9053 
 * Form Name:AdvApplyUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
	[FormRegister("UFIDA.U9.Cust.AdvApplyUI","UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel.AdvApplyUIFormWebPart", "UFIDA.U9.Cust.AdvApplyUI.WebPart", "e64f3280-ab80-447f-83b3-41dfdbad9053","WebPart", "False", 1024, 648)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.AdvApplyUI', 'UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel.AdvApplyUIFormWebPart', 'UFIDA.U9.Cust.AdvApplyUI.WebPart', 'e64f3280-ab80-447f-83b3-41dfdbad9053')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e64f3280-ab80-447f-83b3-41dfdbad9053" title="AdvApplyUIForm"/>
    public partial class AdvApplyUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApplyUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new AdvApplyUIModelAction Action
		{
			get { return (AdvApplyUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		AdvApplyUIModelModel _uimodel=null;
		public new AdvApplyUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new AdvApplyUIModelModel();
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
                this.Model = value as AdvApplyUIModelModel;
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
        IUFTabControl TabControl6;
        IUFTabPage TabPage25;
        IUFLine Line0;
        IUFLabel lblApplyDept161;
        IUFFldReference ApplyDept161;
        IUFLabel lblApplier106;
        IUFFldTextBox Applier106;
        IUFLabel lblPhone218;
        IUFFldTextBox Phone218;
        IUFLabel lblQQ157;
        IUFFldTextBox QQ157;
        IUFLabel lblApplyDate268;
        IUFFldDatePicker ApplyDate268;
        IUFLine Line1;
        IUFLabel lblCustConterName115;
        IUFFldTextBox CustConterName115;
        IUFLabel lblRelPeople158;
        IUFFldTextBox RelPeople158;
        IUFLabel lblCustAddress133;
        IUFFldTextBox CustAddress133;
        IUFLabel lblCustPhone184;
        IUFFldTextBox CustPhone184;
        IUFLabel lblLocationQY196;
        IUFFldTextBox LocationQY196;
        IUFLabel lblLocationXZ172;
        IUFFldTextBox LocationXZ172;
        IUFTabPage TabPage32;
        IUFLine Line3;
        IUFLabel lblAdvItem433;
        IUFFldReference AdvItem433;
        IUFLabel lblQty693;
        IUFFldNumberControl Qty693;
        IUFLabel lblTotalArea333;
        IUFFldNumberControl TotalArea333;
        IUFLine Line4;
        IUFLine Line5;
        IUFLabel lblBMWidth146;
        IUFFldNumberControl BMWidth146;
        IUFLabel lblBMHight124;
        IUFFldNumberControl BMHight124;
        IUFLabel lblBMThick115;
        IUFFldNumberControl BMThick115;
        IUFLabel lblBMArea187;
        IUFFldNumberControl BMArea187;
        IUFLabel lblDZWidth187;
        IUFFldNumberControl DZWidth187;
        IUFLabel lblDZThick224;
        IUFFldNumberControl DZThick224;
        IUFLabel lblDZArea338;
        IUFFldNumberControl DZArea338;
        IUFLine Line6;
        IUFLabel lblAdvDisplayType167;
        IUFFldDropDownList AdvDisplayType167;
        IUFLabel lblAdvDispInfo1191;
        IUFFldTextBox AdvDispInfo1191;
        IUFLabel lblAdvDispInfo2101;
        IUFFldTextBox AdvDispInfo2101;
        IUFLine Line7;
        IUFCard AdvAboutCard;
        IUFCard Card10;
        IUFImage Image3;
        IUFImage Image4;
        IUFImage Image7;
        IUFLabel Label11225;
        IUFLabel Label11226;
        IUFLabel Label11227;
        IUFTabPage TabPage33;
        IUFLine Line8;
        IUFLabel lblAdvMemo802;
        IUFFldTextBox AdvMemo802;
        IUFCard Card7;
        IUFLabel lblAdvCode476;
        IUFFldTextBox AdvCode476;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public AdvApplyUIFormWebPart()
        {
            FormID = "e64f3280-ab80-447f-83b3-41dfdbad9053";
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
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
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
					this.Model = new AdvApplyUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (AdvApplyUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new AdvApplyUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"AdvApplyUIForm",true,1024,648);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(1000,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(40,bool.Parse("False")),new GridRowDef(550,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_TabControl6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.TabControl6, "3");		


	
			_BuilderControl_Card7(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card7, "0");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",1000, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","2576257d-6bcd-435e-8f04-e9b40dec8665");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","24dacb6f-e263-40e1-be53-991d780f66dd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","aa2cba32-ec5a-4b4f-a589-306d25e7cea8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","412949bb-84bf-46b7-949d-3798bf7b689c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","3d69a949-1238-438c-9c81-fe0c0689809e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","ee90ab57-8cbc-4cfd-838c-da4959a991ea");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","e7cf013f-585a-4374-a63c-5bdeccd5d714");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","86a80541-769d-4332-b845-9960980b6224");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","9a65aeda-abd5-414a-99b7-b9d2092d822d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","86a6ecc9-b1eb-419d-8329-df859df244e5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","429f936e-4062-4ad0-a45c-03a22a10d18d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","83db09dc-55b9-4f65-8d45-819160bedc58");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","233a570f-a00d-4141-9aba-2ad6816c45ac");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","70ec5075-12fc-4dc5-9819-b2fb49586b82");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","2a9104e7-8341-4bcf-b143-ab3d32cc9eb3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","12811315-bd8d-4f9b-99d2-a503652a615e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","b5170e32-18e6-4ac4-ad46-1f10499db999");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","3f149fef-75be-43f3-a7ef-2747122f0cb2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	         private void _BuilderControl_TabControl6(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl6",true, true, "3",EventResponseType.Client,1000, 550, 0, 2, 1, 1, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage25(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage32(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage33(_UFTabControl));
            this.TabControl6 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage25(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage25",true, true, "1","3b4f3759-9fe7-45de-9467-c38efbeea061","3b4f3759-9fe7-45de-9467-c38efbeea061");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 16, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","2d2d328f-953a-45d6-ad70-d974c6a9222d","2d2d328f-953a-45d6-ad70-d974c6a9222d");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "2");		


				this.lblApplyDept161 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDept161", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","7962b0c7-ec45-4ecb-b48d-ae20dd012125","d9208b37-f103-43c9-b652-10f9b611bf9c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDept161, "3");		


				this.ApplyDept161 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"ApplyDept161",true,true, true,120, 20, 2, 1, 1, 1, "100","4",false,false,true,"lblApplyDept161","7962b0c7-ec45-4ecb-b48d-ae20dd012125","17a910b4-1d37-439d-b85b-240b63182192");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDept161, "False", "ApplyDept", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDept, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.ApplyDept161,"", 580,408, "","","", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
				

		
			UIControlBuilder.BuilderUFControl(this.ApplyDept161, "4");		
		 

				this.lblApplier106 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplier106", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","cec18246-7fa3-4750-aa18-6ad253140daf","4d7d4875-959c-48f2-9ba4-aa54bb646825");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplier106, "5");		


				this.Applier106 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Applier106", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblApplier106","","50","cec18246-7fa3-4750-aa18-6ad253140daf","92265e05-7bee-44ed-8566-da99bb87977e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Applier106, "False", "Applier", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplier, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Applier106, "6");		
		 

				this.lblPhone218 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPhone218", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","b1e83279-4727-41b9-88d9-c041c68920f6","01e4de13-bec8-4607-a41c-7e7504c5ed9f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPhone218, "7");		


				this.Phone218 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Phone218", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblPhone218","","50","b1e83279-4727-41b9-88d9-c041c68920f6","5a1a6dc7-147a-43e0-9f0d-a4eb0c92da0b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Phone218, "False", "Phone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Phone218, "8");		
		 

				this.lblQQ157 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQQ157", "", "True", "True", "Right", 100, 20, 4, 2, 1, 1, "100","ea83b850-9812-42fd-88ba-8efa2e50984f","55b1568d-b192-4d67-9874-0386e5402979");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQQ157, "9");		


				this.QQ157 = UIControlBuilder.BuilderTextBox(_UFTabPage, "QQ157", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblQQ157","","50","ea83b850-9812-42fd-88ba-8efa2e50984f","9f4e5091-194c-491e-b73f-61073f1ce036");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.QQ157, "False", "QQ", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQQ, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.QQ157, "10");		
		 

				this.lblApplyDate268 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDate268", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","ce780ddb-401c-48b8-a2ab-bd3e6c71fc4d","b24110ac-a2bc-413b-b04d-526928c2022f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDate268, "11");		


				this.ApplyDate268 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ApplyDate268", true, true, true, "Date","Left", 3, 60, 0, 120, 20, 10, 1, 1, 1, "100",true,false,"lblApplyDate268","ce780ddb-401c-48b8-a2ab-bd3e6c71fc4d","a9dde658-d7d6-49c0-a7db-2a08b41b3db9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDate268, "False", "ApplyDate", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDate, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.ApplyDate268, "12");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line1", 950, "Horizontal", "True", 950, 20, 0, 3, 15, 1, "100","07c16f9a-9291-4b2b-87a9-d132e1622457","07c16f9a-9291-4b2b-87a9-d132e1622457");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "13");		


				this.lblCustConterName115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustConterName115", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","7bc62c47-d740-410b-bfba-ca645e3cdbc4","170bbc4c-fce4-48b7-87b9-56a62173e24b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustConterName115, "14");		


				this.CustConterName115 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustConterName115", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustConterName115","","50","7bc62c47-d740-410b-bfba-ca645e3cdbc4","b47fab72-3023-4b53-9ddc-638f12a2307b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustConterName115, "False", "CustConterName", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustConterName, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustConterName115, "15");		
		 

				this.lblRelPeople158 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblRelPeople158", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","966578bc-bb15-4c1d-afb7-49c687ebbb41","a1330a6f-f0fa-44fe-a46a-16441350f806");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelPeople158, "16");		


				this.RelPeople158 = UIControlBuilder.BuilderTextBox(_UFTabPage, "RelPeople158", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblRelPeople158","","50","966578bc-bb15-4c1d-afb7-49c687ebbb41","63eb549b-ff32-47d8-8868-65c0e38b2444");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelPeople158, "False", "RelPeople", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldRelPeople, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.RelPeople158, "17");		
		 

				this.lblCustAddress133 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustAddress133", "", "True", "True", "Right", 100, 20, 0, 5, 1, 1, "100","0b6c32a4-7cd3-4598-be00-61f1dff84d85","f8302aad-6d73-4098-aa0f-d22675dda2d8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustAddress133, "18");		


				this.CustAddress133 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustAddress133", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustAddress133","","50","0b6c32a4-7cd3-4598-be00-61f1dff84d85","2e734cbb-36ba-486d-a826-ba5ff3f0833e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustAddress133, "False", "CustAddress", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustAddress, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustAddress133, "19");		
		 

				this.lblCustPhone184 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustPhone184", "", "True", "True", "Right", 100, 20, 4, 5, 1, 1, "100","60fa3532-eebb-485f-9aa8-bf9701341992","780befdd-6d35-4a94-ac28-2ebc292c36f6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustPhone184, "20");		


				this.CustPhone184 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustPhone184", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustPhone184","","50","60fa3532-eebb-485f-9aa8-bf9701341992","3e11622f-25ec-4246-8f0f-1ab6a7527c03");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustPhone184, "False", "CustPhone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustPhone184, "21");		
		 

				this.lblLocationQY196 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationQY196", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","055df3fa-8970-4465-b64e-ebd1861467f2","67d3d3d4-833c-4772-ac6d-8dc675263b78");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationQY196, "22");		


				this.LocationQY196 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationQY196", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationQY196","","50","055df3fa-8970-4465-b64e-ebd1861467f2","cef2adef-dd86-4869-8e5b-da52ab21297a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LocationQY196, "False", "LocationQY", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldLocationQY, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.LocationQY196, "23");		
		 

				this.lblLocationXZ172 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationXZ172", "", "True", "True", "Right", 100, 20, 8, 5, 1, 1, "100","ccc918d7-9ef5-4367-a072-34ff0c6a79b7","10cdf19a-9269-40ae-ba7b-f7aee0ece3ea");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationXZ172, "24");		


				this.LocationXZ172 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationXZ172", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationXZ172","","50","ccc918d7-9ef5-4367-a072-34ff0c6a79b7","f4c04665-8011-4160-beb0-8793d51606c5");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LocationXZ172, "False", "LocationXZ", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldLocationXZ, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.LocationXZ172, "25");		
		 


			
			this.ApplyDept161.IsMultiOrg  = false ;
			this.lblApplyDept161.SetMultiOrgInfo(this.ApplyDept161,false);
			
																					

            this.TabPage25 = _UFTabPage;
            return _UFTabPage;
        }

				

	        private IUFTabPage _BuilderControl_TabPage32(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage32",true, true, "0","c73192be-1408-46bf-9ba8-f74e7a93701c","c73192be-1408-46bf-9ba8-f74e7a93701c");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 20, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line3 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line3", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","005cdc8b-0b79-4e7c-a684-d4467f18f419","005cdc8b-0b79-4e7c-a684-d4467f18f419");
	

		
			UIControlBuilder.BuilderUFControl(this.Line3, "0");		


				this.lblAdvItem433 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvItem433", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","4b2ad640-727b-4a3a-8d24-061c0ebca1e5","a014a2ba-574e-4efa-98e0-70d2e7b21bc8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvItem433, "1");		


				this.AdvItem433 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"AdvItem433",true,true, true,120, 20, 2, 1, 1, 1, "100","2",false,false,true,"lblAdvItem433","4b2ad640-727b-4a3a-8d24-061c0ebca1e5","537f419a-6eae-40c0-baaf-8a4935189e11");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvItem433, "False", "AdvItem", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvItem, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvItem433,"", 580,408, "","","", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
				

		
			UIControlBuilder.BuilderUFControl(this.AdvItem433, "2");		
		 

				this.lblQty693 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQty693", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","6e784142-471f-4761-bc2e-22ad32f4c405","80707eec-a117-49e6-a387-c50d5728c412");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQty693, "3");		


				this.Qty693 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "Qty693", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblQty693","24.9","6e784142-471f-4761-bc2e-22ad32f4c405","dd73a494-a9e6-4c12-8383-bac217618f05",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Qty693, "False", "Qty", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQty, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.Qty693, "4");		
		 

				this.lblTotalArea333 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblTotalArea333", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","11ca841a-3858-48c1-806c-b030b0b515ce","2b340961-8de1-41c4-81ae-c50699bc0fae");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalArea333, "5");		


				this.TotalArea333 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "TotalArea333", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,true,true,"lblTotalArea333","24.9","11ca841a-3858-48c1-806c-b030b0b515ce","69352b3f-0c95-4f6c-ad6d-87457271f5fb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalArea333, "False", "TotalArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldTotalArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalArea333, "6");		
		 

				this.Line4 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line4", 470, "Horizontal", "True", 470, 20, 0, 2, 7, 1, "100","f6347aaf-e15c-4451-8090-b13322eec721","f6347aaf-e15c-4451-8090-b13322eec721");
	

		
			UIControlBuilder.BuilderUFControl(this.Line4, "7");		


				this.Line5 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line5", 470, "Horizontal", "True", 470, 20, 8, 2, 7, 1, "100","aa16b041-18f0-4698-afa6-683fadb3fbf4","aa16b041-18f0-4698-afa6-683fadb3fbf4");
	

		
			UIControlBuilder.BuilderUFControl(this.Line5, "8");		


				this.lblBMWidth146 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMWidth146", "", "True", "True", "Right", 100, 20, 0, 3, 1, 1, "100","3e3a4ae3-8c50-4953-9438-1fc09df11b07","e67cebca-fc33-466e-be18-c411e2240fc5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMWidth146, "9");		


				this.BMWidth146 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMWidth146", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 2, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBMWidth146","24.9","3e3a4ae3-8c50-4953-9438-1fc09df11b07","a586ba7a-7e1c-477d-ab79-476d4dcb4437",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMWidth146, "False", "BMWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMWidth, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMWidth146, "10");		
		 

				this.lblBMHight124 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMHight124", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","ea559a74-b5a4-4e99-83f7-87e6298f3482","4565e25d-786c-4edc-b356-011f7bd0708b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMHight124, "11");		


				this.BMHight124 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMHight124", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 2, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBMHight124","24.9","ea559a74-b5a4-4e99-83f7-87e6298f3482","b9f96968-bdce-4b3b-9b85-01f4bfa6ffea",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMHight124, "False", "BMHight", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMHight, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMHight124, "12");		
		 

				this.lblBMThick115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMThick115", "", "True", "True", "Right", 100, 20, 4, 3, 1, 1, "100","b1461951-fcba-4a02-b6ed-2b93ce00977d","e44c3fc2-b790-43c3-9505-56430a305519");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMThick115, "13");		


				this.BMThick115 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMThick115", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBMThick115","24.9","b1461951-fcba-4a02-b6ed-2b93ce00977d","7af01b4c-d010-4b85-8a3a-bd3a35204733",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMThick115, "False", "BMThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMThick, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMThick115, "14");		
		 

				this.lblBMArea187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMArea187", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","b5bcf3e9-479b-434c-b34c-f7331edaf2f1","dff1ba12-5514-446f-a5a6-9d8561315d97");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMArea187, "15");		


				this.BMArea187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMArea187", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBMArea187","24.9","b5bcf3e9-479b-434c-b34c-f7331edaf2f1","a793b009-bbdd-461f-9642-48c0dbe1dc83",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMArea187, "False", "BMArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMArea187, "16");		
		 

				this.lblDZWidth187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZWidth187", "", "True", "True", "Right", 100, 20, 8, 3, 1, 1, "100","79405777-8bae-4b6e-9643-58cf3557296f","7e08637c-fe2f-4436-8926-7556ee54a8b2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZWidth187, "17");		


				this.DZWidth187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZWidth187", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblDZWidth187","24.9","79405777-8bae-4b6e-9643-58cf3557296f","7fcf58b5-942f-48ae-a3e0-ecdb165bac96",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZWidth187, "False", "DZWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZWidth, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.DZWidth187, "18");		
		 

				this.lblDZThick224 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZThick224", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","17192fdb-799d-4a8b-ab0a-84877e625f7f","7ad105a5-e355-4222-8c25-7cddfc9e1c84");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZThick224, "19");		


				this.DZThick224 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZThick224", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblDZThick224","24.9","17192fdb-799d-4a8b-ab0a-84877e625f7f","1c44f940-42ea-4107-bb23-7941a804741d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZThick224, "False", "DZThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZThick, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.DZThick224, "20");		
		 

				this.lblDZArea338 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZArea338", "", "True", "True", "Right", 100, 20, 12, 3, 1, 1, "100","b58c623c-1c5b-4f9d-8683-e5362622177f","be1d20cc-6872-42e3-be05-aa80ceb4bd08");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZArea338, "21");		


				this.DZArea338 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZArea338", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 14, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblDZArea338","24.9","b58c623c-1c5b-4f9d-8683-e5362622177f","56055a54-b456-43b9-9f92-7aa3ca192a1f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZArea338, "False", "DZArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.DZArea338, "22");		
		 

				this.Line6 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line6", 950, "Horizontal", "True", 950, 20, 0, 5, 15, 1, "100","e6a717ec-a9c3-469b-80ba-bd3020c82b83","e6a717ec-a9c3-469b-80ba-bd3020c82b83");
	

		
			UIControlBuilder.BuilderUFControl(this.Line6, "23");		


				this.lblAdvDisplayType167 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDisplayType167", "", "True", "True", "Right", 100, 20, 0, 6, 1, 1, "100","b6411d15-78e6-400d-b816-8bf917b9f17f","59dc5374-9173-48ea-b6c6-62c6e0fb4854");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDisplayType167, "24");		


		        this.AdvDisplayType167 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "AdvDisplayType167", "AdvertisementApplyBE.AdvDisplayTypeEnum", true,  true, true, "Left", 2, 60, 0, 120, 20, 2, 6, 1, 1, "100",true,false,"lblAdvDisplayType167","b6411d15-78e6-400d-b816-8bf917b9f17f","9a5f6500-1009-4942-9a2c-7cdea203bb1e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDisplayType167, "False", "AdvDisplayType", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDisplayType, "AdvApplyBE");
			EnumTypeList.Add("AdvertisementApplyBE.AdvDisplayTypeEnum");
			EnumControlsMap.Add(this.AdvDisplayType167, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDisplayType167, "25");		
		 

				this.lblAdvDispInfo1191 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo1191", "", "True", "True", "Right", 100, 20, 0, 7, 1, 1, "100","24c208f5-cd9f-45f0-9112-bd84be1bc7ec","4255ebfe-ee24-4fa9-86c0-802a75cb8071");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo1191, "26");		


				this.AdvDispInfo1191 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvDispInfo1191", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 7, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvDispInfo1191","","50","24c208f5-cd9f-45f0-9112-bd84be1bc7ec","96a4b05b-4e11-4cf4-9af8-838c7bd242e1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo1191, "False", "AdvDispInfo1", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo1, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo1191, "27");		
		 

				this.lblAdvDispInfo2101 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo2101", "", "True", "True", "Right", 100, 20, 0, 8, 1, 1, "100","8d01db86-e4ed-4a85-9b17-2ec3a6f06830","c4dc19e9-1fee-49e3-acbd-c873fa13a55e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo2101, "28");		


				this.AdvDispInfo2101 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvDispInfo2101", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 8, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvDispInfo2101","","50","8d01db86-e4ed-4a85-9b17-2ec3a6f06830","44e1535a-5d4f-4aa4-ac33-61015abe7e8b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo2101, "False", "AdvDispInfo2", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo2, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo2101, "29");		
		 

				this.Line7 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line7", 950, "Horizontal", "True", 950, 20, 0, 14, 15, 1, "100","e91ee868-d4e6-4df8-96a1-0bec6f755371","e91ee868-d4e6-4df8-96a1-0bec6f755371");
	

		
			UIControlBuilder.BuilderUFControl(this.Line7, "33");		


	
			_BuilderControl_AdvAboutCard(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.AdvAboutCard, "0");		


	
			_BuilderControl_Card10(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Card10, "0");		



			
			this.AdvItem433.IsMultiOrg  = false ;
			this.lblAdvItem433.SetMultiOrgInfo(this.AdvItem433,false);
			
																														

            this.TabPage32 = _UFTabPage;
            return _UFTabPage;
        }

				

	                   
        private IUFCard _BuilderControl_AdvAboutCard(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"AdvAboutCard",false,"none", true, true, "0","","59380be5-8606-49cc-989c-b91f2f4b98b2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 120, 0, 15, 15, 5, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 15, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.AdvAboutCard = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器








            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card10(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card10",false,"none", true, true, "0","","60fc64b2-5cd0-4c1d-9d7a-6a153158d420");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 710, 195, 4, 6, 11, 8, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 8, 7, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card10 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Image3(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Image3, "0");		


	
			_BuilderControl_Image4(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Image4, "1");		


	
			_BuilderControl_Image7(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Image7, "2");		


				this.Label11225 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label11225", "", "True", "True", "Right", 100, 20, 2, 4, 1, 1, "100","fa66121d-91a4-49b0-a270-1a50e8edc361","fa66121d-91a4-49b0-a270-1a50e8edc361");


								

		
			UIControlBuilder.BuilderUFControl(this.Label11225, "3");		


				this.Label11226 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label11226", "", "True", "True", "Right", 100, 20, 4, 6, 1, 1, "100","5f7833a7-3b20-4852-8b8a-504d4ad1ad1a","5f7833a7-3b20-4852-8b8a-504d4ad1ad1a");


								

		
			UIControlBuilder.BuilderUFControl(this.Label11226, "4");		


				this.Label11227 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label11227", "", "True", "True", "Right", 100, 20, 6, 5, 1, 1, "100","3c71f820-3692-4e09-9acd-ef946d29c156","3c71f820-3692-4e09-9acd-ef946d29c156");


								

		
			UIControlBuilder.BuilderUFControl(this.Label11227, "5");		



						

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	        private void _BuilderControl_Image3(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image3",true, true, "0");
			_Image.ImageUrl = @"~\";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 210, 95, 0, 0, 3, 4, "100");
            this.Image3 = _Image;
        }

	        private void _BuilderControl_Image4(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image4",true, true, "1");
			_Image.ImageUrl = @"~\";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 100, 145, 4, 0, 1, 6, "100");
            this.Image4 = _Image;
        }

	        private void _BuilderControl_Image7(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image7",true, true, "2");
			_Image.ImageUrl = @"~\";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 180, 120, 6, 0, 2, 5, "100");
            this.Image7 = _Image;
        }

	        private IUFTabPage _BuilderControl_TabPage33(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage33",true, true, "0","036fb0c2-cef8-43eb-88da-2f78d09f64fb","036fb0c2-cef8-43eb-88da-2f78d09f64fb");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 20, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line8 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line8", 870, "Horizontal", "True", 870, 20, 0, 1, 15, 1, "100","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed");
	

		
			UIControlBuilder.BuilderUFControl(this.Line8, "0");		


				this.lblAdvMemo802 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvMemo802", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","0b3fcf89-0723-49e0-bd5b-1d2af55ae3fc","89826801-2b5b-4db2-a0eb-4e4fa93ed493");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvMemo802, "1");		


				this.AdvMemo802 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvMemo802", "True", "True", "True", "True", "Left", 0, 60, 0, 650, 395, 2, 2, 11, 16, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblAdvMemo802","","2000","0b3fcf89-0723-49e0-bd5b-1d2af55ae3fc","bf6588ef-57a6-4b56-ad5d-09771f78f621");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvMemo802, "False", "AdvMemo", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvMemo, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvMemo802, "2");		
		 


			

            this.TabPage33 = _UFTabPage;
            return _UFTabPage;
        }

	                   
        private IUFCard _BuilderControl_Card7(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card7",false,"none", true, true, "0","da8e1120-73fc-4f0b-8b79-c1d3566e1fc0","8a34bf70-88a8-45c7-9a48-931ca74dca61");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1000, 40, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(180,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card7 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblAdvCode476 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvCode476", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","da8e1120-73fc-4f0b-8b79-c1d3566e1fc0","6aef3d2b-a486-414e-9802-4c90da1716b9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvCode476, "0");		


				this.AdvCode476 = UIControlBuilder.BuilderTextBox(_UFCard, "AdvCode476", "True", "True", "True", "False", "Left", 0, 60, 0, 180, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvCode476","","50","da8e1120-73fc-4f0b-8b79-c1d3566e1fc0","e695f198-0b25-453a-98b7-7adbad1458a9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvCode476, "False", "AdvCode", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvCode, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvCode476, "1");		
		 


		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
