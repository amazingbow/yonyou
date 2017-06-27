

namespace UFIDA.U9.Cust.XMJL.XMJLApBillTestBP
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
	public class XMJLApBillCreateBPTest
	{
		private Proxy.XMJLApBillCreateBPProxy obj = new Proxy.XMJLApBillCreateBPProxy();

		public XMJLApBillCreateBPTest()
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