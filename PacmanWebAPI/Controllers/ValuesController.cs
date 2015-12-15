using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Autofac;
using Pacman;
using Pacman.BusinessLogic;

namespace PacmanWebAPI.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values/5
		public IHttpActionResult Get(Guid id)
		{
			var configuration = Setup.Configuration;

			var manager = Setup.Container.Resolve<IApiManager>();

			var jsonEntity = configuration.Entities.First(x => x.EntityName == "account");

			var entity = manager.FetchEntity(jsonEntity, id);

			return Ok(entity);
		}

		public IHttpActionResult Get()
		{
			var configuration = Setup.Configuration;

			var manager = Setup.Container.Resolve<IApiManager>();

			var jsonEntity = configuration.Entities.First(x => x.EntityName == "account");

			var a = manager.FetchEntityType(jsonEntity);

			return Ok(a);
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
