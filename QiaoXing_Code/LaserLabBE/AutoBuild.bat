﻿
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.XMQX.LaserLabBE.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\Unconfiged\DBScript\
echo .\..\..\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=jt,./123;Data Source=QINGXU-PC;Initial Catalog=U9;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\Unconfiged\MetadataScript\ ..\..\U9.VOB.Product.Other\Unconfiged\DBScript\

echo componet  buid end
pause

