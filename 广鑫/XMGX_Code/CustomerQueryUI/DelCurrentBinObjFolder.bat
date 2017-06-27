@echo off
:: 先列出所有的目录之后，然后按照降序排列，删除。
:: 注意文件夹中不能存在与bin、obj名称类似的文件夹
for /f "tokens=*" %%a in ('dir /ad /b /s "bin?" "obj?" ^|sort /r') do call :rd_dir "%%a"
pause
goto:eof

rem ===========删除目录===============
:rd_dir
echo %1
echo 正在删除文件夹...
rd /S /Q %1 2>nul||goto :eof
goto :eof