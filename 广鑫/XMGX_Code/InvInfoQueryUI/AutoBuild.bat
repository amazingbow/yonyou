
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.FJGX.InvInfoQueryUI.WebPart.dll  D:\UFIDA\U9V50\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.FJGX.InvInfoQueryUI.WebPart.pdb  D:\UFIDA\U9V50\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\UBFV50\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=kingwolf;Data Source=localhost;Initial Catalog=GXU9DB20160417;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

