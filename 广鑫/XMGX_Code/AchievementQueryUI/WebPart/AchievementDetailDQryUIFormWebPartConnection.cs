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

namespace UFIDA.U9.Cust.FJGX.AchievementDetailDQryUIModel
{

	
	[InParameterAttribute("@Parameter1")]


	public partial class AchievementDetailDQryUIFormWebPart
    {
		#region Generated WebPart Connection code
        #region  WebPart Consumer
        protected override PropertyDescriptorCollection CreateConsumerSchema()
        {
			return WebPartBuilder.CreateConsumerSchema(new string[]{"@Parameter1",});
        }
		#endregion

		#endregion
		
	}
}