using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShabzLock.Model;

namespace ShabzLock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private static List<Log> LogList = new List<Log>()
        {
            new Log("Rasmus Dolmer", DateTime.Now, "Lock"),
            new Log("Rasmus Dolmer", DateTime.Now, "Unlocked"),
            new Log("Rasmus Dolmer", DateTime.Now, "Unlocked"),
            new Log("Rasmus Dolmer", DateTime.Now, "Lock"),
        };

        // GET api/log
        [HttpGet]
        public List<Log> Get()
        {
            if (LogList != null)
            {
                return LogList;
            }

            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
