using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment : Post
    {
        public Post repliedTo { get; set; }

        public int level { get; set; }

        public string comment { get; set; }
    }
}
