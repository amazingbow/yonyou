
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.TestSuite{

	/// <summary>
	/// RefVoucherInfoBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class RefVoucherInfoBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void RefVoucherInfoBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateRefVoucherInfoBE
										obj  = UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(RefVoucherInfoBE).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE.EntityList list = UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveRefVoucherInfoBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

