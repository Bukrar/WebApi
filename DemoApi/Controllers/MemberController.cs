using DemoApi.Models.Utility;
using DemoApi.Models.ViewModle;
using Jose;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoApi.Controllers
{
    public class MemberController : ApiController
    {
        private JwtLoginToken _jwtLoginToken = new JwtLoginToken();

        [HttpPost]
        public IHttpActionResult GenerateToken(LoginData loginData)
        {
            string token = _jwtLoginToken.Login(loginData);
            return Ok(token);
           // System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
        }
    }
}
