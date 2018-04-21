using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Helpers
{
    public static class UrlHelper
    {
        public static Uri GetUri(string uriBase, Dictionary<string, string> queryParams)
        {
            var apiUrl = new UriBuilder(uriBase);

            if (queryParams.Any())
            {
                var queryString = new StringBuilder();
                foreach (var p in queryParams)
                {
                    queryString.Append("&")
                        .Append(p.Key)
                        .Append("=")
                        .Append(p.Value);
                }
                apiUrl.Query = queryString.ToString().Substring(1);
            }

            return apiUrl.Uri;
        }
    }
}
