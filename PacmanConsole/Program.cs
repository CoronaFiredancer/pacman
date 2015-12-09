using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Pacman;
using Pacman.Readers;

namespace PacmanConsole
{
	class Program
	{
		private static IContainer Container { get; set; }

		static void Main(string[] args)
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<ConfigurationReader>().As<IConfigurationReader>();

			Container = builder.Build();

			var x = GetConfiguration();

			Console.ReadKey();
		}

		public static Configuration GetConfiguration()
		{
			using (var scope = Container.BeginLifetimeScope())
			{
				var configReader = scope.Resolve<IConfigurationReader>();

				return configReader.Read();
			}
		}
	}
}
