using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Providers
{
    public class ApiComm
    {
        /*
            Authorization: Basic eHZ6MWV2R ... o4OERSZHlPZw==
            Content-Type: application/x-www-form-urlencoded;charset=UTF-8
            Content-Length: 29
            Accept-Encoding: gzip

            grant_type=client_credentials

        */
        public Task<string> Post()
        {
            var endpoint = "https://api.twitter.com/oauth2/token";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic","OHU2NnJnN2lmelkzWDkwNkxlY21QNnNpSDpNZm9BTk9rWVJZYTJEQ1E0UTFwczZEMUJiN2FJNk1Qck11d2U4akxSTTc1NGtSbHdrNQ==");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            request.Content = new StringContent("{\"grant_type\":\"client_credentials\"}", Encoding.UTF8, "application/x-www-form-urlencoded");//CONTENT-TYPE header

            HttpResponseMessage response;
            client.SendAsync(request).ContinueWith(responseTask =>
            {
                return responseTask.Result;
            });

            return null;
        }

    }
}
