@echo off
echo Restarting IIS to apply new deployment...
iisreset /restart
echo IIS has been restarted. Your application should now be accessible.
