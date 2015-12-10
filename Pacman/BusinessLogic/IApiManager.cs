using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;

namespace Pacman.BusinessLogic
{
	public interface IApiManager
	{
		CrmEntity FetchEntityType(string entityName);
		Entity FetchEntity(string entityName);
	}
}