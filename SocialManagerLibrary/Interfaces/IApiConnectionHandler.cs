using System;
using System.Collections.Generic;
using SocialManagerLibrary.Entities;

namespace SocialManagerLibrary.Providers
{
    public interface IApiConnectionHandler
    {
        List<Message> Search(Query query);
    }
}