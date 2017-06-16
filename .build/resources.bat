@if [%1]==[] goto skip
@if [%2]==[] goto skip
@if [%1]==[""] goto skip
@if [%2]==[""] goto skip
@cscript /nologo resources.vbs "%1" "%2"
:skip