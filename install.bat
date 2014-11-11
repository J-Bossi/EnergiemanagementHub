SET path=%~dp0

"%path%"\.nuget\NuGet.exe install OpenResKitHub
"%path%"\.nuget\NuGet.exe install OpenResKitHubConsole
"%path%"\.nuget\NuGet.exe install OpenResKit.Runtime


FOR /R "%path%" %%G IN (OpenResKit*.dll) DO (
copy "%%G" "%path%"\bin\
)
FOR /R "%path%" %%G IN (OpenResKit*.config) DO (
copy "%%G" "%path%"\bin\
)
FOR /R "%path%" %%G IN (OpenResKit*.exe) DO (
copy "%%G" "%path%"\bin\
)
FOR /D %%p IN ("%path%"\bin\*.*) DO rmdir "%%p" /s /q