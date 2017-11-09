using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post
    {
        public string Id { get; set; }
        public string Content { get; set; }

        public string ImageSource { get; set; }

        public DateTime DatePosted { get; set; }

        public DateTime LastEdited { get; set; }
    }
}
