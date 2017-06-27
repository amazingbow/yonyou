@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "C:\Users\Administrator\Desktop\XMJL\Code\UFIDA.U9.Cust.XMJL.PlugProject.AccountDesc\UFIDA.U9.Cust.XMJL.PlugProject.AccountDesc.sln" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end