using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Pacman.CrmPlumbing;

namespace Pacman.BusinessLogic
{
	public class Repository : IRepository
	{
		private readonly IOrganizationService _service;

		public Repository(IConfiguration configuration)
		{
			_service = OrganizationServiceManager.Instance(configuration);
		}

		public CrmEntity Fetch<T>()
		{
			var e = new CrmEntity(typeof(T).Name);

			return e;
		}

		public IList<CrmEntity> FetchList<T>()
		{
			var l = new List<T>();

			return (IList<CrmEntity>) l;
		}

	}
}
