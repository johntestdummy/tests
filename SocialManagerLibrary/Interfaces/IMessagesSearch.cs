using SocialManagerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Interfaces
{
    public interface IMessagesSearch
    {
        IList<Message> GetLast(Query query);
    }
}
