using DemoApi.Models.ViewModle;
using Jose;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;

namespace DemoApi.Models.Utility
{
    public class JwtLoginToken
    {
        public string Login(LoginData loginData)
        {
            string secret = ConfigurationManager.AppSettings["secret"];
            if (loginData.Account == "Igor" && loginData.Password == "123")
            {
                var payload = new JwtAuthObject()
                {
                    Id = 1,
                    Name = "account"
                };
                var token = Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS256);
                return token;
            }
            else
            {
                throw new UnauthorizedAccessException("帳號密碼錯誤");
            }
        }
    }
}