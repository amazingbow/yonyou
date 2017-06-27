


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
 * Form ID:afaf9aeb-b5ab-4967-b806-ac2e45e58871 
 * Form Name:XMJLBatchIssueUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBatchIssueUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.Qry.BOMUI","UFIDA.U9.Cust.XMJL.Qry.XMJLBatchIssueUIModel.XMJLBatchIssueUIFormWebPart", "UFIDA.U9.Cust.XMJL.Qry.BOMUI.WebPart", "afaf9aeb-b5ab-4967-b806-ac2e45e58871","WebPart", "False", 710, 502)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.Qry.BOMUI', 'UFIDA.U9.Cust.XMJL.Qry.XMJLBatchIssueUIModel.XMJLBatchIssueUIFormWebPart', 'UFIDA.U9.Cust.XMJL.Qry.BOMUI.WebPart', 'afaf9aeb-b5ab-4967-b806-ac2e45e58871')
	///<siteMapNode url="~/erp/simple.aspx?lnk=afaf9aeb-b5ab-4967-b806-ac2e45e58871" title="XMJLBatchIssueUIForm"/>
    public partial class XMJLBatchIssueUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBatchIssueUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new XMJLBatchIssueUIModelAction Action
		{
			get { return (XMJLBatchIssueUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		XMJLBatchIssueUIModelModel _uimodel=null;
		public new XMJLBatchIssueUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new XMJLBatchIssueUIModelModel();
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
                this.Model = value as XMJLBatchIssueUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFLine Line0;
        IUFLabel lblID83;
        IUFFldNumberControl ID83;
        IUFLabel lblSysVersion44;
        IUFFldNumberControl SysVersion44;
        IUFLabel lblContractNo140;
        IUFFldTextBox ContractNo140;
        IUFLabel lblCarType131;
        IUFFldTextBox CarType131;
        IUFButton BtnBOMMainFind;
        IUFDataGrid DataGrid0;
        IUFLabel lblDisburseType47;
        IUFFldDropDownList DisburseType47;
        IUFLabel lblManufactureNo127;
        IUFFldTextBox ManufactureNo127;
        IUFFldDropDownList ddlHiddenForSelect;
        IUFLabel Label141;
        IUFLabel hasSelectedNum;
        IUFButton BtnClear;
        IUFCard Card1;
        IUFButton BtnClose;
        IUFButton BtnOk;
        IUFLabel lblID84;
        IUFFldNumberControl ID84;
        IUFLabel lblCreatedOn0;
        IUFFldDatePicker CreatedOn0;
        IUFLabel lblCreatedBy0;
        IUFFldTextBox CreatedBy0;
        IUFLabel lblModifiedOn0;
        IUFFldDatePicker ModifiedOn0;
        IUFLabel lblModifiedBy0;
        IUFFldTextBox ModifiedBy0;
        IUFLabel lblSysVersion45;
        IUFFldNumberControl SysVersion45;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public XMJLBatchIssueUIFormWebPart()
        {
            FormID = "afaf9aeb-b5ab-4967-b806-ac2e45e58871";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnBOMMainFind.Click += new EventHandler(BtnBOMMainFind_Click);		
						
				//Grid控件事件
			((UFWebDataGridAdapter)this.DataGrid0).GridRowClickedHandler += new GridRowClickedDelegate(DataGrid0_GridRowClicked);
			//((UFWebDataGridAdapter)this.DataGrid0).ClickAutoPostBack = true;
									
				//Button控件事件
			this.BtnClear.Click += new EventHandler(BtnClear_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						

			
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
					this.Model = new XMJLBatchIssueUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (XMJLBatchIssueUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new XMJLBatchIssueUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"XMJLBatchIssueUIForm",true,710,502);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  this.Model.BOMMainInfoView, "BOMMainInfoView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(682,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(446,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "1");		


	
			_BuilderControl_Card1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "2");		


				this.lblID84 = UIControlBuilder.BuilderUFLabel(_panel, "lblID84", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","40440cd0-d717-401f-9217-ad78a9bf3f15","029c9e6a-2373-43b5-9605-d69ed35bf7e8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID84, "3");		


				this.ID84 = UIControlBuilder.BuilderNumberControl(_panel, "ID84", "False", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID84","","40440cd0-d717-401f-9217-ad78a9bf3f15","b399fc80-88f3-462c-80b6-536a58bd2060",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID84, "False", "ID", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldID, "BOMMainInfoView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID84, "4");		
		 

				this.lblCreatedOn0 = UIControlBuilder.BuilderUFLabel(_panel, "lblCreatedOn0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","66cf76cf-cb94-456e-8d95-bccf14c0a2df","352686d5-6765-41fe-a94e-45fd02a63436");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreatedOn0, "5");		


				this.CreatedOn0 = UIControlBuilder.BuilderDatePicker(_panel, "CreatedOn0", false, false, true, "DateTime","Left", 5, 60, 0, 160, 20, 0, 0, 1, 1, "100",true,false,"lblCreatedOn0","66cf76cf-cb94-456e-8d95-bccf14c0a2df","be875b89-593e-437c-a78e-9eee040a4539");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreatedOn0, "False", "CreatedOn", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldCreatedOn, "BOMMainInfoView");


		
			UIControlBuilder.BuilderUFControl(this.CreatedOn0, "6");		
		 

				this.lblCreatedBy0 = UIControlBuilder.BuilderUFLabel(_panel, "lblCreatedBy0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","f44ceae4-b502-463a-86bf-c5cc5c2bdf81","20bef3c7-fdd4-4b79-9e0a-837c1057514d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreatedBy0, "7");		


				this.CreatedBy0 = UIControlBuilder.BuilderTextBox(_panel, "CreatedBy0", "False", "False", "True", "False", "Left", 0, 60, 0, 160, 20, 0, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCreatedBy0","","","f44ceae4-b502-463a-86bf-c5cc5c2bdf81","2ffd3ee0-aaae-4ed4-8fc6-5cd3ac6557de");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreatedBy0, "False", "CreatedBy", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldCreatedBy, "BOMMainInfoView");


		
			UIControlBuilder.BuilderUFControl(this.CreatedBy0, "8");		
		 

				this.lblModifiedOn0 = UIControlBuilder.BuilderUFLabel(_panel, "lblModifiedOn0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","9b35d256-8238-4d4f-8d16-00216e3912c9","1ff453ed-a374-4725-bdaa-42a501a2c578");


								

		
			UIControlBuilder.BuilderUFControl(this.lblModifiedOn0, "9");		


				this.ModifiedOn0 = UIControlBuilder.BuilderDatePicker(_panel, "ModifiedOn0", false, false, true, "DateTime","Left", 5, 60, 0, 160, 20, 0, 0, 1, 1, "100",true,false,"lblModifiedOn0","9b35d256-8238-4d4f-8d16-00216e3912c9","2b196e4c-8434-4c28-8443-d5095cb3897c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ModifiedOn0, "False", "ModifiedOn", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldModifiedOn, "BOMMainInfoView");


		
			UIControlBuilder.BuilderUFControl(this.ModifiedOn0, "10");		
		 

				this.lblModifiedBy0 = UIControlBuilder.BuilderUFLabel(_panel, "lblModifiedBy0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","c1910b67-44df-4738-9df0-19d9dc6ab989","dfa8d492-8b43-4ac3-8272-9518459e9b92");


								

		
			UIControlBuilder.BuilderUFControl(this.lblModifiedBy0, "11");		


				this.ModifiedBy0 = UIControlBuilder.BuilderTextBox(_panel, "ModifiedBy0", "False", "False", "True", "False", "Left", 0, 60, 0, 160, 20, 0, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblModifiedBy0","","","c1910b67-44df-4738-9df0-19d9dc6ab989","d4cfcf96-e40c-4d9a-83c7-5013d54ae212");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ModifiedBy0, "False", "ModifiedBy", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldModifiedBy, "BOMMainInfoView");


		
			UIControlBuilder.BuilderUFControl(this.ModifiedBy0, "12");		
		 

				this.lblSysVersion45 = UIControlBuilder.BuilderUFLabel(_panel, "lblSysVersion45", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","a3cbf07e-74c2-44ef-b20f-a14e0fb35842","6205b967-9bbe-4a4f-a02a-9e6233138220");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion45, "13");		


				this.SysVersion45 = UIControlBuilder.BuilderNumberControl(_panel, "SysVersion45", "False", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion45","","a3cbf07e-74c2-44ef-b20f-a14e0fb35842","8bac86b5-7c4b-419b-8141-a2217b8ca602",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion45, "False", "SysVersion", this.Model.BOMMainInfoView, this.Model.BOMMainInfoView.FieldSysVersion, "BOMMainInfoView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion45, "14");		
		 


														
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "1","c5a4b508-b389-4f2e-8dc8-d820d9039bfa","4aa55507-c5a8-470a-a579-5ce6a4476cd4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 682, 446, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 13, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.FindBOMMainWhereView, "FindBOMMainWhereView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(90,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(164,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(144,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 669, "Horizontal", "True", 669, 20, 0, 0, 11, 1, "100","0537e66f-7629-49d9-9f60-53c1dad812b9","0537e66f-7629-49d9-9f60-53c1dad812b9");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "1");		


				this.lblID83 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID83", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","c5a4b508-b389-4f2e-8dc8-d820d9039bfa","1468874d-4b8c-4ba3-81a8-68a07f36de7e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID83, "2");		


				this.ID83 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID83", "False", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID83","","c5a4b508-b389-4f2e-8dc8-d820d9039bfa","54b2a5c3-c518-4c92-948d-e82938fdfa9e",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID83, "False", "ID", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldID, "FindBOMMainWhereView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID83, "3");		
		 

				this.lblSysVersion44 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion44", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","642886ed-b518-48b6-913f-4f88a4b27fc2","27e454b5-8741-4aed-8aa1-70826faba33a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion44, "4");		


				this.SysVersion44 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion44", "False", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion44","","642886ed-b518-48b6-913f-4f88a4b27fc2","c2b3030d-bb71-4696-9aed-b8ad979fecd6",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion44, "False", "SysVersion", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldSysVersion, "FindBOMMainWhereView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion44, "5");		
		 

				this.lblContractNo140 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContractNo140", "", "True", "True", "Right", 90, 20, 4, 1, 1, 1, "100","c268ee64-83ad-48ff-9b75-dfb08c7af55f","8c1190cb-4fb6-4491-89c9-1b8652e6e0e8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContractNo140, "11");		


				this.ContractNo140 = UIControlBuilder.BuilderTextBox(_UFCard, "ContractNo140", "True", "True", "True", "False", "Left", 0, 60, 0, 90, 20, 6, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblContractNo140","","50","c268ee64-83ad-48ff-9b75-dfb08c7af55f","0c8bc779-8aec-4b5e-ac2f-77fc87094a2d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContractNo140, "False", "ContractNo", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldContractNo, "FindBOMMainWhereView");


		
			UIControlBuilder.BuilderUFControl(this.ContractNo140, "12");		
		 

				this.lblCarType131 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCarType131", "", "True", "True", "Right", 90, 20, 0, 2, 1, 1, "100","c0dfb6bc-af43-4d16-ba93-ea49c1dbfd20","467da592-1ba3-4334-83e8-3dac7adea6c1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCarType131, "7");		


				this.CarType131 = UIControlBuilder.BuilderTextBox(_UFCard, "CarType131", "True", "True", "True", "False", "Left", 0, 60, 0, 90, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCarType131","","50","c0dfb6bc-af43-4d16-ba93-ea49c1dbfd20","28c0083a-be49-48bd-a096-58cc1b16edf2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CarType131, "False", "CarType", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldCarType, "FindBOMMainWhereView");


		
			UIControlBuilder.BuilderUFControl(this.CarType131, "10");		
		 

				this.BtnBOMMainFind = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnBOMMainFind", true, true, 90, 20, 8, 2, 1, 1, "100","", this.Model.ElementID,"",false,"1280625d-ef78-4285-b7e5-f917778063fa","","1280625d-ef78-4285-b7e5-f917778063fa");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnBOMMainFind, "13");		


	
			_BuilderControl_DataGrid0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "8");		


				this.lblDisburseType47 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDisburseType47", "", "True", "True", "Right", 90, 20, 4, 2, 1, 1, "100","c83cb788-c183-4357-9132-e99fa9ee48dc","bb040a0b-0d73-4c4b-9632-201708c026a2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDisburseType47, "14");		


		        this.DisburseType47 = UIControlBuilder.BuilderDropDownList(_UFCard, "DisburseType47", "UFIDA.U9.Cust.XMJL.BommBE.BomMainType", true,  true, true, "Left", 2, 60, 0, 90, 20, 6, 2, 1, 1, "100",true,false,"lblDisburseType47","c83cb788-c183-4357-9132-e99fa9ee48dc","f2d24465-e103-42d2-8c3a-8c9fc96f04b0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DisburseType47, "False", "DisburseType", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldDisburseType, "FindBOMMainWhereView");
			EnumTypeList.Add("UFIDA.U9.Cust.XMJL.BommBE.BomMainType");
			EnumControlsMap.Add(this.DisburseType47, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DisburseType47, "15");		
		 

				this.lblManufactureNo127 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblManufactureNo127", "", "True", "True", "Right", 90, 20, 0, 1, 1, 1, "100","a4dddf2f-c2cd-4bd7-8a2a-da8f5615b22f","b37c77eb-a070-4d49-8ce6-4ebd03ded70d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblManufactureNo127, "16");		


				this.ManufactureNo127 = UIControlBuilder.BuilderTextBox(_UFCard, "ManufactureNo127", "True", "True", "True", "False", "Left", 0, 60, 0, 90, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblManufactureNo127","","50","a4dddf2f-c2cd-4bd7-8a2a-da8f5615b22f","76b325de-bb3a-4ba0-8956-ac85a74be9bf");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ManufactureNo127, "False", "ManufactureNo", this.Model.FindBOMMainWhereView, this.Model.FindBOMMainWhereView.FieldManufactureNo, "FindBOMMainWhereView");


		
			UIControlBuilder.BuilderUFControl(this.ManufactureNo127, "17");		
		 

		        this.ddlHiddenForSelect = UIControlBuilder.BuilderDropDownList(_UFCard, "ddlHiddenForSelect", "", true,  false, true, "Left", 0, 60, 0, 90, 20, 0, 0, 1, 1, "100",true,false,"","","d48fb979-e0a7-428b-83a9-c55b5490bd04");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ddlHiddenForSelect, "False", "", null, null, "");
			EnumControlsMap.Add(this.ddlHiddenForSelect, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.ddlHiddenForSelect, "18");		
		 

				this.Label141 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label141", "", "True", "True", "Right", 90, 20, 0, 3, 1, 1, "100","cb60c450-a379-4bd8-8341-977321be1dcf","cb60c450-a379-4bd8-8341-977321be1dcf");


								

		
			UIControlBuilder.BuilderUFControl(this.Label141, "19");		


				this.hasSelectedNum = UIControlBuilder.BuilderUFLabel(_UFCard, "hasSelectedNum", "", "True", "True", "Left", 90, 20, 2, 3, 1, 1, "100","8e319922-f055-4df4-8f35-51362c2c559f","8e319922-f055-4df4-8f35-51362c2c559f");


								

		
			UIControlBuilder.BuilderUFControl(this.hasSelectedNum, "20");		


				this.BtnClear = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClear", true, true, 90, 20, 4, 3, 1, 1, "100","", this.Model.ElementID,"",false,"fd53b196-e3e6-4a6c-9e6e-1dbe82a7ed4d","","fd53b196-e3e6-4a6c-9e6e-1dbe82a7ed4d");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClear, "21");		



																			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, false,false,false,false,true,30,true, true) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 669, 344, 0, 4, 11, 9, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.BOMMainInfoView, "BOMMainInfoView", "", null, 30, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=true;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=true;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=true;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);
			//Grid所有页全选事件 
			((UFWebDataGridAdapter)this.DataGrid0).GridSelectAllPageHandler +=
				new GridSelectAllPageDelegate(UFIDA.U9.UI.PDHelper.PDListHelper.UFGridDataGrid_GridSelectAllPageDelegate);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID84","NumberColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","40440cd0-d717-401f-9217-ad78a9bf3f15","40440cd0-d717-401f-9217-ad78a9bf3f15","3df0d8a5-ed2d-4618-b1f3-ea95fb0351e7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion45","NumberColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","a3cbf07e-74c2-44ef-b20f-a14e0fb35842","a3cbf07e-74c2-44ef-b20f-a14e0fb35842","3c8ef6da-ff51-4236-97c8-919fdcfa1f97");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"No1","NumberColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["No"]/*No*/,"No", false, true, false, false, false, true, 2, 70, "10.0",true, false,"","a9380a33-ad81-45f0-aed3-46e28643a2d8","a9380a33-ad81-45f0-aed3-46e28643a2d8","2de48d22-3279-43ef-90f7-ab78ed23b718");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ManufactureNo90","ReferenceColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["ManufactureNo"]/*ManufactureNo*/,"ManufactureNo", false, true, false, false, false, true, 7, 160, "19.0",true, false,"","958c52bb-2b58-411c-9808-3bcf53e986eb","958c52bb-2b58-411c-9808-3bcf53e986eb","87b0caa9-7aa8-41c9-aad6-ed1e766cc396");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.BOMMainInfoView.FieldManufactureNo_Code/*ManufactureNo_Code*/, this.Model.BOMMainInfoView.FieldManufactureNo_Name/*ManufactureNo_Name*/, "65b15208-f055-4f29-8da7-a2cc9d7c1198"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "87b0caa9-7aa8-41c9-aad6-ed1e766cc396";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractNo141","TextBoxColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["ContractNo"]/*ContractNo*/,"ContractNo", false, true, false, false, false, true, 0, 160, "50",true, false,"","9a86bd1f-8eba-433f-b7ff-3f7b10ddcccc","9a86bd1f-8eba-433f-b7ff-3f7b10ddcccc","540b7d81-9e50-4958-8e49-07f3dafda235");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CarType132","TextBoxColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["CarType"]/*CarType*/,"CarType", false, true, false, false, false, true, 0, 160, "50",true, false,"","a0b9ff4a-158c-497f-8107-d5d3a2cd3874","a0b9ff4a-158c-497f-8107-d5d3a2cd3874","bef17b42-9380-4fdb-b3fd-782f3f73ceae");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DisburseType48","DropDownListColumnModel", "", 0,this.Model.BOMMainInfoView.Fields["DisburseType"]/*DisburseType*/,"DisburseType", false, true, true, false, false, true, 2, 100, "10.0",true, false,"","e454a3f9-46aa-456b-9111-4c0951b5c55e","e454a3f9-46aa-456b-9111-4c0951b5c55e","a7036367-b771-49cb-a219-cf1b52a6e598");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.XMJL.BommBE.BomMainType";
			EnumTypeList.Add("UFIDA.U9.Cust.XMJL.BommBE.BomMainType");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"FunctionBar", true, true, "2","","98cc1481-3c21-44c2-9261-f596b2215644");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 682, 25, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","2cf52371-4401-46cb-9abe-507116032339");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "6");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"",false,"7f273bfe-2955-4a1b-9ed1-93d2b3a3fbb5","","7f273bfe-2955-4a1b-9ed1-93d2b3a3fbb5");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "5");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
