
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.CostSharingRatioUI.WebPart.dll  D:\yonyou\U9V50\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.CostSharingRatioUI.WebPart.pdb  D:\yonyou\U9V50\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "packet size=4096;user id=sa;Connection Timeout=150;Max Pool size=1500;data source=localhost;persist security info=True;initial catalog=GXU9DB;password=admin123" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

