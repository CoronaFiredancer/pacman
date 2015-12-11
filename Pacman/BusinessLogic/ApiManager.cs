using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;

namespace Pacman.BusinessLogic
{
	public class ApiManager : IApiManager
	{
		private readonly IRepository _repository;
		public ApiManager(IRepository repository)
		{
			this._repository = repository;
		}

		public CrmEntity FetchEntityType(JsonEntity entity)
		{
			return _repository.FetchType(entity.EntityName, entity.Attributes);
		}

		public Entity FetchEntity(JsonEntity entity, Guid guid)
		{

			var crmentity = _repository.Fetch(entity, guid);

			return crmentity;
		}
	}
}
