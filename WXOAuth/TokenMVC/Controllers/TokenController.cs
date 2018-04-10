using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TokenMVC.Controllers
{
    [Produces("application/json")]
    [Route("api/Token")]
    public class TokenController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            //var signature = Request.Query["signature"].ToString();
            //var timestamp = Request.Query["timestamp"].ToString();
            //var nonce = Request.Query["nonce"].ToString();
            // var echostr = Request.Query["echostr"].ToString();
            return "hello";
        }
    }
}