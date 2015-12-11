using System;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;

namespace Pacman.BusinessLogic
{
	public interface IApiManager
	{
		CrmEntity FetchEntityType(JsonEntity entityName);
		Entity FetchEntity(JsonEntity entity, Guid guid);
	}
}