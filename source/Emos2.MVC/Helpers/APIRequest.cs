using Emos2.MVC.Models.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Web;

namespace Emos2.MVC.Helpers
{
    public class APIRequest
    {

        string url = System.Configuration.ConfigurationManager.AppSettings["apiURL"]; 
        HttpWebRequest _request;
        public bool isAuthorized = false;
        public ResponseModel responseModel;


        public APIRequest(string method)
        {
            _request = WebRequest.Create(url + method) as HttpWebRequest;
            string accessToken = GetUserAccessToken();
            if (!string.IsNullOrEmpty(accessToken))
            {
                isAuthorized = true;
            }
            this.responseModel = new ResponseModel();
            _request.Headers["Authorization"] = "Bearer " + accessToken;
            _request.Headers["ClientCode"] = AppHelper.ClientCode(); 
        }

        public string Get()
        {
            _request.Method = "GET";
            return getResponse(_request);
        }

        public string Put(object body)
        {
            _request.Method = "PUT";

            var json = JsonConvert.SerializeObject(body);

            byte[] dataBytes = UTF8Encoding.UTF8.GetBytes(json);
            _request.ContentType = "application/json";
            _request.ContentLength = dataBytes.Length;

            using (Stream postStream = _request.GetRequestStream())
            {
                postStream.Write(dataBytes, 0, dataBytes.Length);
            }


            return getResponse(_request);
        }

        public string Delete()
        {
            _request.Method = "DELETE";
            return getResponse(_request);
        }

        public string Post(object body)
        {
            _request.Method = "POST";

            var json = JsonConvert.SerializeObject(body);

            byte[] dataBytes = UTF8Encoding.UTF8.GetBytes(json);
            _request.ContentType = "application/json";
            _request.ContentLength = dataBytes.Length;

            using (Stream postStream = _request.GetRequestStream())
            {
                postStream.Write(dataBytes, 0, dataBytes.Length);
            }

            return getResponse(_request);
        }


        #region " add access token to request and get response methods " 

        private string getResponse(HttpWebRequest _request)
        {

            string result = "";
            try
            {
               
                using (var response = _request.GetResponse() as HttpWebResponse)
                {
                    if (_request.HaveResponse && response != null)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            
                             result = reader.ReadToEnd();
                             responseModel.Data = result;
                             responseModel.IsSuccess = true;

                        }

                    }

                }

               
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {

                            result  = reader.ReadToEnd();
                            responseModel.Data = result;
                            responseModel.IsSuccess = false;
                           
                        }
                    }
                }
            }

            return result;

         
        }

        private string GetUserAccessToken()
        {
            string accessToken = string.Empty;
            IPrincipal user = System.Web.HttpContext.Current.User;

            ClaimsIdentity userIdentity = user.Identity as ClaimsIdentity;
         
            if (userIdentity != null)
            {
                if (userIdentity.Claims.Any(c => c.Type.Equals("AccessToken")))
                {
                    Claim accessTokenClaim = userIdentity.Claims.FirstOrDefault(c => c.Type.Equals("AccessToken"));

                    if (accessTokenClaim != null)
                    {
                        accessToken = accessTokenClaim.Value;
                    }
                }
                //else
                //{

                //    accessToken = setAccessTokenFromAPI(user);
                //}
            }
            return accessToken;
        }

        #endregion
    }
}