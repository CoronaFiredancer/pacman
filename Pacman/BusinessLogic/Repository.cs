using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
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

		public Entity Fetch(JsonEntity jsonEntity, Guid guid)
		{
			var attributes = new ColumnSet(jsonEntity.Attributes);
			var entity = _service.Retrieve(jsonEntity.EntityName, guid, attributes);

			return entity;
		}

		public CrmEntity FetchType(string entityName, string[] attributes = null)
		{
			var e = new CrmEntity(entityName);
			
			RetrieveEntityRequest req = new RetrieveEntityRequest
			{
				EntityFilters = EntityFilters.Attributes,
				RetrieveAsIfPublished = true,
				LogicalName = entityName
			};

			var response = (RetrieveEntityResponse) _service.Execute(req);

			var attributeList = response.EntityMetadata.Attributes.ToList();
			List<AttributeMetadata> filteredList = new List<AttributeMetadata>();
			var list = attributes?.ToList();
			if (list != null)
			{
				filteredList = attributeList.Where(x => list.Any(y => y == x.LogicalName)).ToList();
			}

			var listCount = filteredList.Count;


			return e;
		}

		public IList<CrmEntity> FetchList<T>()
		{
			var l = new List<T>();

			return (IList<CrmEntity>) l;
		}

	}
}
