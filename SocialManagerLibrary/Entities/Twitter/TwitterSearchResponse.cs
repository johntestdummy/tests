using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialManagerLibrary.Entities.Twitter
{

    public class TwitterSearchResponse
    {
        public IList<Status> Statuses { get; set; }
        public SearchMetadata SearchMetadata { get; set; }
    }

}
