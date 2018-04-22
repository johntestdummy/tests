using System;
using System.Collections.Generic;
using SocialManagerLibrary.Entities;

namespace SocialManagerLibrary.Providers
{
    public interface IApiConnectionHandler
    {
        string Search(Query query);
    }
}