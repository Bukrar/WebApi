using DemoApi.Models.Utility;
using DemoApi.Models.ViewModle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoApi.Controllers
{
    public class LoginController : ApiController
    {
        private JwtLoginToken _jwtLoginToken = new JwtLoginToken();

        [HttpPost]
        [EnableCors(origins: "http://localhost:83,http://localhost:4200", headers: "*", methods: "*")]
        public IHttpActionResult GenerateToken(LoginData loginData)
        {
            string token = _jwtLoginToken.Login(loginData);
            return Ok(token);
            // System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
        }
    }
}
