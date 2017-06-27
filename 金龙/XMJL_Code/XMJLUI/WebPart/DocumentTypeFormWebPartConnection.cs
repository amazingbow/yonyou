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

namespace DocumentTypeModel
{

	
	[InParameterAttribute("ID")]

	
    [OutParameterAttribute("Code")]
	
    [OutParameterAttribute("Name")]
	
    [OutParameterAttribute("ID")]

	public partial class DocumentTypeFormWebPart
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
			return WebPartBuilder.CreateProviderRowData(this.Model,new ProviderData[]{new ProviderData("Code","Cust_Xmjl_DocumentType","Code"),new ProviderData("Name","Cust_Xmjl_DocumentType","Name"),new ProviderData("ID","Cust_Xmjl_DocumentType","ID"),});
        }
		#endregion
		#endregion
		
	}
}