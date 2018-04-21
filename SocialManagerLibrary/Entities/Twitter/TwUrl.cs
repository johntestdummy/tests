using System.Collections.Generic;

namespace SocialManagerLibrary.Entities.Twitter
{
    public class TwUrl
    {
        public string Url { get; set; }
        public string ExpandedUrl { get; set; }
        public string DisplayUrl { get; set; }
        public IList<int> Indices { get; set; }
    }

}
