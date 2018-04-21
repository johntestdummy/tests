﻿namespace SocialManagerLibrary.Providers
{
    public interface IConfigurationProvider
    {
        T GetValue<T>(string key);
    }
}