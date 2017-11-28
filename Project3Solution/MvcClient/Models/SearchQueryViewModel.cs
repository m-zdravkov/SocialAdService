using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcClient.Models
{
    public class SearchQueryViewModel
    {
        [Required]
        [StringLength(128, ErrorMessage = "Location should be up to 128 symbols max")]
        [RegularExpression("[^A-Za-z0-9 -]", ErrorMessage = "Only alphanumerical symbols and hyphens allowed")]
        public string Location { get; set; }
        [Required]
        [StringLength(256, ErrorMessage = "Please keep your searches up to 256 symbols")]
        [DisplayName("Search for")]
        public string Query { get; set; }
        /*s[HiddenInput(DisplayValue = false)]
        public int Page { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int ResultsPerPage { get; set; }*/
    }
}