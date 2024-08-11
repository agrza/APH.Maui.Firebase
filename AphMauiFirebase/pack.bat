@echo off
call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsMSBuildCmd.bat"

set ROOT=%~p0
cd %ROOT%

echo ======================================================================
echo  Working directory is %ROOT%
echo ======================================================================

echo ======================================================================
echo  Clean up before compiling
echo ======================================================================
dotnet restore AphMauiFirebase.sln --verbosity:minimal

echo ======================================================================
echo  Deleting build folders
echo ======================================================================
rmdir Packages /s /q

rmdir Core\bin /s /q
rmdir Core\obj /s /q

rmdir Bundled\bin /s /q
rmdir Bundled\obj /s /q

rmdir Features\Analytics\bin /s /q
rmdir Features\Analytics\obj /s /q

rmdir Features\Auth\bin /s /q
rmdir Features\Auth\obj /s /q

rmdir Features\CloudMessaging\bin /s /q
rmdir Features\CloudMessaging\obj /s /q

rmdir Features\Crashlytics\bin /s /q
rmdir Features\Crashlytics\obj /s /q

echo ======================================================================
echo  Folders Deleted
echo ======================================================================


REM verbosity can be: Quiet | Normal | Minimal | Diagnostic | Detailed
set BUILD_OPTS=--verbosity:Quiet

echo ======================================================================
echo  Restore nuget packages
echo ======================================================================
msbuild -t:restore %BUILD_OPTS%

echo ======================================================================
echo  Build NuGet Package
echo ======================================================================
msbuild AphMauiFirebase.sln %BUILD_OPTS% /p:Configuration=Release /p:VersionPrefix=1.0.0.1

SET COMPILATION_ERRORLEVEL=%ERRORLEVEL%
echo ======================================================================
echo  Show compilation results and return release build errorlevel
echo ======================================================================
@REM Create folder to put packages inside
mkdir Packages
@REM copy all packages in folder
copy Core\bin\Release\*.nupkg Packages /y
copy Features\Analytics\bin\Release\*.nupkg Packages /y
copy Features\Auth\bin\Release\*.nupkg Packages /y
copy Features\CloudMessaging\bin\Release\*.nupkg Packages /y
copy Features\Crashlytics\bin\Release\*.nupkg Packages /y
@REM Open packages folder
cd Packages
start.
cd %ROOT%
exit /b %COMPILATION_ERRORLEVEL%
:end
 


