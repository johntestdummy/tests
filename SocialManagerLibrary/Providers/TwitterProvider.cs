using SocialManagerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Providers
{
    public class TwitterProvider : IMessagesSearch
    {
        public IList<Message> GetLast(string query, short count)
        {
            return new List<Message>() {
                new Message() { Author = "Author", Text = "Este es un tweet dummy", Posted = DateTime.Now.AddDays(-4) }
            };            
        }
    }
}
