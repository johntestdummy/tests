using System.Collections.Generic;

namespace SocialManagerLibrary.Entities.Tw
{
    public class Entities
    {
        public IList<object> Hashtags { get; set; }
        public IList<object> Symbols { get; set; }
        public IList<UserMention> UserMentions { get; set; }
        public IList<TwUrl> Urls { get; set; }
        public IList<Medium> Media { get; set; }
    }
}
