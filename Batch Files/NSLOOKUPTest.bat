nslookup AWG70002PQ001
ping -4 AWG70002PQ001
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG70002Q018
ping -4 AWG70002Q018
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG70001Q011
ping -4 AWG70001Q011 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG70002Q004
ping -4 AWG70002Q004 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG70001PQ004
ping -4 AWG70001PQ004 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG7082CQ010001
ping -4 AWG7082CQ010001
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG5014CQ010001
ping -4 AWG5014CQ010001 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG5012CQ010002
ping -4 AWG5012CQ010002 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup AWG7122CKR10001
ping -4 AWG7122CKR10001 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup CSA8000BB010330
ping -4 CSA8000BB010330 
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup PC-BEAV-1081
ping -4 PC-BEAV-1081 
@echo
@echo off
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

nslookup W-E126419-W7
ping -4 W-E126419-W7 
@echo. 
@choice /n /c:YN /M "Do the IPV4 addresses match(Y/N)?"%1
if errorlevel ==2 goto callperry
echo on
cls

goto quit

:callperry
@echo. 
@echo Uh-Oh, that's not good. Copy this screen output and send it to Perry.
pause
:quit