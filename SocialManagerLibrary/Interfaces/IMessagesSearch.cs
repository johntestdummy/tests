using SocialManagerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary
{
    public interface IMessagesSearch
    {
        IList<Message> GetLast(string query, short count);
    }
}
