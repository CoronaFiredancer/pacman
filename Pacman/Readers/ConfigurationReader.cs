using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pacman.Readers;

namespace Pacman
{
	public class ConfigurationReader : IConfigurationReader
	{
		public Configuration Read()
		{
			var exectutingPath = AssemblyDirectory;
			var fileName = "Configuration2.json";
			var path = Path.Combine(exectutingPath, fileName);

			var text = File.ReadAllText(path);

			var configuration = JsonConvert.DeserializeObject<Configuration>(text);

			return configuration;
		}

		public static string AssemblyDirectory
		{
			get
			{
				var codeBase = Assembly.GetExecutingAssembly().CodeBase;
				var uri = new UriBuilder(codeBase);
				var path = Uri.UnescapeDataString(uri.Path);
				return Path.GetDirectoryName(path);
			}
		}
	}
}
