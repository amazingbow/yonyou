

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using NUnit.Framework;
	
	/// <summary>
	/// Business operation test
	/// </summary> 
	[TestFixture]		
	public class RcvPushAPComfirmSVTest
	{
		private Proxy.RcvPushAPComfirmSVProxy obj = new Proxy.RcvPushAPComfirmSVProxy();

		public RcvPushAPComfirmSVTest()
		{
		}
		#region AutoTestCode ...
		[Test]
		public void TestDo()
		{
			obj.Do() ;  
		
		}
		#endregion 				
	}
	
}