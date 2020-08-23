using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace LearnHub.API.Controllers
{
    public class HomeController : ApiController
    {
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Index()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("<h1>Your welcome :)</h1>", Encoding.UTF8,"text/html"),
                StatusCode=HttpStatusCode.OK
            };
        }
    }
}
