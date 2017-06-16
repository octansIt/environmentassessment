strRelease = WScript.Arguments(0)
strProject = WScript.Arguments(1)

Sub Run(param)
	WScript.Echo param
	objShell.Run param, 0, True
End Sub

Set objShell = WScript.CreateObject ("WScript.Shell")

WScript.Echo "[Embedded Resources] Updating included Assembly resources to match 'EnvironmentAssessment.Report'"

WScript.Echo "[Embedded Resources] Cleaning up resource temp directory."
Run "cmd /c ""del """ + strProject + "\Includes\resources.tar"" /q"
Run "cmd /c ""del """ + strProject + "\Includes\resources.lzma"" /q"
Run "cmd /c ""del """ + strProject + "\Includes\resources\*.svg"""
Run "cmd /c ""del """ + strProject + "\Includes\resources\*.js"""

WScript.Echo "[Embedded Resources] Updating LZMA TAR file to included latest resources."

Run "cmd /c ""cd """ + strProject + "\Includes"" && ..\..\.build\tar.exe -cvf resources.tar -C resources/ ."""
Run "cmd /c ""cd """ + strProject + "\Includes"" && ..\..\.build\lzma.exe e resources.tar resources.lzma"""

WScript.Echo "[Embedded Resources] Complete."
WScript.Echo ""