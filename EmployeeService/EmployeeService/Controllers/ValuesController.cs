using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> Names = new List<string>()
        {
            "Akhil","Barry","Cameron"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return Names;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return Names[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            Names.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            Names[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Names.RemoveAt(id);
        }
    }
}
