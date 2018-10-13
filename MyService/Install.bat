
cd /d %~dp0
@echo off
for /r %~dp0  %%i in (*.deps.json) do (   
     for /f "delims=. tokens=1" %%n in ("%%~ni") do ( 
	sc create %%n binPath= "%~dp0\%%n.exe"
	Net Start %%n
	sc config %%n start= auto
       )
)  
pause


cd /d %~dp0
@echo off
for /r %~dp0  %%c in (*.deps.json) do (  
echo %%a
 ::文件完整信息
    echo %%~dc 
::保留文件所在驱动器信息
    echo %%~pc
::保留文件所在路径信息
    echo %%~nc
::保留文件名信息
    echo %%~xc
::保留文件后缀信息
    echo %%~zc
::保留文件大小信息
    echo %%~tc
::保留文件修改时间信息
    echo %%~dpc 
::保留文件所在驱动器和所在路径信息
    echo %%~nxc
::保留文件名及后缀信息
    echo %%~pnxc 
::保留文件所在路径及文件名和后缀信息
    echo %%~dpnc 
::保留文件驱动器、路径、文件名信息
    echo %%~dpnxc 
::保留文件驱动器、路径、文件名、后缀信息
    echo %%~dpnxc 
)
pause


