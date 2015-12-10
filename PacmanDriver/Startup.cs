using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Pacman;

[assembly: OwinStartup(typeof(PacmanDriver.Startup))]

namespace PacmanDriver
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);

			Setup.SetItUp();

			var config = Setup.GetConfiguration();

		}
	}
}
