

namespace UFIDA.U9.Cust.XMJL.ProductionPlug
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
    
    
    public partial class DiscreteMOBListUIFormWebPart
    {
        
            #region 字段与属性                                       
                                                                     
            private UFIDA.U9.MFG.MO.DiscreteMOBListUIModel.DiscreteMOBListUIFormWebPart _strongPart;                           
                                                                     
            #endregion                                               

        
        private void Do_AfterDataLoad(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据                               
                                                                     
            _strongPart = part as UFIDA.U9.MFG.MO.DiscreteMOBListUIModel.DiscreteMOBListUIFormWebPart;                         
            if (_strongPart == null)                                  
                return;                                              
                                                                     
            #endregion                                               

        }
    }
}
