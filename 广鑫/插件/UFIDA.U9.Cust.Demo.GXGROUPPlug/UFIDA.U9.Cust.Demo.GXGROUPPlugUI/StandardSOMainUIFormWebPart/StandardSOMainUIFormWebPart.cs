

namespace UFIDA.U9.Cust.Demo.GXGROUPPlugUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Specialized;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.WebControls.ClientCallBack;
    using UFSoft.UBF.UI.WebControls.Association;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.IView;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using UFSoft.UBF.UI.Controls;
    using UFSoft.UBF.UI.WebControls;
    
    
    public partial class StandardSOMainUIFormWebPart : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        
        public override void AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            //this.Do_AfterInit(part, args);;
        }
        public override void BeforeDataLoad(IPart Part, out bool executeDefault)
        {
            base.BeforeDataLoad(Part, out executeDefault);
            _strongPart = Part as UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart;
            if (_strongPart == null)
                return;
            RegisterGridCellDataChangedCallBack();
        }
    }
}
