@if [%1]==[] goto skip
@if [%2]==[] goto skip
@if [%1]==[""] goto skip
@if [%2]==[""] goto skip
@"c:\Program Files (x86)\SmartGitHg\git\bin\sh.exe" --login -i -c "git describe > version.txt"
@cscript /nologo version.vbs "%1" "%2"
:skip
