using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2","value3", "value4","value5" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            if(id > 0 && id < 5)
            {
              return "Small Value"
            }
            else if(id > 5 && id < 10)
            {
                return "Medium value";
            }
            
            return "value1290";
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
