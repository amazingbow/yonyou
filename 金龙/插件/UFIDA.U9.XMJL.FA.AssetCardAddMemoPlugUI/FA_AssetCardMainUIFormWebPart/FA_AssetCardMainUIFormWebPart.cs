

namespace UFIDA.U9.XMJL.FA.AssetCardAddMemoPlugUI
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


    public partial class FA_AssetCardMainUIFormWebPart : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {

        //public override void AfterInit(IPart Part, EventArgs args)
        //{
        //    this.Do_AfterInit(Part, args);
        //}

        public override void AfterDataLoad(IPart Part)
        {
            this.Do_AfterDataLoad(Part);
        }
        //public override void BeforeRender(IPart Part, EventArgs args)
        //{
        //    this.Do_BeforeRender(Part, args);
        //}
        //public override void AfterDataLoad(IPart Part)
        //{
        //    this.Do_AfterLoad(Part);
        //}
    }
}
