@if [%1]==[] goto skip
@if [%2]==[] goto skip
@if [%3]==[] goto skip
@if [%1]==[""] goto skip
@if [%2]==[""] goto skip
@if [%3]==[""] goto skip
@powershell .\signtool.ps1 "%1" "%2" "%3"
:skip