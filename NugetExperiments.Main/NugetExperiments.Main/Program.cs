using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Targets;
using NugetExperiments.ClassLibrary;

namespace NugetExperiments.Main
{
	class Program
	{
		static void Main(string[] args)
		{
			var target = new ConsoleTarget("console");
			LogManager.Configuration = new NLog.Config.LoggingConfiguration() {   };
			LogManager.Configuration.AddTarget(target);
			LogManager.Configuration.AddRule(LogLevel.Info, LogLevel.Fatal, target);
			Console.WriteLine(Person.SaySomething());
		}
	}
}
