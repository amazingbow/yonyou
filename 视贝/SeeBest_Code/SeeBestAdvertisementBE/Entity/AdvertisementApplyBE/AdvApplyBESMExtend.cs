using System;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.Eventing.Configuration;
using UFSoft.UBF.Business;
using UFIDA.U9.Approval.Util;
using UFIDA.U9.CS.Workflow.WorkflowInstanceBE;
using UFSoft.UBF.PL;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
    public partial class AdvApplyBE
    {
        public partial class AdvApplyBEStateMachine
        {
            //OpenLState状态进入方法，开发人员在此实现OpenLState状态进入的逻辑
            private State OpenLStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }
            //OpenLState状态离开方法，开发人员在此实现OpenLState状态离开的逻辑
            private void OpenLStateLeaveImp(Event ev)
            {
                // To do ...
            }
            //ApprovingState状态进入方法，开发人员在此实现ApprovingState状态进入的逻辑
            private State ApprovingStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }
            //ApprovingState状态离开方法，开发人员在此实现ApprovingState状态离开的逻辑
            private void ApprovingStateLeaveImp(Event ev)
            {
                // To do ...
            }
            //ApprovedState状态进入方法，开发人员在此实现ApprovedState状态进入的逻辑
            private State ApprovedStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }
            //ApprovedState状态离开方法，开发人员在此实现ApprovedState状态离开的逻辑
            private void ApprovedStateLeaveImp(Event ev)
            {
                // To do ...
            }



            //SubmitEventDriven事件驱动方法的实现，开发人员在此实现SubmitEventDriven的逻辑
            private State OpenLState_SubmitEventDrivenImp(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.SubmitEvent ev)
            {
                // To do ...
                State toState = CurrentState;
                //TODO:实现转移条件
                if (true)
                {
                    toState = State.ApprovingState;
                }
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.SubmitApproval(this.Entity);
                    ServiceOrderSubscriber subscriber = new ServiceOrderSubscriber();
                    subscriber.EntityKey = this.Entity.Key;
                    EventHelper.SubscribeApprovalResultEvent(this.Entity.Key, subscriber);
                }
                return toState;
            }

            //ApprovedEventDriven事件驱动方法的实现，开发人员在此实现ApprovedEventDriven的逻辑
            private State ApprovingState_ApprovedEventDrivenImp(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
            {
                // To do ...
                State toState = CurrentState;
                //TODO:实现转移条件
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ComfirmWork)
                {
                    toState = State.ApprovedState;
                    return toState;
                }
                //终止审批事件
                if (ev.IsTerminate)
                {
                    ApprovalService.Instance.TerminateApproval(this.Entity);
                    toState = State.OpenLState;
                }
                else if (ev.IsApprovaled)
                {
                    toState = State.ApprovedState;
                }
                else
                {
                    FlowInstance flow = FlowInstance.Finder.Find("SourceOrg=@SourceOrg and OwnerEntity.EntityID=@EntityID and OwnerEntity.EntityType=@EntityType order by ID desc",
                        new OqlParam(this.Entity.Org.ID), new OqlParam(this.Entity.ID), new OqlParam(this.Entity.Key.EntityType));
                    if (flow != null && (flow.ApprovalResult == ApprovalStateEnum.EnumReject || flow.ApprovalResult == ApprovalStateEnum.EnumTerminated))
                        toState = State.OpenLState;
                }
                return toState;
            }
            //UndoApproveEventDriven事件驱动方法的实现，开发人员在此实现UndoApproveEventDriven的逻辑
            private State ApprovedState_UndoApproveEventDrivenImp(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.UndoApproveEvent ev)
            {
                // To do ...
                State toState = CurrentState;
                //TODO:实现转移条件
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.KillApproval(this.Entity);
                }
                toState = State.OpenLState;
                return toState;
            }
            //改变实体状态，开发人员在此实现实体状态的改变
            private void ChangeEntityState()
            {
                switch (this.CurrentState)
                {
                    case State.OpenLState:
                        this.Entity.DocStatus = AdvApplyStatusEnum.OpenL;
                        break;
                    case State.ApprovingState:
                        this.Entity.DocStatus = AdvApplyStatusEnum.Approving;
                        break;
                    case State.ApprovedState:
                        this.Entity.DocStatus = AdvApplyStatusEnum.Approved;
                        break;
                }
            }
        }
    }

    #region 事件侦听器
    ///TODO:在状态机代码的方法使用，如果该状态机不需要侦听事件，则该类可以删除
    ///用法： ServiceOrderSubscriber subscriber = new ServiceOrderSubscriber();
    ///       subscriber.EntityKey = this.Entity.Key;//this是指状态机实例
    ///       UFSoft.UBF.Eventing.EventBroker.Subscribe("UFIDA.UBF.GeneralEvents.ApprovalResultEvent", subscriber);
    [Persistent]
    [Serializable]
    internal class ServiceOrderSubscriber : IEventSubscriber
    {
        UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey;
        public UFSoft.UBF.Business.BusinessEntity.EntityKey EntityKey
        {
            get
            {
                return entityKey;
            }
            set
            {
                entityKey = value;
            }
        }
        ///事件处理方法
        public void Notify(params object[] args)
        {
            if (this.EntityKey == null)
                return;
            if (args.Length == 1)
            {
                UFIDA.U9.GeneralEvents.ApprovalResultEvent ev = args[0] as UFIDA.U9.GeneralEvents.ApprovalResultEvent;
                if (ev != null)
                {
                    if (this.EntityKey.ID == ev.EntityKey.ID)
                    {
                        using (ISession session = Session.Open())
                        {
                            AdvApplyBE entity = this.EntityKey.GetEntity() as AdvApplyBE;
                            entity.StateMachineInstance.ApprovingState_ApprovedEventDriven(ev);
                            session.InList(entity);
                            session.Commit();
                        }
                        EventHelper.UnsubscribeApprovalResultEvent(entityKey, this);
                    }
                }   

            }
        }
    }
    #endregion
}