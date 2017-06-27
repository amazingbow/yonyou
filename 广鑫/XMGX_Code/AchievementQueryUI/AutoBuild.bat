
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.FJGX.AchievementQueryUI.WebPart.dll  D:\yonyou\U9V50\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.FJGX.AchievementQueryUI.WebPart.pdb  D:\yonyou\U9V50\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\..\yonyou\UBFV50\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=admin123;Data Source=localhost;Initial Catalog=GXU9DB;packet size=4096;Max Pool size=500;Connection Timeout=900;persist security info=True;MultipleActiveResultSets=true;" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

