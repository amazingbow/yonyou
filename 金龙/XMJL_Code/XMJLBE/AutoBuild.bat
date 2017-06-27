
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMJL.BE.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\Unconfiged\DBScript\
echo .\..\..\..\yonyou\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "packet size=4096;user id=sa;Connection Timeout=150;Max Pool size=1500;data source=localhost;persist security info=True;initial catalog=GXU9DB;password=admin123" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\Unconfiged\MetadataScript\ ..\..\U9.VOB.Product.Other\Unconfiged\DBScript\

echo componet  buid end
pause

