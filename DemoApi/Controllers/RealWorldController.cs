using DemoApi.Models;
using DemoApi.Models.Services;
using DemoApi.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoApi.Controllers
{
    public class RealWorldController : ApiController
    {
        private RealWorldService _realWordService = new RealWorldService();

        [JwtAuthActionFilter]
        [HttpGet]
        [EnableCors(origins: "http://localhost:83", headers: "*", methods: "*")]
        public IHttpActionResult GetAll()
        {          
            var rs = _realWordService.GetAll();
            return Ok(rs);
        }
    }
}