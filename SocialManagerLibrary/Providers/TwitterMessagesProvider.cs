using Newtonsoft.Json;
using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Entities.Tw;
using SocialManagerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialManagerLibrary.Providers
{
    public class TwitterMessagesProvider : IMessagesSearch
    {
        private IApiConnectionHandler _apiTwitter;

        public TwitterMessagesProvider(IApiConnectionHandler twitterApiConnectionHandler)
        {
            _apiTwitter = twitterApiConnectionHandler;
        }

        public IList<Message> GetLast(Query query)
        {
            return SearchTwitter(query);
        }

        private List<Message> SearchTwitter(Query query)
        {
            var response = new List<Message>();

            var responseString = _apiTwitter.Search(query);
            var tweets = (TweetsResponse)JsonConvert.DeserializeObject(responseString, typeof(TweetsResponse));

            response = tweets?.Statuses?.Select(x => new Message()
            {
                Author = x.User.Name,
                Text = x.Text
            }).ToList();

            return response;
        }

    }
}
