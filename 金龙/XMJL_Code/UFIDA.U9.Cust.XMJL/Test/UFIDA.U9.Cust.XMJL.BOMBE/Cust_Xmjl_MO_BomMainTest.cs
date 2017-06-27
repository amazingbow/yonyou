
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMJL.BommBE.TestSuite{

	/// <summary>
	/// Cust_Xmjl_MO_BomMain Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class Cust_Xmjl_MO_BomMainTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void Cust_Xmjl_MO_BomMainCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCust_Xmjl_MO_BomMain
										obj  = UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(Cust_Xmjl_MO_BomMain).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.EntityList list = UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCust_Xmjl_MO_BomMain	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain).ToString() + "> failed.");
			}
		*/
		}
	}
}

