

namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj
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
	public class BatchRcvToAPBillSVTest
	{
		private Proxy.BatchRcvToAPBillSVProxy obj = new Proxy.BatchRcvToAPBillSVProxy();

		public BatchRcvToAPBillSVTest()
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