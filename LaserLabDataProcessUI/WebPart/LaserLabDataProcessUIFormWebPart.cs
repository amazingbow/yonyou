


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
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI","LaserLabDataProcessUIModel.LaserLabDataProcessUIFormWebPart", "UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI.WebPart", "437debdb-5117-4865-a8ed-d3a2403914e7","WebPart", "True", 848, 480)] 
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
        IUFLabel lblLaserLabCode1081;
        IUFFldTextBox LaserLabCode1081;
        IUFLabel lblBatchNo2007;
        IUFFldTextBox BatchNo2007;
        IUFLabel lblType1667;
        IUFFldTextBox Type1667;
        IUFLabel lblFlowNumStart1064;
        IUFFldTextBox FlowNumStart1064;
        IUFLabel lblFlowNumEnd1073;
        IUFFldTextBox FlowNumEnd1073;
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabDataProcessUIForm",true,848,480);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 8, 12, 0, 12, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  this.Model.LaserLabDataProcessView, "LaserLabDataProcessView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 12,new GridColumnDef[]{new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(100,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(310,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(26,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





				this.Line0 = UIControlBuilder.BuilderUFLine(_panel, "Line0", 490, "Horizontal", "True", 490, 26, 0, 0, 7, 1, "100","cbd23799-b204-4555-99db-e3d62f6182ea","cbd23799-b204-4555-99db-e3d62f6182ea");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.Line1 = UIControlBuilder.BuilderUFLine(_panel, "Line1", 490, "Horizontal", "True", 490, 20, 0, 5, 7, 1, "100","7997e7bc-1933-4d2c-b7b8-b169b891853a","7997e7bc-1933-4d2c-b7b8-b169b891853a");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "1");		


	
			_BuilderControl_RadioBoxList1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.RadioBoxList1, "2");		


				this.BtnCheckFile = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCheckFile", true, true, 120, 25, 3, 2, 1, 1, "100","", this.Model.ElementID,"BtnCheckFileAction",false,"9a13a730-8749-4298-a337-269c55b2cfbe","","9a13a730-8749-4298-a337-269c55b2cfbe");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCheckFile, "10");		


				this.BtnChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnChange", true, true, 120, 25, 3, 3, 1, 1, "100","", this.Model.ElementID,"BtnChangeAction",false,"23c0325b-562b-4e33-b050-cbc157e99a8f","","23c0325b-562b-4e33-b050-cbc157e99a8f");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnChange, "11");		


				this.BtnJYForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnJYForceChange", true, true, 120, 25, 5, 6, 1, 1, "100","", this.Model.ElementID,"BtnJYForceChangeAction",false,"96410ed7-43d5-4048-a664-8411670a0e60","","96410ed7-43d5-4048-a664-8411670a0e60");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnJYForceChange, "22");		


				this.BtnBZForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnBZForceChange", true, true, 120, 25, 5, 8, 1, 1, "100","", this.Model.ElementID,"BtnBZForceChangeAction",false,"f5a8d047-c5df-466c-8bd0-cb365765fcdd","","f5a8d047-c5df-466c-8bd0-cb365765fcdd");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnBZForceChange, "23");		


				this.BtnCHForceChange = UIControlBuilder.BuilderUFButton(_panel, true, "BtnCHForceChange", true, true, 120, 25, 5, 10, 1, 1, "100","", this.Model.ElementID,"BtnCHForceChangeAction",false,"6fdb5be4-87ff-4e7b-9c79-0f61f09e328a","","6fdb5be4-87ff-4e7b-9c79-0f61f09e328a");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCHForceChange, "24");		


				this.lblLaserLabCode1081 = UIControlBuilder.BuilderUFLabel(_panel, "lblLaserLabCode1081", "", "True", "True", "Left", 100, 25, 1, 6, 1, 1, "100","7ee1fcbc-2665-44d6-9297-321ce22c7992","0e3a4a38-b081-4e32-8588-5a4c9a98fc17");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLaserLabCode1081, "25");		


				this.LaserLabCode1081 = UIControlBuilder.BuilderTextBox(_panel, "LaserLabCode1081", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 3, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLaserLabCode1081","","50","7ee1fcbc-2665-44d6-9297-321ce22c7992","db3c1e91-16f5-413b-a631-95dcfd037eaa");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LaserLabCode1081, "False", "LaserLabCode", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldLaserLabCode, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.LaserLabCode1081, "26");		
		 

				this.lblBatchNo2007 = UIControlBuilder.BuilderUFLabel(_panel, "lblBatchNo2007", "", "True", "True", "Left", 100, 25, 1, 7, 1, 1, "100","e701dbd4-2f99-4f61-9551-3196e52a81c7","a9a31b33-a1b4-43d6-8926-e79a3f9cd837");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBatchNo2007, "27");		


				this.BatchNo2007 = UIControlBuilder.BuilderTextBox(_panel, "BatchNo2007", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 3, 7, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBatchNo2007","","50","e701dbd4-2f99-4f61-9551-3196e52a81c7","cad8cbff-559d-48a7-971e-5bfab226f7a6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BatchNo2007, "False", "BatchNo", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldBatchNo, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.BatchNo2007, "28");		
		 

				this.lblType1667 = UIControlBuilder.BuilderUFLabel(_panel, "lblType1667", "", "True", "True", "Left", 100, 25, 1, 8, 1, 1, "100","6120c860-1760-4d74-867b-2541d6ce54ac","2ddd4ed5-58c7-439d-8c04-88a61380a997");


								

		
			UIControlBuilder.BuilderUFControl(this.lblType1667, "29");		


				this.Type1667 = UIControlBuilder.BuilderTextBox(_panel, "Type1667", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 3, 8, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblType1667","","50","6120c860-1760-4d74-867b-2541d6ce54ac","5c0853c6-85b8-47f5-aa44-5a95ab76de2a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Type1667, "False", "Type", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldType, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.Type1667, "30");		
		 

				this.lblFlowNumStart1064 = UIControlBuilder.BuilderUFLabel(_panel, "lblFlowNumStart1064", "", "True", "True", "Left", 100, 25, 1, 9, 1, 1, "100","e199c6c0-a2a1-4f03-916c-b707772fc7c8","a35b9f7b-cbb3-4d47-88c6-b1048cabccf7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumStart1064, "31");		


				this.FlowNumStart1064 = UIControlBuilder.BuilderTextBox(_panel, "FlowNumStart1064", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 3, 9, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblFlowNumStart1064","","50","e199c6c0-a2a1-4f03-916c-b707772fc7c8","db368f97-f65f-4afa-a753-42469856e692");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumStart1064, "False", "FlowNumStart", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumStart, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.FlowNumStart1064, "32");		
		 

				this.lblFlowNumEnd1073 = UIControlBuilder.BuilderUFLabel(_panel, "lblFlowNumEnd1073", "", "True", "True", "Left", 100, 25, 1, 10, 1, 1, "100","7bebb355-dd80-4f99-8a5a-97dd061e38d3","4ecee330-0406-4ca7-b657-b4fa90c3d675");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFlowNumEnd1073, "33");		


				this.FlowNumEnd1073 = UIControlBuilder.BuilderTextBox(_panel, "FlowNumEnd1073", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 25, 3, 10, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblFlowNumEnd1073","","50","7bebb355-dd80-4f99-8a5a-97dd061e38d3","bf67e919-58ce-4ee4-beb2-d10a2a965d0d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlowNumEnd1073, "False", "FlowNumEnd", this.Model.LaserLabDataProcessView, this.Model.LaserLabDataProcessView.FieldFlowNumEnd, "LaserLabDataProcessView");


		
			UIControlBuilder.BuilderUFControl(this.FlowNumEnd1073, "34");		
		 


																		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	        private void _BuilderControl_RadioBoxList1(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"RadioBoxList1",true,true,"2",0,0,UFSoft.UBF.UI.ControlModel.LineOrientation.Vertical);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 100, 136, 1, 1, 1, 4, "100");
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
