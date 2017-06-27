@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "D:\U9\Project\Plug\Code\UFIDA.U9.Cust.XMJL.MiscRcvTransPricePlugUI\MiscRcvTransPricePlugUI\MiscRcvTransPricePlugUI.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end