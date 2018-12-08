using System.Collections.Generic;
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

        public string Get(int id)
        {
            return strings[id];
        }

        public void Post(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
