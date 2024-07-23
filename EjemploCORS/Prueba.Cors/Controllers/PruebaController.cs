using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Prueba.Cors.Controllers
{
    [RoutePrefix("api")]
   // [EnableCors(origins: "https://localhost:44372", headers: "*", methods: "*")]
    public class PruebaController : ApiController
    {
        //curl -i -X GET https://localhost:44380/api/prueba -H "Origin: https://example.com"
        [HttpGet]
        [Route("prueba")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
