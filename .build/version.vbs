strRelease = WScript.Arguments(0)
strProject = WScript.Arguments(1)

Set objFSO = CreateObject("Scripting.FileSystemObject")
Set assemblyFile = objFSO.OpenTextFile(strProject + "\Properties\AssemblyInfo.cs", 1)
strContents = assemblyFile.ReadAll
assemblyFile.Close
arrLines = Split(strContents, vbCrLf)

objFSO.CopyFile strProject + "\Properties\AssemblyInfo.cs", strProject + "\Properties\AssemblyInfo.cs.bak", true

Set assemblyFile = objFSO.OpenTextFile(strProject + "\Properties\AssemblyInfo.cs", 2)
For i = 0 to UBound(arrLines) - 4
	assemblyFile.WriteLine(arrLines(i))
Next

Set versionFile = objFSO.OpenTextFile("version.txt",1)
strVersion = versionFile.ReadLine()

WScript.Echo "[Version Information] Updating Assembly information to match Git version: " + strVersion
WScript.Echo ""

dtNow = now()
verDate = (Year(dtNow)) & Padding( Month(dtNow)) & Padding(Day(dtNow)) 'Padding(Hour(dtNow)) & Padding( Minute(dtNow)) & Padding( second(dtNow))

cleanVersion = Replace(strVersion,"v","")
verMaj = Split(Split(cleanVersion,"-")(0),".")(0)
verMin = Split(Split(cleanVersion,"-")(0),".")(1)
verBuild = Split(cleanVersion,"-")(1)
verHash = Split(cleanVersion,"-")(2)
buildType = LCase(strRelease)

assemblyFile.WriteLine("[assembly: AssemblyFileVersion(""" + verMaj + "." + verMin + ".0." + verBuild + """)]")
assemblyFile.WriteLine("[assembly: AssemblyVersion(""" + verMaj + "." + verMin + ".0." + verBuild + """)]")
asmblInfoVersion = "[assembly: AssemblyInformationalVersion(""" & verMaj & "." + verMin & ".0." & verBuild & "." & verDate & "-" & buildType & "-" & verHash & """" & ")]"
assemblyFile.WriteLine(asmblInfoVersion)
assemblyFile.Close

Function Padding (testIn)
 Select Case Len(testIn) < 2
   CASE TRUE
     Padding = "0" & testIn
   Case Else
     Padding = testIn
  End Select
End Function