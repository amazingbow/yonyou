
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMJLBomChangeBE.TestSuite{

	/// <summary>
	/// Cust_Xmjl_MO_BomChangeManufactureNo Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class Cust_Xmjl_MO_BomChangeManufactureNoTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void Cust_Xmjl_MO_BomChangeManufactureNoCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCust_Xmjl_MO_BomChangeManufactureNo
					
					obj  = UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange.Create() ;
					UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo n_cust_xmjl_mo_bomchangemanufactureno =UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(Cust_Xmjl_MO_BomChangeManufactureNo).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange.EntityList list = UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCust_Xmjl_MO_BomChangeManufactureNo	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange).ToString() + "> failed.");
			}
		*/
		}
	}
}

