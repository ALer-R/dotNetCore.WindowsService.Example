
cd /d %~dp0

@echo off
for /r %~dp0  %%i in (*.deps.json) do (   
     for /f "delims=. tokens=1" %%n in ("%%~ni") do ( 
	sc stop %%n
	sc delete %%n
       )
)  
pause
