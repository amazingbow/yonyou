/*
 *  Generated WebPart Connection code
 */

#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder ;
#endregion

namespace UIFIA.U9.Cust.FJGX.RcvHeadDQryUIModel
{


	
    [OutParameterAttribute("@Provider_Para0")]

	public partial class RcvHeadDQryUIFormWebPart
    {
		#region Generated WebPart Connection code

		#region WebPart Provider
        protected override DataRowView CreateRowData()
        {
            if(!this.IsProviding)
            {
				return null;
			}
			return WebPartBuilder.CreateProviderRowData(this.Model,new ProviderData[]{new ProviderData("@Provider_Para0","QueryView","ID"),});
        }
		#endregion
		#endregion
		
	}
}