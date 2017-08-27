Param(
   [string]$build,
   [string]$project,
   [string]$product
)

Write-Host "[Code Signing] Signing executable $($project)\bin\$($build)."
$build_dir = "$($project)\bin\$($build)"
$version = ([System.Diagnostics.FileVersionInfo]::GetVersionInfo("$build_dir\$product.exe")).FileVersion

$reader = [System.IO.File]::OpenText("$($project)\codesigning.pwd")
$signpwd = ""
while($null -ne ($line = $reader.ReadLine())) {
    $signpwd = $line
}
$signtool = "C:\Program Files (x86)\Microsoft SDKs\Windows\v7.1A\Bin\signtool.exe"
$signcmd = "sign /f ""$($project)\codesigning.pfx"" /p $($signpwd) /t http://timestamp.comodoca.com/authenticode ""$($build_dir)\$($product).exe"""
Write-Host "Start-Process -file $($signtool) -argumentlist $($signcmd) -passthru -workingdirectory $($build_dir) | wait-process"
Start-Process -file $signtool -argumentlist $signcmd -passthru -workingdirectory $build_dir | wait-process