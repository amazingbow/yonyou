

namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV
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
	public class XMJLCreateApBillSVTest
	{
		private Proxy.XMJLCreateApBillSVProxy obj = new Proxy.XMJLCreateApBillSVProxy();

		public XMJLCreateApBillSVTest()
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