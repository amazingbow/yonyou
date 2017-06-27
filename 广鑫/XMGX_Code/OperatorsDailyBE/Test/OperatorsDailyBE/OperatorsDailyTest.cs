
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.FJGX.OperatorsDailyBE.TestSuite{

	/// <summary>
	/// OperatorsDaily Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class OperatorsDailyTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void OperatorsDailyCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateOperatorsDaily
										obj  = UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(OperatorsDaily).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily.EntityList list = UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveOperatorsDaily	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily).ToString() + "> failed.");
			}
		*/
		}
	}
}

