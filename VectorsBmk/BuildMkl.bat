:: The script requires Admin permissions

set funcs_path=%~dp0Experimental.Mkl.Functions.txt
set dir_path=%~dp0mkl
set dll_name=%dir_path%\Experimental.Mkl

if not exist "%dir_path%" mkdir "%dir_path%"

:: Source Visual Studio environment variables for Intel MKL Builder v2019.1.144
cd   "C:\Program Files (x86)\IntelSWTools\compilers_and_libraries_2019.1.144\windows\mkl\tools\builder" 
call "..\..\bin\compilervars.bat" intel64 vs2017

:: Run custom dll builder script
nmake libintel64 interface=cdecl export="%funcs_path%" name="%dll_name%" manifest=embed