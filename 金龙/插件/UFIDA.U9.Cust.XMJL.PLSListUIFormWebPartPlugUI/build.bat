@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "C:\??\Code\UFIDA.U9.Cust.XMJL.PLSListUIFormWebPartPlug\UFIDA.U9.Cust.XMJL.PLSListUIFormWebPartPlugUI\UFIDA.U9.Cust.XMJL.PLSListUIFormWebPartPlugUI.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end