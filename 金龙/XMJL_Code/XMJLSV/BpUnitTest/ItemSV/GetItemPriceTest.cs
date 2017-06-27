

namespace UFIDA.U9.Cust.XMJL.ItemSV
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
	public class GetItemPriceTest
	{
		private Proxy.GetItemPriceProxy obj = new Proxy.GetItemPriceProxy();

		public GetItemPriceTest()
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