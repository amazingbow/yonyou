

namespace UFIDA.U9.Cust.XMJL.BOMMasterBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    
    
    public partial class AfterInserted : UFSoft.UBF.Eventing.IEventSubscriber
    {
        
        void UFSoft.UBF.Eventing.IEventSubscriber.Notify(object[] args)
        {
            this.Do_Notify(args);
        }
    }
}
