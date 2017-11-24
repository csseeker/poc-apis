using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POCAPIs.Controllers
{
    // [Authorize]
    public class HelloController : ApiController
    {
        [HttpGet]
        public IHttpActionResult SayHello(string user = "Stranger")
        {
            return Ok($"Hello, {user}!");
        }
    }
}
