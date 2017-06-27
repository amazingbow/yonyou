
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.Deploy.dll  D:\UFIDA\U9V50\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.Deploy.pdb  D:\UFIDA\U9V50\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.dll  D:\UFIDA\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.pdb  D:\UFIDA\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.Deploy.dll  D:\UFIDA\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.FJGX.OperatorsDailyBE.Deploy.pdb  D:\UFIDA\U9V50\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\UBFV50\U9.VOB.Product.Other\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\..\UBFV50\U9.VOB.Product.Other\\Unconfiged\DBScript\
echo .\..\..\..\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=kingwolf;Data Source=localhost;Initial Catalog=GXU9DB;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\Unconfiged\MetadataScript\ ..\..\U9.VOB.Product.Other\Unconfiged\DBScript\

echo componet  buid end
pause

