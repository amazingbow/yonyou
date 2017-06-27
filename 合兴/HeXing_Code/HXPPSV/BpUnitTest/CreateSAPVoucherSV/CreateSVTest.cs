

namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
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
	public class CreateSVTest
	{
		private Proxy.CreateSVProxy obj = new Proxy.CreateSVProxy();

		public CreateSVTest()
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