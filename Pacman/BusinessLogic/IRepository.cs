using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;

namespace Pacman.BusinessLogic
{
	public interface IRepository
	{
		CrmEntity Fetch<T>();
		IList<CrmEntity> FetchList<T>();
	}
}
