
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.XMQX.LaserQryUI.WebPart.dll  C:\yonyou\U9V50\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.XMQX.LaserQryUI.WebPart.pdb  C:\yonyou\U9V50\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=jt,./123;Data Source=QINGXU-PC;Initial Catalog=U9;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

