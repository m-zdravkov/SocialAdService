using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcClient.Models
{
    public class PostCommentViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(2048, ErrorMessage = "Comments have to be between {0} and {2} symbols long.", MinimumLength = 2)]
        [DisplayName("Your comment")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}