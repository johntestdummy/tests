using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SocialManagerApi.Filters;
using SocialManagerApi.Models;
using SocialManagerLibrary;
using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Interfaces;
using Swashbuckle.Swagger.Annotations;

namespace SocialManagerApi.Controllers
{
    [ValidateModel]
    public class TwitterController : ApiController
    {
        private readonly IMessagesSearch _tweetsSearch;

        public TwitterController(IMessagesSearch tweetsSearch)
        {
            _tweetsSearch = tweetsSearch;
        }

        [HttpGet]
        [Route("v1/tweet/search")]
        [SwaggerOperation("GetTweets")]
        public HttpResponseMessage GetTweets([FromUri]SearchRequestDto request)
        {
            try
            {
                var tweets = _tweetsSearch.GetLast(new Query()
                {
                    Term = request.Query,
                    Count = request.Count
                });

                if (tweets == null)
                    return Request.CreateResponse(HttpStatusCode.NoContent);

                return Request.CreateResponse(HttpStatusCode.OK, tweets);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ha habido un error procesando la peticion");
            }

        }

    }
}
