
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.FJGX.SO.PlugBE.dll  F:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\bin\Debug\UFIDA.U9.Cust.FJGX.SO.PlugBE.pdb  F:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\UFIDA.U9.Cust.FJGX.SO.PlugBE.sub.xml        F:\yonyou\U9V50\Portal\bin



pause

