using NugetExperiments.ClassLibrary.CommonInfrastructure;

namespace NugetExperiments.ClassLibrary
{
	public static class Person
    {
		public static string SaySomething()
		{
			Logger.Log("SaySomething() called");
			return "This is my version with logging through dependent csproj";
		}
    }
}
