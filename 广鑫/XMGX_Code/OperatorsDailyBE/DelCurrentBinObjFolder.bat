@echo off
:: ���г����е�Ŀ¼֮��Ȼ���ս������У�ɾ����
:: ע���ļ����в��ܴ�����bin��obj�������Ƶ��ļ���
for /f "tokens=*" %%a in ('dir /ad /b /s "bin?" "obj?" ^|sort /r') do call :rd_dir "%%a"
pause
goto:eof

rem ===========ɾ��Ŀ¼===============
:rd_dir
echo %1
echo ����ɾ���ļ���...
rd /S /Q %1 2>nul||goto :eof
goto :eof