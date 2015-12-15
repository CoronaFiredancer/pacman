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
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(Guid id)
		{
			//Setup.SetItUp();

			var configuration = Setup.Configuration;

			var manager = Setup.Container.Resolve<IApiManager>();

			var x = configuration.Entities[0];


			var a = manager.FetchEntityType(x);




			var entity = manager.FetchEntity(x, new Guid("4B6AB95B-FF00-4D1A-8A6C-000AECDDB1BC"));

			return entity.LogicalName;
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
