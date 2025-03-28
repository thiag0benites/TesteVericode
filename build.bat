@echo off
cd bin\Debug\net8.0

:: Obtém a data e hora no formato ddmmyy_hhmmss
for /f "tokens=2 delims==." %%I in ('wmic os get localdatetime /value') do set datetime=%%I
set datestamp=%datetime:~6,2%%datetime:~4,2%%datetime:~2,2%
set timestamp=%datetime:~8,2%%datetime:~10,2%%datetime:~12,2%
set foldername=%datestamp%_%timestamp%

:: Cria a pasta de destino
mkdir ..\..\..\Reports\%foldername%

:: Gera o relatório
allure generate allure-results --clean -o ..\..\..\Reports\%foldername%

pause