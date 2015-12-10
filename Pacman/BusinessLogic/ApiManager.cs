using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;

namespace Pacman.BusinessLogic
{
	public class ApiManager : IApiManager
	{
		private readonly IRepository _repository;
		public ApiManager(IRepository repository)
		{
			this._repository = repository;
		}

		public CrmEntity FetchEntity<T>()
		{
			return _repository.Fetch<T>();
		}
	}
}
