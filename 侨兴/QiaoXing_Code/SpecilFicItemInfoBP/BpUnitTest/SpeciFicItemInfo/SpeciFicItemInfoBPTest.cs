

namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
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
	public class SpeciFicItemInfoBPTest
	{
		private Proxy.SpeciFicItemInfoBPProxy obj = new Proxy.SpeciFicItemInfoBPProxy();

		public SpeciFicItemInfoBPTest()
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