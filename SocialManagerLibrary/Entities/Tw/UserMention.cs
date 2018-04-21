using System.Collections.Generic;

namespace SocialManagerLibrary.Entities.Tw
{
    public class UserMention
    {
        public string ScreenName { get; set; }
        public string Name { get; set; }
        public object Id { get; set; }
        public string IdStr { get; set; }
        public IList<int> Indices { get; set; }
    }
}
