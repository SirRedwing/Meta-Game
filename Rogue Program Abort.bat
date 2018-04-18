@echo off
set /p appName="Enter rogue program name: "
echo Shutting down rogue program...
timeout /t 3 /nobreak > nul
TASKKILL /F /IM %appName% > nul
echo Command execution complete.
pause