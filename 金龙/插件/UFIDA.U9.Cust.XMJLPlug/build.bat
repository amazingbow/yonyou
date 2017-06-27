@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "C:\NaChuan_New_Project\PlugCode\UFIDA.U9.Cust.XMJLPlug\UFIDA.U9.Cust.XMJLPlug.sln" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end