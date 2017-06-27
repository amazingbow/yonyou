
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.TestSuite{

	/// <summary>
	/// HxRelationshipBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class HxRelationshipBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void HxRelationshipBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateHxRelationshipBE
										obj  = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(HxRelationshipBE).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE.EntityList list = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveHxRelationshipBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

