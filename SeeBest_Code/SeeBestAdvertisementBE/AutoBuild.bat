
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.SeeBestAdvertisementBE.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\UBFV50\U9.VOB.Product.Other\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\..\UBFV50\U9.VOB.Product.Other\\Unconfiged\DBScript\
echo .\..\..\..\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=database;Data Source=2013-20151104ZX;Initial Catalog=FJNC20161217;packet size=4096;Max Pool size=500;Connection Timeout=900;persist security info=True;MultipleActiveResultSets=true;" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\Unconfiged\MetadataScript\ ..\..\U9.VOB.Product.Other\Unconfiged\DBScript\

echo componet  buid end
pause

