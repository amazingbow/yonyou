

namespace UFIDA.U9.Cust.XMJL.BOMSV
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
	public class GetBomTest
	{
		private Proxy.GetBomProxy obj = new Proxy.GetBomProxy();

		public GetBomTest()
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