using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;

namespace Pacman.CrmPlumbing
{
	public class OrganizationServiceManager
	{
		private static IOrganizationService _instance;

		public static IOrganizationService Instance(IConfiguration configuration)
		{
			if (_instance == null)
			{
				var connectionstring =$"Url={configuration.Crmserverurl}; Username={configuration.Crmusername}; Password={configuration.Crmpassword};";
				var connection = CrmConnection.Parse(connectionstring);

				var organizationService = Setup.Container.Resolve<IOrganizationService>(new NamedParameter("connection", connection));
				_instance = organizationService;
			}
			return _instance;
		}
	}
}
