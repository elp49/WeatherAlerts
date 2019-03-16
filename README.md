# WeatherAlerts

WeatherAlerts is a program designed to allow a university to notify students,
faculty, and staff of class cancellations; it is a solution to the problem
described below.

A local university is designing a system for weather-alert notification that
allows students, faculty, and staff to receive notifications of class
cancellations (due to weather) via e-mail, voice call, or SMS text messages.
Other methods of notification may be added in the future. The system is based on
the weather data decision engine that interfaces with several weather-related
data sources, fuses the information, and automatically decides whether class
cancellations are in effect. The university is interested in integrating the
existing communication services (i.e., e-mail, SMS, and voice) with the decision
engine so that these services can be triggered to initiate notification via
their respective communication types. The design must be flexible so that other
types of communication mechanisms can be added to the system in the future.

## Usage

You may run the program using an IDE like Visual Studio or by running the
provided batch file "RunWeatherAlerts.bat". The batch script will compile and
execute the program, and then delete the outputted executable file.

Note: The batch file uses "C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc" to
compile the program. If this compiler is not on your machine, you may use
another version to compile or download the full Microsoft .NET Framework 4 here
at https://www.microsoft.com/en-us/download/details.aspx?id=17851.