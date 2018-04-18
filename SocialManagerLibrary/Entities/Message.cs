using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Entities
{
    public class Message
    {
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
    }
}
