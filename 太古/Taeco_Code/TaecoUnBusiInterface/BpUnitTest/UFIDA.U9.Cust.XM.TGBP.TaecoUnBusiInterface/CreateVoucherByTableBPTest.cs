

namespace UFIDA.U9.Cust.XM.TGBP.TaecoUnBusiInterface
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
	public class CreateVoucherByTableBPTest
	{
		private Proxy.CreateVoucherByTableBPProxy obj = new Proxy.CreateVoucherByTableBPProxy();

		public CreateVoucherByTableBPTest()
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