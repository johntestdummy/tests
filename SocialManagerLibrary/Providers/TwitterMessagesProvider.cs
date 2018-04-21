using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Interfaces;
using System;
using System.Collections.Generic;

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
            return _apiTwitter.Search(query);
        }
        
    }
}
