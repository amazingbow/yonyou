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

namespace BOMUIModel
{

	
	[InParameterAttribute("ID")]

	
    [OutParameterAttribute("ID")]
	
    [OutParameterAttribute("DocNo")]

	public partial class BOMUIFormWebPart
    {
		#region Generated WebPart Connection code
        #region  WebPart Consumer
        protected override PropertyDescriptorCollection CreateConsumerSchema()
        {
			return WebPartBuilder.CreateConsumerSchema(new string[]{"ID",});
        }
		#endregion

		#region WebPart Provider
        protected override DataRowView CreateRowData()
        {
            if(!this.IsProviding)
            {
				return null;
			}
			return WebPartBuilder.CreateProviderRowData(this.Model,new ProviderData[]{new ProviderData("ID","Cust_Xmjl_MO_BomMain","ID"),new ProviderData("DocNo","Cust_Xmjl_MO_BomMain","DocNo"),});
        }
		#endregion
		#endregion
		
	}
}