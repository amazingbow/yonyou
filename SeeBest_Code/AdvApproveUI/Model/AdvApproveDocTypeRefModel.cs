#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace AdvApproveDocTypeRef
{
	[Serializable]
	public partial class AdvApproveDocTypeRefModel : UIModel
	{
		#region Constructor
		public AdvApproveDocTypeRefModel() : base("AdvApproveDocTypeRef")
		{
			InitClass();
			this.SetResourceInfo("741bf694-2ccf-4255-bc49-c3c5a0c067e1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApproveDocTypeRefModel(bool isInit) : base("AdvApproveDocTypeRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApproveDocTypeRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("803ebb68-9901-4c22-85e3-05ad550ceb86");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApproveUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldConfirmType
		{
			get { return this.Fields["ConfirmType"]; }
		}
		public IUIField FieldApproveType
		{
			get { return this.Fields["ApproveType"]; }
		}
		public IUIField FieldAdvDocEnum
		{
			get { return this.Fields["AdvDocEnum"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","89a87860-7902-4b11-b48e-1bf11d7349b2");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","55555b97-76a0-4441-9c8e-da89c0a12ecb");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab766c47-d587-4d99-bb6e-33cf46fc7b43");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","2a093ab6-3d48-4531-8d74-44a1f17c2c61");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","8bed9498-1589-44c9-9e08-bc3fafc65aa5");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDocEnum", typeof(Int32), false,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum", "AdvDocEnum", true,true, false, "",false,(UIFieldType)2,"5b384422-00ff-4599-9ae5-e1d3f50cfcbe","d4499b49-aace-4cf1-a0d4-0e89a55f8acd");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCode);
			}
			set{
				this[this.uiviewcRef.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldName);
			}
			set{
				this[this.uiviewcRef.FieldName] = value;
			}
		}
		
		
		public  Int32 ConfirmType
		{
			get{
				//object value = this[this.uiviewcRef.FieldConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewcRef.FieldConfirmType);
			}
			set{
				this[this.uiviewcRef.FieldConfirmType] = value;
			}
		}
		
		
		public  Int32? ApproveType
		{
			get{
				//object value = this[this.uiviewcRef.FieldApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldApproveType);
			}
			set{
				this[this.uiviewcRef.FieldApproveType] = value;
			}
		}
		
		
		public  Int32 AdvDocEnum
		{
			get{
				//object value = this[this.uiviewcRef.FieldAdvDocEnum] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewcRef.FieldAdvDocEnum);
			}
			set{
				this[this.uiviewcRef.FieldAdvDocEnum] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"AdvDocEnum=2",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}