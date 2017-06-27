


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
 * Form ID:d922b7d5-064c-4785-93d0-bb827fa87caf 
 * Form Name:XMJLBomDispExecUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.XMJLBomDispExecUI","UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel.XMJLBomDispExecUIFormWebPart", "UFIDA.U9.Cust.XMJL.XMJLBomDispExecUI.WebPart", "d922b7d5-064c-4785-93d0-bb827fa87caf","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.XMJLBomDispExecUI', 'UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel.XMJLBomDispExecUIFormWebPart', 'UFIDA.U9.Cust.XMJL.XMJLBomDispExecUI.WebPart', 'd922b7d5-064c-4785-93d0-bb827fa87caf')
	///<siteMapNode url="~/erp/simple.aspx?lnk=d922b7d5-064c-4785-93d0-bb827fa87caf" title="XMJLBomDispExecUIForm"/>
    public partial class XMJLBomDispExecUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBomDispExecUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new XMJLBomDispExecUIModelAction Action
		{
			get { return (XMJLBomDispExecUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		XMJLBomDispExecUIModelModel _uimodel=null;
		public new XMJLBomDispExecUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new XMJLBomDispExecUIModelModel();
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
                this.Model = value as XMJLBomDispExecUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card3;
        IUFLabel lblWareHouse35;
        IUFFldReference WareHouse35;
        IUFLabel lblManufactureNo25;
        IUFFldReference ManufactureNo25;
        IUFButton BtnDispExec;
        IUFLine Line0;
        IUFLabel lblWorkPlace34;
        IUFFldTextBox WorkPlace34;
        IUFLabel Label36;
        IUFButton Button1;
        IUFLabel lblStartDate109;
        IUFFldDatePicker StartDate109;
        IUFFldDatePicker EndTime43;
        IUFLabel lblItem49;
        IUFFldReference Item49;
        IUFLabel lblDistributeStartDate82;
        IUFFldDatePicker DistributeStartDate82;
        IUFFldDatePicker DistributeEndDate174;
        IUFLabel lblJustDisNegative175;
        IUFFldCheckBox JustDisNegative175;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public XMJLBomDispExecUIFormWebPart()
        {
            FormID = "d922b7d5-064c-4785-93d0-bb827fa87caf";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnDispExec.Click += new EventHandler(BtnDispExec_Click);		
						
				//Button控件事件
			this.Button1.Click += new EventHandler(Button1_Click);		
						

	
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
					this.Model = new XMJLBomDispExecUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (XMJLBomDispExecUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new XMJLBomDispExecUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"XMJLBomDispExecUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 17, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(475,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "0");		



	
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "0","bce0a089-6059-4e99-80d6-cb73a0e818bd","3d4bbea2-99a9-4787-8f7e-de5d4472f347");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 475, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 13, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  this.Model.BOMDispExecView, "BOMDispExecView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(81,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(219,bool.Parse("True")),new GridColumnDef(70,bool.Parse("True")),new GridColumnDef(14,bool.Parse("True")),new GridColumnDef(25,bool.Parse("True")),new GridColumnDef(11,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(23,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblWareHouse35 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblWareHouse35", "", "True", "True", "Right", 81, 20, 0, 1, 1, 1, "100","bce0a089-6059-4e99-80d6-cb73a0e818bd","5f7368d9-51a0-4e4b-b054-f91e08b5723f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblWareHouse35, "0");		


				this.WareHouse35 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"WareHouse35",false,true, true,219, 20, 2, 1, 1, 1, "100","1",false,false,true,"lblWareHouse35","bce0a089-6059-4e99-80d6-cb73a0e818bd","f60dd9b6-a00c-47b2-9108-57421a3cf141");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.WareHouse35, "False", "WareHouse", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldWareHouse, "BOMDispExecView");
			UIControlBuilder.SetReferenceControlRefInfo(this.WareHouse35,"b6846a1b-ed73-4c68-94c4-ccaa523d43fa", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.WareHouse35,"WareHouse35",new ReferenceInputParam[]{new ReferenceInputParam("Org","OrgID","Value","",2),new ReferenceInputParam("Date1","DateTime","Value","",2),new ReferenceInputParam("Date2","DateTime","Value","",2),new ReferenceInputParam("IDS","","","",1),});
 			//for personal
		 
         				 
         				 
         				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.WareHouse35,"WareHouse35",new ReferenceOutputParam[]{new ReferenceOutputParam("WareHouse35","ID","Key"),new ReferenceOutputParam("WareHouse35","Code","Value"),new ReferenceOutputParam("WareHouse35","Name","Text"),new ReferenceOutputParam("","LocationType",""),new ReferenceOutputParam("","IsBin",""),new ReferenceOutputParam("","OutboundType",""),new ReferenceOutputParam("","Supplier_ID",""),new ReferenceOutputParam("","Supplier_Code",""),new ReferenceOutputParam("","Supplier_Name",""),new ReferenceOutputParam("","Customer_ID",""),new ReferenceOutputParam("","Customer_Code",""),new ReferenceOutputParam("","Customer_Name",""),new ReferenceOutputParam("","IsLot",""),new ReferenceOutputParam("","IsSerial",""),new ReferenceOutputParam("","Description",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.WareHouse35, "1");		
		 

				this.lblManufactureNo25 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblManufactureNo25", "", "True", "True", "Right", 81, 20, 0, 2, 1, 1, "100","583469c5-d19a-4861-8c98-62d03cea6469","d0be29c9-9052-49e6-b0b4-a0390a1f7268");


								

		
			UIControlBuilder.BuilderUFControl(this.lblManufactureNo25, "2");		


				this.ManufactureNo25 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ManufactureNo25",true,true, true,219, 20, 2, 2, 1, 1, "100","3",false,false,true,"lblManufactureNo25","583469c5-d19a-4861-8c98-62d03cea6469","940fa2cb-94f9-42be-a0b6-ca99048e720a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ManufactureNo25, "False", "ManufactureNo", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldManufactureNo, "BOMDispExecView");
			UIControlBuilder.SetReferenceControlRefInfo(this.ManufactureNo25,"947d00bb-d74a-42cc-8700-8540c94e2b6d", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.ManufactureNo25,"ManufactureNo25",new ReferenceInputParam[]{new ReferenceInputParam("Date1","DateTime","Value","",2),new ReferenceInputParam("Date2","DateTime","Value","",2),new ReferenceInputParam("Org","OrgID","Value","",2),new ReferenceInputParam("IDS","","","",1),});
 			//for personal
		 
         				 
         				 
         				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ManufactureNo25,"ManufactureNo25",new ReferenceOutputParam[]{new ReferenceOutputParam("ManufactureNo26","ID","Key"),new ReferenceOutputParam("ManufactureNo26","Code","Value"),new ReferenceOutputParam("ManufactureNo26","Name","Text"),new ReferenceOutputParam("","Description",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ManufactureNo25, "3");		
		 

				this.BtnDispExec = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnDispExec", true, true, 70, 20, 3, 10, 1, 1, "100","", this.Model.ElementID,"DispExecClick",false,"b5055280-7586-4ca0-b1b9-480f75e8adb4","","b5055280-7586-4ca0-b1b9-480f75e8adb4");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnDispExec, "4");		


				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 394, "Horizontal", "True", 394, 23, 0, 0, 5, 1, "100","d7eb26ea-6171-4ff0-bf91-246aaaed1f4d","d7eb26ea-6171-4ff0-bf91-246aaaed1f4d");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "5");		


				this.lblWorkPlace34 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblWorkPlace34", "", "True", "True", "Right", 81, 20, 0, 3, 1, 1, "100","570890ae-0c5d-47f9-aba7-a2764dded7bc","7237d7a4-0d6c-438c-b44b-ce692a9b41c5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblWorkPlace34, "6");		


				this.WorkPlace34 = UIControlBuilder.BuilderTextBox(_UFCard, "WorkPlace34", "True", "True", "True", "False", "Left", 0, 60, 0, 219, 20, 2, 3, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblWorkPlace34","","50","570890ae-0c5d-47f9-aba7-a2764dded7bc","f5e450bb-915d-4b83-a53e-a5c436f32033");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.WorkPlace34, "False", "WorkPlace", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldWorkPlace, "BOMDispExecView");


		
			UIControlBuilder.BuilderUFControl(this.WorkPlace34, "7");		
		 

				this.Label36 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label36", "", "True", "True", "Right", 310, 20, 0, 4, 3, 1, "100","002bc325-f30f-4700-b575-726cc11b9a6d","002bc325-f30f-4700-b575-726cc11b9a6d");


								

		
			UIControlBuilder.BuilderUFControl(this.Label36, "8");		


				this.Button1 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Button1", true, true, 70, 20, 3, 11, 1, 1, "100","", this.Model.ElementID,"",false,"a3b7a6dc-54b7-4e18-84bb-b448447a1a66","","a3b7a6dc-54b7-4e18-84bb-b448447a1a66");
	

		
			UIControlBuilder.BuilderUFControl(this.Button1, "9");		


				this.lblStartDate109 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblStartDate109", "", "True", "True", "Right", 81, 20, 0, 5, 1, 1, "100","e11331b5-888f-4025-a4bc-bd79b467d128","e11331b5-888f-4025-a4bc-bd79b467d128");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStartDate109, "10");		


				this.StartDate109 = UIControlBuilder.BuilderDatePicker(_UFCard, "StartDate109", true, true, true, "Date","Left", 3, 60, 0, 219, 20, 2, 5, 1, 1, "100",true,false,"lblStartDate109","18e10bd0-a483-434d-8727-ca7ac92ef83b","efa16f76-85cf-4219-a210-5cd5925fcf44");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.StartDate109, "False", "StartDate", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldStartDate, "BOMDispExecView");


		
			UIControlBuilder.BuilderUFControl(this.StartDate109, "11");		
		 

				this.EndTime43 = UIControlBuilder.BuilderDatePicker(_UFCard, "EndTime43", true, true, true, "Date","Left", 3, 60, 0, 219, 20, 2, 6, 1, 1, "100",true,false,"","fef0cb27-ca53-49f9-ad79-700632e68504","1addf8b2-a01b-4f56-a38f-f5d3f53cc11d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.EndTime43, "False", "EndTime", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldEndTime, "BOMDispExecView");


		
			UIControlBuilder.BuilderUFControl(this.EndTime43, "13");		
		 

				this.lblItem49 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItem49", "", "True", "True", "Right", 81, 20, 0, 7, 1, 1, "100","4ee6800b-2381-4327-b016-1552521d5c2e","d9ca7621-76e5-4bf7-b0fa-1db639301e80");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItem49, "14");		


				this.Item49 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Item49",true,true, true,219, 20, 2, 7, 1, 1, "100","15",false,false,true,"lblItem49","4ee6800b-2381-4327-b016-1552521d5c2e","a82f7913-2b01-4820-a43c-b3c31a8cd754");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Item49, "False", "Item", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldItem, "BOMDispExecView");
			UIControlBuilder.SetReferenceControlRefInfo(this.Item49,"0ac5d443-a634-45ec-bddd-4a76863312ce", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Item49,"Item49",new ReferenceInputParam[]{new ReferenceInputParam("DocDate","","","",1),});
 			//for personal
		 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Item49,"Item49",new ReferenceOutputParam[]{new ReferenceOutputParam("Item49","ID","Key"),new ReferenceOutputParam("Item49","Code","Value"),new ReferenceOutputParam("Item49","Name","Text"),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","Code1",""),new ReferenceOutputParam("","Code2",""),new ReferenceOutputParam("","Version",""),new ReferenceOutputParam("","StandardGrade",""),new ReferenceOutputParam("","StandardPotency",""),new ReferenceOutputParam("","IsGradeControl",""),new ReferenceOutputParam("","IsPotencyControl",""),new ReferenceOutputParam("","StartGrade",""),new ReferenceOutputParam("","EndGrade",""),new ReferenceOutputParam("","StartPotency",""),new ReferenceOutputParam("","EndPotency",""),new ReferenceOutputParam("","IsMISC",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Item49, "15");		
		 

				this.lblDistributeStartDate82 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDistributeStartDate82", "", "True", "True", "Right", 81, 20, 0, 8, 1, 1, "100","0fe3dc74-2786-434a-9122-73353560976a","6a36e312-8a21-4189-91f5-f01b89dc5e9f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDistributeStartDate82, "16");		


				this.DistributeStartDate82 = UIControlBuilder.BuilderDatePicker(_UFCard, "DistributeStartDate82", true, true, true, "Date","Left", 3, 60, 0, 219, 20, 2, 8, 1, 1, "100",true,false,"lblDistributeStartDate82","0fe3dc74-2786-434a-9122-73353560976a","529d71a6-fbd6-4ab4-b828-f0d1d665e2a9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DistributeStartDate82, "False", "DistributeStartDate", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldDistributeStartDate, "BOMDispExecView");


		
			UIControlBuilder.BuilderUFControl(this.DistributeStartDate82, "17");		
		 

				this.DistributeEndDate174 = UIControlBuilder.BuilderDatePicker(_UFCard, "DistributeEndDate174", true, true, true, "Date","Left", 3, 60, 0, 219, 20, 2, 9, 1, 1, "100",true,false,"","37e68c36-dcba-46c7-8c38-b0fa631139fd","7496b891-db56-4618-839b-6116de42e121");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DistributeEndDate174, "False", "DistributeEndDate", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldDistributeEndDate, "BOMDispExecView");


		
			UIControlBuilder.BuilderUFControl(this.DistributeEndDate174, "19");		
		 

				this.lblJustDisNegative175 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblJustDisNegative175", "", "True", "True", "Right", 81, 20, 0, 10, 1, 1, "100","f9f9d2eb-9642-4cfb-9f31-7c5cb6a41e3a","d1d3f8a7-3c5c-49a0-b69f-e12e6f4b1955");


								

		
			UIControlBuilder.BuilderUFControl(this.lblJustDisNegative175, "20");		


				this.JustDisNegative175 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "JustDisNegative175", true, true, "Left", 60, 0, 219, 20, 2, 10, 1, 1, "100",false,"lblJustDisNegative175","f9f9d2eb-9642-4cfb-9f31-7c5cb6a41e3a","efa2370b-dfe7-4687-a150-184070f44429");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.JustDisNegative175, "False", "JustDisNegative", this.Model.BOMDispExecView, this.Model.BOMDispExecView.FieldJustDisNegative, "BOMDispExecView");
		

		
			UIControlBuilder.BuilderUFControl(this.JustDisNegative175, "21");		
		 


		
			this.WareHouse35.IsMultiOrg  = false ;
			this.lblWareHouse35.SetMultiOrgInfo(this.WareHouse35,false);
			
		
			this.ManufactureNo25.IsMultiOrg  = false ;
			this.lblManufactureNo25.SetMultiOrgInfo(this.ManufactureNo25,false);
			
											
			this.Item49.IsMultiOrg  = false ;
			this.lblItem49.SetMultiOrgInfo(this.Item49,false);
			
					

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





		#endregion
		

	}
}
