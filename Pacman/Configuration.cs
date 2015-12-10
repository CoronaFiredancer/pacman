using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
	public class Configuration : IConfiguration
	{
		public string Crmorganization { get; set; }
		public string Crmserverurl { get; set; }
		public string Crmusername { get; set; }
		public string Crmpassword { get; set; }
		public string[] Entities { get; set; }
	}

	public interface IConfiguration
	{
		string Crmorganization { get; set; }
		string Crmserverurl { get; set; }
		string Crmusername { get; set; }
		string Crmpassword { get; set; }
		string[] Entities { get; set; }

	}
}
