

namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV
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
	public class CreateSAPU9GLVoucherSVTest
	{
		private Proxy.CreateSAPU9GLVoucherSVProxy obj = new Proxy.CreateSAPU9GLVoucherSVProxy();

		public CreateSAPU9GLVoucherSVTest()
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