del *.nupkg
del *.nuspec
del NugetExperiments.ClassLibraries\NugetExperiments.ClassLibrary\*.nuspec

nuget.exe restore NugetExperiments.ClassLibraries\NugetExperiments.ClassLibraries.sln

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe NugetExperiments.ClassLibraries\NugetExperiments.ClassLibrary\NugetExperiments.ClassLibrary.csproj /t:rebuild 

cd NugetExperiments.ClassLibraries\NugetExperiments.ClassLibrary

nuget spec

cd ../..

nuget pack NugetExperiments.ClassLibraries\NugetExperiments.ClassLibrary\NugetExperiments.ClassLibrary.csproj -IncludeReferencedProjects

nuget push -Source http://entech-nuget-server-sample.eastus.cloudapp.azure.com/api/odata  *.nupkg

del *.nupkg
del *.nuspec
del NugetExperiments.ClassLibraries\NugetExperiments.ClassLibrary\*.nuspec