using LearnHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace LearnHub.API.Helpers
{
    public class APIBase : ApiController
    {
        public HttpResponseMessage response { get; set; }

        protected HttpResponseMessage CreateResponse(HttpStatusCode httpStatus, object val)
        {
            return Request.CreateResponse(httpStatus, val);
        }
    }
}