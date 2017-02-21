


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
 * Form ID:c70d4c53-455e-4fa4-ac34-168907583ba7 
 * Form Name:LaserLabScrapUIFrom
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabScrapUI.LaserLabScrapUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabScrapUI","UFIDA.U9.Cust.XMQX.LaserLabScrapUI.LaserLabScrapUIModel.LaserLabScrapUIFromWebPart", "UFIDA.U9.Cust.XMQX.LaserLabScrapUI.WebPart", "c70d4c53-455e-4fa4-ac34-168907583ba7","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMQX.LaserLabScrapUI', 'UFIDA.U9.Cust.XMQX.LaserLabScrapUI.LaserLabScrapUIModel.LaserLabScrapUIFromWebPart', 'UFIDA.U9.Cust.XMQX.LaserLabScrapUI.WebPart', 'c70d4c53-455e-4fa4-ac34-168907583ba7')
	///<siteMapNode url="~/erp/simple.aspx?lnk=c70d4c53-455e-4fa4-ac34-168907583ba7" title="LaserLabScrapUIFrom"/>
    public partial class LaserLabScrapUIFromWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabScrapUIFromWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LaserLabScrapUIModelAction Action
		{
			get { return (LaserLabScrapUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		LaserLabScrapUIModelModel _uimodel=null;
		public new LaserLabScrapUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LaserLabScrapUIModelModel();
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
                this.Model = value as LaserLabScrapUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFTabControl TabControl2;
        IUFTabPage TabPage0;
        IUFLine Line0;
        IUFLabel lblBN474;
        IUFFldTextBox BN474;
        IUFLabel lblType63;
        IUFFldTextBox Type63;
        IUFLabel lblDate69;
        IUFFldTextBox Date69;
        IUFLabel lblTime87;
        IUFFldTextBox Time87;
        IUFLabel lblCP84;
        IUFFldTextBox CP84;
        IUFButton BtnOk;
        IUFButton BtnClear;
        IUFLabel lblID48;
        IUFFldNumberControl ID48;
        IUFLabel lblSysVersion78;
        IUFFldNumberControl SysVersion78;
        IUFCard Card1;
        IUFLabel Label1;
        IUFFldTextBox TextBox1;
        IUFLabel Label2;
        IUFFldDatePicker DatePicker2;
        IUFButton BtnReturnMaster;
        IUFTabPage TabPage2;
        IUFDataGrid DataGrid0;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LaserLabScrapUIFromWebPart()
        {
            FormID = "c70d4c53-455e-4fa4-ac34-168907583ba7";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
							
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClear.Click += new EventHandler(BtnClear_Click);		
						
				//Button控件事件
			this.BtnReturnMaster.Click += new EventHandler(BtnReturnMaster_Click);		
						

		
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
					this.Model = new LaserLabScrapUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LaserLabScrapUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new LaserLabScrapUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabScrapUIFrom",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 0,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(500,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "2");		



	
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "2","","03fd6a00-decb-4574-8d3c-b2300caa20b1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 500, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 3, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(1,bool.Parse("True")),new GridColumnDef(990,bool.Parse("False")),new GridColumnDef(1,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(498,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl2, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl2(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl2",true, true, "1",EventResponseType.Server,990, 498, 1, 1, 1, 1, "100");
			_UFTabControl.SelectedIndexChanged += new EventHandler(TabControl2_SelectedIndexChanged);
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage2(_UFTabControl));
            this.TabControl2 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "1","0865b139-18bc-4a1a-978a-78d7c247e1d0","0865b139-18bc-4a1a-978a-78d7c247e1d0");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 16, 15, 0, 10, 8, 10, 8, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.LaserLabSoloScrapView, "LaserLabSoloScrapView", "", null, 1, "LB单个报废视图");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 10,new GridColumnDef[]{new GridColumnDef(1,bool.Parse("False")),new GridColumnDef(160,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(15,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(109,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(7,bool.Parse("False")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(30,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(6,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 805, "Horizontal", "True", 805, 25, 2, 3, 14, 1, "100","152207fd-5be3-4292-b431-2f799a017ba5","152207fd-5be3-4292-b431-2f799a017ba5");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.lblBN474 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBN474", "", "True", "True", "Right", 100, 25, 2, 5, 1, 1, "100","4c975f61-f4ee-4caf-9876-9b4359d7b26b","0cbd184c-0c2a-4dc6-ae69-3e6e9e0e6e6c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBN474, "1");		


				this.BN474 = UIControlBuilder.BuilderTextBox(_UFTabPage, "BN474", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 4, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBN474","","50","4c975f61-f4ee-4caf-9876-9b4359d7b26b","7c17998d-3311-4e76-9ede-10d6f9ce61ce");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BN474, "False", "BN", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldBN, "LaserLabSoloScrapView");


		
			UIControlBuilder.BuilderUFControl(this.BN474, "2");		
		 

				this.lblType63 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblType63", "", "True", "True", "Right", 100, 25, 9, 5, 1, 1, "100","1376e7c4-a051-4ef9-94ac-d83c5c695bff","29aa0577-9acb-4284-8613-381e75f008c2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblType63, "3");		


				this.Type63 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Type63", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 11, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblType63","","50","1376e7c4-a051-4ef9-94ac-d83c5c695bff","3596c58d-34aa-48e6-8b5f-71804e40c381");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Type63, "False", "Type", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldType, "LaserLabSoloScrapView");


		
			UIControlBuilder.BuilderUFControl(this.Type63, "4");		
		 

				this.lblDate69 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDate69", "", "True", "True", "Right", 100, 25, 9, 7, 1, 1, "100","f5c895a7-a541-45fa-903c-d19e4cd80716","a5fce98b-ae3f-4142-a718-9a817feaaadc");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDate69, "5");		


				this.Date69 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Date69", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 11, 7, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblDate69","","50","f5c895a7-a541-45fa-903c-d19e4cd80716","7a0f5e99-9037-481f-9f94-7d3271a65c2b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Date69, "False", "Date", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldDate, "LaserLabSoloScrapView");


		
			UIControlBuilder.BuilderUFControl(this.Date69, "6");		
		 

				this.lblTime87 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblTime87", "", "True", "True", "Right", 100, 25, 2, 7, 1, 1, "100","6e0ea9cb-85bd-490b-8fb6-b5bb626ca104","738624df-98b0-4abf-a803-1ebd3197f968");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTime87, "7");		


				this.Time87 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Time87", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 4, 7, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblTime87","","50","6e0ea9cb-85bd-490b-8fb6-b5bb626ca104","5188b0e4-e24d-4917-8acd-f337b8805f2e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Time87, "False", "Time", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldTime, "LaserLabSoloScrapView");


		
			UIControlBuilder.BuilderUFControl(this.Time87, "8");		
		 

				this.lblCP84 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCP84", "", "True", "True", "Right", 100, 25, 2, 9, 1, 1, "100","fe731b05-c454-4322-b510-1193e7616022","ddff217d-86b9-48e8-a8e9-88268bc02184");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCP84, "9");		


				this.CP84 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CP84", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 4, 9, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCP84","","50","fe731b05-c454-4322-b510-1193e7616022","e8df4898-3110-484f-ac55-19d6d2ff1801");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CP84, "False", "CP", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldCP, "LaserLabSoloScrapView");


		
			UIControlBuilder.BuilderUFControl(this.CP84, "10");		
		 

				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnOk", true, true, 100, 30, 11, 12, 1, 1, "100","", this.Model.ElementID,"",false,"9436cef9-9889-4653-802e-2737cd1ec2b1","","9436cef9-9889-4653-802e-2737cd1ec2b1");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "15");		


				this.BtnClear = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnClear", true, true, 100, 30, 13, 12, 1, 1, "100","", this.Model.ElementID,"",false,"7bff7bca-c6bd-4961-b9b9-c1f1a6ba04b7","","7bff7bca-c6bd-4961-b9b9-c1f1a6ba04b7");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClear, "16");		


				this.lblID48 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblID48", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","167287ec-7050-47ef-8b3f-71a7919ae453","7342f9ae-6993-461d-a037-321c234a4109");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID48, "17");		


				this.ID48 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ID48", "False", "False", "True", "Left", 7, 60, 0, 15, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID48","","167287ec-7050-47ef-8b3f-71a7919ae453","a7ceef0e-c526-4862-9b87-b37fb3233ce5",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID48, "False", "ID", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldID, "LaserLabSoloScrapView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID48, "18");		
		 

				this.lblSysVersion78 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSysVersion78", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","4a020647-89a8-42bf-96cc-a53843d56be4","17fade13-cbf5-4dfd-935c-88d32ca96dc7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion78, "19");		


				this.SysVersion78 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "SysVersion78", "False", "False", "True", "Left", 7, 60, 0, 15, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion78","","4a020647-89a8-42bf-96cc-a53843d56be4","ca47d7b7-5c4e-4dfa-83a7-b19c5c6bfceb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion78, "False", "SysVersion", this.Model.LaserLabSoloScrapView, this.Model.LaserLabSoloScrapView.FieldSysVersion, "LaserLabSoloScrapView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion78, "20");		
		 

	
			_BuilderControl_Card1(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "0");		


				this.BtnReturnMaster = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnReturnMaster", true, true, 100, 30, 9, 12, 1, 1, "100","", this.Model.ElementID,"",false,"d67ba514-d28d-40dc-a531-e5c824322959","","d67ba514-d28d-40dc-a531-e5c824322959");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnReturnMaster, "21");		



																			

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","8a667612-8db9-4bf9-9f9c-406fd37d6f70");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 966, 50, 0, 1, 16, 2, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 10, 3, 0, 10, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(200,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(95,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),new GridRowDef(1,bool.Parse("True")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label1 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label1", "", "True", "True", "Right", 100, 25, 2, 1, 1, 1, "100","c0aa36d6-8723-4f45-9411-f4872f2d15b3","c0aa36d6-8723-4f45-9411-f4872f2d15b3");


								

		
			UIControlBuilder.BuilderUFControl(this.Label1, "21");		


				this.TextBox1 = UIControlBuilder.BuilderTextBox(_UFCard, "TextBox1", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 4, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label1","","","","30677512-2a0d-468c-9974-da03a69b4fb8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox1, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox1, "1");		
		 

				this.Label2 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label2", "", "True", "True", "Right", 100, 25, 6, 1, 1, 1, "100","ba2c11d8-4af0-4dfb-ba76-b823810b3026","ba2c11d8-4af0-4dfb-ba76-b823810b3026");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2, "2");		


				this.DatePicker2 = UIControlBuilder.BuilderDatePicker(_UFCard, "DatePicker2", true, true, true, "DateTime","Left", 0, 60, 0, 100, 25, 8, 1, 1, 1, "100",true,false,"Label2","","acdaa90b-d2f7-4cf2-b6f9-b89546b8dcd2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DatePicker2, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.DatePicker2, "3");		
		 


				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	        private IUFTabPage _BuilderControl_TabPage2(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage2",true, true, "3","d005d408-2791-4664-a0da-ed5cea5f9e22","d005d408-2791-4664-a0da-ed5cea5f9e22");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 3, 3, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(1,bool.Parse("True")),new GridColumnDef(960,bool.Parse("False")),new GridColumnDef(1,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(436,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid0(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "0");		



	

            this.TabPage2 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, false,false,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 960, 436, 1, 1, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.LaserLabScrapInfoView, "LaserLabScrapInfoView", "", null, 20, "镭射标报废信息页");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID49","NumberColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","8548cd32-26d1-4359-8efa-ae950d215a10","8548cd32-26d1-4359-8efa-ae950d215a10","239c9114-abd7-43c4-b4d3-72552910ea78");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion79","NumberColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","a7f6bf95-d5c2-45f2-aafe-12c7931f69a5","a7f6bf95-d5c2-45f2-aafe-12c7931f69a5","5509813f-c4ea-47e5-b3f6-da07c64b24f5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LB347","TextBoxColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["LB"]/*LB*/,"LB", false, true, true, false, false, true, 0, 100, "50",true, false,"","dadd17c4-d517-4716-b806-f7aef366b8d1","dadd17c4-d517-4716-b806-f7aef366b8d1","e50e191f-3e63-4d16-a1f7-45d878b3624b");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BN475","TextBoxColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["BN"]/*BN*/,"BN", false, true, true, false, false, true, 0, 100, "50",true, false,"","b1de1ad6-2603-40e0-8834-4ff18c78cfd0","b1de1ad6-2603-40e0-8834-4ff18c78cfd0","7f98d4e5-bbf9-488a-b410-6a1d629475f8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CP85","TextBoxColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["CP"]/*CP*/,"CP", false, true, true, false, false, true, 0, 100, "50",true, false,"","112836bf-23d7-4e2e-9098-6f687fcdfcae","112836bf-23d7-4e2e-9098-6f687fcdfcae","9988b259-e59b-4cb8-9757-3cc8450d8e4d");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Type64","TextBoxColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["Type"]/*Type*/,"Type", false, true, true, false, false, true, 0, 100, "50",true, false,"","b88c43d8-e119-4aec-9983-cdaced0d29af","b88c43d8-e119-4aec-9983-cdaced0d29af","d292d998-079e-4708-8091-ae09ab180c31");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ScrapDT0","TextBoxColumnModel", "", 0,this.Model.LaserLabScrapInfoView.Fields["ScrapDT"]/*ScrapDT*/,"ScrapDT", false, true, true, false, false, true, 0, 180, "50",true, false,"","8d9c8226-47c6-4031-b36a-a7555fc76c8b","8d9c8226-47c6-4031-b36a-a7555fc76c8b","ba32def9-00e0-4ccc-8bbe-874a6b5615ad");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
