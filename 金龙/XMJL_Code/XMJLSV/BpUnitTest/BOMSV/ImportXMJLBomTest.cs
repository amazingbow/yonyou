

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
	public class ImportXMJLBomTest
	{
		private Proxy.ImportXMJLBomProxy obj = new Proxy.ImportXMJLBomProxy();

		public ImportXMJLBomTest()
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