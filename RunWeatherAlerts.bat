ECHO OFF
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -out:.\WeatherAlerts.exe .\Client.cs .\WeatherAlerts.cs
.\WeatherAlerts.exe
del .\WeatherAlerts.exe
PAUSE