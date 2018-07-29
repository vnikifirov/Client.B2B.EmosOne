using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emos2.Infrastructure.Entities;
using System.Net.Http;
using System.Net;

namespace Emos2.Services
{
    public class LoginService : ILoginService
    {

        #region Private methods

        private FormUrlEncodedContent GenerateLoginContent(string username, string password, string clientCode)
        {
            List<KeyValuePair<string, string>> requestParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("client_id", clientCode)
            };

            return new FormUrlEncodedContent(requestParameters);
        }

        private FormUrlEncodedContent GenerateLoginRefreshContent(string refreshToken, string clientId)
        {
            List<KeyValuePair<string, string>> requestParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("refresh_token", refreshToken),
                new KeyValuePair<string, string>("client_id", clientId)
            };

            return new FormUrlEncodedContent(requestParameters);
        }

        private TokenData GenerateTokenData(HttpResponseMessage response)
        {
            TokenData tokenData;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic responseData = response.Content.ReadAsAsync<object>().Result;

                tokenData = new TokenData()
                {
                    AccessToken = responseData.access_token,
                    RefreshToken = responseData.refresh_token,
                    ClientId = responseData.client_id,
                    Issued = responseData[".issued"],
                    Expires = responseData[".expires"],
                    TokenType = responseData.token_type,
                    ExpiresInSeconds = responseData.expires_in,
                    IsValidUser = true
                };
            }
            else
            {
                dynamic responseErrorData = response.Content.ReadAsAsync<object>().Result;

                tokenData = new TokenData()
                {
                    IsValidUser = false,
                    Error = responseErrorData.error_description
                };
            }

            return tokenData;
        }

        #endregion

        #region ILoginService implementations

        public TokenData LogIn(string tokenServiceUrl, string username, string password, string clientCode)
        {
            using (HttpClient client = new HttpClient())
            {
                FormUrlEncodedContent loginContent = this.GenerateLoginContent(username, password, clientCode);
                HttpResponseMessage response = client.PostAsync(tokenServiceUrl, loginContent).Result;

                return this.GenerateTokenData(response);
            }
        }

        public TokenData LogInRefresh(string tokenServiceUrl, string refreshToken, string clientid)
        {
            using (HttpClient client = new HttpClient())
            {
                FormUrlEncodedContent loginRefreshContent = this.GenerateLoginRefreshContent(refreshToken, clientid);
                HttpResponseMessage response = client.PostAsync(tokenServiceUrl, loginRefreshContent).Result;

                return this.GenerateTokenData(response);
            }
        }

        #endregion
    }
}
