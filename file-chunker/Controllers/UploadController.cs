using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace file_chunker.Controllers
{
    public class UploadController : ApiController
    {
        public IHttpActionResult Index()
        {
            return Ok("index");
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var result = string.Format("The number was...{0}", id);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReceiveFile(string id)
        {
            var result = string.Format("The number was...{0}", id);
            return Ok(result);
        }
    }
}
