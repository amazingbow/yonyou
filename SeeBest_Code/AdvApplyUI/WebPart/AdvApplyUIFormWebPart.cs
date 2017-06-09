


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
	[FormRegister("UFIDA.U9.Cust.AdvApplyUI","UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel.AdvApplyUIFormWebPart", "UFIDA.U9.Cust.AdvApplyUI.WebPart", "e64f3280-ab80-447f-83b3-41dfdbad9053","WebPart", "False", 1216, 800)] 
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
        IUFLine Line7;
        IUFDataGrid DataGrid0;
        IUFLine Line12;
        IUFLabel lblAdvDisplayType588;
        IUFFldDropDownList AdvDisplayType588;
        IUFLabel lblAdvDispInfo11708;
        IUFFldTextBox AdvDispInfo11708;
        IUFLabel lblAdvDispInfo22670;
        IUFFldTextBox AdvDispInfo22670;
        IUFImage Image12;
        IUFImage Image13;
        IUFImage Image14;
        IUFTabPage TabPage33;
        IUFLine Line8;
        IUFLabel lblAdvMemo802;
        IUFFldTextBox AdvMemo802;
        IUFCard Card7;
        IUFLabel lblAdvCode476;
        IUFFldTextBox AdvCode476;
        IUFLabel lblIsClose1250;
        IUFFldCheckBox IsClose1250;
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
			((UFWebDataGridAdapter)this.DataGrid0).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid0_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid0).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid0_GridCustomFilterHandler);
		
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"AdvApplyUIForm",true,1216,800);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 5, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(1000,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(692,bool.Parse("False")),});
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
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl6",true, true, "3",EventResponseType.Client,1000, 692, 0, 2, 1, 1, "100");
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
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","2d2d328f-953a-45d6-ad70-d974c6a9222d","2d2d328f-953a-45d6-ad70-d974c6a9222d");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "2");		


				this.lblApplyDept161 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDept161", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","46233598-0adf-4b99-a9a1-d094c9f4b27b","d9208b37-f103-43c9-b652-10f9b611bf9c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDept161, "3");		


				this.ApplyDept161 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"ApplyDept161",true,true, true,120, 20, 2, 1, 1, 1, "100","4",true,false,true,"lblApplyDept161","46233598-0adf-4b99-a9a1-d094c9f4b27b","17a910b4-1d37-439d-b85b-240b63182192");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDept161, "False", "ApplyDept", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDept, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.ApplyDept161,"874cc1b6-f844-486c-b3f5-f8cca21fe1e0", 580,408, "Name","Code","ID", this.Model.AdvApplyBE.FieldApplyDept_Code,this.Model.AdvApplyBE.FieldApplyDept_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ApplyDept161,"ApplyDept161",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","Org_Name",""),new ReferenceOutputParam("","DescFlexField_PrivateDescSeg14",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ApplyDept161, "4");		
		 

				this.lblApplier106 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplier106", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","89a1b019-bda6-4692-8aeb-e2e9922aea89","4d7d4875-959c-48f2-9ba4-aa54bb646825");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplier106, "5");		


				this.Applier106 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Applier106", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblApplier106","","50","89a1b019-bda6-4692-8aeb-e2e9922aea89","92265e05-7bee-44ed-8566-da99bb87977e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Applier106, "False", "Applier", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplier, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Applier106, "6");		
		 

				this.lblPhone218 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPhone218", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","4d454b63-1781-454d-826c-d58ec781720a","01e4de13-bec8-4607-a41c-7e7504c5ed9f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPhone218, "7");		


				this.Phone218 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Phone218", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblPhone218","","50","4d454b63-1781-454d-826c-d58ec781720a","5a1a6dc7-147a-43e0-9f0d-a4eb0c92da0b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Phone218, "False", "Phone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Phone218, "8");		
		 

				this.lblQQ157 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQQ157", "", "True", "True", "Right", 100, 20, 4, 2, 1, 1, "100","7168f0ce-3f4e-48e7-8071-60d87afe18e9","55b1568d-b192-4d67-9874-0386e5402979");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQQ157, "9");		


				this.QQ157 = UIControlBuilder.BuilderTextBox(_UFTabPage, "QQ157", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblQQ157","","50","7168f0ce-3f4e-48e7-8071-60d87afe18e9","9f4e5091-194c-491e-b73f-61073f1ce036");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.QQ157, "False", "QQ", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQQ, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.QQ157, "10");		
		 

				this.lblApplyDate268 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDate268", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","05998768-75de-46a7-b436-aff66dba0f0d","b24110ac-a2bc-413b-b04d-526928c2022f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDate268, "11");		


				this.ApplyDate268 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ApplyDate268", true, true, true, "Date","Left", 3, 60, 0, 120, 20, 10, 1, 1, 1, "100",true,false,"lblApplyDate268","05998768-75de-46a7-b436-aff66dba0f0d","a9dde658-d7d6-49c0-a7db-2a08b41b3db9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDate268, "False", "ApplyDate", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDate, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.ApplyDate268, "12");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line1", 950, "Horizontal", "True", 950, 20, 0, 3, 15, 1, "100","07c16f9a-9291-4b2b-87a9-d132e1622457","07c16f9a-9291-4b2b-87a9-d132e1622457");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "13");		


				this.lblCustConterName115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustConterName115", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","ae85b77c-c085-4d96-bf38-106c496e5dc5","170bbc4c-fce4-48b7-87b9-56a62173e24b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustConterName115, "14");		


				this.CustConterName115 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustConterName115", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustConterName115","","50","ae85b77c-c085-4d96-bf38-106c496e5dc5","b47fab72-3023-4b53-9ddc-638f12a2307b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustConterName115, "False", "CustConterName", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustConterName, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustConterName115, "15");		
		 

				this.lblRelPeople158 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblRelPeople158", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","c8bba1de-2f50-4de7-ad85-af59d2bb93e9","a1330a6f-f0fa-44fe-a46a-16441350f806");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelPeople158, "16");		


				this.RelPeople158 = UIControlBuilder.BuilderTextBox(_UFTabPage, "RelPeople158", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblRelPeople158","","50","c8bba1de-2f50-4de7-ad85-af59d2bb93e9","63eb549b-ff32-47d8-8868-65c0e38b2444");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelPeople158, "False", "RelPeople", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldRelPeople, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.RelPeople158, "17");		
		 

				this.lblCustAddress133 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustAddress133", "", "True", "True", "Right", 100, 20, 0, 5, 1, 1, "100","c00450f6-6060-4c03-b7f8-a637000180e5","f8302aad-6d73-4098-aa0f-d22675dda2d8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustAddress133, "18");		


				this.CustAddress133 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustAddress133", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustAddress133","","50","c00450f6-6060-4c03-b7f8-a637000180e5","2e734cbb-36ba-486d-a826-ba5ff3f0833e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustAddress133, "False", "CustAddress", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustAddress, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustAddress133, "19");		
		 

				this.lblCustPhone184 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustPhone184", "", "True", "True", "Right", 100, 20, 4, 5, 1, 1, "100","bdfbf75e-50e1-41ca-ab69-f24fbd961cdb","780befdd-6d35-4a94-ac28-2ebc292c36f6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustPhone184, "20");		


				this.CustPhone184 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustPhone184", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustPhone184","","50","bdfbf75e-50e1-41ca-ab69-f24fbd961cdb","3e11622f-25ec-4246-8f0f-1ab6a7527c03");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustPhone184, "False", "CustPhone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustPhone184, "21");		
		 

				this.lblLocationQY196 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationQY196", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","0172a360-63ea-45dd-8617-87ff5deb4026","67d3d3d4-833c-4772-ac6d-8dc675263b78");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationQY196, "22");		


				this.LocationQY196 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationQY196", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationQY196","","50","0172a360-63ea-45dd-8617-87ff5deb4026","cef2adef-dd86-4869-8e5b-da52ab21297a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LocationQY196, "False", "LocationQY", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldLocationQY, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.LocationQY196, "23");		
		 

				this.lblLocationXZ172 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationXZ172", "", "True", "True", "Right", 100, 20, 8, 5, 1, 1, "100","a13bcf08-d80c-4b45-bbcd-ba95747e3dd9","10cdf19a-9269-40ae-ba7b-f7aee0ece3ea");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationXZ172, "24");		


				this.LocationXZ172 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationXZ172", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationXZ172","","50","a13bcf08-d80c-4b45-bbcd-ba95747e3dd9","f4c04665-8011-4160-beb0-8793d51606c5");
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
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 30, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(117,bool.Parse("True")),new GridColumnDef(13,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line3 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line3", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","005cdc8b-0b79-4e7c-a684-d4467f18f419","005cdc8b-0b79-4e7c-a684-d4467f18f419");
	

		
			UIControlBuilder.BuilderUFControl(this.Line3, "0");		


				this.lblAdvItem433 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvItem433", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","6633b8b3-cd02-4fea-810a-0b6fdb967f6f","a014a2ba-574e-4efa-98e0-70d2e7b21bc8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvItem433, "1");		


				this.AdvItem433 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"AdvItem433",true,true, true,117, 20, 2, 1, 1, 1, "100","2",false,false,true,"lblAdvItem433","6633b8b3-cd02-4fea-810a-0b6fdb967f6f","537f419a-6eae-40c0-baaf-8a4935189e11");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvItem433, "False", "AdvItem", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvItem, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvItem433,"81c79b25-3104-4ac6-ab99-af61bec43501", 580,408, "Name","Code","ID", this.Model.AdvApplyBE.FieldAdvItem_Code,this.Model.AdvApplyBE.FieldAdvItem_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.AdvItem433,"AdvItem433",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","AliasName",""),new ReferenceOutputParam("","Description",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.AdvItem433, "2");		
		 

				this.lblQty693 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQty693", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","b14f5c0c-f36d-4d5c-9d48-55f110ff2762","80707eec-a117-49e6-a387-c50d5728c412");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQty693, "3");		


				this.Qty693 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "Qty693", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblQty693","24.9","b14f5c0c-f36d-4d5c-9d48-55f110ff2762","dd73a494-a9e6-4c12-8383-bac217618f05",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Qty693, "False", "Qty", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQty, "AdvApplyBE");
			this.Qty693.ContentChanged += new EventHandler(Qty693_TextChanged);
			this.Qty693.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.Qty693, "4");		
		 

				this.lblTotalArea333 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblTotalArea333", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","4ff04588-9d8b-4546-80fb-c8f99bb019ff","2b340961-8de1-41c4-81ae-c50699bc0fae");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalArea333, "5");		


				this.TotalArea333 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "TotalArea333", "True", "True", "False", "Left", 8, 60, 0, 120, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalArea333","24.9","4ff04588-9d8b-4546-80fb-c8f99bb019ff","69352b3f-0c95-4f6c-ad6d-87457271f5fb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalArea333, "False", "TotalArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldTotalArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalArea333, "6");		
		 

				this.Line4 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line4", 470, "Horizontal", "True", 470, 20, 0, 2, 7, 1, "100","f6347aaf-e15c-4451-8090-b13322eec721","f6347aaf-e15c-4451-8090-b13322eec721");
	

		
			UIControlBuilder.BuilderUFControl(this.Line4, "7");		


				this.Line5 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line5", 470, "Horizontal", "True", 470, 20, 8, 2, 7, 1, "100","aa16b041-18f0-4698-afa6-683fadb3fbf4","aa16b041-18f0-4698-afa6-683fadb3fbf4");
	

		
			UIControlBuilder.BuilderUFControl(this.Line5, "8");		


				this.lblBMWidth146 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMWidth146", "", "True", "True", "Right", 100, 20, 0, 3, 1, 1, "100","41edbf9b-c814-4134-b364-667bf02e205f","e67cebca-fc33-466e-be18-c411e2240fc5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMWidth146, "9");		


				this.BMWidth146 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMWidth146", "True", "True", "True", "Left", 8, 60, 0, 117, 20, 2, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMWidth146","24.9","41edbf9b-c814-4134-b364-667bf02e205f","a586ba7a-7e1c-477d-ab79-476d4dcb4437",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMWidth146, "False", "BMWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMWidth, "AdvApplyBE");
			this.BMWidth146.ContentChanged += new EventHandler(BMWidth146_TextChanged);
			this.BMWidth146.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMWidth146, "10");		
		 

				this.lblBMHight124 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMHight124", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","1cb5d983-1d08-4e79-a7e7-e7ca455730ae","4565e25d-786c-4edc-b356-011f7bd0708b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMHight124, "11");		


				this.BMHight124 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMHight124", "True", "True", "True", "Left", 8, 60, 0, 117, 20, 2, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMHight124","24.9","1cb5d983-1d08-4e79-a7e7-e7ca455730ae","b9f96968-bdce-4b3b-9b85-01f4bfa6ffea",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMHight124, "False", "BMHight", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMHight, "AdvApplyBE");
			this.BMHight124.ContentChanged += new EventHandler(BMHight124_TextChanged);
			this.BMHight124.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMHight124, "12");		
		 

				this.lblBMThick115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMThick115", "", "True", "True", "Right", 100, 20, 4, 3, 1, 1, "100","7427cd7f-9f86-4721-a570-1ecde5b31241","e44c3fc2-b790-43c3-9505-56430a305519");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMThick115, "13");		


				this.BMThick115 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMThick115", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMThick115","24.9","7427cd7f-9f86-4721-a570-1ecde5b31241","7af01b4c-d010-4b85-8a3a-bd3a35204733",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMThick115, "False", "BMThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMThick, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMThick115, "14");		
		 

				this.lblBMArea187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMArea187", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","82879f14-665b-4d3b-ab1b-d05a5a0bddcb","dff1ba12-5514-446f-a5a6-9d8561315d97");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMArea187, "15");		


				this.BMArea187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMArea187", "True", "True", "False", "Left", 8, 60, 0, 120, 20, 6, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMArea187","24.9","82879f14-665b-4d3b-ab1b-d05a5a0bddcb","a793b009-bbdd-461f-9642-48c0dbe1dc83",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMArea187, "False", "BMArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMArea, "AdvApplyBE");
			this.BMArea187.ContentChanged += new EventHandler(BMArea187_TextChanged);
			this.BMArea187.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMArea187, "16");		
		 

				this.lblDZWidth187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZWidth187", "", "True", "True", "Right", 100, 20, 8, 3, 1, 1, "100","64415460-7e3e-4716-920c-cc943b995b44","7e08637c-fe2f-4436-8926-7556ee54a8b2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZWidth187, "17");		


				this.DZWidth187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZWidth187", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDZWidth187","24.9","64415460-7e3e-4716-920c-cc943b995b44","7fcf58b5-942f-48ae-a3e0-ecdb165bac96",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZWidth187, "False", "DZWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZWidth, "AdvApplyBE");
			this.DZWidth187.ContentChanged += new EventHandler(DZWidth187_TextChanged);
			this.DZWidth187.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.DZWidth187, "18");		
		 

				this.lblDZThick224 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZThick224", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","0c649632-746f-4593-a7b4-eba2d263a36c","7ad105a5-e355-4222-8c25-7cddfc9e1c84");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZThick224, "19");		


				this.DZThick224 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZThick224", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDZThick224","24.9","0c649632-746f-4593-a7b4-eba2d263a36c","1c44f940-42ea-4107-bb23-7941a804741d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZThick224, "False", "DZThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZThick, "AdvApplyBE");
			this.DZThick224.ContentChanged += new EventHandler(DZThick224_TextChanged);
			this.DZThick224.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.DZThick224, "20");		
		 

				this.lblDZArea338 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZArea338", "", "True", "True", "Right", 100, 20, 12, 3, 1, 1, "100","a1a33a6e-1480-4679-98b3-57e731855baf","be1d20cc-6872-42e3-be05-aa80ceb4bd08");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZArea338, "21");		


				this.DZArea338 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZArea338", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 14, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDZArea338","24.9","a1a33a6e-1480-4679-98b3-57e731855baf","56055a54-b456-43b9-9f92-7aa3ca192a1f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZArea338, "False", "DZArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.DZArea338, "22");		
		 

				this.Line7 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line7", 950, "Horizontal", "True", 950, 20, 0, 18, 15, 1, "100","e91ee868-d4e6-4df8-96a1-0bec6f755371","e91ee868-d4e6-4df8-96a1-0bec6f755371");
	

		
			UIControlBuilder.BuilderUFControl(this.Line7, "33");		


	
			_BuilderControl_DataGrid0(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "34");		


				this.Line12 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line12", 950, "Horizontal", "True", 950, 20, 0, 5, 15, 1, "100","6cd0b020-c5ce-46cc-8359-942d05f2e65e","6cd0b020-c5ce-46cc-8359-942d05f2e65e");
	

		
			UIControlBuilder.BuilderUFControl(this.Line12, "23");		


				this.lblAdvDisplayType588 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDisplayType588", "", "True", "True", "Right", 100, 20, 0, 6, 1, 1, "100","054233a2-1e6b-4490-bdf4-1f5c44d86bb5","558b31da-225f-42fb-9b44-f13a9eef6a81");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDisplayType588, "35");		


		        this.AdvDisplayType588 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "AdvDisplayType588", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", true,  true, true, "Left", 2, 60, 0, 117, 20, 2, 6, 1, 1, "100",true,false,"lblAdvDisplayType588","054233a2-1e6b-4490-bdf4-1f5c44d86bb5","8978aef7-ef80-44ee-8137-f693bf3ab625");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDisplayType588, "False", "AdvDisplayType", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDisplayType, "AdvApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum");
			EnumControlsMap.Add(this.AdvDisplayType588, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDisplayType588, "36");		
		 

				this.lblAdvDispInfo11708 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo11708", "", "True", "True", "Right", 100, 20, 4, 6, 1, 1, "100","fb962ca2-6af1-44c0-9750-c01bcc00a6c3","8ffaee29-9c7a-4c60-83ca-6a9940d0b1f4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo11708, "37");		


				this.AdvDispInfo11708 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvDispInfo11708", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvDispInfo11708","","50","fb962ca2-6af1-44c0-9750-c01bcc00a6c3","4c9bd6ed-fa4c-4756-bf40-94dd5381d59a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo11708, "False", "AdvDispInfo1", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo1, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo11708, "38");		
		 

				this.lblAdvDispInfo22670 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo22670", "", "True", "True", "Right", 100, 20, 8, 6, 1, 1, "100","d33d4b81-d95b-4897-9e95-241915618803","4a2623ef-67f8-4ee5-a63a-ef9a2801fc34");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo22670, "39");		


				this.AdvDispInfo22670 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvDispInfo22670", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvDispInfo22670","","50","d33d4b81-d95b-4897-9e95-241915618803","367bbaa1-4283-4b8a-98fc-916cde1cb5e5");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo22670, "False", "AdvDispInfo2", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo2, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo22670, "40");		
		 

	
			_BuilderControl_Image12(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image12, "41");		


	
			_BuilderControl_Image13(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image13, "42");		


	
			_BuilderControl_Image14(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image14, "43");		



			
			this.AdvItem433.IsMultiOrg  = false ;
			this.lblAdvItem433.SetMultiOrgInfo(this.AdvItem433,false);
			
																																

            this.TabPage32 = _UFTabPage;
            return _UFTabPage;
        }

				

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, false,false,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "34");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 480, 270, 0, 19, 8, 11, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.AdvApplyBE_AdvAboutBE, "AdvApplyBE_AdvAboutBE", "", null, 20, "广告申请单.Misc.广告体现项目子表");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"IsSelected0","CheckBoxColumnModel", "", 0,this.Model.AdvApplyBE_AdvAboutBE.Fields["IsSelected"]/*IsSelected*/,"IsSelected", false, true, true, false, false, true, 22, 80, "1",true, false,"false","88da77a8-c726-4783-b16c-a82c8880c9f7","88da77a8-c726-4783-b16c-a82c8880c9f7","9095e781-305c-4b67-b5d5-2a60f599985c");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Code0","TextBoxColumnModel", "", 0,this.Model.AdvApplyBE_AdvAboutBE.Fields["Code"]/*Code*/,"Code", false, true, true, false, false, true, 0, 100, "50",true, false,"","7a56b13a-60a9-47f5-9540-55bcd02ea9a3","7a56b13a-60a9-47f5-9540-55bcd02ea9a3","6f717870-a9fb-4ccd-91dd-51c89aeeec47");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Name0","TextBoxColumnModel", "", 0,this.Model.AdvApplyBE_AdvAboutBE.Fields["Name"]/*Name*/,"Name", false, true, false, false, false, true, 0, 160, "50",true, false,"","7ea67510-329d-4872-86fc-66be477ea2c5","7ea67510-329d-4872-86fc-66be477ea2c5","9dcfd79f-01d8-4e27-9892-8f8ea5932882");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Description0","TextBoxColumnModel", "", 0,this.Model.AdvApplyBE_AdvAboutBE.Fields["Description"]/*Description*/,"Description", false, true, true, false, false, true, 0, 100, "50",true, false,"","f56ca411-45c9-4096-911d-90114a584d40","f56ca411-45c9-4096-911d-90114a584d40","6d271c96-f7ea-47bf-a28f-623c0d1c76d4");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }

	        private void _BuilderControl_Image12(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image12",true, true, "41");
			_Image.ImageUrl = @"~\/Images/CusU9/1.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 340, 120, 0, 7, 5, 5, "100");
            this.Image12 = _Image;
        }

	        private void _BuilderControl_Image13(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image13",true, true, "42");
			_Image.ImageUrl = @"~\/Images/CusU9/2.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 120, 270, 6, 7, 1, 11, "100");
            this.Image13 = _Image;
        }

	        private void _BuilderControl_Image14(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image14",true, true, "43");
			_Image.ImageUrl = @"~\/Images/CusU9/3.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 240, 245, 8, 7, 4, 10, "100");
            this.Image14 = _Image;
        }

	        private IUFTabPage _BuilderControl_TabPage33(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage33",true, true, "0","036fb0c2-cef8-43eb-88da-2f78d09f64fb","036fb0c2-cef8-43eb-88da-2f78d09f64fb");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 20, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line8 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line8", 870, "Horizontal", "True", 870, 20, 0, 0, 15, 1, "100","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed");
	

		
			UIControlBuilder.BuilderUFControl(this.Line8, "0");		


				this.lblAdvMemo802 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvMemo802", "", "True", "True", "Right", 120, 20, 0, 1, 1, 1, "100","f551913f-b03c-48c6-b9bc-6cf829c7e3d2","89826801-2b5b-4db2-a0eb-4e4fa93ed493");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvMemo802, "1");		


				this.AdvMemo802 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvMemo802", "True", "True", "True", "True", "Left", 0, 60, 0, 630, 395, 2, 1, 11, 16, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblAdvMemo802","","2000","f551913f-b03c-48c6-b9bc-6cf829c7e3d2","bf6588ef-57a6-4b56-ad5d-09771f78f621");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvMemo802, "False", "AdvMemo", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvMemo, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvMemo802, "2");		
		 


			

            this.TabPage33 = _UFTabPage;
            return _UFTabPage;
        }

	                   
        private IUFCard _BuilderControl_Card7(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card7",false,"none", true, true, "0","8213ba8f-ca68-4ea5-bd1b-bbf863b4fc66","8a34bf70-88a8-45c7-9a48-931ca74dca61");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1000, 30, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 7, 1, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFCard,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(180,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card7 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblAdvCode476 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvCode476", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","8213ba8f-ca68-4ea5-bd1b-bbf863b4fc66","6aef3d2b-a486-414e-9802-4c90da1716b9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvCode476, "0");		


				this.AdvCode476 = UIControlBuilder.BuilderTextBox(_UFCard, "AdvCode476", "True", "True", "True", "False", "Left", 0, 60, 0, 180, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAdvCode476","","50","8213ba8f-ca68-4ea5-bd1b-bbf863b4fc66","e695f198-0b25-453a-98b7-7adbad1458a9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvCode476, "False", "AdvCode", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvCode, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvCode476, "1");		
		 

				this.lblIsClose1250 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsClose1250", "", "True", "True", "Right", 100, 20, 4, 0, 1, 1, "100","57fbd115-c41b-4869-a391-9e7805ad070b","c3efb35e-a27f-4446-a732-bc98f7c76e8a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsClose1250, "2");		


				this.IsClose1250 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsClose1250", true, true, "Left", 60, 0, 100, 20, 6, 0, 1, 1, "100",false,"lblIsClose1250","57fbd115-c41b-4869-a391-9e7805ad070b","9dafff01-cc38-4304-8194-ef0c090336e3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsClose1250, "False", "IsClose", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldIsClose, "AdvApplyBE");
		

		
			UIControlBuilder.BuilderUFControl(this.IsClose1250, "3");		
		 


				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
