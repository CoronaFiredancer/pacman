﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;

namespace Pacman.BusinessLogic
{
	public interface IRepository
	{
		Entity Fetch(JsonEntity entity, Guid guid);
		CrmEntity FetchType(string entityName, string[] attributes);
		IList<CrmEntity> FetchList<T>();
	}
}
