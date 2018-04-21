using SocialManagerLibrary.Constants;
using SocialManagerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using SocialManagerLibrary.Helpers;
using SocialManagerLibrary.Entities.Tw;

namespace SocialManagerLibrary.Providers
{
    public class TwitterApiConnectionHandler : IApiConnectionHandler
    {
        private IConfigurationProvider _configuration;

        public TwitterApiConnectionHandler(IConfigurationProvider configuration)
        {
            _configuration = configuration;
        }
        
        public List<Message> Search(Query query)
        {
            var response = new List<Message>();

            var twResponse = SearchTwitter(query);
            response = twResponse?.Statuses?.Select(x => new Message()
            {
                Author = x.User.Name,
                Text = x.Text
            }).ToList();

            return response;
        }

        private TweetsResponse SearchTwitter(Query query)
        {
            using (var client = new HttpClient())
            {
                var parameters = GetSearchQueryParams(query);
                var apiUrl = UrlHelper.GetUri(_configuration.GetValue<string>(ConfigKeys.TWITTER_API_URI_SEARCH), parameters);

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer { _configuration.GetValue<string>(ConfigKeys.OAUTH_TOKEN_SECRET) }");

                var response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    return (TweetsResponse)JsonConvert.DeserializeObject(responseString, typeof(TweetsResponse));
                }
            }
            return null;
        }

        private Dictionary<string, string> GetSearchQueryParams(Query query)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("q", query.Term);
            parameters.Add("count", query.Count.ToString());
            parameters.Add("lang", "es");
            parameters.Add("include_entities", "false");
            return parameters;
        }

        private string GetOAuth1Authorization()
        {
            var oauth = new StringBuilder("OAuth")
                .Append(" oauth_consumer_key='consumer-key-for-app'")
                .Append(", oauth_nonce = 'generated-nonce'")
                .Append(", oauth_signature = 'generated-signature'")
                .Append(", oauth_signature_method = 'HMAC-SHA1'")
                .Append(", oauth_timestamp = 'generated-timestamp'")
                .Append(", oauth_token = 'access-token-for-authed-user'")
                .Append(", oauth_version = '1.0'");
            return oauth.ToString();
        }
    }
}
