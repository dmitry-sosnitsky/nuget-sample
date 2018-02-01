# NuGet sample

**Contents:**

 1. *NugetExperiments.ClassLibraries* - a class library project that can be stored on a custom nuget server
 2. *NugetExperiments.Main* - a console application that references NugetExperiments.ClassLibraries nuget package
 3. *upload-new-lib-version-to-nuget.bat* - a script to build a new version of NugetExperiments.ClassLibraries and upload it to a custom nuget server

**How to build and test *NugetExperiments.Main* locally:**

 1. Open NugetExperiments.Main.sln
 2. Add the following custom NuGet package source in VS settings: http://entech-nuget-server-sample.eastus.cloudapp.azure.com/api/odata
 3. Build and launch the app
 4. You can explore and change versions of *NugetExperiments.ClassLibraries*  library using VS Package Manager

**How to make a new *NugetExperiments.ClassLibraries*  package version:**

 1. Make some changes in *NugetExperiments.ClassLibraries* project
 2. Run upload-new-lib-version-to-nuget.bat (in production this would be run on build server)
 3. Go to NuGet server web UI to verify that the new version was uploaded successfully: http://entech-nuget-server-sample.eastus.cloudapp.azure.com/packages/list
 4. Open NugetExperiments.Main.sln, update *NugetExperiments.ClassLibraries* package to the latest version and verify that the new referenced version has the changes made earlier
