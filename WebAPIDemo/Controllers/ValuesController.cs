using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>()
        {
            "value0", "value1", "value2"
        };

        public IEnumerable<string> Get()
        {
            return strings;
        }

         
    }
}
