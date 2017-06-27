@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "C:\yonyou\DemoProject\PlugCode\UFIDA.U9.Cust.SeeBest.ItemUIWidenNameFormPlug\UFIDA.U9.Cust.SeeBest.ItemUIWidenNameFormPlug.sln" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end