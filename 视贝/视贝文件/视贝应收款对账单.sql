--Docstatus状态 0:开立 1:审核中 2:已准核 


Select sobperoid.ID as SoBAccountID,period.FromDate,period.ToDate,book.Org from Base_SOBAccountingPeriod sobperoid inner join Base_AccountingPeriod period on sobperoid.AccountPeriod=period.ID inner join Base_SetofBooks book on sobperoid.SetofBooks=book.ID

-----出货单
Select A.BusinessDate as PostDate,DocNo,Org,OrderBy_Customer as Customer_ID,OrderBy_Code as Customer_Code,OrderBy_Name as Customer_Name,
ISNULL(TotalMoneyFC,0) as IncAdd,0 as IncRed,B.ShipMemo as Meno,Case [Status] when 1 then 0 when 2 then 1 when 3 then 2 else 5 end as DocStatus into #Ship_Info from SM_Ship A inner join SM_Ship_Trl B on A.ID=B.ID

------退回处理单
select BusinessDate as PostDate,DocNo,Org,Customer_Customer as Customer_ID,Customer_Code,Customer_ShortName as Customer_Name,(0-(Select Sum(RtnMoneyFC) from SM_RMALine r where r.RMA= A.ID)) as IncAdd,0 as IncRed,case [Status]  when 1 then 0 when 2 then 1 when 3 then 2 else 5 end as DocStatus into #RMA_Info from SM_RMA A

-------应收单(需要过滤调单据类型Code为AR13的数据)
Select BusinessDate as PostDate,DocNo,Org,PayCust_Customer as Customer_ID,PayCust_Code as Customer_Code,PayCust_ShortName as Customer_Name,Case [Description] when '应收增加' then ARFCMoney_TotalMoney else (0-ARFCMoney_TotalMoney) end as IncAdd,0 as IncRed into #AR_InfoAdd from AR_ARBillHead A inner join AR_ARDocType_Trl B on A. DocumentType=B.ID and B.ID <>1001707217833589

Select BusinessDate as PostDate,DocNo,Org,PayCust_Customer as Customer_ID,PayCust_Code as Customer_Code,PayCust_ShortName as Customer_Name,0 as IncAdd,ARFCMoney_TotalMoney as IncRed into #Ar_InfoRec from  AR_ARBillHead A inner join AR_ARDocType_Trl B on A. DocumentType=B.ID and B.ID = 1001707217833589

-------收款单
Select BusinessDate as PostDate,DocNo,Org,Cust_Customer as Customer_ID,Cust_Code as Customer_Code,Cust_ShortName as Customer_Name,0 as IncAdd,TotalMoney_FCMoney as IncRed,DocStatus into #RecInfo from AR_RecBillHead 

Select * from #Ship_Info
drop table #Ship_Info


