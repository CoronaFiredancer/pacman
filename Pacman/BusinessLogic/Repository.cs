using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Pacman.CrmPlumbing;

namespace Pacman.BusinessLogic
{
	public class Repository : IRepository
	{
		private readonly IOrganizationService _service;

		public Repository()
		{
			var configuration = Setup.GetConfiguration();

			_service = OrganizationServiceManager.Instance(configuration);
		}

		public Entity Fetch(string entityName)
		{
			var attributes = new ColumnSet("pa_name2");
			var entity = _service.Retrieve(entityName, new Guid("4B6AB95B-FF00-4D1A-8A6C-000AECDDB1BC"), attributes);

			return entity;
		}

		public CrmEntity FetchType(string entityName)
		{
			var e = new CrmEntity(entityName);

			return e;
		}

		public IList<CrmEntity> FetchList<T>()
		{
			var l = new List<T>();

			return (IList<CrmEntity>) l;
		}

	}
}
