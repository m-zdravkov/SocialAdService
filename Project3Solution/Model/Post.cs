using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Post
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [StringLength(2048, MinimumLength = 1)]
        public string Content { get; set; }
        [StringLength(512, MinimumLength = 1)]
        public string ImageSource { get; set; }
        [Required]
        public DateTime DatePosted { get; set; }
        public DateTime LastEdited { get; set; }
        [Required]
        public string AuthorId { get; set; }
    }
}
