@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "D:\Project\Plug\Code\UFIDA.U9.Cust.HX\UFIDA.U9.Cust.HX\UFIDA.U9.Cust.HX.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end