@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "C:\Users\Administrator\Desktop\????\XMJL\AssetCardMemo\UFIDA.U9.XMJL.FA.AssetCardAddMemoPlug\UFIDA.U9.XMJL.FA.AssetCardAddMemoPlugUI\UFIDA.U9.XMJL.FA.AssetCardAddMemoPlugUI.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end