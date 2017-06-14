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

namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel
{

	
	[InParameterAttribute("ID")]

	
    [OutParameterAttribute("ID")]
	
    [OutParameterAttribute("Code")]
	
    [OutParameterAttribute("Name")]

	public partial class SpecialApplyDocTypeUIFormWebPart
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
			return WebPartBuilder.CreateProviderRowData(this.Model,new ProviderData[]{new ProviderData("ID","SpecialApplyDocType","ID"),new ProviderData("Code","SpecialApplyDocType","Code"),new ProviderData("Name","SpecialApplyDocType","Name"),});
        }
		#endregion
		#endregion
		
	}
}