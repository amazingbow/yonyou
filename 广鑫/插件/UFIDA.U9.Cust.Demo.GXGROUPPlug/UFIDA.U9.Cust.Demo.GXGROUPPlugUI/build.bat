@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "D:\New_Project\PlugCode\UFIDA.U9.Cust.Demo.GXGROUPPlug\UFIDA.U9.Cust.Demo.GXGROUPPlugUI\UFIDA.U9.Cust.Demo.GXGROUPPlugUI.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end