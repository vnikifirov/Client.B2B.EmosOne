using Emos2.API.Attributes;
using Emos2.API.Models;
using Emos2.API.Models.Users.Login;
using Emos2.Infrastructure.Entities;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Emos2.API.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        //[ValidateModelStateFilter]
        public HttpResponseMessage Login(LoginModel loginData)
        {
            string tokenServiceUrl = this.Request.RequestUri.GetLeftPart(UriPartial.Authority) + System.Configuration.ConfigurationManager.AppSettings["TokenUrlPath"];
            TokenData tokenData = this.loginService.LogIn(tokenServiceUrl, loginData.Username, loginData.Password, loginData.ClientCode);
            HttpResponseMessage response;

            if (tokenData.IsValidUser)
            {
                response = this.Request.CreateResponse(HttpStatusCode.OK, tokenData);
            }
            else
            {
                ErrorModel errorModel = new ErrorModel
                {
                    Title = "Login failed",
                    Description = tokenData.Error
                };

                response = this.Request.CreateResponse(HttpStatusCode.BadRequest, errorModel);
            }

            return response;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login/refresh")]
        [ValidateModelStateFilter]
        public HttpResponseMessage RefreshLoginData(LoginRefreshModel loginRefreshData)
        {
            string tokenServiceUrl = this.Request.RequestUri.GetLeftPart(UriPartial.Authority) + System.Configuration.ConfigurationManager.AppSettings["TokenUrlPath"];
            TokenData tokenData = this.loginService.LogInRefresh(tokenServiceUrl, loginRefreshData.RefresToken, loginRefreshData.ClientId);
            HttpResponseMessage response;

            if (tokenData.IsValidUser)
            {
                response = this.Request.CreateResponse(HttpStatusCode.OK, tokenData);
            }
            else
            {
                ErrorModel errorModel = new ErrorModel
                {
                    Title = "Login failed",
                    Description = tokenData.Error
                };


                response = this.Request.CreateResponse(HttpStatusCode.BadRequest, errorModel);
            }

            return response;
        }


      

    }
}
