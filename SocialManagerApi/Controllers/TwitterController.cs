﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SocialManagerLibrary;
using Swashbuckle.Swagger.Annotations;

namespace SocialManagerApi.Controllers
{
    public class TwitterController : ApiController
    {
        private IMessagesSearch _messagesSearch;

        public TwitterController(IMessagesSearch messagesSearch)
        {
            _messagesSearch = messagesSearch;
        }

        // GET api/values
        [SwaggerOperation("GetTweets")]
        [Route("v1/tweet/{query}")]
        public HttpResponseMessage GetTweets(string query)
        {
            var tweets = _messagesSearch.GetLast(query, 10);
            var messages = tweets.Select(x => x.Text).ToArray();
            return Request.CreateResponse(HttpStatusCode.OK, messages);
        }

    //    // GET api/values/5
    //    [SwaggerOperation("GetById")]
    //    [SwaggerResponse(HttpStatusCode.OK)]
    //    [SwaggerResponse(HttpStatusCode.NotFound)]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/values
    //    [SwaggerOperation("Create")]
    //    [SwaggerResponse(HttpStatusCode.Created)]
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT api/values/5
    //    [SwaggerOperation("Update")]
    //    [SwaggerResponse(HttpStatusCode.OK)]
    //    [SwaggerResponse(HttpStatusCode.NotFound)]
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE api/values/5
    //    [SwaggerOperation("Delete")]
    //    [SwaggerResponse(HttpStatusCode.OK)]
    //    [SwaggerResponse(HttpStatusCode.NotFound)]
    //    public void Delete(int id)
    //    {
    //    }
    }
}
