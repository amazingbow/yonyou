


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
 * Form ID:437debdb-5117-4865-a8ed-d3a2403914e7 
 * Form Name:LaserLabDataProcessUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace LaserLabDataProcessUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI","LaserLabDataProcessUIModel.LaserLabDataProcessUIFormWebPart", "UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI.WebPart", "437debdb-5117-4865-a8ed-d3a2403914e7","WebPart", "True", 760, 560)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI', 'LaserLabDataProcessUIModel.LaserLabDataProcessUIFormWebPart', 'UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI.WebPart', '437debdb-5117-4865-a8ed-d3a2403914e7')
	///<siteMapNode url="~/erp/simple.aspx?lnk=437debdb-5117-4865-a8ed-d3a2403914e7" title="LaserLabDataProcessUIForm"/>
    public partial class LaserLabDataProcessUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabDataProcessUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LaserLabDataProcessUIModelAction Action
		{
			get { return (LaserLabDataProcessUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		LaserLabDataProcessUIModelModel _uimodel=null;
		public new LaserLabDataProcessUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LaserLabDataProcessUIModelModel();
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
                this.Model = value as LaserLabDataProcessUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFLine Line0;
        IUFLine Line1;
        IUFRadioBoxList RadioBoxList1;
        IUFButton BtnCheckFile;
        IUFButton BtnChange;
        IUFButton BtnJYForceChange;
        IUFButton BtnBZForceChange;
        IUFButton BtnCHForceChange;
        IUFGroupBox GroupBox0;
        IUFGroupBox GroupBox1;
        IUFGroupBox GroupBox2;
        IUFGroupBox GroupBox3;
        IUFGroupBox GroupBox4;
        IUFTabControl TabControl0;
        IUFTabPage TabPage0;
        IUFLabel lblLaserLabCode1531;
        IUFFldTextBox LaserLabCode1531;
        IUFTabPage TabPage1;
        IUFLabel lblBatchNo2223;
        IUFFldTextBox BatchNo2223;
        IUFLabel lblType1904;
        IUFFldTextBox Type1904;
        IUFLabel lblFlowNumStart1487;
        IUFFldNumberControl FlowNumStart1487;
        IUFLabel lblFlowNumEnd1705;
        IUFFldNumberControl FlowNumEnd1705;
        IUFLabel lblShipBatchNo1764;
        IUFFldTextBox ShipBatchNo1764;
        IUFLabel lblShipTime384;
        IUFFldDatePicker ShipTime384;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LaserLabDataProcessUIFormWebPart()
        {
            FormID = "437debdb-5117-4865-a8ed-d3a2403914e7";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnCheckFile.Click += new EventHandler(BtnCheckFile_Click);		
						
				//Button控件事件
			this.BtnChange.Click += new EventHandler(BtnChange_Click);		
						
				//Button控件事件
			this.BtnJYForceChange.Click += new EventHandler(BtnJYForceChange_Click);		
						
				//Button控件事件
			this.BtnBZForceChange.Click += new EventHandler(BtnBZForceChange_Click);		
						
				//Button控件事件
			this.BtnCHForceChange.Click += new EventHandler(BtnCHForceChange_Click);		
						

			
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
					this.Model = new LaserLabDataProcessUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LaserLabDataProcessUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new LaserLabDataProcessUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabDataProcessUIForm",true,760,560);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 10, 14, 0, 14, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  this.Model.LaserLabDataProcessView, "LaserLabDataProcessView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 14,new GridColumnDef[]{new GridColumnDef(14,bool.Parse("False")),new GridColumnDef(100,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(100,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(100,bool.Parse("False")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(171,bool.Parse("True")),new GridColumnDef(85,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(26,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(26,bool.Parse("False")),new GridRowDef(26,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





				this.Line0 = UIControlBuilder.BuilderUFLine(_panel, "Line0", 515, "Horizontal", "True", 515, 26, 0, 0, 8, 1, "100","cbd23799-b204-4555-99db-e3d62f6182ea","cbd23799-b204-4555-99db-e3d62f6182ea");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.Line1 = UIControlBuilder.BuilderUFLine(_panel, "Line1", 515, "Horizontal", "True", 515, 25, 0, 5, 8, 1, "100","7997e7bc-1933-4d2c-b7b8-b169b891853a","7997e7bc-1933-4d2c-b7b8-b169b891853a");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "1");		


	
			_BuilderControl_RadioBoxList1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.RadioBoxList1, "2");		


				this.BtnCheckFile = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCheckFile", true, true, 100, 25, 3, 2, 1, 1, "100","", this.Model.ElementID,"BtnCheckFileAction",false,"9a13a730-8749-4298-a337-269c55b2cfbe","","9a13a730-8749-4298-a337-269c55b2cfbe");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCheckFile, "10");		


				this.BtnChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnChange", true, true, 100, 25, 3, 3, 1, 1, "100","", this.Model.ElementID,"BtnChangeAction",false,"23c0325b-562b-4e33-b050-cbc157e99a8f","","23c0325b-562b-4e33-b050-cbc157e99a8f");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnChange, "11");		


				this.BtnJYForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnJYForceChange", true, true, 100, 25, 1, 11, 1, 1, "100","", this.Model.ElementID,"BtnJYForceChangeAction",false,"96410ed7-43d5-4048-a664-8411670a0e60","","96410ed7-43d5-4048-a664-8411670a0e60");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnJYForceChange, "22");		


				this.BtnBZForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnBZForceChange", true, true, 100, 25, 3, 11, 1, 1, "100","", this.Model.ElementID,"BtnBZForceChangeAction",false,"f5a8d047-c5df-466c-8bd0-cb365765fcdd","","f5a8d047-c5df-466c-8bd0-cb365765fcdd");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnBZForceChange, "23");		


				this.BtnCHForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCHForceChange", true, true, 100, 25, 5, 11, 1, 1, "100","", this.Model.ElementID,"BtnCHForceChangeAction",false,"6fdb5be4-87ff-4e7b-9c79-0f61f09e328a","","6fdb5be4-87ff-4e7b-9c79-0f61f09e328a");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCHForceChange, "24");		


	
			_BuilderControl_GroupBox0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.GroupBox0, "0");		


	
			_BuilderControl_GroupBox1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.GroupBox1, "0");		


	
			_BuilderControl_GroupBox2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.GroupBox2, "0");		


	
			_BuilderControl_GroupBox3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.GroupBox3, "0");		


	
			_BuilderControl_GroupBox4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.GroupBox4, "0");		


	
			_BuilderControl_TabControl0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.TabControl0, "35");		


				this.lblShipBatchNo1764 = UIControlBuilder.BuilderUFLabel(_panel, "lblShipBatchNo1764", "", "True", "True", "Left", 100, 25, 1, 9, 1, 1, "100","a527a5c4-57ac-4dad-8a8b-4b703b59802e","b392ee40-724b-4c91-af42-4aad111b9bb6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShipBatchNo1764, "36");		


				this.ShipBatchNo1764 = UIControlBuilder.BuilderTextBox(_panel, "ShipBatchNo1764", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 3, 9, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblShipBatchNo1764","","50","a527a5c4-57ac-4dad-8a8b-4b703b59802e","2a03c431-8fc4-4562-bf49-d4ab6ebd1083");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShipBatchNo1764, "False", "ShipBatchNo", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldShipBatchNo, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.ShipBatchNo1764, "37");		
		 

				this.lblShipTime384 = UIControlBuilder.BuilderUFLabel(_panel, "lblShipTime384", "", "True", "True", "Left", 100, 25, 5, 9, 1, 1, "100","8f1975c0-d881-408c-bc05-339eca6e9df4","d8cd5cef-a322-4e2a-a9d7-107e430b8af8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShipTime384, "38");		


				this.ShipTime384 = UIControlBuilder.BuilderDatePicker(_panel, "ShipTime384", true, true, true, "DateTime","Left", 5, 60, 0, 171, 25, 7, 9, 1, 1, "100",true,false,"lblShipTime384","8f1975c0-d881-408c-bc05-339eca6e9df4","b6b91849-3fd3-4c77-baec-d017a589e6c4");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShipTime384, "False", "ShipTime", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldShipTime, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.ShipTime384, "39");		
		 


																		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	        private void _BuilderControl_RadioBoxList1(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"RadioBoxList1",true,true,"2",0,0,UFSoft.UBF.UI.ControlModel.LineOrientation.Vertical);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 100, 142, 1, 1, 1, 4, "100");
            this.RadioBoxList1 = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"9d75e1a6-6406-4d6f-9997-34f7996715b1","9d75e1a6-6406-4d6f-9997-34f7996715b1");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,false,"557a57da-c3d3-4ad9-a65c-995c54d544f0","557a57da-c3d3-4ad9-a65c-995c54d544f0");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"cd3b3e82-d241-4839-874f-30539647a4a3","cd3b3e82-d241-4839-874f-30539647a4a3");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"4", true,false,"5be6b57b-a297-42bf-a8cd-550a7f9f56ac","5be6b57b-a297-42bf-a8cd-550a7f9f56ac");
            _UFListControl.Items.Add(listItem);
        }
	        private IUFGroupBox _BuilderControl_GroupBox0(IUFContainer container)
        {
            IUFGroupBox _UFGroupBox =UIControlBuilder.BuildGroupBox(container,"GroupBox0",true, true, "0",TextAlign.Left,"","20a95ee0-c648-4286-83ca-47bac990cf92");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGroupBox, 14, 26, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFGroupBox, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFGroupBox,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFGroupBox, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach GroupBox下的所有控件，增加到此容器








            this.GroupBox0 = _UFGroupBox;
            return _UFGroupBox;
        }

	        private IUFGroupBox _BuilderControl_GroupBox1(IUFContainer container)
        {
            IUFGroupBox _UFGroupBox =UIControlBuilder.BuildGroupBox(container,"GroupBox1",true, true, "0",TextAlign.Left,"","9b534dfa-c4e3-43ad-8e85-030a6d88355a");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGroupBox, 14, 26, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFGroupBox, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFGroupBox,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFGroupBox, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach GroupBox下的所有控件，增加到此容器








            this.GroupBox1 = _UFGroupBox;
            return _UFGroupBox;
        }

	        private IUFGroupBox _BuilderControl_GroupBox2(IUFContainer container)
        {
            IUFGroupBox _UFGroupBox =UIControlBuilder.BuildGroupBox(container,"GroupBox2",true, true, "0",TextAlign.Left,"","cc9b4712-1e40-4126-897c-999943ea9911");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGroupBox, 14, 26, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFGroupBox, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFGroupBox,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFGroupBox, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach GroupBox下的所有控件，增加到此容器








            this.GroupBox2 = _UFGroupBox;
            return _UFGroupBox;
        }

	        private IUFGroupBox _BuilderControl_GroupBox3(IUFContainer container)
        {
            IUFGroupBox _UFGroupBox =UIControlBuilder.BuildGroupBox(container,"GroupBox3",true, true, "0",TextAlign.Left,"","291c318c-c615-44c1-b095-0f14b2a54053");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGroupBox, 14, 26, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFGroupBox, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFGroupBox,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFGroupBox, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach GroupBox下的所有控件，增加到此容器








            this.GroupBox3 = _UFGroupBox;
            return _UFGroupBox;
        }

	        private IUFGroupBox _BuilderControl_GroupBox4(IUFContainer container)
        {
            IUFGroupBox _UFGroupBox =UIControlBuilder.BuildGroupBox(container,"GroupBox4",true, true, "0",TextAlign.Left,"","05ce8b01-d08f-4e1c-b420-267f72ba07a1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGroupBox, 14, 26, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFGroupBox, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFGroupBox,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFGroupBox, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach GroupBox下的所有控件，增加到此容器








            this.GroupBox4 = _UFGroupBox;
            return _UFGroupBox;
        }

	         private void _BuilderControl_TabControl0(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl0",true, true, "35",EventResponseType.Client,515, 105, 0, 6, 8, 3, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage1(_UFTabControl));
            this.TabControl0 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "0","bea4aa14-2ecb-40c8-8e6a-aa5ee18eed40","bea4aa14-2ecb-40c8-8e6a-aa5ee18eed40");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 7, 1, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.LaserLabDataProcessView, "LaserLabDataProcessView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(25,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblLaserLabCode1531 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLaserLabCode1531", "", "True", "True", "Left", 60, 25, 0, 0, 1, 1, "100","7ee1fcbc-2665-44d6-9297-321ce22c7992","80477b6f-a8b4-4c53-91cf-5e626819c9fe");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLaserLabCode1531, "0");		


				this.LaserLabCode1531 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LaserLabCode1531", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLaserLabCode1531","","50","7ee1fcbc-2665-44d6-9297-321ce22c7992","427b254e-8dfe-4f13-9cbe-43d80967105a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LaserLabCode1531, "False", "LaserLabCode", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldLaserLabCode, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.LaserLabCode1531, "1");		
		 


		

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

	        private IUFTabPage _BuilderControl_TabPage1(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage1",true, true, "0","e39bbe12-dbb4-4a45-8e68-3446dadcb163","e39bbe12-dbb4-4a45-8e68-3446dadcb163");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 8, 2, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.LaserLabDataProcessView, "LaserLabDataProcessView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblBatchNo2223 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBatchNo2223", "", "True", "True", "Left", 60, 25, 0, 0, 1, 1, "100","e701dbd4-2f99-4f61-9551-3196e52a81c7","e26823f7-2a8e-4206-9c3b-02dec3e2b657");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBatchNo2223, "0");		


				this.BatchNo2223 = UIControlBuilder.BuilderTextBox(_UFTabPage, "BatchNo2223", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBatchNo2223","","50","e701dbd4-2f99-4f61-9551-3196e52a81c7","2ce095b6-218d-4193-9da3-97e6248cdc06");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BatchNo2223, "False", "BatchNo", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldBatchNo, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.BatchNo2223, "1");		
		 

				this.lblType1904 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblType1904", "", "True", "True", "Left", 60, 25, 4, 0, 1, 1, "100","6120c860-1760-4d74-867b-2541d6ce54ac","cfd66b49-8009-4922-839d-bf6b6ac267bc");


								

		
			UIControlBuilder.BuilderUFControl(this.lblType1904, "2");		


				this.Type1904 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Type1904", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 6, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblType1904","","50","6120c860-1760-4d74-867b-2541d6ce54ac","0787967f-09be-457e-8b17-451910d250fa");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Type1904, "False", "Type", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldType, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.Type1904, "3");		
		 

				this.lblFlowNumStart1487 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblFlowNumStart1487", "", "True", "True", "Left", 60, 25, 0, 1, 1, 1, "100","e199c6c0-a2a1-4f03-916c-b707772fc7c8","09fce17e-0338-446d-8295-184b00bdfb8b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumStart1487, "4");		


				this.FlowNumStart1487 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "FlowNumStart1487", "True", "True", "True", "Left", 2, 60, 0, 120, 25, 2, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblFlowNumStart1487","10.0","e199c6c0-a2a1-4f03-916c-b707772fc7c8","5e1ae247-307f-4c3f-afdc-35de9909858c",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumStart1487, "False", "FlowNumStart", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumStart, "LaserLabDataProcessView");
	
		
			UIControlBuilder.BuilderUFControl(this.FlowNumStart1487, "5");		
		 

				this.lblFlowNumEnd1705 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblFlowNumEnd1705", "", "True", "True", "Left", 60, 25, 4, 1, 1, 1, "100","7bebb355-dd80-4f99-8a5a-97dd061e38d3","7fcb51db-e73a-4cfe-879a-92094ad4b18e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumEnd1705, "6");		


				this.FlowNumEnd1705 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "FlowNumEnd1705", "True", "True", "True", "Left", 2, 60, 0, 120, 25, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblFlowNumEnd1705","10.0","7bebb355-dd80-4f99-8a5a-97dd061e38d3","2e57d4fc-00d8-42c0-840c-6730a9ad1415",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumEnd1705, "False", "FlowNumEnd", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumEnd, "LaserLabDataProcessView");
	
		
			UIControlBuilder.BuilderUFControl(this.FlowNumEnd1705, "7");		
		 


								

            this.TabPage1 = _UFTabPage;
            return _UFTabPage;
        }





		#endregion
		

	}
}
