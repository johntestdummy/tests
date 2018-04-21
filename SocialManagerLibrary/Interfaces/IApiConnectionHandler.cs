using System;
using System.Collections.Generic;
using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Entities.Twitter;

namespace SocialManagerLibrary.Providers
{
    public interface IApiConnectionHandler
    {
        List<Message> Search(Query query);
    }
}