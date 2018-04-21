using System.Collections.Generic;

namespace SocialManagerLibrary.Entities.Tw
{
    public class Medium
    {
        public long Id { get; set; }
        public string IdStr { get; set; }
        public IList<int> Indices { get; set; }
        public string MediaUrl { get; set; }
        public string MediaUrlHttps { get; set; }
        public string Url { get; set; }
        public string DisplayUrl { get; set; }
        public string ExpandedUrl { get; set; }
        public string Type { get; set; }
        public Sizes Sizes { get; set; }
    }
}
