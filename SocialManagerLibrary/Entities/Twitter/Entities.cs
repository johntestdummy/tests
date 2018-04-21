using System.Collections.Generic;

namespace SocialManagerLibrary.Entities.Twitter
{
    public class Entities
    {
        public IList<object> Hashtags { get; set; }
        public IList<object> Symbols { get; set; }
        public IList<object> UserMentions { get; set; }
        public IList<TwUrl> Urls { get; set; }
    }

}
