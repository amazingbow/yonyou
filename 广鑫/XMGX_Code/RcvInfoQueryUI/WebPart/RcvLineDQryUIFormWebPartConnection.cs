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

namespace UIFIA.U9.Cust.FJGX.RcvLineDQryUIModel
{

	
	[InParameterAttribute("@Parameter0")]


	public partial class RcvLineDQryUIFormWebPart
    {
		#region Generated WebPart Connection code
        #region  WebPart Consumer
        protected override PropertyDescriptorCollection CreateConsumerSchema()
        {
			return WebPartBuilder.CreateConsumerSchema(new string[]{"@Parameter0",});
        }
		#endregion

		#endregion
		
	}
}