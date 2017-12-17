using MvcClient.SasPrivate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public class PostAdViewModel
    {
        public string Id { get; set; }
        [StringLength(512, ErrorMessage = "Title must be shorter than {0} symbols.")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Type of ad")]
        public AdType Type { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [StringLength(256, ErrorMessage = "Location must be shorter than {0} symbols.")]
        public string Location { get; set; }
    }
}