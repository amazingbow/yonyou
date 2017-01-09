


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
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI","LaserLabDataProcessUIModel.LaserLabDataProcessUIFormWebPart", "UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI.WebPart", "437debdb-5117-4865-a8ed-d3a2403914e7","WebPart", "True", 1144, 624)] 
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
        IUFLabel lblLaserLabCode989;
        IUFFldTextBox LaserLabCode989;
        IUFLabel lblBatchNo1843;
        IUFFldTextBox BatchNo1843;
        IUFLabel lblType1196;
        IUFFldTextBox Type1196;
        IUFLabel lblFlowNumStart864;
        IUFFldTextBox FlowNumStart864;
        IUFLabel lblFlowNumEnd870;
        IUFFldTextBox FlowNumEnd870;
        IUFButton BtnJYForceChange;
        IUFButton BtnBZForceChange;
        IUFButton BtnCHForceChange;
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
            IsAutoSize = bool.Parse("True");
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabDataProcessUIForm",true,1144,624);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 16, 20, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  this.Model.LaserLabDataProcessView, "LaserLabDataProcessView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(98,bool.Parse("False")),new GridColumnDef(22,bool.Parse("False")),new GridColumnDef(124,bool.Parse("False")),new GridColumnDef(36,bool.Parse("False")),new GridColumnDef(94,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(26,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





				this.Line0 = UIControlBuilder.BuilderUFLine(_panel, "Line0", 484, "Horizontal", "True", 484, 26, 0, 0, 7, 1, "100","cbd23799-b204-4555-99db-e3d62f6182ea","cbd23799-b204-4555-99db-e3d62f6182ea");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.Line1 = UIControlBuilder.BuilderUFLine(_panel, "Line1", 610, "Horizontal", "True", 610, 26, 8, 0, 8, 1, "100","7997e7bc-1933-4d2c-b7b8-b169b891853a","7997e7bc-1933-4d2c-b7b8-b169b891853a");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "1");		


	
			_BuilderControl_RadioBoxList1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.RadioBoxList1, "2");		


				this.BtnCheckFile = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCheckFile", true, true, 124, 20, 3, 3, 1, 1, "100","", this.Model.ElementID,"BtnCheckFileAction",false,"9a13a730-8749-4298-a337-269c55b2cfbe","","9a13a730-8749-4298-a337-269c55b2cfbe");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCheckFile, "10");		


				this.BtnChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnChange", true, true, 124, 20, 3, 5, 1, 1, "100","", this.Model.ElementID,"BtnChangeAction",false,"23c0325b-562b-4e33-b050-cbc157e99a8f","","23c0325b-562b-4e33-b050-cbc157e99a8f");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnChange, "11");		


				this.lblLaserLabCode989 = UIControlBuilder.BuilderUFLabel(_panel, "lblLaserLabCode989", "", "True", "True", "Right", 120, 20, 8, 2, 1, 1, "100","7ee1fcbc-2665-44d6-9297-321ce22c7992","9047a3bf-44db-410c-9bc2-b676fe1f73ae");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLaserLabCode989, "12");		


				this.LaserLabCode989 = UIControlBuilder.BuilderTextBox(_panel, "LaserLabCode989", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLaserLabCode989","","50","7ee1fcbc-2665-44d6-9297-321ce22c7992","41797c8d-ccad-4ae9-8759-416b38c2a4f7");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LaserLabCode989, "False", "LaserLabCode", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldLaserLabCode, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.LaserLabCode989, "13");		
		 

				this.lblBatchNo1843 = UIControlBuilder.BuilderUFLabel(_panel, "lblBatchNo1843", "", "True", "True", "Right", 120, 20, 8, 4, 1, 1, "100","e701dbd4-2f99-4f61-9551-3196e52a81c7","1f33751f-1be3-4ac6-b896-64605a901f9e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBatchNo1843, "14");		


				this.BatchNo1843 = UIControlBuilder.BuilderTextBox(_panel, "BatchNo1843", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBatchNo1843","","50","e701dbd4-2f99-4f61-9551-3196e52a81c7","e0e9fafe-9194-4856-9a2b-d556bc227190");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BatchNo1843, "False", "BatchNo", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldBatchNo, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.BatchNo1843, "15");		
		 

				this.lblType1196 = UIControlBuilder.BuilderUFLabel(_panel, "lblType1196", "", "True", "True", "Right", 120, 20, 12, 4, 1, 1, "100","6120c860-1760-4d74-867b-2541d6ce54ac","44d2e491-e80e-4ad9-a417-b75126915e23");


								

		
			UIControlBuilder.BuilderUFControl(this.lblType1196, "16");		


				this.Type1196 = UIControlBuilder.BuilderTextBox(_panel, "Type1196", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 14, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblType1196","","50","6120c860-1760-4d74-867b-2541d6ce54ac","2fc62c3b-a42b-4d13-af6f-c30d9fd3be07");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Type1196, "False", "Type", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldType, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.Type1196, "17");		
		 

				this.lblFlowNumStart864 = UIControlBuilder.BuilderUFLabel(_panel, "lblFlowNumStart864", "", "True", "True", "Right", 120, 20, 8, 6, 1, 1, "100","e199c6c0-a2a1-4f03-916c-b707772fc7c8","9c6ec987-3805-4095-a757-09699a91ddee");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumStart864, "18");		


				this.FlowNumStart864 = UIControlBuilder.BuilderTextBox(_panel, "FlowNumStart864", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblFlowNumStart864","","50","e199c6c0-a2a1-4f03-916c-b707772fc7c8","ba2200f8-b0bb-469b-b55c-1f30545cd486");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumStart864, "False", "FlowNumStart", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumStart, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.FlowNumStart864, "19");		
		 

				this.lblFlowNumEnd870 = UIControlBuilder.BuilderUFLabel(_panel, "lblFlowNumEnd870", "", "True", "True", "Right", 120, 20, 12, 6, 1, 1, "100","7bebb355-dd80-4f99-8a5a-97dd061e38d3","01c29231-66d0-4174-bdb7-92dfbd512f93");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumEnd870, "20");		


				this.FlowNumEnd870 = UIControlBuilder.BuilderTextBox(_panel, "FlowNumEnd870", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 14, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblFlowNumEnd870","","50","7bebb355-dd80-4f99-8a5a-97dd061e38d3","a90a6ded-2662-4caf-bb03-2a98a2a259c1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumEnd870, "False", "FlowNumEnd", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumEnd, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.FlowNumEnd870, "21");		
		 

				this.BtnJYForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnJYForceChange", true, true, 120, 20, 8, 8, 1, 1, "100","", this.Model.ElementID,"BtnJYForceChangeAction",false,"96410ed7-43d5-4048-a664-8411670a0e60","","96410ed7-43d5-4048-a664-8411670a0e60");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnJYForceChange, "22");		


				this.BtnBZForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnBZForceChange", true, true, 120, 20, 10, 8, 1, 1, "100","", this.Model.ElementID,"BtnBZForceChangeAction",false,"f5a8d047-c5df-466c-8bd0-cb365765fcdd","","f5a8d047-c5df-466c-8bd0-cb365765fcdd");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnBZForceChange, "23");		


				this.BtnCHForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCHForceChange", true, true, 120, 20, 12, 8, 1, 1, "100","", this.Model.ElementID,"BtnCHForceChangeAction",false,"6fdb5be4-87ff-4e7b-9c79-0f61f09e328a","","6fdb5be4-87ff-4e7b-9c79-0f61f09e328a");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCHForceChange, "24");		



																		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	        private void _BuilderControl_RadioBoxList1(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"RadioBoxList1",true,true,"2",0,0,UFSoft.UBF.UI.ControlModel.LineOrientation.Vertical);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 178, 140, 0, 2, 2, 5, "100");
            this.RadioBoxList1 = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"", true,false,"d158154b-32c9-41f5-8926-cd8865d371f9","d158154b-32c9-41f5-8926-cd8865d371f9");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"", true,false,"a08c92f2-6e6b-4d56-b09d-6ef68fdb9220","a08c92f2-6e6b-4d56-b09d-6ef68fdb9220");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"", true,false,"d8894e3a-751f-4ce8-9b31-f35f9ec08f9d","d8894e3a-751f-4ce8-9b31-f35f9ec08f9d");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"", true,false,"2e0763a7-1edd-42d7-b401-7609cb475195","2e0763a7-1edd-42d7-b401-7609cb475195");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}
