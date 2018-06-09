sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2016 -i MigradoDeDatos.sql  -a 32767 -o resultado_output.txt

REM echo msgbox "Ya termino la migracion... En caso de que anteriormente haya realizado algunas pruebas, recuerde cambiar la fecha del aplicativo al 01/JUNIO/2016." > %tmp%\tmp.vbs
REM cscript /nologo %tmp%\tmp.vbs
REM del %tmp%\tmp.vbs