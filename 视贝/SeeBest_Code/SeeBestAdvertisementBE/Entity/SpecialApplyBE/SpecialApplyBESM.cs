using System;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
	public partial class SpecialApplyBE:IStateMachineEntity
	{
		private SpecialApplyBEStateMachine _statemachineInstance;
		private static object _lockObject=new object();
		public SpecialApplyBEStateMachine StateMachineInstance
		{
			get
			{
				if (_statemachineInstance == null)
				{
					lock(_lockObject)
					{
						if(_statemachineInstance==null)
						{
							_statemachineInstance = new SpecialApplyBEStateMachine(this);
						}
					}
				}
				return _statemachineInstance;
			}
		}

		public partial class SpecialApplyBEStateMachine:EntityStateMachine
		{
			public SpecialApplyBEStateMachine(SpecialApplyBE entity)
			{
				_entity = entity;
			}
			public enum State
			{
				Empty=-1,
		
			OpenLState=0,

			ApprovingState=1,

			ApprovedState=2,
			}

			#region Properties
			private SpecialApplyBE _entity;
			protected SpecialApplyBE Entity
			{
				get
				{
					return _entity;
				}
			}
			public State OriginalState
			{
				get
				{
					return (State)System.Enum.Parse(typeof(State), this.Entity.WFOriginalState.ToString());
				}
				private set
				{
					this.Entity.WFOriginalState = (int)value;
				}
			}
			public State CurrentState
			{
				get
				{
					return (State)System.Enum.Parse(typeof(State), this.Entity.WFCurrentState.ToString());
				}
				private set
				{
					this.Entity.WFCurrentState = (int)value;
				}
			}
			#endregion

			#region public interface
			public void Initialize()
			{
				OriginalState = State.Empty;
				CurrentState = State.OpenLState;
				StateEnter(null);
			}
		    

			
			public void OpenLState_SubmitEventDriven(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SubmitEvent ev)
			{
				if (CurrentState == State.OpenLState)
				{
					SetState(OpenLState_SubmitEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("363e7e53-0181-4a45-95b9-2980fa1a68cf","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void ApprovingState_ApproveEventDriven(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
			{
				if (CurrentState == State.ApprovingState)
				{
					SetState(ApprovingState_ApproveEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("363e7e53-0181-4a45-95b9-2980fa1a68cf","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void ApprovedState_UndoApproveEventDriven(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.UndoApproveEvent ev)
			{
				if (CurrentState == State.ApprovedState)
				{
					SetState(ApprovedState_UndoApproveEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("363e7e53-0181-4a45-95b9-2980fa1a68cf","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
			
			#endregion
			
			#region private 
			private void SetState(State state, Event ev)
			{
				//if (state != CurrentState)
				{
					StateLeave(ev);
					OriginalState = CurrentState;
					CurrentState = state;
					StateEnter(ev);
				}
			}
			private void StateEnter(Event ev)
			{
				State state = CurrentState;
				ChangeEntityState();
				switch (state)
				{
					case State.OpenLState:
						state = OpenLStateEnterImp(ev);
						break;
					case State.ApprovingState:
						state = ApprovingStateEnterImp(ev);
						break;
					case State.ApprovedState:
						state = ApprovedStateEnterImp(ev);
						break;
				}
				if (state != CurrentState)
				{
					SetState(state,ev);
				}
			}
			private void StateLeave(Event ev)
			{
				switch (CurrentState)
				{
					case State.OpenLState:
						OpenLStateLeaveImp(ev);
						break;
					case State.ApprovingState:
						ApprovingStateLeaveImp(ev);
						break;
					case State.ApprovedState:
						ApprovedStateLeaveImp(ev);
						break;
				}
			}
			private void PublishEvent(Event ev)
			{
				string eventName = this.Entity.Key.EntityType + ".StateMachineEvent";
				StateMachineEvent smEvent = new StateMachineEvent(eventName);
				smEvent.EntityKey=this.Entity.Key;
				smEvent.Event=ev;
				smEvent.CurrentState = this.CurrentState.ToString();
				smEvent.OriginalState = this.OriginalState.ToString();
				
				UFSoft.UBF.Eventing.EventBroker.Publish(smEvent);
			}
			#endregion
		}
	}
}