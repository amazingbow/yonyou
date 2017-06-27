

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
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
	public class GetBomInfoByCarNoBPTest
	{
		private Proxy.GetBomInfoByCarNoBPProxy obj = new Proxy.GetBomInfoByCarNoBPProxy();

		public GetBomInfoByCarNoBPTest()
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