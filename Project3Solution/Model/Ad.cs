using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Ad : Post
    {
        public Price Price = new Price();

        public ISet<string> Categories { get; set; }
        public string Title { get; set; }

        public DateTime ExpDate { get; set; }

        public int Views { get; set; }


    }
}
