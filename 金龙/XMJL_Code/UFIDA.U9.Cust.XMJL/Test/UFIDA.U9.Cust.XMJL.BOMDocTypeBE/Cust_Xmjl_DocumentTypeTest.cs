
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMJL.BOMDocTypeBE.TestSuite{

	/// <summary>
	/// Cust_Xmjl_DocumentType Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class Cust_Xmjl_DocumentTypeTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void Cust_Xmjl_DocumentTypeCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCust_Xmjl_DocumentType
										obj  = UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(Cust_Xmjl_DocumentType).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType.EntityList list = UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCust_Xmjl_DocumentType	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.XMJL.BOMDocTypeBE.Cust_Xmjl_DocumentType).ToString() + "> failed.");
			}
		*/
		}
	}
}

