using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialManagerApi.Models
{
    public class SearchRequestDto
    {
        [Required, MinLength(1)]
        public string Query { get; set; }

        [Required, Range(1,20)]
        public short Count { get; set; }

    }
}