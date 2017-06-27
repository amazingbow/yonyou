


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
 * Form ID:c232866a-d519-4014-8fd4-4501b26b87e7 
 * Form Name:BOMUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace BOMUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.UI","BOMUIModel.BOMUIFormWebPart", "UFIDA.U9.Cust.XMJL.UI.WebPart", "c232866a-d519-4014-8fd4-4501b26b87e7","WebPart", "True", 1300, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.UI', 'BOMUIModel.BOMUIFormWebPart', 'UFIDA.U9.Cust.XMJL.UI.WebPart', 'c232866a-d519-4014-8fd4-4501b26b87e7')
	///<siteMapNode url="~/erp/simple.aspx?lnk=c232866a-d519-4014-8fd4-4501b26b87e7" title="BOMUIForm"/>
    public partial class BOMUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BOMUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new BOMUIModelAction Action
		{
			get { return (BOMUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		BOMUIModelModel _uimodel=null;
		public new BOMUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new BOMUIModelModel();
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
                this.Model = value as BOMUIModelModel;
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
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFSeparator Separator5;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFDropDownButton DDBtnOperation;
        IUFDropDownButton DDBtnActivity;
        IUFDropDownButton DDBtnQuery;
        IUFDropDownButton DDBtnTaskLink;
        IUFCard Card3;
        IUFCard Card4;
        IUFLabel lblID71;
        IUFFldNumberControl ID71;
        IUFLabel lblSysVersion71;
        IUFFldNumberControl SysVersion71;
        IUFLabel lblDocumentType62;
        IUFFldReference DocumentType62;
        IUFLabel lblDocNo53;
        IUFFldTextBox DocNo53;
        IUFLabel lblManufactureNo37;
        IUFFldReference ManufactureNo37;
        IUFLabel lblContractNo89;
        IUFFldTextBox ContractNo89;
        IUFLabel lblSequence110;
        IUFFldNumberControl Sequence110;
        IUFLabel lblDisburseBY439;
        IUFFldReference DisburseBY439;
        IUFLabel lblDisburseOn59;
        IUFFldDatePicker DisburseOn59;
        IUFLabel lblCarType129;
        IUFFldTextBox CarType129;
        IUFLabel lblMo71;
        IUFFldReference Mo71;
        IUFLabel lblDepartment67;
        IUFFldReference Department67;
        IUFLabel lblDisburseType72;
        IUFFldDropDownList DisburseType72;
        IUFLabel lblMemo63;
        IUFFldTextBox Memo63;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblStatus192;
        IUFFldDropDownList Status192;
        IUFTabControl TabControl1;
        IUFTabPage TabPage9;
        IUFDataGrid DataGrid8;
        IUFLabel lblRowNo33;
        IUFTabPage TabPage15;
        IUFDataGrid DataGrid7;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public BOMUIFormWebPart()
        {
            FormID = "c232866a-d519-4014-8fd4-4501b26b87e7";
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
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid8).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid8_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid8).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid8_GridCustomFilterHandler);
	
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
					this.Model = new BOMUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{new InParameterModel("Cust_Xmjl_MO_BomMain"),},new InParameterModel[]{new InParameterModel("Cust_Xmjl_MO_BomMain","@ID","ID"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (BOMUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
    		if(this.Consumer.Count > 0 && this.IsConsuming)
			{
				OnPreRenderConsumer(new InParameterModel[]{new InParameterModel("Cust_Xmjl_MO_BomMain"),},new InParameterModel[]{new InParameterModel("Cust_Xmjl_MO_BomMain","@ID","ID"),});
				OnLoadData(this);//对吗？
			}
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
            this.Action = new BOMUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"BOMUIForm",true,1300,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(1300,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "6",1300, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"0", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","d13d79db-e345-417d-9626-27dd48f0d97c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"1", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","c3cc1261-adc6-4ad0-8392-dd5f8e6a1a7c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"2", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","39fdadf4-cf0b-456f-b90d-08073f3c6e34");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"3", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","a7ef05be-9a1a-4e7c-a4a2-2342fe26a834");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"4", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","31cbeb97-d610-4ae7-bf30-b01b69570785");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"5", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","5e3ac2f9-3a5d-454b-8409-ed868b3a50dd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 60, 28,"6", "Y",true,false,"c92b634c-7c75-4165-9bff-e6e988cd39da","c92b634c-7c75-4165-9bff-e6e988cd39da","539c111f-32b8-4a12-a2cc-974df9e959d0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"7", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","851c0b7e-c984-455e-bf9d-3fa941358f73");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"8", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","b8a4c2fe-00bc-4990-a50e-94fdc2e39573");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"9", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","c0e8755c-0ab5-40d6-8a4c-7143780655cc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"10", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","583376ff-8042-49d2-a542-cb2e5e19d832");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"11", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","2ed2b8cd-4a5a-4d67-893d-eb681e1dbff3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"12", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","72ce9595-a0e4-4765-8351-a5e85856e353");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"16", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","7c64d828-a471-45c1-aa89-84aafe7caaef");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "4","","28cea4d9-f4bf-4306-bba6-a656e1a4afa5");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1300, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DDBtnOperation(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnOperation, "20");		


	
			_BuilderControl_DDBtnActivity(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnActivity, "21");		


	
			_BuilderControl_DDBtnQuery(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnQuery, "22");		


	
			_BuilderControl_DDBtnTaskLink(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnTaskLink, "27");		



				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				       
        private void _BuilderControl_DDBtnOperation(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnOperation",true, true,"20"
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","198311ae-f300-40e7-9272-f36099dbf53f");
            this.DDBtnOperation = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnActivity(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnActivity",true, true,"21"
            , 80, 20, 2, 0, 1, 1, "100","d24eab78-82b5-4f55-aa4a-f1c85a2c0489","76848db8-78b4-4b7f-a6ef-9e9ea192e823");
            this.DDBtnActivity = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",true, true,"22"
            , 80, 20, 4, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","877a2ecc-8209-43f5-8170-fb33038a906a");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnTaskLink(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnTaskLink",true, true,"27"
            , 80, 20, 6, 0, 1, 1, "100","e9b85406-d7e2-41f5-94da-49a69f06327c","93265108-0448-4cc7-81dc-bef86a2eb287");
            this.DDBtnTaskLink = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "5","","db7b4bd1-363a-4b4b-82b8-b793b8399a32");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1300, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(1292,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(100,bool.Parse("True")),new GridRowDef(280,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",true,"none", true, true, "2","a5f8fdd0-4d61-4d96-b7ff-72e0cf218cb3","e85ba745-c5f6-4e9c-a686-59f2d2114ebf");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1292, 100, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 16, 4, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.Cust_Xmjl_MO_BomMain, "Cust_Xmjl_MO_BomMain", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(126,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(139,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID71 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID71", "", "False", "True", "Right", 140, 20, 0, 0, 1, 1, "100","a5f8fdd0-4d61-4d96-b7ff-72e0cf218cb3","3ccd64cf-2f6a-4276-beb4-64bfeb92a85d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID71, "0");		


				this.ID71 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID71", "False", "False", "True", "Left", 7, 60, 0, 140, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID71","8.0","a5f8fdd0-4d61-4d96-b7ff-72e0cf218cb3","517ea810-187f-4a8c-9a54-f916a33028dd",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID71, "False", "ID", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldID, "Cust_Xmjl_MO_BomMain");
	
		
			UIControlBuilder.BuilderUFControl(this.ID71, "1");		
		 

				this.lblSysVersion71 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion71", "", "False", "True", "Right", 140, 20, 0, 0, 1, 1, "100","0d07c00e-4700-4822-b7c9-91fe58f11bc6","e15ce64e-5e95-427f-b0a2-cd596718d2e8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion71, "2");		


				this.SysVersion71 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion71", "True", "False", "True", "Left", 7, 60, 0, 140, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion71","8.0","0d07c00e-4700-4822-b7c9-91fe58f11bc6","5bc938b6-6059-430a-a2d8-ba8e7e95374c",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion71, "False", "SysVersion", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldSysVersion, "Cust_Xmjl_MO_BomMain");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion71, "3");		
		 

				this.lblDocumentType62 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocumentType62", "", "True", "True", "Right", 140, 20, 0, 0, 1, 1, "100","df84027f-8ca7-4492-80c2-05c37a974fc0","3559ac7c-aede-463f-b792-ef70f95c11bf");

			UIControlBuilder.SetLabelFormReference(this.lblDocumentType62,"083ac1d9-50d4-4748-ab40-7f86405e3da8",true,992, 504);
			//foreach input parameter
	    	ScriptBuilder.BuildFormLinkInScript(this.lblDocumentType62,"lblDocumentType62", new FormLinkInParam[]{new FormLinkInParam("ID","","Key","DocumentType62",1), });
			//foreach output set data
	    	ScriptBuilder.BuildFormLinkOutScript(this.lblDocumentType62,"lblDocumentType62", new FormLinkOutParam[]{new FormLinkOutParam("Code","","Value","DocumentType62"),new FormLinkOutParam("Name","","Text","DocumentType62"),new FormLinkOutParam("ID","","Key","DocumentType62"), });
		
								

		
			UIControlBuilder.BuilderUFControl(this.lblDocumentType62, "4");		


				this.DocumentType62 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"DocumentType62",true,true, true,140, 20, 2, 0, 1, 1, "100","5",false,false,true,"lblDocumentType62","df84027f-8ca7-4492-80c2-05c37a974fc0","c993ade9-2684-488d-84a2-6685b78fe596");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocumentType62, "False", "DocumentType", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDocumentType, "Cust_Xmjl_MO_BomMain");
			UIControlBuilder.SetReferenceControlRefInfo(this.DocumentType62,"d9fe6a38-ce7d-4178-b66a-db6fed3dfee8", 580,408, "Name","Code","ID", this.Model.Cust_Xmjl_MO_BomMain.FieldDocumentType_Code,this.Model.Cust_Xmjl_MO_BomMain.FieldDocumentType_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DocumentType62,"DocumentType62",new ReferenceOutputParam[]{new ReferenceOutputParam("DocumentType62","ID","Key"),new ReferenceOutputParam("DocumentType62","Code","Value"),new ReferenceOutputParam("DocumentType62","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.DocumentType62, "5");		
		 

				this.lblDocNo53 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocNo53", "", "True", "True", "Right", 140, 20, 0, 1, 1, 1, "100","de99fac9-6f41-4ea0-ab19-c9eb0bf481b1","27bb5686-21fd-4fc2-9d1f-a47e3a9cc5c6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocNo53, "6");		


				this.DocNo53 = UIControlBuilder.BuilderTextBox(_UFCard, "DocNo53", "False", "True", "True", "False", "Left", 0, 60, 0, 140, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblDocNo53","","50","de99fac9-6f41-4ea0-ab19-c9eb0bf481b1","5f5f10cf-c213-4ad0-8fab-d71e984e8e19");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocNo53, "False", "DocNo", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDocNo, "Cust_Xmjl_MO_BomMain");


		
			UIControlBuilder.BuilderUFControl(this.DocNo53, "7");		
		 

				this.lblManufactureNo37 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblManufactureNo37", "", "True", "True", "Right", 140, 20, 0, 2, 1, 1, "100","78641555-2c30-442a-8435-d9946f46ad18","6ca3016b-8902-4a39-843a-2b586d506244");


								

		
			UIControlBuilder.BuilderUFControl(this.lblManufactureNo37, "8");		


				this.ManufactureNo37 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ManufactureNo37",true,true, true,140, 20, 2, 2, 1, 1, "100","9",false,false,true,"lblManufactureNo37","78641555-2c30-442a-8435-d9946f46ad18","786f1d0a-c4a3-4fe7-85e3-c904e6098a71");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ManufactureNo37, "False", "ManufactureNo", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldManufactureNo, "Cust_Xmjl_MO_BomMain");
			UIControlBuilder.SetReferenceControlRefInfo(this.ManufactureNo37,"65b15208-f055-4f29-8da7-a2cc9d7c1198", 580,408, "Name","Code","ID", this.Model.Cust_Xmjl_MO_BomMain.FieldManufactureNo_Code,this.Model.Cust_Xmjl_MO_BomMain.FieldManufactureNo_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ManufactureNo37,"ManufactureNo37",new ReferenceOutputParam[]{new ReferenceOutputParam("ManufactureNo37","ID","Key"),new ReferenceOutputParam("ManufactureNo37","Code","Value"),new ReferenceOutputParam("ManufactureNo37","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.ManufactureNo37, "9");		
		 

				this.lblContractNo89 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContractNo89", "", "True", "True", "Right", 140, 20, 0, 3, 1, 1, "100","c7baa697-77b0-42eb-b5e7-73220375cc19","efcdc6ac-d299-4a84-abbb-a008f6302f65");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContractNo89, "10");		


				this.ContractNo89 = UIControlBuilder.BuilderTextBox(_UFCard, "ContractNo89", "True", "True", "True", "False", "Left", 0, 60, 0, 140, 20, 2, 3, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblContractNo89","","50","c7baa697-77b0-42eb-b5e7-73220375cc19","eb215772-7e07-415f-b244-84da762bf301");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContractNo89, "False", "ContractNo", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldContractNo, "Cust_Xmjl_MO_BomMain");


		
			UIControlBuilder.BuilderUFControl(this.ContractNo89, "11");		
		 

				this.lblSequence110 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSequence110", "", "True", "True", "Right", 126, 20, 4, 3, 1, 1, "100","3b6445d4-1772-455b-96fa-78883dcc394b","4e9d1888-f888-4c36-91b2-e562db5f8a1d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSequence110, "12");		


				this.Sequence110 = UIControlBuilder.BuilderNumberControl(_UFCard, "Sequence110", "True", "True", "True", "Left", 2, 60, 0, 140, 20, 6, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSequence110","10.0","3b6445d4-1772-455b-96fa-78883dcc394b","cfbeec40-670f-40c5-8c15-4d16db6face1",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Sequence110, "False", "Sequence", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldSequence, "Cust_Xmjl_MO_BomMain");
	
		
			UIControlBuilder.BuilderUFControl(this.Sequence110, "13");		
		 

				this.lblDisburseBY439 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDisburseBY439", "", "True", "True", "Right", 126, 20, 4, 0, 1, 1, "100","d654f202-953e-4bfb-adff-4e46c679f11a","d4fcd7e9-67fe-4f28-9fb6-ee4d313752d1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDisburseBY439, "14");		


				this.DisburseBY439 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"DisburseBY439",true,true, true,140, 20, 6, 0, 1, 1, "100","15",false,false,true,"lblDisburseBY439","d654f202-953e-4bfb-adff-4e46c679f11a","ec282bbd-57df-489d-b3c4-25f6c24eb35c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DisburseBY439, "False", "DisburseBY", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDisburseBY, "Cust_Xmjl_MO_BomMain");
			UIControlBuilder.SetReferenceControlRefInfo(this.DisburseBY439,"9f2c4026-a9c0-4c6c-8cc4-51e4b99dbca6", 580,408, "Name","Code","ID", this.Model.Cust_Xmjl_MO_BomMain.FieldDisburseBY_Code,this.Model.Cust_Xmjl_MO_BomMain.FieldDisburseBY_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.DisburseBY439,"DisburseBY439",new ReferenceInputParam[]{new ReferenceInputParam("OperatorType","","","",1),});
 			//for personal
		 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DisburseBY439,"DisburseBY439",new ReferenceOutputParam[]{new ReferenceOutputParam("DisburseBY439","ID","Key"),new ReferenceOutputParam("DisburseBY439","Code","Value"),new ReferenceOutputParam("DisburseBY439","Name","Text"),new ReferenceOutputParam("","Dept_ID",""),new ReferenceOutputParam("","Dept_Code",""),new ReferenceOutputParam("","Dept_Name",""),new ReferenceOutputParam("","MasterOrg_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.DisburseBY439, "15");		
		 

				this.lblDisburseOn59 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDisburseOn59", "", "True", "True", "Right", 126, 20, 4, 1, 1, 1, "100","393c3679-1e81-4000-b93c-b108054f6394","b8fcdb86-ab90-42d0-86f1-24b6a7c77898");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDisburseOn59, "16");		


				this.DisburseOn59 = UIControlBuilder.BuilderDatePicker(_UFCard, "DisburseOn59", true, true, true, "DateTime","Left", 5, 60, 0, 140, 20, 6, 1, 1, 1, "100",true,false,"lblDisburseOn59","393c3679-1e81-4000-b93c-b108054f6394","d32540bc-1069-4c59-aa53-2daf15fa4f39");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DisburseOn59, "False", "DisburseOn", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDisburseOn, "Cust_Xmjl_MO_BomMain");


		
			UIControlBuilder.BuilderUFControl(this.DisburseOn59, "17");		
		 

				this.lblCarType129 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCarType129", "", "True", "True", "Right", 126, 20, 4, 2, 1, 1, "100","f54b2f5d-7c63-47bf-9dbd-61b7a25610af","a8cbdff7-64e3-44fc-9456-f4d19cc98e06");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCarType129, "18");		


				this.CarType129 = UIControlBuilder.BuilderTextBox(_UFCard, "CarType129", "True", "True", "True", "False", "Left", 0, 60, 0, 140, 20, 6, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCarType129","","50","f54b2f5d-7c63-47bf-9dbd-61b7a25610af","effedc3c-a480-4ca3-92af-198601530067");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CarType129, "False", "CarType", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldCarType, "Cust_Xmjl_MO_BomMain");


		
			UIControlBuilder.BuilderUFControl(this.CarType129, "19");		
		 

				this.lblMo71 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblMo71", "", "True", "True", "Right", 139, 20, 8, 1, 1, 1, "100","c79f650e-c77e-473f-a3ea-0ff400bff15a","e27d9137-35ee-4a36-a0b3-208afa93d079");


								

		
			UIControlBuilder.BuilderUFControl(this.lblMo71, "20");		


				this.Mo71 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Mo71",true,true, true,140, 20, 10, 1, 1, 1, "100","21",false,false,true,"lblMo71","c79f650e-c77e-473f-a3ea-0ff400bff15a","f7580bbc-847c-4ad9-968b-2a4c9a442fcc");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Mo71, "False", "Mo", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldMo, "Cust_Xmjl_MO_BomMain");
			UIControlBuilder.SetReferenceControlRefInfo(this.Mo71,"17b3faf5-d774-4c8f-a499-af8d58eb8a62", 580,408, "DocNo","","ID", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Mo71,"Mo71",new ReferenceOutputParam[]{new ReferenceOutputParam("Mo71","ID","Key"),new ReferenceOutputParam("Mo71","DocNo","Value"),new ReferenceOutputParam("Mo71","ItemMaster_Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Mo71, "21");		
		 

				this.lblDepartment67 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDepartment67", "", "True", "True", "Right", 139, 20, 8, 2, 1, 1, "100","75e1ceeb-48ac-4c75-b8e9-be6a0996cdf9","9bc57bb3-5a10-4cb9-b079-bcac460705d9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDepartment67, "22");		


				this.Department67 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Department67",true,true, true,140, 20, 10, 2, 1, 1, "100","23",false,false,true,"lblDepartment67","75e1ceeb-48ac-4c75-b8e9-be6a0996cdf9","db278f28-44ee-4193-9e49-05f0d1a548ae");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Department67, "False", "Department", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDepartment, "Cust_Xmjl_MO_BomMain");
			UIControlBuilder.SetReferenceControlRefInfo(this.Department67,"ae6daa9d-a3f5-437d-8aa9-ac3070720c34", 580,408, "Name","Code","ID", this.Model.Cust_Xmjl_MO_BomMain.FieldDepartment_Code,this.Model.Cust_Xmjl_MO_BomMain.FieldDepartment_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Department67,"Department67",new ReferenceInputParam[]{new ReferenceInputParam("DepartmentID","","","",1),});
 			//for personal
		 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Department67,"Department67",new ReferenceOutputParam[]{new ReferenceOutputParam("Department67","ID","Key"),new ReferenceOutputParam("Department67","Code","Value"),new ReferenceOutputParam("Department67","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Department67, "23");		
		 

				this.lblDisburseType72 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDisburseType72", "", "True", "True", "Right", 139, 20, 8, 3, 1, 1, "100","1513e231-510e-463a-9943-23077cc9b731","ea31337d-5974-481d-91eb-7f11490ca411");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDisburseType72, "26");		


		        this.DisburseType72 = UIControlBuilder.BuilderDropDownList(_UFCard, "DisburseType72", "UFIDA.U9.Cust.XMJL.BommBE.BomMainType", true,  true, true, "Left", 2, 60, 0, 140, 20, 10, 3, 1, 1, "100",true,false,"lblDisburseType72","1513e231-510e-463a-9943-23077cc9b731","0c2899df-7701-4e9e-82f9-b37312e10ed0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DisburseType72, "False", "DisburseType", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldDisburseType, "Cust_Xmjl_MO_BomMain");
			EnumTypeList.Add("UFIDA.U9.Cust.XMJL.BommBE.BomMainType");
			EnumControlsMap.Add(this.DisburseType72, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DisburseType72, "27");		
		 

				this.lblMemo63 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblMemo63", "", "True", "True", "Right", 140, 20, 13, 0, 1, 1, "100","a52f4343-7ff6-4bb9-8b40-115f0e2417a4","df2574b0-c6bc-46ae-97da-7a0ce71b1359");


								

		
			UIControlBuilder.BuilderUFControl(this.lblMemo63, "28");		


				this.Memo63 = UIControlBuilder.BuilderTextBox(_UFCard, "Memo63", "True", "True", "True", "True", "Left", 0, 60, 0, 140, 70, 15, 0, 1, 3, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblMemo63","","50","a52f4343-7ff6-4bb9-8b40-115f0e2417a4","16d893ff-c0e1-489e-bb23-80c68193718f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Memo63, "False", "Memo", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldMemo, "Cust_Xmjl_MO_BomMain");


		
			UIControlBuilder.BuilderUFControl(this.Memo63, "29");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 140, 20, 13, 2, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","c10d278a-0a14-4729-8589-d9be4c9e722e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "30");		
		 

				this.lblStatus192 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblStatus192", "", "True", "True", "Right", 139, 20, 8, 0, 1, 1, "100","131db531-dbcc-40d2-9fd5-bc9cf41032a2","6be7589d-67ed-4b5f-a00d-09c610b47b4d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStatus192, "31");		


		        this.Status192 = UIControlBuilder.BuilderDropDownList(_UFCard, "Status192", "UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum", true,  true, true, "Left", 2, 60, 0, 140, 20, 10, 0, 1, 1, "100",true,false,"lblStatus192","131db531-dbcc-40d2-9fd5-bc9cf41032a2","87998e55-f26f-43ca-9d06-3add549a2542");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Status192, "False", "Status", this.Model.Cust_Xmjl_MO_BomMain, this.Model.Cust_Xmjl_MO_BomMain.FieldStatus, "Cust_Xmjl_MO_BomMain");
			EnumTypeList.Add("UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum");
			EnumControlsMap.Add(this.Status192, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.Status192, "32");		
		 


						
			this.DocumentType62.IsMultiOrg  = false ;
			this.lblDocumentType62.SetMultiOrgInfo(this.DocumentType62,false);
			
				
			this.ManufactureNo37.IsMultiOrg  = false ;
			this.lblManufactureNo37.SetMultiOrgInfo(this.ManufactureNo37,false);
			
						
			this.DisburseBY439.IsMultiOrg  = false ;
			this.lblDisburseBY439.SetMultiOrgInfo(this.DisburseBY439,false);
			
						
			this.Mo71.IsMultiOrg  = false ;
			this.lblMo71.SetMultiOrgInfo(this.Mo71,false);
			
		
			this.Department67.IsMultiOrg  = false ;
			this.lblDepartment67.SetMultiOrgInfo(this.Department67,false);
			
							

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				

				

	         private void _BuilderControl_TabControl1(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl1",true, true, "1",EventResponseType.Client,1293, 291, 0, 1, 2, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage9(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage15(_UFTabControl));
            this.TabControl1 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage9(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage9",true, true, "0","97448b1c-f239-40f3-b0e0-5c1fb33bd8e6","97448b1c-f239-40f3-b0e0-5c1fb33bd8e6");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 2, 3, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(1292,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(223,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid8(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid8, "0");		


				this.lblRowNo33 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblRowNo33", "", "True", "True", "Right", 1292, 20, 0, 2, 1, 1, "100","","82d930d7-2bfe-4da9-aed0-7784145b5641");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRowNo33, "1");		



		

            this.TabPage9 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid8(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid8", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 1292, 229, 0, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead, "Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead", "", null, 20, "缺件发料主表.Misc.缺件发料单");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid8 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RowNo34","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["RowNo"]/*RowNo*/,"RowNo", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","ddf292e3-fc36-408a-8c23-aa85f5bc4db2","ddf292e3-fc36-408a-8c23-aa85f5bc4db2","9341c988-1bfc-4e70-a18f-b554531c61c9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"10","10");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID95","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","60520024-2e3b-402f-b952-8477c5e53be2","60520024-2e3b-402f-b952-8477c5e53be2","66f3a99f-3350-4d16-a2d4-96b908c95b1f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion104","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","83168639-16e0-417b-b32a-b24d8cb9314c","83168639-16e0-417b-b32a-b24d8cb9314c","8e05c506-7aee-4c99-9d0d-168bdf401ac5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Item0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Item"]/*Item*/,"Item", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","0cb934ea-6b41-4c0f-b821-fde0248ce8b0","0cb934ea-6b41-4c0f-b821-fde0248ce8b0","8fc3c180-a3e0-4a5a-b4bc-da08f7591622");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Code/*Item_Code*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Name/*Item_Name*/, "beedebc3-5398-46b5-a237-5a3a4d13ad4f"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "8fc3c180-a3e0-4a5a-b4bc-da08f7591622";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Item", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Item_Code", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Item", "Text"));
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Item_Code1","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Item_Code"]/*Item_Code*/,"Item_Code", false, true, true, false, false, false, 0, 100, "255",true, false,"","1ec4b5db-ee25-4b14-af34-c375d2d322c5","1ec4b5db-ee25-4b14-af34-c375d2d322c5","158fb0ac-1d48-4e49-8355-653e96070830");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","255") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Supplier0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Supplier"]/*Supplier*/,"Supplier", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","16c04fc5-ef1f-4134-9c42-7be44214df28","16c04fc5-ef1f-4134-9c42-7be44214df28","3e681330-cfdb-4468-89bc-fca50c20c8b5");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Code/*Supplier_Code*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Name/*Supplier_Name*/, "ea01ca72-c3a4-4563-b9b9-d47c720f051c"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "3e681330-cfdb-4468-89bc-fca50c20c8b5";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Supplier", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Supplier", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Supplier", "Text"));
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"WareHouse0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["WareHouse"]/*WareHouse*/,"WareHouse", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","e1c8365f-3379-4764-820b-400ff8001f13","e1c8365f-3379-4764-820b-400ff8001f13","ea855e84-db3d-40db-9137-dcd78d07c83e");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Code/*WareHouse_Code*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Name/*WareHouse_Name*/, "1dc5d0ff-a06e-4dd8-a056-f1b266104b57"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "ea855e84-db3d-40db-9137-dcd78d07c83e";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "WareHouse", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "WareHouse", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "WareHouse", "Text"));
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"WorkPlace0","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["WorkPlace"]/*WorkPlace*/,"WorkPlace", false, true, true, false, false, true, 0, 100, "50",true, false,"","e605f7e4-fd0a-4dae-86dd-704aa35e00dc","e605f7e4-fd0a-4dae-86dd-704aa35e00dc","ba796098-b294-4138-a988-d56e06cf7d3e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Status85","DropDownListColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Status"]/*Status*/,"Status", false, true, true, false, false, true, 2, 100, "10.0",true, false,"1","778b7ca4-0c22-4126-8154-3a7aeaa7b3d6","778b7ca4-0c22-4126-8154-3a7aeaa7b3d6","e8e3b130-659d-4668-8d6a-b2a84507d61c");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus";
			EnumTypeList.Add("UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Qty0","NumberColumnModel", "", 2,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Qty"]/*Qty*/,"Qty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","88031f7b-9a94-45a8-bff0-21a083a40637","88031f7b-9a94-45a8-bff0-21a083a40637","d1469bde-0c1c-4970-b9b9-3fdb68033a04");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DisbursedQty0","NumberColumnModel", "", 2,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["DisbursedQty"]/*DisbursedQty*/,"DisbursedQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","c2910efd-2f30-42e9-925c-0ec37caaa7dd","c2910efd-2f30-42e9-925c-0ec37caaa7dd","9c20dfd1-fadc-49a8-b2fd-a4718553b4b5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RptBy0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["RptBy"]/*RptBy*/,"RptBy", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","3286a9f4-5955-4841-8556-f7041f94746e","3286a9f4-5955-4841-8556-f7041f94746e","86157343-837e-4344-8084-3eb6102c7dc3");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Code/*RptBy_Code*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Name/*RptBy_Name*/, "b91d9f6c-d058-48c7-bff4-ecf349a84098"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "86157343-837e-4344-8084-3eb6102c7dc3";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "RptBy", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "RptBy", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "RptBy", "Text"));
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RptOn0","DatePickerColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["RptOn"]/*RptOn*/,"RptOn", false, true, true, false, false, true, 5, 70, "19",true, false,"","11a34daa-7cc1-4fad-b48c-f56c1fecebc0","11a34daa-7cc1-4fad-b48c-f56c1fecebc0","3c7a51ad-9ce6-46be-ad3b-6bc5e623e1d5");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo64","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["Memo"]/*Memo*/,"Memo", false, true, true, false, false, true, 0, 100, "50",true, false,"","143ff7fb-fa2a-4cc5-9201-d93888d74832","143ff7fb-fa2a-4cc5-9201-d93888d74832","460bfe7e-6855-4d26-90a9-f55d3d8d2d01");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FeeID0","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["FeeID"]/*FeeID*/,"FeeID", false, true, true, false, false, true, 0, 100, "50",true, false,"","da1b5bc0-74f4-4103-8db4-655a4aa51c66","da1b5bc0-74f4-4103-8db4-655a4aa51c66","07a1465b-bbf1-4bf2-b3d9-fb5fa57c1b0a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"OutOn0","DatePickerColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["OutOn"]/*OutOn*/,"OutOn", false, true, true, false, false, true, 5, 70, "19",true, false,"","7ce65eae-ae24-4fca-88f9-71f4778af415","7ce65eae-ae24-4fca-88f9-71f4778af415","24bffdc3-6543-4e1e-aae6-2117e116df34");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FeeQty0","NumberColumnModel", "", 2,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["FeeQty"]/*FeeQty*/,"FeeQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","7fe86ee9-406f-428b-914a-557fb8526484","7fe86ee9-406f-428b-914a-557fb8526484","85d1bd85-1e30-41fd-822a-69aefa7816e9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BackQty0","NumberColumnModel", "", 2,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.Fields["BackQty"]/*BackQty*/,"BackQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","fc2a619b-ef9a-4284-ba57-08802cd82faf","fc2a619b-ef9a-4284-ba57-08802cd82faf","cefe5993-e805-48d2-b717-e9e478bdf6f7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"TextBoxColumn67","TextBoxColumnModel", "", 0,null,"", false, true, true, false, false, true, 0, 100, "",true, false,"","","","2e0973c5-1d85-4955-94dc-15fd48b29021");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","") ;          
	  
		 
        }

	        private IUFTabPage _BuilderControl_TabPage15(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage15",true, true, "7","998e862a-a1bc-45d9-9785-8e5089e57341","998e862a-a1bc-45d9-9785-8e5089e57341");
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
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid7", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, false,false,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 954, 229, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine, "Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine", "", null, 20, "缺件发料单.Misc.缺件发料单子行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid7 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID96","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","55357610-1d5d-4f62-8969-15b5fcf67fbd","55357610-1d5d-4f62-8969-15b5fcf67fbd","34315d4c-6d9a-4f1a-8830-fbcc53b90857");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion105","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","f26f49cd-2300-4fee-aa60-75af63a4fc4f","f26f49cd-2300-4fee-aa60-75af63a4fc4f","c5e9c03a-7980-40c1-b971-933c081ab7c9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RowNo35","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["RowNo"]/*RowNo*/,"RowNo", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","e6bb637c-d0b4-4016-b3f8-e0a3518d994b","e6bb637c-d0b4-4016-b3f8-e0a3518d994b","d9e6a815-6faf-4af3-97a3-c0eaf63b52d7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"10","10");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Qty1","NumberColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["Qty"]/*Qty*/,"Qty", false, true, true, false, false, true, 8, 100, "10.0",true, false,"0","12ac91ae-24b9-4025-95b6-e1c3ad67d509","12ac91ae-24b9-4025-95b6-e1c3ad67d509","83252ea1-114a-47d9-af7f-746cd3cdaa25");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ShipL0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["ShipL"]/*ShipL*/,"ShipL", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","890425e1-1253-413b-a4f6-bfeb47b40279","890425e1-1253-413b-a4f6-bfeb47b40279","10e16931-9540-4f3b-8282-8502d0aa52d5");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "ItemInfo_ItemName", "ItemInfo_ItemName", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldShipL/*ShipL*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldShipL/*ShipL*/, "88e9cadc-b354-4a43-8f8d-c0aa76f81c95"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "10e16931-9540-4f3b-8282-8502d0aa52d5";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "ShipL", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("DocLineNo", "ShipL", "Value"));
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RcvTransL0","ReferenceColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["RcvTransL"]/*RcvTransL*/,"RcvTransL", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","9d8f8fd4-2485-4766-a8a0-94af57b46bc0","9d8f8fd4-2485-4766-a8a0-94af57b46bc0","69498990-bcbc-4d18-9ef7-a30278846ca2");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "ItemInfo_ItemCode", "ItemInfo_ItemCode", this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRcvTransL/*RcvTransL*/, this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRcvTransL/*RcvTransL*/, "ee4c9f0e-064a-492e-ac15-ec1e7e0ac87e"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "69498990-bcbc-4d18-9ef7-a30278846ca2";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "RcvTransL", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("DocLineNo", "RcvTransL", "Key"));
							
							
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("MiscRcvTrans_DocNo", "RcvTransL", "Text"));
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Memo65","TextBoxColumnModel", "", 0,this.Model.Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.Fields["Memo"]/*Memo*/,"Memo", false, true, true, false, false, true, 0, 100, "50",true, false,"","b84a8abe-40d9-41ae-ae76-6886c950c76c","b84a8abe-40d9-41ae-ae76-6886c950c76c","6e5261e6-577d-4b04-8fa6-5b41461e7e6d");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
