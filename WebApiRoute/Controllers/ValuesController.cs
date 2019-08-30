using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRoute.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("Api/Values/{filter:string}/contendo")]
        [HttpGet]
        public IEnumerable<string> ObterContendo(string filter)
        {
            var listInfo = new List<string>()
            {
                "Contem 1",
                "Contem 1.2.1",
                "Contem 1.2.2",
                "Contem 1.3.1",
                "Contem 1.3.2",
                "Contem 1.5",
            };
            return listInfo.Where(x => x.Contains(filter));
        }
        [NonAction]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
