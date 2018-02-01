using NLog;

namespace NugetExperiments.ClassLibrary.CommonInfrastructure
{
	public static class Logger
    {
		public static void Log(string message)
		{
			LogManager.GetCurrentClassLogger().Info(message);
		}
    }
}
