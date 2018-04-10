using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheckToken.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var signature = Request.Query["signature"].ToString();
            var timestamp = Request.Query["timestamp"].ToString();
            var nonce = Request.Query["nonce"].ToString();
            var echostr = Request.Query["echostr"].ToString();
            return echostr;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var a = Request.ContentLength;
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
