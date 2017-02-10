
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.TestSuite{

	/// <summary>
	/// HeXingSAPU9GLVoucherHead Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class HeXingSAPU9GLVoucherHeadTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void HeXingSAPU9GLVoucherHeadCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateHeXingSAPU9GLVoucherHead
										obj  = UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(HeXingSAPU9GLVoucherHead).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.EntityList list = UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveHeXingSAPU9GLVoucherHead	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead).ToString() + "> failed.");
			}
		*/
		}
	}
}

