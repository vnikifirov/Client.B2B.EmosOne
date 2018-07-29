using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Emos2.API.Controllers
{
    public class TestController : ApiController
    {
        // GET: Test
        [HttpGet]
        [AllowAnonymous]
        [Route("test/test")]
        public string Test()
        {
            return "test/test success";
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("test")]
        public string Index()
        {
            return "test success";
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("test1")]
        public HttpResponseMessage Test1()
        {
            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK, "ok...");
            return response;
        }
    }
}