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

		public CrmEntity FetchEntityType(string entityName)
		{
			return _repository.FetchType(entityName);
		}

		public Entity FetchEntity(string entityName)
		{

			var entity = _repository.Fetch(entityName);

			return entity;
		}
	}
}
