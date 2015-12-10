using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Pacman;
using Pacman.CrmPlumbing;
using Pacman.Readers;

namespace PacmanConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Setup.SetItUp();

			var x = Setup.GetConfiguration();

			var y = OrganizationServiceManager.Instance(x);

			Console.ReadKey();
		}
	}
}
