Param(
   [string]$build,
   [string]$project,
   [string]$product
)

$build_dir ="$($project)\bin\$($build)"
$version = ([System.Diagnostics.FileVersionInfo]::GetVersionInfo("$build_dir\$product.exe")).FileVersion
$zipfile = "$build_dir\$product-$($build.toLower())-$version.zip"
$dropbox_dir = "C:\Users\johan\Dropbox\Public\ea"

Write-Host "[Project Publishing] Updating published assembly to $dropbox_dir."

Write-Host "[Project Publishing] Cleaning up resource temp directory."
Remove-Item -Force "$zipfile"
New-Item "$build_dir\temp" -type directory | out-null
Copy-Item "$($build_dir)\$($product).exe" "$($build_dir)\temp"

Write-Host "[Project Publishing] Creating $zipfile..."

Add-Type -A System.IO.Compression.FileSystem
[IO.Compression.ZipFile]::CreateFromDirectory("$build_dir\temp", $zipfile, [System.IO.Compression.CompressionLevel]::Optimal, $false)
Remove-Item -Recurse -Force "$build_dir\temp"

Write-Host "[Project Publishing] Uploading to $dropbox_dir..."
Copy-Item -Force "$zipfile" "$dropbox_dir"
Remove-Item -Force "$zipfile"

Write-Host "[Project Publishing] Complete."
Write-Host ""