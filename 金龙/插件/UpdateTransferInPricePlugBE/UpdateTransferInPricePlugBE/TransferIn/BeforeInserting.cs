

namespace UFIDA.U9.Cust.XMJL.UpdateTransferInPricePlugBE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;
    
    
    public partial class BeforeInserting : UFSoft.UBF.Eventing.IEventSubscriber
    {
        
        void UFSoft.UBF.Eventing.IEventSubscriber.Notify(object[] args)
        {
            this.Do_Notify(args);
        }
    }
}
